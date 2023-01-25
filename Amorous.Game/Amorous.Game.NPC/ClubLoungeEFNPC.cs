using Amorous.Engine.NPC;

namespace Amorous.Game.NPC;

public class ClubLoungeEFNPC : LayerNPC<ClubLoungeEFNPC.EHeads, ClubLoungeEFNPC.EPoses, ClubLoungeEFNPC.EClothes>
{
	public enum EHeads
	{
		None
	}

	public enum EPoses
	{
		None,
		Sitting
	}

	public enum EClothes
	{
		None,
		Shirt,
		Pants
	}

	public ClubLoungeEFNPC(IAmorous game)
		: base(Game, "Assets/NPC/ClubLoungeStatic", 1f)
	{
		_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Sitting, "E F club nude")._6NcgB9eEKq8eKu8SgNWnKbLsDhB("E F club nude cock");
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Sitting, EClothes.Shirt, "E F club shirt")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._9mDS3yizOswyCzK6V3LBhafV7Dh();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Sitting, EClothes.Pants, "E F club pants")._dUWotuFGWMaIlD1IFkXcXUhjchR()._mgkfAuKt1tsSRmn1YmxkzbHikc();
		_J4giDjnRtYmiHMmzwRZ0ThvfAhH = false;
		_upl1k7yzBzlU7vErvbydGmXROfA = true;
	}
}
