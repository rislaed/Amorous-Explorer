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

	protected ClubStaticSpineNPC(IAmorous game, string string_0, string[] string_1, string[] string_2 = null, string[] string_3 = null)
		: base(game, string_0, 1f, bool_0: true)
	{
		GetPose(EPoses.Nude, string_1);
		if (string_2 != null)
		{
			GetClothes(EPoses.Nude, EClothes.Shirt, string_2)._XJUU6QdUDN3lYoRweLWOMaWqcUE()._9mDS3yizOswyCzK6V3LBhafV7Dh();
		}
		if (string_3 != null)
		{
			GetClothes(EPoses.Nude, EClothes.Pants, string_3)._dUWotuFGWMaIlD1IFkXcXUhjchR()._mgkfAuKt1tsSRmn1YmxkzbHikc();
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
