namespace Amorous.Game.NPC;

public class ClubLoungeANPC : ClubStaticNPC
{
	public ClubLoungeANPC(IAmorous game)
		: base(game, "Assets/NPC/ClubLoungeStatic", "A", bool_0: true, bool_1: false)
	{
		NudesBehindShirt = false;
		NudesBehindPants = true;
	}
}
