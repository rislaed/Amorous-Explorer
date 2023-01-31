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
		AddEmotion(EHeads.Smirk, "Head");
		AddPose(EPoses.Dancing, "Arm right", "Body", "Left forearm", "Tail").AddNudes("Cock");
		AddClothes(EPoses.Dancing, EClothes.Shirt, "Shirt", "Shirt arm right", "Shirt left forearm").AsShirt().AsNudes();
		AddClothes(EPoses.Dancing, EClothes.Pants, "Pants").AsPants().AsCloth();
		NudesBehindShirt = false;
		NudesBehindPants = true;
	}
}
