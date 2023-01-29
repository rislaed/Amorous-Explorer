namespace Amorous.Game.NPC;

public class ClubStaticSkyeNPC : ClubStaticNPC
{
	public ClubStaticSkyeNPC(IAmorous game)
		: base(game, "Assets/NPC/ClubStatic", "Skye", bool_0: true, bool_1: true)
	{
		Width = 230;
		Height = 211;
		NudesBehindShirt = false;
		NudesBehindPants = true;
	}
}
