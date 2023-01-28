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
		GetEmotion(EHeads.Smirk, "Ears", "Head");
		GetPose(EPoses.Dancing, "Arm right", "Body");
		GetClothes(EPoses.Dancing, EClothes.Shirt, "Shirt")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._9mDS3yizOswyCzK6V3LBhafV7Dh();
		GetClothes(EPoses.Dancing, EClothes.Pants, "Pants")._dUWotuFGWMaIlD1IFkXcXUhjchR()._mgkfAuKt1tsSRmn1YmxkzbHikc();
		_J4giDjnRtYmiHMmzwRZ0ThvfAhH = false;
		_upl1k7yzBzlU7vErvbydGmXROfA = true;
	}
}
