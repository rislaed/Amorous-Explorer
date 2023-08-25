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
		: base(game, "Assets/NPC/ClubLoungeStatic/Dancer A", 1f, premultipliedAlpha: true)
	{
		base.Skeleton.StartAnimationWithLooping("animation");
		AddEmotion(EHeads.Smirk, "Ear", "Eye back", "Fringe", "Head", "Pupil");
		AddPose(EPoses.Dancing, "Arms", "Body", "Breast", "Leg left", "Leg right", "Tail base", "Tail head", "Tail head jaw", "Tail head tongue tip");
		AddClothes(EPoses.Dancing, EClothes.Shirt, "Shirt").AsShirt().AsNudes();
		AddClothes(EPoses.Dancing, EClothes.Shorts, "Shorts left", "Shorts right").AsPants().AsCloth();
		NudesBehindShirt = true;
		NudesBehindPants = true;
	}
}
