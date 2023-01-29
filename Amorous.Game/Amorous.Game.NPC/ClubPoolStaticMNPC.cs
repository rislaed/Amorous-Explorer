namespace Amorous.Game.NPC;

public class ClubPoolStaticMNPC : ClubStaticNPC
{
	public ClubPoolStaticMNPC(IAmorous game)
		: base(game, "Assets/NPC/ClubPoolStatic", "M", shirt: false, pants: true)
	{
		NudesBehindShirt = false;
		NudesBehindPants = true;
	}
}
