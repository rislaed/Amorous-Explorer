namespace Amorous.Game.NPC;

public class ClubPoolStaticJKNPC : ClubPoolStaticNPC
{
	public ClubPoolStaticJKNPC(IAmorous game)
		: base(game, "Assets/NPC/ClubPoolStatic", "J K", shirt: false, pants: true)
	{
		Width = 410;
		Height = 697;
		PoolMaskOffset = 500f;
		NudesBehindShirt = true;
		NudesBehindPants = true;
	}
}
