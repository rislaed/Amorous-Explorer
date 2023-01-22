using System;
using Amorous.Game.NPC;

namespace Amorous.Game.Scenes;

public class ClubEntranceScene : _7UlnfykmEmZDFt3BmCKZekI43Ih
{
	private KaneNPC _kane;

	private _3IHp43rpkJgOBcY9lrIrwMuwWve _kaneLayer;

	public ClubEntranceScene(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		_opIJo2jLUqdOL5yAFP4yzXce0DG opIJo2jLUqdOL5yAFP4yzXce0DG_ = default(_opIJo2jLUqdOL5yAFP4yzXce0DG);
		while (true)
		{
			int num = -1232202995;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFE534442u) % 11u)
				{
				case 10u:
					ClubEntranceScene.smethod_14((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Rope Back", "Assets/Scenes/ClubEntrance/Club Front Ropes (behind)", -535, 0);
					num = (int)((num2 * 1311701399) ^ 0x20698A50);
					continue;
				case 9u:
					ClubEntranceScene.smethod_18(ClubEntranceScene.smethod_17(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0), -535, 535, 0, 0);
					num = (int)((num2 * 697501499) ^ 0x5C8B1E8B);
					continue;
				case 8u:
					_poenyHBGUusBcnNcTFB9MQBV72R._kf3EbE0B70xGe1szklqAZyCqoLj = true;
					num = (int)(num2 * 1792778721) ^ -1749390244;
					continue;
				case 7u:
					ClubEntranceScene.smethod_19(_KZ7hNP1K5E99Xfup1lTZ9UDrxPE._oCy13KHJxLHriH7TwMiQ1qKJ8Uc, 0.4f, bool_0: true, bool_1: true);
					opIJo2jLUqdOL5yAFP4yzXce0DG_ = ClubEntranceScene.smethod_20();
					num = ((int)num2 * -1741445963) ^ -516687160;
					continue;
				case 5u:
					ClubEntranceScene.smethod_14((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Background", "Assets/Scenes/ClubEntrance/Club Front", -535, 0);
					num = (int)(num2 * 1881360938) ^ -135237582;
					continue;
				case 4u:
					ClubEntranceScene.smethod_14((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Rope Front", "Assets/Scenes/ClubEntrance/Club Front Ropes (infront)", -535, 0);
					num = ((int)num2 * -591594063) ^ -1050660732;
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (ClubEntranceScene.smethod_21(opIJo2jLUqdOL5yAFP4yzXce0DG_, "Prologue") < 20)
					{
						num3 = 1930675680;
						num4 = 1930675680;
					}
					else
					{
						num3 = 914657534;
						num4 = 914657534;
					}
					num = num3 ^ ((int)num2 * -1008542046);
					continue;
				}
				case 1u:
					ClubEntranceScene.smethod_16((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Entrance", "Assets/Scenes/ClubEntrance/Club Entrance Door Selectable", 410, 96, (Action)OnDoorClick);
					ClubEntranceScene.smethod_16((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Club Back", "Assets/Scenes/ClubEntrance/Back of Club Selectable", -535, 0, (Action)OnClubBackClick);
					num = ((int)num2 * -1961955718) ^ 0x297FC6F;
					continue;
				case 0u:
					ClubEntranceScene.smethod_15((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Lights", -535, 0, 500, new string[2] { "Assets/Scenes/ClubEntrance/Club Front Glow (option one)", "Assets/Scenes/ClubEntrance/Club Front Glow (option two)" });
					num = (int)(num2 * 828320904) ^ -480263842;
					continue;
				default:
					return;
				case 6u:
					break;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	public override void Start()
	{
		_kane = ClubEntranceScene.smethod_22((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<KaneNPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Background);
		_3IHp43rpkJgOBcY9lrIrwMuwWve _3IHp43rpkJgOBcY9lrIrwMuwWve2 = default(_3IHp43rpkJgOBcY9lrIrwMuwWve);
		_3IHp43rpkJgOBcY9lrIrwMuwWve _3IHp43rpkJgOBcY9lrIrwMuwWve = default(_3IHp43rpkJgOBcY9lrIrwMuwWve);
		ClubEntranceCNPC clubEntranceCNPC = default(ClubEntranceCNPC);
		ClubEntranceDNPC clubEntranceDNPC = default(ClubEntranceDNPC);
		ClubEntranceABNPC clubEntranceABNPC = default(ClubEntranceABNPC);
		while (true)
		{
			int num = 189674090;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x26866470u) % 16u)
				{
				case 15u:
					_3IHp43rpkJgOBcY9lrIrwMuwWve2._VNgmwYSLsJyyiR6cPQ35UHJBR4d = 1;
					num = ((int)num2 * -1975458355) ^ 0x7697ACA5;
					continue;
				case 13u:
					_3IHp43rpkJgOBcY9lrIrwMuwWve._VNgmwYSLsJyyiR6cPQ35UHJBR4d = 1;
					num = ((int)num2 * -891318629) ^ -19762486;
					continue;
				case 12u:
				{
					_3IHp43rpkJgOBcY9lrIrwMuwWve _3IHp43rpkJgOBcY9lrIrwMuwWve3 = _VvFE2zgy4FbDjvaEvb67tXJ7aRm<ClubEntranceABNPC>();
					_3IHp43rpkJgOBcY9lrIrwMuwWve3._VNgmwYSLsJyyiR6cPQ35UHJBR4d = 1;
					clubEntranceCNPC = ClubEntranceScene.smethod_22((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubEntranceCNPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Background);
					num = (int)((num2 * 1019694872) ^ 0x621C6F57);
					continue;
				}
				case 11u:
					clubEntranceDNPC = ClubEntranceScene.smethod_22((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubEntranceDNPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Background);
					clubEntranceDNPC._tDFvus0ZCanjp81eOiDzoMXJiuf(ClubStaticNPC.EPoses.Nude);
					clubEntranceDNPC._09vxUzgOn7J7DFZEwsTh7lgEIhB(ClubStaticNPC.EClothes.Pants, ClubStaticNPC.EClothes.Shirt);
					num = (int)((num2 * 325193454) ^ 0x1E4185A8);
					continue;
				case 10u:
					_kaneLayer = _VvFE2zgy4FbDjvaEvb67tXJ7aRm<KaneNPC>();
					num = (int)((num2 * 1696317952) ^ 0x23A60793);
					continue;
				case 9u:
					clubEntranceABNPC._09vxUzgOn7J7DFZEwsTh7lgEIhB(ClubStaticNPC.EClothes.Pants, ClubStaticNPC.EClothes.Shirt);
					ClubEntranceScene.smethod_24((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubEntranceABNPC, -325f);
					ClubEntranceScene.smethod_25((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubEntranceABNPC, 300f);
					num = ((int)num2 * -423066818) ^ 0x23370752;
					continue;
				case 8u:
					ClubEntranceScene.smethod_25((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubEntranceCNPC, 205f);
					num = ((int)num2 * -350169654) ^ 0x16D3AA1B;
					continue;
				case 7u:
					clubEntranceCNPC._tDFvus0ZCanjp81eOiDzoMXJiuf(ClubStaticNPC.EPoses.Nude);
					clubEntranceCNPC._09vxUzgOn7J7DFZEwsTh7lgEIhB(ClubStaticNPC.EClothes.Pants, ClubStaticNPC.EClothes.Shirt);
					num = (int)((num2 * 46999799) ^ 0x283AF501);
					continue;
				case 5u:
					_3IHp43rpkJgOBcY9lrIrwMuwWve2 = _VvFE2zgy4FbDjvaEvb67tXJ7aRm<ClubEntranceDNPC>();
					num = (int)((num2 * 274484111) ^ 0x2DCAEE14);
					continue;
				case 4u:
					clubEntranceABNPC = ClubEntranceScene.smethod_22((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubEntranceABNPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Background);
					clubEntranceABNPC._tDFvus0ZCanjp81eOiDzoMXJiuf(ClubStaticNPC.EPoses.Nude);
					num = ((int)num2 * -1168756532) ^ 0x35ECF6B9;
					continue;
				case 3u:
					ClubEntranceScene.smethod_23(_kaneLayer, (Action)delegate
					{
						_kaneLayer._ac2H6kMdrgPhXXxabsikjji4SiT = 1;
						while (true)
						{
							int num3 = -1287105468;
							while (true)
							{
								uint num4;
								switch ((num4 = (uint)num3 ^ 0xAC46E1DCu) % 7u)
								{
								case 6u:
									ClubEntranceScene.smethod_30((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)_kane, bool_0: false);
									num3 = ((int)num4 * -1327693077) ^ 0x3F62E3D2;
									continue;
								case 4u:
									_kaneLayer._VNgmwYSLsJyyiR6cPQ35UHJBR4d = 0;
									num3 = (int)(num4 * 486558849) ^ -1984461864;
									continue;
								case 3u:
									_kane._09vxUzgOn7J7DFZEwsTh7lgEIhB(KaneNPC.EClothes.Shirt, KaneNPC.EClothes.Shorts);
									ClubEntranceScene.smethod_24((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)_kane, -25f);
									ClubEntranceScene.smethod_25((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)_kane, 180f);
									num3 = (int)(num4 * 1543687581) ^ -2069020883;
									continue;
								case 1u:
									_kane._g3oEqGBkN3YHUPosRq2nIP2sX0D(KaneNPC.EHeads.Angry);
									_kane._tDFvus0ZCanjp81eOiDzoMXJiuf(KaneNPC.EPoses.Stern);
									num3 = ((int)num4 * -1000646547) ^ -436107241;
									continue;
								case 0u:
									ClubEntranceScene.smethod_31((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)_kane, 0.4f);
									ClubEntranceScene.smethod_26((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)_kane, (Action)OnKaneClick);
									num3 = ((int)num4 * -509039476) ^ 0x690A4795;
									continue;
								case 2u:
									break;
								default:
									ClubEntranceScene.smethod_28((_7UlnfykmEmZDFt3BmCKZekI43Ih)this);
									return;
								}
								break;
							}
						}
					});
					num = ((int)num2 * -1276647914) ^ -1807430410;
					continue;
				case 2u:
					ClubEntranceScene.smethod_24((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubEntranceDNPC, 1930f);
					num = (int)(num2 * 1262658405) ^ -695640197;
					continue;
				case 1u:
					ClubEntranceScene.smethod_25((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubEntranceDNPC, 255f);
					_3IHp43rpkJgOBcY9lrIrwMuwWve = _VvFE2zgy4FbDjvaEvb67tXJ7aRm<ClubEntranceCNPC>();
					num = (int)(num2 * 1263601491) ^ -1511955394;
					continue;
				case 0u:
					ClubEntranceScene.smethod_24((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubEntranceCNPC, 1630f);
					num = (int)(num2 * 192614281) ^ -1418308264;
					continue;
				default:
					return;
				case 14u:
					break;
				case 6u:
					return;
				}
				break;
			}
		}
	}

	private void OnDoorClick()
	{
		ClubEntranceScene.smethod_22((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._k9wUPeU1Ga7cygiuGP8TT6aPLWF<ClubInsideScene>();
	}

	private void OnClubBackClick()
	{
		ClubEntranceScene.smethod_22((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._k9wUPeU1Ga7cygiuGP8TT6aPLWF<ClubBackScene>();
	}

	private void OnKaneClick()
	{
		_kaneLayer._ac2H6kMdrgPhXXxabsikjji4SiT = 3;
		while (true)
		{
			int num = 643231515;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4B70D049u) % 5u)
				{
				case 4u:
					ClubEntranceScene.smethod_29(ClubEntranceScene.smethod_22((_7UlnfykmEmZDFt3BmCKZekI43Ih)this), "Kane");
					num = (int)((num2 * 539605991) ^ 0x78674437);
					continue;
				case 3u:
					ClubEntranceScene.smethod_26((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)_kane, (Action)null);
					ClubEntranceScene.smethod_27((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)_kane, bool_0: false);
					ClubEntranceScene.smethod_28((_7UlnfykmEmZDFt3BmCKZekI43Ih)this);
					num = ((int)num2 * -1293178336) ^ 0x4835C493;
					continue;
				case 2u:
					_kaneLayer._VNgmwYSLsJyyiR6cPQ35UHJBR4d = 0;
					num = (int)(num2 * 1689893163) ^ -496617472;
					continue;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
			}
		}
	}

	static _uqydQVaCmCvK7zzWs5W4gZFpKBu smethod_14(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0, string string_0, string string_1, int int_0, int int_1)
	{
		return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._0O8D0mBgmrh0sLOGcLVvGNOHKLCA(string_0, string_1, int_0, int_1);
	}

	static _kxm3yIqio0baXT5t5vOHBAEdviB smethod_15(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0, string string_0, int int_0, int int_1, int int_2, string[] string_1)
	{
		return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._qCH6LFVbWcTfZTRElH4N91FiGeM(string_0, int_0, int_1, int_2, string_1);
	}

	static _z20t8IpBINiJtljSeTIkNoKUOkx smethod_16(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0, string string_0, string string_1, int int_0, int int_1, Action action_0)
	{
		return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._2CHUZ5vSi5NbJYJ4gGtr3C2VVEo(string_0, string_1, int_0, int_1, action_0);
	}

	static _wRd4nHuQQlAPEwrHOGkBfut6Uip smethod_17(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		return _JbeCmOie0phb2cbgG6DdGZrbs3pB_0._vsceSzSIjBy2nZrCxAzKZbUiwLq;
	}

	static void smethod_18(_wRd4nHuQQlAPEwrHOGkBfut6Uip _wRd4nHuQQlAPEwrHOGkBfut6Uip_0, int int_0, int int_1, int int_2, int int_3)
	{
		_wRd4nHuQQlAPEwrHOGkBfut6Uip_0._wFfc7xL7eKxed7i9gWtao7pgsnm(int_0, int_1, int_2, int_3);
	}

	static void smethod_19(string[] string_0, float float_0, bool bool_0, bool bool_1)
	{
		_UmxbIbk7pgaod0bD7pS309P3Lns._QrgbXEg7MMeD9Ybz12fFVsbmAd9(string_0, float_0, bool_0, bool_1);
	}

	static _opIJo2jLUqdOL5yAFP4yzXce0DG smethod_20()
	{
		return _Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t();
	}

	static int smethod_21(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0, string string_0)
	{
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._fvTKDuNATrUxfXZVvltePz3vYkK(string_0);
	}

	static _JbeCmOie0phb2cbgG6DdGZrbs3pB smethod_22(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0)
	{
		return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._ZzBuoSDMWwerejOO9Goyv2OCKgE;
	}

	static void smethod_23(_3IHp43rpkJgOBcY9lrIrwMuwWve _3IHp43rpkJgOBcY9lrIrwMuwWve_0, Action action_0)
	{
		_3IHp43rpkJgOBcY9lrIrwMuwWve_0._64JjsghBPDjZ1OxZwhO8Y6dFE5t = action_0;
	}

	static void smethod_24(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, float float_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_7Xn1C5tjYnmIif1iZKV8AWsEEbL = float_0;
	}

	static void smethod_25(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, float float_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_bCjZ3VSXGKyhmykd2zCnQBiSpDf = float_0;
	}

	static void smethod_26(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, Action action_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._ZVpZ5Oing5kbbVhbmbOHyrofGH7 = action_0;
	}

	static void smethod_27(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, bool bool_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._IvIFs0Tl6RHdTn3daJXsNCXCNyO = bool_0;
	}

	static void smethod_28(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0)
	{
		_7UlnfykmEmZDFt3BmCKZekI43Ih_0._yMMFQ2n4dqXlB1AEzmdkoKkPkX5();
	}

	static void smethod_29(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0, string string_0)
	{
		_JbeCmOie0phb2cbgG6DdGZrbs3pB_0._xyl3Tv5KdR5eezDgagxbBcS3cwt(string_0);
	}

	static void smethod_30(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, bool bool_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._zkHMlDFkja4TqmjdlHuZRCj8FCB = bool_0;
	}

	static void smethod_31(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, float float_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._fO7gSlrDDNMoHR4FO5QXAq8fUyA = float_0;
	}
}
