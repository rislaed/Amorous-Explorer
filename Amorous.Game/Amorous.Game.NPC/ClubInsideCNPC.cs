namespace Amorous.Game.NPC;

public class ClubInsideCNPC : ClubStaticNPC
{
	public ClubInsideCNPC(IAmorous game)
		: base(game, "Assets/NPC/ClubInsideStatic", "C", shirt: true, pants: true)
	{
		base.Scale = 0.4f;
		NudesBehindShirt = false;
		NudesBehindPants = true;
	}
}
