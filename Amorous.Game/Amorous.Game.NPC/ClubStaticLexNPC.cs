namespace Amorous.Game.NPC;

public class ClubStaticLexNPC : ClubStaticNPC
{
	public ClubStaticLexNPC(IAmorous game)
		: base(game, "Assets/NPC/ClubStatic", "Lex", shirt: true, pants: true)
	{
		Width = 372;
		Height = 762;
		NudesBehindShirt = false;
		NudesBehindPants = true;
	}
}
