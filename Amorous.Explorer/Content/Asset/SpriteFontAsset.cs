using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Amorous.Explorer.Content.Asset;

public class SpriteFontAsset : AbstractAsset
{
	public override bool CanHandle(object asset)
	{
		return asset is SpriteFont;
	}

	public override void HandleToFile(string path, string assetName, object asset, XnbHeader elf)
	{
		SpriteFont font = (SpriteFont)asset;
		base.HandleToFile(path, assetName, asset, elf);
		Vector2 bounds;
		try
		{
			bounds = font.MeasureString(GetType().Name);
		}
		catch (ArgumentException)
		{
			bounds = Vector2.Zero;
		}
		Logger.Debug("Exporting font {0} ({1}x{2}, {3} characters)", assetName, bounds.X, bounds.Y, font.Characters.Count);
		List<Rectangle> glyphs;
		try
		{
			glyphs = (List<Rectangle>)typeof(SpriteFont)
				.GetMethod("GetGlyphs", BindingFlags.Instance | BindingFlags.Public)
				.Invoke(font, new object[0]);
		}
		catch (NullReferenceException)
		{
			glyphs = (List<Rectangle>)typeof(SpriteFont)
				.GetField("glyphData", BindingFlags.Instance | BindingFlags.NonPublic)
				.GetValue(font);
		}
		object json = new
		{
			font.LineSpacing,
			font.Spacing,
			font.DefaultCharacter,
			font.Characters,
			Glyphs = glyphs
		};
		File.WriteAllText($"{path}.json", ImperativeJsonConvert.SerializeObject(json));
		Texture2D texture;
		try
		{
			texture = (Texture2D)typeof(SpriteFont)
				.GetField("Texture", BindingFlags.Instance | BindingFlags.Public)
				.GetValue(font);
		}
		catch (NullReferenceException)
		{
			texture = (Texture2D)typeof(SpriteFont)
				.GetField("textureValue", BindingFlags.Instance | BindingFlags.NonPublic)
				.GetValue(font);
		}
		if (texture == null)
		{
			Logger.Warning("Corresponding sprite not found or empty, nothing to do!");
			return;
		}
		new TextureAsset().HandleToFile(path, assetName, texture, elf);
	}
}
