namespace Amorous.Game.NPC;

public class ClubInsideDNPC : ClubStaticNPC
{
	public ClubInsideDNPC(IAmorous game)
		: base(game, "Assets/NPC/ClubInsideStatic", "D", bool_0: true, bool_1: true)
	{
		base.Scale = 0.4f;
		NudesBehindShirt = false;
		NudesBehindPants = true;
	}
}
