using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class _iHJrndJdM1jj9TEnuU3BvgdDuvf : _d4ad1i8rcZMvfN9iaxggA1KtVgx
{
	private string _text;
	private Vector2 Overlap;
	private Vector2 AbsoluteLocation;
	public SpriteFont Font { get; private set; }

	public string Text
	{
		get
		{
			return _text;
		}
		set
		{
			_text = value;
			if (!string.IsNullOrEmpty(_text))
			{
				Overlap = Font.MeasureString(_text);
			}
			else
			{
				Overlap = Vector2.Zero;
			}
		}
	}

	public _iHJrndJdM1jj9TEnuU3BvgdDuvf(Texture2D texture2D_0, Texture2D texture2D_1, SpriteFont spriteFont_0, string string_0, Color color_0, Action action_0)
		: base(texture2D_0, texture2D_1, action_0)
	{
		Font = spriteFont_0;
		Text = string_0;
		Color = color_0;
	}

	public override void Draw(SpriteBatch spriteBatch)
	{
		base.Draw(spriteBatch);
		if (!string.IsNullOrEmpty(Text))
		{
			AbsoluteLocation.X = (float)base.X + ((float)_2psWLw4AI8EIjQzaXnhGg8M1FnaA.Width - Overlap.X) / 2f;
			AbsoluteLocation.Y = (float)base.Y + ((float)_2psWLw4AI8EIjQzaXnhGg8M1FnaA.Height - Overlap.Y) / 2f;
			spriteBatch.DrawString(Font, Text, AbsoluteLocation, Color);
		}
	}
}
