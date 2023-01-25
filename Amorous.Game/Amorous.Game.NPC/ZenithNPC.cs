using System;
using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class ZenithNPC : SpineNPC<ZenithNPC.EHeads, ZenithNPC.EPoses, ZenithNPC.EClothes>
{
	public enum EHeads
	{
		None,
		Angry,
		Blush,
		Happy,
		NotAmused
	}

	public enum EPoses
	{
		None,
		ArmsFolded,
		HandsOnHips
	}

	public enum EClothes
	{
		None,
		Security,
		Shirt,
		Pants
	}

	public static string Name = "Zenith";

	public static Color Color = new Color(155, 213, 154);

	public ZenithNPC(IAmorous game)
		: base(Game, "Assets/NPC/Zenith/Zenith", 1f, bool_0: true)
	{
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._C5vPbZ72rpVMDWGuHxZuR5FNpAH("animation");
		_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Angry, "Head angry", "Eye Back", "Pupils")._qL2MEiFtBpbdxqUUTSqOgOsEK4j("Blink");
		_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Blush, "Head Blush", "Eye Back", "Pupils")._qL2MEiFtBpbdxqUUTSqOgOsEK4j("Blink");
		_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Happy, "Head Happy", "Eye Back", "Pupils")._qL2MEiFtBpbdxqUUTSqOgOsEK4j("Blink");
		_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.NotAmused, "Head Un-amused", "Eye Back", "Pupils")._qL2MEiFtBpbdxqUUTSqOgOsEK4j("Blink");
		_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.ArmsFolded, "Body fold arms", "Wing left", "Wing right");
		_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.HandsOnHips, "Body hips", "Wing left", "Wing right");
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.ArmsFolded, EClothes.Security, "Security fold arms")._XJUU6QdUDN3lYoRweLWOMaWqcUE();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.ArmsFolded, EClothes.Shirt, "Shirt fold arms")._XJUU6QdUDN3lYoRweLWOMaWqcUE();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.ArmsFolded, EClothes.Pants, "Pants fold arms")._dUWotuFGWMaIlD1IFkXcXUhjchR();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.HandsOnHips, EClothes.Security, "Security hips")._XJUU6QdUDN3lYoRweLWOMaWqcUE();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.HandsOnHips, EClothes.Shirt, "Shirt hips")._XJUU6QdUDN3lYoRweLWOMaWqcUE();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.HandsOnHips, EClothes.Pants, "Pants hips")._dUWotuFGWMaIlD1IFkXcXUhjchR();
		_J4giDjnRtYmiHMmzwRZ0ThvfAhH = false;
		_upl1k7yzBzlU7vErvbydGmXROfA = true;
	}

	public override void _nGGBtYpZ8pI1BmE2c2ke63UjGDP(NPCLocation npclocation_0)
	{
		base._nGGBtYpZ8pI1BmE2c2ke63UjGDP(npclocation_0);
		switch (npclocation_0)
		{
		case NPCLocation.Middle:
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_Pv8G2bIbjHmJYrVXhNyr64NSPXn = false;
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EX = 1000f;
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EY = 1090f;
			break;
		case NPCLocation.Left:
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_Pv8G2bIbjHmJYrVXhNyr64NSPXn = false;
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EX = 380f;
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EY = 1090f;
			break;
		case NPCLocation.Right:
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_Pv8G2bIbjHmJYrVXhNyr64NSPXn = false;
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EX = 1540f;
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EY = 1090f;
			break;
		}
	}
}
