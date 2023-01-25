using System;
using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class SethNPC : SpineNPC<SethNPC.EHeads, SethNPC.EPoses, SethNPC.EClothes>
{
	public enum EHeads
	{
		None,
		Blush,
		Happy,
		Sad,
		Smirk
	}

	public enum EPoses
	{
		None,
		Shy,
		Gesture
	}

	public enum EClothes
	{
		None,
		Top,
		Pants
	}

	public static string Name = "Seth";

	public static Color Color = new Color(176, 255, 83);

	public SethNPC(IAmorous game)
		: base(Game, "Assets/NPC/Seth/Seth", 1f, bool_0: true)
	{
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._C5vPbZ72rpVMDWGuHxZuR5FNpAH("Idle");
		_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Blush, "Blush head", "Blush pupils", "Blush eyeback");
		_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Happy, "Happy head", "Happy Pupils", "Happy eyeback", "Happy jaw")._qL2MEiFtBpbdxqUUTSqOgOsEK4j("Happy blink");
		_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Sad, "Sad head", "Sad pupils", "Sad eye back")._qL2MEiFtBpbdxqUUTSqOgOsEK4j("Sad blink");
		_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Smirk, "Smirk Head", "Smirk Pupil", "Smirk eye back")._qL2MEiFtBpbdxqUUTSqOgOsEK4j("Smirk Blink");
		_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Shy, "Shy body")._6NcgB9eEKq8eKu8SgNWnKbLsDhB("Seth cock");
		_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Gesture, "Gesture Body")._6NcgB9eEKq8eKu8SgNWnKbLsDhB("Seth cock");
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Shy, EClothes.Top, "Shy top")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._9mDS3yizOswyCzK6V3LBhafV7Dh();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Shy, EClothes.Pants, "Pants")._dUWotuFGWMaIlD1IFkXcXUhjchR()._mgkfAuKt1tsSRmn1YmxkzbHikc();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Gesture, EClothes.Top, "Gesture top")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._9mDS3yizOswyCzK6V3LBhafV7Dh();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Gesture, EClothes.Pants, "Pants")._dUWotuFGWMaIlD1IFkXcXUhjchR()._mgkfAuKt1tsSRmn1YmxkzbHikc();
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
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EX = 960f;
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EY = 1120f;
			break;
		case NPCLocation.Left:
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_Pv8G2bIbjHmJYrVXhNyr64NSPXn = false;
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EX = 400f;
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EY = 1120f;
			break;
		case NPCLocation.Right:
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_Pv8G2bIbjHmJYrVXhNyr64NSPXn = true;
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EX = 1520f;
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EY = 1120f;
			break;
		}
	}
}
