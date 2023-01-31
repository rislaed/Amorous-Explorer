using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Squid;

public class SquidRenderer : IDisposable, ISquidRenderer
{ // _k8LAl8bPyzLGEpo59dKFGU4sCQ
	private readonly Dictionary<int, SpriteFont> _fonts = new Dictionary<int, SpriteFont>();
	private readonly Dictionary<int, Texture2D> _textures = new Dictionary<int, Texture2D>();
	private readonly Dictionary<string, int> _fontPathes = new Dictionary<string, int>();
	private readonly Dictionary<string, int> _texturePathes = new Dictionary<string, int>();
	private readonly Game _game;
	private readonly SpriteBatch _batch;
	private readonly Texture2D _foreground;
	private readonly RasterizerState _rasterizer;
	private readonly string _fontName = "Assets/Gui/Fonts/Bold-14";
	private int _index;
	private SpriteFont _font;
	private Texture2D _texture;

	public SquidRenderer(Game game)
	{
		_game = game;
		_batch = new SpriteBatch(game.GraphicsDevice);
		_foreground = new Texture2D(_game.GraphicsDevice, 1, 1);
		_foreground.SetData(new Color[1]
		{
			new Color(255, 255, 255, 255)
		});
		_rasterizer = new RasterizerState
		{
			ScissorTestEnable = true
		};
		_texturePathes.Add(string.Empty, 0);
		_textures.Add(0, _foreground);
	}

	private Color ExtractColor(int bits)
	{
		byte[] bytes = BitConverter.GetBytes(bits);
		return new Color((float)(int)bytes[2] / 255f, (float)(int)bytes[1] / 255f, (float)(int)bytes[0] / 255f) * ((float)(int)bytes[3] / 255f);
	}

	public int GetTexture(string name)
	{
		if (_texturePathes.TryGetValue(name ?? string.Empty, out _index))
		{
			return _index;
		}
		Texture2D texture = _game.Content.Load<Texture2D>(Path.GetDirectoryName(name) + "/" + Path.GetFileNameWithoutExtension(name));
		int index = _texturePathes.Count;
		_texturePathes.Add(name, index);
		_textures.Add(index, texture);
		return index;
	}

	public void SetTexture(string name, object texture)
	{
		if (_texturePathes.TryGetValue(name, out _index))
		{
			_textures[_index] = (Texture2D)texture;
			return;
		}
		int index = _texturePathes.Count;
		_texturePathes.Add(name, index);
		_textures.Add(index, (Texture2D)texture);
	}

	public int GetFont(string name)
	{
		if (name == "default")
		{
			name = _fontName;
		}
		if (!_fontPathes.TryGetValue(name, out _index))
		{
			SpriteFont value = _game.Content.Load<SpriteFont>(name);
			int count = _fontPathes.Count;
			_fontPathes.Add(name, count);
			_fonts.Add(count, value);
			return count;
		}
		return _index;
	}

	public Squid.Point GetTextSize(string text, int font)
	{
		if (string.IsNullOrEmpty(text))
		{
			return Squid.Point.Zero;
		}
		if (_fonts.TryGetValue(font, out _font))
		{
			Vector2 vector = _font.MeasureString(text);
			return new Squid.Point((int)vector.X, (int)vector.Y);
		}
		return Squid.Point.Zero;
	}

	public Squid.Point GetTextureSize(int texture)
	{
		if (_textures.TryGetValue(texture, out _texture))
		{
			return new Squid.Point(_texture.Width, _texture.Height);
		}
		return Squid.Point.Zero;
	}

	public void DrawBox(int x, int y, int w, int h, int color)
	{
		_batch.Draw(_foreground, new Microsoft.Xna.Framework.Rectangle(x, y, w, h), ExtractColor(color));
	}

	public void DrawText(string text, int x, int y, int font, int color)
	{
		if (_fonts.TryGetValue(font, out _font))
		{
			_batch.DrawString(_font, text, new Vector2(x, y), ExtractColor(color));
		}
	}

	public void DrawTexture(int texture, int x, int y, int w, int h, Squid.Rectangle rect, int color)
	{
		if (_textures.TryGetValue(texture, out _texture))
		{
			_batch.Draw(_texture, new Microsoft.Xna.Framework.Rectangle(x, y, w, h), new Microsoft.Xna.Framework.Rectangle(rect.Left, rect.Top, rect.Width, rect.Height), ExtractColor(color), 0f, Vector2.Zero, SpriteEffects.None, 0f);
		}
	}

	public void Scissor(int x, int y, int w, int h)
	{
		_game.GraphicsDevice.ScissorRectangle = new Microsoft.Xna.Framework.Rectangle(x, y, w, h);
	}

	public void StartBatch()
	{
		_batch.Begin(SpriteSortMode.Deferred, null, null, null, _rasterizer);
	}

	public void EndBatch(bool final)
	{
		_batch.End();
	}

	public void Dispose() {}
}
