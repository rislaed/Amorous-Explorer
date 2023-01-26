using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public abstract class AbstractLayer
{
	public Vector2 Location;
	public Color Color;
	public int ZOrder, LayerOrder;
	public float Scale = 1f;
	protected AbstractScene Scene { get; private set; }
	public string Name { get; private set; }
	public bool Updatable { get; set; }
	public bool Visible { get; set; }
	public bool Removable { get; set; }

	public float X
	{
		get
		{
			return Location.X;
		}
		set
		{
			Location.X = value;
		}
	}

	public float Y
	{
		get
		{
			return Location.Y;
		}
		set
		{
			Location.Y = value;
		}
	}

	public int Width { get; protected set; }
	public int Height { get; protected set; }

	protected AbstractLayer(AbstractScene scene, string name)
	{
		Scene = scene;
		Name = name;
		Updatable = true;
		Visible = true;
		Color = Color.White;
		ZOrder = 0;
	}

	public abstract void Update(GameTime gameTime);
	public abstract void Draw(SpriteBatch spriteBatch);

	public virtual bool Click()
	{
		return false;
	}

	public virtual void Continue() {}
	public virtual void Hover() {}
	public virtual void Unhover() {}
	public virtual void Remove() {}
}
