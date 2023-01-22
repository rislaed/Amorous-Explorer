using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class _kxm3yIqio0baXT5t5vOHBAEdviB : _ujAkjlfN5TywwbLAUDzPvtab6uJ
{
	private int _3wk7bXUbhNqSQ9kMD9hieEubOhG;

	private int _Q7Kx7ErHf3u1QIUDKfFCKSXbznG;

	public List<Texture2D> _I1ZbHemGfJWozEfpDc9aFgiZQhEb { get; private set; }

	public int _LYcgggYAzSIbIyLQB6fJYp9GPs6 { get; private set; }

	public _kxm3yIqio0baXT5t5vOHBAEdviB(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0, string string_0, int int_0, List<Texture2D> list_0)
		: base(_7UlnfykmEmZDFt3BmCKZekI43Ih_0, string_0)
	{
		_I1ZbHemGfJWozEfpDc9aFgiZQhEb = list_0;
		base._je8rVfyg4zywmqSi4Ozx1z7wJ4b = _kxm3yIqio0baXT5t5vOHBAEdviB.smethod_0(list_0[0]);
		base._WJfGWBzn4wgdGBnMWRH2pcJ3AqH = _kxm3yIqio0baXT5t5vOHBAEdviB.smethod_1(list_0[0]);
		_LYcgggYAzSIbIyLQB6fJYp9GPs6 = int_0;
		_3wk7bXUbhNqSQ9kMD9hieEubOhG = 0;
		_Q7Kx7ErHf3u1QIUDKfFCKSXbznG = _LYcgggYAzSIbIyLQB6fJYp9GPs6;
	}

	public override void _tiBFUHPEkedkbgvuX3whdeyjhKo(GameTime gameTime_0)
	{
		_Q7Kx7ErHf3u1QIUDKfFCKSXbznG -= _kxm3yIqio0baXT5t5vOHBAEdviB.smethod_2(gameTime_0).Milliseconds;
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
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		if (((Color)(ref _9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA)).get_A() != 0)
		{
			spriteBatch_0.Draw(_I1ZbHemGfJWozEfpDc9aFgiZQhEb[_3wk7bXUbhNqSQ9kMD9hieEubOhG], _Jh6AK28sBy2bS8ZCoKHP3LX45Uk, (Rectangle?)null, _9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA, 0f, Vector2.get_Zero(), _fO7gSlrDDNMoHR4FO5QXAq8fUyA, (SpriteEffects)0, 0f);
		}
	}

	static int smethod_0(Texture2D texture2D_0)
	{
		return texture2D_0.get_Width();
	}

	static int smethod_1(Texture2D texture2D_0)
	{
		return texture2D_0.get_Height();
	}

	static TimeSpan smethod_2(GameTime gameTime_0)
	{
		return gameTime_0.get_ElapsedGameTime();
	}
}
