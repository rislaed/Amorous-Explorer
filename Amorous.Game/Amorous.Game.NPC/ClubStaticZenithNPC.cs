namespace Amorous.Game.NPC;

public class ClubStaticZenithNPC : ClubStaticNPC
{
	public ClubStaticZenithNPC(IAmorous game)
		: base(game, "Assets/NPC/ClubStatic", "Zenith", bool_0: true, bool_1: true)
	{
		Width = 299;
		Height = 765;
		NudesBehindShirt = false;
		NudesBehindPants = true;
	}
}
