using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Spine;

namespace Amorous.Game.Sexscenes;

public class SkyeSexscene : CensoredSexscene
{
	public const string _SIHadD6cwfqQgHEvKqYhLp1ptN0 = "Gray";

	public const string _8WiBHk4ojcKXNJ8Iq6MFEuNQ4gT = "Yellow";

	public const string _KDxkn5aSvEobDXVkoiuQmEphQ6J = "Blue";

	private Texture2D _p65Ex7slWkEu44TWzMfnrHkavQb;

	private Texture2D _a2vuTNBvRtI0ysFdoyLqbnVKmKb;

	private Texture2D _8Wpyx8UxfA2ieouQH6qdonhcCok;

	private static readonly List<SpineEvent> _zAqFZFiaBbpl6Gf6nSX9UC3cSh6;

	public SkyeSexscene(ContentManager contentManager_0)
		: base(contentManager_0, _003CModule_003E.smethod_26<string>(508777207u), _003CModule_003E.smethod_27<string>(1393417785u), null, list_0: _zAqFZFiaBbpl6Gf6nSX9UC3cSh6, _sa8EsNgk4VDRaASdXE7VprdlNlg_0: _sg4TvSTYoH0YwumBfYnvr7IeDaT._AZrO8MxMUE7cKsFYTQ4k9O3q7yC(contentManager_0), float_0: SkyeSexscene.smethod_14() ? 2f : 1f, bool_0: true, float_1: 3000f)
	{
		bool flag2 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = 527249467;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD15F4Du) % 21u)
				{
				case 19u:
					SkyeSexscene.smethod_18(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), 1100f);
					num = (int)(num2 * 188343293) ^ -358516605;
					continue;
				case 18u:
					SkyeSexscene.smethod_17(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), 1500f);
					num = ((int)num2 * -912714737) ^ 0x44FE6DBD;
					continue;
				case 17u:
				{
					int num4;
					if (flag2)
					{
						num = 126623247;
						num4 = 126623247;
					}
					else
					{
						num = 1705571092;
						num4 = 1705571092;
					}
					continue;
				}
				case 15u:
					SkyeSexscene.smethod_21((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this, _003CModule_003E.smethod_24<string>(3977583864u));
					num = ((int)num2 * -487802181) ^ -263375689;
					continue;
				case 14u:
				{
					_opIJo2jLUqdOL5yAFP4yzXce0DG opIJo2jLUqdOL5yAFP4yzXce0DG_ = SkyeSexscene.smethod_19();
					flag = SkyeSexscene.smethod_20(opIJo2jLUqdOL5yAFP4yzXce0DG_, _003CModule_003E.smethod_28<string>(1045563614u));
					flag2 = SkyeSexscene.smethod_20(opIJo2jLUqdOL5yAFP4yzXce0DG_, _003CModule_003E.smethod_24<string>(109400315u));
					num = (int)(num2 * 2011771227) ^ -2042457305;
					continue;
				}
				case 13u:
					SkyeSexscene.smethod_21((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this, _003CModule_003E.smethod_28<string>(3135959319u));
					num = (int)(num2 * 595257188) ^ -166903749;
					continue;
				case 12u:
				{
					int num7;
					int num8;
					if (!(flag && flag2))
					{
						num7 = 1125116984;
						num8 = 1125116984;
					}
					else
					{
						num7 = 1756947565;
						num8 = 1756947565;
					}
					num = num7 ^ (int)(num2 * 1906946775);
					continue;
				}
				case 11u:
					_a2vuTNBvRtI0ysFdoyLqbnVKmKb = contentManager_0.Load<Texture2D>(_003CModule_003E.smethod_24<string>(1671342953u));
					_8Wpyx8UxfA2ieouQH6qdonhcCok = contentManager_0.Load<Texture2D>(_003CModule_003E.smethod_25<string>(562112389u));
					num = (int)((num2 * 1221396719) ^ 0x7AF16B4C);
					continue;
				case 10u:
					SkyeSexscene.smethod_16(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_28<string>(420718839u), (Action<int>)null);
					num = ((int)num2 * -219315432) ^ 0x30773C68;
					continue;
				case 8u:
					SkyeSexscene.smethod_17(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), 950f);
					num = 310692288;
					continue;
				case 7u:
				{
					int num5;
					int num6;
					if (SkyeSexscene.smethod_14())
					{
						num5 = 420297956;
						num6 = 420297956;
					}
					else
					{
						num5 = 289932586;
						num6 = 289932586;
					}
					num = num5 ^ (int)(num2 * 952613099);
					continue;
				}
				case 6u:
					SkyeSexscene.smethod_21((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this, _003CModule_003E.smethod_27<string>(3546327314u));
					num = ((int)num2 * -1293535002) ^ -928390319;
					continue;
				case 4u:
				{
					int num3;
					if (!flag)
					{
						num = 1631331468;
						num3 = 1631331468;
					}
					else
					{
						num = 1305249446;
						num3 = 1305249446;
					}
					continue;
				}
				case 3u:
					SkyeSexscene.smethod_18(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), 2000f);
					num = ((int)num2 * -1809082333) ^ -763083908;
					continue;
				case 1u:
					_p65Ex7slWkEu44TWzMfnrHkavQb = contentManager_0.Load<Texture2D>(_003CModule_003E.smethod_24<string>(2906227845u));
					num = 2147199595;
					continue;
				case 0u:
					SkyeSexscene.smethod_21((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this, _003CModule_003E.smethod_24<string>(4286305087u));
					num = 820739383;
					continue;
				default:
					return;
				case 20u:
					break;
				case 2u:
					return;
				case 5u:
					return;
				case 9u:
					return;
				case 16u:
					return;
				}
				break;
			}
		}
	}

	public override string[] _tCw3HO9jqoEm2Ad1hqdKsA8vS7b()
	{
		return new string[3]
		{
			_003CModule_003E.smethod_25<string>(1972244602u),
			_003CModule_003E.smethod_26<string>(4197045251u),
			_003CModule_003E.smethod_27<string>(921424119u)
		};
	}

	public override void _GGyEXu1JJKcG2X3txvtCwyZAylK(string string_0)
	{
		this.method_9(string_0);
		while (true)
		{
			int num = 1183631601;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3FC4E521u) % 11u)
				{
				case 9u:
				{
					int num5;
					int num6;
					if (SkyeSexscene.smethod_22(string_0, _003CModule_003E.smethod_25<string>(2375139520u)))
					{
						num5 = -261307233;
						num6 = -261307233;
					}
					else
					{
						num5 = -740772748;
						num6 = -740772748;
					}
					num = num5 ^ ((int)num2 * -1496147452);
					continue;
				}
				case 8u:
					SkyeSexscene.smethod_23((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this, _a2vuTNBvRtI0ysFdoyLqbnVKmKb);
					num = 1141605125;
					continue;
				case 7u:
				{
					int num7;
					int num8;
					if (SkyeSexscene.smethod_22(string_0, _003CModule_003E.smethod_24<string>(3977583864u)))
					{
						num7 = 2146229679;
						num8 = 2146229679;
					}
					else
					{
						num7 = 194263320;
						num8 = 194263320;
					}
					num = num7 ^ (int)(num2 * 1950874902);
					continue;
				}
				case 5u:
					SkyeSexscene.smethod_23((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this, _p65Ex7slWkEu44TWzMfnrHkavQb);
					num = 1574507391;
					continue;
				case 2u:
					SkyeSexscene.smethod_23((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this, _8Wpyx8UxfA2ieouQH6qdonhcCok);
					num = 1671516137;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (SkyeSexscene.smethod_22(string_0, _003CModule_003E.smethod_24<string>(4286305087u)))
					{
						num3 = -1911194089;
						num4 = -1911194089;
					}
					else
					{
						num3 = -442982768;
						num4 = -442982768;
					}
					num = num3 ^ (int)(num2 * 892411066);
					continue;
				}
				default:
					return;
				case 6u:
					break;
				case 0u:
					return;
				case 3u:
					return;
				case 4u:
					return;
				case 10u:
					return;
				}
				break;
			}
		}
	}

	protected override void _coudx6g9HL4THj8r5aYCDxaHH0I(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_030b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Unknown result type (might be due to invalid IL or missing references)
		//IL_0320: Unknown result type (might be due to invalid IL or missing references)
		//IL_0325: Unknown result type (might be due to invalid IL or missing references)
		//IL_061c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0621: Unknown result type (might be due to invalid IL or missing references)
		//IL_0631: Unknown result type (might be due to invalid IL or missing references)
		//IL_0636: Unknown result type (might be due to invalid IL or missing references)
		//IL_0646: Unknown result type (might be due to invalid IL or missing references)
		//IL_064b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0670: Unknown result type (might be due to invalid IL or missing references)
		//IL_0675: Unknown result type (might be due to invalid IL or missing references)
		//IL_0685: Unknown result type (might be due to invalid IL or missing references)
		//IL_068a: Unknown result type (might be due to invalid IL or missing references)
		//IL_069a: Unknown result type (might be due to invalid IL or missing references)
		//IL_069f: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_080f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0814: Unknown result type (might be due to invalid IL or missing references)
		//IL_0839: Unknown result type (might be due to invalid IL or missing references)
		//IL_083e: Unknown result type (might be due to invalid IL or missing references)
		//IL_084e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0853: Unknown result type (might be due to invalid IL or missing references)
		//IL_0863: Unknown result type (might be due to invalid IL or missing references)
		//IL_0868: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_090c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0911: Unknown result type (might be due to invalid IL or missing references)
		//IL_0921: Unknown result type (might be due to invalid IL or missing references)
		//IL_0926: Unknown result type (might be due to invalid IL or missing references)
		SkyeSexscene.smethod_24(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), 0f);
		while (true)
		{
			int num = 395634713;
			while (true)
			{
				uint num2;
				Color val;
				switch ((num2 = (uint)num ^ 0x7036F47Du) % 33u)
				{
				case 32u:
					SkyeSexscene.smethod_25(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_27<string>(2834719561u), 1f);
					SkyeSexscene.smethod_25(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_24<string>(1825328606u), 1f);
					num = ((int)num2 * -183850062) ^ -817810392;
					continue;
				case 31u:
				{
					_nHdiyIURlAiaNZ8u6MKzxjcwnyL nHdiyIURlAiaNZ8u6MKzxjcwnyL11 = base._1BgOJ3z4ZUXNS2L4JWf24pr41hB;
					string string_11 = _003CModule_003E.smethod_24<string>(1298818858u);
					val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._zBv1cYqPRU7uDCALpBlBSgObUcbA;
					float float_21 = (float)(int)((Color)(ref val)).get_R() / 255f;
					val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._zBv1cYqPRU7uDCALpBlBSgObUcbA;
					float float_22 = (float)(int)((Color)(ref val)).get_G() / 255f;
					val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._zBv1cYqPRU7uDCALpBlBSgObUcbA;
					nHdiyIURlAiaNZ8u6MKzxjcwnyL11._VoeevpFh2kLKfHtpPDXWt0TFbuH(string_11, float_21, float_22, (float)(int)((Color)(ref val)).get_B() / 255f);
					num = ((int)num2 * -1073682705) ^ -197810843;
					continue;
				}
				case 30u:
				{
					_nHdiyIURlAiaNZ8u6MKzxjcwnyL nHdiyIURlAiaNZ8u6MKzxjcwnyL = base._1BgOJ3z4ZUXNS2L4JWf24pr41hB;
					string string_ = _003CModule_003E.smethod_25<string>(959850315u);
					val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._XnNREK59QnV1onFFWfSUaS9WK0E;
					float float_ = (float)(int)((Color)(ref val)).get_R() / 255f;
					val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._XnNREK59QnV1onFFWfSUaS9WK0E;
					float float_2 = (float)(int)((Color)(ref val)).get_G() / 255f;
					val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._XnNREK59QnV1onFFWfSUaS9WK0E;
					nHdiyIURlAiaNZ8u6MKzxjcwnyL._VoeevpFh2kLKfHtpPDXWt0TFbuH(string_, float_, float_2, (float)(int)((Color)(ref val)).get_B() / 255f);
					num = ((int)num2 * -1479733753) ^ -842043252;
					continue;
				}
				case 28u:
				{
					_nHdiyIURlAiaNZ8u6MKzxjcwnyL nHdiyIURlAiaNZ8u6MKzxjcwnyL2 = base._1BgOJ3z4ZUXNS2L4JWf24pr41hB;
					string string_2 = _003CModule_003E.smethod_27<string>(2369960403u);
					val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._TxfCqloeyiHpsXka6B46iqCZNsZ;
					float float_3 = (float)(int)((Color)(ref val)).get_R() / 255f;
					val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._TxfCqloeyiHpsXka6B46iqCZNsZ;
					float float_4 = (float)(int)((Color)(ref val)).get_G() / 255f;
					val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._TxfCqloeyiHpsXka6B46iqCZNsZ;
					nHdiyIURlAiaNZ8u6MKzxjcwnyL2._VoeevpFh2kLKfHtpPDXWt0TFbuH(string_2, float_3, float_4, (float)(int)((Color)(ref val)).get_B() / 255f);
					_nHdiyIURlAiaNZ8u6MKzxjcwnyL nHdiyIURlAiaNZ8u6MKzxjcwnyL3 = base._1BgOJ3z4ZUXNS2L4JWf24pr41hB;
					string string_3 = _003CModule_003E.smethod_28<string>(2127111933u);
					val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._TxfCqloeyiHpsXka6B46iqCZNsZ;
					float float_5 = (float)(int)((Color)(ref val)).get_R() / 255f;
					val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._TxfCqloeyiHpsXka6B46iqCZNsZ;
					float float_6 = (float)(int)((Color)(ref val)).get_G() / 255f;
					val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._TxfCqloeyiHpsXka6B46iqCZNsZ;
					nHdiyIURlAiaNZ8u6MKzxjcwnyL3._VoeevpFh2kLKfHtpPDXWt0TFbuH(string_3, float_5, float_6, (float)(int)((Color)(ref val)).get_B() / 255f);
					num = ((int)num2 * -2111747208) ^ -1090731798;
					continue;
				}
				case 27u:
					SkyeSexscene.smethod_25(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_25<string>(2842605095u), 1f);
					num = (int)((num2 * 2064708615) ^ 0x150DE1D4);
					continue;
				case 26u:
					SkyeSexscene.smethod_25(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_28<string>(1670408389u), 1f);
					num = ((int)num2 * -1222093953) ^ 0x349C1BD6;
					continue;
				case 25u:
				{
					_nHdiyIURlAiaNZ8u6MKzxjcwnyL nHdiyIURlAiaNZ8u6MKzxjcwnyL7 = base._1BgOJ3z4ZUXNS2L4JWf24pr41hB;
					string string_7 = _003CModule_003E.smethod_24<string>(63933966u);
					val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._TxfCqloeyiHpsXka6B46iqCZNsZ;
					float float_13 = (float)(int)((Color)(ref val)).get_R() / 255f;
					val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._TxfCqloeyiHpsXka6B46iqCZNsZ;
					float float_14 = (float)(int)((Color)(ref val)).get_G() / 255f;
					val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._TxfCqloeyiHpsXka6B46iqCZNsZ;
					nHdiyIURlAiaNZ8u6MKzxjcwnyL7._VoeevpFh2kLKfHtpPDXWt0TFbuH(string_7, float_13, float_14, (float)(int)((Color)(ref val)).get_B() / 255f);
					num = (int)(num2 * 461429451) ^ -1428778794;
					continue;
				}
				case 24u:
					SkyeSexscene.smethod_25(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_25<string>(3044052554u), 1f);
					SkyeSexscene.smethod_25(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_27<string>(4265169575u), 1f);
					num = (int)((num2 * 2095985147) ^ 0x5DB0A543);
					continue;
				case 23u:
				{
					_nHdiyIURlAiaNZ8u6MKzxjcwnyL nHdiyIURlAiaNZ8u6MKzxjcwnyL10 = base._1BgOJ3z4ZUXNS2L4JWf24pr41hB;
					string string_10 = _003CModule_003E.smethod_28<string>(1505466699u);
					val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._XnNREK59QnV1onFFWfSUaS9WK0E;
					float float_19 = (float)(int)((Color)(ref val)).get_R() / 255f;
					val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._XnNREK59QnV1onFFWfSUaS9WK0E;
					float float_20 = (float)(int)((Color)(ref val)).get_G() / 255f;
					val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._XnNREK59QnV1onFFWfSUaS9WK0E;
					nHdiyIURlAiaNZ8u6MKzxjcwnyL10._VoeevpFh2kLKfHtpPDXWt0TFbuH(string_10, float_19, float_20, (float)(int)((Color)(ref val)).get_B() / 255f);
					num = (int)((num2 * 2067641739) ^ 0x3491524E);
					continue;
				}
				case 22u:
					SkyeSexscene.smethod_25(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_26<string>(260957330u), 1f);
					num = (int)(num2 * 469212501) ^ -1805527074;
					continue;
				case 21u:
					SkyeSexscene.smethod_25(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_24<string>(38509675u), 1f);
					SkyeSexscene.smethod_25(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_26<string>(3141181263u), 1f);
					SkyeSexscene.smethod_25(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_28<string>(1730618930u), SkyeSexscene.smethod_27((Enum)SkyeSexscene.smethod_26(_opIJo2jLUqdOL5yAFP4yzXce0DG_0), (Enum)_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.Stripes) ? 1f : 0f);
					SkyeSexscene.smethod_25(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_27<string>(467516723u), SkyeSexscene.smethod_27((Enum)SkyeSexscene.smethod_26(_opIJo2jLUqdOL5yAFP4yzXce0DG_0), (Enum)_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.Underbelly) ? 1f : 0f);
					num = 251250305;
					continue;
				case 19u:
					SkyeSexscene.smethod_25(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_25<string>(2437131681u), SkyeSexscene.smethod_27((Enum)SkyeSexscene.smethod_26(_opIJo2jLUqdOL5yAFP4yzXce0DG_0), (Enum)_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.Stripes) ? 1f : 0f);
					SkyeSexscene.smethod_25(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_26<string>(2735826870u), SkyeSexscene.smethod_27((Enum)SkyeSexscene.smethod_26(_opIJo2jLUqdOL5yAFP4yzXce0DG_0), (Enum)_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.Underthigh) ? 1f : 0f);
					SkyeSexscene.smethod_25(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_26<string>(2392750154u), 1f);
					SkyeSexscene.smethod_25(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_25<string>(3712965588u), SkyeSexscene.smethod_27((Enum)SkyeSexscene.smethod_26(_opIJo2jLUqdOL5yAFP4yzXce0DG_0), (Enum)_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.Stripes) ? 1f : 0f);
					SkyeSexscene.smethod_25(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_24<string>(1226222683u), SkyeSexscene.smethod_27((Enum)SkyeSexscene.smethod_26(_opIJo2jLUqdOL5yAFP4yzXce0DG_0), (Enum)_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.Underthigh) ? 1f : 0f);
					num = 873491612;
					continue;
				case 18u:
					SkyeSexscene.smethod_25(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_26<string>(2028011076u), 1f);
					num = ((int)num2 * -1333941580) ^ 0x42571FE6;
					continue;
				case 17u:
					SkyeSexscene.smethod_25(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_28<string>(1790829471u), 1f);
					SkyeSexscene.smethod_25(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_28<string>(3598908059u), 1f);
					num = ((int)num2 * -1206856973) ^ -32963669;
					continue;
				case 16u:
					SkyeSexscene.smethod_25(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_24<string>(3695992467u), 1f);
					num = 1276043878;
					continue;
				case 15u:
					SkyeSexscene.smethod_25(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_27<string>(2602339982u), 1f);
					SkyeSexscene.smethod_25(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_26<string>(4050341916u), 1f);
					num = (int)(num2 * 1617783700) ^ -1398668446;
					continue;
				case 14u:
				{
					_nHdiyIURlAiaNZ8u6MKzxjcwnyL nHdiyIURlAiaNZ8u6MKzxjcwnyL8 = SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this);
					string string_8 = _003CModule_003E.smethod_25<string>(1122836848u);
					val = SkyeSexscene.smethod_29(_opIJo2jLUqdOL5yAFP4yzXce0DG_0);
					float float_15 = (float)(int)((Color)(ref val)).get_R() / 255f;
					val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._6f1rvTENt5XWmHTE22zxBIwbH9G;
					float float_16 = (float)(int)((Color)(ref val)).get_G() / 255f;
					val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._6f1rvTENt5XWmHTE22zxBIwbH9G;
					nHdiyIURlAiaNZ8u6MKzxjcwnyL8._VoeevpFh2kLKfHtpPDXWt0TFbuH(string_8, float_15, float_16, (float)(int)((Color)(ref val)).get_B() / 255f);
					_nHdiyIURlAiaNZ8u6MKzxjcwnyL nHdiyIURlAiaNZ8u6MKzxjcwnyL9 = base._1BgOJ3z4ZUXNS2L4JWf24pr41hB;
					string string_9 = _003CModule_003E.smethod_25<string>(1595459415u);
					val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._6f1rvTENt5XWmHTE22zxBIwbH9G;
					float float_17 = (float)(int)((Color)(ref val)).get_R() / 255f;
					val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._6f1rvTENt5XWmHTE22zxBIwbH9G;
					float float_18 = (float)(int)((Color)(ref val)).get_G() / 255f;
					val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._6f1rvTENt5XWmHTE22zxBIwbH9G;
					nHdiyIURlAiaNZ8u6MKzxjcwnyL9._VoeevpFh2kLKfHtpPDXWt0TFbuH(string_9, float_17, float_18, (float)(int)((Color)(ref val)).get_B() / 255f);
					num = (int)(num2 * 1036583631) ^ -1517610816;
					continue;
				}
				case 13u:
					SkyeSexscene.smethod_25(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_26<string>(1669131701u), 1f);
					SkyeSexscene.smethod_25(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_24<string>(1271689032u), 1f);
					num = ((int)num2 * -484411334) ^ -2043869906;
					continue;
				case 12u:
				{
					int num3;
					int num4;
					if (!SkyeSexscene.smethod_14())
					{
						num3 = -751757111;
						num4 = -751757111;
					}
					else
					{
						num3 = -1307414198;
						num4 = -1307414198;
					}
					num = num3 ^ ((int)num2 * -481530670);
					continue;
				}
				case 11u:
					SkyeSexscene.smethod_25(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_25<string>(2636000644u), 1f);
					SkyeSexscene.smethod_25(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_27<string>(449430453u), 1f);
					num = ((int)num2 * -49727133) ^ 0x5796E520;
					continue;
				case 10u:
					SkyeSexscene.smethod_25(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_27<string>(1168272714u), 1f);
					num = (int)(num2 * 847333428) ^ -531872205;
					continue;
				case 9u:
					SkyeSexscene.smethod_25(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_27<string>(2834719561u), 1f);
					num = (int)((num2 * 43320470) ^ 0x2929B0D8);
					continue;
				case 8u:
				{
					_nHdiyIURlAiaNZ8u6MKzxjcwnyL nHdiyIURlAiaNZ8u6MKzxjcwnyL5 = base._1BgOJ3z4ZUXNS2L4JWf24pr41hB;
					string string_5 = _003CModule_003E.smethod_26<string>(3141181263u);
					val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._6f1rvTENt5XWmHTE22zxBIwbH9G;
					float float_9 = (float)(int)((Color)(ref val)).get_R() / 255f;
					val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._6f1rvTENt5XWmHTE22zxBIwbH9G;
					float float_10 = (float)(int)((Color)(ref val)).get_G() / 255f;
					val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._6f1rvTENt5XWmHTE22zxBIwbH9G;
					nHdiyIURlAiaNZ8u6MKzxjcwnyL5._VoeevpFh2kLKfHtpPDXWt0TFbuH(string_5, float_9, float_10, (float)(int)((Color)(ref val)).get_B() / 255f);
					_nHdiyIURlAiaNZ8u6MKzxjcwnyL nHdiyIURlAiaNZ8u6MKzxjcwnyL6 = base._1BgOJ3z4ZUXNS2L4JWf24pr41hB;
					string string_6 = _003CModule_003E.smethod_25<string>(288358785u);
					val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._PeK36AvFxEQCvX3fS62hNV7rpuJ;
					float float_11 = (float)(int)((Color)(ref val)).get_R() / 255f;
					val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._PeK36AvFxEQCvX3fS62hNV7rpuJ;
					float float_12 = (float)(int)((Color)(ref val)).get_G() / 255f;
					val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._PeK36AvFxEQCvX3fS62hNV7rpuJ;
					nHdiyIURlAiaNZ8u6MKzxjcwnyL6._VoeevpFh2kLKfHtpPDXWt0TFbuH(string_6, float_11, float_12, (float)(int)((Color)(ref val)).get_B() / 255f);
					num = (int)(num2 * 1466639753) ^ -234706748;
					continue;
				}
				case 7u:
					SkyeSexscene.smethod_25(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_28<string>(2120866737u), 1f);
					num = (int)((num2 * 368354997) ^ 0x5EEE5C8);
					continue;
				case 6u:
					SkyeSexscene.smethod_25(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_27<string>(3027309346u), 1f);
					num = ((int)num2 * -1629088616) ^ -1799041482;
					continue;
				case 4u:
				{
					_nHdiyIURlAiaNZ8u6MKzxjcwnyL nHdiyIURlAiaNZ8u6MKzxjcwnyL4 = base._1BgOJ3z4ZUXNS2L4JWf24pr41hB;
					string string_4 = _003CModule_003E.smethod_27<string>(703513556u);
					val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._zBv1cYqPRU7uDCALpBlBSgObUcbA;
					float float_7 = (float)(int)((Color)(ref val)).get_R() / 255f;
					val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._zBv1cYqPRU7uDCALpBlBSgObUcbA;
					float float_8 = (float)(int)((Color)(ref val)).get_G() / 255f;
					val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._zBv1cYqPRU7uDCALpBlBSgObUcbA;
					nHdiyIURlAiaNZ8u6MKzxjcwnyL4._VoeevpFh2kLKfHtpPDXWt0TFbuH(string_4, float_7, float_8, (float)(int)((Color)(ref val)).get_B() / 255f);
					num = ((int)num2 * -1224094391) ^ -462037535;
					continue;
				}
				case 3u:
					SkyeSexscene.smethod_25(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_25<string>(1029577964u), 1f);
					SkyeSexscene.smethod_25(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_28<string>(1952725506u), 1f);
					SkyeSexscene.smethod_25(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_28<string>(655315807u), 1f);
					SkyeSexscene.smethod_25(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_26<string>(715981769u), 1f);
					SkyeSexscene.smethod_25(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_26<string>(918214853u), 1f);
					num = ((int)num2 * -1953037733) ^ -1055234705;
					continue;
				case 2u:
					SkyeSexscene.smethod_25(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_25<string>(959850315u), (SkyeSexscene.smethod_28(_opIJo2jLUqdOL5yAFP4yzXce0DG_0) == _opIJo2jLUqdOL5yAFP4yzXce0DG.ECockType.Knotted) ? 1f : 0f);
					num = 716157761;
					continue;
				case 1u:
					SkyeSexscene.smethod_25(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_24<string>(2433977749u), 1f);
					num = ((int)num2 * -2091246445) ^ -397322295;
					continue;
				case 0u:
					SkyeSexscene.smethod_25(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_26<string>(2174714411u), 1f);
					SkyeSexscene.smethod_25(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_26<string>(2376947495u), 1f);
					SkyeSexscene.smethod_25(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_26<string>(2579180579u), 1f);
					SkyeSexscene.smethod_25(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_26<string>(3898667103u), 1f);
					SkyeSexscene.smethod_25(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_28<string>(2066901392u), 1f);
					num = (int)(num2 * 1979012979) ^ -817271647;
					continue;
				case 5u:
					break;
				case 20u:
					SkyeSexscene.smethod_25(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_24<string>(872035111u), 1f);
					SkyeSexscene.smethod_25(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_26<string>(715981769u), 1f);
					SkyeSexscene.smethod_25(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_28<string>(4271472983u), 1f);
					return;
				default:
					base._DUynKBx2CM4riE68wCCfknspxeg.Add(_003CModule_003E.smethod_24<string>(3650526118u));
					return;
				}
				break;
			}
		}
	}

	static SkyeSexscene()
	{
		List<SpineEvent> list = new List<SpineEvent>();
		SpineEvent val = SkyeSexscene.smethod_30();
		val.AnimationName = _003CModule_003E.smethod_28<string>(420718839u);
		val.EventName = _003CModule_003E.smethod_25<string>(2476242149u);
		SpineEvent obj = val;
		float[] array = new float[6];
		SkyeSexscene.smethod_31((Array)array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		obj.FrameTimes = array;
		list.Add(val);
		val = SkyeSexscene.smethod_30();
		val.AnimationName = _003CModule_003E.smethod_25<string>(4121017498u);
		val.EventName = _003CModule_003E.smethod_26<string>(2619840628u);
		SpineEvent obj2 = val;
		float[] array2 = new float[6];
		SkyeSexscene.smethod_31((Array)array2, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		obj2.FrameTimes = array2;
		list.Add(val);
		val = SkyeSexscene.smethod_30();
		val.AnimationName = _003CModule_003E.smethod_24<string>(935837983u);
		val.EventName = _003CModule_003E.smethod_28<string>(586293476u);
		SpineEvent obj3 = val;
		float[] array3 = new float[6];
		SkyeSexscene.smethod_31((Array)array3, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		obj3.FrameTimes = array3;
		list.Add(val);
		_zAqFZFiaBbpl6Gf6nSX9UC3cSh6 = list;
	}

	static bool smethod_14()
	{
		return _iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF;
	}

	static _nHdiyIURlAiaNZ8u6MKzxjcwnyL smethod_15(_TwlwMC1hhdSzamwGWEBxuUkz1gH _TwlwMC1hhdSzamwGWEBxuUkz1gH_0)
	{
		return _TwlwMC1hhdSzamwGWEBxuUkz1gH_0._1BgOJ3z4ZUXNS2L4JWf24pr41hB;
	}

	static void smethod_16(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0, string string_0, Action<int> action_0)
	{
		_nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._C5vPbZ72rpVMDWGuHxZuR5FNpAH(string_0, action_0);
	}

	static void smethod_17(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0, float float_0)
	{
		_nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._7Xn1C5tjYnmIif1iZKV8AWsEEbL = float_0;
	}

	static void smethod_18(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0, float float_0)
	{
		_nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._bCjZ3VSXGKyhmykd2zCnQBiSpDf = float_0;
	}

	static _opIJo2jLUqdOL5yAFP4yzXce0DG smethod_19()
	{
		return _Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t();
	}

	static bool smethod_20(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0, string string_0)
	{
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._Oms9lumBodLGrGZ09YJaEuzmlAf(string_0);
	}

	static void smethod_21(_TwlwMC1hhdSzamwGWEBxuUkz1gH _TwlwMC1hhdSzamwGWEBxuUkz1gH_0, string string_0)
	{
		_TwlwMC1hhdSzamwGWEBxuUkz1gH_0._GGyEXu1JJKcG2X3txvtCwyZAylK(string_0);
	}

	void method_9(string string_0)
	{
		base._GGyEXu1JJKcG2X3txvtCwyZAylK(string_0);
	}

	static bool smethod_22(string string_0, string string_1)
	{
		return string_0 == string_1;
	}

	static void smethod_23(_TwlwMC1hhdSzamwGWEBxuUkz1gH _TwlwMC1hhdSzamwGWEBxuUkz1gH_0, Texture2D texture2D_0)
	{
		_TwlwMC1hhdSzamwGWEBxuUkz1gH_0._1AqpgY4vB6ly5vxOay6j86rcIEo = texture2D_0;
	}

	static void smethod_24(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0, float float_0)
	{
		_nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._c4iC7y9v6xg7LpvjKIeUkOdZ3UF(float_0);
	}

	static void smethod_25(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0, string string_0, float float_0)
	{
		_nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._aAoZaDNczeScsMfLlGSfAzey9SQ(string_0, float_0);
	}

	static _opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U smethod_26(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._Mz7LwHZqoGBscApFXmff1kEQnGY;
	}

	static bool smethod_27(Enum enum_0, Enum enum_1)
	{
		return enum_0.HasFlag(enum_1);
	}

	static _opIJo2jLUqdOL5yAFP4yzXce0DG.ECockType smethod_28(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._rtyJgfViJdXL2Ela5APpDlk99dI;
	}

	static Color smethod_29(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._6f1rvTENt5XWmHTE22zxBIwbH9G;
	}

	static SpineEvent smethod_30()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new SpineEvent();
	}

	static void smethod_31(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0)
	{
		RuntimeHelpers.InitializeArray(array_0, runtimeFieldHandle_0);
	}
}
