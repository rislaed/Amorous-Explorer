using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class SpriteInteractable : AbstractInteractable
{ // _d4ad1i8rcZMvfN9iaxggA1KtVgx
	private readonly Action _click;

	public Texture2D Sprite { get; private set; }
	public Texture2D HoveredSprite { get; private set; }
	public Color Blending { get; set; }

	public SpriteInteractable(Texture2D sprite, Texture2D hoveredSprite, Action click)
	{
		Sprite = sprite;
		HoveredSprite = hoveredSprite;
		Blending = Color.White;
		_click = click;
	}

	public override void Click()
	{
		if (_click != null)
		{
			_click();
		}
	}

	public override void Draw(SpriteBatch spriteBatch)
	{
		if (base.Hovered)
		{
			spriteBatch.Draw(HoveredSprite ?? Sprite, Location, Blending);
			return;
		}
		spriteBatch.Draw(Sprite, Location, Blending);
	}
}
