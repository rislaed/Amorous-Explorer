namespace Amorous.Game.NPC;

public class ClubPoolStaticANPC : ClubStaticSpineNPC
{
	private static readonly string[] _faT8q4ZAxVWFlC2DnvTQkGsQ8Dh = new string[9] { "Arm left", "Body", "Forearm right", "Hair", "Hand", "Head", "Scrub", "Shoulder right", "Tail" };

	private static readonly string[] _zUSO7mJ2m3VQVLAdUFTSi7leUMe = new string[1] { "Shorts" };

	public ClubPoolStaticANPC(IAmorous game)
		: base(game, "Assets/NPC/ClubPoolStatic/A club", _faT8q4ZAxVWFlC2DnvTQkGsQ8Dh, null, _zUSO7mJ2m3VQVLAdUFTSi7leUMe)
	{
		_J4giDjnRtYmiHMmzwRZ0ThvfAhH = false;
		_upl1k7yzBzlU7vErvbydGmXROfA = true;
	}
}
