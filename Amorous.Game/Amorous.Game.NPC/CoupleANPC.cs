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
		: base(game, "Assets/Scenes/Intro/Couple A", 1f, premultipliedAlpha: true)
	{
		base.Spine.StartAnimationWithLooping("Waving");
		GetPose(EPoses.Waving, "Skunk arm back", "Characters left", "Silver arm");
		GetClothes(EPoses.Waving, EClothes.Shirt, "Shirts")._XJUU6QdUDN3lYoRweLWOMaWqcUE();
		GetClothes(EPoses.Waving, EClothes.Pants, "Pants")._dUWotuFGWMaIlD1IFkXcXUhjchR();
		_J4giDjnRtYmiHMmzwRZ0ThvfAhH = false;
		_upl1k7yzBzlU7vErvbydGmXROfA = true;
	}
}
