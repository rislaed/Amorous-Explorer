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
		base._je8rVfyg4zywmqSi4Ozx1z7wJ4b = _rmc1e7Ng50C4uLmgllAoRtxaZiB.smethod_0(list_0[0]);
		base._WJfGWBzn4wgdGBnMWRH2pcJ3AqH = _rmc1e7Ng50C4uLmgllAoRtxaZiB.smethod_1(list_0[0]);
		_LYcgggYAzSIbIyLQB6fJYp9GPs6 = int_0;
		_XvomzD7ydX2gHHhG6ti3fxsB4QF = action_0;
		_3wk7bXUbhNqSQ9kMD9hieEubOhG = 0;
		_Q7Kx7ErHf3u1QIUDKfFCKSXbznG = _LYcgggYAzSIbIyLQB6fJYp9GPs6;
	}

	public override void _tiBFUHPEkedkbgvuX3whdeyjhKo(GameTime gameTime_0)
	{
		_Q7Kx7ErHf3u1QIUDKfFCKSXbznG -= _rmc1e7Ng50C4uLmgllAoRtxaZiB.smethod_2(gameTime_0).Milliseconds;
		while (true)
		{
			int num = 43107295;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3AF3B6AAu) % 6u)
				{
				case 4u:
					_Q7Kx7ErHf3u1QIUDKfFCKSXbznG = _LYcgggYAzSIbIyLQB6fJYp9GPs6;
					_3wk7bXUbhNqSQ9kMD9hieEubOhG++;
					num = (int)((num2 * 416405234) ^ 0x6369E37A);
					continue;
				case 3u:
					_3wk7bXUbhNqSQ9kMD9hieEubOhG = 0;
					num = ((int)num2 * -1131619533) ^ 0x6A2A9C3B;
					continue;
				case 2u:
				{
					int num5;
					int num6;
					if (_3wk7bXUbhNqSQ9kMD9hieEubOhG >= _I1ZbHemGfJWozEfpDc9aFgiZQhEb.Count)
					{
						num5 = -302400601;
						num6 = -302400601;
					}
					else
					{
						num5 = -1656369620;
						num6 = -1656369620;
					}
					num = num5 ^ ((int)num2 * -577372203);
					continue;
				}
				case 1u:
				{
					int num3;
					int num4;
					if (_Q7Kx7ErHf3u1QIUDKfFCKSXbznG < 0)
					{
						num3 = -1389481125;
						num4 = -1389481125;
					}
					else
					{
						num3 = -1338160067;
						num4 = -1338160067;
					}
					num = num3 ^ (int)(num2 * 336640125);
					continue;
				}
				default:
					return;
				case 5u:
					break;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	public override void _f5ctqAmdNsZ889UjM4LxDm8WGxA(SpriteBatch spriteBatch_0)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		if (((Color)(ref _9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA)).get_A() != 0)
		{
			spriteBatch_0.Draw(_I1ZbHemGfJWozEfpDc9aFgiZQhEb[_3wk7bXUbhNqSQ9kMD9hieEubOhG], _Jh6AK28sBy2bS8ZCoKHP3LX45Uk, (Rectangle?)null, _3pSkuXQLrbxfnmDHjLbcxrYNIfk ? Color.get_Red() : _9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA, 0f, Vector2.get_Zero(), _fO7gSlrDDNMoHR4FO5QXAq8fUyA, (SpriteEffects)0, 0f);
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
