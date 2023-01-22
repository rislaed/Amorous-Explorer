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

	public static string _RB8fRXeQvK5vs7JEA0XfVCEpg1i = "Lex";

	public static Color _9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA = new Color(255, 128, 0);

	public LexNPC(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0, "Assets/NPC/Lex/Lex", 1f, bool_0: true)
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
					_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.GestureSigaret, EClothes.DickSoft, "Male balls", "Male dick soft");
					num = ((int)num2 * -85591228) ^ -1449421980;
					continue;
				case 26u:
					LexNPC.smethod_22(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Gesture, EClothes.Boxers, "Boxers"));
					num = ((int)num2 * -1283287490) ^ -1398419432;
					continue;
				case 25u:
					LexNPC.smethod_20(_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Happy, first.Union(new string[1] { "Head happy" }).ToArray()), "Blink");
					LexNPC.smethod_20(_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Angry, first.Union(new string[1] { "Head angry" }).ToArray()), "Blink");
					num = ((int)num2 * -1949881571) ^ 0x291DAF04;
					continue;
				case 23u:
					LexNPC.smethod_24(LexNPC.smethod_18((_tfDAeR6npiqJMLRSXPO1DxGA0TgA)this), "Male dick hard", "Male dick soft");
					num = (int)(num2 * 1936944489) ^ -749827814;
					continue;
				case 22u:
					first = new string[5] { "Fringe", "Hair back", "Pupils", "Eyes back", "Ear" };
					num = ((int)num2 * -144607911) ^ -666695634;
					continue;
				case 21u:
					LexNPC.smethod_23(LexNPC.smethod_22(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.GestureDrink, EClothes.Jeans, "Jeans")));
					LexNPC.smethod_23(LexNPC.smethod_22(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.GestureSigaret, EClothes.Jeans, "Jeans")));
					num = ((int)num2 * -320158245) ^ -785384355;
					continue;
				case 20u:
					LexNPC.smethod_20(_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Sad, first.Union(new string[1] { "Head sad" }).ToArray()), "Blink");
					num = ((int)num2 * -2124825746) ^ 0x662CFA1C;
					continue;
				case 19u:
					LexNPC.smethod_24(LexNPC.smethod_18((_tfDAeR6npiqJMLRSXPO1DxGA0TgA)this), "Male dick soft", "Jacket");
					num = (int)(num2 * 211696098) ^ -39430336;
					continue;
				case 18u:
					LexNPC.smethod_21(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.GestureSigaret, EClothes.Jacket, "Jacket", "Shoulder gesture jacket", "Forearm gesture jacket"));
					LexNPC.smethod_23(LexNPC.smethod_22(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Neutral, EClothes.Jeans, "Jeans")));
					LexNPC.smethod_23(LexNPC.smethod_22(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Gesture, EClothes.Jeans, "Jeans")));
					num = (int)(num2 * 1117313160) ^ -1408634644;
					continue;
				case 17u:
					LexNPC.smethod_20(_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Embarrassed, first.Union(new string[1] { "Head blush" }).ToArray()), "Blink");
					num = ((int)num2 * -1587976170) ^ -304727625;
					continue;
				case 16u:
					LexNPC.smethod_19(LexNPC.smethod_18((_tfDAeR6npiqJMLRSXPO1DxGA0TgA)this), "animation", (Action<int>)null);
					num = ((int)num2 * -1590599048) ^ -1063844233;
					continue;
				case 15u:
					LexNPC.smethod_22(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.GestureSigaret, EClothes.Boxers, "Boxers"));
					num = ((int)num2 * -1650112591) ^ -798337526;
					continue;
				case 14u:
					LexNPC.smethod_22(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Neutral, EClothes.Boxers, "Boxers"));
					num = (int)((num2 * 793867320) ^ 0x7E9EA5F7);
					continue;
				case 13u:
					LexNPC.smethod_22(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Gesture, EClothes.Panties, "Panties"));
					num = ((int)num2 * -1353409322) ^ 0x29D51069;
					continue;
				case 12u:
					LexNPC.smethod_21(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.GestureDrink, EClothes.Jacket, "Jacket", "Shoulder gesture jacket", "Forearm gesture jacket"));
					num = ((int)num2 * -1580512091) ^ -1669802525;
					continue;
				case 11u:
					LexNPC.smethod_22(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Neutral, EClothes.Panties, "Panties"));
					num = ((int)num2 * -720888075) ^ 0x73056E07;
					continue;
				case 9u:
					_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.GestureSigaret, "Body neutral", "Shoulder gesture", "Forearm gesture", "Hand cig", "Tail");
					LexNPC.smethod_21(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Neutral, EClothes.Jacket, "Jacket", "Shoulder neutral jacket", "Forearm neutral jacket"));
					LexNPC.smethod_21(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Gesture, EClothes.Jacket, "Jacket", "Shoulder gesture jacket", "Forearm gesture jacket"));
					num = ((int)num2 * -2010112222) ^ -578704673;
					continue;
				case 8u:
					_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Neutral, "Body neutral", "Shoulder neutral", "Forearm neutral", "Tail");
					num = (int)((num2 * 1875693309) ^ 0x75C4FAF6);
					continue;
				case 7u:
					_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.GestureDrink, EClothes.DickSoft, "Male balls", "Male dick soft");
					num = ((int)num2 * -195473319) ^ -1230453051;
					continue;
				case 6u:
					LexNPC.smethod_22(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.GestureDrink, EClothes.Panties, "Panties"));
					LexNPC.smethod_22(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.GestureSigaret, EClothes.Panties, "Panties"));
					num = ((int)num2 * -1462354205) ^ 0x6745A33D;
					continue;
				case 5u:
					_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Neutral, EClothes.DickHard, "Male balls", "Male dick hard");
					num = (int)(num2 * 1270065698) ^ -1232520609;
					continue;
				case 4u:
					_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Neutral, EClothes.DickSoft, "Male balls", "Male dick soft");
					_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Gesture, EClothes.DickSoft, "Male balls", "Male dick soft");
					num = (int)((num2 * 96221291) ^ 0x73FDE4FA);
					continue;
				case 3u:
					_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Gesture, "Body neutral", "Shoulder gesture", "Forearm gesture", "Hand gesture", "Tail");
					num = (int)((num2 * 628684207) ^ 0x23459CF6);
					continue;
				case 2u:
					_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.GestureDrink, "Body neutral", "Shoulder gesture", "Forearm gesture", "Hand drink", "Tail");
					num = (int)(num2 * 1920402634) ^ -631603524;
					continue;
				case 1u:
					LexNPC.smethod_22(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.GestureDrink, EClothes.Boxers, "Boxers"));
					num = (int)(num2 * 761494125) ^ -1471032941;
					continue;
				case 0u:
					_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Gesture, EClothes.DickHard, "Male balls", "Male dick hard");
					_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.GestureDrink, EClothes.DickHard, "Male balls", "Male dick hard");
					_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.GestureSigaret, EClothes.DickHard, "Male balls", "Male dick hard");
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
