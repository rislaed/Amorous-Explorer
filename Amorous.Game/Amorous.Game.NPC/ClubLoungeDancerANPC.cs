using System;
using Amorous.Engine.NPC;

namespace Amorous.Game.NPC;

public class ClubLoungeDancerANPC : SpineNPC<ClubLoungeDancerANPC.EHeads, ClubLoungeDancerANPC.EPoses, ClubLoungeDancerANPC.EClothes>
{
	public enum EHeads
	{
		None,
		Smirk
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
		Shorts
	}

	public ClubLoungeDancerANPC(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0, "Assets/NPC/ClubLoungeStatic/Dancer A", 1f, bool_0: true)
	{
		ClubLoungeDancerANPC.smethod_19(ClubLoungeDancerANPC.smethod_18((_tfDAeR6npiqJMLRSXPO1DxGA0TgA)this), "animation", (Action<int>)null);
		_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Smirk, "Ear", "Eye back", "Fringe", "Head", "Pupil");
		_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Dancing, "Arms", "Body", "Breast", "Leg left", "Leg right", "Tail base", "Tail head", "Tail head jaw", "Tail head tongue tip");
		ClubLoungeDancerANPC.smethod_21(ClubLoungeDancerANPC.smethod_20(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Dancing, EClothes.Shirt, "Shirt")));
		ClubLoungeDancerANPC.smethod_23(ClubLoungeDancerANPC.smethod_22(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Dancing, EClothes.Shorts, "Shorts left", "Shorts right")));
		_J4giDjnRtYmiHMmzwRZ0ThvfAhH = true;
		_upl1k7yzBzlU7vErvbydGmXROfA = true;
	}

	static _nHdiyIURlAiaNZ8u6MKzxjcwnyL smethod_18(_tfDAeR6npiqJMLRSXPO1DxGA0TgA _tfDAeR6npiqJMLRSXPO1DxGA0TgA_0)
	{
		return _tfDAeR6npiqJMLRSXPO1DxGA0TgA_0._1BgOJ3z4ZUXNS2L4JWf24pr41hB;
	}

	static void smethod_19(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0, string string_0, Action<int> action_0)
	{
		_nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._C5vPbZ72rpVMDWGuHxZuR5FNpAH(string_0, action_0);
	}

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_20(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._XJUU6QdUDN3lYoRweLWOMaWqcUE();
	}

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_21(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._9mDS3yizOswyCzK6V3LBhafV7Dh();
	}

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_22(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._dUWotuFGWMaIlD1IFkXcXUhjchR();
	}

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_23(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._mgkfAuKt1tsSRmn1YmxkzbHikc();
	}
}
