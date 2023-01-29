using Amorous.Engine.NPC;

namespace Amorous.Game.NPC;

public abstract class ClubStaticNPC : LayerNPC<ClubStaticNPC.EHeads, ClubStaticNPC.EPoses, ClubStaticNPC.EClothes>
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

	protected ClubStaticNPC(IAmorous game, string sprite, string part, bool shirt, bool pants)
		: base(game, sprite, 1f)
	{
		AddPose(EPoses.Nude, $"{part} club nude");
		if (shirt)
		{
			AddClothes(EPoses.Nude, EClothes.Shirt, $"{part} club shirt").AsShirt();
		}
		if (pants)
		{
			AddClothes(EPoses.Nude, EClothes.Pants, $"{part} club pants").AsPants();
		}
	}

	public override void Start()
	{
		base.Start();
		SetEmotion(EHeads.None);
		SetPose(EPoses.Nude);
		SetClothes(EClothes.Shirt, EClothes.Pants);
	}
}
