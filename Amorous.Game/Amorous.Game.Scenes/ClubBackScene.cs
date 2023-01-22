using System;
using Amorous.Game.NPC;

namespace Amorous.Game.Scenes;

public class ClubBackScene : _7UlnfykmEmZDFt3BmCKZekI43Ih
{
	private ClubStaticLexNPC _lex;

	private readonly bool _showLex;

	public ClubBackScene(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		_0O8D0mBgmrh0sLOGcLVvGNOHKLCA("Background", "Assets/Scenes/ClubBack/Club back main", -535, 0);
		_0O8D0mBgmrh0sLOGcLVvGNOHKLCA("Background", "Assets/Scenes/ClubBack/Club back bodies", 1313, 486);
		if (!_iExD93IWLlzVfXsU9wyrEvWgJsg._b52DDz3MN1kD8sgdQhCNO1tJRNn)
		{
			_0O8D0mBgmrh0sLOGcLVvGNOHKLCA("Background", "Assets/Scenes/ClubBack/Club back shirts", 1313, 486);
		}
		if (!_iExD93IWLlzVfXsU9wyrEvWgJsg._pKBiGAgDu5WqoykkGBaEGnP7oMj)
		{
			_0O8D0mBgmrh0sLOGcLVvGNOHKLCA("Background", "Assets/Scenes/ClubBack/Club back pants", 1313, 486);
		}
		_2CHUZ5vSi5NbJYJ4gGtr3C2VVEo("Door", "Assets/Scenes/ClubBack/Door to lounge selectable", -217, 120, OnDoorClick);
		_2CHUZ5vSi5NbJYJ4gGtr3C2VVEo("Side", "Assets/Scenes/ClubBack/Front of Club Selectable", 608, 0, OnClubFrontClick);
		_t1wBwPCrsAvA30GB26t9oLVcGfU("Fan", "Assets/Scenes/ClubBack/Fan", 524, 75, 10f, 68, 75);
		_JbeCmOie0phb2cbgG6DdGZrbs3pB_0._vsceSzSIjBy2nZrCxAzKZbUiwLq._wFfc7xL7eKxed7i9gWtao7pgsnm(-535, 535, 0, 0);
		_UmxbIbk7pgaod0bD7pS309P3Lns._QrgbXEg7MMeD9Ybz12fFVsbmAd9(_KZ7hNP1K5E99Xfup1lTZ9UDrxPE._oCy13KHJxLHriH7TwMiQ1qKJ8Uc, 0.4f, bool_0: true, bool_1: true);
		_opIJo2jLUqdOL5yAFP4yzXce0DG opIJo2jLUqdOL5yAFP4yzXce0DG = _Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t();
		_showLex = !opIJo2jLUqdOL5yAFP4yzXce0DG._Oms9lumBodLGrGZ09YJaEuzmlAf("LexLeftClub");
	}

	public override void Start()
	{
		if (_showLex)
		{
			_lex = base._ZzBuoSDMWwerejOO9Goyv2OCKgE._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubStaticLexNPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Foreground);
			_lex._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_7Xn1C5tjYnmIif1iZKV8AWsEEbL = -535f;
			_lex._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_bCjZ3VSXGKyhmykd2zCnQBiSpDf = 250f;
			_lex._ZVpZ5Oing5kbbVhbmbOHyrofGH7 = OnLexClick;
		}
	}

	private void OnDoorClick()
	{
		base._ZzBuoSDMWwerejOO9Goyv2OCKgE._k9wUPeU1Ga7cygiuGP8TT6aPLWF<ClubLoungeScene>();
	}

	private void OnClubFrontClick()
	{
		base._ZzBuoSDMWwerejOO9Goyv2OCKgE._k9wUPeU1Ga7cygiuGP8TT6aPLWF<ClubEntranceScene>();
	}

	private void OnLexClick()
	{
		base._ZzBuoSDMWwerejOO9Goyv2OCKgE._xyl3Tv5KdR5eezDgagxbBcS3cwt("LexPreDate");
	}
}
