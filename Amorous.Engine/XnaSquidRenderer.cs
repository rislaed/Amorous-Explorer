using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Squid;

public class XnaSquidRenderer : IDisposable, ISquidRenderer
{ // _k8LAl8bPyzLGEpo59dKFGU4sCQ
	private readonly Dictionary<int, SpriteFont> loadedFonts = new Dictionary<int, SpriteFont>();
	private readonly Dictionary<int, Texture2D> loadedTextures = new Dictionary<int, Texture2D>();
	private readonly Dictionary<string, int> loadedFontPathes = new Dictionary<string, int>();
	private readonly Dictionary<string, int> loadedTexturePathes = new Dictionary<string, int>();
	private readonly Game game;
	private readonly SpriteBatch spriteBatch;
	private readonly Texture2D fallback;
	private readonly RasterizerState rasterizerState;
	private readonly string fallbackFontAssetName = "Assets/Gui/Fonts/Bold-14";
	private int internalIndex;
	private SpriteFont internalFont;
	private Texture2D internalTexture;

	public XnaSquidRenderer(Game game)
	{
		this.game = game;
		spriteBatch = new SpriteBatch(game.GraphicsDevice);
        fallback = new Texture2D(this.game.GraphicsDevice, 1, 1);
		fallback.SetData(new Color[1]
		{
			new Color(255, 255, 255, 255)
		});
		rasterizerState = new RasterizerState
		{
			ScissorTestEnable = true
		};
		loadedTexturePathes.Add(string.Empty, 0);
		loadedTextures.Add(0, fallback);
	}

	private Color ExtractColor(int bits)
	{
		byte[] bytes = BitConverter.GetBytes(bits);
		return new Color((float)(int)bytes[2] / 255f, (float)(int)bytes[1] / 255f, (float)(int)bytes[0] / 255f) * ((float)(int)bytes[3] / 255f);
	}

	public int GetTexture(string name)
	{
		if (loadedTexturePathes.TryGetValue(name ?? string.Empty, out internalIndex))
		{
			return internalIndex;
		}
		Texture2D texture = game.Content.Load<Texture2D>(Path.GetDirectoryName(name) + "/" + Path.GetFileNameWithoutExtension(name));
		int index = loadedTexturePathes.Count;
		loadedTexturePathes.Add(name, index);
		loadedTextures.Add(index, texture);
		return index;
	}

	public void SetTexture(string name, object texture)
	{
		if (loadedTexturePathes.TryGetValue(name, out internalIndex))
		{
			loadedTextures[internalIndex] = (Texture2D)texture;
			return;
		}
		int index = loadedTexturePathes.Count;
		loadedTexturePathes.Add(name, index);
		loadedTextures.Add(index, (Texture2D)texture);
	}

	public int GetFont(string name)
	{
		if (name == "default")
		{
			name = fallbackFontAssetName;
		}
		if (!loadedFontPathes.TryGetValue(name, out internalIndex))
		{
			SpriteFont value = game.Content.Load<SpriteFont>(name);
			int count = loadedFontPathes.Count;
			loadedFontPathes.Add(name, count);
			loadedFonts.Add(count, value);
			return count;
		}
		return internalIndex;
	}

	public Squid.Point GetTextSize(string text, int font)
	{
		if (string.IsNullOrEmpty(text))
		{
			return Squid.Point.Zero;
		}
		if (loadedFonts.TryGetValue(font, out internalFont))
		{
			Vector2 vector = internalFont.MeasureString(text);
			return new Squid.Point((int)vector.X, (int)vector.Y);
		}
		return Squid.Point.Zero;
	}

	public Squid.Point GetTextureSize(int texture)
	{
		if (loadedTextures.TryGetValue(texture, out internalTexture))
		{
			return new Squid.Point(internalTexture.Width, internalTexture.Height);
		}
		return Squid.Point.Zero;
	}

	public void DrawBox(int x, int y, int w, int h, int color)
	{
		spriteBatch.Draw(fallback, new Microsoft.Xna.Framework.Rectangle(x, y, w, h), ExtractColor(color));
	}

	public void DrawText(string text, int x, int y, int font, int color)
	{
		if (loadedFonts.TryGetValue(font, out internalFont))
		{
			spriteBatch.DrawString(internalFont, text, new Vector2(x, y), ExtractColor(color));
		}
	}

	public void DrawTexture(int texture, int x, int y, int w, int h, Squid.Rectangle rect, int color)
	{
		if (loadedTextures.TryGetValue(texture, out internalTexture))
		{
			spriteBatch.Draw(internalTexture, new Microsoft.Xna.Framework.Rectangle(x, y, w, h), new Microsoft.Xna.Framework.Rectangle(rect.Left, rect.Top, rect.Width, rect.Height), ExtractColor(color), 0f, Vector2.Zero, SpriteEffects.None, 0f);
		}
	}

	public void Scissor(int x, int y, int w, int h)
	{
		game.GraphicsDevice.ScissorRectangle = new Microsoft.Xna.Framework.Rectangle(x, y, w, h);
	}

	public void StartBatch()
	{
		spriteBatch.Begin(SpriteSortMode.Deferred, null, null, null, rasterizerState);
	}

	public void EndBatch(bool final)
	{
		spriteBatch.End();
	}

	public void Dispose() {}
}
