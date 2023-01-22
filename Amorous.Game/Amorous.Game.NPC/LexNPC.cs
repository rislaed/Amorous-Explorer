using System;
using System.Linq;
using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class LexNPC : SpineNPC<LexNPC.EHeads, LexNPC.EPoses, LexNPC.EClothes>
{
	public enum EHeads
	{
		None,
		Happy,
		Angry,
		Sad,
		Embarrassed
	}

	public enum EPoses
	{
		None,
		Neutral,
		Gesture,
		GestureDrink,
		GestureSigaret
	}

	public enum EClothes
	{
		None,
		Jacket,
		Jeans,
		Panties,
		Boxers,
		DickSoft,
		DickHard
	}

	public static string _RB8fRXeQvK5vs7JEA0XfVCEpg1i = _003CModule_003E.smethod_27<string>(241380367u);

	public static Color _9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA = new Color(255, 128, 0);

	public LexNPC(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0, _003CModule_003E.smethod_26<string>(4185415313u), 1f, bool_0: true)
	{
		string[] first = default(string[]);
		while (true)
		{
			int num = 252642773;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x309F9A9Du) % 28u)
				{
				case 27u:
					_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.GestureSigaret, EClothes.DickSoft, _003CModule_003E.smethod_28<string>(3570727734u), _003CModule_003E.smethod_27<string>(109176653u));
					num = ((int)num2 * -85591228) ^ -1449421980;
					continue;
				case 26u:
					LexNPC.smethod_22(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Gesture, EClothes.Boxers, _003CModule_003E.smethod_26<string>(4089270249u)));
					num = ((int)num2 * -1283287490) ^ -1398419432;
					continue;
				case 25u:
					LexNPC.smethod_20(_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Happy, first.Union(new string[1] { _003CModule_003E.smethod_27<string>(566701303u) }).ToArray()), _003CModule_003E.smethod_25<string>(1985894881u));
					LexNPC.smethod_20(_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Angry, first.Union(new string[1] { _003CModule_003E.smethod_28<string>(2038721067u) }).ToArray()), _003CModule_003E.smethod_27<string>(1525157651u));
					num = ((int)num2 * -1949881571) ^ 0x291DAF04;
					continue;
				case 23u:
					LexNPC.smethod_24(LexNPC.smethod_18((_tfDAeR6npiqJMLRSXPO1DxGA0TgA)this), _003CModule_003E.smethod_26<string>(1460240157u), _003CModule_003E.smethod_24<string>(4199666190u));
					num = (int)(num2 * 1936944489) ^ -749827814;
					continue;
				case 22u:
					first = new string[5]
					{
						_003CModule_003E.smethod_24<string>(1860501818u),
						_003CModule_003E.smethod_28<string>(3732623769u),
						_003CModule_003E.smethod_28<string>(1245735061u),
						_003CModule_003E.smethod_28<string>(963417944u),
						_003CModule_003E.smethod_25<string>(2801240902u)
					};
					num = ((int)num2 * -144607911) ^ -666695634;
					continue;
				case 21u:
					LexNPC.smethod_23(LexNPC.smethod_22(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.GestureDrink, EClothes.Jeans, _003CModule_003E.smethod_25<string>(3057702833u))));
					LexNPC.smethod_23(LexNPC.smethod_22(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.GestureSigaret, EClothes.Jeans, _003CModule_003E.smethod_25<string>(3057702833u))));
					num = ((int)num2 * -320158245) ^ -785384355;
					continue;
				case 20u:
					LexNPC.smethod_20(_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Sad, first.Union(new string[1] { _003CModule_003E.smethod_27<string>(3670832672u) }).ToArray()), _003CModule_003E.smethod_27<string>(1525157651u));
					num = ((int)num2 * -2124825746) ^ 0x662CFA1C;
					continue;
				case 19u:
					LexNPC.smethod_24(LexNPC.smethod_18((_tfDAeR6npiqJMLRSXPO1DxGA0TgA)this), _003CModule_003E.smethod_26<string>(148210850u), _003CModule_003E.smethod_26<string>(1311051083u));
					num = (int)(num2 * 211696098) ^ -39430336;
					continue;
				case 18u:
					LexNPC.smethod_21(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.GestureSigaret, EClothes.Jacket, _003CModule_003E.smethod_26<string>(1311051083u), _003CModule_003E.smethod_25<string>(2386211303u), _003CModule_003E.smethod_25<string>(2990553680u)));
					LexNPC.smethod_23(LexNPC.smethod_22(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Neutral, EClothes.Jeans, _003CModule_003E.smethod_26<string>(3937595436u))));
					LexNPC.smethod_23(LexNPC.smethod_22(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Gesture, EClothes.Jeans, _003CModule_003E.smethod_27<string>(1064015747u))));
					num = (int)(num2 * 1117313160) ^ -1408634644;
					continue;
				case 17u:
					LexNPC.smethod_20(_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Embarrassed, first.Union(new string[1] { _003CModule_003E.smethod_24<string>(376948990u) }).ToArray()), _003CModule_003E.smethod_24<string>(2583463900u));
					num = ((int)num2 * -1587976170) ^ -304727625;
					continue;
				case 16u:
					LexNPC.smethod_19(LexNPC.smethod_18((_tfDAeR6npiqJMLRSXPO1DxGA0TgA)this), _003CModule_003E.smethod_28<string>(2267705786u), (Action<int>)null);
					num = ((int)num2 * -1590599048) ^ -1063844233;
					continue;
				case 15u:
					LexNPC.smethod_22(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.GestureSigaret, EClothes.Boxers, _003CModule_003E.smethod_28<string>(236887675u)));
					num = ((int)num2 * -1650112591) ^ -798337526;
					continue;
				case 14u:
					LexNPC.smethod_22(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Neutral, EClothes.Boxers, _003CModule_003E.smethod_25<string>(3393448598u)));
					num = (int)((num2 * 793867320) ^ 0x7E9EA5F7);
					continue;
				case 13u:
					LexNPC.smethod_22(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Gesture, EClothes.Panties, _003CModule_003E.smethod_24<string>(993097303u)));
					num = ((int)num2 * -1353409322) ^ 0x29D51069;
					continue;
				case 12u:
					LexNPC.smethod_21(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.GestureDrink, EClothes.Jacket, _003CModule_003E.smethod_26<string>(1311051083u), _003CModule_003E.smethod_27<string>(584787573u), _003CModule_003E.smethod_27<string>(2730462594u)));
					num = ((int)num2 * -1580512091) ^ -1669802525;
					continue;
				case 11u:
					LexNPC.smethod_22(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Neutral, EClothes.Panties, _003CModule_003E.smethod_28<string>(3051247055u)));
					num = ((int)num2 * -720888075) ^ 0x73056E07;
					continue;
				case 9u:
					_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.GestureSigaret, _003CModule_003E.smethod_26<string>(2719225454u), _003CModule_003E.smethod_26<string>(3427041248u), _003CModule_003E.smethod_24<string>(4154199841u), _003CModule_003E.smethod_24<string>(2492531202u), _003CModule_003E.smethod_26<string>(3894539116u));
					LexNPC.smethod_21(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Neutral, EClothes.Jacket, _003CModule_003E.smethod_25<string>(1381552504u), _003CModule_003E.smethod_24<string>(404078816u), _003CModule_003E.smethod_26<string>(1816633793u)));
					LexNPC.smethod_21(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Gesture, EClothes.Jacket, _003CModule_003E.smethod_27<string>(3206073514u), _003CModule_003E.smethod_28<string>(405028906u), _003CModule_003E.smethod_27<string>(2730462594u)));
					num = ((int)num2 * -2010112222) ^ -578704673;
					continue;
				case 8u:
					_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Neutral, _003CModule_003E.smethod_28<string>(3114024190u), _003CModule_003E.smethod_28<string>(627135482u), _003CModule_003E.smethod_25<string>(3664623706u), _003CModule_003E.smethod_24<string>(2091583148u));
					num = (int)((num2 * 1875693309) ^ 0x75C4FAF6);
					continue;
				case 7u:
					_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.GestureDrink, EClothes.DickSoft, _003CModule_003E.smethod_28<string>(3570727734u), _003CModule_003E.smethod_26<string>(148210850u));
					num = ((int)num2 * -195473319) ^ -1230453051;
					continue;
				case 6u:
					LexNPC.smethod_22(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.GestureDrink, EClothes.Panties, _003CModule_003E.smethod_28<string>(3051247055u)));
					LexNPC.smethod_22(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.GestureSigaret, EClothes.Panties, _003CModule_003E.smethod_25<string>(291045538u)));
					num = ((int)num2 * -1462354205) ^ 0x6745A33D;
					continue;
				case 5u:
					_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Neutral, EClothes.DickHard, _003CModule_003E.smethod_24<string>(2728656250u), _003CModule_003E.smethod_28<string>(4081396623u));
					num = (int)(num2 * 1270065698) ^ -1232520609;
					continue;
				case 4u:
					_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Neutral, EClothes.DickSoft, _003CModule_003E.smethod_25<string>(3729194363u), _003CModule_003E.smethod_28<string>(1083839026u));
					_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Gesture, EClothes.DickSoft, _003CModule_003E.smethod_28<string>(3570727734u), _003CModule_003E.smethod_27<string>(109176653u));
					num = (int)((num2 * 96221291) ^ 0x73FDE4FA);
					continue;
				case 3u:
					_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Gesture, _003CModule_003E.smethod_28<string>(3114024190u), _003CModule_003E.smethod_25<string>(3866071165u), _003CModule_003E.smethod_27<string>(4157295354u), _003CModule_003E.smethod_27<string>(1053163985u), _003CModule_003E.smethod_27<string>(2371827011u));
					num = (int)((num2 * 628684207) ^ 0x23459CF6);
					continue;
				case 2u:
					_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.GestureDrink, _003CModule_003E.smethod_24<string>(3437031394u), _003CModule_003E.smethod_27<string>(2959224919u), _003CModule_003E.smethod_25<string>(307166056u), _003CModule_003E.smethod_25<string>(777210127u), _003CModule_003E.smethod_27<string>(2371827011u));
					num = (int)(num2 * 1920402634) ^ -631603524;
					continue;
				case 1u:
					LexNPC.smethod_22(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.GestureDrink, EClothes.Boxers, _003CModule_003E.smethod_25<string>(3393448598u)));
					num = (int)(num2 * 761494125) ^ -1471032941;
					continue;
				case 0u:
					_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Gesture, EClothes.DickHard, _003CModule_003E.smethod_27<string>(2494465761u), _003CModule_003E.smethod_24<string>(1357372311u));
					_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.GestureDrink, EClothes.DickHard, _003CModule_003E.smethod_28<string>(3570727734u), _003CModule_003E.smethod_28<string>(4081396623u));
					_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.GestureSigaret, EClothes.DickHard, _003CModule_003E.smethod_24<string>(2728656250u), _003CModule_003E.smethod_28<string>(4081396623u));
					num = ((int)num2 * -303635480) ^ 0x4402822E;
					continue;
				case 10u:
					break;
				default:
					_J4giDjnRtYmiHMmzwRZ0ThvfAhH = false;
					_upl1k7yzBzlU7vErvbydGmXROfA = true;
					return;
				}
				break;
			}
		}
	}

	public override void _nGGBtYpZ8pI1BmE2c2ke63UjGDP(NPCLocation npclocation_0)
	{
		this.method_0(npclocation_0);
		int num;
		switch (npclocation_0)
		{
		case NPCLocation.Left:
			LexNPC.smethod_25((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: false);
			num = -730643593;
			goto IL_00bf;
		case NPCLocation.Middle:
			goto IL_0092;
		default:
			goto IL_00ba;
		case NPCLocation.Right:
			goto IL_0101;
			IL_00bf:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB907EE4Cu) % 12u)
				{
				case 9u:
					LexNPC.smethod_26((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 960f);
					LexNPC.smethod_27((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1090f);
					num = (int)((num2 * 1188034140) ^ 0x163F4DFA);
					continue;
				case 8u:
					break;
				case 7u:
					LexNPC.smethod_26((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 400f);
					LexNPC.smethod_27((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1090f);
					num = (int)(num2 * 889311551) ^ -2089786012;
					continue;
				case 4u:
					LexNPC.smethod_27((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1090f);
					num = ((int)num2 * -1692085897) ^ -1988782678;
					continue;
				case 3u:
					goto IL_0092;
				case 1u:
					LexNPC.smethod_26((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1520f);
					num = ((int)num2 * -175687062) ^ 0xA7FD2A2;
					continue;
				case 0u:
					goto IL_00ba;
				default:
					return;
				case 6u:
					goto IL_0101;
				case 2u:
					return;
				case 5u:
					return;
				case 10u:
					return;
				case 11u:
					return;
				}
				break;
			}
			goto case NPCLocation.Left;
			IL_0101:
			LexNPC.smethod_25((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: false);
			num = -658637899;
			goto IL_00bf;
			IL_00ba:
			num = -1440874869;
			goto IL_00bf;
			IL_0092:
			LexNPC.smethod_25((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: false);
			num = -381680835;
			goto IL_00bf;
		}
	}

	static _nHdiyIURlAiaNZ8u6MKzxjcwnyL smethod_18(_tfDAeR6npiqJMLRSXPO1DxGA0TgA _tfDAeR6npiqJMLRSXPO1DxGA0TgA_0)
	{
		return _tfDAeR6npiqJMLRSXPO1DxGA0TgA_0._1BgOJ3z4ZUXNS2L4JWf24pr41hB;
	}

	static void smethod_19(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0, string string_0, Action<int> action_0)
	{
		_nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._C5vPbZ72rpVMDWGuHxZuR5FNpAH(string_0, action_0);
	}

	static _xmfdPa5IagU3cXbLL61gyoXAV7gA smethod_20(_xmfdPa5IagU3cXbLL61gyoXAV7gA _xmfdPa5IagU3cXbLL61gyoXAV7gA_0, string string_0)
	{
		return _xmfdPa5IagU3cXbLL61gyoXAV7gA_0._qL2MEiFtBpbdxqUUTSqOgOsEK4j(string_0);
	}

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_21(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._XJUU6QdUDN3lYoRweLWOMaWqcUE();
	}

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_22(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._dUWotuFGWMaIlD1IFkXcXUhjchR();
	}

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_23(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._B19pyNfKCkJxZB1oCC3WzfkqEQF();
	}

	static void smethod_24(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0, string string_0, string string_1)
	{
		_nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._eCEWplYE5FdfYPYTrwfyRlIfd6i(string_0, string_1);
	}

	void method_0(NPCLocation npclocation_0)
	{
		base._nGGBtYpZ8pI1BmE2c2ke63UjGDP(npclocation_0);
	}

	static void smethod_25(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, bool bool_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_Pv8G2bIbjHmJYrVXhNyr64NSPXn = bool_0;
	}

	static void smethod_26(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, float float_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_7Xn1C5tjYnmIif1iZKV8AWsEEbL = float_0;
	}

	static void smethod_27(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, float float_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_bCjZ3VSXGKyhmykd2zCnQBiSpDf = float_0;
	}
}
