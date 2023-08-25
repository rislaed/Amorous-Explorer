using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class ClickableLayer : AbstractLayer
{ // _z20t8IpBINiJtljSeTIkNoKUOkx
	private bool hovered;
	private readonly Action click;

	public Texture2D Texture { get; private set; }

	public ClickableLayer(AbstractScene scene, string name, Texture2D texture2D, Action action)
		: base(scene, name)
	{
		Texture = texture2D;
		base.Width = texture2D.Width;
		base.Height = texture2D.Height;
		click = action;
	}

	public override void Update(GameTime gameTime) {}

	public override void Draw(SpriteBatch spriteBatch)
	{
		if (Color.A != 0)
		{
			spriteBatch.Draw(Texture, Location, null, (!hovered) ? Color : Color.Red, 0f, Vector2.Zero, Scale, SpriteEffects.None, 0f);
		}
	}

	public override bool Click()
	{
		hovered = false;
		click();
		return true;
	}

	public override void Enter()
	{
		hovered = true;
	}

	public override void Leave()
	{
		hovered = false;
	}
}
