namespace Amorous.Game.NPC;

public class ClubPoolStaticFNPC : ClubStaticNPC
{
	public ClubPoolStaticFNPC(IAmorous game)
		: base(game, "Assets/NPC/ClubPoolStatic", "F", shirt: false, pants: true)
	{
		NudesBehindShirt = false;
		NudesBehindPants = true;
	}
}
