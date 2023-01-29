using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public abstract class AbstractInteractable
{ // _1dTaaW9MQWoHm2Pqblg0u9bPhpe
	public Vector2 Location;
	public Color Color;
	public Rectangle Bounds;

	public int X
	{
		get
		{
			return (int)Location.X;
		}
		set
		{
			Location.X = value;
			Bounds.X = value;
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
			Bounds.Y = value;
		}
	}

	public bool Hovered { get; private set; }
	public bool Visible { get; set; }

	protected AbstractInteractable()
	{
		Color = Color.White;
		Visible = true;
	}

	public abstract void Click();

	public virtual void Hover()
	{
		Hovered = true;
	}

	public virtual void Unhover()
	{
		Hovered = false;
	}

	public abstract void Draw(SpriteBatch spriteBatch);
}
