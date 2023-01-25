using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Squid;

public class _abqs0UynzjUEhuA3VpR4t6Uuk0E : _1dTaaW9MQWoHm2Pqblg0u9bPhpe
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
			if (string.IsNullOrEmpty(Text))
			{
				Overlap = Vector2.Zero;
			}
			else
			{
				Overlap = Font.MeasureString(Text);
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

	public override void _eJedLbGgSejIX7Xyx6RoIYD1soJA()
	{
	}

	public override void Draw(SpriteBatch spriteBatch_0)
	{
		if (!string.IsNullOrEmpty(Text))
		{
			switch (Gravity)
			{
			case Alignment.MiddleRight:
				Location.X = (float)base.X - Overlap.X;
				Location.Y = (float)base.Y + ((float)_2psWLw4AI8EIjQzaXnhGg8M1FnaA.Height - Overlap.Y) / 2f;
				break;
			default:
				Location.X = (float)base.X + ((float)_2psWLw4AI8EIjQzaXnhGg8M1FnaA.Width - Overlap.X) / 2f;
				Location.Y = (float)base.Y + ((float)_2psWLw4AI8EIjQzaXnhGg8M1FnaA.Height - Overlap.Y) / 2f;
				break;
			case Alignment.MiddleLeft:
				Location.X = base.X;
				Location.Y = (float)base.Y + ((float)_2psWLw4AI8EIjQzaXnhGg8M1FnaA.Height - Overlap.Y) / 2f;
				break;
			}
			spriteBatch_0.DrawString(Font, Text, Location, Color);
		}
	}
}
