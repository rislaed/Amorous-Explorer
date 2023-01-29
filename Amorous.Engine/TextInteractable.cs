using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Squid;

public class TextInteractable : AbstractInteractable
{ // _abqs0UynzjUEhuA3VpR4t6Uuk0E
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
			if (string.IsNullOrEmpty(_text))
			{
				_overlap = Vector2.Zero;
			}
			else
			{
				_overlap = Font.MeasureString(_text);
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
					_location.X = (float)base.X - _overlap.X;
					_location.Y = (float)base.Y + ((float)Bounds.Height - _overlap.Y) / 2f;
					break;
				default:
					_location.X = (float)base.X + ((float)Bounds.Width - _overlap.X) / 2f;
					_location.Y = (float)base.Y + ((float)Bounds.Height - _overlap.Y) / 2f;
					break;
				case Alignment.MiddleLeft:
					_location.X = base.X;
					_location.Y = (float)base.Y + ((float)Bounds.Height - _overlap.Y) / 2f;
					break;
			}
			spriteBatch.DrawString(Font, Text, _location, Color);
		}
	}
}
