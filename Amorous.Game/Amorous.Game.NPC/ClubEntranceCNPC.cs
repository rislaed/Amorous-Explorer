namespace Amorous.Game.NPC;

public class ClubEntranceCNPC : ClubStaticNPC
{
	public ClubEntranceCNPC(IAmorous game)
		: base(game, "Assets/NPC/ClubEntranceStatic", "C", shirt: true, pants: true)
	{
		base.Scale = 0.7f;
		NudesBehindShirt = true;
		NudesBehindPants = true;
	}
}
