using System;
using Amorous.Engine.NPC;

namespace Amorous.Game.NPC;

public abstract class ClubStaticSpineNPC : SpineNPC<ClubStaticSpineNPC.EHeads, ClubStaticSpineNPC.EPoses, ClubStaticSpineNPC.EClothes>
{
	public enum EHeads
	{
		None
	}

	public enum EPoses
	{
		None,
		Nude
	}

	public enum EClothes
	{
		None,
		Shirt,
		Pants
	}

	protected ClubStaticSpineNPC(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0, string string_0, string[] string_1, string[] string_2 = null, string[] string_3 = null)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0, string_0, 1f, bool_0: true)
	{
		_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Nude, string_1);
		if (string_2 != null)
		{
			ClubStaticSpineNPC.smethod_19(ClubStaticSpineNPC.smethod_18(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Nude, EClothes.Shirt, string_2)));
		}
		if (string_3 != null)
		{
			ClubStaticSpineNPC.smethod_21(ClubStaticSpineNPC.smethod_20(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Nude, EClothes.Pants, string_3)));
		}
	}

	public override void _g9Sx54kMPiHz5jrqWh4Kb1pTijH()
	{
		this.method_0();
		_g3oEqGBkN3YHUPosRq2nIP2sX0D(EHeads.None);
		_tDFvus0ZCanjp81eOiDzoMXJiuf(EPoses.Nude);
		_09vxUzgOn7J7DFZEwsTh7lgEIhB(EClothes.Shirt, EClothes.Pants);
		ClubStaticSpineNPC.smethod_23(ClubStaticSpineNPC.smethod_22((_tfDAeR6npiqJMLRSXPO1DxGA0TgA)this), "animation", (Action<int>)null);
	}

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_18(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._XJUU6QdUDN3lYoRweLWOMaWqcUE();
	}

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_19(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._9mDS3yizOswyCzK6V3LBhafV7Dh();
	}

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_20(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._dUWotuFGWMaIlD1IFkXcXUhjchR();
	}

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_21(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._mgkfAuKt1tsSRmn1YmxkzbHikc();
	}

	void method_0()
	{
		base._g9Sx54kMPiHz5jrqWh4Kb1pTijH();
	}

	static _nHdiyIURlAiaNZ8u6MKzxjcwnyL smethod_22(_tfDAeR6npiqJMLRSXPO1DxGA0TgA _tfDAeR6npiqJMLRSXPO1DxGA0TgA_0)
	{
		return _tfDAeR6npiqJMLRSXPO1DxGA0TgA_0._1BgOJ3z4ZUXNS2L4JWf24pr41hB;
	}

	static void smethod_23(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0, string string_0, Action<int> action_0)
	{
		_nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._C5vPbZ72rpVMDWGuHxZuR5FNpAH(string_0, action_0);
	}
}
