using System;
using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Spine;

public abstract class _tfDAeR6npiqJMLRSXPO1DxGA0TgA : _QGGOTxZ8aNWGh0hc26wcmx8wmwT
{
	private class _eBuDnRXeABWf8uwfsN15PfKEHw
	{
		public Vector2 _Jh6AK28sBy2bS8ZCoKHP3LX45Uk { get; set; }

		public RenderTarget2D _Z5JOwYZpe1u3WDYizFmDS7dmAcK { get; set; }

		public float _WxTaPaOE8qb7d7anVlwwqCzugAo { get; set; }
	}

	private readonly _NxPDyghimJKCwBg53DaNTazjQ5k _YWKqVMq3bCWDIv73VmJykYuZBKN;

	private bool _7sgRQPgr8EJYjFmEXCYagaObJd0;

	private int? _xm9p2W8AbxEBdrI3wbC7knvB06R;

	private bool _FdDzmVlp0fgTsGUxfkRfLr0dxtF;

	private readonly _eBuDnRXeABWf8uwfsN15PfKEHw[] _smM3y5A19la8hNpeOINXXDeitDH;

	private NPCLocation _KouBKjmDwRJIjRK4fKJ8PzNn9uV;

	public _nHdiyIURlAiaNZ8u6MKzxjcwnyL _1BgOJ3z4ZUXNS2L4JWf24pr41hB { get; private set; }

	public override float _QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_7Xn1C5tjYnmIif1iZKV8AWsEEbL { get; set; }

	public override float _QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_bCjZ3VSXGKyhmykd2zCnQBiSpDf { get; set; }

	public override bool _QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_Pv8G2bIbjHmJYrVXhNyr64NSPXn
	{
		get
		{
			return _1BgOJ3z4ZUXNS2L4JWf24pr41hB._Hwt6L2NJfXmAfG6UOH8NVlNfGCR;
		}
		set
		{
			_1BgOJ3z4ZUXNS2L4JWf24pr41hB._Hwt6L2NJfXmAfG6UOH8NVlNfGCR = value;
		}
	}

	public Texture2D _1AqpgY4vB6ly5vxOay6j86rcIEo { get; set; }

	public Func<int, string, bool> _YwAdHC5A5VB16lereNxJLkAP3Z9A { get; set; }

	protected _tfDAeR6npiqJMLRSXPO1DxGA0TgA(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0, string string_0, float float_0 = 1f, bool bool_0 = true)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		_1BgOJ3z4ZUXNS2L4JWf24pr41hB = base._ZzBuoSDMWwerejOO9Goyv2OCKgE._uwNDZuqdFb9tyQtlQMxiz1DQ7x8._7BVREQXEcBCieHb0qgaVDpUj1ni(string_0, float_0, bool_0);
		_1BgOJ3z4ZUXNS2L4JWf24pr41hB._c4iC7y9v6xg7LpvjKIeUkOdZ3UF(0f);
		base._fO7gSlrDDNMoHR4FO5QXAq8fUyA = float_0;
		_YWKqVMq3bCWDIv73VmJykYuZBKN = new _NxPDyghimJKCwBg53DaNTazjQ5k();
		_smM3y5A19la8hNpeOINXXDeitDH = new _eBuDnRXeABWf8uwfsN15PfKEHw[2];
		_FdDzmVlp0fgTsGUxfkRfLr0dxtF = true;
	}

	public override void _tiBFUHPEkedkbgvuX3whdeyjhKo(GameTime gameTime_0)
	{
		if (_FdDzmVlp0fgTsGUxfkRfLr0dxtF)
		{
			goto IL_002a;
		}
		goto IL_0050;
		IL_0050:
		base._tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime_0);
		int num = -315458550;
		goto IL_002f;
		IL_002f:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x884BDE64u) % 4u)
			{
			case 1u:
				_1BgOJ3z4ZUXNS2L4JWf24pr41hB._tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime_0);
				num = (int)((num2 * 1511897877) ^ 0x20FC692E);
				continue;
			case 0u:
				break;
			default:
				return;
			case 3u:
				goto IL_0050;
			case 2u:
				return;
			}
			break;
		}
		goto IL_002a;
		IL_002a:
		num = -663029011;
		goto IL_002f;
	}

	public void _f5ctqAmdNsZ889UjM4LxDm8WGxA(SpriteBatch spriteBatch_0, SkeletonMeshRenderer skeletonMeshRenderer_0)
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		base._f5ctqAmdNsZ889UjM4LxDm8WGxA();
		if (_7sgRQPgr8EJYjFmEXCYagaObJd0)
		{
			goto IL_01ad;
		}
		goto IL_0201;
		IL_0201:
		_1BgOJ3z4ZUXNS2L4JWf24pr41hB._7Xn1C5tjYnmIif1iZKV8AWsEEbL = _QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_7Xn1C5tjYnmIif1iZKV8AWsEEbL;
		int num = -1286518057;
		goto IL_01b2;
		IL_01b2:
		int num3 = default(int);
		_eBuDnRXeABWf8uwfsN15PfKEHw eBuDnRXeABWf8uwfsN15PfKEHw = default(_eBuDnRXeABWf8uwfsN15PfKEHw);
		Color val2 = default(Color);
		_eBuDnRXeABWf8uwfsN15PfKEHw[] smM3y5A19la8hNpeOINXXDeitDH = default(_eBuDnRXeABWf8uwfsN15PfKEHw[]);
		while (true)
		{
			uint num2;
			Color val;
			switch ((num2 = (uint)num ^ 0xD5EE58B3u) % 15u)
			{
			case 14u:
				break;
			case 13u:
				if (!_IvIFs0Tl6RHdTn3daJXsNCXCNyO)
				{
					num = ((int)num2 * -613371941) ^ 0x6AB066CC;
					continue;
				}
				val = Color.get_Red();
				goto IL_0059;
			case 12u:
				num = ((int)num2 * -1615277451) ^ -1776599659;
				continue;
			case 11u:
				num3++;
				num = -1594688316;
				continue;
			case 10u:
				spriteBatch_0._f5ctqAmdNsZ889UjM4LxDm8WGxA((Texture2D)(object)eBuDnRXeABWf8uwfsN15PfKEHw._Z5JOwYZpe1u3WDYizFmDS7dmAcK, (Vector2?)null, (Rectangle?)new Rectangle((int)_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_7Xn1C5tjYnmIif1iZKV8AWsEEbL, (int)_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_bCjZ3VSXGKyhmykd2zCnQBiSpDf, _tfDAeR6npiqJMLRSXPO1DxGA0TgA.smethod_6((Texture2D)(object)eBuDnRXeABWf8uwfsN15PfKEHw._Z5JOwYZpe1u3WDYizFmDS7dmAcK), _tfDAeR6npiqJMLRSXPO1DxGA0TgA.smethod_7((Texture2D)(object)eBuDnRXeABWf8uwfsN15PfKEHw._Z5JOwYZpe1u3WDYizFmDS7dmAcK)), (Rectangle?)null, (Vector2?)eBuDnRXeABWf8uwfsN15PfKEHw._Jh6AK28sBy2bS8ZCoKHP3LX45Uk, 0f, (Vector2?)null, (Color?)(val2 * eBuDnRXeABWf8uwfsN15PfKEHw._WxTaPaOE8qb7d7anVlwwqCzugAo), (SpriteEffects)0, 0f);
				num = ((int)num2 * -1970127528) ^ 0x2B2091D6;
				continue;
			case 9u:
				_4nhWi4RWJVAsAaRiBUYVgLfEiCz(skeletonMeshRenderer_0);
				_tfDAeR6npiqJMLRSXPO1DxGA0TgA.smethod_5(spriteBatch_0);
				num = ((int)num2 * -1636861209) ^ -373303802;
				continue;
			case 8u:
				goto IL_013b;
			case 6u:
				_1BgOJ3z4ZUXNS2L4JWf24pr41hB._bCjZ3VSXGKyhmykd2zCnQBiSpDf = _QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_bCjZ3VSXGKyhmykd2zCnQBiSpDf;
				num = ((int)num2 * -1562332160) ^ 0x7561438;
				continue;
			case 5u:
				val = Color.get_White();
				goto IL_0059;
			case 4u:
				spriteBatch_0.End();
				num = (int)(num2 * 1166033712) ^ -759319567;
				continue;
			case 2u:
				num3 = 0;
				num = ((int)num2 * -1177487305) ^ 0x4C4A846A;
				continue;
			case 0u:
				goto end_IL_01b2;
			case 3u:
				goto IL_0201;
			case 1u:
				return;
			default:
				{
					_1BgOJ3z4ZUXNS2L4JWf24pr41hB._f5ctqAmdNsZ889UjM4LxDm8WGxA(skeletonMeshRenderer_0, float_0: base._fO7gSlrDDNMoHR4FO5QXAq8fUyA, texture2D_0: _1AqpgY4vB6ly5vxOay6j86rcIEo, func_0: _YwAdHC5A5VB16lereNxJLkAP3Z9A, nullable_0: _IvIFs0Tl6RHdTn3daJXsNCXCNyO ? new Color?(new Color(1, 0, 0, 1)) : null);
					return;
				}
				IL_0059:
				val2 = val;
				smM3y5A19la8hNpeOINXXDeitDH = _smM3y5A19la8hNpeOINXXDeitDH;
				num = -518239009;
				continue;
			}
			eBuDnRXeABWf8uwfsN15PfKEHw = smM3y5A19la8hNpeOINXXDeitDH[num3];
			int num4;
			if (eBuDnRXeABWf8uwfsN15PfKEHw != null)
			{
				num = -152765853;
				num4 = -152765853;
			}
			else
			{
				num = -1540155818;
				num4 = -1540155818;
			}
			continue;
			IL_013b:
			int num5;
			if (num3 < smM3y5A19la8hNpeOINXXDeitDH.Length)
			{
				num = -1771532670;
				num5 = -1771532670;
			}
			else
			{
				num = -569554979;
				num5 = -569554979;
			}
			continue;
			end_IL_01b2:
			break;
		}
		goto IL_01ad;
		IL_01ad:
		num = -1526900538;
		goto IL_01b2;
	}

	protected override void _aAoZaDNczeScsMfLlGSfAzey9SQ(string string_0, float float_0)
	{
		_1BgOJ3z4ZUXNS2L4JWf24pr41hB._aAoZaDNczeScsMfLlGSfAzey9SQ(string_0, float_0);
	}

	private void _4nhWi4RWJVAsAaRiBUYVgLfEiCz(SkeletonMeshRenderer skeletonMeshRenderer_0)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		if (!_xm9p2W8AbxEBdrI3wbC7knvB06R.HasValue)
		{
			return;
		}
		_eBuDnRXeABWf8uwfsN15PfKEHw eBuDnRXeABWf8uwfsN15PfKEHw = default(_eBuDnRXeABWf8uwfsN15PfKEHw);
		RenderTargetBinding[] renderTargetBinding_ = default(RenderTargetBinding[]);
		while (true)
		{
			int num = -747110951;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF983B17Bu) % 7u)
				{
				case 6u:
					_tfDAeR6npiqJMLRSXPO1DxGA0TgA.smethod_9(base._ZzBuoSDMWwerejOO9Goyv2OCKgE._2yepMkVENnecIsduggABaU2qhXW, eBuDnRXeABWf8uwfsN15PfKEHw._Z5JOwYZpe1u3WDYizFmDS7dmAcK);
					_tfDAeR6npiqJMLRSXPO1DxGA0TgA.smethod_10(base._ZzBuoSDMWwerejOO9Goyv2OCKgE._2yepMkVENnecIsduggABaU2qhXW, Color.get_Transparent());
					_1BgOJ3z4ZUXNS2L4JWf24pr41hB._7Xn1C5tjYnmIif1iZKV8AWsEEbL = eBuDnRXeABWf8uwfsN15PfKEHw._Jh6AK28sBy2bS8ZCoKHP3LX45Uk.X;
					_1BgOJ3z4ZUXNS2L4JWf24pr41hB._bCjZ3VSXGKyhmykd2zCnQBiSpDf = eBuDnRXeABWf8uwfsN15PfKEHw._Jh6AK28sBy2bS8ZCoKHP3LX45Uk.Y;
					_1BgOJ3z4ZUXNS2L4JWf24pr41hB._f5ctqAmdNsZ889UjM4LxDm8WGxA(skeletonMeshRenderer_0, float_0: base._fO7gSlrDDNMoHR4FO5QXAq8fUyA, texture2D_0: _1AqpgY4vB6ly5vxOay6j86rcIEo, func_0: _YwAdHC5A5VB16lereNxJLkAP3Z9A);
					num = (int)(num2 * 441092860) ^ -1100173681;
					continue;
				case 4u:
					renderTargetBinding_ = _tfDAeR6npiqJMLRSXPO1DxGA0TgA.smethod_8(base._ZzBuoSDMWwerejOO9Goyv2OCKgE._2yepMkVENnecIsduggABaU2qhXW);
					num = ((int)num2 * -513907337) ^ 0x7A0BD7AA;
					continue;
				case 3u:
					eBuDnRXeABWf8uwfsN15PfKEHw = _smM3y5A19la8hNpeOINXXDeitDH[_xm9p2W8AbxEBdrI3wbC7knvB06R.Value];
					num = -959614063;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (_smM3y5A19la8hNpeOINXXDeitDH[_xm9p2W8AbxEBdrI3wbC7knvB06R.Value] == null)
					{
						num3 = -2105726283;
						num4 = -2105726283;
					}
					else
					{
						num3 = -2130902402;
						num4 = -2130902402;
					}
					num = num3 ^ (int)(num2 * 1350256135);
					continue;
				}
				case 0u:
					break;
				default:
					_tfDAeR6npiqJMLRSXPO1DxGA0TgA.smethod_11(base._ZzBuoSDMWwerejOO9Goyv2OCKgE._2yepMkVENnecIsduggABaU2qhXW, renderTargetBinding_);
					return;
				case 1u:
					return;
				}
				break;
			}
		}
	}

	protected override bool _BbDRof5yB0Qn864T1KJxUzMy8di(int int_0)
	{
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Expected O, but got Unknown
		if (int_0 == 0)
		{
			goto IL_0168;
		}
		goto IL_02c4;
		IL_02c4:
		int num;
		int num2;
		if (int_0 == 1)
		{
			num = 2089708528;
			num2 = 2089708528;
		}
		else
		{
			num = 222053043;
			num2 = 222053043;
		}
		goto IL_025f;
		IL_025f:
		Vector2 val = default(Vector2);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num ^ 0x1D66A117u) % 17u)
			{
			case 15u:
				_YWKqVMq3bCWDIv73VmJykYuZBKN._tiBFUHPEkedkbgvuX3whdeyjhKo(_1BgOJ3z4ZUXNS2L4JWf24pr41hB._4puDGlIwmnebKpz1JXzxe4GDuJ4);
				num = ((int)num3 * -660332490) ^ 0x8513AEE;
				continue;
			case 14u:
			{
				int num4;
				int num5;
				if (_KouBKjmDwRJIjRK4fKJ8PzNn9uV != base._9m9LEAgaqaeXydYhykSBmf9BrDG)
				{
					num4 = 2031718031;
					num5 = 2031718031;
				}
				else
				{
					num4 = 658262795;
					num5 = 658262795;
				}
				num = num4 ^ ((int)num3 * -481252424);
				continue;
			}
			case 13u:
				_smM3y5A19la8hNpeOINXXDeitDH[int_0] = null;
				num = 1987101800;
				continue;
			case 10u:
				_FdDzmVlp0fgTsGUxfkRfLr0dxtF = false;
				num = (int)(num3 * 2003600082) ^ -1224101396;
				continue;
			case 9u:
				_1BgOJ3z4ZUXNS2L4JWf24pr41hB._7Xn1C5tjYnmIif1iZKV8AWsEEbL = 0f;
				_1BgOJ3z4ZUXNS2L4JWf24pr41hB._bCjZ3VSXGKyhmykd2zCnQBiSpDf = 0f;
				num = ((int)num3 * -342656111) ^ 0x500C11CB;
				continue;
			case 8u:
				((Vector2)(ref val))._002Ector((float)(int)_YWKqVMq3bCWDIv73VmJykYuZBKN._je8rVfyg4zywmqSi4Ozx1z7wJ4b, (float)(int)_YWKqVMq3bCWDIv73VmJykYuZBKN._WJfGWBzn4wgdGBnMWRH2pcJ3AqH);
				num = (int)(num3 * 1728417163) ^ -132102607;
				continue;
			case 7u:
			{
				int num8;
				int num9;
				if (!(val.X <= 0f))
				{
					num8 = 1915292202;
					num9 = 1915292202;
				}
				else
				{
					num8 = 1859593654;
					num9 = 1859593654;
				}
				num = num8 ^ (int)(num3 * 711024100);
				continue;
			}
			case 6u:
			{
				int num6;
				int num7;
				if (val.Y <= 0f)
				{
					num6 = -1226741968;
					num7 = -1226741968;
				}
				else
				{
					num6 = -782239586;
					num7 = -782239586;
				}
				num = num6 ^ ((int)num3 * -1985003190);
				continue;
			}
			case 5u:
				break;
			case 4u:
				goto IL_0172;
			case 3u:
				_smM3y5A19la8hNpeOINXXDeitDH[int_0] = new _eBuDnRXeABWf8uwfsN15PfKEHw
				{
					_Jh6AK28sBy2bS8ZCoKHP3LX45Uk = new Vector2(_tfDAeR6npiqJMLRSXPO1DxGA0TgA.smethod_13(_tfDAeR6npiqJMLRSXPO1DxGA0TgA.smethod_12(_1BgOJ3z4ZUXNS2L4JWf24pr41hB._4puDGlIwmnebKpz1JXzxe4GDuJ4)) - _YWKqVMq3bCWDIv73VmJykYuZBKN._SjhHztt8d5kOtb7Z2BJKnZZxEKh, _tfDAeR6npiqJMLRSXPO1DxGA0TgA.smethod_14(_tfDAeR6npiqJMLRSXPO1DxGA0TgA.smethod_12(_1BgOJ3z4ZUXNS2L4JWf24pr41hB._4puDGlIwmnebKpz1JXzxe4GDuJ4)) - _YWKqVMq3bCWDIv73VmJykYuZBKN._xqxFKfudZYzf8RtrC7EB1Ya6FPT),
					_Z5JOwYZpe1u3WDYizFmDS7dmAcK = new RenderTarget2D(base._ZzBuoSDMWwerejOO9Goyv2OCKgE._2yepMkVENnecIsduggABaU2qhXW, (int)val.X, (int)val.Y),
					_WxTaPaOE8qb7d7anVlwwqCzugAo = ((int_0 == 0) ? 1f : 0f)
				};
				num = 1987101800;
				continue;
			case 2u:
				_7sgRQPgr8EJYjFmEXCYagaObJd0 = true;
				_xm9p2W8AbxEBdrI3wbC7knvB06R = int_0;
				num = 1555908824;
				continue;
			case 1u:
				_KouBKjmDwRJIjRK4fKJ8PzNn9uV = base._9m9LEAgaqaeXydYhykSBmf9BrDG;
				num = ((int)num3 * -1589217614) ^ -665458333;
				continue;
			case 11u:
				goto IL_02c4;
			default:
				return true;
			case 12u:
				_xm9p2W8AbxEBdrI3wbC7knvB06R = null;
				return false;
			case 16u:
				return false;
			}
			break;
			IL_0172:
			int num10;
			if (int_0 >= 2)
			{
				num = 1924868840;
				num10 = 1924868840;
			}
			else
			{
				num = 1695788423;
				num10 = 1695788423;
			}
		}
		goto IL_0168;
		IL_0168:
		num = 1530392789;
		goto IL_025f;
	}

	protected override void _PdRLTpsImBScBFQhILtCHJpcsllA(float float_0)
	{
		if (_smM3y5A19la8hNpeOINXXDeitDH[0] != null)
		{
			goto IL_001c;
		}
		goto IL_0092;
		IL_0092:
		int num;
		int num2;
		if (_smM3y5A19la8hNpeOINXXDeitDH[1] != null)
		{
			num = -412587085;
			num2 = -412587085;
		}
		else
		{
			num = -1554738981;
			num2 = -1554738981;
		}
		goto IL_0061;
		IL_0061:
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num ^ 0xA697EFADu) % 5u)
			{
			case 4u:
				break;
			case 3u:
				_smM3y5A19la8hNpeOINXXDeitDH[0]._WxTaPaOE8qb7d7anVlwwqCzugAo = float_0;
				num = ((int)num3 * -1399172433) ^ 0x44FA9116;
				continue;
			case 2u:
				_smM3y5A19la8hNpeOINXXDeitDH[1]._WxTaPaOE8qb7d7anVlwwqCzugAo = 1f - float_0;
				num = ((int)num3 * -1475743035) ^ 0xAC797CD;
				continue;
			default:
				return;
			case 1u:
				goto IL_0092;
			case 0u:
				return;
			}
			break;
		}
		goto IL_001c;
		IL_001c:
		num = -646436610;
		goto IL_0061;
	}

	protected override void _Hx7zLXU6nbxudxFgMuYbyRXeEPB()
	{
		_7sgRQPgr8EJYjFmEXCYagaObJd0 = false;
		_xm9p2W8AbxEBdrI3wbC7knvB06R = null;
		while (true)
		{
			int num = 267752474;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1C76BC62u) % 9u)
				{
				case 8u:
					_tfDAeR6npiqJMLRSXPO1DxGA0TgA.smethod_15((GraphicsResource)(object)_smM3y5A19la8hNpeOINXXDeitDH[1]._Z5JOwYZpe1u3WDYizFmDS7dmAcK);
					num = (int)((num2 * 1119512256) ^ 0x24219B92);
					continue;
				case 6u:
				{
					int num5;
					if (_smM3y5A19la8hNpeOINXXDeitDH[1] != null)
					{
						num = 1870885890;
						num5 = 1870885890;
					}
					else
					{
						num = 386923651;
						num5 = 386923651;
					}
					continue;
				}
				case 5u:
				{
					int num3;
					int num4;
					if (_smM3y5A19la8hNpeOINXXDeitDH[0] != null)
					{
						num3 = -467381826;
						num4 = -467381826;
					}
					else
					{
						num3 = -149854688;
						num4 = -149854688;
					}
					num = num3 ^ (int)(num2 * 1702131818);
					continue;
				}
				case 3u:
					_tfDAeR6npiqJMLRSXPO1DxGA0TgA.smethod_15((GraphicsResource)(object)_smM3y5A19la8hNpeOINXXDeitDH[0]._Z5JOwYZpe1u3WDYizFmDS7dmAcK);
					num = ((int)num2 * -673227256) ^ -1934759623;
					continue;
				case 2u:
					_smM3y5A19la8hNpeOINXXDeitDH[1] = null;
					num = ((int)num2 * -264652170) ^ 0x55C88423;
					continue;
				case 1u:
					_FdDzmVlp0fgTsGUxfkRfLr0dxtF = true;
					num = (int)((num2 * 2014095639) ^ 0x791DAF92);
					continue;
				case 0u:
					_smM3y5A19la8hNpeOINXXDeitDH[0] = null;
					num = (int)(num2 * 810146765) ^ -1623208657;
					continue;
				default:
					return;
				case 4u:
					break;
				case 7u:
					return;
				}
				break;
			}
		}
	}

	static void smethod_5(SpriteBatch spriteBatch_0)
	{
		spriteBatch_0.Begin();
	}

	static int smethod_6(Texture2D texture2D_0)
	{
		return texture2D_0.get_Width();
	}

	static int smethod_7(Texture2D texture2D_0)
	{
		return texture2D_0.get_Height();
	}

	static RenderTargetBinding[] smethod_8(GraphicsDevice graphicsDevice_0)
	{
		return graphicsDevice_0.GetRenderTargets();
	}

	static void smethod_9(GraphicsDevice graphicsDevice_0, RenderTarget2D renderTarget2D_0)
	{
		graphicsDevice_0.SetRenderTarget(renderTarget2D_0);
	}

	static void smethod_10(GraphicsDevice graphicsDevice_0, Color color_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		graphicsDevice_0.Clear(color_0);
	}

	static void smethod_11(GraphicsDevice graphicsDevice_0, RenderTargetBinding[] renderTargetBinding_0)
	{
		graphicsDevice_0.SetRenderTargets(renderTargetBinding_0);
	}

	static Bone smethod_12(Skeleton skeleton_0)
	{
		return skeleton_0.get_RootBone();
	}

	static float smethod_13(Bone bone_0)
	{
		return bone_0.get_WorldX();
	}

	static float smethod_14(Bone bone_0)
	{
		return bone_0.get_WorldY();
	}

	static void smethod_15(GraphicsResource graphicsResource_0)
	{
		graphicsResource_0.Dispose();
	}
}
