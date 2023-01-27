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

	protected ClubStaticNPC(IAmorous game, string string_0, string string_1, bool bool_0, bool bool_1)
		: base(game, string_0, 1f)
	{
		GetPose(EPoses.Nude, $"{string_1} club nude");
		if (bool_0)
		{
			GetClothes(EPoses.Nude, EClothes.Shirt, $"{string_1} club shirt")._XJUU6QdUDN3lYoRweLWOMaWqcUE();
		}
		if (bool_1)
		{
			GetClothes(EPoses.Nude, EClothes.Pants, $"{string_1} club pants")._dUWotuFGWMaIlD1IFkXcXUhjchR();
		}
	}

	public override void Begin()
	{
		base.Begin();
		SetEmotion(EHeads.None);
		SetPose(EPoses.Nude);
		SetClothes(EClothes.Shirt, EClothes.Pants);
	}
}
