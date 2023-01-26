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
		: base(Game, "Assets/NPC/Placeholder", 1f)
	{
		_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Placeholder, "Placeholder");
	}

	public override void SetLocation(NPCLocation npclocation_0)
	{
		base.SetLocation(npclocation_0);
		switch (npclocation_0)
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
