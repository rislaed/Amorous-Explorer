using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class CosplayerLexyNPC : LayerNPC<CosplayerLexyNPC.EHeads, CosplayerLexyNPC.EPoses, CosplayerLexyNPC.EClothes>
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
		Costume
	}

	public static string Name = "Lexy";

	public static Color Color = new Color(60, 128, 241);

	public CosplayerLexyNPC(IAmorous game)
		: base(game, "Assets/NPC/CosplayerLexy", 1f)
	{
		AddPose(EPoses.Standing, "Lexy Cosplayer (nude)").AddNudes("Lexy Cosplayer (fringe for nude)");
		AddClothes(EPoses.Standing, EClothes.Costume, "Lexy Cosplayer (clothed)").AsShirt().AsPants().AsCloth();
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
			X = 413f;
			Y = 0f;
			break;
		case NPCLocation.Left:
			FlipX = true;
			X = -280f;
			Y = 0f;
			break;
		case NPCLocation.Right:
			FlipX = false;
			X = 1016f;
			Y = 0f;
			break;
		}
	}
}
