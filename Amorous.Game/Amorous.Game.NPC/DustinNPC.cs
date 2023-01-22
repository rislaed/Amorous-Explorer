using System;
using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class DustinNPC : SpineNPC<DustinNPC.EHeads, DustinNPC.EPoses, DustinNPC.EClothes>
{
	public enum EHeads
	{
		None,
		Neutral,
		Angry,
		Blush,
		Sad
	}

	public enum EPoses
	{
		None,
		Neutral,
		Gesture
	}

	public enum EClothes
	{
		None,
		Shirt,
		Pants
	}

	public static string _RB8fRXeQvK5vs7JEA0XfVCEpg1i = "Dustin";

	public static Color _9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA = new Color(242, 208, 150);

	public DustinNPC(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0, "Assets/NPC/Dustin/Dustin", 1f, bool_0: true)
	{
		DustinNPC.smethod_19(DustinNPC.smethod_18((_tfDAeR6npiqJMLRSXPO1DxGA0TgA)this), "Idle", (Action<int>)null);
		DustinNPC.smethod_20(_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Neutral, "Neutral Mane", "Neutral eye back", "Neutral pupil", "Neutral jaw", "Neutral head"), "Neutral blink");
		DustinNPC.smethod_20(_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Angry, "Angry mane", "Angry eyeback", "Angry pupil", "Angry head"), "Angry blink");
		DustinNPC.smethod_20(_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Blush, "Blush mane", "Blush eye back", "Blush pupil", "Blush head"), "Blush blink");
		DustinNPC.smethod_20(_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Sad, "Sad earback", "Sad mane", "Sad eyeback", "Sad pupils", "Sad head"), "Sad blink");
		DustinNPC.smethod_21(_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Neutral, "Body Neutral", "Neutral thumb"), new string[1] { "Cock" });
		DustinNPC.smethod_21(_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Gesture, "Body Gesture"), new string[1] { "Cock" });
		DustinNPC.smethod_23(DustinNPC.smethod_22(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Neutral, EClothes.Shirt, "Neutral shirt")));
		DustinNPC.smethod_25(DustinNPC.smethod_24(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Neutral, EClothes.Pants, "Pants")));
		DustinNPC.smethod_23(DustinNPC.smethod_22(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Gesture, EClothes.Shirt, "Gesture shirt")));
		DustinNPC.smethod_25(DustinNPC.smethod_24(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Gesture, EClothes.Pants, "Pants")));
		_J4giDjnRtYmiHMmzwRZ0ThvfAhH = false;
		_upl1k7yzBzlU7vErvbydGmXROfA = true;
	}

	public override void _nGGBtYpZ8pI1BmE2c2ke63UjGDP(NPCLocation npclocation_0)
	{
		this.method_0(npclocation_0);
		switch (npclocation_0)
		{
		case NPCLocation.Middle:
			DustinNPC.smethod_26((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: false);
			DustinNPC.smethod_27((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 960f);
			DustinNPC.smethod_28((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1100f);
			break;
		case NPCLocation.Left:
			DustinNPC.smethod_26((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: false);
			DustinNPC.smethod_27((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 400f);
			DustinNPC.smethod_28((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1100f);
			break;
		case NPCLocation.Right:
			DustinNPC.smethod_26((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: false);
			DustinNPC.smethod_27((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1520f);
			DustinNPC.smethod_28((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1100f);
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
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._mgkfAuKt1tsSRmn1YmxkzbHikc();
	}

	void method_0(NPCLocation npclocation_0)
	{
		base._nGGBtYpZ8pI1BmE2c2ke63UjGDP(npclocation_0);
	}

	static void smethod_26(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, bool bool_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_Pv8G2bIbjHmJYrVXhNyr64NSPXn = bool_0;
	}

	static void smethod_27(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, float float_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_7Xn1C5tjYnmIif1iZKV8AWsEEbL = float_0;
	}

	static void smethod_28(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, float float_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_bCjZ3VSXGKyhmykd2zCnQBiSpDf = float_0;
	}
}
