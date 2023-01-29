namespace Amorous.Game.NPC;

public class ClubEntranceABNPC : ClubStaticNPC
{
	public ClubEntranceABNPC(IAmorous game)
		: base(game, "Assets/NPC/ClubEntranceStatic", "A B", shirt: true, pants: true)
	{
		base.Scale = 0.7f;
		NudesBehindShirt = true;
		NudesBehindPants = true;
	}
}
