using System;
using Amorous.Engine.NPC;

namespace Amorous.Game.NPC;

public abstract class ClubStaticSpineNPC : SpineNPC<ClubStaticSpineNPC.EHeads, ClubStaticSpineNPC.EPoses, ClubStaticSpineNPC.EClothes>
{
	public enum EHeads
	{
		None
	}

	public enum EPoses
	{
		None,
		Nude
	}

	public enum EClothes
	{
		None,
		Shirt,
		Pants
	}

	protected ClubStaticSpineNPC(IAmorous game, string path, string[] poses, string[] shirts = null, string[] pants = null)
		: base(game, path, 1f, premultipliedAlpha: true)
	{
		GetPose(EPoses.Nude, poses);
		if (shirts != null)
		{
			GetClothes(EPoses.Nude, EClothes.Shirt, shirts)._XJUU6QdUDN3lYoRweLWOMaWqcUE()._9mDS3yizOswyCzK6V3LBhafV7Dh();
		}
		if (pants != null)
		{
			GetClothes(EPoses.Nude, EClothes.Pants, pants)._dUWotuFGWMaIlD1IFkXcXUhjchR()._mgkfAuKt1tsSRmn1YmxkzbHikc();
		}
	}

	public override void Begin()
	{
		base.Begin();
		SetEmotion(EHeads.None);
		SetPose(EPoses.Nude);
		SetClothes(EClothes.Shirt, EClothes.Pants);
		base.Spine.StartAnimationWithLooping("animation");
	}
}
