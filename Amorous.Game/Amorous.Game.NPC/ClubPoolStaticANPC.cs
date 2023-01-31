namespace Amorous.Game.NPC;

public class ClubPoolStaticANPC : ClubStaticSpineNPC
{
	private static readonly string[] Bones = new string[9] { "Arm left", "Body", "Forearm right", "Hair", "Hand", "Head", "Scrub", "Shoulder right", "Tail" };
	private static readonly string[] Pants = new string[1] { "Shorts" };

	public ClubPoolStaticANPC(IAmorous game)
		: base(game, "Assets/NPC/ClubPoolStatic/A club", Bones, null, Pants)
	{
		NudesBehindShirt = false;
		NudesBehindPants = true;
	}
}
