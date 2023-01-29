namespace Amorous.Game.NPC;

public class ClubStaticSkyeNPC : ClubStaticNPC
{
	public ClubStaticSkyeNPC(IAmorous game)
		: base(game, "Assets/NPC/ClubStatic", "Skye", shirt: true, pants: true)
	{
		Width = 230;
		Height = 211;
		NudesBehindShirt = false;
		NudesBehindPants = true;
	}
}
