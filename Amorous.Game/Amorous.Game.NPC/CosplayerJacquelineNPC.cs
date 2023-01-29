using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class CosplayerJacquelineNPC : LayerNPC<CosplayerJacquelineNPC.EHeads, CosplayerJacquelineNPC.EPoses, CosplayerJacquelineNPC.EClothes>
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

	public static string Name = "Jacqueline Knight";

	public static Color Color = new Color(138, 148, 170);

	public CosplayerJacquelineNPC(IAmorous game)
		: base(game, "Assets/NPC/CosplayerJacqueline", 1f)
	{
		AddPose(EPoses.Standing, "Jacqueline Knight (nude)");
		AddClothes(EPoses.Standing, EClothes.Shirt, "Jacqueline Knight (shirt)").AsShirt().AsNudes();
		AddClothes(EPoses.Standing, EClothes.Pants, "Jacqueline Knight (pants)").AsPants().AsCloth();
		NudesBehindShirt = true;
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
			X = -200f;
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
