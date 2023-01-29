namespace Amorous.Game.NPC;

public class ClubLoungeCNPC : ClubStaticNPC
{
	public ClubLoungeCNPC(IAmorous game)
		: base(game, "Assets/NPC/ClubLoungeStatic", "C", shirt: true, pants: true)
	{
		NudesBehindShirt = false;
		NudesBehindPants = true;
	}
}
