using System;
using System.IO;
using Microsoft.Xna.Framework.Media;

namespace Amorous.Explorer.Content.Asset;

public class SongAsset : BytecodeAsset
{
	public override bool CanHandle(object asset)
	{
		return asset is Song;
	}

	public override void HandleToFile(string path, string assetName, object asset, XnbHeader elf)
	{
		ReadContent(path, assetName, asset, elf);
	}

	public override void HandleBytecode(string path, string assetName, BytecodeBinaryReader reader, object asset, XnbHeader elf)
	{
		string filename = reader.ReadString();
		if (Path.GetFileNameWithoutExtension(path) != Path.GetFileNameWithoutExtension(filename))
		{
			Logger.Warning("Song filename {0} mismatched with self pointer {1}!", assetName, filename);
		}
		else
		{
			Logger.Debug("Exporting song {0} ({1}, {2}s)", assetName, filename, (int)((Song)asset).Duration.TotalSeconds);
		}
		reader.ReadInt32(); // duration (unused in framework)
	}
}
