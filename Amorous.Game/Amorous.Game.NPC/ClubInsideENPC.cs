namespace Amorous.Game.NPC;

public class ClubInsideENPC : ClubStaticNPC
{
	public ClubInsideENPC(IAmorous game)
		: base(game, "Assets/NPC/ClubInsideStatic", "E", shirt: true, pants: true)
	{
		base.Scale = 0.32f;
		NudesBehindShirt = true;
		NudesBehindPants = true;
	}
}
