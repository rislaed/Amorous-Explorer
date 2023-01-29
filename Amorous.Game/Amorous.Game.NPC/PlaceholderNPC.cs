using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class PlaceholderNPC : LayerNPC<PlaceholderNPC.EHeads, PlaceholderNPC.EPoses, PlaceholderNPC.EClothes>
{
	public enum EHeads
	{
		None
	}

	public enum EPoses
	{
		None,
		Placeholder
	}

	public enum EClothes
	{
		None
	}

	public static string Name = "Placeholder";

	public static Color Color = new Color(255, 0, 255);

	public PlaceholderNPC(IAmorous game)
		: base(game, "Assets/NPC/Placeholder", 1f)
	{
		AddPose(EPoses.Placeholder, "Placeholder");
	}

	public override void SetLocation(NPCLocation location)
	{
		base.SetLocation(location);
		switch (location)
		{
		case NPCLocation.Middle:
			FlipX = false;
			X = 685f;
			Y = 100f;
			break;
		case NPCLocation.Left:
			FlipX = true;
			X = 100f;
			Y = 100f;
			break;
		case NPCLocation.Right:
			FlipX = false;
			X = 1270f;
			Y = 100f;
			break;
		}
	}
}
