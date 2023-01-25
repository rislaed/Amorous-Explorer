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

	private readonly bool _showCoby;

	private readonly bool _showJax;

	private readonly bool _showSeth;

	private readonly bool _showSkye;

	public ClubInsideScene(IAmorous game)
		: base(Game)
	{
		_qCH6LFVbWcTfZTRElH4N91FiGeM("Background Left", -1770, 0, 1200, "Assets/Scenes/ClubInside/Clubdance_left", "Assets/Scenes/ClubInside/Clubdancegreen_left");
		_qCH6LFVbWcTfZTRElH4N91FiGeM("Background Middle", 50, 0, 1200, "Assets/Scenes/ClubInside/Clubdance_mid", "Assets/Scenes/ClubInside/Clubdancegreen_mid");
		_qCH6LFVbWcTfZTRElH4N91FiGeM("Background Right", 1870, 0, 1200, "Assets/Scenes/ClubInside/Clubdance_right", "Assets/Scenes/ClubInside/Clubdancegreen_right");
		_0smWNvs61rH3hoJEMYp9eRPrLge("Floor Left", "Assets/Scenes/ClubInside/dancefloor_left", -1740, 748, 1200);
		_0smWNvs61rH3hoJEMYp9eRPrLge("Floor Middle", "Assets/Scenes/ClubInside/dancefloor_mid", 54, 736, 1200);
		_0smWNvs61rH3hoJEMYp9eRPrLge("Floor Right", "Assets/Scenes/ClubInside/dancefloor_right", 1874, 815, 1200);
		_0O8D0mBgmrh0sLOGcLVvGNOHKLCA("Spotlight Blue", "Assets/Scenes/ClubInside/blue_spotlight", -1454, 75);
		_0O8D0mBgmrh0sLOGcLVvGNOHKLCA("Spotlight Green", "Assets/Scenes/ClubInside/Green_spotlight", 1078, 75);
		_0O8D0mBgmrh0sLOGcLVvGNOHKLCA("Spotlight Pink", "Assets/Scenes/ClubInside/pink_spotlight", 1580, 100);
		_2CHUZ5vSi5NbJYJ4gGtr3C2VVEo("Entrance", "Assets/Scenes/ClubInside/Entrance Selectable", -1733, 302, OnDoorClick);
		_2CHUZ5vSi5NbJYJ4gGtr3C2VVEo("Lounge", "Assets/Scenes/ClubInside/Loungeroom Selectable", 231, 347, OnLoungeClick);
		_uqydQVaCmCvK7zzWs5W4gZFpKBu uqydQVaCmCvK7zzWs5W4gZFpKBu = _0O8D0mBgmrh0sLOGcLVvGNOHKLCA("Bar", "Assets/Scenes/ClubInside/Bar", 1162, 541);
		uqydQVaCmCvK7zzWs5W4gZFpKBu.LayerOrder = 1;
		_NC5VT77x8y2iH2pW56TBN1eyomA("Coat check-in", "Assets/Scenes/ClubInside/Service desk coverup", -1234, 516);
		_NC5VT77x8y2iH2pW56TBN1eyomA("DJ", "Assets/Scenes/ClubInside/DJ Booth Coverup", -718, 314);
		_NC5VT77x8y2iH2pW56TBN1eyomA("DJ Screen", "Assets/Scenes/ClubInside/Jumbo screen", -701, 385);
		_Gwla9fGwcaH1uD03fvVNW68BhdH("Strobe Blue", "Assets/Scenes/ClubInside/blue_strobe", -1425, 100, 1200, 0, 1200);
		_Gwla9fGwcaH1uD03fvVNW68BhdH("Strobe Green", "Assets/Scenes/ClubInside/green_strobe", 708, 120, 1200, 600, 600);
		_Gwla9fGwcaH1uD03fvVNW68BhdH("Strobe Pink", "Assets/Scenes/ClubInside/pink_strobe", 48, 130, 1200, 1200);
		Game._vsceSzSIjBy2nZrCxAzKZbUiwLq._EPA0ilTeyu3r3U3sXajd13XXT1B(-1770, 1770);
		_UmxbIbk7pgaod0bD7pS309P3Lns._QrgbXEg7MMeD9Ybz12fFVsbmAd9(_KZ7hNP1K5E99Xfup1lTZ9UDrxPE._oCy13KHJxLHriH7TwMiQ1qKJ8Uc, 0.4f, bool_0: true, bool_1: true);
		PlayerData opIJo2jLUqdOL5yAFP4yzXce0DG = _Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t();
		_showCoby = true;
		_showJax = !opIJo2jLUqdOL5yAFP4yzXce0DG.GetBit("JaxLeftClub");
		_showSeth = !opIJo2jLUqdOL5yAFP4yzXce0DG.GetBit("SethLeftClub");
		_showSkye = !opIJo2jLUqdOL5yAFP4yzXce0DG.GetBit("SkyeLeftClub");
		if (opIJo2jLUqdOL5yAFP4yzXce0DG.GetDecimal("SkyeDate") == 20)
		{
			opIJo2jLUqdOL5yAFP4yzXce0DG.SetDecimal("SkyeDate", 10);
		}
		base.Game._aJh9CibG5YKhkExxgRyVopdfSeJ._vVZVLriSGPExpn1KeobglMabsoi("AchievementGeneric2");
	}

	public override void Start()
	{
		if (_showJax)
		{
			_jax = base.Game._TwQHHdbdRFRy2ctTZabNfz1Htrg<JaxNPC>(LayerOrder.Background);
			_jax._g3oEqGBkN3YHUPosRq2nIP2sX0D(JaxNPC.EHeads.Happy);
			_jax._tDFvus0ZCanjp81eOiDzoMXJiuf(JaxNPC.EPoses.Chill);
			_jax._09vxUzgOn7J7DFZEwsTh7lgEIhB(JaxNPC.EClothes.TuxChest, JaxNPC.EClothes.TuxUnderwear);
			_jax._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EX = 1500f;
			_jax._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EY = 580f;
			_jax._fO7gSlrDDNMoHR4FO5QXAq8fUyA = 0.2f;
			_jax._ZVpZ5Oing5kbbVhbmbOHyrofGH7 = OnJaxClick;
			_3IHp43rpkJgOBcY9lrIrwMuwWve _3IHp43rpkJgOBcY9lrIrwMuwWve = _VvFE2zgy4FbDjvaEvb67tXJ7aRm<JaxNPC>();
			_3IHp43rpkJgOBcY9lrIrwMuwWve._ac2H6kMdrgPhXXxabsikjji4SiT = 0;
			_3IHp43rpkJgOBcY9lrIrwMuwWve.LayerOrder = 0;
		}
		else
		{
			_rou = base.Game._TwQHHdbdRFRy2ctTZabNfz1Htrg<BartenderNPC>(LayerOrder.Background);
			_rou._g3oEqGBkN3YHUPosRq2nIP2sX0D(BartenderNPC.EHeads.None);
			_rou._tDFvus0ZCanjp81eOiDzoMXJiuf(BartenderNPC.EPoses.Standing);
			_rou._09vxUzgOn7J7DFZEwsTh7lgEIhB(BartenderNPC.EClothes.Shirt, BartenderNPC.EClothes.Pants);
			_rou._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EX = 1450f;
			_rou._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EY = 380f;
			_rou._fO7gSlrDDNMoHR4FO5QXAq8fUyA = 0.2f;
			_rou._ZVpZ5Oing5kbbVhbmbOHyrofGH7 = OnRouClick;
			_3IHp43rpkJgOBcY9lrIrwMuwWve _3IHp43rpkJgOBcY9lrIrwMuwWve2 = _VvFE2zgy4FbDjvaEvb67tXJ7aRm<BartenderNPC>();
			_3IHp43rpkJgOBcY9lrIrwMuwWve2._ac2H6kMdrgPhXXxabsikjji4SiT = 0;
			_3IHp43rpkJgOBcY9lrIrwMuwWve2.LayerOrder = 0;
		}
		ClubInsideANPC clubInsideANPC = base.Game._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubInsideANPC>(LayerOrder.Background);
		clubInsideANPC._tDFvus0ZCanjp81eOiDzoMXJiuf(ClubStaticNPC.EPoses.Nude);
		clubInsideANPC._09vxUzgOn7J7DFZEwsTh7lgEIhB(ClubStaticNPC.EClothes.Pants, ClubStaticNPC.EClothes.Shirt);
		clubInsideANPC._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EX = -1700f;
		clubInsideANPC._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EY = 320f;
		ClubInsideBNPC clubInsideBNPC = base.Game._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubInsideBNPC>(LayerOrder.Background);
		clubInsideBNPC._tDFvus0ZCanjp81eOiDzoMXJiuf(ClubStaticNPC.EPoses.Nude);
		clubInsideBNPC._09vxUzgOn7J7DFZEwsTh7lgEIhB(ClubStaticNPC.EClothes.Pants, ClubStaticNPC.EClothes.Shirt);
		clubInsideBNPC._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EX = -1480f;
		clubInsideBNPC._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EY = 320f;
		ClubInsideCNPC clubInsideCNPC = base.Game._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubInsideCNPC>(LayerOrder.Background);
		clubInsideCNPC._tDFvus0ZCanjp81eOiDzoMXJiuf(ClubStaticNPC.EPoses.Nude);
		clubInsideCNPC._09vxUzgOn7J7DFZEwsTh7lgEIhB(ClubStaticNPC.EClothes.Pants, ClubStaticNPC.EClothes.Shirt);
		clubInsideCNPC._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EX = -1230f;
		clubInsideCNPC._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EY = 360f;
		ClubInsideDNPC clubInsideDNPC = base.Game._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubInsideDNPC>(LayerOrder.Background);
		clubInsideDNPC._tDFvus0ZCanjp81eOiDzoMXJiuf(ClubStaticNPC.EPoses.Nude);
		clubInsideDNPC._09vxUzgOn7J7DFZEwsTh7lgEIhB(ClubStaticNPC.EClothes.Pants, ClubStaticNPC.EClothes.Shirt);
		clubInsideDNPC._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EX = 950f;
		clubInsideDNPC._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EY = 500f;
		ClubInsideENPC clubInsideENPC = base.Game._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubInsideENPC>(LayerOrder.Background);
		clubInsideENPC._tDFvus0ZCanjp81eOiDzoMXJiuf(ClubStaticNPC.EPoses.Nude);
		clubInsideENPC._09vxUzgOn7J7DFZEwsTh7lgEIhB(ClubStaticNPC.EClothes.Pants, ClubStaticNPC.EClothes.Shirt);
		clubInsideENPC._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EX = 1150f;
		clubInsideENPC._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EY = 420f;
		_3IHp43rpkJgOBcY9lrIrwMuwWve _3IHp43rpkJgOBcY9lrIrwMuwWve3 = _VvFE2zgy4FbDjvaEvb67tXJ7aRm<ClubInsideENPC>();
		_3IHp43rpkJgOBcY9lrIrwMuwWve3.LayerOrder = 2;
		ClubInsideFNPC clubInsideFNPC = base.Game._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubInsideFNPC>(LayerOrder.Background);
		clubInsideFNPC._tDFvus0ZCanjp81eOiDzoMXJiuf(ClubStaticNPC.EPoses.Nude);
		clubInsideFNPC._09vxUzgOn7J7DFZEwsTh7lgEIhB(ClubStaticNPC.EClothes.Pants, ClubStaticNPC.EClothes.Shirt);
		clubInsideFNPC._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EX = 3275f;
		clubInsideFNPC._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EY = 360f;
		ClubInsideGNPC clubInsideGNPC = base.Game._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubInsideGNPC>(LayerOrder.Background);
		clubInsideGNPC._tDFvus0ZCanjp81eOiDzoMXJiuf(ClubStaticNPC.EPoses.Nude);
		clubInsideGNPC._09vxUzgOn7J7DFZEwsTh7lgEIhB(ClubStaticNPC.EClothes.Pants, ClubStaticNPC.EClothes.Shirt);
		clubInsideGNPC._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EX = 3400f;
		clubInsideGNPC._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EY = 340f;
		ClubDJNPC clubDJNPC = base.Game._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubDJNPC>(LayerOrder.Background);
		clubDJNPC._g3oEqGBkN3YHUPosRq2nIP2sX0D(ClubDJNPC.EHeads.Smirk);
		clubDJNPC._tDFvus0ZCanjp81eOiDzoMXJiuf(ClubDJNPC.EPoses.Dancing);
		clubDJNPC._09vxUzgOn7J7DFZEwsTh7lgEIhB(ClubDJNPC.EClothes.Shirt, ClubDJNPC.EClothes.Pants);
		clubDJNPC._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EX = -400f;
		clubDJNPC._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EY = 500f;
		clubDJNPC._SC7QlorMIWTLSkD757wC7ybszpE = true;
		clubDJNPC._ZVpZ5Oing5kbbVhbmbOHyrofGH7 = OnDJClick;
		_dancerA = base.Game._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubInsideDancerANPC>(LayerOrder.Foreground);
		_dancerA._g3oEqGBkN3YHUPosRq2nIP2sX0D(ClubInsideDancerANPC.EHeads.Happy);
		_dancerA._tDFvus0ZCanjp81eOiDzoMXJiuf(ClubInsideDancerANPC.EPoses.Dancing);
		_dancerA._09vxUzgOn7J7DFZEwsTh7lgEIhB(ClubInsideDancerANPC.EClothes.Pants, ClubInsideDancerANPC.EClothes.Shirt);
		_dancerA._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EX = -900f;
		_dancerA._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EY = 950f;
		_dancerA._KDimeEJ9On2dWcynEqeEZz9c8DE(4, 3);
		if (_showCoby)
		{
			_coby = base.Game._TwQHHdbdRFRy2ctTZabNfz1Htrg<CobyDancingNPC>(LayerOrder.Foreground);
			_coby._g3oEqGBkN3YHUPosRq2nIP2sX0D(CobyDancingNPC.EHeads.Happy);
			_coby._tDFvus0ZCanjp81eOiDzoMXJiuf(CobyDancingNPC.EPoses.Dancing);
			_coby._09vxUzgOn7J7DFZEwsTh7lgEIhB(CobyDancingNPC.EClothes.Shirt, CobyDancingNPC.EClothes.Shorts, CobyDancingNPC.EClothes.Sleeves);
			_coby._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EX = -400f;
			_coby._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EY = 1000f;
			_coby._ZVpZ5Oing5kbbVhbmbOHyrofGH7 = OnCobyClick;
		}
		ClubInsideDancerCNPC clubInsideDancerCNPC = base.Game._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubInsideDancerCNPC>(LayerOrder.Foreground);
		clubInsideDancerCNPC._g3oEqGBkN3YHUPosRq2nIP2sX0D(ClubInsideDancerCNPC.EHeads.Smirk);
		clubInsideDancerCNPC._tDFvus0ZCanjp81eOiDzoMXJiuf(ClubInsideDancerCNPC.EPoses.Dancing);
		clubInsideDancerCNPC._09vxUzgOn7J7DFZEwsTh7lgEIhB(ClubInsideDancerCNPC.EClothes.Shorts);
		clubInsideDancerCNPC._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EX = 50f;
		clubInsideDancerCNPC._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EY = 910f;
		ClubInsideDancerBNPC clubInsideDancerBNPC = base.Game._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubInsideDancerBNPC>(LayerOrder.Foreground);
		clubInsideDancerBNPC._g3oEqGBkN3YHUPosRq2nIP2sX0D(ClubInsideDancerBNPC.EHeads.Happy);
		clubInsideDancerBNPC._tDFvus0ZCanjp81eOiDzoMXJiuf(ClubInsideDancerBNPC.EPoses.Dancing);
		clubInsideDancerBNPC._09vxUzgOn7J7DFZEwsTh7lgEIhB(ClubInsideDancerBNPC.EClothes.Skirt, ClubInsideDancerBNPC.EClothes.Shirt);
		clubInsideDancerBNPC._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EX = 50f;
		clubInsideDancerBNPC._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EY = 910f;
		ClubInsideDancerDNPC clubInsideDancerDNPC = base.Game._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubInsideDancerDNPC>(LayerOrder.Foreground);
		clubInsideDancerDNPC._g3oEqGBkN3YHUPosRq2nIP2sX0D(ClubInsideDancerDNPC.EHeads.Smirk);
		clubInsideDancerDNPC._tDFvus0ZCanjp81eOiDzoMXJiuf(ClubInsideDancerDNPC.EPoses.Dancing);
		clubInsideDancerDNPC._09vxUzgOn7J7DFZEwsTh7lgEIhB(ClubInsideDancerDNPC.EClothes.Shirt, ClubInsideDancerDNPC.EClothes.Pants);
		clubInsideDancerDNPC._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EX = 700f;
		clubInsideDancerDNPC._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EY = 960f;
		if (_showSeth)
		{
			_seth = base.Game._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubStaticSethNPC>(LayerOrder.Foreground);
			_seth._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EX = 1612f;
			_seth._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EY = 420f;
			_seth._ZVpZ5Oing5kbbVhbmbOHyrofGH7 = OnSethClick;
		}
		if (_showSkye)
		{
			_skye = base.Game._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubStaticSkyeNPC>(LayerOrder.Background);
			_skye._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EX = 2212f;
			_skye._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EY = 438f;
			_skye._ZVpZ5Oing5kbbVhbmbOHyrofGH7 = OnSkyeClick;
			_3IHp43rpkJgOBcY9lrIrwMuwWve _3IHp43rpkJgOBcY9lrIrwMuwWve4 = _VvFE2zgy4FbDjvaEvb67tXJ7aRm<ClubStaticSkyeNPC>();
			_3IHp43rpkJgOBcY9lrIrwMuwWve4.LayerOrder = 1;
		}
		_yMMFQ2n4dqXlB1AEzmdkoKkPkX5();
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
		base.Game.RequestScene("JaxPreDate");
	}

	private void OnRouClick()
	{
		base.Game.RequestScene("Rou");
	}

	private void OnSethClick()
	{
		base.Game.RequestScene("SethPreDate");
	}

	private void OnSkyeClick()
	{
		base.Game.RequestScene("SkyePreDate");
	}

	private void OnCobyClick()
	{
		PlayerData opIJo2jLUqdOL5yAFP4yzXce0DG = _Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t();
		if (opIJo2jLUqdOL5yAFP4yzXce0DG.GetDecimal("Prologue") >= 40)
		{
			base.Game.RequestScene("CobyClub");
		}
		else
		{
			base.Game.RequestScene("Prologue");
		}
	}

	private void OnDJClick()
	{
		base.Game.RequestScene("DJ");
	}
}
