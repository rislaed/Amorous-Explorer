using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class ButtonInteractable : SpriteInteractable
{ // _iHJrndJdM1jj9TEnuU3BvgdDuvf
	private string text;
	private Vector2 bounds;
	private Vector2 location;

	public SpriteFont Font { get; private set; }

	public string Text
	{
		get
		{
			return text;
		}
		set
		{
			text = value;
			if (!string.IsNullOrEmpty(text))
			{
				bounds = Font.MeasureString(text);
			}
			else
			{
				bounds = Vector2.Zero;
			}
		}
	}

	public ButtonInteractable(Texture2D foreground, Texture2D background, SpriteFont font, string text, Color color, Action click) : base(foreground, background, click)
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
			location.X = (float)base.X + ((float)Bounds.Width - bounds.X) / 2f;
			location.Y = (float)base.Y + ((float)Bounds.Height - bounds.Y) / 2f;
			spriteBatch.DrawString(Font, Text, location, Color);
		}
	}
}
