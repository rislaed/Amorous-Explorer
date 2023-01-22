using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Spine;

namespace Amorous.Game.Sexscenes;

public class LexSexscene : CensoredSexscene
{
	public const string _7p39D6gRnJVEL4nBpm27s7mRbMo = "Male";

	public const string _bguKzeUbXe4hujNISQZXXCW725e = "Female";

	private static readonly List<SpineEvent> _zAqFZFiaBbpl6Gf6nSX9UC3cSh6;

	public LexSexscene(ContentManager contentManager_0)
		: base(contentManager_0, _003CModule_003E.smethod_28<string>(2435847017u), _003CModule_003E.smethod_25<string>(3222618320u), null, list_0: _zAqFZFiaBbpl6Gf6nSX9UC3cSh6, float_0: LexSexscene.smethod_14() ? 1.5f : 1f, bool_0: true, _sa8EsNgk4VDRaASdXE7VprdlNlg_0: null, float_1: 5000f)
	{
		while (true)
		{
			int num = -2013504397;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCF5E9B40u) % 7u)
				{
				case 6u:
					LexSexscene.smethod_17(LexSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), 1000f);
					LexSexscene.smethod_18(LexSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), 1600f);
					num = (int)((num2 * 308898405) ^ 0x34B67CDE);
					continue;
				case 4u:
					LexSexscene.smethod_16(LexSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_26<string>(4184661290u), (Action<int>)null);
					num = (int)(num2 * 547910348) ^ -857437379;
					continue;
				case 3u:
					LexSexscene.smethod_17(LexSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), 900f);
					LexSexscene.smethod_18(LexSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), 1100f);
					LexSexscene.smethod_19(LexSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_28<string>(2267705786u), -0.2f);
					num = -2032147499;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (LexSexscene.smethod_14())
					{
						num3 = -786480890;
						num4 = -786480890;
					}
					else
					{
						num3 = -820992226;
						num4 = -820992226;
					}
					num = num3 ^ (int)(num2 * 2049265382);
					continue;
				}
				default:
					return;
				case 2u:
					break;
				case 1u:
					return;
				case 5u:
					return;
				}
				break;
			}
		}
	}

	public override string[] _tCw3HO9jqoEm2Ad1hqdKsA8vS7b()
	{
		if (LexSexscene.smethod_14())
		{
			return this.method_9();
		}
		return new string[2]
		{
			_003CModule_003E.smethod_24<string>(3723327994u),
			_003CModule_003E.smethod_28<string>(1024261432u)
		};
	}

	public override void _GGyEXu1JJKcG2X3txvtCwyZAylK(string string_0)
	{
		this.method_10(string_0);
		while (true)
		{
			int num = 423282;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF01A2BFu) % 14u)
				{
				case 13u:
				{
					int num5;
					int num6;
					if (LexSexscene.smethod_20(string_0, _003CModule_003E.smethod_26<string>(193043620u)))
					{
						num5 = 530671317;
						num6 = 530671317;
					}
					else
					{
						num5 = 935596991;
						num6 = 935596991;
					}
					num = num5 ^ ((int)num2 * -1077494588);
					continue;
				}
				case 11u:
					base._DUynKBx2CM4riE68wCCfknspxeg.Clear();
					num = (int)((num2 * 605101689) ^ 0xCA6CA5A);
					continue;
				case 10u:
					base._DUynKBx2CM4riE68wCCfknspxeg.Add(_003CModule_003E.smethod_27<string>(370726188u));
					num = ((int)num2 * -1801042560) ^ 0x68DC932D;
					continue;
				case 9u:
				{
					int num3;
					int num4;
					if (LexSexscene.smethod_20(string_0, _003CModule_003E.smethod_28<string>(4075784374u)))
					{
						num3 = -1831743344;
						num4 = -1831743344;
					}
					else
					{
						num3 = -1528637378;
						num4 = -1528637378;
					}
					num = num3 ^ (int)(num2 * 691122094);
					continue;
				}
				case 8u:
					LexSexscene.smethod_21(LexSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_24<string>(3414606771u), 0f);
					LexSexscene.smethod_21(LexSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_27<string>(2280404376u), 0f);
					LexSexscene.smethod_21(LexSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_26<string>(1808422553u), 0f);
					num = (int)(num2 * 315817868) ^ -778159395;
					continue;
				case 7u:
					LexSexscene.smethod_21(LexSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_28<string>(291485967u), 1f);
					LexSexscene.smethod_21(LexSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_27<string>(4190082564u), 1f);
					LexSexscene.smethod_21(LexSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_28<string>(2381881672u), 0f);
					num = ((int)num2 * -773273928) ^ -1843623106;
					continue;
				case 4u:
					LexSexscene.smethod_21(LexSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_25<string>(603801353u), 1f);
					base._DUynKBx2CM4riE68wCCfknspxeg.Clear();
					num = ((int)num2 * -1772179708) ^ -2107370961;
					continue;
				case 3u:
					base._wQSC6rD8bbXFvRxba0kr1RqxlOV = _ecVLwNBaQAiybVyX9cgWCvnbkWe._AZrO8MxMUE7cKsFYTQ4k9O3q7yC(base._uwNDZuqdFb9tyQtlQMxiz1DQ7x8);
					LexSexscene.smethod_21(LexSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_28<string>(63134195u), 1f);
					num = 199907312;
					continue;
				case 2u:
					base._DUynKBx2CM4riE68wCCfknspxeg.Add(_003CModule_003E.smethod_27<string>(2284021630u));
					num = (int)(num2 * 111958755) ^ -192224686;
					continue;
				case 0u:
					base._wQSC6rD8bbXFvRxba0kr1RqxlOV = _sg4TvSTYoH0YwumBfYnvr7IeDaT._AZrO8MxMUE7cKsFYTQ4k9O3q7yC(base._uwNDZuqdFb9tyQtlQMxiz1DQ7x8);
					num = 1378534667;
					continue;
				case 5u:
					break;
				case 1u:
					return;
				default:
					base._DUynKBx2CM4riE68wCCfknspxeg.Add(_003CModule_003E.smethod_25<string>(939547118u));
					return;
				case 12u:
					return;
				}
				break;
			}
		}
	}

	protected override void _coudx6g9HL4THj8r5aYCDxaHH0I(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_0476: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ce: Unknown result type (might be due to invalid IL or missing references)
		bool flag = LexSexscene.smethod_22(_opIJo2jLUqdOL5yAFP4yzXce0DG_0, _003CModule_003E.smethod_27<string>(2523635717u));
		while (true)
		{
			int num = -2117904748;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB0715F23u) % 41u)
				{
				case 40u:
					LexSexscene.smethod_21(LexSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_26<string>(4088516226u), 1f);
					LexSexscene.smethod_21(LexSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_25<string>(2344522339u), 1f);
					num = ((int)num2 * -397427558) ^ 0x4A549681;
					continue;
				case 39u:
					LexSexscene.smethod_29(LexSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_27<string>(3017332907u), (LexSexscene.smethod_24(_opIJo2jLUqdOL5yAFP4yzXce0DG_0) == _opIJo2jLUqdOL5yAFP4yzXce0DG.ECockType.Uncut) ? LexSexscene.smethod_30(_opIJo2jLUqdOL5yAFP4yzXce0DG_0) : LexSexscene.smethod_28(_opIJo2jLUqdOL5yAFP4yzXce0DG_0));
					LexSexscene.smethod_29(LexSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_28<string>(1319068941u), LexSexscene.smethod_28(_opIJo2jLUqdOL5yAFP4yzXce0DG_0));
					LexSexscene.smethod_29(LexSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_28<string>(1036751824u), LexSexscene.smethod_31(_opIJo2jLUqdOL5yAFP4yzXce0DG_0));
					num = -1628996487;
					continue;
				case 38u:
				{
					LexSexscene.smethod_23(LexSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), 0f);
					int num3;
					int num4;
					if (!LexSexscene.smethod_14())
					{
						num3 = 1113677207;
						num4 = 1113677207;
					}
					else
					{
						num3 = 1383127141;
						num4 = 1383127141;
					}
					num = num3 ^ ((int)num2 * -475793894);
					continue;
				}
				case 37u:
					LexSexscene.smethod_21(LexSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_24<string>(1852664133u), 1f);
					num = ((int)num2 * -328865998) ^ -1396058240;
					continue;
				case 36u:
					LexSexscene.smethod_21(LexSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_27<string>(1590500147u), (LexSexscene.smethod_25(_opIJo2jLUqdOL5yAFP4yzXce0DG_0) == _opIJo2jLUqdOL5yAFP4yzXce0DG.EBodyType.Chubby) ? 1f : 0f);
					num = -634061145;
					continue;
				case 35u:
					LexSexscene.smethod_21(LexSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_25<string>(1071266928u), 1f);
					LexSexscene.smethod_21(LexSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_25<string>(1272714387u), 1f);
					LexSexscene.smethod_21(LexSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_26<string>(3734608329u), 1f);
					num = (int)((num2 * 1973448833) ^ 0x72690509);
					continue;
				case 34u:
					LexSexscene.smethod_21(LexSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_26<string>(595024049u), 1f);
					num = ((int)num2 * -1969486850) ^ 0x3985C7FC;
					continue;
				case 33u:
					LexSexscene.smethod_21(LexSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_24<string>(2379173881u), 1f);
					num = ((int)num2 * -1966204892) ^ 0x4046461;
					continue;
				case 32u:
					LexSexscene.smethod_21(LexSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_24<string>(3441736597u), 1f);
					LexSexscene.smethod_21(LexSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_25<string>(4160127966u), 1f);
					LexSexscene.smethod_21(LexSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_25<string>(64029633u), 1f);
					LexSexscene.smethod_21(LexSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_27<string>(4200934326u), 1f);
					num = ((int)num2 * -589059715) ^ -1227625438;
					continue;
				case 31u:
					LexSexscene.smethod_21(LexSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_26<string>(2769029702u), 1f);
					LexSexscene.smethod_21(LexSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_26<string>(2971262786u), 1f);
					num = (int)((num2 * 889096853) ^ 0x1B93ECA2);
					continue;
				case 30u:
					LexSexscene.smethod_21(LexSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_27<string>(1111271973u), 1f);
					LexSexscene.smethod_21(LexSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_28<string>(3295288760u), 1f);
					num = ((int)num2 * -2136084853) ^ -1580386194;
					continue;
				case 29u:
					LexSexscene.smethod_29(LexSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_27<string>(3736175168u), LexSexscene.smethod_33(_opIJo2jLUqdOL5yAFP4yzXce0DG_0));
					num = (int)((num2 * 1387224133) ^ 0x683E41B3);
					continue;
				case 28u:
					LexSexscene.smethod_21(LexSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_27<string>(3496561081u), (LexSexscene.smethod_24(_opIJo2jLUqdOL5yAFP4yzXce0DG_0) == _opIJo2jLUqdOL5yAFP4yzXce0DG.ECockType.Knotted) ? 1f : 0f);
					num = -1768484683;
					continue;
				case 27u:
					LexSexscene.smethod_21(LexSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_24<string>(1353284211u), 1f);
					num = (int)(num2 * 417950761) ^ -18951919;
					continue;
				case 25u:
					LexSexscene.smethod_21(LexSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_27<string>(3721706152u), 1f);
					num = ((int)num2 * -114858461) ^ -814609414;
					continue;
				case 24u:
					LexSexscene.smethod_21(LexSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_25<string>(3085741518u), 1f);
					LexSexscene.smethod_21(LexSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_26<string>(797257133u), 1f);
					num = (int)((num2 * 742640319) ^ 0x61B9F8B5);
					continue;
				case 23u:
					LexSexscene.smethod_21(LexSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_28<string>(2280196178u), 1f);
					LexSexscene.smethod_21(LexSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_28<string>(982786479u), 1f);
					num = (int)(num2 * 21163570) ^ -663145547;
					continue;
				case 22u:
					LexSexscene.smethod_29(LexSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_28<string>(2844830412u), LexSexscene.smethod_32(_opIJo2jLUqdOL5yAFP4yzXce0DG_0));
					num = ((int)num2 * -1832897248) ^ 0xACD6C9D;
					continue;
				case 21u:
					LexSexscene.smethod_21(LexSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_28<string>(2394372064u), 1f);
					num = (int)((num2 * 1868255206) ^ 0x574359F0);
					continue;
				case 20u:
					LexSexscene.smethod_21(LexSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_25<string>(64029633u), 1f);
					num = (int)(num2 * 1285955415) ^ -944674321;
					continue;
				case 19u:
					LexSexscene.smethod_21(LexSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_27<string>(377960696u), 1f);
					num = ((int)num2 * -1666087600) ^ -1741041677;
					continue;
				case 18u:
					LexSexscene.smethod_21(LexSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_26<string>(3734608329u), 1f);
					num = (int)((num2 * 345418454) ^ 0x7677872B);
					continue;
				case 17u:
					LexSexscene.smethod_21(LexSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_25<string>(262898596u), (LexSexscene.smethod_24(_opIJo2jLUqdOL5yAFP4yzXce0DG_0) == _opIJo2jLUqdOL5yAFP4yzXce0DG.ECockType.Knotted) ? 1f : 0f);
					num = -106533527;
					continue;
				case 16u:
					LexSexscene.smethod_21(LexSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_26<string>(291674423u), 1f);
					num = ((int)num2 * -1058863381) ^ -1350039720;
					continue;
				case 15u:
					LexSexscene.smethod_29(LexSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_24<string>(2542702754u), LexSexscene.smethod_28(_opIJo2jLUqdOL5yAFP4yzXce0DG_0));
					LexSexscene.smethod_29(LexSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_25<string>(3687505399u), LexSexscene.smethod_28(_opIJo2jLUqdOL5yAFP4yzXce0DG_0));
					num = (int)((num2 * 1482493821) ^ 0x2FB2664A);
					continue;
				case 14u:
					LexSexscene.smethod_21(LexSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_25<string>(1812486107u), 1f);
					num = (int)((num2 * 400293769) ^ 0x2CE0D718);
					continue;
				case 13u:
					LexSexscene.smethod_21(LexSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_24<string>(3877313647u), 1f);
					num = (int)(num2 * 21206378) ^ -1450584629;
					continue;
				case 12u:
					LexSexscene.smethod_21(LexSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_27<string>(1350886060u), 1f);
					num = (int)((num2 * 679766411) ^ 0x3CFAB782);
					continue;
				case 11u:
					LexSexscene.smethod_21(LexSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_27<string>(1579648385u), 1f);
					num = (int)(num2 * 264013651) ^ -1143030585;
					continue;
				case 10u:
					LexSexscene.smethod_21(LexSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_26<string>(3026792535u), 1f);
					num = (int)(num2 * 709611859) ^ -45074313;
					continue;
				case 9u:
					LexSexscene.smethod_21(LexSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_27<string>(3739792422u), 1f);
					num = ((int)num2 * -2072389940) ^ -1895620905;
					continue;
				case 8u:
					LexSexscene.smethod_21(LexSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_26<string>(2971262786u), 1f);
					LexSexscene.smethod_21(LexSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_26<string>(4283292093u), 1f);
					num = (int)(num2 * 562424296) ^ -2140708094;
					continue;
				case 7u:
					LexSexscene.smethod_21(LexSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_28<string>(1144682514u), 1f);
					LexSexscene.smethod_21(LexSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_25<string>(2344522339u), 1f);
					LexSexscene.smethod_21(LexSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_25<string>(2613118951u), 1f);
					LexSexscene.smethod_21(LexSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_25<string>(2881715563u), 1f);
					LexSexscene.smethod_21(LexSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_25<string>(3150312175u), 1f);
					num = ((int)num2 * -2042999620) ^ -1318926681;
					continue;
				case 6u:
					LexSexscene.smethod_21(LexSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_27<string>(3500178335u), LexSexscene.smethod_27((Enum)LexSexscene.smethod_26(_opIJo2jLUqdOL5yAFP4yzXce0DG_0), (Enum)_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.Stripes) ? 1f : 0f);
					num = -540910699;
					continue;
				case 5u:
					LexSexscene.smethod_21(LexSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_27<string>(1579648385u), 1f);
					num = ((int)num2 * -1279615574) ^ 0xEB0FFD8;
					continue;
				case 4u:
					LexSexscene.smethod_21(LexSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_26<string>(1257253050u), 1f);
					LexSexscene.smethod_21(LexSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_27<string>(628426545u), 1f);
					num = (int)(num2 * 1188363366) ^ -370488962;
					continue;
				case 3u:
					LexSexscene.smethod_21(LexSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_25<string>(1272714387u), 1f);
					num = (int)(num2 * 519234596) ^ -1579218546;
					continue;
				case 1u:
					LexSexscene.smethod_21(LexSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_24<string>(3441736597u), 1f);
					num = (int)(num2 * 1964440208) ^ -542459731;
					continue;
				case 26u:
					break;
				default:
					LexSexscene.smethod_34((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this, flag ? _003CModule_003E.smethod_25<string>(3961259003u) : _003CModule_003E.smethod_27<string>(2037173035u));
					return;
				case 2u:
					LexSexscene.smethod_21(LexSexscene.smethod_15((_TwlwMC1hhdSzamwGWEBxuUkz1gH)this), _003CModule_003E.smethod_25<string>(3150312175u), 1f);
					return;
				}
				break;
			}
		}
	}

	static LexSexscene()
	{
		List<SpineEvent> list = new List<SpineEvent>();
		SpineEvent val = LexSexscene.smethod_35();
		val.AnimationName = _003CModule_003E.smethod_25<string>(3692662391u);
		val.EventName = _003CModule_003E.smethod_27<string>(1597734655u);
		SpineEvent obj = val;
		float[] array = new float[6];
		LexSexscene.smethod_36((Array)array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		obj.FrameTimes = array;
		list.Add(val);
		while (true)
		{
			int num = -1948581044;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDC5883C6u) % 3u)
				{
				case 1u:
					goto IL_004c;
				case 0u:
					break;
				default:
				{
					val = LexSexscene.smethod_35();
					val.AnimationName = _003CModule_003E.smethod_27<string>(131112101u);
					val.EventName = _003CModule_003E.smethod_24<string>(2451770056u);
					SpineEvent obj2 = val;
					float[] array2 = new float[6];
					LexSexscene.smethod_36((Array)array2, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
					obj2.FrameTimes = array2;
					list.Add(val);
					_zAqFZFiaBbpl6Gf6nSX9UC3cSh6 = list;
					return;
				}
				}
				break;
				IL_004c:
				val = LexSexscene.smethod_35();
				val.AnimationName = _003CModule_003E.smethod_26<string>(4184661290u);
				val.EventName = _003CModule_003E.smethod_27<string>(163667387u);
				SpineEvent obj3 = val;
				float[] array3 = new float[6];
				LexSexscene.smethod_36((Array)array3, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
				obj3.FrameTimes = array3;
				list.Add(val);
				num = (int)((num2 * 30686091) ^ 0x3D1EF821);
			}
		}
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

	static void smethod_19(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0, string string_0, float float_0)
	{
		_nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._49JXjKJqaPZw5nEmhHdAENuBtLJ(string_0, float_0);
	}

	string[] method_9()
	{
		return base._tCw3HO9jqoEm2Ad1hqdKsA8vS7b();
	}

	void method_10(string string_0)
	{
		base._GGyEXu1JJKcG2X3txvtCwyZAylK(string_0);
	}

	static bool smethod_20(string string_0, string string_1)
	{
		return string_0 == string_1;
	}

	static void smethod_21(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0, string string_0, float float_0)
	{
		_nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._aAoZaDNczeScsMfLlGSfAzey9SQ(string_0, float_0);
	}

	static bool smethod_22(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0, string string_0)
	{
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._Oms9lumBodLGrGZ09YJaEuzmlAf(string_0);
	}

	static void smethod_23(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0, float float_0)
	{
		_nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._c4iC7y9v6xg7LpvjKIeUkOdZ3UF(float_0);
	}

	static _opIJo2jLUqdOL5yAFP4yzXce0DG.ECockType smethod_24(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._rtyJgfViJdXL2Ela5APpDlk99dI;
	}

	static _opIJo2jLUqdOL5yAFP4yzXce0DG.EBodyType smethod_25(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._8CtoV1bqn0CwCzb1tuoNppBt0Gg;
	}

	static _opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U smethod_26(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._Mz7LwHZqoGBscApFXmff1kEQnGY;
	}

	static bool smethod_27(Enum enum_0, Enum enum_1)
	{
		return enum_0.HasFlag(enum_1);
	}

	static Color smethod_28(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._XnNREK59QnV1onFFWfSUaS9WK0E;
	}

	static void smethod_29(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0, string string_0, Color color_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		_nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._VoeevpFh2kLKfHtpPDXWt0TFbuH(string_0, color_0);
	}

	static Color smethod_30(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._o6OnmHi5rZIQPHESokp9rTaO1ei;
	}

	static Color smethod_31(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._PeK36AvFxEQCvX3fS62hNV7rpuJ;
	}

	static Color smethod_32(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._TxfCqloeyiHpsXka6B46iqCZNsZ;
	}

	static Color smethod_33(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._6f1rvTENt5XWmHTE22zxBIwbH9G;
	}

	static void smethod_34(_TwlwMC1hhdSzamwGWEBxuUkz1gH _TwlwMC1hhdSzamwGWEBxuUkz1gH_0, string string_0)
	{
		_TwlwMC1hhdSzamwGWEBxuUkz1gH_0._GGyEXu1JJKcG2X3txvtCwyZAylK(string_0);
	}

	static SpineEvent smethod_35()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new SpineEvent();
	}

	static void smethod_36(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0)
	{
		RuntimeHelpers.InitializeArray(array_0, runtimeFieldHandle_0);
	}
}
