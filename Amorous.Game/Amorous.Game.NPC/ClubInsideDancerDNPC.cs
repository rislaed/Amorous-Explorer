using System;
using Amorous.Engine.NPC;

namespace Amorous.Game.NPC;

public class ClubInsideDancerDNPC : SpineNPC<ClubInsideDancerDNPC.EHeads, ClubInsideDancerDNPC.EPoses, ClubInsideDancerDNPC.EClothes>
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
		Pants
	}

	public ClubInsideDancerDNPC(IAmorous game)
		: base(game, "Assets/NPC/ClubInsideStatic/Dancer D", 0.8f, premultipliedAlpha: true)
	{
		base.Spine.StartAnimationWithLooping("Dancing");
		GetEmotion(EHeads.Smirk, "Head");
		GetPose(EPoses.Dancing, "Arm right", "Body", "Left forearm", "Tail")._6NcgB9eEKq8eKu8SgNWnKbLsDhB("Cock");
		GetClothes(EPoses.Dancing, EClothes.Shirt, "Shirt", "Shirt arm right", "Shirt left forearm")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._9mDS3yizOswyCzK6V3LBhafV7Dh();
		GetClothes(EPoses.Dancing, EClothes.Pants, "Pants")._dUWotuFGWMaIlD1IFkXcXUhjchR()._mgkfAuKt1tsSRmn1YmxkzbHikc();
		_J4giDjnRtYmiHMmzwRZ0ThvfAhH = false;
		_upl1k7yzBzlU7vErvbydGmXROfA = true;
	}
}
