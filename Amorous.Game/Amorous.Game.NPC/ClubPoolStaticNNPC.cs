namespace Amorous.Game.NPC;

public class ClubPoolStaticNNPC : ClubStaticNPC
{
	public ClubPoolStaticNNPC(IAmorous game)
		: base(game, "Assets/NPC/ClubPoolStatic", "N", bool_0: false, bool_1: true)
	{
		NudesBehindShirt = true;
		NudesBehindPants = true;
	}
}
