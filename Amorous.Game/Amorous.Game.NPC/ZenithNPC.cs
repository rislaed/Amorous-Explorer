using System;
using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class ZenithNPC : SpineNPC<ZenithNPC.EHeads, ZenithNPC.EPoses, ZenithNPC.EClothes>
{
	public enum EHeads
	{
		None,
		Angry,
		Blush,
		Happy,
		NotAmused
	}

	public enum EPoses
	{
		None,
		ArmsFolded,
		HandsOnHips
	}

	public enum EClothes
	{
		None,
		Security,
		Shirt,
		Pants
	}

	public static string _RB8fRXeQvK5vs7JEA0XfVCEpg1i = "Zenith";

	public static Color _9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA = new Color(155, 213, 154);

	public ZenithNPC(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0, "Assets/NPC/Zenith/Zenith", 1f, bool_0: true)
	{
		ZenithNPC.smethod_19(ZenithNPC.smethod_18((_tfDAeR6npiqJMLRSXPO1DxGA0TgA)this), "animation", (Action<int>)null);
		ZenithNPC.smethod_20(_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Angry, "Head angry", "Eye Back", "Pupils"), "Blink");
		ZenithNPC.smethod_20(_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Blush, "Head Blush", "Eye Back", "Pupils"), "Blink");
		ZenithNPC.smethod_20(_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Happy, "Head Happy", "Eye Back", "Pupils"), "Blink");
		ZenithNPC.smethod_20(_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.NotAmused, "Head Un-amused", "Eye Back", "Pupils"), "Blink");
		_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.ArmsFolded, "Body fold arms", "Wing left", "Wing right");
		_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.HandsOnHips, "Body hips", "Wing left", "Wing right");
		ZenithNPC.smethod_21(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.ArmsFolded, EClothes.Security, "Security fold arms"));
		ZenithNPC.smethod_21(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.ArmsFolded, EClothes.Shirt, "Shirt fold arms"));
		ZenithNPC.smethod_22(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.ArmsFolded, EClothes.Pants, "Pants fold arms"));
		ZenithNPC.smethod_21(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.HandsOnHips, EClothes.Security, "Security hips"));
		ZenithNPC.smethod_21(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.HandsOnHips, EClothes.Shirt, "Shirt hips"));
		ZenithNPC.smethod_22(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.HandsOnHips, EClothes.Pants, "Pants hips"));
		_J4giDjnRtYmiHMmzwRZ0ThvfAhH = false;
		_upl1k7yzBzlU7vErvbydGmXROfA = true;
	}

	public override void _nGGBtYpZ8pI1BmE2c2ke63UjGDP(NPCLocation npclocation_0)
	{
		this.method_0(npclocation_0);
		switch (npclocation_0)
		{
		case NPCLocation.Middle:
			ZenithNPC.smethod_23((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: false);
			ZenithNPC.smethod_24((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1000f);
			ZenithNPC.smethod_25((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1090f);
			break;
		case NPCLocation.Left:
			ZenithNPC.smethod_23((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: false);
			ZenithNPC.smethod_24((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 380f);
			ZenithNPC.smethod_25((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1090f);
			break;
		case NPCLocation.Right:
			ZenithNPC.smethod_23((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: false);
			ZenithNPC.smethod_24((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1540f);
			ZenithNPC.smethod_25((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1090f);
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

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_21(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._XJUU6QdUDN3lYoRweLWOMaWqcUE();
	}

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_22(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._dUWotuFGWMaIlD1IFkXcXUhjchR();
	}

	void method_0(NPCLocation npclocation_0)
	{
		base._nGGBtYpZ8pI1BmE2c2ke63UjGDP(npclocation_0);
	}

	static void smethod_23(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, bool bool_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_Pv8G2bIbjHmJYrVXhNyr64NSPXn = bool_0;
	}

	static void smethod_24(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, float float_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_7Xn1C5tjYnmIif1iZKV8AWsEEbL = float_0;
	}

	static void smethod_25(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, float float_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_bCjZ3VSXGKyhmykd2zCnQBiSpDf = float_0;
	}
}
