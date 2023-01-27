using System;
using Amorous.Engine.NPC;

namespace Amorous.Game.NPC;

public class CoupleBNPC : SpineNPC<CoupleBNPC.EHeads, CoupleBNPC.EPoses, CoupleBNPC.EClothes>
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

	public CoupleBNPC(IAmorous game)
		: base(game, "Assets/Scenes/Intro/Couple B", 1f, bool_0: true)
	{
		base.Spine.StartAnimationWithLooping("Waving");
		GetPose(EPoses.Waving, "Dark arm", "Characters right", "fem arms");
		GetClothes(EPoses.Waving, EClothes.Shirt, "Shirts right")._XJUU6QdUDN3lYoRweLWOMaWqcUE();
		GetClothes(EPoses.Waving, EClothes.Pants, "Pants right")._dUWotuFGWMaIlD1IFkXcXUhjchR();
		_J4giDjnRtYmiHMmzwRZ0ThvfAhH = true;
		_upl1k7yzBzlU7vErvbydGmXROfA = true;
	}
}
