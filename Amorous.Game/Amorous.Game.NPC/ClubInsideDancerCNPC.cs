using System;
using Amorous.Engine.NPC;

namespace Amorous.Game.NPC;

public class ClubInsideDancerCNPC : SpineNPC<ClubInsideDancerCNPC.EHeads, ClubInsideDancerCNPC.EPoses, ClubInsideDancerCNPC.EClothes>
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
		Shorts
	}

	public ClubInsideDancerCNPC(IAmorous game)
		: base(game, "Assets/NPC/ClubInsideStatic/Dancer C", 0.7f, premultipliedAlpha: true)
	{
		base.Spine.StartAnimationWithLooping("Dance A");
		GetEmotion(EHeads.Smirk, "Head", "Pupil", "eye");
		GetPose(EPoses.Dancing, "Arm close", "Character");
		GetClothes(EPoses.Dancing, EClothes.Shorts, "Shorts")._dUWotuFGWMaIlD1IFkXcXUhjchR()._mgkfAuKt1tsSRmn1YmxkzbHikc();
		_J4giDjnRtYmiHMmzwRZ0ThvfAhH = false;
		_upl1k7yzBzlU7vErvbydGmXROfA = true;
	}
}
