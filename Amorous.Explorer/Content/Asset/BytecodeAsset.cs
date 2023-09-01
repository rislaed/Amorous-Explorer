using System;
using System.IO;
using System.IO.Compression;

namespace Amorous.Explorer.Content.Asset;

public abstract class BytecodeAsset : AbstractAsset
{
	public override void HandleToFile(string path, string assetName, object asset, XnbHeader elf)
	{
		base.HandleToFile(path, assetName, asset, elf);
		ReadContent(path, assetName, asset, elf);
	}

	protected virtual void ReadContent(string path, string assetName, object asset, XnbHeader elf)
	{
		if (elf == null || elf.LZ4 || elf.LZX)
		{
			throw new ArgumentException("Unsupported Xnb bytecode, reading interrupted!");
		}
		using (BytecodeBinaryReader reader = new BytecodeBinaryReader(
			Compressions.ReadStream(File.OpenRead(elf.Path))
		))
		{
			reader.ReadBytes(XnbHeader.LENGTH);
			int size = reader.ReadInt32();
			try
			{
				if (size != reader.BaseStream.Length)
				{
					throw new ArgumentOutOfRangeException($"Xnb length mismatched with bytecode ({size} != {reader.BaseStream.Length})!");
				}
			}
			catch (NotSupportedException ex)
			{
				if (reader.BaseStream.GetType() != typeof(GZipStream))
				{
					throw ex;
				}
			}
			int count = reader.Read7BitEncodedInt(); // of readers
			for (int i = 0; i < count; i++)
			{
				reader.ReadString(); // content type
				reader.ReadInt32(); // content version
			}
			reader.Read7BitEncodedInt(); // shared resources
			reader.Read7BitEncodedInt(); // currently reader index
			HandleBytecode(path, assetName, reader, asset, elf);
			if (count > 1)
			{
				while (reader.Read() != -1) {} // consume unexpected readers
			}
			if (reader.Read() != -1)
			{
				throw new InvalidOperationException("Bytecode reader produced additional input, it must consumed by handle!");
			}
		}
	}

	public abstract void HandleBytecode(string path, string assetName, BytecodeBinaryReader reader, object asset, XnbHeader elf);
}
