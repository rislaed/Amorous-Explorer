using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class GamestoreClerkNPC : LayerNPC<GamestoreClerkNPC.EHeads, GamestoreClerkNPC.EPoses, GamestoreClerkNPC.EClothes>
{
	public enum EHeads
	{
		None
	}

	public enum EPoses
	{
		None,
		Standing
	}

	public enum EClothes
	{
		None,
		Shirt,
		Pants
	}

	public static string Name = "Game Store Clerk";
	public static Color Color = new Color(252, 137, 76);

	public GamestoreClerkNPC(IAmorous game) : base(game, "Assets/NPC/GamestoreClerk", 1f)
	{
		AddPose(EPoses.Standing, "Kula Game Store Clerk (nude)");
		AddClothes(EPoses.Standing, EClothes.Pants, "Kula Game Store Clerk (pants)").AsPants().AsCloth();
		AddClothes(EPoses.Standing, EClothes.Shirt, "Kula Game Store Clerk (shirt)").AsShirt().AsNudes();
		NudesBehindShirt = false;
		NudesBehindPants = true;
	}

	public override void SetLocation(NPCLocation location)
	{
		base.SetLocation(location);
		switch (location)
		{
			case NPCLocation.Middle:
				FlipX = false;
				X = 545f;
				Y = 0f;
				break;
			case NPCLocation.Left:
				FlipX = true;
				X = -80f;
				Y = 0f;
				break;
			case NPCLocation.Right:
				FlipX = false;
				X = 1166f;
				Y = 0f;
				break;
		}
	}
}
