namespace Amorous.Game.NPC;

public class ClubStaticLexNPC : ClubStaticNPC
{
	public ClubStaticLexNPC(IAmorous game)
		: base(game, "Assets/NPC/ClubStatic", "Lex", bool_0: true, bool_1: true)
	{
		Width = 372;
		Height = 762;
		NudesBehindShirt = false;
		NudesBehindPants = true;
	}
}
