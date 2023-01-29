using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class ScreenFader : AbstractInterpolator<Color>
{ // _gJR4g7ak0hsZAUWX1vJbMqG2P5I
	private readonly Texture2D _foreground;

	public ScreenFader(GraphicsDevice graphicsDevice)
	{
		_foreground = new Texture2D(graphicsDevice, 1, 1, mipMap: false, SurfaceFormat.Color);
		_foreground.SetData(new Color[1] { Color.White });
	}

	protected override Color Interpolate(Color value1, Color value2, float interpolation)
	{
		return Color.Lerp(value1, value2, interpolation);
	}

	public void Draw(SpriteBatch spriteBatch, MouseObserver mouse)
	{
		spriteBatch.Begin();
		spriteBatch.Draw(_foreground, new Rectangle(0, 0, mouse.Width, mouse.Height), base.State);
		spriteBatch.End();
	}

	public void FadeOut(Action then = null)
	{
		To(new Color(0, 0, 0, 255), then);
	}

	public void FadeIn(Action then = null)
	{
		To(new Color(0, 0, 0, 0), then);
	}

	public void Apply(Color value, Action then = null)
	{
		To(value, then);
	}

	public void ApplyNow(Color value)
	{
		Set(value);
	}
}
