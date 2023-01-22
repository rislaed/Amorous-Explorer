using System;
using Amorous.Game.NPC;

namespace Amorous.Game.Scenes;

public class ClubEntranceScene : _7UlnfykmEmZDFt3BmCKZekI43Ih
{
	private KaneNPC _kane;

	private _3IHp43rpkJgOBcY9lrIrwMuwWve _kaneLayer;

	public ClubEntranceScene(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		_0O8D0mBgmrh0sLOGcLVvGNOHKLCA("Background", "Assets/Scenes/ClubEntrance/Club Front", -535, 0);
		_0O8D0mBgmrh0sLOGcLVvGNOHKLCA("Rope Back", "Assets/Scenes/ClubEntrance/Club Front Ropes (behind)", -535, 0);
		_qCH6LFVbWcTfZTRElH4N91FiGeM("Lights", -535, 0, 500, "Assets/Scenes/ClubEntrance/Club Front Glow (option one)", "Assets/Scenes/ClubEntrance/Club Front Glow (option two)");
		_2CHUZ5vSi5NbJYJ4gGtr3C2VVEo("Entrance", "Assets/Scenes/ClubEntrance/Club Entrance Door Selectable", 410, 96, OnDoorClick);
		_2CHUZ5vSi5NbJYJ4gGtr3C2VVEo("Club Back", "Assets/Scenes/ClubEntrance/Back of Club Selectable", -535, 0, OnClubBackClick);
		_0O8D0mBgmrh0sLOGcLVvGNOHKLCA("Rope Front", "Assets/Scenes/ClubEntrance/Club Front Ropes (infront)", -535, 0);
		_JbeCmOie0phb2cbgG6DdGZrbs3pB_0._vsceSzSIjBy2nZrCxAzKZbUiwLq._wFfc7xL7eKxed7i9gWtao7pgsnm(-535, 535, 0, 0);
		_UmxbIbk7pgaod0bD7pS309P3Lns._QrgbXEg7MMeD9Ybz12fFVsbmAd9(_KZ7hNP1K5E99Xfup1lTZ9UDrxPE._oCy13KHJxLHriH7TwMiQ1qKJ8Uc, 0.4f, bool_0: true, bool_1: true);
		_opIJo2jLUqdOL5yAFP4yzXce0DG opIJo2jLUqdOL5yAFP4yzXce0DG = _Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t();
		if (opIJo2jLUqdOL5yAFP4yzXce0DG._fvTKDuNATrUxfXZVvltePz3vYkK("Prologue") >= 20)
		{
			_poenyHBGUusBcnNcTFB9MQBV72R._kf3EbE0B70xGe1szklqAZyCqoLj = true;
		}
	}

	public override void Start()
	{
		_kane = base._ZzBuoSDMWwerejOO9Goyv2OCKgE._TwQHHdbdRFRy2ctTZabNfz1Htrg<KaneNPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Background);
		_kaneLayer = _VvFE2zgy4FbDjvaEvb67tXJ7aRm<KaneNPC>();
		_kaneLayer._64JjsghBPDjZ1OxZwhO8Y6dFE5t = delegate
		{
			_kaneLayer._ac2H6kMdrgPhXXxabsikjji4SiT = 1;
			_kaneLayer._VNgmwYSLsJyyiR6cPQ35UHJBR4d = 0;
			_kane._zkHMlDFkja4TqmjdlHuZRCj8FCB = false;
			_kane._g3oEqGBkN3YHUPosRq2nIP2sX0D(KaneNPC.EHeads.Angry);
			_kane._tDFvus0ZCanjp81eOiDzoMXJiuf(KaneNPC.EPoses.Stern);
			_kane._09vxUzgOn7J7DFZEwsTh7lgEIhB(KaneNPC.EClothes.Shirt, KaneNPC.EClothes.Shorts);
			_kane._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_7Xn1C5tjYnmIif1iZKV8AWsEEbL = -25f;
			_kane._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_bCjZ3VSXGKyhmykd2zCnQBiSpDf = 180f;
			_kane._fO7gSlrDDNMoHR4FO5QXAq8fUyA = 0.4f;
			_kane._ZVpZ5Oing5kbbVhbmbOHyrofGH7 = OnKaneClick;
			_yMMFQ2n4dqXlB1AEzmdkoKkPkX5();
		};
		ClubEntranceABNPC clubEntranceABNPC = base._ZzBuoSDMWwerejOO9Goyv2OCKgE._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubEntranceABNPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Background);
		clubEntranceABNPC._tDFvus0ZCanjp81eOiDzoMXJiuf(ClubStaticNPC.EPoses.Nude);
		clubEntranceABNPC._09vxUzgOn7J7DFZEwsTh7lgEIhB(ClubStaticNPC.EClothes.Pants, ClubStaticNPC.EClothes.Shirt);
		clubEntranceABNPC._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_7Xn1C5tjYnmIif1iZKV8AWsEEbL = -325f;
		clubEntranceABNPC._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_bCjZ3VSXGKyhmykd2zCnQBiSpDf = 300f;
		_3IHp43rpkJgOBcY9lrIrwMuwWve _3IHp43rpkJgOBcY9lrIrwMuwWve = _VvFE2zgy4FbDjvaEvb67tXJ7aRm<ClubEntranceABNPC>();
		_3IHp43rpkJgOBcY9lrIrwMuwWve._VNgmwYSLsJyyiR6cPQ35UHJBR4d = 1;
		ClubEntranceCNPC clubEntranceCNPC = base._ZzBuoSDMWwerejOO9Goyv2OCKgE._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubEntranceCNPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Background);
		clubEntranceCNPC._tDFvus0ZCanjp81eOiDzoMXJiuf(ClubStaticNPC.EPoses.Nude);
		clubEntranceCNPC._09vxUzgOn7J7DFZEwsTh7lgEIhB(ClubStaticNPC.EClothes.Pants, ClubStaticNPC.EClothes.Shirt);
		clubEntranceCNPC._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_7Xn1C5tjYnmIif1iZKV8AWsEEbL = 1630f;
		clubEntranceCNPC._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_bCjZ3VSXGKyhmykd2zCnQBiSpDf = 205f;
		ClubEntranceDNPC clubEntranceDNPC = base._ZzBuoSDMWwerejOO9Goyv2OCKgE._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubEntranceDNPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Background);
		clubEntranceDNPC._tDFvus0ZCanjp81eOiDzoMXJiuf(ClubStaticNPC.EPoses.Nude);
		clubEntranceDNPC._09vxUzgOn7J7DFZEwsTh7lgEIhB(ClubStaticNPC.EClothes.Pants, ClubStaticNPC.EClothes.Shirt);
		clubEntranceDNPC._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_7Xn1C5tjYnmIif1iZKV8AWsEEbL = 1930f;
		clubEntranceDNPC._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_bCjZ3VSXGKyhmykd2zCnQBiSpDf = 255f;
		_3IHp43rpkJgOBcY9lrIrwMuwWve _3IHp43rpkJgOBcY9lrIrwMuwWve2 = _VvFE2zgy4FbDjvaEvb67tXJ7aRm<ClubEntranceCNPC>();
		_3IHp43rpkJgOBcY9lrIrwMuwWve2._VNgmwYSLsJyyiR6cPQ35UHJBR4d = 1;
		_3IHp43rpkJgOBcY9lrIrwMuwWve _3IHp43rpkJgOBcY9lrIrwMuwWve3 = _VvFE2zgy4FbDjvaEvb67tXJ7aRm<ClubEntranceDNPC>();
		_3IHp43rpkJgOBcY9lrIrwMuwWve3._VNgmwYSLsJyyiR6cPQ35UHJBR4d = 1;
	}

	private void OnDoorClick()
	{
		base._ZzBuoSDMWwerejOO9Goyv2OCKgE._k9wUPeU1Ga7cygiuGP8TT6aPLWF<ClubInsideScene>();
	}

	private void OnClubBackClick()
	{
		base._ZzBuoSDMWwerejOO9Goyv2OCKgE._k9wUPeU1Ga7cygiuGP8TT6aPLWF<ClubBackScene>();
	}

	private void OnKaneClick()
	{
		_kaneLayer._ac2H6kMdrgPhXXxabsikjji4SiT = 3;
		_kaneLayer._VNgmwYSLsJyyiR6cPQ35UHJBR4d = 0;
		_kane._ZVpZ5Oing5kbbVhbmbOHyrofGH7 = null;
		_kane._IvIFs0Tl6RHdTn3daJXsNCXCNyO = false;
		_yMMFQ2n4dqXlB1AEzmdkoKkPkX5();
		base._ZzBuoSDMWwerejOO9Goyv2OCKgE._xyl3Tv5KdR5eezDgagxbBcS3cwt("Kane");
	}
}
