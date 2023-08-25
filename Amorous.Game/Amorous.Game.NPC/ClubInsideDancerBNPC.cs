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
		base.Skeleton.StartAnimationWithLooping("Dance A");
		AddEmotion(EHeads.Happy, "Hair", "Head", "Jaw");
		AddPose(EPoses.Dancing, "Body", "Chest", "Tail");
		AddClothes(EPoses.Dancing, EClothes.Shirt, "Shirt").AsShirt().AsNudes();
		AddClothes(EPoses.Dancing, EClothes.Skirt, "Skirt").AsPants().AsCloth();
		NudesBehindShirt = true;
		NudesBehindPants = true;
	}
}
