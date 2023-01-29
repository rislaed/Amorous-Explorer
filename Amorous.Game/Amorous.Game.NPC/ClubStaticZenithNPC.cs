namespace Amorous.Game.NPC;

public class ClubStaticZenithNPC : ClubStaticNPC
{
	public ClubStaticZenithNPC(IAmorous game)
		: base(game, "Assets/NPC/ClubStatic", "Zenith", shirt: true, pants: true)
	{
		Width = 299;
		Height = 765;
		NudesBehindShirt = false;
		NudesBehindPants = true;
	}
}
