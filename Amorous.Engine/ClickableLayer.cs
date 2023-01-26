using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class ClickableLayer : AbstractLayer
{
	private bool Hovered;

	private readonly Action When;
	public Texture2D Texture { get; private set; }

	public ClickableLayer(AbstractScene scene, string name, Texture2D texture2D, Action click)
		: base(scene, name)
	{
		Texture = texture2D;
		base.Width = texture2D.Width;
		base.Height = texture2D.Height;
		When = click;
	}

	public override void Update(GameTime gameTime) {}

	public override void Draw(SpriteBatch spriteBatch)
	{
		if (Color.A != 0)
		{
			spriteBatch.Draw(Texture, Location, null, (!Hovered) ? Color : Color.Red, 0f, Vector2.Zero, Scale, SpriteEffects.None, 0f);
		}
	}

	public override bool Click()
	{
		Hovered = false;
		When();
		return true;
	}

	public override void Hover()
	{
		Hovered = true;
	}

	public override void Unhover()
	{
		Hovered = false;
	}
}
