namespace Amorous.Game.NPC;

public class ClubInsideDNPC : ClubStaticNPC
{
	public ClubInsideDNPC(IAmorous game)
		: base(game, "Assets/NPC/ClubInsideStatic", "D", shirt: true, pants: true)
	{
		base.Scale = 0.4f;
		NudesBehindShirt = false;
		NudesBehindPants = true;
	}
}
