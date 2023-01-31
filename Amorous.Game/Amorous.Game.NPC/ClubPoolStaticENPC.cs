namespace Amorous.Game.NPC;

public class ClubPoolStaticENPC : ClubStaticSpineNPC
{
	private static readonly string[] Bones = new string[8] { "Bar cover", "Chest", "Forearm back", "Forearm front", "Head", "Shaker", "Shoulder back", "Shoulder front" };

	public ClubPoolStaticENPC(IAmorous game)
		: base(game, "Assets/NPC/ClubPoolStatic/E club", Bones)
	{
		NudesBehindShirt = false;
		NudesBehindPants = true;
	}
}
