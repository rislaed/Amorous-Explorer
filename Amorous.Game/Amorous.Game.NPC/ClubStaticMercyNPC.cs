namespace Amorous.Game.NPC;

public class ClubStaticMercyNPC : ClubStaticNPC
{
	public ClubStaticMercyNPC(IAmorous game)
		: base(game, "Assets/NPC/ClubStatic", "Mercy", shirt: true, pants: false)
	{
		Width = 291;
		Height = 492;
		NudesBehindShirt = true;
		NudesBehindPants = true;
	}
}
