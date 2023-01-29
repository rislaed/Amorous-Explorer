namespace Amorous.Game.NPC;

public class ClubStaticDustinNPC : ClubStaticNPC
{
	public ClubStaticDustinNPC(IAmorous game)
		: base(game, "Assets/NPC/ClubStatic", "Dustin", shirt: true, pants: true)
	{
		Width = 214;
		Height = 588;
		NudesBehindShirt = false;
		NudesBehindPants = true;
	}
}
