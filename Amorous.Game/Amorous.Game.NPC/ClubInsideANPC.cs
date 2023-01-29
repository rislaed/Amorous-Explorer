namespace Amorous.Game.NPC;

public class ClubInsideANPC : ClubStaticNPC
{
	public ClubInsideANPC(IAmorous game)
		: base(game, "Assets/NPC/ClubInsideStatic", "A", shirt: true, pants: true)
	{
		base.Scale = 0.58f;
		NudesBehindShirt = false;
		NudesBehindPants = true;
	}
}
