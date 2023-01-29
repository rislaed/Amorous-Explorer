namespace Amorous.Game.NPC;

public class ClubEntranceDNPC : ClubStaticNPC
{
	public ClubEntranceDNPC(IAmorous game)
		: base(game, "Assets/NPC/ClubEntranceStatic", "D", shirt: true, pants: true)
	{
		base.Scale = 0.7f;
		NudesBehindShirt = false;
		NudesBehindPants = true;
	}
}
