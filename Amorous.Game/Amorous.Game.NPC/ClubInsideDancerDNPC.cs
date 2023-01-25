using System;
using Amorous.Engine.NPC;

namespace Amorous.Game.NPC;

public class ClubInsideDancerDNPC : SpineNPC<ClubInsideDancerDNPC.EHeads, ClubInsideDancerDNPC.EPoses, ClubInsideDancerDNPC.EClothes>
{
	public enum EHeads
	{
		None,
		Smirk
	}

	public enum EPoses
	{
		None,
		Dancing
	}

	public enum EClothes
	{
		None,
		Shirt,
		Pants
	}

	public ClubInsideDancerDNPC(IAmorous game)
		: base(Game, "Assets/NPC/ClubInsideStatic/Dancer D", 0.8f, bool_0: true)
	{
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._C5vPbZ72rpVMDWGuHxZuR5FNpAH("Dancing");
		_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Smirk, "Head");
		_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Dancing, "Arm right", "Body", "Left forearm", "Tail")._6NcgB9eEKq8eKu8SgNWnKbLsDhB("Cock");
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Dancing, EClothes.Shirt, "Shirt", "Shirt arm right", "Shirt left forearm")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._9mDS3yizOswyCzK6V3LBhafV7Dh();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Dancing, EClothes.Pants, "Pants")._dUWotuFGWMaIlD1IFkXcXUhjchR()._mgkfAuKt1tsSRmn1YmxkzbHikc();
		_J4giDjnRtYmiHMmzwRZ0ThvfAhH = false;
		_upl1k7yzBzlU7vErvbydGmXROfA = true;
	}
}
