using System;
using Amorous.Game.NPC;

namespace Amorous.Game.Scenes;

public class ClubLoungeScene : _7UlnfykmEmZDFt3BmCKZekI43Ih
{
	private ClubStaticDustinNPC _dustin;

	private ClubStaticMercyNPC _mercy;

	private readonly bool _showDustin;

	private readonly bool _showMercy;

	public ClubLoungeScene(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		ClubLoungeScene.smethod_14((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, _003CModule_003E.smethod_27<string>(3171999506u), _003CModule_003E.smethod_25<string>(3302335182u), -1295, 0);
		ClubLoungeScene.smethod_15((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, _003CModule_003E.smethod_25<string>(458864292u), 638, 0, 500, new string[2]
		{
			_003CModule_003E.smethod_28<string>(1548224949u),
			_003CModule_003E.smethod_25<string>(683518215u)
		});
		ClubLoungeScene.smethod_14((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, _003CModule_003E.smethod_25<string>(1422158898u), _003CModule_003E.smethod_28<string>(3698831195u), 638, 0);
		ClubLoungeScene.smethod_14((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, _003CModule_003E.smethod_27<string>(39921390u), _003CModule_003E.smethod_24<string>(3654275703u), 1384, -150);
		ClubLoungeScene.smethod_16((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, _003CModule_003E.smethod_25<string>(3434054992u), _003CModule_003E.smethod_24<string>(403534600u), -958, 0, (Action)OnUpstairsClick);
		ClubLoungeScene.smethod_16((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, _003CModule_003E.smethod_24<string>(1257102094u), _003CModule_003E.smethod_26<string>(140798367u), -242, 0, (Action)OnUpstairsClick);
		ClubLoungeScene.smethod_16((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, _003CModule_003E.smethod_27<string>(522766818u), _003CModule_003E.smethod_26<string>(848614161u), 235, 0, (Action)OnDoorClick);
		ClubLoungeScene.smethod_17((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, _003CModule_003E.smethod_26<string>(1505871684u), 2588, 0, (Action)OnClubClick, 1200, new string[2]
		{
			_003CModule_003E.smethod_28<string>(1386328914u),
			_003CModule_003E.smethod_28<string>(2461632037u)
		});
		ClubLoungeScene.smethod_18((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, _003CModule_003E.smethod_25<string>(3498625649u), _003CModule_003E.smethod_24<string>(358068251u), -1295, 758);
		ClubLoungeScene.smethod_20(ClubLoungeScene.smethod_19(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0), -1295, 1295, 0, 0);
		ClubLoungeScene.smethod_21(_KZ7hNP1K5E99Xfup1lTZ9UDrxPE._oCy13KHJxLHriH7TwMiQ1qKJ8Uc, 0.4f, bool_0: true, bool_1: true);
		_opIJo2jLUqdOL5yAFP4yzXce0DG opIJo2jLUqdOL5yAFP4yzXce0DG_ = ClubLoungeScene.smethod_22();
		_showDustin = !ClubLoungeScene.smethod_23(opIJo2jLUqdOL5yAFP4yzXce0DG_, _003CModule_003E.smethod_28<string>(2804159695u));
		_showMercy = !ClubLoungeScene.smethod_23(opIJo2jLUqdOL5yAFP4yzXce0DG_, _003CModule_003E.smethod_24<string>(3945410320u));
		if (_showDustin)
		{
			ClubLoungeScene.smethod_14((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, _003CModule_003E.smethod_25<string>(1282703600u), _003CModule_003E.smethod_24<string>(1003390440u), -426, 259);
		}
		if (_showMercy)
		{
			ClubLoungeScene.smethod_14((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, _003CModule_003E.smethod_28<string>(2689983809u), _003CModule_003E.smethod_28<string>(3482969815u), 2333, 448);
		}
	}

	public override void Start()
	{
		ClubLoungeBNPC clubLoungeBNPC = ClubLoungeScene.smethod_24((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubLoungeBNPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Background);
		clubLoungeBNPC._tDFvus0ZCanjp81eOiDzoMXJiuf(ClubStaticNPC.EPoses.Nude);
		ClubLoungeEFNPC clubLoungeEFNPC = default(ClubLoungeEFNPC);
		ClubLoungeDancerANPC clubLoungeDancerANPC = default(ClubLoungeDancerANPC);
		ClubLoungeANPC clubLoungeANPC = default(ClubLoungeANPC);
		ClubLoungeCNPC clubLoungeCNPC = default(ClubLoungeCNPC);
		while (true)
		{
			int num = -131656132;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x80653D4Bu) % 27u)
				{
				case 26u:
					clubLoungeEFNPC = ClubLoungeScene.smethod_24((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubLoungeEFNPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Background);
					num = (int)((num2 * 1137370713) ^ 0x854BC56);
					continue;
				case 25u:
				{
					ClubLoungeScene.smethod_25((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubLoungeDancerANPC, 1450f);
					ClubLoungeScene.smethod_26((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubLoungeDancerANPC, 1000f);
					int num4;
					int num5;
					if (_showDustin)
					{
						num4 = 1481210808;
						num5 = 1481210808;
					}
					else
					{
						num4 = 585111016;
						num5 = 585111016;
					}
					num = num4 ^ (int)(num2 * 254406091);
					continue;
				}
				case 24u:
					ClubLoungeScene.smethod_25((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubLoungeANPC, 40f);
					ClubLoungeScene.smethod_26((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubLoungeANPC, 55f);
					num = ((int)num2 * -1776498319) ^ 0x486E7FB8;
					continue;
				case 22u:
					clubLoungeANPC._09vxUzgOn7J7DFZEwsTh7lgEIhB(ClubStaticNPC.EClothes.Shirt);
					num = (int)(num2 * 1565353247) ^ -1993344003;
					continue;
				case 21u:
					ClubLoungeScene.smethod_25((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubLoungeBNPC, 700f);
					num = ((int)num2 * -1283703805) ^ 0x1303DAD8;
					continue;
				case 20u:
					clubLoungeEFNPC._tDFvus0ZCanjp81eOiDzoMXJiuf(ClubLoungeEFNPC.EPoses.Sitting);
					num = (int)((num2 * 227663206) ^ 0x2AA0C10E);
					continue;
				case 19u:
					clubLoungeDancerANPC = ClubLoungeScene.smethod_24((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubLoungeDancerANPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Foreground);
					num = (int)(num2 * 1857838674) ^ -1916403547;
					continue;
				case 18u:
					clubLoungeBNPC._09vxUzgOn7J7DFZEwsTh7lgEIhB(ClubStaticNPC.EClothes.Shirt, ClubStaticNPC.EClothes.Pants);
					num = (int)(num2 * 2061949623) ^ -438167209;
					continue;
				case 17u:
					clubLoungeDancerANPC._tDFvus0ZCanjp81eOiDzoMXJiuf(ClubLoungeDancerANPC.EPoses.Dancing);
					num = ((int)num2 * -298366285) ^ 0x2500FC1D;
					continue;
				case 16u:
					_dustin = ClubLoungeScene.smethod_24((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubStaticDustinNPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Foreground);
					ClubLoungeScene.smethod_25((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)_dustin, -370f);
					num = (int)((num2 * 1602854794) ^ 0x6C114021);
					continue;
				case 15u:
					clubLoungeANPC._tDFvus0ZCanjp81eOiDzoMXJiuf(ClubStaticNPC.EPoses.Nude);
					num = ((int)num2 * -1163354828) ^ 0x2AF7586F;
					continue;
				case 14u:
					ClubLoungeScene.smethod_26((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubLoungeCNPC, 275f);
					num = (int)((num2 * 1781249465) ^ 0x23C75EAF);
					continue;
				case 12u:
					ClubLoungeScene.smethod_26((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)_dustin, 246f);
					ClubLoungeScene.smethod_27((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)_dustin, (Action)OnDustinClick);
					num = (int)(num2 * 964919393) ^ -1728609299;
					continue;
				case 11u:
					ClubLoungeScene.smethod_26((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubLoungeBNPC, 275f);
					num = (int)((num2 * 1042662932) ^ 0x5FB27A59);
					continue;
				case 10u:
					clubLoungeDancerANPC._g3oEqGBkN3YHUPosRq2nIP2sX0D(ClubLoungeDancerANPC.EHeads.Smirk);
					num = ((int)num2 * -229581051) ^ 0x61B0D9A1;
					continue;
				case 9u:
					ClubLoungeScene.smethod_25((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubLoungeCNPC, 1000f);
					num = ((int)num2 * -85112404) ^ 0x70C3AF74;
					continue;
				case 8u:
					_mercy = ClubLoungeScene.smethod_24((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubStaticMercyNPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Foreground);
					num = (int)(num2 * 828752462) ^ -802821296;
					continue;
				case 7u:
					ClubLoungeScene.smethod_25((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)_mercy, 2300f);
					ClubLoungeScene.smethod_26((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)_mercy, 225f);
					ClubLoungeScene.smethod_27((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)_mercy, (Action)OnMercyClick);
					num = ((int)num2 * -811572505) ^ -1828664916;
					continue;
				case 6u:
					clubLoungeANPC._YyDeMNgCbNCOMTBX2QLUb4ruMp9A = false;
					num = ((int)num2 * -1667764284) ^ 0x2E5FE064;
					continue;
				case 5u:
					clubLoungeEFNPC._09vxUzgOn7J7DFZEwsTh7lgEIhB(ClubLoungeEFNPC.EClothes.Shirt, ClubLoungeEFNPC.EClothes.Pants);
					num = (int)(num2 * 1260352375) ^ -691777011;
					continue;
				case 4u:
					clubLoungeCNPC = ClubLoungeScene.smethod_24((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubLoungeCNPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Background);
					clubLoungeCNPC._tDFvus0ZCanjp81eOiDzoMXJiuf(ClubStaticNPC.EPoses.Nude);
					clubLoungeCNPC._09vxUzgOn7J7DFZEwsTh7lgEIhB(ClubStaticNPC.EClothes.Shirt, ClubStaticNPC.EClothes.Pants);
					num = (int)((num2 * 928706191) ^ 0x4895DC91);
					continue;
				case 3u:
					ClubLoungeScene.smethod_26((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubLoungeEFNPC, 250f);
					clubLoungeANPC = ClubLoungeScene.smethod_24((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubLoungeANPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Foreground);
					num = (int)((num2 * 672548339) ^ 0x202B0873);
					continue;
				case 2u:
					ClubLoungeScene.smethod_25((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubLoungeEFNPC, 1600f);
					num = (int)((num2 * 1291015316) ^ 0x17B860D4);
					continue;
				case 1u:
					clubLoungeDancerANPC._09vxUzgOn7J7DFZEwsTh7lgEIhB(ClubLoungeDancerANPC.EClothes.Shirt, ClubLoungeDancerANPC.EClothes.Shorts);
					num = (int)(num2 * 1626528104) ^ -1325598306;
					continue;
				case 0u:
				{
					int num3;
					if (!_showMercy)
					{
						num = -199201667;
						num3 = -199201667;
					}
					else
					{
						num = -718504631;
						num3 = -718504631;
					}
					continue;
				}
				default:
					return;
				case 13u:
					break;
				case 23u:
					return;
				}
				break;
			}
		}
	}

	private void OnDoorClick()
	{
		ClubLoungeScene.smethod_24((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._k9wUPeU1Ga7cygiuGP8TT6aPLWF<ClubBackScene>();
	}

	private void OnUpstairsClick()
	{
		ClubLoungeScene.smethod_24((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._k9wUPeU1Ga7cygiuGP8TT6aPLWF<ClubUpstairsScene>();
	}

	private void OnClubClick()
	{
		ClubLoungeScene.smethod_24((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._k9wUPeU1Ga7cygiuGP8TT6aPLWF<ClubInsideScene>();
	}

	private void OnDustinClick()
	{
		ClubLoungeScene.smethod_28(ClubLoungeScene.smethod_24((_7UlnfykmEmZDFt3BmCKZekI43Ih)this), _003CModule_003E.smethod_24<string>(1967726989u));
	}

	private void OnMercyClick()
	{
		ClubLoungeScene.smethod_28(ClubLoungeScene.smethod_24((_7UlnfykmEmZDFt3BmCKZekI43Ih)this), _003CModule_003E.smethod_28<string>(1396577887u));
	}

	static _uqydQVaCmCvK7zzWs5W4gZFpKBu smethod_14(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0, string string_0, string string_1, int int_0, int int_1)
	{
		return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._0O8D0mBgmrh0sLOGcLVvGNOHKLCA(string_0, string_1, int_0, int_1);
	}

	static _kxm3yIqio0baXT5t5vOHBAEdviB smethod_15(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0, string string_0, int int_0, int int_1, int int_2, string[] string_1)
	{
		return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._qCH6LFVbWcTfZTRElH4N91FiGeM(string_0, int_0, int_1, int_2, string_1);
	}

	static _z20t8IpBINiJtljSeTIkNoKUOkx smethod_16(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0, string string_0, string string_1, int int_0, int int_1, Action action_0)
	{
		return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._2CHUZ5vSi5NbJYJ4gGtr3C2VVEo(string_0, string_1, int_0, int_1, action_0);
	}

	static _rmc1e7Ng50C4uLmgllAoRtxaZiB smethod_17(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0, string string_0, int int_0, int int_1, Action action_0, int int_2, string[] string_1)
	{
		return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._IsVv8GGyawVeoK7wFAd8Xv3wpvh(string_0, int_0, int_1, action_0, int_2, string_1);
	}

	static _uqydQVaCmCvK7zzWs5W4gZFpKBu smethod_18(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0, string string_0, string string_1, int int_0, int int_1)
	{
		return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._NC5VT77x8y2iH2pW56TBN1eyomA(string_0, string_1, int_0, int_1);
	}

	static _wRd4nHuQQlAPEwrHOGkBfut6Uip smethod_19(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		return _JbeCmOie0phb2cbgG6DdGZrbs3pB_0._vsceSzSIjBy2nZrCxAzKZbUiwLq;
	}

	static void smethod_20(_wRd4nHuQQlAPEwrHOGkBfut6Uip _wRd4nHuQQlAPEwrHOGkBfut6Uip_0, int int_0, int int_1, int int_2, int int_3)
	{
		_wRd4nHuQQlAPEwrHOGkBfut6Uip_0._wFfc7xL7eKxed7i9gWtao7pgsnm(int_0, int_1, int_2, int_3);
	}

	static void smethod_21(string[] string_0, float float_0, bool bool_0, bool bool_1)
	{
		_UmxbIbk7pgaod0bD7pS309P3Lns._QrgbXEg7MMeD9Ybz12fFVsbmAd9(string_0, float_0, bool_0, bool_1);
	}

	static _opIJo2jLUqdOL5yAFP4yzXce0DG smethod_22()
	{
		return _Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t();
	}

	static bool smethod_23(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0, string string_0)
	{
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._Oms9lumBodLGrGZ09YJaEuzmlAf(string_0);
	}

	static _JbeCmOie0phb2cbgG6DdGZrbs3pB smethod_24(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0)
	{
		return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._ZzBuoSDMWwerejOO9Goyv2OCKgE;
	}

	static void smethod_25(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, float float_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_7Xn1C5tjYnmIif1iZKV8AWsEEbL = float_0;
	}

	static void smethod_26(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, float float_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_bCjZ3VSXGKyhmykd2zCnQBiSpDf = float_0;
	}

	static void smethod_27(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, Action action_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._ZVpZ5Oing5kbbVhbmbOHyrofGH7 = action_0;
	}

	static void smethod_28(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0, string string_0)
	{
		_JbeCmOie0phb2cbgG6DdGZrbs3pB_0._xyl3Tv5KdR5eezDgagxbBcS3cwt(string_0);
	}
}
