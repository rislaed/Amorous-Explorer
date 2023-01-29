namespace Amorous.Game.NPC;

public class ClubStaticMercyNPC : ClubStaticNPC
{
	public ClubStaticMercyNPC(IAmorous game)
		: base(game, "Assets/NPC/ClubStatic", "Mercy", bool_0: true, bool_1: false)
	{
		Width = 291;
		Height = 492;
		NudesBehindShirt = true;
		NudesBehindPants = true;
	}
}
