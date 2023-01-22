using System;
using System.Linq;
using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class RemyNPC : SpineNPC<RemyNPC.EHeads, RemyNPC.EPoses, RemyNPC.EClothes>
{
	public enum EHeads
	{
		None,
		Blushing,
		Happy,
		Sad,
		Shocked
	}

	public enum EPoses
	{
		None,
		LeftArm,
		RightArm,
		BothArms,
		Shy
	}

	public enum EClothes
	{
		None,
		Apron,
		Pants,
		Sweater,
		Swimsuit
	}

	public static string _RB8fRXeQvK5vs7JEA0XfVCEpg1i = "Remy";

	public static Color _9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA = new Color(255, 102, 51);

	public RemyNPC(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0, "Assets/NPC/Remy/Remy", 0.75f, bool_0: true)
	{
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._C5vPbZ72rpVMDWGuHxZuR5FNpAH("animation");
		string[] first = new string[5] { "Fringe", "Ponytail", "Ear left", "Ear right", "Eyes back" };
		_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Blushing, first.Union(new string[2] { "Head Blush", "Default pupils" }).ToArray())._qL2MEiFtBpbdxqUUTSqOgOsEK4j("Head blush blink");
		_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Happy, first.Union(new string[2] { "Head Happy", "Default pupils" }).ToArray())._qL2MEiFtBpbdxqUUTSqOgOsEK4j("Head happy blink");
		_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Sad, first.Union(new string[2] { "Head Sad", "Sad pupils" }).ToArray());
		_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Shocked, first.Union(new string[2] { "Head Shock", "Default pupils" }).ToArray());
		string[] first2 = new string[5] { "Body", "Breasts", "Torso", "Hair", "Tail" };
		_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.LeftArm, first2.Union(new string[3] { "Gesture forearm left", "Gesture hand left", "Gesture shoulder left" }).ToArray());
		_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.RightArm, first2.Union(new string[3] { "Shy arms back", "Gesture forearm right", "Gesture hand right" }).ToArray());
		_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.BothArms, first2.Union(new string[5] { "Gesture forearm left", "Gesture hand left", "Gesture shoulder left", "Gesture forearm right", "Gesture hand right" }).ToArray());
		_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Shy, first2.Union(new string[1] { "Shy arms back" }).ToArray());
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.LeftArm, EClothes.Apron, "Apron")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._dUWotuFGWMaIlD1IFkXcXUhjchR();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.LeftArm, EClothes.Pants, "Pants")._dUWotuFGWMaIlD1IFkXcXUhjchR()._B19pyNfKCkJxZB1oCC3WzfkqEQF();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.LeftArm, EClothes.Sweater, "Sweater body", "Sweater breasts", "Sweater torso", "Sweater Gesture shoulder left")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._KCZzL8xtjbw97bTOV0k8JDz3olE();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.LeftArm, EClothes.Swimsuit, "Swimsuit")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._dUWotuFGWMaIlD1IFkXcXUhjchR();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.RightArm, EClothes.Apron, "Apron")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._dUWotuFGWMaIlD1IFkXcXUhjchR();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.RightArm, EClothes.Pants, "Pants")._dUWotuFGWMaIlD1IFkXcXUhjchR()._B19pyNfKCkJxZB1oCC3WzfkqEQF();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.RightArm, EClothes.Sweater, "Sweater body", "Sweater breasts", "Sweater torso", "Sweater shy arms back", "Sweater Gesture forearm right")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._KCZzL8xtjbw97bTOV0k8JDz3olE();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.RightArm, EClothes.Swimsuit, "Swimsuit")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._dUWotuFGWMaIlD1IFkXcXUhjchR();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.BothArms, EClothes.Apron, "Apron")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._dUWotuFGWMaIlD1IFkXcXUhjchR();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.BothArms, EClothes.Pants, "Pants")._dUWotuFGWMaIlD1IFkXcXUhjchR()._B19pyNfKCkJxZB1oCC3WzfkqEQF();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.BothArms, EClothes.Sweater, "Sweater body", "Sweater breasts", "Sweater torso", "Sweater Gesture shoulder left", "Sweater Gesture forearm right")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._KCZzL8xtjbw97bTOV0k8JDz3olE();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.BothArms, EClothes.Swimsuit, "Swimsuit")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._dUWotuFGWMaIlD1IFkXcXUhjchR();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Shy, EClothes.Apron, "Apron")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._dUWotuFGWMaIlD1IFkXcXUhjchR();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Shy, EClothes.Pants, "Pants")._dUWotuFGWMaIlD1IFkXcXUhjchR()._B19pyNfKCkJxZB1oCC3WzfkqEQF();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Shy, EClothes.Sweater, "Sweater body", "Sweater breasts", "Sweater torso", "Sweater shy arms back")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._KCZzL8xtjbw97bTOV0k8JDz3olE();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Shy, EClothes.Swimsuit, "Swimsuit")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._dUWotuFGWMaIlD1IFkXcXUhjchR();
		_J4giDjnRtYmiHMmzwRZ0ThvfAhH = true;
		_upl1k7yzBzlU7vErvbydGmXROfA = true;
	}

	public override void _nGGBtYpZ8pI1BmE2c2ke63UjGDP(NPCLocation npclocation_0)
	{
		base._nGGBtYpZ8pI1BmE2c2ke63UjGDP(npclocation_0);
		switch (npclocation_0)
		{
		case NPCLocation.Middle:
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_Pv8G2bIbjHmJYrVXhNyr64NSPXn = false;
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_7Xn1C5tjYnmIif1iZKV8AWsEEbL = 1000f;
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_bCjZ3VSXGKyhmykd2zCnQBiSpDf = 1200f;
			break;
		case NPCLocation.Left:
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_Pv8G2bIbjHmJYrVXhNyr64NSPXn = false;
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_7Xn1C5tjYnmIif1iZKV8AWsEEbL = 380f;
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_bCjZ3VSXGKyhmykd2zCnQBiSpDf = 1200f;
			break;
		case NPCLocation.Right:
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_Pv8G2bIbjHmJYrVXhNyr64NSPXn = true;
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_7Xn1C5tjYnmIif1iZKV8AWsEEbL = 1540f;
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_bCjZ3VSXGKyhmykd2zCnQBiSpDf = 1200f;
			break;
		}
	}
}
