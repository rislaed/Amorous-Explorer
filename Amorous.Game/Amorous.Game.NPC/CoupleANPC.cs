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
		base.Skeleton.StartAnimationWithLooping("Waving");
		AddPose(EPoses.Waving, "Skunk arm back", "Characters left", "Silver arm");
		AddClothes(EPoses.Waving, EClothes.Shirt, "Shirts").AsShirt();
		AddClothes(EPoses.Waving, EClothes.Pants, "Pants").AsPants();
		NudesBehindShirt = false;
		NudesBehindPants = true;
	}
}
