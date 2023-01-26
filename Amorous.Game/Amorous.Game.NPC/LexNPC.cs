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
		: base(game, "Assets/NPC/Lex/Lex", 1f, bool_0: true)
	{
		base.Spine.StartAnimationWithLooping("animation");
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
		base.Spine.OverlayWith("Male dick soft", "Jacket");
		base.Spine.OverlayWith("Male dick hard", "Male dick soft");
		_J4giDjnRtYmiHMmzwRZ0ThvfAhH = false;
		_upl1k7yzBzlU7vErvbydGmXROfA = true;
	}

	public override void SetLocation(NPCLocation npclocation_0)
	{
		base.SetLocation(npclocation_0);
		switch (npclocation_0)
		{
			case NPCLocation.Middle:
				FlipX = false;
				X = 960f;
				Y = 1090f;
				break;
			case NPCLocation.Left:
				FlipX = false;
				X = 400f;
				Y = 1090f;
				break;
			case NPCLocation.Right:
				FlipX = false;
				X = 1520f;
				Y = 1090f;
				break;
		}
	}
}
