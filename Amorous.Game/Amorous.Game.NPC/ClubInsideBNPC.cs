namespace Amorous.Game.NPC;

public class ClubInsideBNPC : ClubStaticNPC
{
	public ClubInsideBNPC(IAmorous game)
		: base(game, "Assets/NPC/ClubInsideStatic", "B", bool_0: true, bool_1: true)
	{
		base.Scale = 0.42f;
		NudesBehindShirt = false;
		NudesBehindPants = true;
	}
}
