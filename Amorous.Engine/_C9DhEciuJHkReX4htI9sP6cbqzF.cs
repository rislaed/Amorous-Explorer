using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class _C9DhEciuJHkReX4htI9sP6cbqzF : _ujAkjlfN5TywwbLAUDzPvtab6uJ
{
	private float _u8pBof2EYEcHCEDxEtA27OOeLmVb;

	private readonly Vector2 _QBwNjQE21bfJ9yRo7CynjeYaHRg;

	public Texture2D _Ko8EyRGBPblyaAEHREGGfcgE0A7 { get; private set; }

	public float _NhL238TaCbkDiY6HXlWXZzzUYkm { get; private set; }

	public _C9DhEciuJHkReX4htI9sP6cbqzF(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0, string string_0, Texture2D texture2D_0, float float_0, Vector2 vector2_0)
		: base(_7UlnfykmEmZDFt3BmCKZekI43Ih_0, string_0)
	{
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			int num = -554434257;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF3E3E825u) % 6u)
				{
				case 5u:
					_NhL238TaCbkDiY6HXlWXZzzUYkm = float_0;
					num = (int)(num2 * 1148989304) ^ -686602035;
					continue;
				case 4u:
					base._je8rVfyg4zywmqSi4Ozx1z7wJ4b = _C9DhEciuJHkReX4htI9sP6cbqzF.smethod_0(texture2D_0);
					num = (int)(num2 * 1598970761) ^ -748319323;
					continue;
				case 2u:
					_Ko8EyRGBPblyaAEHREGGfcgE0A7 = texture2D_0;
					num = ((int)num2 * -193028356) ^ -981004596;
					continue;
				case 0u:
					base._WJfGWBzn4wgdGBnMWRH2pcJ3AqH = _C9DhEciuJHkReX4htI9sP6cbqzF.smethod_1(texture2D_0);
					num = ((int)num2 * -1532375930) ^ 0x1DC28496;
					continue;
				case 3u:
					break;
				default:
					_u8pBof2EYEcHCEDxEtA27OOeLmVb = 0f;
					_QBwNjQE21bfJ9yRo7CynjeYaHRg = vector2_0;
					return;
				}
				break;
			}
		}
	}

	public override void _tiBFUHPEkedkbgvuX3whdeyjhKo(GameTime gameTime_0)
	{
		_u8pBof2EYEcHCEDxEtA27OOeLmVb += (float)_C9DhEciuJHkReX4htI9sP6cbqzF.smethod_2(gameTime_0).Milliseconds / 1000f * _NhL238TaCbkDiY6HXlWXZzzUYkm;
		while (true)
		{
			int num = -871660295;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB2FCBFA5u) % 7u)
				{
				case 4u:
					_u8pBof2EYEcHCEDxEtA27OOeLmVb += 360f;
					num = (int)(num2 * 23555867) ^ -1519062475;
					continue;
				case 3u:
				{
					int num4;
					int num5;
					if (_u8pBof2EYEcHCEDxEtA27OOeLmVb <= 360f)
					{
						num4 = -2084906177;
						num5 = -2084906177;
					}
					else
					{
						num4 = -1248052596;
						num5 = -1248052596;
					}
					num = num4 ^ (int)(num2 * 234712174);
					continue;
				}
				case 2u:
					_u8pBof2EYEcHCEDxEtA27OOeLmVb -= 360f;
					num = ((int)num2 * -1684454109) ^ -909388145;
					continue;
				case 0u:
				{
					int num3;
					if (_u8pBof2EYEcHCEDxEtA27OOeLmVb >= -360f)
					{
						num = -767809316;
						num3 = -767809316;
					}
					else
					{
						num = -150178322;
						num3 = -150178322;
					}
					continue;
				}
				default:
					return;
				case 5u:
					break;
				case 1u:
					return;
				case 6u:
					return;
				}
				break;
			}
		}
	}

	public override void _f5ctqAmdNsZ889UjM4LxDm8WGxA(SpriteBatch spriteBatch_0)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		if (((Color)(ref _9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA)).get_A() == 0)
		{
			goto IL_000d;
		}
		goto IL_0031;
		IL_0031:
		spriteBatch_0.Draw(_Ko8EyRGBPblyaAEHREGGfcgE0A7, _Jh6AK28sBy2bS8ZCoKHP3LX45Uk + _QBwNjQE21bfJ9yRo7CynjeYaHRg, (Rectangle?)null, _9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA, _u8pBof2EYEcHCEDxEtA27OOeLmVb, _QBwNjQE21bfJ9yRo7CynjeYaHRg, _fO7gSlrDDNMoHR4FO5QXAq8fUyA, (SpriteEffects)0, 0f);
		int num = 190233958;
		goto IL_0012;
		IL_0012:
		switch ((uint)(num ^ 0xC4C643D) % 4u)
		{
		case 0u:
			break;
		default:
			return;
		case 2u:
			goto IL_0031;
		case 1u:
			return;
		case 3u:
			return;
		}
		goto IL_000d;
		IL_000d:
		num = 459601704;
		goto IL_0012;
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
