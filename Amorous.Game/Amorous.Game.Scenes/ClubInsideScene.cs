using System;
using Amorous.Game.NPC;

namespace Amorous.Game.Scenes;

public class ClubInsideScene : AbstractScene
{
	private ClubInsideDancerANPC _dancerA;
	private CobyDancingNPC _coby;
	private JaxNPC _jax;
	private BartenderNPC _rou;
	private ClubStaticSkyeNPC _skye;
	private ClubStaticSethNPC _seth;

	private readonly bool _showCoby, _showJax, _showSeth, _showSkye;

	public ClubInsideScene(IAmorous game)
		: base(game)
	{
		AddAnimatedLayer("Background Left", -1770, 0, 1200, "Assets/Scenes/ClubInside/Clubdance_left", "Assets/Scenes/ClubInside/Clubdancegreen_left");
		AddAnimatedLayer("Background Middle", 50, 0, 1200, "Assets/Scenes/ClubInside/Clubdance_mid", "Assets/Scenes/ClubInside/Clubdancegreen_mid");
		AddAnimatedLayer("Background Right", 1870, 0, 1200, "Assets/Scenes/ClubInside/Clubdance_right", "Assets/Scenes/ClubInside/Clubdancegreen_right");
		AddFadingLayer("Floor Left", "Assets/Scenes/ClubInside/dancefloor_left", -1740, 748, 1200);
		AddFadingLayer("Floor Middle", "Assets/Scenes/ClubInside/dancefloor_mid", 54, 736, 1200);
		AddFadingLayer("Floor Right", "Assets/Scenes/ClubInside/dancefloor_right", 1874, 815, 1200);
		AddTexturedLayer("Spotlight Blue", "Assets/Scenes/ClubInside/blue_spotlight", -1454, 75);
		AddTexturedLayer("Spotlight Green", "Assets/Scenes/ClubInside/Green_spotlight", 1078, 75);
		AddTexturedLayer("Spotlight Pink", "Assets/Scenes/ClubInside/pink_spotlight", 1580, 100);
		AddClickableLayer("Entrance", "Assets/Scenes/ClubInside/Entrance Selectable", -1733, 302, OnDoorClick);
		AddClickableLayer("Lounge", "Assets/Scenes/ClubInside/Loungeroom Selectable", 231, 347, OnLoungeClick);
		TexturedLayer bar = AddTexturedLayer("Bar", "Assets/Scenes/ClubInside/Bar", 1162, 541);
		bar.LayerOrder = 1;
		AddForegroundTexturedLayer("Coat check-in", "Assets/Scenes/ClubInside/Service desk coverup", -1234, 516);
		AddForegroundTexturedLayer("DJ", "Assets/Scenes/ClubInside/DJ Booth Coverup", -718, 314);
		AddForegroundTexturedLayer("DJ Screen", "Assets/Scenes/ClubInside/Jumbo screen", -701, 385);
		AddForegroundFadingLayer("Strobe Blue", "Assets/Scenes/ClubInside/blue_strobe", -1425, 100, 1200, 0, 1200);
		AddForegroundFadingLayer("Strobe Green", "Assets/Scenes/ClubInside/green_strobe", 708, 120, 1200, 600, 600);
		AddForegroundFadingLayer("Strobe Pink", "Assets/Scenes/ClubInside/pink_strobe", 48, 130, 1200, 1200);
		Game.Mouse._EPA0ilTeyu3r3U3sXajd13XXT1B(-1770, 1770);
		FadingMediaPlayer.Play(AmorousData.ClubTracks, 0.4f, repeat: true, oneOf: true);
		PlayerData data = PlayerPreferences.GetPlayerData();
		_showCoby = true;
		_showJax = !data.GetFlag(AmorousData.JaxLeftClub);
		_showSeth = !data.GetFlag(AmorousData.SethLeftClub);
		_showSkye = !data.GetFlag(AmorousData.SkyeLeftClub);
		if (data.GetState(AmorousData.SkyeDate) == 20)
		{
			data.SetStage(AmorousData.SkyeDate, 10);
		}
		base.Game.Achievements.GainAchievement(Achievements.AchievementGeneric2);
	}

	public override void Start()
	{
		if (_showJax)
		{
			_jax = base.Game.GetNPCLayerAt<JaxNPC>(LayerOrder.Background);
			_jax.SetEmotion(JaxNPC.EHeads.Happy);
			_jax.SetPose(JaxNPC.EPoses.Chill);
			_jax.SetClothes(JaxNPC.EClothes.TuxChest, JaxNPC.EClothes.TuxUnderwear);
			_jax.X = 1500f;
			_jax.Y = 580f;
			_jax.Scale = 0.2f;
			_jax.Click = OnJaxClick;
			NPCLayer NPCLayer = GetNPCLayer<JaxNPC>();
			NPCLayer.ZOrder = 0;
			NPCLayer.LayerOrder = 0;
		}
		else
		{
			_rou = base.Game.GetNPCLayerAt<BartenderNPC>(LayerOrder.Background);
			_rou.SetEmotion(BartenderNPC.EHeads.None);
			_rou.SetPose(BartenderNPC.EPoses.Standing);
			_rou.SetClothes(BartenderNPC.EClothes.Shirt, BartenderNPC.EClothes.Pants);
			_rou.X = 1450f;
			_rou.Y = 380f;
			_rou.Scale = 0.2f;
			_rou.Click = OnRouClick;
			NPCLayer NPCLayer2 = GetNPCLayer<BartenderNPC>();
			NPCLayer2.ZOrder = 0;
			NPCLayer2.LayerOrder = 0;
		}
		ClubInsideANPC clubInsideANPC = base.Game.GetNPCLayerAt<ClubInsideANPC>(LayerOrder.Background);
		clubInsideANPC.SetPose(ClubStaticNPC.EPoses.Nude);
		clubInsideANPC.SetClothes(ClubStaticNPC.EClothes.Pants, ClubStaticNPC.EClothes.Shirt);
		clubInsideANPC.X = -1700f;
		clubInsideANPC.Y = 320f;
		ClubInsideBNPC clubInsideBNPC = base.Game.GetNPCLayerAt<ClubInsideBNPC>(LayerOrder.Background);
		clubInsideBNPC.SetPose(ClubStaticNPC.EPoses.Nude);
		clubInsideBNPC.SetClothes(ClubStaticNPC.EClothes.Pants, ClubStaticNPC.EClothes.Shirt);
		clubInsideBNPC.X = -1480f;
		clubInsideBNPC.Y = 320f;
		ClubInsideCNPC clubInsideCNPC = base.Game.GetNPCLayerAt<ClubInsideCNPC>(LayerOrder.Background);
		clubInsideCNPC.SetPose(ClubStaticNPC.EPoses.Nude);
		clubInsideCNPC.SetClothes(ClubStaticNPC.EClothes.Pants, ClubStaticNPC.EClothes.Shirt);
		clubInsideCNPC.X = -1230f;
		clubInsideCNPC.Y = 360f;
		ClubInsideDNPC clubInsideDNPC = base.Game.GetNPCLayerAt<ClubInsideDNPC>(LayerOrder.Background);
		clubInsideDNPC.SetPose(ClubStaticNPC.EPoses.Nude);
		clubInsideDNPC.SetClothes(ClubStaticNPC.EClothes.Pants, ClubStaticNPC.EClothes.Shirt);
		clubInsideDNPC.X = 950f;
		clubInsideDNPC.Y = 500f;
		ClubInsideENPC clubInsideENPC = base.Game.GetNPCLayerAt<ClubInsideENPC>(LayerOrder.Background);
		clubInsideENPC.SetPose(ClubStaticNPC.EPoses.Nude);
		clubInsideENPC.SetClothes(ClubStaticNPC.EClothes.Pants, ClubStaticNPC.EClothes.Shirt);
		clubInsideENPC.X = 1150f;
		clubInsideENPC.Y = 420f;
		NPCLayer NPCLayer3 = GetNPCLayer<ClubInsideENPC>();
		NPCLayer3.LayerOrder = 2;
		ClubInsideFNPC clubInsideFNPC = base.Game.GetNPCLayerAt<ClubInsideFNPC>(LayerOrder.Background);
		clubInsideFNPC.SetPose(ClubStaticNPC.EPoses.Nude);
		clubInsideFNPC.SetClothes(ClubStaticNPC.EClothes.Pants, ClubStaticNPC.EClothes.Shirt);
		clubInsideFNPC.X = 3275f;
		clubInsideFNPC.Y = 360f;
		ClubInsideGNPC clubInsideGNPC = base.Game.GetNPCLayerAt<ClubInsideGNPC>(LayerOrder.Background);
		clubInsideGNPC.SetPose(ClubStaticNPC.EPoses.Nude);
		clubInsideGNPC.SetClothes(ClubStaticNPC.EClothes.Pants, ClubStaticNPC.EClothes.Shirt);
		clubInsideGNPC.X = 3400f;
		clubInsideGNPC.Y = 340f;
		ClubDJNPC clubDJNPC = base.Game.GetNPCLayerAt<ClubDJNPC>(LayerOrder.Background);
		clubDJNPC.SetEmotion(ClubDJNPC.EHeads.Smirk);
		clubDJNPC.SetPose(ClubDJNPC.EPoses.Dancing);
		clubDJNPC.SetClothes(ClubDJNPC.EClothes.Shirt, ClubDJNPC.EClothes.Pants);
		clubDJNPC.X = -400f;
		clubDJNPC.Y = 500f;
		clubDJNPC.LockedInLayer = true;
		clubDJNPC.Click = OnDJClick;
		_dancerA = base.Game.GetNPCLayerAt<ClubInsideDancerANPC>(LayerOrder.Foreground);
		_dancerA.SetEmotion(ClubInsideDancerANPC.EHeads.Happy);
		_dancerA.SetPose(ClubInsideDancerANPC.EPoses.Dancing);
		_dancerA.SetClothes(ClubInsideDancerANPC.EClothes.Pants, ClubInsideDancerANPC.EClothes.Shirt);
		_dancerA.X = -900f;
		_dancerA.Y = 950f;
		_dancerA._KDimeEJ9On2dWcynEqeEZz9c8DE(4, 3);
		if (_showCoby)
		{
			_coby = base.Game.GetNPCLayerAt<CobyDancingNPC>(LayerOrder.Foreground);
			_coby.SetEmotion(CobyDancingNPC.EHeads.Happy);
			_coby.SetPose(CobyDancingNPC.EPoses.Dancing);
			_coby.SetClothes(CobyDancingNPC.EClothes.Shirt, CobyDancingNPC.EClothes.Shorts, CobyDancingNPC.EClothes.Sleeves);
			_coby.X = -400f;
			_coby.Y = 1000f;
			_coby.Click = OnCobyClick;
		}
		ClubInsideDancerCNPC clubInsideDancerCNPC = base.Game.GetNPCLayerAt<ClubInsideDancerCNPC>(LayerOrder.Foreground);
		clubInsideDancerCNPC.SetEmotion(ClubInsideDancerCNPC.EHeads.Smirk);
		clubInsideDancerCNPC.SetPose(ClubInsideDancerCNPC.EPoses.Dancing);
		clubInsideDancerCNPC.SetClothes(ClubInsideDancerCNPC.EClothes.Shorts);
		clubInsideDancerCNPC.X = 50f;
		clubInsideDancerCNPC.Y = 910f;
		ClubInsideDancerBNPC clubInsideDancerBNPC = base.Game.GetNPCLayerAt<ClubInsideDancerBNPC>(LayerOrder.Foreground);
		clubInsideDancerBNPC.SetEmotion(ClubInsideDancerBNPC.EHeads.Happy);
		clubInsideDancerBNPC.SetPose(ClubInsideDancerBNPC.EPoses.Dancing);
		clubInsideDancerBNPC.SetClothes(ClubInsideDancerBNPC.EClothes.Skirt, ClubInsideDancerBNPC.EClothes.Shirt);
		clubInsideDancerBNPC.X = 50f;
		clubInsideDancerBNPC.Y = 910f;
		ClubInsideDancerDNPC clubInsideDancerDNPC = base.Game.GetNPCLayerAt<ClubInsideDancerDNPC>(LayerOrder.Foreground);
		clubInsideDancerDNPC.SetEmotion(ClubInsideDancerDNPC.EHeads.Smirk);
		clubInsideDancerDNPC.SetPose(ClubInsideDancerDNPC.EPoses.Dancing);
		clubInsideDancerDNPC.SetClothes(ClubInsideDancerDNPC.EClothes.Shirt, ClubInsideDancerDNPC.EClothes.Pants);
		clubInsideDancerDNPC.X = 700f;
		clubInsideDancerDNPC.Y = 960f;
		if (_showSeth)
		{
			_seth = base.Game.GetNPCLayerAt<ClubStaticSethNPC>(LayerOrder.Foreground);
			_seth.X = 1612f;
			_seth.Y = 420f;
			_seth.Click = OnSethClick;
		}
		if (_showSkye)
		{
			_skye = base.Game.GetNPCLayerAt<ClubStaticSkyeNPC>(LayerOrder.Background);
			_skye.X = 2212f;
			_skye.Y = 438f;
			_skye.Click = OnSkyeClick;
			NPCLayer NPCLayer4 = GetNPCLayer<ClubStaticSkyeNPC>();
			NPCLayer4.LayerOrder = 1;
		}
		RefreshLayerOrdering();
	}

	private void OnDoorClick()
	{
		base.Game.StartScene<ClubEntranceScene>();
	}

	private void OnLoungeClick()
	{
		base.Game.StartScene<ClubLoungeScene>();
	}

	private void OnJaxClick()
	{
		base.Game.StartCutscene(AmorousData.JaxPreDate);
	}

	private void OnRouClick()
	{
		base.Game.StartCutscene(AmorousData.Rou);
	}

	private void OnSethClick()
	{
		base.Game.StartCutscene(AmorousData.SethPreDate);
	}

	private void OnSkyeClick()
	{
		base.Game.StartCutscene(AmorousData.SkyePreDate);
	}

	private void OnCobyClick()
	{
		PlayerData data = PlayerPreferences.GetPlayerData();
		if (data.GetState(AmorousData.Prologue) >= AmorousData.PrologueStateCompleted)
		{
			base.Game.StartCutscene(AmorousData.CobyClub);
		}
		else
		{
			base.Game.StartCutscene(AmorousData.Prologue);
		}
	}

	private void OnDJClick()
	{
		base.Game.StartCutscene(AmorousData.DJ);
	}
}
