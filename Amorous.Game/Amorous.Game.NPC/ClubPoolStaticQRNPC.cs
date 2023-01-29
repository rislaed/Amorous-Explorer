namespace Amorous.Game.NPC;

public class ClubPoolStaticQRNPC : ClubStaticNPC
{
	public ClubPoolStaticQRNPC(IAmorous game)
		: base(game, "Assets/NPC/ClubPoolStatic", "Q R", shirt: false, pants: true)
	{
		NudesBehindShirt = true;
		NudesBehindPants = true;
	}
}
