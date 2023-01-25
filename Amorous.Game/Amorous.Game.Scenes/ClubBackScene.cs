using System;
using Amorous.Game.NPC;

namespace Amorous.Game.Scenes;

public class ClubBackScene : AbstractScene
{
	private ClubStaticLexNPC _lex;

	private readonly bool _showLex;

	public ClubBackScene(IAmorous game)
		: base(Game)
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
		Game._vsceSzSIjBy2nZrCxAzKZbUiwLq._wFfc7xL7eKxed7i9gWtao7pgsnm(-535, 535, 0, 0);
		_UmxbIbk7pgaod0bD7pS309P3Lns._QrgbXEg7MMeD9Ybz12fFVsbmAd9(_KZ7hNP1K5E99Xfup1lTZ9UDrxPE._oCy13KHJxLHriH7TwMiQ1qKJ8Uc, 0.4f, bool_0: true, bool_1: true);
		PlayerData opIJo2jLUqdOL5yAFP4yzXce0DG = _Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t();
		_showLex = !opIJo2jLUqdOL5yAFP4yzXce0DG.GetBit("LexLeftClub");
	}

	public override void Start()
	{
		if (_showLex)
		{
			_lex = base.Game._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubStaticLexNPC>(LayerOrder.Foreground);
			_lex._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EX = -535f;
			_lex._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EY = 250f;
			_lex._ZVpZ5Oing5kbbVhbmbOHyrofGH7 = OnLexClick;
		}
	}

	private void OnDoorClick()
	{
		base.Game.StartScene<ClubLoungeScene>();
	}

	private void OnClubFrontClick()
	{
		base.Game.StartScene<ClubEntranceScene>();
	}

	private void OnLexClick()
	{
		base.Game.RequestScene("LexPreDate");
	}
}
