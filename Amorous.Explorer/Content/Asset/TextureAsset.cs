using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Amorous.Explorer.Content.Asset;

public class TextureAsset : AbstractAsset
{
	public override bool CanHandle(object asset)
	{
		return asset is Texture2D;
	}

	public override void HandleToFile(string path, string assetName, object asset, XnbHeader elf)
	{
		Texture2D texture = (Texture2D)asset;
		base.HandleToFile(path, assetName, asset, elf);
		Logger.Debug("Exporting texture {0} ({1}x{2}#{3})", assetName, texture.Width, texture.Height, Enum.GetName(typeof(SurfaceFormat), texture.Format));
		if (texture.Format == SurfaceFormat.Dxt3)
		{
			texture = RenderToTarget(texture, texture.GraphicsDevice);
		}
		UnpremultiplyTransparency(texture);
		using (Stream stream = File.Create($"{path}.png"))
		{
			texture.SaveAsPng(stream, texture.Width, texture.Height);
		}
	}

	private static void UnpremultiplyTransparency(Texture2D texture)
	{
		Color[] pixels = new Color[texture.Width * texture.Height];
		texture.GetData(pixels);
		for (int i = 0; i < pixels.Length; i++)
		{
			Color pixel = pixels[i];
			if (pixel.A == 0)
			{
				continue;
			}
			pixel.R = (byte)((pixel.R * 255) / pixel.A);
			pixel.G = (byte)((pixel.G * 255) / pixel.A);
			pixel.B = (byte)((pixel.B * 255) / pixel.A);
		}
		texture.SetData(pixels);
	}

	private static RenderTarget2D RenderToTarget(Texture2D texture, GraphicsDevice graphics)
	{
		RenderTargetBinding[] targets = graphics.GetRenderTargets();
		RenderTarget2D target = new RenderTarget2D(graphics, texture.Width, texture.Height);
		graphics.SetRenderTarget(target);
		try
		{
			graphics.Clear(Color.Transparent);
			using SpriteBatch batch = new SpriteBatch(graphics);
			batch.Begin();
			batch.Draw(texture, Vector2.Zero, Color.White);
			batch.End();
		}
		finally
		{
			graphics.SetRenderTargets(targets);
		}
		return target;
	}
}
