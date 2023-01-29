namespace Amorous.Game.NPC;

public class ClubInsideANPC : ClubStaticNPC
{
	public ClubInsideANPC(IAmorous game)
		: base(game, "Assets/NPC/ClubInsideStatic", "A", bool_0: true, bool_1: true)
	{
		base.Scale = 0.58f;
		NudesBehindShirt = false;
		NudesBehindPants = true;
	}
}
