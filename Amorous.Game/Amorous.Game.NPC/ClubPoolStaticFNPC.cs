namespace Amorous.Game.NPC;

public class ClubPoolStaticFNPC : ClubStaticNPC
{
	public ClubPoolStaticFNPC(IAmorous game)
		: base(game, "Assets/NPC/ClubPoolStatic", "F", bool_0: false, bool_1: true)
	{
		NudesBehindShirt = false;
		NudesBehindPants = true;
	}
}
