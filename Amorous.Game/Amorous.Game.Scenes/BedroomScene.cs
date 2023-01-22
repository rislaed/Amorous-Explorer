using System;
using Microsoft.Xna.Framework;

namespace Amorous.Game.Scenes;

public class BedroomScene : TimeOfDayScene
{
	private readonly _dvyBDFOZwoBLf9qqHSfHYLLXVwP _phoneNag;

	public BedroomScene(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		while (true)
		{
			int num = 443137992;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x27FE4EB7u) % 15u)
				{
				case 14u:
				{
					int num5;
					int num6;
					if (BedroomScene.smethod_21(BedroomScene.smethod_20(), "Prologue") >= 40)
					{
						num5 = 119338689;
						num6 = 119338689;
					}
					else
					{
						num5 = 358685109;
						num6 = 358685109;
					}
					num = num5 ^ (int)(num2 * 1013244819);
					continue;
				}
				case 13u:
				{
					int num3;
					int num4;
					if (!BedroomScene.smethod_23())
					{
						num3 = 651593145;
						num4 = 651593145;
					}
					else
					{
						num3 = 671516839;
						num4 = 671516839;
					}
					num = num3 ^ ((int)num2 * -243572561);
					continue;
				}
				case 12u:
					BedroomScene.smethod_25(BedroomScene.smethod_24(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0), -458, 458, 0, 0);
					num = (int)((num2 * 467761087) ^ 0x368ABC11);
					continue;
				case 11u:
					Reset();
					num = ((int)num2 * -1286553608) ^ -914312263;
					continue;
				case 10u:
					BedroomScene.smethod_18((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Background", "Assets/Scenes/Bedroom/Bedroom", -458, 0);
					BedroomScene.smethod_19((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Background", "Assets/Scenes/Bedroom/Door", 1008, 186, (Action)OnDoorClick);
					num = (int)((num2 * 365038358) ^ 0x3BF203);
					continue;
				case 9u:
					BedroomScene.smethod_22((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Background", "Assets/Scenes/Bedroom/Closet", 1551, 112, "Assets/Scenes/Bedroom/Closet active", 1517, 102, "Most of his clothes have been taken to his boyfriend's house. I can still see his ass hugging swim trunks that I'm pretty sure were designed for girls, and a dress for, well... he liked to wear a dress at one point. I don't judge.");
					num = 904039981;
					continue;
				case 8u:
					BedroomScene.smethod_22((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Background", "Assets/Scenes/Bedroom/Kangaroo Plush", 359, 159, (string)null, 0, 0, "A little something my brother bought as a reminder of his long-distance boyfriend. It must be a pretty open relationship.");
					BedroomScene.smethod_22((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Background", "Assets/Scenes/Bedroom/Laptop", 1153, 662, (string)null, 0, 0, "My entertainment centre for the last few weeks.");
					num = 1944191880;
					continue;
				case 7u:
					BedroomScene.smethod_26("Assets/Music/DanMasterFlash - Sun Funk", 0.4f);
					_phoneNag = new _dvyBDFOZwoBLf9qqHSfHYLLXVwP(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0);
					num = (int)((num2 * 359660346) ^ 0x5928AD32);
					continue;
				case 6u:
					BedroomScene.smethod_22((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Background", "Assets/Scenes/Bedroom/Photo frame", 496, 156, (string)null, 0, 0, "Thats Coby's Australian boyfriend Marty. Apparently he is making plans to visit sometime. I guess he understands my brother can't keep his pants on for that long.");
					BedroomScene.smethod_22((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Background", "Assets/Scenes/Bedroom/Poster", 96, 217, (string)null, 0, 0, "Coby's still got the hots for Marsupials after meeting his penpal. Apparently he was the thunder down under and then some.");
					BedroomScene.smethod_22((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Background", "Assets/Scenes/Bedroom/Con badges", 410, 310, (string)null, 0, 0, "Badges Coby has collected from going to cons.");
					num = (int)((num2 * 450279290) ^ 0x39F3FED);
					continue;
				case 5u:
					BedroomScene.smethod_22((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Background", "Assets/Scenes/Bedroom/Alarm clock", 672, 493, "Assets/Scenes/Bedroom/Alarm clock active", 672, 493, "Never something I used often myself, but it's been at least getting me up before noon.");
					num = ((int)num2 * -1867368157) ^ -1188370171;
					continue;
				case 2u:
					BedroomScene.smethod_22((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Background", "Assets/Scenes/Bedroom/Matress", -446, 447, (string)null, 0, 0, "My brother's bed. The springs are a little worn out but otherwise still leagues better than mine. If you're wondering why I'm sleeping here, it's for a fresher perspective. Everytime I look over at his corner of the bedroom from mine, I just think of them going at it.");
					num = 1766354334;
					continue;
				case 1u:
					BedroomScene.smethod_19((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Background", "Assets/Scenes/Bedroom/Closet", 1551, 112, (Action)OnClosetClick);
					num = ((int)num2 * -1032950414) ^ 0x3D873075;
					continue;
				case 0u:
					BedroomScene.smethod_22((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Background", "Assets/Scenes/Bedroom/Drawer", 531, 568, "Assets/Scenes/Bedroom/Drawer active", 454, 538, "It's a struggle just to get this thing open. Always keeping the emergency supply at arms' reach I guess.");
					num = (int)((num2 * 1886256037) ^ 0x53D90BE9);
					continue;
				default:
					return;
				case 4u:
					break;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	private void Reset()
	{
		if (BedroomScene.smethod_21(BedroomScene.smethod_20(), "Prologue") == 40)
		{
			goto IL_0014;
		}
		goto IL_005f;
		IL_005f:
		ResetFailedDates();
		ResetDeletedContacts();
		int num = 1752950668;
		goto IL_003e;
		IL_003e:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x552C0304u) % 4u)
			{
			case 3u:
				break;
			case 2u:
				BedroomScene.smethod_29(BedroomScene.smethod_28(BedroomScene.smethod_27((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)), "MessageTutorial1");
				num = (int)((num2 * 664688378) ^ 0x6040F689);
				continue;
			default:
				return;
			case 1u:
				goto IL_005f;
			case 0u:
				return;
			}
			break;
		}
		goto IL_0014;
		IL_0014:
		num = 452797918;
		goto IL_003e;
	}

	public override void StopCutscene()
	{
		Reset();
	}

	public void ResetFailedDates()
	{
		_opIJo2jLUqdOL5yAFP4yzXce0DG opIJo2jLUqdOL5yAFP4yzXce0DG_ = BedroomScene.smethod_20();
		while (true)
		{
			int num = -1455939360;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x855D6347u) % 24u)
				{
				case 23u:
					BedroomScene.smethod_34(BedroomScene.smethod_28(BedroomScene.smethod_27((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)), "AchievementGeneric4");
					num = (int)(num2 * 1223083346) ^ -859202002;
					continue;
				case 22u:
				{
					int num6;
					if (!BedroomScene.smethod_35(opIJo2jLUqdOL5yAFP4yzXce0DG_, "SkyeLeftClub"))
					{
						num = -1237039803;
						num6 = -1237039803;
					}
					else
					{
						num = -123309583;
						num6 = -123309583;
					}
					continue;
				}
				case 21u:
				{
					int num20;
					int num21;
					if (BedroomScene.smethod_21(opIJo2jLUqdOL5yAFP4yzXce0DG_, "LexDate") == 40)
					{
						num20 = 498475463;
						num21 = 498475463;
					}
					else
					{
						num20 = 1720562698;
						num21 = 1720562698;
					}
					num = num20 ^ ((int)num2 * -870156094);
					continue;
				}
				case 20u:
					BedroomScene.smethod_36(opIJo2jLUqdOL5yAFP4yzXce0DG_, _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Zenith);
					num = ((int)num2 * -258131677) ^ 0x1F363196;
					continue;
				case 19u:
				{
					int num19;
					if (!BedroomScene.smethod_35(opIJo2jLUqdOL5yAFP4yzXce0DG_, "RemyLeftClub"))
					{
						num = -584271290;
						num19 = -584271290;
					}
					else
					{
						num = -1186578393;
						num19 = -1186578393;
					}
					continue;
				}
				case 18u:
					BedroomScene.smethod_32(opIJo2jLUqdOL5yAFP4yzXce0DG_, "CobyLeftClub", bool_0: true);
					num = ((int)num2 * -1067584245) ^ 0x368F39BC;
					continue;
				case 17u:
				{
					int num10;
					if (!BedroomScene.smethod_35(opIJo2jLUqdOL5yAFP4yzXce0DG_, "SethLeftClub"))
					{
						num = -1933773271;
						num10 = -1933773271;
					}
					else
					{
						num = -1365131540;
						num10 = -1365131540;
					}
					continue;
				}
				case 16u:
					BedroomScene.smethod_36(opIJo2jLUqdOL5yAFP4yzXce0DG_, _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Seth);
					num = ((int)num2 * -1661200399) ^ -286624463;
					continue;
				case 15u:
				{
					int num5;
					if (BedroomScene.smethod_35(opIJo2jLUqdOL5yAFP4yzXce0DG_, "LexLeftClub"))
					{
						num = -1266314298;
						num5 = -1266314298;
					}
					else
					{
						num = -1900775596;
						num5 = -1900775596;
					}
					continue;
				}
				case 14u:
				{
					int num15;
					int num16;
					if (BedroomScene.smethod_21(opIJo2jLUqdOL5yAFP4yzXce0DG_, "ZenithDate") == 10)
					{
						num15 = -1218052861;
						num16 = -1218052861;
					}
					else
					{
						num15 = -181658118;
						num16 = -181658118;
					}
					num = num15 ^ (int)(num2 * 692240760);
					continue;
				}
				case 12u:
					BedroomScene.smethod_36(opIJo2jLUqdOL5yAFP4yzXce0DG_, _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Remy);
					num = (int)(num2 * 418778061) ^ -611679302;
					continue;
				case 11u:
					BedroomScene.smethod_36(opIJo2jLUqdOL5yAFP4yzXce0DG_, _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Skye);
					num = ((int)num2 * -289582216) ^ -609024211;
					continue;
				case 10u:
					BedroomScene.smethod_30(opIJo2jLUqdOL5yAFP4yzXce0DG_, _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Coby);
					BedroomScene.smethod_31(opIJo2jLUqdOL5yAFP4yzXce0DG_, "Prologue", 40);
					num = (int)((num2 * 1923206509) ^ 0x4A1210C7);
					continue;
				case 9u:
				{
					int num8;
					int num9;
					if (BedroomScene.smethod_21(opIJo2jLUqdOL5yAFP4yzXce0DG_, "LexDate") == 40)
					{
						num8 = 1239897960;
						num9 = 1239897960;
					}
					else
					{
						num8 = 254662663;
						num9 = 254662663;
					}
					num = num8 ^ (int)(num2 * 1610663251);
					continue;
				}
				case 8u:
				{
					int num22;
					int num23;
					if (BedroomScene.smethod_21(opIJo2jLUqdOL5yAFP4yzXce0DG_, "RemyPreDate") != 10)
					{
						num22 = -127748026;
						num23 = -127748026;
					}
					else
					{
						num22 = -964502357;
						num23 = -964502357;
					}
					num = num22 ^ ((int)num2 * -1935417040);
					continue;
				}
				case 7u:
				{
					int num17;
					int num18;
					if (BedroomScene.smethod_21(opIJo2jLUqdOL5yAFP4yzXce0DG_, "Prologue") != 30)
					{
						num17 = -1052394435;
						num18 = -1052394435;
					}
					else
					{
						num17 = -1830211641;
						num18 = -1830211641;
					}
					num = num17 ^ ((int)num2 * -1069647093);
					continue;
				}
				case 6u:
				{
					int num13;
					int num14;
					if (BedroomScene.smethod_21(opIJo2jLUqdOL5yAFP4yzXce0DG_, "SkyePreDate") != 10)
					{
						num13 = 983842371;
						num14 = 983842371;
					}
					else
					{
						num13 = 1190281026;
						num14 = 1190281026;
					}
					num = num13 ^ (int)(num2 * 1708010745);
					continue;
				}
				case 5u:
					BedroomScene.smethod_33(BedroomScene.smethod_28(BedroomScene.smethod_27((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)), _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Coby);
					num = ((int)num2 * -483165347) ^ 0x5430EE69;
					continue;
				case 4u:
					BedroomScene.smethod_36(opIJo2jLUqdOL5yAFP4yzXce0DG_, _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Lex);
					num = -1900775596;
					continue;
				case 3u:
				{
					int num11;
					int num12;
					if (BedroomScene.smethod_21(opIJo2jLUqdOL5yAFP4yzXce0DG_, "SethPreDate") != 10)
					{
						num11 = 1698103815;
						num12 = 1698103815;
					}
					else
					{
						num11 = 969907185;
						num12 = 969907185;
					}
					num = num11 ^ (int)(num2 * 1210278538);
					continue;
				}
				case 2u:
				{
					int num7;
					if (!BedroomScene.smethod_35(opIJo2jLUqdOL5yAFP4yzXce0DG_, "ZenithLeftClub"))
					{
						num = -1910304150;
						num7 = -1910304150;
					}
					else
					{
						num = -1282945559;
						num7 = -1282945559;
					}
					continue;
				}
				case 1u:
				{
					int num3;
					int num4;
					if (BedroomScene.smethod_21(opIJo2jLUqdOL5yAFP4yzXce0DG_, "LexPreDate") == 20)
					{
						num3 = -295721792;
						num4 = -295721792;
					}
					else
					{
						num3 = -475000387;
						num4 = -475000387;
					}
					num = num3 ^ (int)(num2 * 1236160379);
					continue;
				}
				default:
					return;
				case 0u:
					break;
				case 13u:
					return;
				}
				break;
			}
		}
	}

	private void ResetDeletedContacts()
	{
		_opIJo2jLUqdOL5yAFP4yzXce0DG opIJo2jLUqdOL5yAFP4yzXce0DG_ = BedroomScene.smethod_20();
		if (BedroomScene.smethod_38((Enum)BedroomScene.smethod_37(opIJo2jLUqdOL5yAFP4yzXce0DG_), (Enum)_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Coby))
		{
			goto IL_00e1;
		}
		goto IL_05ce;
		IL_05ce:
		int num;
		int num2;
		if (!BedroomScene.smethod_38((Enum)BedroomScene.smethod_37(opIJo2jLUqdOL5yAFP4yzXce0DG_), (Enum)_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Dustin))
		{
			num = -1105648189;
			num2 = -1105648189;
		}
		else
		{
			num = -1827287803;
			num2 = -1827287803;
		}
		goto IL_0521;
		IL_0521:
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num ^ 0xFCC71A9Bu) % 35u)
			{
			case 34u:
				break;
			case 33u:
				BedroomScene.smethod_39(opIJo2jLUqdOL5yAFP4yzXce0DG_, "Remy", bool_0: true);
				BedroomScene.smethod_39(opIJo2jLUqdOL5yAFP4yzXce0DG_, "Rip.", bool_0: true);
				BedroomScene.smethod_39(opIJo2jLUqdOL5yAFP4yzXce0DG_, "Chef.", bool_0: true);
				BedroomScene.smethod_39(opIJo2jLUqdOL5yAFP4yzXce0DG_, "Strip.", bool_0: true);
				num = ((int)num3 * -905920649) ^ 0x40C83364;
				continue;
			case 32u:
				BedroomScene.smethod_31(opIJo2jLUqdOL5yAFP4yzXce0DG_, "MercyDate", 10);
				BedroomScene.smethod_39(opIJo2jLUqdOL5yAFP4yzXce0DG_, "Mercy", bool_0: true);
				num = ((int)num3 * -603772875) ^ -1517501637;
				continue;
			case 31u:
				goto end_IL_0521;
			case 30u:
				BedroomScene.smethod_39(opIJo2jLUqdOL5yAFP4yzXce0DG_, "Dustin", bool_0: true);
				num = (int)(num3 * 1523908147) ^ -1318623811;
				continue;
			case 28u:
				BedroomScene.smethod_31(opIJo2jLUqdOL5yAFP4yzXce0DG_, "SethPreDate", 10);
				num = ((int)num3 * -1558522242) ^ -1905884089;
				continue;
			case 27u:
				BedroomScene.smethod_31(opIJo2jLUqdOL5yAFP4yzXce0DG_, "SethDate", 10);
				BedroomScene.smethod_39(opIJo2jLUqdOL5yAFP4yzXce0DG_, "Seth", bool_0: true);
				num = (int)((num3 * 389931556) ^ 0x406132);
				continue;
			case 26u:
				BedroomScene.smethod_31(opIJo2jLUqdOL5yAFP4yzXce0DG_, "MercyPreDate", 10);
				num = ((int)num3 * -1475049199) ^ 0x1C36EA3E;
				continue;
			case 25u:
				BedroomScene.smethod_31(opIJo2jLUqdOL5yAFP4yzXce0DG_, "RemyDate", 10);
				num = ((int)num3 * -1944106790) ^ 0x5CBCCFEC;
				continue;
			case 24u:
				goto IL_0197;
			case 23u:
				BedroomScene.smethod_39(opIJo2jLUqdOL5yAFP4yzXce0DG_, "Zenith", bool_0: true);
				num = ((int)num3 * -288509917) ^ 0x532C8358;
				continue;
			case 22u:
				BedroomScene.smethod_31(opIJo2jLUqdOL5yAFP4yzXce0DG_, "SkyePreDate", 10);
				num = ((int)num3 * -1595908989) ^ -1105248937;
				continue;
			case 21u:
				BedroomScene.smethod_39(opIJo2jLUqdOL5yAFP4yzXce0DG_, "Jax", bool_0: true);
				BedroomScene.smethod_39(opIJo2jLUqdOL5yAFP4yzXce0DG_, "SimpleOrder", bool_0: false);
				num = (int)(num3 * 344636902) ^ -95735681;
				continue;
			case 19u:
				BedroomScene.smethod_31(opIJo2jLUqdOL5yAFP4yzXce0DG_, "ZenithDate", 10);
				num = (int)(num3 * 681705864) ^ -53807112;
				continue;
			case 18u:
				goto IL_0256;
			case 17u:
				goto IL_028a;
			case 16u:
				BedroomScene.smethod_31(opIJo2jLUqdOL5yAFP4yzXce0DG_, "JaxDate", 10);
				num = (int)(num3 * 973375090) ^ -12360687;
				continue;
			case 15u:
				BedroomScene.smethod_39(opIJo2jLUqdOL5yAFP4yzXce0DG_, "Lex", bool_0: true);
				num = (int)((num3 * 102302126) ^ 0x48076740);
				continue;
			case 14u:
				BedroomScene.smethod_31(opIJo2jLUqdOL5yAFP4yzXce0DG_, "SkyeDate", 10);
				num = ((int)num3 * -1773626045) ^ 0x33DFC5FB;
				continue;
			case 13u:
				goto IL_031e;
			case 12u:
				BedroomScene.smethod_39(opIJo2jLUqdOL5yAFP4yzXce0DG_, "First_Dustin_", bool_0: true);
				num = ((int)num3 * -660870025) ^ 0x424405B7;
				continue;
			case 11u:
				BedroomScene.smethod_31(opIJo2jLUqdOL5yAFP4yzXce0DG_, "RemyPreDate", 10);
				num = (int)(num3 * 1666119868) ^ -1238061525;
				continue;
			case 10u:
				goto IL_0392;
			case 9u:
				BedroomScene.smethod_31(opIJo2jLUqdOL5yAFP4yzXce0DG_, "DustinDate", 10);
				num = (int)((num3 * 728166175) ^ 0x399CC374);
				continue;
			case 8u:
				BedroomScene.smethod_39(opIJo2jLUqdOL5yAFP4yzXce0DG_, "Club_Dustin_", bool_0: true);
				num = ((int)num3 * -1438548766) ^ 0x4003D675;
				continue;
			case 7u:
				BedroomScene.smethod_31(opIJo2jLUqdOL5yAFP4yzXce0DG_, "ZenithPreDate", 10);
				num = (int)(num3 * 1438725942) ^ -610902071;
				continue;
			case 6u:
				goto IL_0429;
			case 5u:
				BedroomScene.smethod_30(opIJo2jLUqdOL5yAFP4yzXce0DG_, _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Coby);
				num = (int)(num3 * 1555635665) ^ -1962521735;
				continue;
			case 4u:
				BedroomScene.smethod_39(opIJo2jLUqdOL5yAFP4yzXce0DG_, "Player.Dork", bool_0: false);
				num = ((int)num3 * -1745470462) ^ -1755588322;
				continue;
			case 3u:
				BedroomScene.smethod_31(opIJo2jLUqdOL5yAFP4yzXce0DG_, "CobyDate", 10);
				BedroomScene.smethod_39(opIJo2jLUqdOL5yAFP4yzXce0DG_, "Coby", bool_0: true);
				num = (int)((num3 * 280444523) ^ 0x74D7DE45);
				continue;
			case 2u:
				BedroomScene.smethod_31(opIJo2jLUqdOL5yAFP4yzXce0DG_, "LexPreDate", 10);
				BedroomScene.smethod_31(opIJo2jLUqdOL5yAFP4yzXce0DG_, "LexDate", 10);
				num = (int)(num3 * 968314929) ^ -489259615;
				continue;
			case 1u:
				BedroomScene.smethod_31(opIJo2jLUqdOL5yAFP4yzXce0DG_, "JaxPreDate", 10);
				num = ((int)num3 * -516845257) ^ -943532768;
				continue;
			case 0u:
				BedroomScene.smethod_39(opIJo2jLUqdOL5yAFP4yzXce0DG_, "Skye", bool_0: true);
				num = ((int)num3 * -1671705431) ^ -2047223522;
				continue;
			case 20u:
				goto IL_05ce;
			default:
				BedroomScene.smethod_40(opIJo2jLUqdOL5yAFP4yzXce0DG_);
				return;
			}
			int num4;
			if (!BedroomScene.smethod_38((Enum)BedroomScene.smethod_37(opIJo2jLUqdOL5yAFP4yzXce0DG_), (Enum)_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Remy))
			{
				num = -361138627;
				num4 = -361138627;
			}
			else
			{
				num = -378836226;
				num4 = -378836226;
			}
			continue;
			IL_0429:
			int num5;
			if (BedroomScene.smethod_38((Enum)BedroomScene.smethod_37(opIJo2jLUqdOL5yAFP4yzXce0DG_), (Enum)_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Seth))
			{
				num = -1966775978;
				num5 = -1966775978;
			}
			else
			{
				num = -16079590;
				num5 = -16079590;
			}
			continue;
			IL_028a:
			int num6;
			if (BedroomScene.smethod_38((Enum)BedroomScene.smethod_37(opIJo2jLUqdOL5yAFP4yzXce0DG_), (Enum)_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Mercy))
			{
				num = -444900515;
				num6 = -444900515;
			}
			else
			{
				num = -988986332;
				num6 = -988986332;
			}
			continue;
			IL_0197:
			int num7;
			if (BedroomScene.smethod_38((Enum)BedroomScene.smethod_37(opIJo2jLUqdOL5yAFP4yzXce0DG_), (Enum)_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Jax))
			{
				num = -1212699664;
				num7 = -1212699664;
			}
			else
			{
				num = -1255633573;
				num7 = -1255633573;
			}
			continue;
			IL_0392:
			int num8;
			if (BedroomScene.smethod_38((Enum)BedroomScene.smethod_37(opIJo2jLUqdOL5yAFP4yzXce0DG_), (Enum)_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Lex))
			{
				num = -1775062750;
				num8 = -1775062750;
			}
			else
			{
				num = -2034893700;
				num8 = -2034893700;
			}
			continue;
			IL_031e:
			int num9;
			if (!BedroomScene.smethod_38((Enum)BedroomScene.smethod_37(opIJo2jLUqdOL5yAFP4yzXce0DG_), (Enum)_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Zenith))
			{
				num = -424584095;
				num9 = -424584095;
			}
			else
			{
				num = -799276869;
				num9 = -799276869;
			}
			continue;
			IL_0256:
			int num10;
			if (BedroomScene.smethod_38((Enum)BedroomScene.smethod_37(opIJo2jLUqdOL5yAFP4yzXce0DG_), (Enum)_opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts.Skye))
			{
				num = -241186448;
				num10 = -241186448;
			}
			else
			{
				num = -945434623;
				num10 = -945434623;
			}
			continue;
			end_IL_0521:
			break;
		}
		goto IL_00e1;
		IL_00e1:
		num = -2138101341;
		goto IL_0521;
	}

	public override void Update(GameTime gameTime)
	{
		_tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime);
		_phoneNag._tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime);
	}

	public override void End()
	{
		this.method_3();
		_phoneNag._tO46aYSBLFIuhFNlhbrAeWbFDSf();
	}

	private void OnClosetClick()
	{
		BedroomScene.smethod_41(BedroomScene.smethod_27((_7UlnfykmEmZDFt3BmCKZekI43Ih)this), "Clothes");
	}

	private void OnDoorClick()
	{
		if (BedroomScene.smethod_21(BedroomScene.smethod_20(), "Prologue") >= 40)
		{
			while (true)
			{
				int num = 24200531;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7BFFF346u) % 4u)
					{
					case 1u:
						BedroomScene.smethod_27((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._k9wUPeU1Ga7cygiuGP8TT6aPLWF<LivingRoomScene>();
						num = (int)((num2 * 1036688521) ^ 0x44B49D0C);
						continue;
					case 0u:
						break;
					case 3u:
						return;
					default:
						goto end_IL_004f;
					}
					break;
				}
				continue;
				end_IL_004f:
				break;
			}
		}
		BedroomScene.smethod_41(BedroomScene.smethod_27((_7UlnfykmEmZDFt3BmCKZekI43Ih)this), "Prologue");
	}

	static _uqydQVaCmCvK7zzWs5W4gZFpKBu smethod_18(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0, string string_0, string string_1, int int_0, int int_1)
	{
		return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._0O8D0mBgmrh0sLOGcLVvGNOHKLCA(string_0, string_1, int_0, int_1);
	}

	static _z20t8IpBINiJtljSeTIkNoKUOkx smethod_19(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0, string string_0, string string_1, int int_0, int int_1, Action action_0)
	{
		return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._2CHUZ5vSi5NbJYJ4gGtr3C2VVEo(string_0, string_1, int_0, int_1, action_0);
	}

	static _opIJo2jLUqdOL5yAFP4yzXce0DG smethod_20()
	{
		return _Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t();
	}

	static int smethod_21(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0, string string_0)
	{
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._fvTKDuNATrUxfXZVvltePz3vYkK(string_0);
	}

	static _x1wxbalqqw8qtEqHC1UaGdv59Od smethod_22(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0, string string_0, string string_1, int int_0, int int_1, string string_2, int int_2, int int_3, string string_3)
	{
		return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._2VwdavpaoNVxohFKsz1eYBmnxyh(string_0, string_1, int_0, int_1, string_2, int_2, int_3, string_3);
	}

	static bool smethod_23()
	{
		return _iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF;
	}

	static _wRd4nHuQQlAPEwrHOGkBfut6Uip smethod_24(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		return _JbeCmOie0phb2cbgG6DdGZrbs3pB_0._vsceSzSIjBy2nZrCxAzKZbUiwLq;
	}

	static void smethod_25(_wRd4nHuQQlAPEwrHOGkBfut6Uip _wRd4nHuQQlAPEwrHOGkBfut6Uip_0, int int_0, int int_1, int int_2, int int_3)
	{
		_wRd4nHuQQlAPEwrHOGkBfut6Uip_0._wFfc7xL7eKxed7i9gWtao7pgsnm(int_0, int_1, int_2, int_3);
	}

	static void smethod_26(string string_0, float float_0)
	{
		_UmxbIbk7pgaod0bD7pS309P3Lns._l94kUraQ13OohoVwwxKC37hG7Pc(string_0, float_0);
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
		_691ooXdgg17CWFkMkjedKBBBfYw_0._0Y1BTbSbP9IopfJXfeA4x02PifL(string_0);
	}

	static void smethod_30(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0, _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts ephoneContacts_0)
	{
		_opIJo2jLUqdOL5yAFP4yzXce0DG_0._modEEaw3I1w8Mt0usyRNoa4Ri0H(ephoneContacts_0);
	}

	static void smethod_31(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0, string string_0, int int_0)
	{
		_opIJo2jLUqdOL5yAFP4yzXce0DG_0._fPyIv5zbbSj5sjZlbAwQTFXnJ5G(string_0, int_0);
	}

	static void smethod_32(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0, string string_0, bool bool_0)
	{
		_opIJo2jLUqdOL5yAFP4yzXce0DG_0._4Fscz8ryB3hm0NmL5xw39HHiPd1(string_0, bool_0);
	}

	static void smethod_33(_691ooXdgg17CWFkMkjedKBBBfYw _691ooXdgg17CWFkMkjedKBBBfYw_0, _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts ephoneContacts_0)
	{
		_691ooXdgg17CWFkMkjedKBBBfYw_0._rGMDL1kMYXSwaZiIoINCo5AqZuM(ephoneContacts_0);
	}

	static void smethod_34(_691ooXdgg17CWFkMkjedKBBBfYw _691ooXdgg17CWFkMkjedKBBBfYw_0, string string_0)
	{
		_691ooXdgg17CWFkMkjedKBBBfYw_0._vVZVLriSGPExpn1KeobglMabsoi(string_0);
	}

	static bool smethod_35(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0, string string_0)
	{
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._Oms9lumBodLGrGZ09YJaEuzmlAf(string_0);
	}

	static void smethod_36(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0, _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts ephoneContacts_0)
	{
		_opIJo2jLUqdOL5yAFP4yzXce0DG_0._Qd7anWdHpZ5AgaUbbEv07BnnI6Q(ephoneContacts_0);
	}

	static _opIJo2jLUqdOL5yAFP4yzXce0DG.EPhoneContacts smethod_37(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._uVBbxOT5AbKoffINIsfdTnEGd3xA;
	}

	static bool smethod_38(Enum enum_0, Enum enum_1)
	{
		return enum_0.HasFlag(enum_1);
	}

	static void smethod_39(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0, string string_0, bool bool_0)
	{
		_opIJo2jLUqdOL5yAFP4yzXce0DG_0._aedbmRW9PZZduyLA3PVVHtafNAGA(string_0, bool_0);
	}

	static void smethod_40(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		_opIJo2jLUqdOL5yAFP4yzXce0DG_0._Xwcp3PcmrSeqc3MSVH0tfLbcwXA();
	}

	void method_3()
	{
		base._tO46aYSBLFIuhFNlhbrAeWbFDSf();
	}

	static void smethod_41(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0, string string_0)
	{
		_JbeCmOie0phb2cbgG6DdGZrbs3pB_0._xyl3Tv5KdR5eezDgagxbBcS3cwt(string_0);
	}
}
