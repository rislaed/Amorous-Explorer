using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class _rmc1e7Ng50C4uLmgllAoRtxaZiB : _ujAkjlfN5TywwbLAUDzPvtab6uJ
{
	private readonly Action _XvomzD7ydX2gHHhG6ti3fxsB4QF;

	private int _3wk7bXUbhNqSQ9kMD9hieEubOhG;

	private int _Q7Kx7ErHf3u1QIUDKfFCKSXbznG;

	private bool _3pSkuXQLrbxfnmDHjLbcxrYNIfk;

	public List<Texture2D> _I1ZbHemGfJWozEfpDc9aFgiZQhEb { get; private set; }

	public int _LYcgggYAzSIbIyLQB6fJYp9GPs6 { get; private set; }

	public _rmc1e7Ng50C4uLmgllAoRtxaZiB(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0, string string_0, Action action_0, int int_0, List<Texture2D> list_0)
		: base(_7UlnfykmEmZDFt3BmCKZekI43Ih_0, string_0)
	{
		_I1ZbHemGfJWozEfpDc9aFgiZQhEb = list_0;
		base._je8rVfyg4zywmqSi4Ozx1z7wJ4b = list_0[0].Width;
		base._WJfGWBzn4wgdGBnMWRH2pcJ3AqH = list_0[0].Height;
		_LYcgggYAzSIbIyLQB6fJYp9GPs6 = int_0;
		_XvomzD7ydX2gHHhG6ti3fxsB4QF = action_0;
		_3wk7bXUbhNqSQ9kMD9hieEubOhG = 0;
		_Q7Kx7ErHf3u1QIUDKfFCKSXbznG = _LYcgggYAzSIbIyLQB6fJYp9GPs6;
	}

	public override void _tiBFUHPEkedkbgvuX3whdeyjhKo(GameTime gameTime_0)
	{
		_Q7Kx7ErHf3u1QIUDKfFCKSXbznG -= gameTime_0.ElapsedGameTime.Milliseconds;
		if (_Q7Kx7ErHf3u1QIUDKfFCKSXbznG < 0)
		{
			_Q7Kx7ErHf3u1QIUDKfFCKSXbznG = _LYcgggYAzSIbIyLQB6fJYp9GPs6;
			_3wk7bXUbhNqSQ9kMD9hieEubOhG++;
			if (_3wk7bXUbhNqSQ9kMD9hieEubOhG >= _I1ZbHemGfJWozEfpDc9aFgiZQhEb.Count)
			{
				_3wk7bXUbhNqSQ9kMD9hieEubOhG = 0;
			}
		}
	}

	public override void _f5ctqAmdNsZ889UjM4LxDm8WGxA(SpriteBatch spriteBatch_0)
	{
		if (_9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA.A != 0)
		{
			spriteBatch_0.Draw(_I1ZbHemGfJWozEfpDc9aFgiZQhEb[_3wk7bXUbhNqSQ9kMD9hieEubOhG], _Jh6AK28sBy2bS8ZCoKHP3LX45Uk, null, _3pSkuXQLrbxfnmDHjLbcxrYNIfk ? Color.Red : _9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA, 0f, Vector2.Zero, _fO7gSlrDDNMoHR4FO5QXAq8fUyA, SpriteEffects.None, 0f);
		}
	}

	public override bool _Hym13mjJB64DQkbAkEMmEae8pQdA()
	{
		_XvomzD7ydX2gHHhG6ti3fxsB4QF();
		return true;
	}

	public override void _i3qb0SiBqvdxqp5NXIRGrNGErxh()
	{
		_3pSkuXQLrbxfnmDHjLbcxrYNIfk = true;
	}

	public override void _oc2Bt2sYu2e2W8gFbd4cz1hv2Fq()
	{
		_3pSkuXQLrbxfnmDHjLbcxrYNIfk = false;
	}

	static int smethod_0(Texture2D texture2D_0)
	{
		return texture2D_0.Width;
	}

	static int smethod_1(Texture2D texture2D_0)
	{
		return texture2D_0.Height;
	}

	static TimeSpan smethod_2(GameTime gameTime_0)
	{
		return gameTime_0.ElapsedGameTime;
	}
}
