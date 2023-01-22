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
		: base(contentManager_0, "Assets/SexScenes/Skye/Skye Sex", "Assets/SexScenes/Skye/Background", null, list_0: _zAqFZFiaBbpl6Gf6nSX9UC3cSh6, _sa8EsNgk4VDRaASdXE7VprdlNlg_0: _sg4TvSTYoH0YwumBfYnvr7IeDaT._AZrO8MxMUE7cKsFYTQ4k9O3q7yC(contentManager_0), float_0: SkyeSexscene.smethod_14() ? 2f : 1f, bool_0: true, float_1: 3000f)
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
					SkyeSexscene.smethod_21((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this, "Blue");
					num = ((int)num2 * -487802181) ^ -263375689;
					continue;
				case 14u:
				{
					_opIJo2jLUqdOL5yAFP4yzXce0DG opIJo2jLUqdOL5yAFP4yzXce0DG_ = SkyeSexscene.smethod_19();
					flag = SkyeSexscene.smethod_20(opIJo2jLUqdOL5yAFP4yzXce0DG_, "SkyeSkinYellow");
					flag2 = SkyeSexscene.smethod_20(opIJo2jLUqdOL5yAFP4yzXce0DG_, "SkyeSkinBlue");
					num = (int)(num2 * 2011771227) ^ -2042457305;
					continue;
				}
				case 13u:
					SkyeSexscene.smethod_21((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this, "Gray");
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
					_a2vuTNBvRtI0ysFdoyLqbnVKmKb = contentManager_0.Load<Texture2D>("Assets/SexScenes/Skye/Skye Sex Yellow");
					_8Wpyx8UxfA2ieouQH6qdonhcCok = contentManager_0.Load<Texture2D>("Assets/SexScenes/Skye/Skye Sex Blue");
					num = (int)((num2 * 1221396719) ^ 0x7AF16B4C);
					continue;
				case 10u:
					SkyeSexscene.smethod_16(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Sex", (Action<int>)null);
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
					SkyeSexscene.smethod_21((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this, "Yellow");
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
					_p65Ex7slWkEu44TWzMfnrHkavQb = contentManager_0.Load<Texture2D>("Assets/SexScenes/Skye/Skye Sex");
					num = 2147199595;
					continue;
				case 0u:
					SkyeSexscene.smethod_21((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this, "Gray");
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
		return new string[3] { "Gray", "Yellow", "Blue" };
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
					if (SkyeSexscene.smethod_22(string_0, "Yellow"))
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
					if (SkyeSexscene.smethod_22(string_0, "Blue"))
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
					if (SkyeSexscene.smethod_22(string_0, "Gray"))
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
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_060d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0612: Unknown result type (might be due to invalid IL or missing references)
		//IL_0622: Unknown result type (might be due to invalid IL or missing references)
		//IL_0627: Unknown result type (might be due to invalid IL or missing references)
		//IL_0751: Unknown result type (might be due to invalid IL or missing references)
		//IL_0756: Unknown result type (might be due to invalid IL or missing references)
		//IL_0766: Unknown result type (might be due to invalid IL or missing references)
		//IL_076b: Unknown result type (might be due to invalid IL or missing references)
		//IL_077b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0780: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0853: Unknown result type (might be due to invalid IL or missing references)
		//IL_0858: Unknown result type (might be due to invalid IL or missing references)
		//IL_0868: Unknown result type (might be due to invalid IL or missing references)
		//IL_086d: Unknown result type (might be due to invalid IL or missing references)
		//IL_087d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0882: Unknown result type (might be due to invalid IL or missing references)
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
					SkyeSexscene.smethod_25(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Skye tail", 1f);
					SkyeSexscene.smethod_25(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Skye thigh left", 1f);
					num = ((int)num2 * -183850062) ^ -817810392;
					continue;
				case 31u:
				{
					_nHdiyIURlAiaNZ8u6MKzxjcwnyL nHdiyIURlAiaNZ8u6MKzxjcwnyL11 = base._1BgOJ3z4ZUXNS2L4JWf24pr41hB;
					val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._zBv1cYqPRU7uDCALpBlBSgObUcbA;
					float float_21 = (float)(int)((Color)(ref val)).get_R() / 255f;
					val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._zBv1cYqPRU7uDCALpBlBSgObUcbA;
					float float_22 = (float)(int)((Color)(ref val)).get_G() / 255f;
					val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._zBv1cYqPRU7uDCALpBlBSgObUcbA;
					nHdiyIURlAiaNZ8u6MKzxjcwnyL11._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player underthigh right", float_21, float_22, (float)(int)((Color)(ref val)).get_B() / 255f);
					num = ((int)num2 * -1073682705) ^ -197810843;
					continue;
				}
				case 30u:
				{
					_nHdiyIURlAiaNZ8u6MKzxjcwnyL nHdiyIURlAiaNZ8u6MKzxjcwnyL = base._1BgOJ3z4ZUXNS2L4JWf24pr41hB;
					val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._XnNREK59QnV1onFFWfSUaS9WK0E;
					float float_ = (float)(int)((Color)(ref val)).get_R() / 255f;
					val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._XnNREK59QnV1onFFWfSUaS9WK0E;
					float float_2 = (float)(int)((Color)(ref val)).get_G() / 255f;
					val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._XnNREK59QnV1onFFWfSUaS9WK0E;
					nHdiyIURlAiaNZ8u6MKzxjcwnyL._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player knot", float_, float_2, (float)(int)((Color)(ref val)).get_B() / 255f);
					num = ((int)num2 * -1479733753) ^ -842043252;
					continue;
				}
				case 28u:
				{
					_nHdiyIURlAiaNZ8u6MKzxjcwnyL nHdiyIURlAiaNZ8u6MKzxjcwnyL2 = base._1BgOJ3z4ZUXNS2L4JWf24pr41hB;
					val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._TxfCqloeyiHpsXka6B46iqCZNsZ;
					float float_3 = (float)(int)((Color)(ref val)).get_R() / 255f;
					val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._TxfCqloeyiHpsXka6B46iqCZNsZ;
					float float_4 = (float)(int)((Color)(ref val)).get_G() / 255f;
					val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._TxfCqloeyiHpsXka6B46iqCZNsZ;
					nHdiyIURlAiaNZ8u6MKzxjcwnyL2._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player stripe right", float_3, float_4, (float)(int)((Color)(ref val)).get_B() / 255f);
					_nHdiyIURlAiaNZ8u6MKzxjcwnyL nHdiyIURlAiaNZ8u6MKzxjcwnyL3 = base._1BgOJ3z4ZUXNS2L4JWf24pr41hB;
					val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._TxfCqloeyiHpsXka6B46iqCZNsZ;
					float float_5 = (float)(int)((Color)(ref val)).get_R() / 255f;
					val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._TxfCqloeyiHpsXka6B46iqCZNsZ;
					float float_6 = (float)(int)((Color)(ref val)).get_G() / 255f;
					val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._TxfCqloeyiHpsXka6B46iqCZNsZ;
					nHdiyIURlAiaNZ8u6MKzxjcwnyL3._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player stripe left", float_5, float_6, (float)(int)((Color)(ref val)).get_B() / 255f);
					num = ((int)num2 * -2111747208) ^ -1090731798;
					continue;
				}
				case 27u:
					SkyeSexscene.smethod_25(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Skye arm left", 1f);
					num = (int)((num2 * 2064708615) ^ 0x150DE1D4);
					continue;
				case 26u:
					SkyeSexscene.smethod_25(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Skye head back", 1f);
					num = ((int)num2 * -1222093953) ^ 0x349C1BD6;
					continue;
				case 25u:
				{
					_nHdiyIURlAiaNZ8u6MKzxjcwnyL nHdiyIURlAiaNZ8u6MKzxjcwnyL7 = base._1BgOJ3z4ZUXNS2L4JWf24pr41hB;
					val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._TxfCqloeyiHpsXka6B46iqCZNsZ;
					float float_13 = (float)(int)((Color)(ref val)).get_R() / 255f;
					val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._TxfCqloeyiHpsXka6B46iqCZNsZ;
					float float_14 = (float)(int)((Color)(ref val)).get_G() / 255f;
					val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._TxfCqloeyiHpsXka6B46iqCZNsZ;
					nHdiyIURlAiaNZ8u6MKzxjcwnyL7._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player belly stripes", float_13, float_14, (float)(int)((Color)(ref val)).get_B() / 255f);
					num = (int)(num2 * 461429451) ^ -1428778794;
					continue;
				}
				case 24u:
					SkyeSexscene.smethod_25(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Skye arm right", 1f);
					SkyeSexscene.smethod_25(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Skye boob left", 1f);
					num = (int)((num2 * 2095985147) ^ 0x5DB0A543);
					continue;
				case 23u:
				{
					_nHdiyIURlAiaNZ8u6MKzxjcwnyL nHdiyIURlAiaNZ8u6MKzxjcwnyL10 = base._1BgOJ3z4ZUXNS2L4JWf24pr41hB;
					val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._XnNREK59QnV1onFFWfSUaS9WK0E;
					float float_19 = (float)(int)((Color)(ref val)).get_R() / 255f;
					val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._XnNREK59QnV1onFFWfSUaS9WK0E;
					float float_20 = (float)(int)((Color)(ref val)).get_G() / 255f;
					val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._XnNREK59QnV1onFFWfSUaS9WK0E;
					nHdiyIURlAiaNZ8u6MKzxjcwnyL10._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player cock", float_19, float_20, (float)(int)((Color)(ref val)).get_B() / 255f);
					num = (int)((num2 * 2067641739) ^ 0x3491524E);
					continue;
				}
				case 22u:
					SkyeSexscene.smethod_25(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Skye ear right", 1f);
					num = (int)(num2 * 469212501) ^ -1805527074;
					continue;
				case 21u:
					SkyeSexscene.smethod_25(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Player cock", 1f);
					SkyeSexscene.smethod_25(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Player body", 1f);
					SkyeSexscene.smethod_25(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Player belly stripes", SkyeSexscene.smethod_27((Enum)SkyeSexscene.smethod_26(_opIJo2jLUqdOL5yAFP4yzXce0DG_0), (Enum)_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.Stripes) ? 1f : 0f);
					SkyeSexscene.smethod_25(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Player underbelly", SkyeSexscene.smethod_27((Enum)SkyeSexscene.smethod_26(_opIJo2jLUqdOL5yAFP4yzXce0DG_0), (Enum)_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.Underbelly) ? 1f : 0f);
					num = 251250305;
					continue;
				case 19u:
					SkyeSexscene.smethod_25(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Player stripe right", SkyeSexscene.smethod_27((Enum)SkyeSexscene.smethod_26(_opIJo2jLUqdOL5yAFP4yzXce0DG_0), (Enum)_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.Stripes) ? 1f : 0f);
					SkyeSexscene.smethod_25(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Player underthigh right", SkyeSexscene.smethod_27((Enum)SkyeSexscene.smethod_26(_opIJo2jLUqdOL5yAFP4yzXce0DG_0), (Enum)_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.Underthigh) ? 1f : 0f);
					SkyeSexscene.smethod_25(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Player thigh left", 1f);
					SkyeSexscene.smethod_25(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Player stripe left", SkyeSexscene.smethod_27((Enum)SkyeSexscene.smethod_26(_opIJo2jLUqdOL5yAFP4yzXce0DG_0), (Enum)_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.Stripes) ? 1f : 0f);
					SkyeSexscene.smethod_25(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Player underthigh left", SkyeSexscene.smethod_27((Enum)SkyeSexscene.smethod_26(_opIJo2jLUqdOL5yAFP4yzXce0DG_0), (Enum)_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.Underthigh) ? 1f : 0f);
					num = 873491612;
					continue;
				case 18u:
					SkyeSexscene.smethod_25(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Skye shin right", 1f);
					num = ((int)num2 * -1333941580) ^ 0x42571FE6;
					continue;
				case 17u:
					SkyeSexscene.smethod_25(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Skye body", 1f);
					SkyeSexscene.smethod_25(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Skye foot right", 1f);
					num = ((int)num2 * -1206856973) ^ -32963669;
					continue;
				case 16u:
					SkyeSexscene.smethod_25(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Skye shin back", 1f);
					num = 1276043878;
					continue;
				case 15u:
					SkyeSexscene.smethod_25(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Skye jaw", 1f);
					SkyeSexscene.smethod_25(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Skye ear left", 1f);
					num = (int)(num2 * 1617783700) ^ -1398668446;
					continue;
				case 14u:
				{
					_nHdiyIURlAiaNZ8u6MKzxjcwnyL nHdiyIURlAiaNZ8u6MKzxjcwnyL8 = SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this);
					val = SkyeSexscene.smethod_29(_opIJo2jLUqdOL5yAFP4yzXce0DG_0);
					float float_15 = (float)(int)((Color)(ref val)).get_R() / 255f;
					val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._6f1rvTENt5XWmHTE22zxBIwbH9G;
					float float_16 = (float)(int)((Color)(ref val)).get_G() / 255f;
					val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._6f1rvTENt5XWmHTE22zxBIwbH9G;
					nHdiyIURlAiaNZ8u6MKzxjcwnyL8._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player thigh right", float_15, float_16, (float)(int)((Color)(ref val)).get_B() / 255f);
					_nHdiyIURlAiaNZ8u6MKzxjcwnyL nHdiyIURlAiaNZ8u6MKzxjcwnyL9 = base._1BgOJ3z4ZUXNS2L4JWf24pr41hB;
					val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._6f1rvTENt5XWmHTE22zxBIwbH9G;
					float float_17 = (float)(int)((Color)(ref val)).get_R() / 255f;
					val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._6f1rvTENt5XWmHTE22zxBIwbH9G;
					float float_18 = (float)(int)((Color)(ref val)).get_G() / 255f;
					val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._6f1rvTENt5XWmHTE22zxBIwbH9G;
					nHdiyIURlAiaNZ8u6MKzxjcwnyL9._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player thigh left", float_17, float_18, (float)(int)((Color)(ref val)).get_B() / 255f);
					num = (int)(num2 * 1036583631) ^ -1517610816;
					continue;
				}
				case 13u:
					SkyeSexscene.smethod_25(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Skye arm right", 1f);
					SkyeSexscene.smethod_25(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Skye boob left", 1f);
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
					SkyeSexscene.smethod_25(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Skye thigh right", 1f);
					SkyeSexscene.smethod_25(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Skye arm left", 1f);
					num = ((int)num2 * -49727133) ^ 0x5796E520;
					continue;
				case 10u:
					SkyeSexscene.smethod_25(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Skye chest", 1f);
					num = (int)(num2 * 847333428) ^ -531872205;
					continue;
				case 9u:
					SkyeSexscene.smethod_25(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Skye tail", 1f);
					num = (int)((num2 * 43320470) ^ 0x2929B0D8);
					continue;
				case 8u:
				{
					_nHdiyIURlAiaNZ8u6MKzxjcwnyL nHdiyIURlAiaNZ8u6MKzxjcwnyL5 = base._1BgOJ3z4ZUXNS2L4JWf24pr41hB;
					val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._6f1rvTENt5XWmHTE22zxBIwbH9G;
					float float_9 = (float)(int)((Color)(ref val)).get_R() / 255f;
					val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._6f1rvTENt5XWmHTE22zxBIwbH9G;
					float float_10 = (float)(int)((Color)(ref val)).get_G() / 255f;
					val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._6f1rvTENt5XWmHTE22zxBIwbH9G;
					nHdiyIURlAiaNZ8u6MKzxjcwnyL5._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player body", float_9, float_10, (float)(int)((Color)(ref val)).get_B() / 255f);
					_nHdiyIURlAiaNZ8u6MKzxjcwnyL nHdiyIURlAiaNZ8u6MKzxjcwnyL6 = base._1BgOJ3z4ZUXNS2L4JWf24pr41hB;
					val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._PeK36AvFxEQCvX3fS62hNV7rpuJ;
					float float_11 = (float)(int)((Color)(ref val)).get_R() / 255f;
					val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._PeK36AvFxEQCvX3fS62hNV7rpuJ;
					float float_12 = (float)(int)((Color)(ref val)).get_G() / 255f;
					val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._PeK36AvFxEQCvX3fS62hNV7rpuJ;
					nHdiyIURlAiaNZ8u6MKzxjcwnyL6._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player underbelly", float_11, float_12, (float)(int)((Color)(ref val)).get_B() / 255f);
					num = (int)(num2 * 1466639753) ^ -234706748;
					continue;
				}
				case 7u:
					SkyeSexscene.smethod_25(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Skye pupil", 1f);
					num = (int)((num2 * 368354997) ^ 0x5EEE5C8);
					continue;
				case 6u:
					SkyeSexscene.smethod_25(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Player thigh right", 1f);
					num = ((int)num2 * -1629088616) ^ -1799041482;
					continue;
				case 4u:
				{
					_nHdiyIURlAiaNZ8u6MKzxjcwnyL nHdiyIURlAiaNZ8u6MKzxjcwnyL4 = base._1BgOJ3z4ZUXNS2L4JWf24pr41hB;
					val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._zBv1cYqPRU7uDCALpBlBSgObUcbA;
					float float_7 = (float)(int)((Color)(ref val)).get_R() / 255f;
					val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._zBv1cYqPRU7uDCALpBlBSgObUcbA;
					float float_8 = (float)(int)((Color)(ref val)).get_G() / 255f;
					val = _opIJo2jLUqdOL5yAFP4yzXce0DG_0._zBv1cYqPRU7uDCALpBlBSgObUcbA;
					nHdiyIURlAiaNZ8u6MKzxjcwnyL4._VoeevpFh2kLKfHtpPDXWt0TFbuH("Player underthigh left", float_7, float_8, (float)(int)((Color)(ref val)).get_B() / 255f);
					num = ((int)num2 * -1224094391) ^ -462037535;
					continue;
				}
				case 3u:
					SkyeSexscene.smethod_25(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Skye head back", 1f);
					SkyeSexscene.smethod_25(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Skye ear right", 1f);
					SkyeSexscene.smethod_25(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Skye eyelids", 1f);
					SkyeSexscene.smethod_25(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Skye head", 1f);
					SkyeSexscene.smethod_25(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Skye eyelash", 1f);
					num = ((int)num2 * -1953037733) ^ -1055234705;
					continue;
				case 2u:
					SkyeSexscene.smethod_25(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Player knot", (SkyeSexscene.smethod_28(_opIJo2jLUqdOL5yAFP4yzXce0DG_0) == _opIJo2jLUqdOL5yAFP4yzXce0DG.ECockType.Knotted) ? 1f : 0f);
					num = 716157761;
					continue;
				case 1u:
					SkyeSexscene.smethod_25(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Skye eyes", 1f);
					num = ((int)num2 * -2091246445) ^ -397322295;
					continue;
				case 0u:
					SkyeSexscene.smethod_25(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Skye chest", 1f);
					SkyeSexscene.smethod_25(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Skye eyes", 1f);
					SkyeSexscene.smethod_25(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Skye pupil", 1f);
					SkyeSexscene.smethod_25(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Skye jaw", 1f);
					SkyeSexscene.smethod_25(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Skye ear left", 1f);
					num = (int)(num2 * 1979012979) ^ -817271647;
					continue;
				case 5u:
					break;
				case 20u:
					SkyeSexscene.smethod_25(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Skye eyelids", 1f);
					SkyeSexscene.smethod_25(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Skye head", 1f);
					SkyeSexscene.smethod_25(SkyeSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), "Skye eyelash", 1f);
					return;
				default:
					base._DUynKBx2CM4riE68wCCfknspxeg.Add("Player wetness");
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
		val.AnimationName = "Sex";
		val.EventName = "ThrustStart";
		SpineEvent obj = val;
		float[] array = new float[6];
		SkyeSexscene.smethod_31((Array)array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		obj.FrameTimes = array;
		list.Add(val);
		val = SkyeSexscene.smethod_30();
		val.AnimationName = "Sex";
		val.EventName = "ThrustEnd";
		SpineEvent obj2 = val;
		float[] array2 = new float[6];
		SkyeSexscene.smethod_31((Array)array2, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		obj2.FrameTimes = array2;
		list.Add(val);
		val = SkyeSexscene.smethod_30();
		val.AnimationName = "Sex";
		val.EventName = "Moan";
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
