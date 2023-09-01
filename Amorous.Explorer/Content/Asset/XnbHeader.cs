using System;
using System.IO;

namespace Amorous.Explorer.Content.Asset;

public sealed class InvalidXnbHeader : Exception
{
	public InvalidXnbHeader() : this("Invalid or mismatched header, asset is not supported!") {}
	public InvalidXnbHeader(string message) : base(message) {}
	public InvalidXnbHeader(string message, Exception inner) : base(message, inner) {}
}

public sealed class XnbHeader
{
	public static readonly int LENGTH = 6;
	public static readonly byte HIDEF_MASK = 0x1;
	public static readonly byte LZ4_MASK = 0x40;
	public static readonly byte LZX_MASK = 0x80;

	public enum EPlatform : int
	{
		Windows = 'w',
		Xbox = 'x',
		Android = 'a',
		iOS = 'i',
		Unknown
	}

	public enum EFramework : byte
	{
		Xna30 = 0x3,
		Xna31 = 0x4,
		Xna40 = 0x5,
		Unknown
	}

	public readonly EPlatform Platform;
	public readonly EFramework Framework;
	public readonly bool HiDef, LZ4, LZX;
	public readonly string Path;

	public XnbHeader(string path, char platform, byte framework, byte flags)
	{
		if (string.IsNullOrEmpty(path))
		{
			throw new ArgumentNullException("path");
		}
		Path = path;
		platform = char.ToLowerInvariant(platform);
		try
		{
			Platform = (EPlatform)Enum.Parse(
				typeof(EPlatform),
				Enum.GetName(typeof(EPlatform), (int)platform)
			);
		}
		catch (ArgumentException)
		{
			Logger.Warning("No such supported platform {0} found!", platform);
			Platform = EPlatform.Unknown;
		}
		try
		{
			Framework = (EFramework)Enum.Parse(
				typeof(EFramework),
				Enum.GetName(typeof(EFramework), framework)
			);
		}
		catch (ArgumentException)
		{
			Logger.Warning("No such supported framework {0} found!", framework);
			Framework = EFramework.Unknown;
		}
		HiDef = (flags & HIDEF_MASK) != 0;
		LZ4 = (flags & LZ4_MASK) != 0;
		LZX = (flags & LZX_MASK) != 0;
	}

	public static XnbHeader Of(string path)
	{
		try
		{
			using (Stream stream = Compressions.ReadStream(File.OpenRead(path)))
			{
				byte[] header = new byte[LENGTH];
				stream.Read(header, 0, header.Length);
				if (header[0] != 'X' || header[1] != 'N' || header[2] != 'B')
				{
					throw new InvalidXnbHeader();
				}
				return new XnbHeader(path, (char)header[3], header[4], header[5]);
			}
		}
		catch (FileNotFoundException)
		{
			if (System.IO.Path.GetExtension(path) != ".xnb")
			{
				return Of(System.IO.Path.ChangeExtension(path, ".xnb"));
			}
		}
		throw new InvalidXnbHeader($"Not found: {path}!");
	}
}
