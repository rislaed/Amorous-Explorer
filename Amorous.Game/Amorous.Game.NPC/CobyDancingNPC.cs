using System;
using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class CobyDancingNPC : SpineNPC<CobyDancingNPC.EHeads, CobyDancingNPC.EPoses, CobyDancingNPC.EClothes>
{
	public enum EHeads
	{
		None,
		Happy
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
		Shorts,
		Sleeves
	}

	public static Color Color = new Color(104, 193, 255);

	public CobyDancingNPC(IAmorous game)
		: base(Game, "Assets/NPC/CobyDancing/Coby", 0.8f, bool_0: true)
	{
		Width = 600;
		Height = 800;
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._C5vPbZ72rpVMDWGuHxZuR5FNpAH("animation");
		_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Happy, "Eyes Back", "Pupil", "Jaw", "Head");
		_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Dancing, "Tail", "Leg right", "Arm right", "Body", "left leg", "Arm left")._6NcgB9eEKq8eKu8SgNWnKbLsDhB("Balls", "Cock");
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Dancing, EClothes.Shirt, "Shirt")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._9mDS3yizOswyCzK6V3LBhafV7Dh();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Dancing, EClothes.Shorts, "Shorts right", "Shorts crotch", "Shorts left")._dUWotuFGWMaIlD1IFkXcXUhjchR()._mgkfAuKt1tsSRmn1YmxkzbHikc();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Dancing, EClothes.Sleeves, "Sleeves right", "Sleeves left")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._9mDS3yizOswyCzK6V3LBhafV7Dh();
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
