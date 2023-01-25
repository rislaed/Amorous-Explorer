using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class _hxdR2gDHAgUMo1HqEU81OpKiFNA : _ujAkjlfN5TywwbLAUDzPvtab6uJ
{
	private enum _ez0Al0VFyZFkAVXNLYDgc6YDLaiA
	{
		Offset,
		FadeIn,
		FadeOut,
		Delay
	}

	private float _3wk7bXUbhNqSQ9kMD9hieEubOhG;

	private float _1Ok941G6Q0LacxwafBKzxBsQW5G;

	private float _ZWlF2BJ5oy1fSTcy3mPaT8QxJke;

	private int _Q7Kx7ErHf3u1QIUDKfFCKSXbznG;

	private int _5gwtSkLakD15AZC4x8KB491e1Ww;

	private _ez0Al0VFyZFkAVXNLYDgc6YDLaiA _dwYo1Zgom5wwftglD0CihP0EaHO;

	public Texture2D _Ko8EyRGBPblyaAEHREGGfcgE0A7 { get; private set; }

	public int _MTruZRkpqc4kHflWg7twpjpk2hf { get; set; }

	public int _RFfbJpFrHeugXRRlKIQ5tDxMeTg { get; set; }

	public int Delay { get; set; }

	public _hxdR2gDHAgUMo1HqEU81OpKiFNA(AbstractScene AbstractScene_0, string string_0, Texture2D texture2D_0, int int_0, int int_1, int int_2)
		: base(AbstractScene_0, string_0)
	{
		if (int_0 == 0)
		{
			throw new ArgumentException("timePerFade == 0");
		}
		_Ko8EyRGBPblyaAEHREGGfcgE0A7 = texture2D_0;
		base.Width = texture2D_0.Width;
		base.Height = texture2D_0.Height;
		_MTruZRkpqc4kHflWg7twpjpk2hf = int_0;
		_RFfbJpFrHeugXRRlKIQ5tDxMeTg = int_1;
		Delay = int_2;
		_dwYo1Zgom5wwftglD0CihP0EaHO = _ez0Al0VFyZFkAVXNLYDgc6YDLaiA.Delay;
		_wFKqij4skEKboWZNcGSEePbkSNo();
	}

	public override void Update(GameTime gameTime_0)
	{
		_Q7Kx7ErHf3u1QIUDKfFCKSXbznG -= gameTime_0.ElapsedGameTime.Milliseconds;
		if (_Q7Kx7ErHf3u1QIUDKfFCKSXbznG <= 0)
		{
			_wFKqij4skEKboWZNcGSEePbkSNo();
		}
		float amount = (float)_Q7Kx7ErHf3u1QIUDKfFCKSXbznG / (float)_5gwtSkLakD15AZC4x8KB491e1Ww;
		_3wk7bXUbhNqSQ9kMD9hieEubOhG = MathHelper.Lerp(_ZWlF2BJ5oy1fSTcy3mPaT8QxJke, _1Ok941G6Q0LacxwafBKzxBsQW5G, amount);
	}

	private void _wFKqij4skEKboWZNcGSEePbkSNo()
	{
		switch (_dwYo1Zgom5wwftglD0CihP0EaHO)
		{
		case _ez0Al0VFyZFkAVXNLYDgc6YDLaiA.Offset:
			_1Ok941G6Q0LacxwafBKzxBsQW5G = 0f;
			_ZWlF2BJ5oy1fSTcy3mPaT8QxJke = 1f;
			_dwYo1Zgom5wwftglD0CihP0EaHO = _ez0Al0VFyZFkAVXNLYDgc6YDLaiA.FadeIn;
			_5gwtSkLakD15AZC4x8KB491e1Ww = _MTruZRkpqc4kHflWg7twpjpk2hf / 2;
			break;
		case _ez0Al0VFyZFkAVXNLYDgc6YDLaiA.FadeIn:
			_1Ok941G6Q0LacxwafBKzxBsQW5G = 1f;
			_ZWlF2BJ5oy1fSTcy3mPaT8QxJke = 0f;
			_dwYo1Zgom5wwftglD0CihP0EaHO = _ez0Al0VFyZFkAVXNLYDgc6YDLaiA.FadeOut;
			_5gwtSkLakD15AZC4x8KB491e1Ww = _MTruZRkpqc4kHflWg7twpjpk2hf / 2;
			break;
		case _ez0Al0VFyZFkAVXNLYDgc6YDLaiA.FadeOut:
			_1Ok941G6Q0LacxwafBKzxBsQW5G = 0f;
			_ZWlF2BJ5oy1fSTcy3mPaT8QxJke = 0f;
			_dwYo1Zgom5wwftglD0CihP0EaHO = _ez0Al0VFyZFkAVXNLYDgc6YDLaiA.Delay;
			_5gwtSkLakD15AZC4x8KB491e1Ww = Delay;
			break;
		case _ez0Al0VFyZFkAVXNLYDgc6YDLaiA.Delay:
			_1Ok941G6Q0LacxwafBKzxBsQW5G = 0f;
			_ZWlF2BJ5oy1fSTcy3mPaT8QxJke = 0f;
			_dwYo1Zgom5wwftglD0CihP0EaHO = _ez0Al0VFyZFkAVXNLYDgc6YDLaiA.Offset;
			_5gwtSkLakD15AZC4x8KB491e1Ww = _RFfbJpFrHeugXRRlKIQ5tDxMeTg;
			break;
		}
		_3wk7bXUbhNqSQ9kMD9hieEubOhG = _1Ok941G6Q0LacxwafBKzxBsQW5G;
		_Q7Kx7ErHf3u1QIUDKfFCKSXbznG = _5gwtSkLakD15AZC4x8KB491e1Ww;
		if (_Q7Kx7ErHf3u1QIUDKfFCKSXbznG == 0)
		{
			_wFKqij4skEKboWZNcGSEePbkSNo();
		}
	}

	public override void Draw(SpriteBatch spriteBatch_0)
	{
		Color.A = (byte)(_3wk7bXUbhNqSQ9kMD9hieEubOhG * 255f);
		if (Color.A != 0)
		{
			spriteBatch_0.Draw(_Ko8EyRGBPblyaAEHREGGfcgE0A7, _Jh6AK28sBy2bS8ZCoKHP3LX45Uk, null, Color, 0f, Vector2.Zero, _fO7gSlrDDNMoHR4FO5QXAq8fUyA, SpriteEffects.None, 0f);
		}
	}
}
