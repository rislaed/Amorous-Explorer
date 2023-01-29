namespace Amorous.Game.NPC;

public class ClubEntranceABNPC : ClubStaticNPC
{
	public ClubEntranceABNPC(IAmorous game)
		: base(game, "Assets/NPC/ClubEntranceStatic", "A B", bool_0: true, bool_1: true)
	{
		base.Scale = 0.7f;
		NudesBehindShirt = true;
		NudesBehindPants = true;
	}
}
