using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class _iHJrndJdM1jj9TEnuU3BvgdDuvf : _d4ad1i8rcZMvfN9iaxggA1KtVgx
{
	private string _eNqfeKhXj4x1FkHQitvzRQ1JLSE;

	private Vector2 _0IQKqP6KjSSBSTlZR0Y2K1CamuH;

	private Vector2 _zqzgCa0m3Wy0XOFPjEWDVqp6Ybb;

	public SpriteFont _UlZpHdih1X5ig1k6QjZ497jtA1A { get; private set; }

	public string _K87Hdb6ToAR0us3tN3ZmvHdPdeJ
	{
		get
		{
			return _eNqfeKhXj4x1FkHQitvzRQ1JLSE;
		}
		set
		{
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			//IL_006a: Unknown result type (might be due to invalid IL or missing references)
			_eNqfeKhXj4x1FkHQitvzRQ1JLSE = value;
			if (!_iHJrndJdM1jj9TEnuU3BvgdDuvf.smethod_1(_eNqfeKhXj4x1FkHQitvzRQ1JLSE))
			{
				goto IL_0014;
			}
			goto IL_0064;
			IL_0064:
			_0IQKqP6KjSSBSTlZR0Y2K1CamuH = Vector2.get_Zero();
			int num = -1003592372;
			goto IL_003f;
			IL_003f:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA8AF2E4Cu) % 5u)
				{
				case 4u:
					break;
				case 3u:
					_0IQKqP6KjSSBSTlZR0Y2K1CamuH = _iHJrndJdM1jj9TEnuU3BvgdDuvf.smethod_2(_UlZpHdih1X5ig1k6QjZ497jtA1A, _eNqfeKhXj4x1FkHQitvzRQ1JLSE);
					num = (int)(num2 * 1128957647) ^ -1840247018;
					continue;
				default:
					return;
				case 1u:
					goto IL_0064;
				case 0u:
					return;
				case 2u:
					return;
				}
				break;
			}
			goto IL_0014;
			IL_0014:
			num = -1145580965;
			goto IL_003f;
		}
	}

	public _iHJrndJdM1jj9TEnuU3BvgdDuvf(Texture2D texture2D_0, Texture2D texture2D_1, SpriteFont spriteFont_0, string string_0, Color color_0, Action action_0)
		: base(texture2D_0, texture2D_1, action_0)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		_UlZpHdih1X5ig1k6QjZ497jtA1A = spriteFont_0;
		_K87Hdb6ToAR0us3tN3ZmvHdPdeJ = string_0;
		_9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA = color_0;
	}

	public override void _f5ctqAmdNsZ889UjM4LxDm8WGxA(SpriteBatch spriteBatch_0)
	{
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		base._f5ctqAmdNsZ889UjM4LxDm8WGxA(spriteBatch_0);
		while (true)
		{
			int num = -666378668;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8C15FEEFu) % 6u)
				{
				case 4u:
					_zqzgCa0m3Wy0XOFPjEWDVqp6Ybb.X = (float)base._7Xn1C5tjYnmIif1iZKV8AWsEEbL + ((float)_2psWLw4AI8EIjQzaXnhGg8M1FnaA.Width - _0IQKqP6KjSSBSTlZR0Y2K1CamuH.X) / 2f;
					num = -609563562;
					continue;
				case 3u:
					_zqzgCa0m3Wy0XOFPjEWDVqp6Ybb.Y = (float)base._bCjZ3VSXGKyhmykd2zCnQBiSpDf + ((float)_2psWLw4AI8EIjQzaXnhGg8M1FnaA.Height - _0IQKqP6KjSSBSTlZR0Y2K1CamuH.Y) / 2f;
					spriteBatch_0._FY70IFLoBond3ORPe0ndCLvIeVcA(_UlZpHdih1X5ig1k6QjZ497jtA1A, _eNqfeKhXj4x1FkHQitvzRQ1JLSE, _zqzgCa0m3Wy0XOFPjEWDVqp6Ybb, _9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA);
					num = ((int)num2 * -418024739) ^ 0x5424A1A7;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (_iHJrndJdM1jj9TEnuU3BvgdDuvf.smethod_1(_K87Hdb6ToAR0us3tN3ZmvHdPdeJ))
					{
						num3 = 907010246;
						num4 = 907010246;
					}
					else
					{
						num3 = 280630536;
						num4 = 280630536;
					}
					num = num3 ^ (int)(num2 * 2078183735);
					continue;
				}
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				case 5u:
					return;
				}
				break;
			}
		}
	}

	static bool smethod_1(string string_0)
	{
		return string.IsNullOrEmpty(string_0);
	}

	static Vector2 smethod_2(SpriteFont spriteFont_0, string string_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return spriteFont_0.MeasureString(string_0);
	}
}
