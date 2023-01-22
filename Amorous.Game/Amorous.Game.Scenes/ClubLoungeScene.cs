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
		ClubLoungeScene.smethod_14((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Background", "Assets/Scenes/ClubLounge/Lounge Main", -1295, 0);
		ClubLoungeScene.smethod_15((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Lights", 638, 0, 500, new string[2] { "Assets/Scenes/ClubLounge/Lights Green Flicker", "Assets/Scenes/ClubLounge/Lights Yellow Flicker" });
		ClubLoungeScene.smethod_14((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Lights Glow", "Assets/Scenes/ClubLounge/Lights glow", 638, 0);
		ClubLoungeScene.smethod_14((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Pole", "Assets/Scenes/ClubLounge/Dance Pole", 1384, -150);
		ClubLoungeScene.smethod_16((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Elevator", "Assets/Scenes/ClubLounge/Elevator Door Selectable", -958, 0, (Action)OnUpstairsClick);
		ClubLoungeScene.smethod_16((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Stairs", "Assets/Scenes/ClubLounge/Stairs selectable", -242, 0, (Action)OnUpstairsClick);
		ClubLoungeScene.smethod_16((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Door", "Assets/Scenes/ClubLounge/Exit door selectable", 235, 0, (Action)OnDoorClick);
		ClubLoungeScene.smethod_17((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Club", 2588, 0, (Action)OnClubClick, 1200, new string[2] { "Assets/Scenes/ClubLounge/Main Room Blue", "Assets/Scenes/ClubLounge/Main Room Green" });
		ClubLoungeScene.smethod_18((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Couches", "Assets/Scenes/ClubLounge/Foreground couches", -1295, 758);
		ClubLoungeScene.smethod_20(ClubLoungeScene.smethod_19(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0), -1295, 1295, 0, 0);
		ClubLoungeScene.smethod_21(_KZ7hNP1K5E99Xfup1lTZ9UDrxPE._oCy13KHJxLHriH7TwMiQ1qKJ8Uc, 0.4f, bool_0: true, bool_1: true);
		_opIJo2jLUqdOL5yAFP4yzXce0DG opIJo2jLUqdOL5yAFP4yzXce0DG_ = ClubLoungeScene.smethod_22();
		_showDustin = !ClubLoungeScene.smethod_23(opIJo2jLUqdOL5yAFP4yzXce0DG_, "DustinLeftClub");
		_showMercy = !ClubLoungeScene.smethod_23(opIJo2jLUqdOL5yAFP4yzXce0DG_, "MercyLeftClub");
		if (_showDustin)
		{
			ClubLoungeScene.smethod_14((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Shadow", "Assets/Scenes/ClubLounge/ShadowDustin", -426, 259);
		}
		if (_showMercy)
		{
			ClubLoungeScene.smethod_14((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Shadow", "Assets/Scenes/ClubLounge/ShadowMercy", 2333, 448);
		}
	}

	public override void Start()
	{
		ClubLoungeBNPC clubLoungeBNPC = ClubLoungeScene.smethod_24((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubLoungeBNPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Background);
		clubLoungeBNPC._tDFvus0ZCanjp81eOiDzoMXJiuf(ClubStaticNPC.EPoses.Nude);
		clubLoungeBNPC._09vxUzgOn7J7DFZEwsTh7lgEIhB(ClubStaticNPC.EClothes.Shirt, ClubStaticNPC.EClothes.Pants);
		ClubLoungeScene.smethod_25((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubLoungeBNPC, 700f);
		ClubLoungeScene.smethod_26((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubLoungeBNPC, 275f);
		ClubLoungeCNPC clubLoungeCNPC = ClubLoungeScene.smethod_24((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubLoungeCNPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Background);
		clubLoungeCNPC._tDFvus0ZCanjp81eOiDzoMXJiuf(ClubStaticNPC.EPoses.Nude);
		clubLoungeCNPC._09vxUzgOn7J7DFZEwsTh7lgEIhB(ClubStaticNPC.EClothes.Shirt, ClubStaticNPC.EClothes.Pants);
		ClubLoungeScene.smethod_25((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubLoungeCNPC, 1000f);
		ClubLoungeScene.smethod_26((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubLoungeCNPC, 275f);
		ClubLoungeEFNPC clubLoungeEFNPC = ClubLoungeScene.smethod_24((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubLoungeEFNPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Background);
		clubLoungeEFNPC._tDFvus0ZCanjp81eOiDzoMXJiuf(ClubLoungeEFNPC.EPoses.Sitting);
		clubLoungeEFNPC._09vxUzgOn7J7DFZEwsTh7lgEIhB(ClubLoungeEFNPC.EClothes.Shirt, ClubLoungeEFNPC.EClothes.Pants);
		ClubLoungeScene.smethod_25((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubLoungeEFNPC, 1600f);
		ClubLoungeScene.smethod_26((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubLoungeEFNPC, 250f);
		ClubLoungeANPC clubLoungeANPC = ClubLoungeScene.smethod_24((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubLoungeANPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Foreground);
		clubLoungeANPC._tDFvus0ZCanjp81eOiDzoMXJiuf(ClubStaticNPC.EPoses.Nude);
		clubLoungeANPC._09vxUzgOn7J7DFZEwsTh7lgEIhB(ClubStaticNPC.EClothes.Shirt);
		ClubLoungeScene.smethod_25((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubLoungeANPC, 40f);
		ClubLoungeScene.smethod_26((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubLoungeANPC, 55f);
		clubLoungeANPC._YyDeMNgCbNCOMTBX2QLUb4ruMp9A = false;
		ClubLoungeDancerANPC clubLoungeDancerANPC = ClubLoungeScene.smethod_24((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubLoungeDancerANPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Foreground);
		clubLoungeDancerANPC._g3oEqGBkN3YHUPosRq2nIP2sX0D(ClubLoungeDancerANPC.EHeads.Smirk);
		clubLoungeDancerANPC._tDFvus0ZCanjp81eOiDzoMXJiuf(ClubLoungeDancerANPC.EPoses.Dancing);
		clubLoungeDancerANPC._09vxUzgOn7J7DFZEwsTh7lgEIhB(ClubLoungeDancerANPC.EClothes.Shirt, ClubLoungeDancerANPC.EClothes.Shorts);
		ClubLoungeScene.smethod_25((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubLoungeDancerANPC, 1450f);
		ClubLoungeScene.smethod_26((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubLoungeDancerANPC, 1000f);
		if (_showDustin)
		{
			_dustin = ClubLoungeScene.smethod_24((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubStaticDustinNPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Foreground);
			ClubLoungeScene.smethod_25((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)_dustin, -370f);
			ClubLoungeScene.smethod_26((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)_dustin, 246f);
			ClubLoungeScene.smethod_27((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)_dustin, (Action)OnDustinClick);
		}
		if (_showMercy)
		{
			_mercy = ClubLoungeScene.smethod_24((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubStaticMercyNPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Foreground);
			ClubLoungeScene.smethod_25((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)_mercy, 2300f);
			ClubLoungeScene.smethod_26((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)_mercy, 225f);
			ClubLoungeScene.smethod_27((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)_mercy, (Action)OnMercyClick);
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
		ClubLoungeScene.smethod_28(ClubLoungeScene.smethod_24((_7UlnfykmEmZDFt3BmCKZekI43Ih)this), "DustinDate");
	}

	private void OnMercyClick()
	{
		ClubLoungeScene.smethod_28(ClubLoungeScene.smethod_24((_7UlnfykmEmZDFt3BmCKZekI43Ih)this), "MercyPreDate");
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
