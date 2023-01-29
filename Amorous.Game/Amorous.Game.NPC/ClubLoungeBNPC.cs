namespace Amorous.Game.NPC;

public class ClubLoungeBNPC : ClubStaticNPC
{
	public ClubLoungeBNPC(IAmorous game)
		: base(game, "Assets/NPC/ClubLoungeStatic", "B", bool_0: true, bool_1: true)
	{
		NudesBehindShirt = false;
		NudesBehindPants = true;
	}
}
