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

	private float _alpha;
	private float _fadingOut;
	private float _fadingIn;
	private int _ticks;
	private int _timeBetweenFade;
	private FadingStep _step;

	public Texture2D Texture { get; private set; }
	public int TimePerFade { get; set; }
	public int Offset { get; set; }
	public int Delay { get; set; }

	public FadingLayer(AbstractScene scene, string name, Texture2D texture, int timePerFade, int offset, int delay)
		: base(scene, name)
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
		_step = FadingStep.Delay;
		RefreshFading();
	}

	public override void Update(GameTime gameTime)
	{
		_ticks -= gameTime.ElapsedGameTime.Milliseconds;
		if (_ticks <= 0)
		{
			RefreshFading();
		}
		float amount = (float)_ticks / (float)_timeBetweenFade;
		_alpha = MathHelper.Lerp(_fadingIn, _fadingOut, amount);
	}

	private void RefreshFading()
	{
		switch (_step)
		{
			case FadingStep.Offset:
				_fadingOut = 0f;
				_fadingIn = 1f;
				_step = FadingStep.FadeIn;
				_timeBetweenFade = TimePerFade / 2;
				break;
			case FadingStep.FadeIn:
				_fadingOut = 1f;
				_fadingIn = 0f;
				_step = FadingStep.FadeOut;
				_timeBetweenFade = TimePerFade / 2;
				break;
			case FadingStep.FadeOut:
				_fadingOut = 0f;
				_fadingIn = 0f;
				_step = FadingStep.Delay;
				_timeBetweenFade = Delay;
				break;
			case FadingStep.Delay:
				_fadingOut = 0f;
				_fadingIn = 0f;
				_step = FadingStep.Offset;
				_timeBetweenFade = Offset;
				break;
		}
		_alpha = _fadingOut;
		_ticks = _timeBetweenFade;
		if (_ticks == 0)
		{
			RefreshFading();
		}
	}

	public override void Draw(SpriteBatch spriteBatch)
	{
		Color.A = (byte)(_alpha * 255f);
		if (Color.A != 0)
		{
			spriteBatch.Draw(Texture, Location, null, Color, 0f, Vector2.Zero, Scale, SpriteEffects.None, 0f);
		}
	}
}
