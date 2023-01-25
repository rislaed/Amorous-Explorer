using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class TeamAmorousNPC : LayerNPC<TeamAmorousNPC.EHeads, TeamAmorousNPC.EPoses, TeamAmorousNPC.EClothes>
{
	public enum EHeads
	{
		None
	}

	public enum EPoses
	{
		None
	}

	public enum EClothes
	{
		None
	}

	public static string Name = "Team Amorous";

	public static Color Color = new Color(255, 160, 255);

	public TeamAmorousNPC(IAmorous game)
		: base(Game, string.Empty, 1f)
	{
	}
}
