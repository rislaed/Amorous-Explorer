using System;
using System.Linq;
using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class LexNPC : SpineNPC<LexNPC.EHeads, LexNPC.EPoses, LexNPC.EClothes>
{
	public enum EHeads
	{
		None,
		Happy,
		Angry,
		Sad,
		Embarrassed
	}

	public enum EPoses
	{
		None,
		Neutral,
		Gesture,
		GestureDrink,
		GestureSigaret
	}

	public enum EClothes
	{
		None,
		Jacket,
		Jeans,
		Panties,
		Boxers,
		DickSoft,
		DickHard
	}

	public static string Name = "Lex";

	public static Color Color = new Color(255, 128, 0);

	public LexNPC(IAmorous game)
		: base(Game, "Assets/NPC/Lex/Lex", 1f, bool_0: true)
	{
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._C5vPbZ72rpVMDWGuHxZuR5FNpAH("animation");
		string[] first = new string[5] { "Fringe", "Hair back", "Pupils", "Eyes back", "Ear" };
		_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Happy, first.Union(new string[1] { "Head happy" }).ToArray())._qL2MEiFtBpbdxqUUTSqOgOsEK4j("Blink");
		_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Angry, first.Union(new string[1] { "Head angry" }).ToArray())._qL2MEiFtBpbdxqUUTSqOgOsEK4j("Blink");
		_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Sad, first.Union(new string[1] { "Head sad" }).ToArray())._qL2MEiFtBpbdxqUUTSqOgOsEK4j("Blink");
		_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Embarrassed, first.Union(new string[1] { "Head blush" }).ToArray())._qL2MEiFtBpbdxqUUTSqOgOsEK4j("Blink");
		_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Neutral, "Body neutral", "Shoulder neutral", "Forearm neutral", "Tail");
		_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Gesture, "Body neutral", "Shoulder gesture", "Forearm gesture", "Hand gesture", "Tail");
		_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.GestureDrink, "Body neutral", "Shoulder gesture", "Forearm gesture", "Hand drink", "Tail");
		_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.GestureSigaret, "Body neutral", "Shoulder gesture", "Forearm gesture", "Hand cig", "Tail");
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Neutral, EClothes.Jacket, "Jacket", "Shoulder neutral jacket", "Forearm neutral jacket")._XJUU6QdUDN3lYoRweLWOMaWqcUE();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Gesture, EClothes.Jacket, "Jacket", "Shoulder gesture jacket", "Forearm gesture jacket")._XJUU6QdUDN3lYoRweLWOMaWqcUE();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.GestureDrink, EClothes.Jacket, "Jacket", "Shoulder gesture jacket", "Forearm gesture jacket")._XJUU6QdUDN3lYoRweLWOMaWqcUE();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.GestureSigaret, EClothes.Jacket, "Jacket", "Shoulder gesture jacket", "Forearm gesture jacket")._XJUU6QdUDN3lYoRweLWOMaWqcUE();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Neutral, EClothes.Jeans, "Jeans")._dUWotuFGWMaIlD1IFkXcXUhjchR()._B19pyNfKCkJxZB1oCC3WzfkqEQF();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Gesture, EClothes.Jeans, "Jeans")._dUWotuFGWMaIlD1IFkXcXUhjchR()._B19pyNfKCkJxZB1oCC3WzfkqEQF();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.GestureDrink, EClothes.Jeans, "Jeans")._dUWotuFGWMaIlD1IFkXcXUhjchR()._B19pyNfKCkJxZB1oCC3WzfkqEQF();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.GestureSigaret, EClothes.Jeans, "Jeans")._dUWotuFGWMaIlD1IFkXcXUhjchR()._B19pyNfKCkJxZB1oCC3WzfkqEQF();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Neutral, EClothes.Panties, "Panties")._dUWotuFGWMaIlD1IFkXcXUhjchR();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Gesture, EClothes.Panties, "Panties")._dUWotuFGWMaIlD1IFkXcXUhjchR();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.GestureDrink, EClothes.Panties, "Panties")._dUWotuFGWMaIlD1IFkXcXUhjchR();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.GestureSigaret, EClothes.Panties, "Panties")._dUWotuFGWMaIlD1IFkXcXUhjchR();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Neutral, EClothes.Boxers, "Boxers")._dUWotuFGWMaIlD1IFkXcXUhjchR();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Gesture, EClothes.Boxers, "Boxers")._dUWotuFGWMaIlD1IFkXcXUhjchR();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.GestureDrink, EClothes.Boxers, "Boxers")._dUWotuFGWMaIlD1IFkXcXUhjchR();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.GestureSigaret, EClothes.Boxers, "Boxers")._dUWotuFGWMaIlD1IFkXcXUhjchR();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Neutral, EClothes.DickSoft, "Male balls", "Male dick soft");
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Gesture, EClothes.DickSoft, "Male balls", "Male dick soft");
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.GestureDrink, EClothes.DickSoft, "Male balls", "Male dick soft");
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.GestureSigaret, EClothes.DickSoft, "Male balls", "Male dick soft");
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Neutral, EClothes.DickHard, "Male balls", "Male dick hard");
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Gesture, EClothes.DickHard, "Male balls", "Male dick hard");
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.GestureDrink, EClothes.DickHard, "Male balls", "Male dick hard");
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.GestureSigaret, EClothes.DickHard, "Male balls", "Male dick hard");
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._eCEWplYE5FdfYPYTrwfyRlIfd6i("Male dick soft", "Jacket");
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._eCEWplYE5FdfYPYTrwfyRlIfd6i("Male dick hard", "Male dick soft");
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
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EY = 1090f;
			break;
		case NPCLocation.Left:
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_Pv8G2bIbjHmJYrVXhNyr64NSPXn = false;
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EX = 400f;
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EY = 1090f;
			break;
		case NPCLocation.Right:
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_Pv8G2bIbjHmJYrVXhNyr64NSPXn = false;
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EX = 1520f;
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EY = 1090f;
			break;
		}
	}
}
