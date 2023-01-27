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

	public ClubLoungeDancerANPC(IAmorous game)
		: base(game, "Assets/NPC/ClubLoungeStatic/Dancer A", 1f, bool_0: true)
	{
		base.Spine.StartAnimationWithLooping("animation");
		GetEmotion(EHeads.Smirk, "Ear", "Eye back", "Fringe", "Head", "Pupil");
		GetPose(EPoses.Dancing, "Arms", "Body", "Breast", "Leg left", "Leg right", "Tail base", "Tail head", "Tail head jaw", "Tail head tongue tip");
		GetClothes(EPoses.Dancing, EClothes.Shirt, "Shirt")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._9mDS3yizOswyCzK6V3LBhafV7Dh();
		GetClothes(EPoses.Dancing, EClothes.Shorts, "Shorts left", "Shorts right")._dUWotuFGWMaIlD1IFkXcXUhjchR()._mgkfAuKt1tsSRmn1YmxkzbHikc();
		_J4giDjnRtYmiHMmzwRZ0ThvfAhH = true;
		_upl1k7yzBzlU7vErvbydGmXROfA = true;
	}
}
