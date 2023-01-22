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
			_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Nude, EClothes.Shirt, string_2)._XJUU6QdUDN3lYoRweLWOMaWqcUE()._9mDS3yizOswyCzK6V3LBhafV7Dh();
		}
		if (string_3 != null)
		{
			_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Nude, EClothes.Pants, string_3)._dUWotuFGWMaIlD1IFkXcXUhjchR()._mgkfAuKt1tsSRmn1YmxkzbHikc();
		}
	}

	public override void _g9Sx54kMPiHz5jrqWh4Kb1pTijH()
	{
		base._g9Sx54kMPiHz5jrqWh4Kb1pTijH();
		_g3oEqGBkN3YHUPosRq2nIP2sX0D(EHeads.None);
		_tDFvus0ZCanjp81eOiDzoMXJiuf(EPoses.Nude);
		_09vxUzgOn7J7DFZEwsTh7lgEIhB(EClothes.Shirt, EClothes.Pants);
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._C5vPbZ72rpVMDWGuHxZuR5FNpAH("animation");
	}
}
