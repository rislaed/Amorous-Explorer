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

	protected ClubStaticSpineNPC(IAmorous game, string path, string[] bones, string[] shirts = null, string[] pants = null)
		: base(game, path, 1f, premultipliedAlpha: true)
	{
		AddPose(EPoses.Nude, bones);
		if (shirts != null)
		{
			AddClothes(EPoses.Nude, EClothes.Shirt, shirts).AsShirt().AsNudes();
		}
		if (pants != null)
		{
			AddClothes(EPoses.Nude, EClothes.Pants, pants).AsPants().AsCloth();
		}
	}

	public override void Start()
	{
		base.Start();
		SetEmotion(EHeads.None);
		SetPose(EPoses.Nude);
		SetClothes(EClothes.Shirt, EClothes.Pants);
		base.Skeleton.StartAnimationWithLooping("animation");
	}
}
