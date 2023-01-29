namespace Amorous.Game.NPC;

public class ClubEntranceCNPC : ClubStaticNPC
{
	public ClubEntranceCNPC(IAmorous game)
		: base(game, "Assets/NPC/ClubEntranceStatic", "C", bool_0: true, bool_1: true)
	{
		base.Scale = 0.7f;
		NudesBehindShirt = true;
		NudesBehindPants = true;
	}
}
