namespace Amorous.Game.NPC;

public class ClubLoungeCNPC : ClubStaticNPC
{
	public ClubLoungeCNPC(IAmorous game)
		: base(game, "Assets/NPC/ClubLoungeStatic", "C", bool_0: true, bool_1: true)
	{
		NudesBehindShirt = false;
		NudesBehindPants = true;
	}
}
