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
			throw _hxdR2gDHAgUMo1HqEU81OpKiFNA.smethod_0("timePerFade == 0");
		}
		_Ko8EyRGBPblyaAEHREGGfcgE0A7 = texture2D_0;
		base._je8rVfyg4zywmqSi4Ozx1z7wJ4b = _hxdR2gDHAgUMo1HqEU81OpKiFNA.smethod_1(texture2D_0);
		base._WJfGWBzn4wgdGBnMWRH2pcJ3AqH = _hxdR2gDHAgUMo1HqEU81OpKiFNA.smethod_2(texture2D_0);
		_MTruZRkpqc4kHflWg7twpjpk2hf = int_0;
		_RFfbJpFrHeugXRRlKIQ5tDxMeTg = int_1;
		_F5UOCZEYoZ6vR0bYiGdjxZQ8tA = int_2;
		_dwYo1Zgom5wwftglD0CihP0EaHO = _ez0Al0VFyZFkAVXNLYDgc6YDLaiA.Delay;
		_wFKqij4skEKboWZNcGSEePbkSNo();
	}

	public override void _tiBFUHPEkedkbgvuX3whdeyjhKo(GameTime gameTime_0)
	{
		_Q7Kx7ErHf3u1QIUDKfFCKSXbznG -= _hxdR2gDHAgUMo1HqEU81OpKiFNA.smethod_3(gameTime_0).Milliseconds;
		if (_Q7Kx7ErHf3u1QIUDKfFCKSXbznG <= 0)
		{
			goto IL_0062;
		}
		goto IL_008c;
		IL_008c:
		float num = (float)_Q7Kx7ErHf3u1QIUDKfFCKSXbznG / (float)_5gwtSkLakD15AZC4x8KB491e1Ww;
		int num2 = -388770837;
		goto IL_0067;
		IL_0067:
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0x8C14A6FDu) % 5u)
			{
			case 3u:
				_3wk7bXUbhNqSQ9kMD9hieEubOhG = MathHelper.Lerp(_ZWlF2BJ5oy1fSTcy3mPaT8QxJke, _1Ok941G6Q0LacxwafBKzxBsQW5G, num);
				num2 = ((int)num3 * -2068422566) ^ 0x7765FEA7;
				continue;
			case 2u:
				_wFKqij4skEKboWZNcGSEePbkSNo();
				num2 = (int)((num3 * 407387377) ^ 0x31BF4C64);
				continue;
			case 0u:
				break;
			default:
				return;
			case 1u:
				goto IL_008c;
			case 4u:
				return;
			}
			break;
		}
		goto IL_0062;
		IL_0062:
		num2 = -1270372947;
		goto IL_0067;
	}

	private void _wFKqij4skEKboWZNcGSEePbkSNo()
	{
		int num;
		switch (_dwYo1Zgom5wwftglD0CihP0EaHO)
		{
		default:
			num = 1804803157;
			goto IL_0232;
		case _ez0Al0VFyZFkAVXNLYDgc6YDLaiA.Offset:
			goto IL_007f;
		case _ez0Al0VFyZFkAVXNLYDgc6YDLaiA.FadeOut:
			goto IL_00c5;
		case _ez0Al0VFyZFkAVXNLYDgc6YDLaiA.FadeIn:
			goto IL_01d2;
		case _ez0Al0VFyZFkAVXNLYDgc6YDLaiA.Delay:
			goto IL_02a0;
			IL_0232:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x77CBA447u) % 23u)
				{
				case 22u:
					_dwYo1Zgom5wwftglD0CihP0EaHO = _ez0Al0VFyZFkAVXNLYDgc6YDLaiA.Offset;
					num = (int)((num2 * 1041429859) ^ 0x1AA9659F);
					continue;
				case 21u:
					_5gwtSkLakD15AZC4x8KB491e1Ww = _MTruZRkpqc4kHflWg7twpjpk2hf / 2;
					num = ((int)num2 * -1536237851) ^ -1345706621;
					continue;
				case 20u:
					break;
				case 19u:
					_ZWlF2BJ5oy1fSTcy3mPaT8QxJke = 0f;
					num = ((int)num2 * -1476179235) ^ -805084686;
					continue;
				case 18u:
					goto IL_007f;
				case 17u:
					_wFKqij4skEKboWZNcGSEePbkSNo();
					num = ((int)num2 * -695437080) ^ -890714438;
					continue;
				case 16u:
					_dwYo1Zgom5wwftglD0CihP0EaHO = _ez0Al0VFyZFkAVXNLYDgc6YDLaiA.Delay;
					num = (int)(num2 * 1140539243) ^ -1516396755;
					continue;
				case 15u:
					goto IL_00c5;
				case 13u:
				{
					int num3;
					int num4;
					if (_Q7Kx7ErHf3u1QIUDKfFCKSXbznG == 0)
					{
						num3 = 777341578;
						num4 = 777341578;
					}
					else
					{
						num3 = 275011242;
						num4 = 275011242;
					}
					num = num3 ^ (int)(num2 * 439504892);
					continue;
				}
				case 12u:
					_5gwtSkLakD15AZC4x8KB491e1Ww = _RFfbJpFrHeugXRRlKIQ5tDxMeTg;
					num = ((int)num2 * -860219930) ^ -517835045;
					continue;
				case 11u:
					_dwYo1Zgom5wwftglD0CihP0EaHO = _ez0Al0VFyZFkAVXNLYDgc6YDLaiA.FadeOut;
					num = (int)(num2 * 1334964022) ^ -769528103;
					continue;
				case 10u:
					_5gwtSkLakD15AZC4x8KB491e1Ww = _MTruZRkpqc4kHflWg7twpjpk2hf / 2;
					num = (int)(num2 * 408895315) ^ -1112883160;
					continue;
				case 9u:
					num = ((int)num2 * -901423428) ^ 0x7DFFC0AD;
					continue;
				case 8u:
					_3wk7bXUbhNqSQ9kMD9hieEubOhG = _1Ok941G6Q0LacxwafBKzxBsQW5G;
					num = 66433076;
					continue;
				case 7u:
					_ZWlF2BJ5oy1fSTcy3mPaT8QxJke = 1f;
					num = ((int)num2 * -434456756) ^ 0x5A981541;
					continue;
				case 6u:
					num = ((int)num2 * -733212038) ^ 0x19AEF4F5;
					continue;
				case 5u:
					_dwYo1Zgom5wwftglD0CihP0EaHO = _ez0Al0VFyZFkAVXNLYDgc6YDLaiA.FadeIn;
					num = (int)((num2 * 756064730) ^ 0x7DAE34A);
					continue;
				case 3u:
					goto IL_01d2;
				case 2u:
					num = ((int)num2 * -329195957) ^ -1102347461;
					continue;
				case 1u:
					_Q7Kx7ErHf3u1QIUDKfFCKSXbznG = _5gwtSkLakD15AZC4x8KB491e1Ww;
					num = (int)((num2 * 1545503485) ^ 0xE71605A);
					continue;
				case 0u:
					_5gwtSkLakD15AZC4x8KB491e1Ww = _F5UOCZEYoZ6vR0bYiGdjxZQ8tA;
					num = ((int)num2 * -574375230) ^ 0x5F6343F3;
					continue;
				default:
					return;
				case 4u:
					goto IL_02a0;
				case 14u:
					return;
				}
				break;
			}
			goto default;
			IL_02a0:
			_1Ok941G6Q0LacxwafBKzxBsQW5G = 0f;
			num = 1002533049;
			goto IL_0232;
			IL_01d2:
			_1Ok941G6Q0LacxwafBKzxBsQW5G = 1f;
			_ZWlF2BJ5oy1fSTcy3mPaT8QxJke = 0f;
			num = 1024671234;
			goto IL_0232;
			IL_00c5:
			_1Ok941G6Q0LacxwafBKzxBsQW5G = 0f;
			_ZWlF2BJ5oy1fSTcy3mPaT8QxJke = 0f;
			num = 384315744;
			goto IL_0232;
			IL_007f:
			_1Ok941G6Q0LacxwafBKzxBsQW5G = 0f;
			num = 1495077307;
			goto IL_0232;
		}
	}

	public override void _f5ctqAmdNsZ889UjM4LxDm8WGxA(SpriteBatch spriteBatch_0)
	{
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		((Color)(ref _9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA)).set_A((byte)(_3wk7bXUbhNqSQ9kMD9hieEubOhG * 255f));
		while (true)
		{
			int num = 61761267;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0x6A894AAAu) % 4u)
				{
				case 1u:
				{
					int num4;
					if (((Color)(ref _9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA)).get_A() != 0)
					{
						num3 = -1279854095;
						num4 = -1279854095;
					}
					else
					{
						num3 = -2118199412;
						num4 = -2118199412;
					}
					goto IL_003d;
				}
				case 0u:
					break;
				case 2u:
					return;
				default:
					spriteBatch_0.Draw(_Ko8EyRGBPblyaAEHREGGfcgE0A7, _Jh6AK28sBy2bS8ZCoKHP3LX45Uk, (Rectangle?)null, _9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA, 0f, Vector2.get_Zero(), _fO7gSlrDDNMoHR4FO5QXAq8fUyA, (SpriteEffects)0, 0f);
					return;
				}
				break;
				IL_003d:
				num = num3 ^ (int)(num2 * 516012268);
			}
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
