namespace Amorous.Game.NPC;

public class ClubStaticSethNPC : ClubStaticNPC
{
	public ClubStaticSethNPC(IAmorous game)
		: base(game, "Assets/NPC/ClubStatic", "Seth", shirt: true, pants: true)
	{
		Width = 225;
		Height = 334;
		NudesBehindShirt = false;
		NudesBehindPants = true;
	}
}
