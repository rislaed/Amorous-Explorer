using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class ScreenFader : AbstractInterpolator<Color>
{ // _gJR4g7ak0hsZAUWX1vJbMqG2P5I
	private readonly Texture2D color;

	public ScreenFader(GraphicsDevice graphicsDevice)
	{
		color = new Texture2D(graphicsDevice, 1, 1, mipMap: false, SurfaceFormat.Color);
		color.SetData(new Color[1] { Color.White });
	}

	protected override Color Interpolate(Color value1, Color value2, float amount)
	{
		return Color.Lerp(value1, value2, amount);
	}

	public void Draw(SpriteBatch spriteBatch, CanvasObserver canvas)
	{
		spriteBatch.Begin();
		spriteBatch.Draw(color, new Rectangle(0, 0, canvas.AbsoluteWidth, canvas.AbsoluteHeight), base.Value);
		spriteBatch.End();
	}

	public void FadeOut(Action then = null)
	{
		Begin(new Color(0, 0, 0, 255), then);
	}

	public void FadeIn(Action then = null)
	{
		Begin(new Color(0, 0, 0, 0), then);
	}

	public void Apply(Color value, Action then = null)
	{
		Begin(value, then);
	}

	public void ApplyWithoutFading(Color value)
	{
		End(value);
	}
}
