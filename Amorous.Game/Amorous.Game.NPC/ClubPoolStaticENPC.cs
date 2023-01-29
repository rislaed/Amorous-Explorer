namespace Amorous.Game.NPC;

public class ClubPoolStaticENPC : ClubStaticSpineNPC
{
	private static readonly string[] _faT8q4ZAxVWFlC2DnvTQkGsQ8Dh = new string[8] { "Bar cover", "Chest", "Forearm back", "Forearm front", "Head", "Shaker", "Shoulder back", "Shoulder front" };

	public ClubPoolStaticENPC(IAmorous game)
		: base(game, "Assets/NPC/ClubPoolStatic/E club", _faT8q4ZAxVWFlC2DnvTQkGsQ8Dh)
	{
		NudesBehindShirt = false;
		NudesBehindPants = true;
	}
}
