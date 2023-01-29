using System;
using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class ClubDJNPC : SpineNPC<ClubDJNPC.EHeads, ClubDJNPC.EPoses, ClubDJNPC.EClothes>
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

	public static string Name = "Club Amorous DJ";
	public static Color Color = new Color(40, 122, 255);

	public ClubDJNPC(IAmorous game)
		: base(game, "Assets/NPC/ClubDJ/DJ", 0.6f, premultipliedAlpha: true)
	{
		Width = 400;
		Height = 600;
		base.Spine.StartAnimationWithLooping("Dance A");
		AddEmotion(EHeads.Smirk, "Ears", "Head");
		AddPose(EPoses.Dancing, "Arm right", "Body");
		AddClothes(EPoses.Dancing, EClothes.Shirt, "Shirt").AsShirt().AsNudes();
		AddClothes(EPoses.Dancing, EClothes.Pants, "Pants").AsPants().AsCloth();
		NudesBehindShirt = false;
		NudesBehindPants = true;
	}
}
