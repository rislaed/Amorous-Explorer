namespace Amorous.Game.NPC;

public class ClubPoolStaticMNPC : ClubStaticNPC
{
	public ClubPoolStaticMNPC(IAmorous game)
		: base(game, "Assets/NPC/ClubPoolStatic", "M", bool_0: false, bool_1: true)
	{
		NudesBehindShirt = false;
		NudesBehindPants = true;
	}
}
