using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Squid;

public class TextInteractable : AbstractInteractable
{ // _abqs0UynzjUEhuA3VpR4t6Uuk0E
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
			if (string.IsNullOrEmpty(text))
			{
				bounds = Vector2.Zero;
			}
			else
			{
				bounds = Font.MeasureString(text);
			}
		}
	}

	public Alignment Gravity { get; set; }

	public TextInteractable(SpriteFont font, string text, Color color)
	{
		Font = font;
		Text = text;
		Color = color;
	}

	public override void Click() {}

	public override void Draw(SpriteBatch spriteBatch)
	{
		if (!string.IsNullOrEmpty(Text))
		{
			switch (Gravity)
			{
				case Alignment.MiddleRight:
					location.X = (float)base.X - bounds.X;
					location.Y = (float)base.Y + ((float)Bounds.Height - bounds.Y) / 2f;
					break;
				default:
					location.X = (float)base.X + ((float)Bounds.Width - bounds.X) / 2f;
					location.Y = (float)base.Y + ((float)Bounds.Height - bounds.Y) / 2f;
					break;
				case Alignment.MiddleLeft:
					location.X = base.X;
					location.Y = (float)base.Y + ((float)Bounds.Height - bounds.Y) / 2f;
					break;
			}
			spriteBatch.DrawString(Font, Text, location, Color);
		}
	}
}
