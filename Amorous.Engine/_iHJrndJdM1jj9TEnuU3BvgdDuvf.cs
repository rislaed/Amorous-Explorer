using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class _iHJrndJdM1jj9TEnuU3BvgdDuvf : _d4ad1i8rcZMvfN9iaxggA1KtVgx
{
	private string Text;

	private Vector2 Overlap;

	private Vector2 Location;

	public SpriteFont Font { get; private set; }

	public string Text
	{
		get
		{
			return Text;
		}
		set
		{
			Text = value;
			if (!string.IsNullOrEmpty(Text))
			{
				Overlap = Font.MeasureString(Text);
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

	public override void Draw(SpriteBatch spriteBatch_0)
	{
		base.Draw(spriteBatch_0);
		if (!string.IsNullOrEmpty(Text))
		{
			Location.X = (float)base.X + ((float)_2psWLw4AI8EIjQzaXnhGg8M1FnaA.Width - Overlap.X) / 2f;
			Location.Y = (float)base.Y + ((float)_2psWLw4AI8EIjQzaXnhGg8M1FnaA.Height - Overlap.Y) / 2f;
			spriteBatch_0.DrawString(Font, Text, Location, Color);
		}
	}
}
