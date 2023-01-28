using System;
using Amorous.Engine.NPC;

namespace Amorous.Game.NPC;

public class ClubInsideDancerBNPC : SpineNPC<ClubInsideDancerBNPC.EHeads, ClubInsideDancerBNPC.EPoses, ClubInsideDancerBNPC.EClothes>
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
		Skirt
	}

	public ClubInsideDancerBNPC(IAmorous game)
		: base(game, "Assets/NPC/ClubInsideStatic/Dancer B", 0.7f, premultipliedAlpha: true)
	{
		base.Spine.StartAnimationWithLooping("Dance A");
		GetEmotion(EHeads.Happy, "Hair", "Head", "Jaw");
		GetPose(EPoses.Dancing, "Body", "Chest", "Tail");
		GetClothes(EPoses.Dancing, EClothes.Shirt, "Shirt")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._9mDS3yizOswyCzK6V3LBhafV7Dh();
		GetClothes(EPoses.Dancing, EClothes.Skirt, "Skirt")._dUWotuFGWMaIlD1IFkXcXUhjchR()._mgkfAuKt1tsSRmn1YmxkzbHikc();
		_J4giDjnRtYmiHMmzwRZ0ThvfAhH = true;
		_upl1k7yzBzlU7vErvbydGmXROfA = true;
	}
}
