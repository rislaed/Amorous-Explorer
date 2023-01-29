namespace Amorous.Game.NPC;

public class ClubPoolStaticBNPC : ClubStaticNPC
{
	public ClubPoolStaticBNPC(IAmorous game)
		: base(game, "Assets/NPC/ClubPoolStatic", "B", bool_0: true, bool_1: true)
	{
		NudesBehindShirt = true;
		NudesBehindPants = true;
	}
}
