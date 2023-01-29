using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class FadingLayer : AbstractLayer
{ // _hxdR2gDHAgUMo1HqEU81OpKiFNA
	private enum FadingStep
	{
		Offset,
		FadeIn,
		FadeOut,
		Delay
	}

	private float Value;
	private float FadingOut;
	private float FadingIn;
	private int Stopwatch;
	private int Between;
	private FadingStep Step;

	public Texture2D Texture { get; private set; }
	public int TimePerFade { get; set; }
	public int Offset { get; set; }
	public int Delay { get; set; }

	public FadingLayer(AbstractScene scene, string name, Texture2D texture2D, int timePerFade, int offset, int delay)
		: base(scene, name)
	{
		if (timePerFade == 0)
		{
			throw new ArgumentException("timePerFade == 0");
		}
		Texture = texture2D;
		base.Width = texture2D.Width;
		base.Height = texture2D.Height;
		TimePerFade = timePerFade;
		Offset = offset;
		Delay = delay;
		Step = FadingStep.Delay;
		RefreshFading();
	}

	public override void Update(GameTime gameTime)
	{
		Stopwatch -= gameTime.ElapsedGameTime.Milliseconds;
		if (Stopwatch <= 0)
		{
			RefreshFading();
		}
		float amount = (float)Stopwatch / (float)Between;
		Value = MathHelper.Lerp(FadingIn, FadingOut, amount);
	}

	private void RefreshFading()
	{
		switch (Step)
		{
			case FadingStep.Offset:
				FadingOut = 0f;
				FadingIn = 1f;
				Step = FadingStep.FadeIn;
				Between = TimePerFade / 2;
				break;
			case FadingStep.FadeIn:
				FadingOut = 1f;
				FadingIn = 0f;
				Step = FadingStep.FadeOut;
				Between = TimePerFade / 2;
				break;
			case FadingStep.FadeOut:
				FadingOut = 0f;
				FadingIn = 0f;
				Step = FadingStep.Delay;
				Between = Delay;
				break;
			case FadingStep.Delay:
				FadingOut = 0f;
				FadingIn = 0f;
				Step = FadingStep.Offset;
				Between = Offset;
				break;
		}
		Value = FadingOut;
		Stopwatch = Between;
		if (Stopwatch == 0)
		{
			RefreshFading();
		}
	}

	public override void Draw(SpriteBatch spriteBatch)
	{
		Color.A = (byte)(Value * 255f);
		if (Color.A != 0)
		{
			spriteBatch.Draw(Texture, Location, null, Color, 0f, Vector2.Zero, Scale, SpriteEffects.None, 0f);
		}
	}
}
