using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class ClickableLayer : AbstractLayer
{ // _z20t8IpBINiJtljSeTIkNoKUOkx
	private bool _hovered;
	private readonly Action _click;

	public Texture2D Texture { get; private set; }

	public ClickableLayer(AbstractScene scene, string name, Texture2D texture2D, Action click)
		: base(scene, name)
	{
		Texture = texture2D;
		base.Width = texture2D.Width;
		base.Height = texture2D.Height;
		_click = click;
	}

	public override void Update(GameTime gameTime) {}

	public override void Draw(SpriteBatch spriteBatch)
	{
		if (Color.A != 0)
		{
			spriteBatch.Draw(Texture, Location, null, (!_hovered) ? Color : Color.Red, 0f, Vector2.Zero, Scale, SpriteEffects.None, 0f);
		}
	}

	public override bool Click()
	{
		_hovered = false;
		_click();
		return true;
	}

	public override void Hover()
	{
		_hovered = true;
	}

	public override void Unhover()
	{
		_hovered = false;
	}
}
