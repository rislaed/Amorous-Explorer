namespace Amorous.Game.NPC;

public class ClubPoolStaticLNPC : ClubStaticNPC
{
	public ClubPoolStaticLNPC(IAmorous game)
		: base(game, "Assets/NPC/ClubPoolStatic", "L", shirt: false, pants: true)
	{
		NudesBehindShirt = false;
		NudesBehindPants = true;
	}
}
