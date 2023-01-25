using System;
using Amorous.Game.NPC;

namespace Amorous.Game.Scenes;

public class ClubUpstairsScene : AbstractScene
{
	private const int OFFSET_LEFT = -1295;

	private RoseWoodNPC _roseWood;

	private ClubStaticZenithNPC _zenith;

	private readonly bool _showZenith;

	public ClubUpstairsScene(IAmorous game)
		: base(Game)
	{
		_0O8D0mBgmrh0sLOGcLVvGNOHKLCA("Background", "Assets/Scenes/ClubUpstairs/Upstairs Hall main", -1295, 0);
		_2CHUZ5vSi5NbJYJ4gGtr3C2VVEo("Elevator", "Assets/Scenes/ClubUpstairs/Elevator Door Selectable", -919, 103, OnDownstairsClick);
		_2CHUZ5vSi5NbJYJ4gGtr3C2VVEo("Stairs", "Assets/Scenes/ClubUpstairs/Staircase Selectable", -245, 20, OnDownstairsClick);
		_2CHUZ5vSi5NbJYJ4gGtr3C2VVEo("Door", "Assets/Scenes/ClubUpstairs/Pool Door Selectable", 2533, 0, OnDoorClick);
		Game._vsceSzSIjBy2nZrCxAzKZbUiwLq._wFfc7xL7eKxed7i9gWtao7pgsnm(-1295, 1295, 0, 0);
		_UmxbIbk7pgaod0bD7pS309P3Lns._QrgbXEg7MMeD9Ybz12fFVsbmAd9(_KZ7hNP1K5E99Xfup1lTZ9UDrxPE._oCy13KHJxLHriH7TwMiQ1qKJ8Uc, 0.4f, bool_0: true, bool_1: true);
		PlayerData opIJo2jLUqdOL5yAFP4yzXce0DG = _Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t();
		_showZenith = !opIJo2jLUqdOL5yAFP4yzXce0DG.GetBit("ZenithLeftClub");
		if (_showZenith)
		{
			_0O8D0mBgmrh0sLOGcLVvGNOHKLCA("Shadow", "Assets/Scenes/ClubUpstairs/ShadowZenith", 540, 712);
			_0O8D0mBgmrh0sLOGcLVvGNOHKLCA("Shadow", "Assets/Scenes/ClubUpstairs/ShadowRose", 930, 700);
		}
	}

	public override void Start()
	{
		if (_showZenith)
		{
			_roseWood = base.Game._TwQHHdbdRFRy2ctTZabNfz1Htrg<RoseWoodNPC>(LayerOrder.Background);
			_roseWood._zkHMlDFkja4TqmjdlHuZRCj8FCB = false;
			_roseWood._g3oEqGBkN3YHUPosRq2nIP2sX0D(RoseWoodNPC.EHeads.None);
			_roseWood._tDFvus0ZCanjp81eOiDzoMXJiuf(RoseWoodNPC.EPoses.Standing);
			_roseWood._09vxUzgOn7J7DFZEwsTh7lgEIhB(RoseWoodNPC.EClothes.Shirt, RoseWoodNPC.EClothes.Shorts);
			_roseWood._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EX = 950f;
			_roseWood._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EY = 160f;
			_roseWood._fO7gSlrDDNMoHR4FO5QXAq8fUyA = 0.4f;
			_roseWood._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_Pv8G2bIbjHmJYrVXhNyr64NSPXn = true;
			_zenith = base.Game._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubStaticZenithNPC>(LayerOrder.Foreground);
			_zenith._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EX = 580f;
			_zenith._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EY = 10f;
			_zenith._ZVpZ5Oing5kbbVhbmbOHyrofGH7 = OnZenithClick;
		}
	}

	private void OnDoorClick()
	{
		base.Game.StartScene<ClubPoolScene>();
	}

	private void OnDownstairsClick()
	{
		base.Game.StartScene<ClubLoungeScene>();
	}

	private void OnZenithClick()
	{
		base.Game.RequestScene("ZenithPreDate");
	}
}
