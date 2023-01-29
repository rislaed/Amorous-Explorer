namespace Amorous.Game.NPC;

public class ClubPoolStaticNNPC : ClubStaticNPC
{
	public ClubPoolStaticNNPC(IAmorous game)
		: base(game, "Assets/NPC/ClubPoolStatic", "N", shirt: false, pants: true)
	{
		NudesBehindShirt = true;
		NudesBehindPants = true;
	}
}
