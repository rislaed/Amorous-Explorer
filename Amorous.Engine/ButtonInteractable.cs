using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class ButtonInteractable : SpriteInteractable
{ // _iHJrndJdM1jj9TEnuU3BvgdDuvf
	private string _text;
	private Vector2 _overlap;
	private Vector2 _location;

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
				_overlap = Font.MeasureString(_text);
			}
			else
			{
				_overlap = Vector2.Zero;
			}
		}
	}

	public ButtonInteractable(Texture2D foreground, Texture2D background, SpriteFont font, string text, Color color, Action click)
		: base(foreground, background, click)
	{
		Font = font;
		Text = text;
		Color = color;
	}

	public override void Draw(SpriteBatch spriteBatch)
	{
		base.Draw(spriteBatch);
		if (!string.IsNullOrEmpty(Text))
		{
			_location.X = (float)base.X + ((float)Bounds.Width - _overlap.X) / 2f;
			_location.Y = (float)base.Y + ((float)Bounds.Height - _overlap.Y) / 2f;
			spriteBatch.DrawString(Font, Text, _location, Color);
		}
	}
}
