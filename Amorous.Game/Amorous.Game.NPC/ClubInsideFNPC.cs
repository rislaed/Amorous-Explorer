namespace Amorous.Game.NPC;

public class ClubInsideFNPC : ClubStaticNPC
{
	public ClubInsideFNPC(IAmorous game)
		: base(game, "Assets/NPC/ClubInsideStatic", "F", bool_0: true, bool_1: true)
	{
		base.Scale = 0.37f;
		NudesBehindShirt = false;
		NudesBehindPants = true;
	}
}
