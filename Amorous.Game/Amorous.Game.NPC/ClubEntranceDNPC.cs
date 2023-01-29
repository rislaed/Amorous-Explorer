namespace Amorous.Game.NPC;

public class ClubEntranceDNPC : ClubStaticNPC
{
	public ClubEntranceDNPC(IAmorous game)
		: base(game, "Assets/NPC/ClubEntranceStatic", "D", bool_0: true, bool_1: true)
	{
		base.Scale = 0.7f;
		NudesBehindShirt = false;
		NudesBehindPants = true;
	}
}
