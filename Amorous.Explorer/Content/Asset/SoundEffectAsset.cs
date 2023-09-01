using System;
using System.IO;
using Microsoft.Xna.Framework.Audio;

namespace Amorous.Explorer.Content.Asset;

public class SoundEffectAsset : BytecodeAsset
{
	private static readonly char[] RIFF = "RIFF".ToCharArray();
	private static readonly char[] WAVE = "WAVE".ToCharArray();
	private static readonly char[] FMT = "fmt ".ToCharArray();
	private static readonly char[] DATA = "data".ToCharArray();

	public override bool CanHandle(object asset)
	{
		return asset is SoundEffect;
	}

	public override void HandleBytecode(string path, string assetName, BytecodeBinaryReader reader, object asset, XnbHeader elf)
	{
		uint formatChunkSize = reader.ReadUInt32();
		ushort formatType = reader.ReadUInt16();
		ushort channels = reader.ReadUInt16();
		uint sampleRate = reader.ReadUInt32();
		reader.ReadUInt32(); // originally ignored byte rate
		ushort blockAlign = reader.ReadUInt16();
		ushort bitsPerSample = reader.ReadUInt16();
		reader.ReadUInt16(); // xnb must contain extra chunk size
		byte[] extraChunk = reader.ReadBytes((int)(formatChunkSize - 18));
		byte[] data = reader.ReadBytes(reader.ReadInt32());
		reader.ReadUInt32(); // looping start
		reader.ReadUInt32(); // looping length
		reader.ReadUInt32(); // looping duration

		Logger.Debug("Exporting sound effect {0} ({1}ms)", assetName, ((SoundEffect)asset).Duration.TotalMilliseconds);

		if (formatType == 1)
		{
			formatChunkSize -= 2;
			if (formatChunkSize > 16)
			{
				throw new ArgumentException($"Wave PCM contains extra block (length {formatChunkSize - 16}), which is not supported here!");
			}
		}

		using (BytecodeBinaryWriter target = new BytecodeBinaryWriter(File.OpenWrite($"{path}.wav")))
		{
			target.Write(RIFF);
			target.Write((int)(20 + formatChunkSize + data.Length));
			target.Write(WAVE);

			target.Write(FMT);
			target.Write(formatChunkSize);
			target.Write(formatType);
			target.Write(channels);
			target.Write(sampleRate);
			target.Write(sampleRate * channels * bitsPerSample / 8);
			target.Write(blockAlign);
			target.Write(bitsPerSample);

			if (formatType != 1)
			{
				target.Write(extraChunk.Length);
				target.Write(extraChunk);
			}

			target.Write(DATA);
			target.Write(data.Length);
			target.Write(data);
		}
	}
}
