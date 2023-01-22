using System;
using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class CobyDancingNPC : SpineNPC<CobyDancingNPC.EHeads, CobyDancingNPC.EPoses, CobyDancingNPC.EClothes>
{
	public enum EHeads
	{
		None,
		Happy
	}

	public enum EPoses
	{
		None,
		Dancing
	}

	public enum EClothes
	{
		None,
		Shirt,
		Shorts,
		Sleeves
	}

	public static Color _9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA = new Color(104, 193, 255);

	public CobyDancingNPC(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0, "Assets/NPC/CobyDancing/Coby", 0.8f, bool_0: true)
	{
		_je8rVfyg4zywmqSi4Ozx1z7wJ4b = 600;
		_WJfGWBzn4wgdGBnMWRH2pcJ3AqH = 800;
		CobyDancingNPC.smethod_19(CobyDancingNPC.smethod_18((_tfDAeR6npiqJMLRSXPO1DxGA0TgA)this), "animation", (Action<int>)null);
		_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Happy, "Eyes Back", "Pupil", "Jaw", "Head");
		CobyDancingNPC.smethod_20(_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Dancing, "Tail", "Leg right", "Arm right", "Body", "left leg", "Arm left"), new string[2] { "Balls", "Cock" });
		CobyDancingNPC.smethod_22(CobyDancingNPC.smethod_21(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Dancing, EClothes.Shirt, "Shirt")));
		CobyDancingNPC.smethod_24(CobyDancingNPC.smethod_23(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Dancing, EClothes.Shorts, "Shorts right", "Shorts crotch", "Shorts left")));
		CobyDancingNPC.smethod_22(CobyDancingNPC.smethod_21(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Dancing, EClothes.Sleeves, "Sleeves right", "Sleeves left")));
		_J4giDjnRtYmiHMmzwRZ0ThvfAhH = false;
		_upl1k7yzBzlU7vErvbydGmXROfA = true;
	}

	public override void _nGGBtYpZ8pI1BmE2c2ke63UjGDP(NPCLocation npclocation_0)
	{
		this.method_0(npclocation_0);
		switch (npclocation_0)
		{
		case NPCLocation.Middle:
			CobyDancingNPC.smethod_25((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: false);
			CobyDancingNPC.smethod_26((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 960f);
			CobyDancingNPC.smethod_27((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1120f);
			break;
		case NPCLocation.Left:
			CobyDancingNPC.smethod_25((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: false);
			CobyDancingNPC.smethod_26((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 400f);
			CobyDancingNPC.smethod_27((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1120f);
			break;
		case NPCLocation.Right:
			CobyDancingNPC.smethod_25((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: true);
			CobyDancingNPC.smethod_26((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1520f);
			CobyDancingNPC.smethod_27((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1120f);
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

	static _NaKchYC4I4GjWR34SfBLAktysCE smethod_20(_NaKchYC4I4GjWR34SfBLAktysCE _NaKchYC4I4GjWR34SfBLAktysCE_0, string[] string_0)
	{
		return _NaKchYC4I4GjWR34SfBLAktysCE_0._6NcgB9eEKq8eKu8SgNWnKbLsDhB(string_0);
	}

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_21(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._XJUU6QdUDN3lYoRweLWOMaWqcUE();
	}

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_22(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._9mDS3yizOswyCzK6V3LBhafV7Dh();
	}

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_23(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._dUWotuFGWMaIlD1IFkXcXUhjchR();
	}

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_24(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._mgkfAuKt1tsSRmn1YmxkzbHikc();
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
