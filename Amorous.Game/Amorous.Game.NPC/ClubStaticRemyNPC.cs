namespace Amorous.Game.NPC;

public class ClubStaticRemyNPC : ClubStaticNPC
{
	public ClubStaticRemyNPC(IAmorous game)
		: base(game, "Assets/NPC/ClubStatic", "Remy", shirt: true, pants: true)
	{
		Width = 128;
		Height = 414;
		NudesBehindShirt = true;
		NudesBehindPants = true;
	}
}
