namespace Amorous.Game.NPC;

public class ClubPoolStaticGHINPC : ClubPoolStaticNPC
{
	public ClubPoolStaticGHINPC(IAmorous game)
		: base(game, "Assets/NPC/ClubPoolStatic", "G H I", shirt: false, pants: false)
	{
		Width = 601;
		Height = 587;
		PoolMaskOffset = 330f;
		NudesBehindShirt = true;
		NudesBehindPants = true;
	}
}
