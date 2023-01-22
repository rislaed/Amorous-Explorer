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

	public int _F5UOCZEYoZ6vR0bYiGdjxZQ8tA { get; set; }

	public _hxdR2gDHAgUMo1HqEU81OpKiFNA(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0, string string_0, Texture2D texture2D_0, int int_0, int int_1, int int_2)
		: base(_7UlnfykmEmZDFt3BmCKZekI43Ih_0, string_0)
	{
		if (int_0 == 0)
		{
			throw new ArgumentException("timePerFade == 0");
		}
		_Ko8EyRGBPblyaAEHREGGfcgE0A7 = texture2D_0;
		base._je8rVfyg4zywmqSi4Ozx1z7wJ4b = texture2D_0.get_Width();
		base._WJfGWBzn4wgdGBnMWRH2pcJ3AqH = texture2D_0.get_Height();
		_MTruZRkpqc4kHflWg7twpjpk2hf = int_0;
		_RFfbJpFrHeugXRRlKIQ5tDxMeTg = int_1;
		_F5UOCZEYoZ6vR0bYiGdjxZQ8tA = int_2;
		_dwYo1Zgom5wwftglD0CihP0EaHO = _ez0Al0VFyZFkAVXNLYDgc6YDLaiA.Delay;
		_wFKqij4skEKboWZNcGSEePbkSNo();
	}

	public override void _tiBFUHPEkedkbgvuX3whdeyjhKo(GameTime gameTime_0)
	{
		_Q7Kx7ErHf3u1QIUDKfFCKSXbznG -= gameTime_0.get_ElapsedGameTime().Milliseconds;
		if (_Q7Kx7ErHf3u1QIUDKfFCKSXbznG <= 0)
		{
			_wFKqij4skEKboWZNcGSEePbkSNo();
		}
		float num = (float)_Q7Kx7ErHf3u1QIUDKfFCKSXbznG / (float)_5gwtSkLakD15AZC4x8KB491e1Ww;
		_3wk7bXUbhNqSQ9kMD9hieEubOhG = MathHelper.Lerp(_ZWlF2BJ5oy1fSTcy3mPaT8QxJke, _1Ok941G6Q0LacxwafBKzxBsQW5G, num);
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
			_5gwtSkLakD15AZC4x8KB491e1Ww = _F5UOCZEYoZ6vR0bYiGdjxZQ8tA;
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

	public override void _f5ctqAmdNsZ889UjM4LxDm8WGxA(SpriteBatch spriteBatch_0)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		((Color)(ref _9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA)).set_A((byte)(_3wk7bXUbhNqSQ9kMD9hieEubOhG * 255f));
		if (((Color)(ref _9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA)).get_A() != 0)
		{
			spriteBatch_0.Draw(_Ko8EyRGBPblyaAEHREGGfcgE0A7, _Jh6AK28sBy2bS8ZCoKHP3LX45Uk, (Rectangle?)null, _9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA, 0f, Vector2.get_Zero(), _fO7gSlrDDNMoHR4FO5QXAq8fUyA, (SpriteEffects)0, 0f);
		}
	}

	static ArgumentException smethod_0(string string_0)
	{
		return new ArgumentException(string_0);
	}

	static int smethod_1(Texture2D texture2D_0)
	{
		return texture2D_0.get_Width();
	}

	static int smethod_2(Texture2D texture2D_0)
	{
		return texture2D_0.get_Height();
	}

	static TimeSpan smethod_3(GameTime gameTime_0)
	{
		return gameTime_0.get_ElapsedGameTime();
	}
}
