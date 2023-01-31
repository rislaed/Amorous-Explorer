using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class CosplayerHaneNPC : LayerNPC<CosplayerHaneNPC.EHeads, CosplayerHaneNPC.EPoses, CosplayerHaneNPC.EClothes>
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
		Jacket
	}

	public static string Name = "Hane Maxwell";
	public static Color Color = new Color(186, 78, 60);

	public CosplayerHaneNPC(IAmorous game)
		: base(game, "Assets/NPC/CosplayerHane", 1f)
	{
		AddPose(EPoses.Standing, "Hane Maxwell Cosplayer (nude)");
		AddClothes(EPoses.Standing, EClothes.Jacket, "Hane Maxwell Cosplayer (clothed)").AsShirt().AsNudes();
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
				X = -190f;
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
