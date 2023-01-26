using System;
using Amorous.Game.NPC;

namespace Amorous.Game.Scenes;

public class ClubLoungeScene : AbstractScene
{
	private ClubStaticDustinNPC _dustin;

	private ClubStaticMercyNPC _mercy;

	private readonly bool _showDustin;

	private readonly bool _showMercy;

	public ClubLoungeScene(IAmorous game)
		: base(game)
	{
		AddTexturedLayer("Background", "Assets/Scenes/ClubLounge/Lounge Main", -1295, 0);
		AddAnimatedLayer("Lights", 638, 0, 500, "Assets/Scenes/ClubLounge/Lights Green Flicker", "Assets/Scenes/ClubLounge/Lights Yellow Flicker");
		AddTexturedLayer("Lights Glow", "Assets/Scenes/ClubLounge/Lights glow", 638, 0);
		AddTexturedLayer("Pole", "Assets/Scenes/ClubLounge/Dance Pole", 1384, -150);
		AddClickableLayer("Elevator", "Assets/Scenes/ClubLounge/Elevator Door Selectable", -958, 0, OnUpstairsClick);
		AddClickableLayer("Stairs", "Assets/Scenes/ClubLounge/Stairs selectable", -242, 0, OnUpstairsClick);
		AddClickableLayer("Door", "Assets/Scenes/ClubLounge/Exit door selectable", 235, 0, OnDoorClick);
		AddAnimatedClickableLayer("Club", 2588, 0, OnClubClick, 1200, "Assets/Scenes/ClubLounge/Main Room Blue", "Assets/Scenes/ClubLounge/Main Room Green");
		AddForegroundTexturedLayer("Couches", "Assets/Scenes/ClubLounge/Foreground couches", -1295, 758);
		Game._vsceSzSIjBy2nZrCxAzKZbUiwLq._wFfc7xL7eKxed7i9gWtao7pgsnm(-1295, 1295, 0, 0);
		_UmxbIbk7pgaod0bD7pS309P3Lns._QrgbXEg7MMeD9Ybz12fFVsbmAd9(_KZ7hNP1K5E99Xfup1lTZ9UDrxPE._oCy13KHJxLHriH7TwMiQ1qKJ8Uc, 0.4f, bool_0: true, bool_1: true);
		PlayerData data = PlayerPreferences.GetPlayerData();
		_showDustin = !data.GetBit("DustinLeftClub");
		_showMercy = !data.GetBit("MercyLeftClub");
		if (_showDustin)
		{
			AddTexturedLayer("Shadow", "Assets/Scenes/ClubLounge/ShadowDustin", -426, 259);
		}
		if (_showMercy)
		{
			AddTexturedLayer("Shadow", "Assets/Scenes/ClubLounge/ShadowMercy", 2333, 448);
		}
	}

	public override void Start()
	{
		ClubLoungeBNPC clubLoungeBNPC = base.Game._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubLoungeBNPC>(LayerOrder.Background);
		clubLoungeBNPC.SetPose(ClubStaticNPC.EPoses.Nude);
		clubLoungeBNPC.SetClothes(ClubStaticNPC.EClothes.Shirt, ClubStaticNPC.EClothes.Pants);
		clubLoungeBNPC.X = 700f;
		clubLoungeBNPC.Y = 275f;
		ClubLoungeCNPC clubLoungeCNPC = base.Game._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubLoungeCNPC>(LayerOrder.Background);
		clubLoungeCNPC.SetPose(ClubStaticNPC.EPoses.Nude);
		clubLoungeCNPC.SetClothes(ClubStaticNPC.EClothes.Shirt, ClubStaticNPC.EClothes.Pants);
		clubLoungeCNPC.X = 1000f;
		clubLoungeCNPC.Y = 275f;
		ClubLoungeEFNPC clubLoungeEFNPC = base.Game._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubLoungeEFNPC>(LayerOrder.Background);
		clubLoungeEFNPC.SetPose(ClubLoungeEFNPC.EPoses.Sitting);
		clubLoungeEFNPC.SetClothes(ClubLoungeEFNPC.EClothes.Shirt, ClubLoungeEFNPC.EClothes.Pants);
		clubLoungeEFNPC.X = 1600f;
		clubLoungeEFNPC.Y = 250f;
		ClubLoungeANPC clubLoungeANPC = base.Game._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubLoungeANPC>(LayerOrder.Foreground);
		clubLoungeANPC.SetPose(ClubStaticNPC.EPoses.Nude);
		clubLoungeANPC.SetClothes(ClubStaticNPC.EClothes.Shirt);
		clubLoungeANPC.X = 40f;
		clubLoungeANPC.Y = 55f;
		clubLoungeANPC._YyDeMNgCbNCOMTBX2QLUb4ruMp9A = false;
		ClubLoungeDancerANPC clubLoungeDancerANPC = base.Game._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubLoungeDancerANPC>(LayerOrder.Foreground);
		clubLoungeDancerANPC.SetEmotion(ClubLoungeDancerANPC.EHeads.Smirk);
		clubLoungeDancerANPC.SetPose(ClubLoungeDancerANPC.EPoses.Dancing);
		clubLoungeDancerANPC.SetClothes(ClubLoungeDancerANPC.EClothes.Shirt, ClubLoungeDancerANPC.EClothes.Shorts);
		clubLoungeDancerANPC.X = 1450f;
		clubLoungeDancerANPC.Y = 1000f;
		if (_showDustin)
		{
			_dustin = base.Game._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubStaticDustinNPC>(LayerOrder.Foreground);
			_dustin.X = -370f;
			_dustin.Y = 246f;
			_dustin.Click = OnDustinClick;
		}
		if (_showMercy)
		{
			_mercy = base.Game._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubStaticMercyNPC>(LayerOrder.Foreground);
			_mercy.X = 2300f;
			_mercy.Y = 225f;
			_mercy.Click = OnMercyClick;
		}
	}

	private void OnDoorClick()
	{
		base.Game.StartScene<ClubBackScene>();
	}

	private void OnUpstairsClick()
	{
		base.Game.StartScene<ClubUpstairsScene>();
	}

	private void OnClubClick()
	{
		base.Game.StartScene<ClubInsideScene>();
	}

	private void OnDustinClick()
	{
		base.Game.RequestScene("DustinDate");
	}

	private void OnMercyClick()
	{
		base.Game.RequestScene("MercyPreDate");
	}
}
