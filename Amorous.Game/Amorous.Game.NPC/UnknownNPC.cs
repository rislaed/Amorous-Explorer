using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class UnknownNPC : LayerNPC<UnknownNPC.EHeads, UnknownNPC.EPoses, UnknownNPC.EClothes>
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

	public static string Name = "Unknown";

	public static Color Color = new Color(255, 0, 255);

	public UnknownNPC(IAmorous game)
		: base(game, string.Empty, 1f)
	{
	}
}
