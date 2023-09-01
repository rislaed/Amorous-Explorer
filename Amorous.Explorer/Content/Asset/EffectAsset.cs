using System;
using System.IO;
using Microsoft.Xna.Framework.Graphics;

namespace Amorous.Explorer.Content.Asset;

public class EffectAsset : BytecodeAsset
{
	public override bool CanHandle(object asset)
	{
		return asset is Effect;
	}

	public override void HandleBytecode(string path, string assetName, BytecodeBinaryReader reader, object asset, XnbHeader elf)
	{
		Logger.Debug("Exporting effect {0} ({1})", assetName, ((Effect)asset).CurrentTechnique?.Name);
		using (Stream target = File.OpenWrite($"{path}.fxb"))
		{
			int count = reader.ReadInt32();
			byte[] bytes = reader.ReadBytes(count);
			target.Write(bytes, 0, bytes.Length);
		}
	}
}
