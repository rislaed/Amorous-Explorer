namespace Amorous.Game.NPC;

public class ClubPoolStaticQRNPC : ClubStaticNPC
{
	public ClubPoolStaticQRNPC(IAmorous game)
		: base(game, "Assets/NPC/ClubPoolStatic", "Q R", bool_0: false, bool_1: true)
	{
		NudesBehindShirt = true;
		NudesBehindPants = true;
	}
}
