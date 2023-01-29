namespace Amorous.Game.NPC;

public class ClubLoungeBNPC : ClubStaticNPC
{
	public ClubLoungeBNPC(IAmorous game)
		: base(game, "Assets/NPC/ClubLoungeStatic", "B", shirt: true, pants: true)
	{
		NudesBehindShirt = false;
		NudesBehindPants = true;
	}
}
