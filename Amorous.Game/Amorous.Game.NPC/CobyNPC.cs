using System;
using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class CobyNPC : SpineNPC<CobyNPC.EHeads, CobyNPC.EPoses, CobyNPC.EClothes>
{
	public enum EHeads
	{
		None,
		Sad,
		Cocky,
		Flirty,
		Happy
	}

	public enum EPoses
	{
		None,
		Flirty,
		Shy,
		Chill
	}

	public enum EClothes
	{
		None,
		Shirt,
		Shorts,
		Sleeves,
		Underwear
	}

	public static string _RB8fRXeQvK5vs7JEA0XfVCEpg1i = "Coby";

	public static Color _9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA = new Color(104, 193, 255);

	public CobyNPC(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0, "Assets/NPC/Coby/Coby", 1f, bool_0: true)
	{
		while (true)
		{
			int num = 1704874863;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2F399879u) % 15u)
				{
				case 14u:
					CobyNPC.smethod_20(_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Happy, "Happy Head", "Happy Pupil", "Happy Black eye back", "Happy Jaw"), "Happy Blink");
					num = (int)((num2 * 192624091) ^ 0x30146626);
					continue;
				case 13u:
					CobyNPC.smethod_23(CobyNPC.smethod_22(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Flirty, EClothes.Shirt, "Flirty shirt only")));
					num = ((int)num2 * -1192242492) ^ -614267447;
					continue;
				case 12u:
					_J4giDjnRtYmiHMmzwRZ0ThvfAhH = false;
					_upl1k7yzBzlU7vErvbydGmXROfA = true;
					num = (int)(num2 * 782436719) ^ -756480548;
					continue;
				case 10u:
					CobyNPC.smethod_26(CobyNPC.smethod_25(CobyNPC.smethod_24(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Chill, EClothes.Underwear, "Chill underwear"))));
					num = ((int)num2 * -1995533177) ^ 0x3313A30C;
					continue;
				case 9u:
					CobyNPC.smethod_21(_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Chill, "Neck puff", "Chill Bod"), new string[1] { "Chill cock" });
					num = (int)(num2 * 1380077651) ^ -908023747;
					continue;
				case 7u:
					CobyNPC.smethod_23(CobyNPC.smethod_22(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Chill, EClothes.Sleeves, "Chill Sleeves")));
					num = (int)(num2 * 1061397964) ^ -969787826;
					continue;
				case 6u:
					CobyNPC.smethod_26(CobyNPC.smethod_24(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Shy, EClothes.Underwear, "Shy underwear")));
					CobyNPC.smethod_23(CobyNPC.smethod_22(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Chill, EClothes.Shirt, "Chill shirt only")));
					CobyNPC.smethod_26(CobyNPC.smethod_25(CobyNPC.smethod_24(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Chill, EClothes.Shorts, "Chil outfit"))));
					num = ((int)num2 * -1294443655) ^ 0x531259AA;
					continue;
				case 5u:
					CobyNPC.smethod_23(CobyNPC.smethod_22(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Flirty, EClothes.Sleeves, "Flirty Sleeves")));
					num = (int)(num2 * 1940827979) ^ -2117195771;
					continue;
				case 4u:
					CobyNPC.smethod_21(_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Flirty, "Neck puff", "Flirty Bod", "Leg extension"), new string[1] { "Flirty cock" });
					CobyNPC.smethod_21(_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Shy, "Neck puff", "Shy Bod"), new string[1] { "Chill/Shy Cock" });
					num = (int)(num2 * 1452525282) ^ -185096495;
					continue;
				case 3u:
					CobyNPC.smethod_26(CobyNPC.smethod_25(CobyNPC.smethod_24(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Flirty, EClothes.Shorts, "Flirty outfit"))));
					num = ((int)num2 * -1799712807) ^ -1565152588;
					continue;
				case 2u:
					CobyNPC.smethod_20(_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Sad, "Sad Head", "Sad Pupils", "Sad Eye back"), "Sad Blink");
					CobyNPC.smethod_20(_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Cocky, "Cocky Head", "Cocky Pupils", "Cocky Black eye back", "Cocky Jaw"), "Cocky Blink");
					CobyNPC.smethod_20(_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Flirty, "Flirty Head", "Flirty Pupils", "Flirty Black eye back", "Flirty Jaw"), "Flirty Blink");
					num = (int)(num2 * 244769056) ^ -288337803;
					continue;
				case 1u:
					CobyNPC.smethod_19(CobyNPC.smethod_18((_tfDAeR6npiqJMLRSXPO1DxGA0TgA)this), "Breathing", (Action<int>)null);
					num = ((int)num2 * -440564624) ^ -1460822227;
					continue;
				case 0u:
					CobyNPC.smethod_26(CobyNPC.smethod_24(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Flirty, EClothes.Underwear, "Flirty underwear")));
					CobyNPC.smethod_23(CobyNPC.smethod_22(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Shy, EClothes.Shirt, "Shy shirt only")));
					CobyNPC.smethod_26(CobyNPC.smethod_25(CobyNPC.smethod_24(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Shy, EClothes.Shorts, "Shy outfit"))));
					CobyNPC.smethod_23(CobyNPC.smethod_22(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Shy, EClothes.Sleeves, "Shy sleeves")));
					num = (int)((num2 * 454567242) ^ 0x3B817EFB);
					continue;
				default:
					return;
				case 8u:
					break;
				case 11u:
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
		case NPCLocation.Middle:
			CobyNPC.smethod_27((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: false);
			num = 423622958;
			goto IL_00d1;
		default:
			goto IL_00a4;
		case NPCLocation.Left:
			goto IL_00c5;
		case NPCLocation.Right:
			goto IL_0117;
			IL_00d1:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x585CF8B5u) % 13u)
				{
				case 12u:
					CobyNPC.smethod_28((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 400f);
					num = (int)(num2 * 1812492165) ^ -1749408473;
					continue;
				case 11u:
					CobyNPC.smethod_29((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1120f);
					num = ((int)num2 * -538087658) ^ 0x28465EC7;
					continue;
				case 10u:
					break;
				case 8u:
					CobyNPC.smethod_29((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1120f);
					num = ((int)num2 * -1609815560) ^ -1980143564;
					continue;
				case 6u:
					CobyNPC.smethod_28((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 960f);
					CobyNPC.smethod_29((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1120f);
					num = ((int)num2 * -1329035913) ^ -597686786;
					continue;
				case 4u:
					goto IL_00a4;
				case 1u:
					CobyNPC.smethod_28((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1520f);
					num = ((int)num2 * -1066272213) ^ 0x8764C9;
					continue;
				case 0u:
					goto IL_00c5;
				default:
					return;
				case 3u:
					goto IL_0117;
				case 2u:
					return;
				case 5u:
					return;
				case 7u:
					return;
				case 9u:
					return;
				}
				break;
			}
			goto case NPCLocation.Middle;
			IL_0117:
			CobyNPC.smethod_27((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: true);
			num = 1074374047;
			goto IL_00d1;
			IL_00c5:
			CobyNPC.smethod_27((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: false);
			num = 1334374563;
			goto IL_00d1;
			IL_00a4:
			num = 1636475902;
			goto IL_00d1;
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

	static _NaKchYC4I4GjWR34SfBLAktysCE smethod_21(_NaKchYC4I4GjWR34SfBLAktysCE _NaKchYC4I4GjWR34SfBLAktysCE_0, string[] string_0)
	{
		return _NaKchYC4I4GjWR34SfBLAktysCE_0._6NcgB9eEKq8eKu8SgNWnKbLsDhB(string_0);
	}

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_22(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._XJUU6QdUDN3lYoRweLWOMaWqcUE();
	}

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_23(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._9mDS3yizOswyCzK6V3LBhafV7Dh();
	}

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_24(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._dUWotuFGWMaIlD1IFkXcXUhjchR();
	}

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_25(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._B19pyNfKCkJxZB1oCC3WzfkqEQF();
	}

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_26(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._mgkfAuKt1tsSRmn1YmxkzbHikc();
	}

	void method_0(NPCLocation npclocation_0)
	{
		base._nGGBtYpZ8pI1BmE2c2ke63UjGDP(npclocation_0);
	}

	static void smethod_27(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, bool bool_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_Pv8G2bIbjHmJYrVXhNyr64NSPXn = bool_0;
	}

	static void smethod_28(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, float float_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_7Xn1C5tjYnmIif1iZKV8AWsEEbL = float_0;
	}

	static void smethod_29(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, float float_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_bCjZ3VSXGKyhmykd2zCnQBiSpDf = float_0;
	}
}
