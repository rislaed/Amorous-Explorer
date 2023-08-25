using Amorous.Game.NPC;

namespace Amorous.Game.Scenes;

public class ClubInsideScene : AbstractScene
{
	private ClubInsideDancerANPC dancerA;
	private CobyDancingNPC coby;
	private JaxNPC jax;
	private BartenderNPC rou;
	private ClubStaticSkyeNPC skye;
	private ClubStaticSethNPC seth;

	private readonly bool showCoby, showJax, showSeth, showSkye;

	public ClubInsideScene(IAmorous game) : base(game)
	{
		AddAnimatedLayer("Background Left", -1770, 0, 1200, "Assets/Scenes/ClubInside/Clubdance_left", "Assets/Scenes/ClubInside/Clubdancegreen_left");
		AddAnimatedLayer("Background Middle", 50, 0, 1200, "Assets/Scenes/ClubInside/Clubdance_mid", "Assets/Scenes/ClubInside/Clubdancegreen_mid");
		AddAnimatedLayer("Background Right", 1870, 0, 1200, "Assets/Scenes/ClubInside/Clubdance_right", "Assets/Scenes/ClubInside/Clubdancegreen_right");
		AddFadingLayer("Floor Left", "Assets/Scenes/ClubInside/dancefloor_left", -1740, 748, 1200);
		AddFadingLayer("Floor Middle", "Assets/Scenes/ClubInside/dancefloor_mid", 54, 736, 1200);
		AddFadingLayer("Floor Right", "Assets/Scenes/ClubInside/dancefloor_right", 1874, 815, 1200);
		AddSpriteLayer("Spotlight Blue", "Assets/Scenes/ClubInside/blue_spotlight", -1454, 75);
		AddSpriteLayer("Spotlight Green", "Assets/Scenes/ClubInside/Green_spotlight", 1078, 75);
		AddSpriteLayer("Spotlight Pink", "Assets/Scenes/ClubInside/pink_spotlight", 1580, 100);
		AddClickableLayer("Entrance", "Assets/Scenes/ClubInside/Entrance Selectable", -1733, 302, OnDoorClick);
		AddClickableLayer("Lounge", "Assets/Scenes/ClubInside/Loungeroom Selectable", 231, 347, OnLoungeClick);
		SpriteLayer bar = AddSpriteLayer("Bar", "Assets/Scenes/ClubInside/Bar", 1162, 541);
		bar.LayerOrder = 1;
		AddSpriteLayerAbove("Coat check-in", "Assets/Scenes/ClubInside/Service desk coverup", -1234, 516);
		AddSpriteLayerAbove("DJ", "Assets/Scenes/ClubInside/DJ Booth Coverup", -718, 314);
		AddSpriteLayerAbove("DJ Screen", "Assets/Scenes/ClubInside/Jumbo screen", -701, 385);
		AddFadingLayerAbove("Strobe Blue", "Assets/Scenes/ClubInside/blue_strobe", -1425, 100, 1200, 0, 1200);
		AddFadingLayerAbove("Strobe Green", "Assets/Scenes/ClubInside/green_strobe", 708, 120, 1200, 600, 600);
		AddFadingLayerAbove("Strobe Pink", "Assets/Scenes/ClubInside/pink_strobe", 48, 130, 1200, 1200);
		Game.Canvas.SetCyclingOverscroll(-1770, 1770);
		FadingMediaPlayer.Play(AmorousData.ClubTracks, 0.4f, repeat: true, oneOf: true);
		PlayerData data = PlayerPreferences.GetPlayerData();
		showCoby = true;
		showJax = !data.HasFlag(AmorousData.JaxLeftClub);
		showSeth = !data.HasFlag(AmorousData.SethLeftClub);
		showSkye = !data.HasFlag(AmorousData.SkyeLeftClub);
		if (data.GetStage(AmorousData.SkyeDate) == 20)
		{
			data.InsertStage(AmorousData.SkyeDate, 10);
		}
		base.Game.Achievements.TriggerAchievement(Achievements.AchievementGeneric2);
	}

	public override void Start()
	{
		if (showJax)
		{
			jax = base.Game.GetNPCLayerAt<JaxNPC>(LayerOrder.Background);
			jax.SetEmotion(JaxNPC.EHeads.Happy);
			jax.SetPose(JaxNPC.EPoses.Chill);
			jax.SetClothes(JaxNPC.EClothes.TuxChest, JaxNPC.EClothes.TuxUnderwear);
			jax.X = 1500f;
			jax.Y = 580f;
			jax.Scale = 0.2f;
			jax.Click = OnJaxClick;
			NPCLayer layer = GetNPCLayer<JaxNPC>();
			layer.ZOrder = 0;
			layer.LayerOrder = 0;
		}
		else
		{
			rou = base.Game.GetNPCLayerAt<BartenderNPC>(LayerOrder.Background);
			rou.SetEmotion(BartenderNPC.EHeads.None);
			rou.SetPose(BartenderNPC.EPoses.Standing);
			rou.SetClothes(BartenderNPC.EClothes.Shirt, BartenderNPC.EClothes.Pants);
			rou.X = 1450f;
			rou.Y = 380f;
			rou.Scale = 0.2f;
			rou.Click = OnRouClick;
			NPCLayer layer = GetNPCLayer<BartenderNPC>();
			layer.ZOrder = 0;
			layer.LayerOrder = 0;
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
		GetNPCLayer<ClubInsideENPC>().LayerOrder = 2;
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
		clubDJNPC.IsFixedOrder = true;
		clubDJNPC.Click = OnDJClick;
		dancerA = base.Game.GetNPCLayerAt<ClubInsideDancerANPC>(LayerOrder.Foreground);
		dancerA.SetEmotion(ClubInsideDancerANPC.EHeads.Happy);
		dancerA.SetPose(ClubInsideDancerANPC.EPoses.Dancing);
		dancerA.SetClothes(ClubInsideDancerANPC.EClothes.Pants, ClubInsideDancerANPC.EClothes.Shirt);
		dancerA.X = -900f;
		dancerA.Y = 950f;
		dancerA.SetDanceScheme(4, 3);
		if (showCoby)
		{
			coby = base.Game.GetNPCLayerAt<CobyDancingNPC>(LayerOrder.Foreground);
			coby.SetEmotion(CobyDancingNPC.EHeads.Happy);
			coby.SetPose(CobyDancingNPC.EPoses.Dancing);
			coby.SetClothes(CobyDancingNPC.EClothes.Shirt, CobyDancingNPC.EClothes.Shorts, CobyDancingNPC.EClothes.Sleeves);
			coby.X = -400f;
			coby.Y = 1000f;
			coby.Click = OnCobyClick;
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
		if (showSeth)
		{
			seth = base.Game.GetNPCLayerAt<ClubStaticSethNPC>(LayerOrder.Foreground);
			seth.X = 1612f;
			seth.Y = 420f;
			seth.Click = OnSethClick;
		}
		if (showSkye)
		{
			skye = base.Game.GetNPCLayerAt<ClubStaticSkyeNPC>(LayerOrder.Background);
			skye.X = 2212f;
			skye.Y = 438f;
			skye.Click = OnSkyeClick;
			GetNPCLayer<ClubStaticSkyeNPC>().LayerOrder = 1;
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
		base.Game.PlayCutscene(AmorousData.JaxPreDate);
	}

	private void OnRouClick()
	{
		base.Game.PlayCutscene(AmorousData.Rou);
	}

	private void OnSethClick()
	{
		base.Game.PlayCutscene(AmorousData.SethPreDate);
	}

	private void OnSkyeClick()
	{
		base.Game.PlayCutscene(AmorousData.SkyePreDate);
	}

	private void OnCobyClick()
	{
		PlayerData data = PlayerPreferences.GetPlayerData();
		if (data.GetStage(AmorousData.Prologue) >= AmorousData.PrologueStateCompleted)
		{
			base.Game.PlayCutscene(AmorousData.CobyClub);
		}
		else
		{
			base.Game.PlayCutscene(AmorousData.Prologue);
		}
	}

	private void OnDJClick()
	{
		base.Game.PlayCutscene(AmorousData.DJ);
	}
}
