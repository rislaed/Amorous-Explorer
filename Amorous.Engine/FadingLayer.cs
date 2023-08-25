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

	private float alpha;
	private float fadingOut;
	private float fadingIn;
	private int ticks;
	private int timeBetweenFade;
	private FadingStep step;

	public Texture2D Texture { get; private set; }
	public int TimePerFade { get; set; }
	public int Offset { get; set; }
	public int Delay { get; set; }

	public FadingLayer(AbstractScene scene, string name, Texture2D texture, int timePerFade, int offset, int delay) : base(scene, name)
	{
		if (timePerFade == 0)
		{
			throw new ArgumentException("timePerFade == 0");
		}
		Texture = texture;
		base.Width = texture.Width;
		base.Height = texture.Height;
		TimePerFade = timePerFade;
		Offset = offset;
		Delay = delay;
		step = FadingStep.Delay;
		RefreshFading();
	}

	public override void Update(GameTime gameTime)
	{
		ticks -= gameTime.ElapsedGameTime.Milliseconds;
		if (ticks <= 0)
		{
			RefreshFading();
		}
		float amount = (float)ticks / (float)timeBetweenFade;
		alpha = MathHelper.Lerp(fadingIn, fadingOut, amount);
	}

	private void RefreshFading()
	{
		switch (step)
		{
			case FadingStep.Offset:
				fadingOut = 0f;
				fadingIn = 1f;
				step = FadingStep.FadeIn;
				timeBetweenFade = TimePerFade / 2;
				break;
			case FadingStep.FadeIn:
				fadingOut = 1f;
				fadingIn = 0f;
				step = FadingStep.FadeOut;
				timeBetweenFade = TimePerFade / 2;
				break;
			case FadingStep.FadeOut:
				fadingOut = 0f;
				fadingIn = 0f;
				step = FadingStep.Delay;
				timeBetweenFade = Delay;
				break;
			case FadingStep.Delay:
				fadingOut = 0f;
				fadingIn = 0f;
				step = FadingStep.Offset;
				timeBetweenFade = Offset;
				break;
		}
		alpha = fadingOut;
		ticks = timeBetweenFade;
		if (ticks == 0)
		{
			RefreshFading();
		}
	}

	public override void Draw(SpriteBatch spriteBatch)
	{
		Color.A = (byte)(alpha * 255f);
		if (Color.A != 0)
		{
			spriteBatch.Draw(Texture, Location, null, Color, 0f, Vector2.Zero, Scale, SpriteEffects.None, 0f);
		}
	}
}
