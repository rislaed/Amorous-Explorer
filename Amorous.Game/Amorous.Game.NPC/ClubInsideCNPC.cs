namespace Amorous.Game.NPC;

public class ClubInsideCNPC : ClubStaticNPC
{
	public ClubInsideCNPC(IAmorous game)
		: base(game, "Assets/NPC/ClubInsideStatic", "C", bool_0: true, bool_1: true)
	{
		base.Scale = 0.4f;
		NudesBehindShirt = false;
		NudesBehindPants = true;
	}
}
