using System;
using Amorous.Engine.NPC;

namespace Amorous.Game.NPC;

public class CoupleANPC : SpineNPC<CoupleANPC.EHeads, CoupleANPC.EPoses, CoupleANPC.EClothes>
{
	public enum EHeads
	{
		None
	}

	public enum EPoses
	{
		None,
		Waving
	}

	public enum EClothes
	{
		None,
		Shirt,
		Pants
	}

	public CoupleANPC(IAmorous game)
		: base(Game, "Assets/Scenes/Intro/Couple A", 1f, bool_0: true)
	{
		base.Spine.StartAnimationWithLooping("Waving");
		_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Waving, "Skunk arm back", "Characters left", "Silver arm");
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Waving, EClothes.Shirt, "Shirts")._XJUU6QdUDN3lYoRweLWOMaWqcUE();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Waving, EClothes.Pants, "Pants")._dUWotuFGWMaIlD1IFkXcXUhjchR();
		_J4giDjnRtYmiHMmzwRZ0ThvfAhH = false;
		_upl1k7yzBzlU7vErvbydGmXROfA = true;
	}
}
