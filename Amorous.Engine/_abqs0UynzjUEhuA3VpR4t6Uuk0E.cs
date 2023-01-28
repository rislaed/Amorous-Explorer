using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Squid;

public class _abqs0UynzjUEhuA3VpR4t6Uuk0E : _1dTaaW9MQWoHm2Pqblg0u9bPhpe
{
	private string _text;
	private Vector2 _overlap;
	private Vector2 _absoluteLocation;

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

	public _abqs0UynzjUEhuA3VpR4t6Uuk0E(SpriteFont spriteFont_0, string string_0, Color color_0)
	{
		Font = spriteFont_0;
		Text = string_0;
		Color = color_0;
	}

	public override void _eJedLbGgSejIX7Xyx6RoIYD1soJA() {}

	public override void Draw(SpriteBatch spriteBatch)
	{
		if (!string.IsNullOrEmpty(Text))
		{
			switch (Gravity)
			{
				case Alignment.MiddleRight:
					_absoluteLocation.X = (float)base.X - _overlap.X;
					_absoluteLocation.Y = (float)base.Y + ((float)_2psWLw4AI8EIjQzaXnhGg8M1FnaA.Height - _overlap.Y) / 2f;
					break;
				default:
					_absoluteLocation.X = (float)base.X + ((float)_2psWLw4AI8EIjQzaXnhGg8M1FnaA.Width - _overlap.X) / 2f;
					_absoluteLocation.Y = (float)base.Y + ((float)_2psWLw4AI8EIjQzaXnhGg8M1FnaA.Height - _overlap.Y) / 2f;
					break;
				case Alignment.MiddleLeft:
					_absoluteLocation.X = base.X;
					_absoluteLocation.Y = (float)base.Y + ((float)_2psWLw4AI8EIjQzaXnhGg8M1FnaA.Height - _overlap.Y) / 2f;
					break;
			}
			spriteBatch.DrawString(Font, Text, _absoluteLocation, Color);
		}
	}
}
