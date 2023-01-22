using System;
using Amorous.Game.NPC;

namespace Amorous.Game.Scenes;

public class ClubUpstairsScene : _7UlnfykmEmZDFt3BmCKZekI43Ih
{
	private const int OFFSET_LEFT = -1295;

	private RoseWoodNPC _roseWood;

	private ClubStaticZenithNPC _zenith;

	private readonly bool _showZenith;

	public ClubUpstairsScene(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		ClubUpstairsScene.smethod_14((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Background", "Assets/Scenes/ClubUpstairs/Upstairs Hall main", -1295, 0);
		ClubUpstairsScene.smethod_15((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Elevator", "Assets/Scenes/ClubUpstairs/Elevator Door Selectable", -919, 103, (Action)OnDownstairsClick);
		ClubUpstairsScene.smethod_15((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Stairs", "Assets/Scenes/ClubUpstairs/Staircase Selectable", -245, 20, (Action)OnDownstairsClick);
		ClubUpstairsScene.smethod_15((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Door", "Assets/Scenes/ClubUpstairs/Pool Door Selectable", 2533, 0, (Action)OnDoorClick);
		ClubUpstairsScene.smethod_17(ClubUpstairsScene.smethod_16(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0), -1295, 1295, 0, 0);
		ClubUpstairsScene.smethod_18(_KZ7hNP1K5E99Xfup1lTZ9UDrxPE._oCy13KHJxLHriH7TwMiQ1qKJ8Uc, 0.4f, bool_0: true, bool_1: true);
		_opIJo2jLUqdOL5yAFP4yzXce0DG opIJo2jLUqdOL5yAFP4yzXce0DG_ = ClubUpstairsScene.smethod_19();
		_showZenith = !ClubUpstairsScene.smethod_20(opIJo2jLUqdOL5yAFP4yzXce0DG_, "ZenithLeftClub");
		if (_showZenith)
		{
			ClubUpstairsScene.smethod_14((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Shadow", "Assets/Scenes/ClubUpstairs/ShadowZenith", 540, 712);
			ClubUpstairsScene.smethod_14((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Shadow", "Assets/Scenes/ClubUpstairs/ShadowRose", 930, 700);
		}
	}

	public override void Start()
	{
		if (!_showZenith)
		{
			return;
		}
		while (true)
		{
			int num = 979570115;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5EAD7276u) % 10u)
				{
				case 9u:
					_roseWood = ClubUpstairsScene.smethod_21((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<RoseWoodNPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Background);
					ClubUpstairsScene.smethod_22((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)_roseWood, bool_0: false);
					_roseWood._g3oEqGBkN3YHUPosRq2nIP2sX0D(RoseWoodNPC.EHeads.None);
					_roseWood._tDFvus0ZCanjp81eOiDzoMXJiuf(RoseWoodNPC.EPoses.Standing);
					num = ((int)num2 * -13411397) ^ -1124735854;
					continue;
				case 7u:
					ClubUpstairsScene.smethod_24((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)_zenith, 10f);
					ClubUpstairsScene.smethod_27((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)_zenith, (Action)OnZenithClick);
					num = ((int)num2 * -130006595) ^ -1447660108;
					continue;
				case 6u:
					_zenith = ClubUpstairsScene.smethod_21((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubStaticZenithNPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Foreground);
					num = (int)(num2 * 2015590612) ^ -864012116;
					continue;
				case 5u:
					_roseWood._09vxUzgOn7J7DFZEwsTh7lgEIhB(RoseWoodNPC.EClothes.Shirt, RoseWoodNPC.EClothes.Shorts);
					ClubUpstairsScene.smethod_23((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)_roseWood, 950f);
					num = (int)(num2 * 1724338127) ^ -486474888;
					continue;
				case 4u:
					ClubUpstairsScene.smethod_26((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)_roseWood, bool_0: true);
					num = (int)(num2 * 829587640) ^ -822864282;
					continue;
				case 3u:
					ClubUpstairsScene.smethod_24((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)_roseWood, 160f);
					num = (int)(num2 * 2007485741) ^ -1712133283;
					continue;
				case 2u:
					ClubUpstairsScene.smethod_23((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)_zenith, 580f);
					num = ((int)num2 * -2097942095) ^ -700866219;
					continue;
				case 0u:
					ClubUpstairsScene.smethod_25((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)_roseWood, 0.4f);
					num = (int)((num2 * 1753707268) ^ 0x1DC8664);
					continue;
				default:
					return;
				case 8u:
					break;
				case 1u:
					return;
				}
				break;
			}
		}
	}

	private void OnDoorClick()
	{
		ClubUpstairsScene.smethod_21((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._k9wUPeU1Ga7cygiuGP8TT6aPLWF<ClubPoolScene>();
	}

	private void OnDownstairsClick()
	{
		ClubUpstairsScene.smethod_21((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._k9wUPeU1Ga7cygiuGP8TT6aPLWF<ClubLoungeScene>();
	}

	private void OnZenithClick()
	{
		ClubUpstairsScene.smethod_28(ClubUpstairsScene.smethod_21((_7UlnfykmEmZDFt3BmCKZekI43Ih)this), "ZenithPreDate");
	}

	static _uqydQVaCmCvK7zzWs5W4gZFpKBu smethod_14(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0, string string_0, string string_1, int int_0, int int_1)
	{
		return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._0O8D0mBgmrh0sLOGcLVvGNOHKLCA(string_0, string_1, int_0, int_1);
	}

	static _z20t8IpBINiJtljSeTIkNoKUOkx smethod_15(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0, string string_0, string string_1, int int_0, int int_1, Action action_0)
	{
		return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._2CHUZ5vSi5NbJYJ4gGtr3C2VVEo(string_0, string_1, int_0, int_1, action_0);
	}

	static _wRd4nHuQQlAPEwrHOGkBfut6Uip smethod_16(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		return _JbeCmOie0phb2cbgG6DdGZrbs3pB_0._vsceSzSIjBy2nZrCxAzKZbUiwLq;
	}

	static void smethod_17(_wRd4nHuQQlAPEwrHOGkBfut6Uip _wRd4nHuQQlAPEwrHOGkBfut6Uip_0, int int_0, int int_1, int int_2, int int_3)
	{
		_wRd4nHuQQlAPEwrHOGkBfut6Uip_0._wFfc7xL7eKxed7i9gWtao7pgsnm(int_0, int_1, int_2, int_3);
	}

	static void smethod_18(string[] string_0, float float_0, bool bool_0, bool bool_1)
	{
		_UmxbIbk7pgaod0bD7pS309P3Lns._QrgbXEg7MMeD9Ybz12fFVsbmAd9(string_0, float_0, bool_0, bool_1);
	}

	static _opIJo2jLUqdOL5yAFP4yzXce0DG smethod_19()
	{
		return _Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t();
	}

	static bool smethod_20(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0, string string_0)
	{
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._Oms9lumBodLGrGZ09YJaEuzmlAf(string_0);
	}

	static _JbeCmOie0phb2cbgG6DdGZrbs3pB smethod_21(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0)
	{
		return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._ZzBuoSDMWwerejOO9Goyv2OCKgE;
	}

	static void smethod_22(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, bool bool_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._zkHMlDFkja4TqmjdlHuZRCj8FCB = bool_0;
	}

	static void smethod_23(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, float float_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_7Xn1C5tjYnmIif1iZKV8AWsEEbL = float_0;
	}

	static void smethod_24(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, float float_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_bCjZ3VSXGKyhmykd2zCnQBiSpDf = float_0;
	}

	static void smethod_25(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, float float_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._fO7gSlrDDNMoHR4FO5QXAq8fUyA = float_0;
	}

	static void smethod_26(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, bool bool_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_Pv8G2bIbjHmJYrVXhNyr64NSPXn = bool_0;
	}

	static void smethod_27(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, Action action_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._ZVpZ5Oing5kbbVhbmbOHyrofGH7 = action_0;
	}

	static void smethod_28(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0, string string_0)
	{
		_JbeCmOie0phb2cbgG6DdGZrbs3pB_0._xyl3Tv5KdR5eezDgagxbBcS3cwt(string_0);
	}
}
