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
		CobyNPC.smethod_19(CobyNPC.smethod_18((_tfDAeR6npiqJMLRSXPO1DxGA0TgA)this), "Breathing", (Action<int>)null);
		CobyNPC.smethod_20(_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Sad, "Sad Head", "Sad Pupils", "Sad Eye back"), "Sad Blink");
		CobyNPC.smethod_20(_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Cocky, "Cocky Head", "Cocky Pupils", "Cocky Black eye back", "Cocky Jaw"), "Cocky Blink");
		CobyNPC.smethod_20(_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Flirty, "Flirty Head", "Flirty Pupils", "Flirty Black eye back", "Flirty Jaw"), "Flirty Blink");
		CobyNPC.smethod_20(_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Happy, "Happy Head", "Happy Pupil", "Happy Black eye back", "Happy Jaw"), "Happy Blink");
		CobyNPC.smethod_21(_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Flirty, "Neck puff", "Flirty Bod", "Leg extension"), new string[1] { "Flirty cock" });
		CobyNPC.smethod_21(_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Shy, "Neck puff", "Shy Bod"), new string[1] { "Chill/Shy Cock" });
		CobyNPC.smethod_21(_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Chill, "Neck puff", "Chill Bod"), new string[1] { "Chill cock" });
		CobyNPC.smethod_23(CobyNPC.smethod_22(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Flirty, EClothes.Shirt, "Flirty shirt only")));
		CobyNPC.smethod_26(CobyNPC.smethod_25(CobyNPC.smethod_24(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Flirty, EClothes.Shorts, "Flirty outfit"))));
		CobyNPC.smethod_23(CobyNPC.smethod_22(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Flirty, EClothes.Sleeves, "Flirty Sleeves")));
		CobyNPC.smethod_26(CobyNPC.smethod_24(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Flirty, EClothes.Underwear, "Flirty underwear")));
		CobyNPC.smethod_23(CobyNPC.smethod_22(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Shy, EClothes.Shirt, "Shy shirt only")));
		CobyNPC.smethod_26(CobyNPC.smethod_25(CobyNPC.smethod_24(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Shy, EClothes.Shorts, "Shy outfit"))));
		CobyNPC.smethod_23(CobyNPC.smethod_22(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Shy, EClothes.Sleeves, "Shy sleeves")));
		CobyNPC.smethod_26(CobyNPC.smethod_24(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Shy, EClothes.Underwear, "Shy underwear")));
		CobyNPC.smethod_23(CobyNPC.smethod_22(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Chill, EClothes.Shirt, "Chill shirt only")));
		CobyNPC.smethod_26(CobyNPC.smethod_25(CobyNPC.smethod_24(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Chill, EClothes.Shorts, "Chil outfit"))));
		CobyNPC.smethod_23(CobyNPC.smethod_22(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Chill, EClothes.Sleeves, "Chill Sleeves")));
		CobyNPC.smethod_26(CobyNPC.smethod_25(CobyNPC.smethod_24(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Chill, EClothes.Underwear, "Chill underwear"))));
		_J4giDjnRtYmiHMmzwRZ0ThvfAhH = false;
		_upl1k7yzBzlU7vErvbydGmXROfA = true;
	}

	public override void _nGGBtYpZ8pI1BmE2c2ke63UjGDP(NPCLocation npclocation_0)
	{
		this.method_0(npclocation_0);
		switch (npclocation_0)
		{
		case NPCLocation.Middle:
			CobyNPC.smethod_27((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: false);
			CobyNPC.smethod_28((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 960f);
			CobyNPC.smethod_29((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1120f);
			break;
		case NPCLocation.Left:
			CobyNPC.smethod_27((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: false);
			CobyNPC.smethod_28((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 400f);
			CobyNPC.smethod_29((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1120f);
			break;
		case NPCLocation.Right:
			CobyNPC.smethod_27((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: true);
			CobyNPC.smethod_28((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1520f);
			CobyNPC.smethod_29((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1120f);
			break;
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
