namespace Amorous.Game.NPC;

public class ClubInsideENPC : ClubStaticNPC
{
	public ClubInsideENPC(IAmorous game)
		: base(game, "Assets/NPC/ClubInsideStatic", "E", bool_0: true, bool_1: true)
	{
		base.Scale = 0.32f;
		NudesBehindShirt = true;
		NudesBehindPants = true;
	}
}
