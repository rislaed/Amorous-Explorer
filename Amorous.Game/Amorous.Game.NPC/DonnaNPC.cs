using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class DonnaNPC : LayerNPC<DonnaNPC.EHeads, DonnaNPC.EPoses, DonnaNPC.EClothes>
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

	public static string Name = "Donna";

	public static Color Color = new Color(255, 0, 255);

	public DonnaNPC(IAmorous game)
		: base(Game, string.Empty, 1f)
	{
	}
}
