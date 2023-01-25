using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class GangBNPC : LayerNPC<GangBNPC.EHeads, GangBNPC.EPoses, GangBNPC.EClothes>
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

	public static string Name = "Taylor";

	public static Color Color = new Color(103, 23, 183);

	public GangBNPC(IAmorous game)
		: base(Game, string.Empty, 1f)
	{
	}
}
