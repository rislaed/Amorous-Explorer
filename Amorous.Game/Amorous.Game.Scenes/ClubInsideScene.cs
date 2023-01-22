using System;
using Amorous.Game.NPC;

namespace Amorous.Game.Scenes;

public class ClubInsideScene : _7UlnfykmEmZDFt3BmCKZekI43Ih
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

	public ClubInsideScene(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		ClubInsideScene.smethod_14((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Background Left", -1770, 0, 1200, new string[2] { "Assets/Scenes/ClubInside/Clubdance_left", "Assets/Scenes/ClubInside/Clubdancegreen_left" });
		ClubInsideScene.smethod_14((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Background Middle", 50, 0, 1200, new string[2] { "Assets/Scenes/ClubInside/Clubdance_mid", "Assets/Scenes/ClubInside/Clubdancegreen_mid" });
		ClubInsideScene.smethod_14((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Background Right", 1870, 0, 1200, new string[2] { "Assets/Scenes/ClubInside/Clubdance_right", "Assets/Scenes/ClubInside/Clubdancegreen_right" });
		ClubInsideScene.smethod_15((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Floor Left", "Assets/Scenes/ClubInside/dancefloor_left", -1740, 748, 1200, 0, 0);
		ClubInsideScene.smethod_15((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Floor Middle", "Assets/Scenes/ClubInside/dancefloor_mid", 54, 736, 1200, 0, 0);
		ClubInsideScene.smethod_15((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Floor Right", "Assets/Scenes/ClubInside/dancefloor_right", 1874, 815, 1200, 0, 0);
		ClubInsideScene.smethod_16((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Spotlight Blue", "Assets/Scenes/ClubInside/blue_spotlight", -1454, 75);
		ClubInsideScene.smethod_16((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Spotlight Green", "Assets/Scenes/ClubInside/Green_spotlight", 1078, 75);
		ClubInsideScene.smethod_16((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Spotlight Pink", "Assets/Scenes/ClubInside/pink_spotlight", 1580, 100);
		ClubInsideScene.smethod_17((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Entrance", "Assets/Scenes/ClubInside/Entrance Selectable", -1733, 302, (Action)OnDoorClick);
		ClubInsideScene.smethod_17((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Lounge", "Assets/Scenes/ClubInside/Loungeroom Selectable", 231, 347, (Action)OnLoungeClick);
		_uqydQVaCmCvK7zzWs5W4gZFpKBu uqydQVaCmCvK7zzWs5W4gZFpKBu = ClubInsideScene.smethod_16((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Bar", "Assets/Scenes/ClubInside/Bar", 1162, 541);
		uqydQVaCmCvK7zzWs5W4gZFpKBu._VNgmwYSLsJyyiR6cPQ35UHJBR4d = 1;
		ClubInsideScene.smethod_18((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Coat check-in", "Assets/Scenes/ClubInside/Service desk coverup", -1234, 516);
		ClubInsideScene.smethod_18((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "DJ", "Assets/Scenes/ClubInside/DJ Booth Coverup", -718, 314);
		ClubInsideScene.smethod_18((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "DJ Screen", "Assets/Scenes/ClubInside/Jumbo screen", -701, 385);
		ClubInsideScene.smethod_19((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Strobe Blue", "Assets/Scenes/ClubInside/blue_strobe", -1425, 100, 1200, 0, 1200);
		ClubInsideScene.smethod_19((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Strobe Green", "Assets/Scenes/ClubInside/green_strobe", 708, 120, 1200, 600, 600);
		ClubInsideScene.smethod_19((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Strobe Pink", "Assets/Scenes/ClubInside/pink_strobe", 48, 130, 1200, 1200, 0);
		ClubInsideScene.smethod_21(ClubInsideScene.smethod_20(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0), -1770, 1770);
		ClubInsideScene.smethod_22(_KZ7hNP1K5E99Xfup1lTZ9UDrxPE._oCy13KHJxLHriH7TwMiQ1qKJ8Uc, 0.4f, bool_0: true, bool_1: true);
		_opIJo2jLUqdOL5yAFP4yzXce0DG opIJo2jLUqdOL5yAFP4yzXce0DG_ = ClubInsideScene.smethod_23();
		_showCoby = true;
		_showJax = !ClubInsideScene.smethod_24(opIJo2jLUqdOL5yAFP4yzXce0DG_, "JaxLeftClub");
		_showSeth = !ClubInsideScene.smethod_24(opIJo2jLUqdOL5yAFP4yzXce0DG_, "SethLeftClub");
		_showSkye = !ClubInsideScene.smethod_24(opIJo2jLUqdOL5yAFP4yzXce0DG_, "SkyeLeftClub");
		if (ClubInsideScene.smethod_25(opIJo2jLUqdOL5yAFP4yzXce0DG_, "SkyeDate") == 20)
		{
			ClubInsideScene.smethod_26(opIJo2jLUqdOL5yAFP4yzXce0DG_, "SkyeDate", 10);
		}
		ClubInsideScene.smethod_29(ClubInsideScene.smethod_28(ClubInsideScene.smethod_27((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)), "AchievementGeneric2");
	}

	public override void Start()
	{
		if (_showJax)
		{
			_jax = ClubInsideScene.smethod_27((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<JaxNPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Background);
			_jax._g3oEqGBkN3YHUPosRq2nIP2sX0D(JaxNPC.EHeads.Happy);
			_jax._tDFvus0ZCanjp81eOiDzoMXJiuf(JaxNPC.EPoses.Chill);
			_jax._09vxUzgOn7J7DFZEwsTh7lgEIhB(JaxNPC.EClothes.TuxChest, JaxNPC.EClothes.TuxUnderwear);
			ClubInsideScene.smethod_30((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)_jax, 1500f);
			ClubInsideScene.smethod_31((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)_jax, 580f);
			ClubInsideScene.smethod_32((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)_jax, 0.2f);
			ClubInsideScene.smethod_33((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)_jax, (Action)OnJaxClick);
			_3IHp43rpkJgOBcY9lrIrwMuwWve _3IHp43rpkJgOBcY9lrIrwMuwWve = _VvFE2zgy4FbDjvaEvb67tXJ7aRm<JaxNPC>();
			_3IHp43rpkJgOBcY9lrIrwMuwWve._ac2H6kMdrgPhXXxabsikjji4SiT = 0;
			_3IHp43rpkJgOBcY9lrIrwMuwWve._VNgmwYSLsJyyiR6cPQ35UHJBR4d = 0;
		}
		else
		{
			_rou = ClubInsideScene.smethod_27((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<BartenderNPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Background);
			_rou._g3oEqGBkN3YHUPosRq2nIP2sX0D(BartenderNPC.EHeads.None);
			_rou._tDFvus0ZCanjp81eOiDzoMXJiuf(BartenderNPC.EPoses.Standing);
			_rou._09vxUzgOn7J7DFZEwsTh7lgEIhB(BartenderNPC.EClothes.Shirt, BartenderNPC.EClothes.Pants);
			ClubInsideScene.smethod_30((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)_rou, 1450f);
			ClubInsideScene.smethod_31((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)_rou, 380f);
			ClubInsideScene.smethod_32((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)_rou, 0.2f);
			ClubInsideScene.smethod_33((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)_rou, (Action)OnRouClick);
			_3IHp43rpkJgOBcY9lrIrwMuwWve _3IHp43rpkJgOBcY9lrIrwMuwWve2 = _VvFE2zgy4FbDjvaEvb67tXJ7aRm<BartenderNPC>();
			_3IHp43rpkJgOBcY9lrIrwMuwWve2._ac2H6kMdrgPhXXxabsikjji4SiT = 0;
			_3IHp43rpkJgOBcY9lrIrwMuwWve2._VNgmwYSLsJyyiR6cPQ35UHJBR4d = 0;
		}
		ClubInsideANPC clubInsideANPC = ClubInsideScene.smethod_27((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubInsideANPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Background);
		clubInsideANPC._tDFvus0ZCanjp81eOiDzoMXJiuf(ClubStaticNPC.EPoses.Nude);
		clubInsideANPC._09vxUzgOn7J7DFZEwsTh7lgEIhB(ClubStaticNPC.EClothes.Pants, ClubStaticNPC.EClothes.Shirt);
		ClubInsideScene.smethod_30((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubInsideANPC, -1700f);
		ClubInsideScene.smethod_31((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubInsideANPC, 320f);
		ClubInsideBNPC clubInsideBNPC = ClubInsideScene.smethod_27((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubInsideBNPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Background);
		clubInsideBNPC._tDFvus0ZCanjp81eOiDzoMXJiuf(ClubStaticNPC.EPoses.Nude);
		clubInsideBNPC._09vxUzgOn7J7DFZEwsTh7lgEIhB(ClubStaticNPC.EClothes.Pants, ClubStaticNPC.EClothes.Shirt);
		ClubInsideScene.smethod_30((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubInsideBNPC, -1480f);
		ClubInsideScene.smethod_31((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubInsideBNPC, 320f);
		ClubInsideCNPC clubInsideCNPC = ClubInsideScene.smethod_27((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubInsideCNPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Background);
		clubInsideCNPC._tDFvus0ZCanjp81eOiDzoMXJiuf(ClubStaticNPC.EPoses.Nude);
		clubInsideCNPC._09vxUzgOn7J7DFZEwsTh7lgEIhB(ClubStaticNPC.EClothes.Pants, ClubStaticNPC.EClothes.Shirt);
		ClubInsideScene.smethod_30((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubInsideCNPC, -1230f);
		ClubInsideScene.smethod_31((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubInsideCNPC, 360f);
		ClubInsideDNPC clubInsideDNPC = ClubInsideScene.smethod_27((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubInsideDNPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Background);
		clubInsideDNPC._tDFvus0ZCanjp81eOiDzoMXJiuf(ClubStaticNPC.EPoses.Nude);
		clubInsideDNPC._09vxUzgOn7J7DFZEwsTh7lgEIhB(ClubStaticNPC.EClothes.Pants, ClubStaticNPC.EClothes.Shirt);
		ClubInsideScene.smethod_30((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubInsideDNPC, 950f);
		ClubInsideScene.smethod_31((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubInsideDNPC, 500f);
		ClubInsideENPC clubInsideENPC = ClubInsideScene.smethod_27((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubInsideENPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Background);
		clubInsideENPC._tDFvus0ZCanjp81eOiDzoMXJiuf(ClubStaticNPC.EPoses.Nude);
		clubInsideENPC._09vxUzgOn7J7DFZEwsTh7lgEIhB(ClubStaticNPC.EClothes.Pants, ClubStaticNPC.EClothes.Shirt);
		ClubInsideScene.smethod_30((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubInsideENPC, 1150f);
		ClubInsideScene.smethod_31((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubInsideENPC, 420f);
		_3IHp43rpkJgOBcY9lrIrwMuwWve _3IHp43rpkJgOBcY9lrIrwMuwWve3 = _VvFE2zgy4FbDjvaEvb67tXJ7aRm<ClubInsideENPC>();
		_3IHp43rpkJgOBcY9lrIrwMuwWve3._VNgmwYSLsJyyiR6cPQ35UHJBR4d = 2;
		ClubInsideFNPC clubInsideFNPC = ClubInsideScene.smethod_27((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubInsideFNPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Background);
		clubInsideFNPC._tDFvus0ZCanjp81eOiDzoMXJiuf(ClubStaticNPC.EPoses.Nude);
		clubInsideFNPC._09vxUzgOn7J7DFZEwsTh7lgEIhB(ClubStaticNPC.EClothes.Pants, ClubStaticNPC.EClothes.Shirt);
		ClubInsideScene.smethod_30((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubInsideFNPC, 3275f);
		ClubInsideScene.smethod_31((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubInsideFNPC, 360f);
		ClubInsideGNPC clubInsideGNPC = ClubInsideScene.smethod_27((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubInsideGNPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Background);
		clubInsideGNPC._tDFvus0ZCanjp81eOiDzoMXJiuf(ClubStaticNPC.EPoses.Nude);
		clubInsideGNPC._09vxUzgOn7J7DFZEwsTh7lgEIhB(ClubStaticNPC.EClothes.Pants, ClubStaticNPC.EClothes.Shirt);
		ClubInsideScene.smethod_30((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubInsideGNPC, 3400f);
		ClubInsideScene.smethod_31((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubInsideGNPC, 340f);
		ClubDJNPC clubDJNPC = ClubInsideScene.smethod_27((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubDJNPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Background);
		clubDJNPC._g3oEqGBkN3YHUPosRq2nIP2sX0D(ClubDJNPC.EHeads.Smirk);
		clubDJNPC._tDFvus0ZCanjp81eOiDzoMXJiuf(ClubDJNPC.EPoses.Dancing);
		clubDJNPC._09vxUzgOn7J7DFZEwsTh7lgEIhB(ClubDJNPC.EClothes.Shirt, ClubDJNPC.EClothes.Pants);
		ClubInsideScene.smethod_30((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubDJNPC, -400f);
		ClubInsideScene.smethod_31((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubDJNPC, 500f);
		clubDJNPC._SC7QlorMIWTLSkD757wC7ybszpE = true;
		ClubInsideScene.smethod_33((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubDJNPC, (Action)OnDJClick);
		_dancerA = ClubInsideScene.smethod_27((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubInsideDancerANPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Foreground);
		_dancerA._g3oEqGBkN3YHUPosRq2nIP2sX0D(ClubInsideDancerANPC.EHeads.Happy);
		_dancerA._tDFvus0ZCanjp81eOiDzoMXJiuf(ClubInsideDancerANPC.EPoses.Dancing);
		_dancerA._09vxUzgOn7J7DFZEwsTh7lgEIhB(ClubInsideDancerANPC.EClothes.Pants, ClubInsideDancerANPC.EClothes.Shirt);
		ClubInsideScene.smethod_30((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)_dancerA, -900f);
		ClubInsideScene.smethod_31((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)_dancerA, 950f);
		_dancerA._KDimeEJ9On2dWcynEqeEZz9c8DE(4, 3);
		if (_showCoby)
		{
			_coby = ClubInsideScene.smethod_27((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<CobyDancingNPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Foreground);
			_coby._g3oEqGBkN3YHUPosRq2nIP2sX0D(CobyDancingNPC.EHeads.Happy);
			_coby._tDFvus0ZCanjp81eOiDzoMXJiuf(CobyDancingNPC.EPoses.Dancing);
			_coby._09vxUzgOn7J7DFZEwsTh7lgEIhB(CobyDancingNPC.EClothes.Shirt, CobyDancingNPC.EClothes.Shorts, CobyDancingNPC.EClothes.Sleeves);
			ClubInsideScene.smethod_30((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)_coby, -400f);
			ClubInsideScene.smethod_31((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)_coby, 1000f);
			ClubInsideScene.smethod_33((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)_coby, (Action)OnCobyClick);
		}
		ClubInsideDancerCNPC clubInsideDancerCNPC = ClubInsideScene.smethod_27((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubInsideDancerCNPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Foreground);
		clubInsideDancerCNPC._g3oEqGBkN3YHUPosRq2nIP2sX0D(ClubInsideDancerCNPC.EHeads.Smirk);
		clubInsideDancerCNPC._tDFvus0ZCanjp81eOiDzoMXJiuf(ClubInsideDancerCNPC.EPoses.Dancing);
		clubInsideDancerCNPC._09vxUzgOn7J7DFZEwsTh7lgEIhB(ClubInsideDancerCNPC.EClothes.Shorts);
		ClubInsideScene.smethod_30((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubInsideDancerCNPC, 50f);
		ClubInsideScene.smethod_31((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubInsideDancerCNPC, 910f);
		ClubInsideDancerBNPC clubInsideDancerBNPC = ClubInsideScene.smethod_27((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubInsideDancerBNPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Foreground);
		clubInsideDancerBNPC._g3oEqGBkN3YHUPosRq2nIP2sX0D(ClubInsideDancerBNPC.EHeads.Happy);
		clubInsideDancerBNPC._tDFvus0ZCanjp81eOiDzoMXJiuf(ClubInsideDancerBNPC.EPoses.Dancing);
		clubInsideDancerBNPC._09vxUzgOn7J7DFZEwsTh7lgEIhB(ClubInsideDancerBNPC.EClothes.Skirt, ClubInsideDancerBNPC.EClothes.Shirt);
		ClubInsideScene.smethod_30((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubInsideDancerBNPC, 50f);
		ClubInsideScene.smethod_31((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubInsideDancerBNPC, 910f);
		ClubInsideDancerDNPC clubInsideDancerDNPC = ClubInsideScene.smethod_27((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubInsideDancerDNPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Foreground);
		clubInsideDancerDNPC._g3oEqGBkN3YHUPosRq2nIP2sX0D(ClubInsideDancerDNPC.EHeads.Smirk);
		clubInsideDancerDNPC._tDFvus0ZCanjp81eOiDzoMXJiuf(ClubInsideDancerDNPC.EPoses.Dancing);
		clubInsideDancerDNPC._09vxUzgOn7J7DFZEwsTh7lgEIhB(ClubInsideDancerDNPC.EClothes.Shirt, ClubInsideDancerDNPC.EClothes.Pants);
		ClubInsideScene.smethod_30((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubInsideDancerDNPC, 700f);
		ClubInsideScene.smethod_31((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubInsideDancerDNPC, 960f);
		if (_showSeth)
		{
			_seth = ClubInsideScene.smethod_27((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubStaticSethNPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Foreground);
			ClubInsideScene.smethod_30((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)_seth, 1612f);
			ClubInsideScene.smethod_31((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)_seth, 420f);
			ClubInsideScene.smethod_33((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)_seth, (Action)OnSethClick);
		}
		if (_showSkye)
		{
			_skye = ClubInsideScene.smethod_27((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubStaticSkyeNPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Background);
			ClubInsideScene.smethod_30((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)_skye, 2212f);
			ClubInsideScene.smethod_31((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)_skye, 438f);
			ClubInsideScene.smethod_33((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)_skye, (Action)OnSkyeClick);
			_3IHp43rpkJgOBcY9lrIrwMuwWve _3IHp43rpkJgOBcY9lrIrwMuwWve4 = _VvFE2zgy4FbDjvaEvb67tXJ7aRm<ClubStaticSkyeNPC>();
			_3IHp43rpkJgOBcY9lrIrwMuwWve4._VNgmwYSLsJyyiR6cPQ35UHJBR4d = 1;
		}
		ClubInsideScene.smethod_34((_7UlnfykmEmZDFt3BmCKZekI43Ih)this);
	}

	private void OnDoorClick()
	{
		ClubInsideScene.smethod_27((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._k9wUPeU1Ga7cygiuGP8TT6aPLWF<ClubEntranceScene>();
	}

	private void OnLoungeClick()
	{
		ClubInsideScene.smethod_27((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._k9wUPeU1Ga7cygiuGP8TT6aPLWF<ClubLoungeScene>();
	}

	private void OnJaxClick()
	{
		ClubInsideScene.smethod_35(ClubInsideScene.smethod_27((_7UlnfykmEmZDFt3BmCKZekI43Ih)this), "JaxPreDate");
	}

	private void OnRouClick()
	{
		ClubInsideScene.smethod_35(ClubInsideScene.smethod_27((_7UlnfykmEmZDFt3BmCKZekI43Ih)this), "Rou");
	}

	private void OnSethClick()
	{
		ClubInsideScene.smethod_35(ClubInsideScene.smethod_27((_7UlnfykmEmZDFt3BmCKZekI43Ih)this), "SethPreDate");
	}

	private void OnSkyeClick()
	{
		ClubInsideScene.smethod_35(ClubInsideScene.smethod_27((_7UlnfykmEmZDFt3BmCKZekI43Ih)this), "SkyePreDate");
	}

	private void OnCobyClick()
	{
		_opIJo2jLUqdOL5yAFP4yzXce0DG opIJo2jLUqdOL5yAFP4yzXce0DG_ = ClubInsideScene.smethod_23();
		if (ClubInsideScene.smethod_25(opIJo2jLUqdOL5yAFP4yzXce0DG_, "Prologue") >= 40)
		{
			ClubInsideScene.smethod_35(ClubInsideScene.smethod_27((_7UlnfykmEmZDFt3BmCKZekI43Ih)this), "CobyClub");
		}
		else
		{
			ClubInsideScene.smethod_35(ClubInsideScene.smethod_27((_7UlnfykmEmZDFt3BmCKZekI43Ih)this), "Prologue");
		}
	}

	private void OnDJClick()
	{
		ClubInsideScene.smethod_35(ClubInsideScene.smethod_27((_7UlnfykmEmZDFt3BmCKZekI43Ih)this), "DJ");
	}

	static _kxm3yIqio0baXT5t5vOHBAEdviB smethod_14(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0, string string_0, int int_0, int int_1, int int_2, string[] string_1)
	{
		return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._qCH6LFVbWcTfZTRElH4N91FiGeM(string_0, int_0, int_1, int_2, string_1);
	}

	static _hxdR2gDHAgUMo1HqEU81OpKiFNA smethod_15(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0, string string_0, string string_1, int int_0, int int_1, int int_2, int int_3, int int_4)
	{
		return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._0smWNvs61rH3hoJEMYp9eRPrLge(string_0, string_1, int_0, int_1, int_2, int_3, int_4);
	}

	static _uqydQVaCmCvK7zzWs5W4gZFpKBu smethod_16(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0, string string_0, string string_1, int int_0, int int_1)
	{
		return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._0O8D0mBgmrh0sLOGcLVvGNOHKLCA(string_0, string_1, int_0, int_1);
	}

	static _z20t8IpBINiJtljSeTIkNoKUOkx smethod_17(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0, string string_0, string string_1, int int_0, int int_1, Action action_0)
	{
		return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._2CHUZ5vSi5NbJYJ4gGtr3C2VVEo(string_0, string_1, int_0, int_1, action_0);
	}

	static _uqydQVaCmCvK7zzWs5W4gZFpKBu smethod_18(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0, string string_0, string string_1, int int_0, int int_1)
	{
		return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._NC5VT77x8y2iH2pW56TBN1eyomA(string_0, string_1, int_0, int_1);
	}

	static _hxdR2gDHAgUMo1HqEU81OpKiFNA smethod_19(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0, string string_0, string string_1, int int_0, int int_1, int int_2, int int_3, int int_4)
	{
		return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._Gwla9fGwcaH1uD03fvVNW68BhdH(string_0, string_1, int_0, int_1, int_2, int_3, int_4);
	}

	static _wRd4nHuQQlAPEwrHOGkBfut6Uip smethod_20(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		return _JbeCmOie0phb2cbgG6DdGZrbs3pB_0._vsceSzSIjBy2nZrCxAzKZbUiwLq;
	}

	static void smethod_21(_wRd4nHuQQlAPEwrHOGkBfut6Uip _wRd4nHuQQlAPEwrHOGkBfut6Uip_0, int int_0, int int_1)
	{
		_wRd4nHuQQlAPEwrHOGkBfut6Uip_0._EPA0ilTeyu3r3U3sXajd13XXT1B(int_0, int_1);
	}

	static void smethod_22(string[] string_0, float float_0, bool bool_0, bool bool_1)
	{
		_UmxbIbk7pgaod0bD7pS309P3Lns._QrgbXEg7MMeD9Ybz12fFVsbmAd9(string_0, float_0, bool_0, bool_1);
	}

	static _opIJo2jLUqdOL5yAFP4yzXce0DG smethod_23()
	{
		return _Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t();
	}

	static bool smethod_24(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0, string string_0)
	{
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._Oms9lumBodLGrGZ09YJaEuzmlAf(string_0);
	}

	static int smethod_25(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0, string string_0)
	{
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._fvTKDuNATrUxfXZVvltePz3vYkK(string_0);
	}

	static void smethod_26(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0, string string_0, int int_0)
	{
		_opIJo2jLUqdOL5yAFP4yzXce0DG_0._fPyIv5zbbSj5sjZlbAwQTFXnJ5G(string_0, int_0);
	}

	static _JbeCmOie0phb2cbgG6DdGZrbs3pB smethod_27(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0)
	{
		return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._ZzBuoSDMWwerejOO9Goyv2OCKgE;
	}

	static _691ooXdgg17CWFkMkjedKBBBfYw smethod_28(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		return _JbeCmOie0phb2cbgG6DdGZrbs3pB_0._aJh9CibG5YKhkExxgRyVopdfSeJ;
	}

	static void smethod_29(_691ooXdgg17CWFkMkjedKBBBfYw _691ooXdgg17CWFkMkjedKBBBfYw_0, string string_0)
	{
		_691ooXdgg17CWFkMkjedKBBBfYw_0._vVZVLriSGPExpn1KeobglMabsoi(string_0);
	}

	static void smethod_30(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, float float_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_7Xn1C5tjYnmIif1iZKV8AWsEEbL = float_0;
	}

	static void smethod_31(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, float float_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_bCjZ3VSXGKyhmykd2zCnQBiSpDf = float_0;
	}

	static void smethod_32(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, float float_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._fO7gSlrDDNMoHR4FO5QXAq8fUyA = float_0;
	}

	static void smethod_33(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, Action action_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._ZVpZ5Oing5kbbVhbmbOHyrofGH7 = action_0;
	}

	static void smethod_34(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0)
	{
		_7UlnfykmEmZDFt3BmCKZekI43Ih_0._yMMFQ2n4dqXlB1AEzmdkoKkPkX5();
	}

	static void smethod_35(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0, string string_0)
	{
		_JbeCmOie0phb2cbgG6DdGZrbs3pB_0._xyl3Tv5KdR5eezDgagxbBcS3cwt(string_0);
	}
}
