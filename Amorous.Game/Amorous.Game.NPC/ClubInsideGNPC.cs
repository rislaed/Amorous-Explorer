namespace Amorous.Game.NPC;

public class ClubInsideGNPC : ClubStaticNPC
{
	public ClubInsideGNPC(IAmorous game)
		: base(game, "Assets/NPC/ClubInsideStatic", "G", bool_0: true, bool_1: true)
	{
		base.Scale = 0.37f;
		NudesBehindShirt = false;
		NudesBehindPants = true;
	}
}
