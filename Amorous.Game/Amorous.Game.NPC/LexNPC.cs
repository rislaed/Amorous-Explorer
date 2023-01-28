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
		: base(game, "Assets/NPC/Lex/Lex", 1f, premultipliedAlpha: true)
	{
		base.Spine.StartAnimationWithLooping("animation");
		string[] first = new string[5] { "Fringe", "Hair back", "Pupils", "Eyes back", "Ear" };
		GetEmotion(EHeads.Happy, first.Union(new string[1] { "Head happy" }).ToArray())._qL2MEiFtBpbdxqUUTSqOgOsEK4j("Blink");
		GetEmotion(EHeads.Angry, first.Union(new string[1] { "Head angry" }).ToArray())._qL2MEiFtBpbdxqUUTSqOgOsEK4j("Blink");
		GetEmotion(EHeads.Sad, first.Union(new string[1] { "Head sad" }).ToArray())._qL2MEiFtBpbdxqUUTSqOgOsEK4j("Blink");
		GetEmotion(EHeads.Embarrassed, first.Union(new string[1] { "Head blush" }).ToArray())._qL2MEiFtBpbdxqUUTSqOgOsEK4j("Blink");
		GetPose(EPoses.Neutral, "Body neutral", "Shoulder neutral", "Forearm neutral", "Tail");
		GetPose(EPoses.Gesture, "Body neutral", "Shoulder gesture", "Forearm gesture", "Hand gesture", "Tail");
		GetPose(EPoses.GestureDrink, "Body neutral", "Shoulder gesture", "Forearm gesture", "Hand drink", "Tail");
		GetPose(EPoses.GestureSigaret, "Body neutral", "Shoulder gesture", "Forearm gesture", "Hand cig", "Tail");
		GetClothes(EPoses.Neutral, EClothes.Jacket, "Jacket", "Shoulder neutral jacket", "Forearm neutral jacket")._XJUU6QdUDN3lYoRweLWOMaWqcUE();
		GetClothes(EPoses.Gesture, EClothes.Jacket, "Jacket", "Shoulder gesture jacket", "Forearm gesture jacket")._XJUU6QdUDN3lYoRweLWOMaWqcUE();
		GetClothes(EPoses.GestureDrink, EClothes.Jacket, "Jacket", "Shoulder gesture jacket", "Forearm gesture jacket")._XJUU6QdUDN3lYoRweLWOMaWqcUE();
		GetClothes(EPoses.GestureSigaret, EClothes.Jacket, "Jacket", "Shoulder gesture jacket", "Forearm gesture jacket")._XJUU6QdUDN3lYoRweLWOMaWqcUE();
		GetClothes(EPoses.Neutral, EClothes.Jeans, "Jeans")._dUWotuFGWMaIlD1IFkXcXUhjchR()._B19pyNfKCkJxZB1oCC3WzfkqEQF();
		GetClothes(EPoses.Gesture, EClothes.Jeans, "Jeans")._dUWotuFGWMaIlD1IFkXcXUhjchR()._B19pyNfKCkJxZB1oCC3WzfkqEQF();
		GetClothes(EPoses.GestureDrink, EClothes.Jeans, "Jeans")._dUWotuFGWMaIlD1IFkXcXUhjchR()._B19pyNfKCkJxZB1oCC3WzfkqEQF();
		GetClothes(EPoses.GestureSigaret, EClothes.Jeans, "Jeans")._dUWotuFGWMaIlD1IFkXcXUhjchR()._B19pyNfKCkJxZB1oCC3WzfkqEQF();
		GetClothes(EPoses.Neutral, EClothes.Panties, "Panties")._dUWotuFGWMaIlD1IFkXcXUhjchR();
		GetClothes(EPoses.Gesture, EClothes.Panties, "Panties")._dUWotuFGWMaIlD1IFkXcXUhjchR();
		GetClothes(EPoses.GestureDrink, EClothes.Panties, "Panties")._dUWotuFGWMaIlD1IFkXcXUhjchR();
		GetClothes(EPoses.GestureSigaret, EClothes.Panties, "Panties")._dUWotuFGWMaIlD1IFkXcXUhjchR();
		GetClothes(EPoses.Neutral, EClothes.Boxers, "Boxers")._dUWotuFGWMaIlD1IFkXcXUhjchR();
		GetClothes(EPoses.Gesture, EClothes.Boxers, "Boxers")._dUWotuFGWMaIlD1IFkXcXUhjchR();
		GetClothes(EPoses.GestureDrink, EClothes.Boxers, "Boxers")._dUWotuFGWMaIlD1IFkXcXUhjchR();
		GetClothes(EPoses.GestureSigaret, EClothes.Boxers, "Boxers")._dUWotuFGWMaIlD1IFkXcXUhjchR();
		GetClothes(EPoses.Neutral, EClothes.DickSoft, "Male balls", "Male dick soft");
		GetClothes(EPoses.Gesture, EClothes.DickSoft, "Male balls", "Male dick soft");
		GetClothes(EPoses.GestureDrink, EClothes.DickSoft, "Male balls", "Male dick soft");
		GetClothes(EPoses.GestureSigaret, EClothes.DickSoft, "Male balls", "Male dick soft");
		GetClothes(EPoses.Neutral, EClothes.DickHard, "Male balls", "Male dick hard");
		GetClothes(EPoses.Gesture, EClothes.DickHard, "Male balls", "Male dick hard");
		GetClothes(EPoses.GestureDrink, EClothes.DickHard, "Male balls", "Male dick hard");
		GetClothes(EPoses.GestureSigaret, EClothes.DickHard, "Male balls", "Male dick hard");
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
