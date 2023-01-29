namespace Amorous.Game.NPC;

public class ClubInsideGNPC : ClubStaticNPC
{
	public ClubInsideGNPC(IAmorous game)
		: base(game, "Assets/NPC/ClubInsideStatic", "G", shirt: true, pants: true)
	{
		base.Scale = 0.37f;
		NudesBehindShirt = false;
		NudesBehindPants = true;
	}
}
