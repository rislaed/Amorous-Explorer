namespace Amorous.Game.NPC;

public class ClubPoolStaticLNPC : ClubStaticNPC
{
	public ClubPoolStaticLNPC(IAmorous game)
		: base(game, "Assets/NPC/ClubPoolStatic", "L", bool_0: false, bool_1: true)
	{
		NudesBehindShirt = false;
		NudesBehindPants = true;
	}
}
