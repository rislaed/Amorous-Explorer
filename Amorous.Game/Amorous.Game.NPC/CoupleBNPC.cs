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
		: base(game, "Assets/Scenes/Intro/Couple B", 1f, premultipliedAlpha: true)
	{
		base.Spine.StartAnimationWithLooping("Waving");
		AddPose(EPoses.Waving, "Dark arm", "Characters right", "fem arms");
		AddClothes(EPoses.Waving, EClothes.Shirt, "Shirts right").AsShirt();
		AddClothes(EPoses.Waving, EClothes.Pants, "Pants right").AsPants();
		NudesBehindShirt = true;
		NudesBehindPants = true;
	}
}
