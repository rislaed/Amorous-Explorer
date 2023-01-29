namespace Amorous.Game.NPC;

public class ClubLoungeANPC : ClubStaticNPC
{
	public ClubLoungeANPC(IAmorous game)
		: base(game, "Assets/NPC/ClubLoungeStatic", "A", shirt: true, pants: false)
	{
		NudesBehindShirt = false;
		NudesBehindPants = true;
	}
}
