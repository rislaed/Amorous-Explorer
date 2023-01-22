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
		_opIJo2jLUqdOL5yAFP4yzXce0DG opIJo2jLUqdOL5yAFP4yzXce0DG_ = default(_opIJo2jLUqdOL5yAFP4yzXce0DG);
		while (true)
		{
			int num = 1614635623;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3DDC40B4u) % 18u)
				{
				case 17u:
					ClubInsideScene.smethod_14((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Background Left", -1770, 0, 1200, new string[2] { "Assets/Scenes/ClubInside/Clubdance_left", "Assets/Scenes/ClubInside/Clubdancegreen_left" });
					ClubInsideScene.smethod_14((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Background Middle", 50, 0, 1200, new string[2] { "Assets/Scenes/ClubInside/Clubdance_mid", "Assets/Scenes/ClubInside/Clubdancegreen_mid" });
					num = (int)(num2 * 34847202) ^ -2147086224;
					continue;
				case 16u:
					ClubInsideScene.smethod_18((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Coat check-in", "Assets/Scenes/ClubInside/Service desk coverup", -1234, 516);
					ClubInsideScene.smethod_18((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "DJ", "Assets/Scenes/ClubInside/DJ Booth Coverup", -718, 314);
					num = (int)((num2 * 2099123716) ^ 0x3351C796);
					continue;
				case 15u:
					_showCoby = true;
					_showJax = !ClubInsideScene.smethod_24(opIJo2jLUqdOL5yAFP4yzXce0DG_, "JaxLeftClub");
					num = (int)(num2 * 1579817466) ^ -1915588999;
					continue;
				case 14u:
					ClubInsideScene.smethod_14((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Background Right", 1870, 0, 1200, new string[2] { "Assets/Scenes/ClubInside/Clubdance_right", "Assets/Scenes/ClubInside/Clubdancegreen_right" });
					ClubInsideScene.smethod_15((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Floor Left", "Assets/Scenes/ClubInside/dancefloor_left", -1740, 748, 1200, 0, 0);
					ClubInsideScene.smethod_15((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Floor Middle", "Assets/Scenes/ClubInside/dancefloor_mid", 54, 736, 1200, 0, 0);
					num = (int)(num2 * 2071809180) ^ -2011433441;
					continue;
				case 13u:
					ClubInsideScene.smethod_16((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Spotlight Green", "Assets/Scenes/ClubInside/Green_spotlight", 1078, 75);
					num = (int)((num2 * 2043220566) ^ 0x1B4482D5);
					continue;
				case 12u:
				{
					int num3;
					int num4;
					if (ClubInsideScene.smethod_25(opIJo2jLUqdOL5yAFP4yzXce0DG_, "SkyeDate") != 20)
					{
						num3 = -1300021641;
						num4 = -1300021641;
					}
					else
					{
						num3 = -1934143384;
						num4 = -1934143384;
					}
					num = num3 ^ ((int)num2 * -505401697);
					continue;
				}
				case 10u:
					opIJo2jLUqdOL5yAFP4yzXce0DG_ = ClubInsideScene.smethod_23();
					num = ((int)num2 * -1487603818) ^ -1399357205;
					continue;
				case 9u:
					ClubInsideScene.smethod_15((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Floor Right", "Assets/Scenes/ClubInside/dancefloor_right", 1874, 815, 1200, 0, 0);
					ClubInsideScene.smethod_16((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Spotlight Blue", "Assets/Scenes/ClubInside/blue_spotlight", -1454, 75);
					num = (int)((num2 * 2126754943) ^ 0x7EAA0AEE);
					continue;
				case 8u:
					ClubInsideScene.smethod_26(opIJo2jLUqdOL5yAFP4yzXce0DG_, "SkyeDate", 10);
					num = (int)((num2 * 28388376) ^ 0x57F1D995);
					continue;
				case 7u:
					ClubInsideScene.smethod_29(ClubInsideScene.smethod_28(ClubInsideScene.smethod_27((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)), "AchievementGeneric2");
					num = 1894868981;
					continue;
				case 6u:
				{
					_uqydQVaCmCvK7zzWs5W4gZFpKBu uqydQVaCmCvK7zzWs5W4gZFpKBu = ClubInsideScene.smethod_16((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Bar", "Assets/Scenes/ClubInside/Bar", 1162, 541);
					uqydQVaCmCvK7zzWs5W4gZFpKBu._VNgmwYSLsJyyiR6cPQ35UHJBR4d = 1;
					num = ((int)num2 * -386583700) ^ -1685721724;
					continue;
				}
				case 5u:
					ClubInsideScene.smethod_16((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Spotlight Pink", "Assets/Scenes/ClubInside/pink_spotlight", 1580, 100);
					ClubInsideScene.smethod_17((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Entrance", "Assets/Scenes/ClubInside/Entrance Selectable", -1733, 302, (Action)OnDoorClick);
					ClubInsideScene.smethod_17((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Lounge", "Assets/Scenes/ClubInside/Loungeroom Selectable", 231, 347, (Action)OnLoungeClick);
					num = ((int)num2 * -988988727) ^ -2071920081;
					continue;
				case 4u:
					ClubInsideScene.smethod_18((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "DJ Screen", "Assets/Scenes/ClubInside/Jumbo screen", -701, 385);
					ClubInsideScene.smethod_19((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Strobe Blue", "Assets/Scenes/ClubInside/blue_strobe", -1425, 100, 1200, 0, 1200);
					ClubInsideScene.smethod_19((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Strobe Green", "Assets/Scenes/ClubInside/green_strobe", 708, 120, 1200, 600, 600);
					ClubInsideScene.smethod_19((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Strobe Pink", "Assets/Scenes/ClubInside/pink_strobe", 48, 130, 1200, 1200, 0);
					num = (int)(num2 * 1799532772) ^ -501516252;
					continue;
				case 3u:
					_showSeth = !ClubInsideScene.smethod_24(opIJo2jLUqdOL5yAFP4yzXce0DG_, "SethLeftClub");
					_showSkye = !ClubInsideScene.smethod_24(opIJo2jLUqdOL5yAFP4yzXce0DG_, "SkyeLeftClub");
					num = ((int)num2 * -1360622019) ^ 0x72D179B5;
					continue;
				case 2u:
					ClubInsideScene.smethod_22(_KZ7hNP1K5E99Xfup1lTZ9UDrxPE._oCy13KHJxLHriH7TwMiQ1qKJ8Uc, 0.4f, bool_0: true, bool_1: true);
					num = ((int)num2 * -1195387833) ^ 0x6ED66D86;
					continue;
				case 0u:
					ClubInsideScene.smethod_21(ClubInsideScene.smethod_20(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0), -1770, 1770);
					num = ((int)num2 * -691750145) ^ 0x33A30D0E;
					continue;
				default:
					return;
				case 11u:
					break;
				case 1u:
					return;
				}
				break;
			}
		}
	}

	public override void Start()
	{
		if (_showJax)
		{
			goto IL_0176;
		}
		goto IL_0c1f;
		IL_0c1f:
		_rou = ClubInsideScene.smethod_27((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<BartenderNPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Background);
		int num = 340769379;
		goto IL_0af8;
		IL_0af8:
		ClubInsideENPC clubInsideENPC = default(ClubInsideENPC);
		ClubInsideCNPC clubInsideCNPC = default(ClubInsideCNPC);
		ClubInsideDNPC clubInsideDNPC = default(ClubInsideDNPC);
		ClubInsideDancerBNPC clubInsideDancerBNPC = default(ClubInsideDancerBNPC);
		ClubInsideANPC clubInsideANPC = default(ClubInsideANPC);
		ClubInsideBNPC clubInsideBNPC = default(ClubInsideBNPC);
		ClubInsideFNPC clubInsideFNPC = default(ClubInsideFNPC);
		ClubInsideGNPC clubInsideGNPC = default(ClubInsideGNPC);
		ClubDJNPC clubDJNPC = default(ClubDJNPC);
		ClubInsideDancerDNPC clubInsideDancerDNPC = default(ClubInsideDancerDNPC);
		_3IHp43rpkJgOBcY9lrIrwMuwWve _3IHp43rpkJgOBcY9lrIrwMuwWve3 = default(_3IHp43rpkJgOBcY9lrIrwMuwWve);
		ClubInsideDancerCNPC clubInsideDancerCNPC = default(ClubInsideDancerCNPC);
		_3IHp43rpkJgOBcY9lrIrwMuwWve _3IHp43rpkJgOBcY9lrIrwMuwWve = default(_3IHp43rpkJgOBcY9lrIrwMuwWve);
		_3IHp43rpkJgOBcY9lrIrwMuwWve _3IHp43rpkJgOBcY9lrIrwMuwWve2 = default(_3IHp43rpkJgOBcY9lrIrwMuwWve);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x6AB7BDBBu) % 69u)
			{
			case 68u:
				ClubInsideScene.smethod_31((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubInsideENPC, 420f);
				num = ((int)num2 * -928839754) ^ 0x6AD267E8;
				continue;
			case 67u:
				ClubInsideScene.smethod_30((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubInsideCNPC, -1230f);
				ClubInsideScene.smethod_31((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubInsideCNPC, 360f);
				clubInsideDNPC = ClubInsideScene.smethod_27((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubInsideDNPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Background);
				num = (int)(num2 * 186110697) ^ -205383495;
				continue;
			case 66u:
				ClubInsideScene.smethod_30((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubInsideDancerBNPC, 50f);
				num = (int)((num2 * 1226718874) ^ 0x4E073929);
				continue;
			case 65u:
				clubInsideANPC = ClubInsideScene.smethod_27((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubInsideANPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Background);
				num = 3046528;
				continue;
			case 64u:
				ClubInsideScene.smethod_33((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)_skye, (Action)OnSkyeClick);
				num = ((int)num2 * -194240866) ^ -1728476534;
				continue;
			case 63u:
				ClubInsideScene.smethod_31((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubInsideBNPC, 320f);
				clubInsideCNPC = ClubInsideScene.smethod_27((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubInsideCNPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Background);
				clubInsideCNPC._tDFvus0ZCanjp81eOiDzoMXJiuf(ClubStaticNPC.EPoses.Nude);
				num = ((int)num2 * -87843536) ^ 0x105C36B1;
				continue;
			case 62u:
				clubInsideDNPC._09vxUzgOn7J7DFZEwsTh7lgEIhB(ClubStaticNPC.EClothes.Pants, ClubStaticNPC.EClothes.Shirt);
				ClubInsideScene.smethod_30((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubInsideDNPC, 950f);
				ClubInsideScene.smethod_31((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubInsideDNPC, 500f);
				num = (int)((num2 * 217860785) ^ 0x491190D1);
				continue;
			case 61u:
			{
				ClubInsideScene.smethod_33((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)_jax, (Action)OnJaxClick);
				_3IHp43rpkJgOBcY9lrIrwMuwWve _3IHp43rpkJgOBcY9lrIrwMuwWve4 = _VvFE2zgy4FbDjvaEvb67tXJ7aRm<JaxNPC>();
				_3IHp43rpkJgOBcY9lrIrwMuwWve4._ac2H6kMdrgPhXXxabsikjji4SiT = 0;
				_3IHp43rpkJgOBcY9lrIrwMuwWve4._VNgmwYSLsJyyiR6cPQ35UHJBR4d = 0;
				num = ((int)num2 * -1728769882) ^ -1600543058;
				continue;
			}
			case 60u:
				break;
			case 59u:
				clubInsideDancerBNPC._09vxUzgOn7J7DFZEwsTh7lgEIhB(ClubInsideDancerBNPC.EClothes.Skirt, ClubInsideDancerBNPC.EClothes.Shirt);
				num = ((int)num2 * -935331984) ^ 0x4EB3BEB3;
				continue;
			case 58u:
				clubInsideENPC._09vxUzgOn7J7DFZEwsTh7lgEIhB(ClubStaticNPC.EClothes.Pants, ClubStaticNPC.EClothes.Shirt);
				ClubInsideScene.smethod_30((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubInsideENPC, 1150f);
				num = (int)((num2 * 1218705411) ^ 0x23CC8C56);
				continue;
			case 57u:
				clubInsideANPC._09vxUzgOn7J7DFZEwsTh7lgEIhB(ClubStaticNPC.EClothes.Pants, ClubStaticNPC.EClothes.Shirt);
				ClubInsideScene.smethod_30((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubInsideANPC, -1700f);
				num = (int)(num2 * 1819552958) ^ -1169552709;
				continue;
			case 55u:
				ClubInsideScene.smethod_30((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)_rou, 1450f);
				ClubInsideScene.smethod_31((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)_rou, 380f);
				num = ((int)num2 * -320075713) ^ -1937490148;
				continue;
			case 54u:
				ClubInsideScene.smethod_31((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubInsideFNPC, 360f);
				clubInsideGNPC = ClubInsideScene.smethod_27((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubInsideGNPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Background);
				clubInsideGNPC._tDFvus0ZCanjp81eOiDzoMXJiuf(ClubStaticNPC.EPoses.Nude);
				num = (int)((num2 * 491739309) ^ 0x51C8E890);
				continue;
			case 53u:
			{
				_dancerA._KDimeEJ9On2dWcynEqeEZz9c8DE(4, 3);
				int num5;
				int num6;
				if (!_showCoby)
				{
					num5 = -1070077213;
					num6 = -1070077213;
				}
				else
				{
					num5 = -1031248498;
					num6 = -1031248498;
				}
				num = num5 ^ ((int)num2 * -619068908);
				continue;
			}
			case 52u:
				clubInsideDNPC._tDFvus0ZCanjp81eOiDzoMXJiuf(ClubStaticNPC.EPoses.Nude);
				num = ((int)num2 * -1945919476) ^ -1943094049;
				continue;
			case 51u:
				goto IL_02ca;
			case 50u:
				_seth = ClubInsideScene.smethod_27((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubStaticSethNPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Foreground);
				num = (int)(num2 * 2146346753) ^ -364099179;
				continue;
			case 49u:
				_dancerA._tDFvus0ZCanjp81eOiDzoMXJiuf(ClubInsideDancerANPC.EPoses.Dancing);
				_dancerA._09vxUzgOn7J7DFZEwsTh7lgEIhB(ClubInsideDancerANPC.EClothes.Pants, ClubInsideDancerANPC.EClothes.Shirt);
				ClubInsideScene.smethod_30((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)_dancerA, -900f);
				num = (int)(num2 * 1796741344) ^ -92714332;
				continue;
			case 48u:
				clubInsideDancerBNPC = ClubInsideScene.smethod_27((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubInsideDancerBNPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Foreground);
				clubInsideDancerBNPC._g3oEqGBkN3YHUPosRq2nIP2sX0D(ClubInsideDancerBNPC.EHeads.Happy);
				num = (int)(num2 * 1596213131) ^ -781467786;
				continue;
			case 47u:
				_rou._09vxUzgOn7J7DFZEwsTh7lgEIhB(BartenderNPC.EClothes.Shirt, BartenderNPC.EClothes.Pants);
				num = ((int)num2 * -1264926309) ^ 0x2FAE5C01;
				continue;
			case 46u:
				ClubInsideScene.smethod_31((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubDJNPC, 500f);
				num = ((int)num2 * -1207950748) ^ -1197222047;
				continue;
			case 45u:
				clubDJNPC._SC7QlorMIWTLSkD757wC7ybszpE = true;
				ClubInsideScene.smethod_33((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubDJNPC, (Action)OnDJClick);
				_dancerA = ClubInsideScene.smethod_27((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubInsideDancerANPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Foreground);
				_dancerA._g3oEqGBkN3YHUPosRq2nIP2sX0D(ClubInsideDancerANPC.EHeads.Happy);
				num = ((int)num2 * -1931379528) ^ -1879114817;
				continue;
			case 44u:
				clubInsideDancerBNPC._tDFvus0ZCanjp81eOiDzoMXJiuf(ClubInsideDancerBNPC.EPoses.Dancing);
				num = (int)((num2 * 924927710) ^ 0x48ACE080);
				continue;
			case 43u:
				clubInsideDancerDNPC = ClubInsideScene.smethod_27((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubInsideDancerDNPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Foreground);
				clubInsideDancerDNPC._g3oEqGBkN3YHUPosRq2nIP2sX0D(ClubInsideDancerDNPC.EHeads.Smirk);
				num = ((int)num2 * -1095832918) ^ 0x3EAC7431;
				continue;
			case 42u:
				ClubInsideScene.smethod_31((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)_coby, 1000f);
				ClubInsideScene.smethod_33((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)_coby, (Action)OnCobyClick);
				num = (int)(num2 * 1411786532) ^ -97974845;
				continue;
			case 41u:
				num = ((int)num2 * -1758779934) ^ -2137759366;
				continue;
			case 39u:
				clubInsideGNPC._09vxUzgOn7J7DFZEwsTh7lgEIhB(ClubStaticNPC.EClothes.Pants, ClubStaticNPC.EClothes.Shirt);
				num = (int)(num2 * 1552198302) ^ -2083513276;
				continue;
			case 38u:
				ClubInsideScene.smethod_32((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)_rou, 0.2f);
				ClubInsideScene.smethod_33((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)_rou, (Action)OnRouClick);
				_3IHp43rpkJgOBcY9lrIrwMuwWve3 = _VvFE2zgy4FbDjvaEvb67tXJ7aRm<BartenderNPC>();
				_3IHp43rpkJgOBcY9lrIrwMuwWve3._ac2H6kMdrgPhXXxabsikjji4SiT = 0;
				num = ((int)num2 * -944006837) ^ -1301976017;
				continue;
			case 37u:
				_jax = ClubInsideScene.smethod_27((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<JaxNPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Background);
				_jax._g3oEqGBkN3YHUPosRq2nIP2sX0D(JaxNPC.EHeads.Happy);
				num = ((int)num2 * -133928670) ^ 0xD946D2F;
				continue;
			case 36u:
				clubInsideBNPC = ClubInsideScene.smethod_27((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubInsideBNPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Background);
				clubInsideBNPC._tDFvus0ZCanjp81eOiDzoMXJiuf(ClubStaticNPC.EPoses.Nude);
				clubInsideBNPC._09vxUzgOn7J7DFZEwsTh7lgEIhB(ClubStaticNPC.EClothes.Pants, ClubStaticNPC.EClothes.Shirt);
				ClubInsideScene.smethod_30((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubInsideBNPC, -1480f);
				num = (int)((num2 * 1697634395) ^ 0x5C3A7BC7);
				continue;
			case 35u:
				ClubInsideScene.smethod_31((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubInsideDancerCNPC, 910f);
				num = ((int)num2 * -300973171) ^ -695226911;
				continue;
			case 34u:
				ClubInsideScene.smethod_34((_7UlnfykmEmZDFt3BmCKZekI43Ih)this);
				num = 1509732635;
				continue;
			case 33u:
				clubDJNPC._tDFvus0ZCanjp81eOiDzoMXJiuf(ClubDJNPC.EPoses.Dancing);
				num = (int)((num2 * 269395456) ^ 0x35561262);
				continue;
			case 32u:
				clubDJNPC._g3oEqGBkN3YHUPosRq2nIP2sX0D(ClubDJNPC.EHeads.Smirk);
				num = ((int)num2 * -1480278053) ^ -1924122919;
				continue;
			case 31u:
				_skye = ClubInsideScene.smethod_27((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubStaticSkyeNPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Background);
				ClubInsideScene.smethod_30((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)_skye, 2212f);
				ClubInsideScene.smethod_31((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)_skye, 438f);
				num = ((int)num2 * -22870898) ^ -323099592;
				continue;
			case 30u:
				clubInsideDancerDNPC._tDFvus0ZCanjp81eOiDzoMXJiuf(ClubInsideDancerDNPC.EPoses.Dancing);
				clubInsideDancerDNPC._09vxUzgOn7J7DFZEwsTh7lgEIhB(ClubInsideDancerDNPC.EClothes.Shirt, ClubInsideDancerDNPC.EClothes.Pants);
				ClubInsideScene.smethod_30((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubInsideDancerDNPC, 700f);
				ClubInsideScene.smethod_31((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubInsideDancerDNPC, 960f);
				num = (int)((num2 * 496232213) ^ 0x663BE4DD);
				continue;
			case 29u:
				_coby = ClubInsideScene.smethod_27((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<CobyDancingNPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Foreground);
				_coby._g3oEqGBkN3YHUPosRq2nIP2sX0D(CobyDancingNPC.EHeads.Happy);
				num = ((int)num2 * -673171830) ^ -1076870914;
				continue;
			case 28u:
				ClubInsideScene.smethod_31((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)_jax, 580f);
				num = ((int)num2 * -1015162099) ^ 0x24314D30;
				continue;
			case 27u:
				_jax._09vxUzgOn7J7DFZEwsTh7lgEIhB(JaxNPC.EClothes.TuxChest, JaxNPC.EClothes.TuxUnderwear);
				num = ((int)num2 * -908435753) ^ -1130314580;
				continue;
			case 26u:
				ClubInsideScene.smethod_30((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubInsideFNPC, 3275f);
				num = ((int)num2 * -1144809716) ^ 0x7F571ADE;
				continue;
			case 25u:
				_3IHp43rpkJgOBcY9lrIrwMuwWve3._VNgmwYSLsJyyiR6cPQ35UHJBR4d = 0;
				num = (int)(num2 * 1234712771) ^ -549662054;
				continue;
			case 24u:
				clubInsideDancerCNPC._09vxUzgOn7J7DFZEwsTh7lgEIhB(ClubInsideDancerCNPC.EClothes.Shorts);
				ClubInsideScene.smethod_30((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubInsideDancerCNPC, 50f);
				num = (int)((num2 * 1198363162) ^ 0x2F248E7);
				continue;
			case 23u:
				ClubInsideScene.smethod_31((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)_dancerA, 950f);
				num = ((int)num2 * -1604723165) ^ 0x623E53BB;
				continue;
			case 22u:
				ClubInsideScene.smethod_30((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubDJNPC, -400f);
				num = (int)((num2 * 664282589) ^ 0x33A4882);
				continue;
			case 21u:
				_jax._tDFvus0ZCanjp81eOiDzoMXJiuf(JaxNPC.EPoses.Chill);
				num = ((int)num2 * -2133481518) ^ 0x124B71A6;
				continue;
			case 20u:
				clubInsideDancerCNPC = ClubInsideScene.smethod_27((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubInsideDancerCNPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Foreground);
				clubInsideDancerCNPC._g3oEqGBkN3YHUPosRq2nIP2sX0D(ClubInsideDancerCNPC.EHeads.Smirk);
				clubInsideDancerCNPC._tDFvus0ZCanjp81eOiDzoMXJiuf(ClubInsideDancerCNPC.EPoses.Dancing);
				num = 1548318689;
				continue;
			case 19u:
				_3IHp43rpkJgOBcY9lrIrwMuwWve = _VvFE2zgy4FbDjvaEvb67tXJ7aRm<ClubStaticSkyeNPC>();
				num = (int)((num2 * 1037139119) ^ 0x4271E931);
				continue;
			case 18u:
				clubInsideCNPC._09vxUzgOn7J7DFZEwsTh7lgEIhB(ClubStaticNPC.EClothes.Pants, ClubStaticNPC.EClothes.Shirt);
				num = ((int)num2 * -1009976507) ^ -1748032659;
				continue;
			case 17u:
				clubDJNPC._09vxUzgOn7J7DFZEwsTh7lgEIhB(ClubDJNPC.EClothes.Shirt, ClubDJNPC.EClothes.Pants);
				num = (int)((num2 * 450695172) ^ 0x2B2F1AE8);
				continue;
			case 16u:
				ClubInsideScene.smethod_30((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)_jax, 1500f);
				num = (int)((num2 * 706323387) ^ 0x437385A6);
				continue;
			case 15u:
			{
				int num3;
				int num4;
				if (!_showSeth)
				{
					num3 = -47862560;
					num4 = -47862560;
				}
				else
				{
					num3 = -1364313816;
					num4 = -1364313816;
				}
				num = num3 ^ (int)(num2 * 868330982);
				continue;
			}
			case 14u:
				ClubInsideScene.smethod_31((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubInsideANPC, 320f);
				num = ((int)num2 * -1316797872) ^ 0x6FF0EEED;
				continue;
			case 13u:
				_rou._tDFvus0ZCanjp81eOiDzoMXJiuf(BartenderNPC.EPoses.Standing);
				num = (int)(num2 * 365175543) ^ -174289501;
				continue;
			case 12u:
				ClubInsideScene.smethod_33((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)_seth, (Action)OnSethClick);
				num = ((int)num2 * -974003688) ^ 0x7AB90D24;
				continue;
			case 11u:
				ClubInsideScene.smethod_30((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)_coby, -400f);
				num = (int)(num2 * 703373461) ^ -1692984427;
				continue;
			case 10u:
				_coby._tDFvus0ZCanjp81eOiDzoMXJiuf(CobyDancingNPC.EPoses.Dancing);
				_coby._09vxUzgOn7J7DFZEwsTh7lgEIhB(CobyDancingNPC.EClothes.Shirt, CobyDancingNPC.EClothes.Shorts, CobyDancingNPC.EClothes.Sleeves);
				num = (int)(num2 * 450660741) ^ -2063223245;
				continue;
			case 9u:
				ClubInsideScene.smethod_32((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)_jax, 0.2f);
				num = (int)((num2 * 1648155872) ^ 0x4D37C393);
				continue;
			case 8u:
				_3IHp43rpkJgOBcY9lrIrwMuwWve2 = _VvFE2zgy4FbDjvaEvb67tXJ7aRm<ClubInsideENPC>();
				num = ((int)num2 * -726189707) ^ -1620777371;
				continue;
			case 7u:
				_3IHp43rpkJgOBcY9lrIrwMuwWve2._VNgmwYSLsJyyiR6cPQ35UHJBR4d = 2;
				clubInsideFNPC = ClubInsideScene.smethod_27((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubInsideFNPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Background);
				clubInsideFNPC._tDFvus0ZCanjp81eOiDzoMXJiuf(ClubStaticNPC.EPoses.Nude);
				clubInsideFNPC._09vxUzgOn7J7DFZEwsTh7lgEIhB(ClubStaticNPC.EClothes.Pants, ClubStaticNPC.EClothes.Shirt);
				num = (int)(num2 * 1739838071) ^ -1176036404;
				continue;
			case 6u:
				_rou._g3oEqGBkN3YHUPosRq2nIP2sX0D(BartenderNPC.EHeads.None);
				num = ((int)num2 * -1536379686) ^ 0x3E66E802;
				continue;
			case 5u:
				clubInsideENPC = ClubInsideScene.smethod_27((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubInsideENPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Background);
				clubInsideENPC._tDFvus0ZCanjp81eOiDzoMXJiuf(ClubStaticNPC.EPoses.Nude);
				num = ((int)num2 * -1015715438) ^ 0x422D7BEC;
				continue;
			case 4u:
				_3IHp43rpkJgOBcY9lrIrwMuwWve._VNgmwYSLsJyyiR6cPQ35UHJBR4d = 1;
				num = (int)((num2 * 322460060) ^ 0x2979F0B6);
				continue;
			case 3u:
				ClubInsideScene.smethod_30((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubInsideGNPC, 3400f);
				ClubInsideScene.smethod_31((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubInsideGNPC, 340f);
				clubDJNPC = ClubInsideScene.smethod_27((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubDJNPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Background);
				num = (int)((num2 * 1548884111) ^ 0x11CA8BF3);
				continue;
			case 2u:
				ClubInsideScene.smethod_31((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubInsideDancerBNPC, 910f);
				num = (int)((num2 * 1067652543) ^ 0x7D5F33AC);
				continue;
			case 1u:
				clubInsideANPC._tDFvus0ZCanjp81eOiDzoMXJiuf(ClubStaticNPC.EPoses.Nude);
				num = (int)(num2 * 273979453) ^ -2079115267;
				continue;
			case 0u:
				ClubInsideScene.smethod_30((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)_seth, 1612f);
				ClubInsideScene.smethod_31((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)_seth, 420f);
				num = ((int)num2 * -995868660) ^ -203015609;
				continue;
			default:
				return;
			case 56u:
				goto IL_0c1f;
			case 40u:
				return;
			}
			break;
			IL_02ca:
			int num7;
			if (!_showSkye)
			{
				num = 1134324194;
				num7 = 1134324194;
			}
			else
			{
				num = 756484942;
				num7 = 756484942;
			}
		}
		goto IL_0176;
		IL_0176:
		num = 325396791;
		goto IL_0af8;
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
		while (true)
		{
			int num = -273570642;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF3740906u) % 6u)
				{
				case 5u:
					ClubInsideScene.smethod_35(ClubInsideScene.smethod_27((_7UlnfykmEmZDFt3BmCKZekI43Ih)this), "CobyClub");
					num = (int)(num2 * 1340835314) ^ -1887392234;
					continue;
				case 3u:
					ClubInsideScene.smethod_35(ClubInsideScene.smethod_27((_7UlnfykmEmZDFt3BmCKZekI43Ih)this), "Prologue");
					num = -2141330523;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (ClubInsideScene.smethod_25(opIJo2jLUqdOL5yAFP4yzXce0DG_, "Prologue") >= 40)
					{
						num3 = -940210177;
						num4 = -940210177;
					}
					else
					{
						num3 = -1013561385;
						num4 = -1013561385;
					}
					num = num3 ^ (int)(num2 * 734068505);
					continue;
				}
				default:
					return;
				case 4u:
					break;
				case 0u:
					return;
				case 1u:
					return;
				}
				break;
			}
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
