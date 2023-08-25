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
		base.Skeleton.StartAnimationWithLooping("Dance A");
		AddEmotion(EHeads.Smirk, "Head", "Pupil", "eye");
		AddPose(EPoses.Dancing, "Arm close", "Character");
		AddClothes(EPoses.Dancing, EClothes.Shorts, "Shorts").AsPants().AsCloth();
		NudesBehindShirt = false;
		NudesBehindPants = true;
	}
}
