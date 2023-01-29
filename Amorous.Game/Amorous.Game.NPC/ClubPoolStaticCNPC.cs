namespace Amorous.Game.NPC;

public class ClubPoolStaticCNPC : ClubPoolStaticNPC
{
	public ClubPoolStaticCNPC(IAmorous game)
		: base(game, "Assets/NPC/ClubPoolStatic", "C", shirt: false, pants: true)
	{
		Width = 413;
		Height = 680;
		_rlJEdnItzlU5efWtBjMCaC5Nizb = 570f;
		NudesBehindShirt = false;
		NudesBehindPants = true;
	}
}
