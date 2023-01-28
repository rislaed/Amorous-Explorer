using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public abstract class _1dTaaW9MQWoHm2Pqblg0u9bPhpe
{
	public Vector2 Location;
	public Color Color;
	public Rectangle _2psWLw4AI8EIjQzaXnhGg8M1FnaA;

	public int X
	{
		get
		{
			return (int)Location.X;
		}
		set
		{
			Location.X = value;
			_2psWLw4AI8EIjQzaXnhGg8M1FnaA.X = value;
		}
	}

	public int Y
	{
		get
		{
			return (int)Location.Y;
		}
		set
		{
			Location.Y = value;
			_2psWLw4AI8EIjQzaXnhGg8M1FnaA.Y = value;
		}
	}

	public bool _NUP8Fs8I7oMuI6vfg25DFKFlQqE { get; private set; }

	public bool Visible { get; set; }

	protected _1dTaaW9MQWoHm2Pqblg0u9bPhpe()
	{
		Color = Color.White;
		Visible = true;
	}

	public abstract void _eJedLbGgSejIX7Xyx6RoIYD1soJA();

	public virtual void _4xz3iE0ff4Zjl6ybnWxczeMPKyB()
	{
		_NUP8Fs8I7oMuI6vfg25DFKFlQqE = true;
	}

	public virtual void _TVKS7kokuGdoU8kMxQQPKABgo4c()
	{
		_NUP8Fs8I7oMuI6vfg25DFKFlQqE = false;
	}

	public abstract void Draw(SpriteBatch spriteBatch);
}
