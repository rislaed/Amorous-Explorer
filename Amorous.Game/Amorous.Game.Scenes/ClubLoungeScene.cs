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
		_0O8D0mBgmrh0sLOGcLVvGNOHKLCA("Background", "Assets/Scenes/ClubLounge/Lounge Main", -1295, 0);
		_qCH6LFVbWcTfZTRElH4N91FiGeM("Lights", 638, 0, 500, "Assets/Scenes/ClubLounge/Lights Green Flicker", "Assets/Scenes/ClubLounge/Lights Yellow Flicker");
		_0O8D0mBgmrh0sLOGcLVvGNOHKLCA("Lights Glow", "Assets/Scenes/ClubLounge/Lights glow", 638, 0);
		_0O8D0mBgmrh0sLOGcLVvGNOHKLCA("Pole", "Assets/Scenes/ClubLounge/Dance Pole", 1384, -150);
		_2CHUZ5vSi5NbJYJ4gGtr3C2VVEo("Elevator", "Assets/Scenes/ClubLounge/Elevator Door Selectable", -958, 0, OnUpstairsClick);
		_2CHUZ5vSi5NbJYJ4gGtr3C2VVEo("Stairs", "Assets/Scenes/ClubLounge/Stairs selectable", -242, 0, OnUpstairsClick);
		_2CHUZ5vSi5NbJYJ4gGtr3C2VVEo("Door", "Assets/Scenes/ClubLounge/Exit door selectable", 235, 0, OnDoorClick);
		_IsVv8GGyawVeoK7wFAd8Xv3wpvh("Club", 2588, 0, OnClubClick, 1200, "Assets/Scenes/ClubLounge/Main Room Blue", "Assets/Scenes/ClubLounge/Main Room Green");
		_NC5VT77x8y2iH2pW56TBN1eyomA("Couches", "Assets/Scenes/ClubLounge/Foreground couches", -1295, 758);
		_JbeCmOie0phb2cbgG6DdGZrbs3pB_0._vsceSzSIjBy2nZrCxAzKZbUiwLq._wFfc7xL7eKxed7i9gWtao7pgsnm(-1295, 1295, 0, 0);
		_UmxbIbk7pgaod0bD7pS309P3Lns._QrgbXEg7MMeD9Ybz12fFVsbmAd9(_KZ7hNP1K5E99Xfup1lTZ9UDrxPE._oCy13KHJxLHriH7TwMiQ1qKJ8Uc, 0.4f, bool_0: true, bool_1: true);
		_opIJo2jLUqdOL5yAFP4yzXce0DG opIJo2jLUqdOL5yAFP4yzXce0DG = _Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t();
		_showDustin = !opIJo2jLUqdOL5yAFP4yzXce0DG._Oms9lumBodLGrGZ09YJaEuzmlAf("DustinLeftClub");
		_showMercy = !opIJo2jLUqdOL5yAFP4yzXce0DG._Oms9lumBodLGrGZ09YJaEuzmlAf("MercyLeftClub");
		if (_showDustin)
		{
			_0O8D0mBgmrh0sLOGcLVvGNOHKLCA("Shadow", "Assets/Scenes/ClubLounge/ShadowDustin", -426, 259);
		}
		if (_showMercy)
		{
			_0O8D0mBgmrh0sLOGcLVvGNOHKLCA("Shadow", "Assets/Scenes/ClubLounge/ShadowMercy", 2333, 448);
		}
	}

	public override void Start()
	{
		ClubLoungeBNPC clubLoungeBNPC = base._ZzBuoSDMWwerejOO9Goyv2OCKgE._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubLoungeBNPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Background);
		clubLoungeBNPC._tDFvus0ZCanjp81eOiDzoMXJiuf(ClubStaticNPC.EPoses.Nude);
		clubLoungeBNPC._09vxUzgOn7J7DFZEwsTh7lgEIhB(ClubStaticNPC.EClothes.Shirt, ClubStaticNPC.EClothes.Pants);
		clubLoungeBNPC._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_7Xn1C5tjYnmIif1iZKV8AWsEEbL = 700f;
		clubLoungeBNPC._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_bCjZ3VSXGKyhmykd2zCnQBiSpDf = 275f;
		ClubLoungeCNPC clubLoungeCNPC = base._ZzBuoSDMWwerejOO9Goyv2OCKgE._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubLoungeCNPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Background);
		clubLoungeCNPC._tDFvus0ZCanjp81eOiDzoMXJiuf(ClubStaticNPC.EPoses.Nude);
		clubLoungeCNPC._09vxUzgOn7J7DFZEwsTh7lgEIhB(ClubStaticNPC.EClothes.Shirt, ClubStaticNPC.EClothes.Pants);
		clubLoungeCNPC._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_7Xn1C5tjYnmIif1iZKV8AWsEEbL = 1000f;
		clubLoungeCNPC._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_bCjZ3VSXGKyhmykd2zCnQBiSpDf = 275f;
		ClubLoungeEFNPC clubLoungeEFNPC = base._ZzBuoSDMWwerejOO9Goyv2OCKgE._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubLoungeEFNPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Background);
		clubLoungeEFNPC._tDFvus0ZCanjp81eOiDzoMXJiuf(ClubLoungeEFNPC.EPoses.Sitting);
		clubLoungeEFNPC._09vxUzgOn7J7DFZEwsTh7lgEIhB(ClubLoungeEFNPC.EClothes.Shirt, ClubLoungeEFNPC.EClothes.Pants);
		clubLoungeEFNPC._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_7Xn1C5tjYnmIif1iZKV8AWsEEbL = 1600f;
		clubLoungeEFNPC._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_bCjZ3VSXGKyhmykd2zCnQBiSpDf = 250f;
		ClubLoungeANPC clubLoungeANPC = base._ZzBuoSDMWwerejOO9Goyv2OCKgE._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubLoungeANPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Foreground);
		clubLoungeANPC._tDFvus0ZCanjp81eOiDzoMXJiuf(ClubStaticNPC.EPoses.Nude);
		clubLoungeANPC._09vxUzgOn7J7DFZEwsTh7lgEIhB(ClubStaticNPC.EClothes.Shirt);
		clubLoungeANPC._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_7Xn1C5tjYnmIif1iZKV8AWsEEbL = 40f;
		clubLoungeANPC._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_bCjZ3VSXGKyhmykd2zCnQBiSpDf = 55f;
		clubLoungeANPC._YyDeMNgCbNCOMTBX2QLUb4ruMp9A = false;
		ClubLoungeDancerANPC clubLoungeDancerANPC = base._ZzBuoSDMWwerejOO9Goyv2OCKgE._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubLoungeDancerANPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Foreground);
		clubLoungeDancerANPC._g3oEqGBkN3YHUPosRq2nIP2sX0D(ClubLoungeDancerANPC.EHeads.Smirk);
		clubLoungeDancerANPC._tDFvus0ZCanjp81eOiDzoMXJiuf(ClubLoungeDancerANPC.EPoses.Dancing);
		clubLoungeDancerANPC._09vxUzgOn7J7DFZEwsTh7lgEIhB(ClubLoungeDancerANPC.EClothes.Shirt, ClubLoungeDancerANPC.EClothes.Shorts);
		clubLoungeDancerANPC._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_7Xn1C5tjYnmIif1iZKV8AWsEEbL = 1450f;
		clubLoungeDancerANPC._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_bCjZ3VSXGKyhmykd2zCnQBiSpDf = 1000f;
		if (_showDustin)
		{
			_dustin = base._ZzBuoSDMWwerejOO9Goyv2OCKgE._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubStaticDustinNPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Foreground);
			_dustin._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_7Xn1C5tjYnmIif1iZKV8AWsEEbL = -370f;
			_dustin._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_bCjZ3VSXGKyhmykd2zCnQBiSpDf = 246f;
			_dustin._ZVpZ5Oing5kbbVhbmbOHyrofGH7 = OnDustinClick;
		}
		if (_showMercy)
		{
			_mercy = base._ZzBuoSDMWwerejOO9Goyv2OCKgE._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubStaticMercyNPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Foreground);
			_mercy._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_7Xn1C5tjYnmIif1iZKV8AWsEEbL = 2300f;
			_mercy._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_bCjZ3VSXGKyhmykd2zCnQBiSpDf = 225f;
			_mercy._ZVpZ5Oing5kbbVhbmbOHyrofGH7 = OnMercyClick;
		}
	}

	private void OnDoorClick()
	{
		base._ZzBuoSDMWwerejOO9Goyv2OCKgE._k9wUPeU1Ga7cygiuGP8TT6aPLWF<ClubBackScene>();
	}

	private void OnUpstairsClick()
	{
		base._ZzBuoSDMWwerejOO9Goyv2OCKgE._k9wUPeU1Ga7cygiuGP8TT6aPLWF<ClubUpstairsScene>();
	}

	private void OnClubClick()
	{
		base._ZzBuoSDMWwerejOO9Goyv2OCKgE._k9wUPeU1Ga7cygiuGP8TT6aPLWF<ClubInsideScene>();
	}

	private void OnDustinClick()
	{
		base._ZzBuoSDMWwerejOO9Goyv2OCKgE._xyl3Tv5KdR5eezDgagxbBcS3cwt("DustinDate");
	}

	private void OnMercyClick()
	{
		base._ZzBuoSDMWwerejOO9Goyv2OCKgE._xyl3Tv5KdR5eezDgagxbBcS3cwt("MercyPreDate");
	}
}
