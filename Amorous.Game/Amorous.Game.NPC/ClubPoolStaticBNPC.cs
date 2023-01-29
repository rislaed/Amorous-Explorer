namespace Amorous.Game.NPC;

public class ClubPoolStaticBNPC : ClubStaticNPC
{
	public ClubPoolStaticBNPC(IAmorous game)
		: base(game, "Assets/NPC/ClubPoolStatic", "B", shirt: true, pants: true)
	{
		NudesBehindShirt = true;
		NudesBehindPants = true;
	}
}
