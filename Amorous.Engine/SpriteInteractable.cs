using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class SpriteInteractable : AbstractInteractable
{ // _d4ad1i8rcZMvfN9iaxggA1KtVgx
	private readonly Action _click;

	public Texture2D Foreground { get; private set; }
	public Texture2D Background { get; private set; }
	public Color Blending { get; set; }

	public SpriteInteractable(Texture2D foreground, Texture2D background, Action click)
	{
		Foreground = foreground;
		Background = background;
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
			spriteBatch.Draw(Background ?? Foreground, Location, Blending);
		}
		spriteBatch.Draw(Foreground, Location, Blending);
	}
}
