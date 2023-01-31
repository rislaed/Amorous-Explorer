namespace Amorous.Game.NPC;

public class ClubPoolStaticOPNPC : ClubPoolStaticNPC
{
	public ClubPoolStaticOPNPC(IAmorous game)
		: base(game, "Assets/NPC/ClubPoolStatic", "O P", shirt: false, pants: true)
	{
		Width = 483;
		Height = 636;
		PoolMaskOffset = 450f;
		NudesBehindShirt = false;
		NudesBehindPants = true;
	}
}
