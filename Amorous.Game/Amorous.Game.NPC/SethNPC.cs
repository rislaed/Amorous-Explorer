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
		: base(game, "Assets/NPC/Seth/Seth", 1f, bool_0: true)
	{
		base.Spine.StartAnimationWithLooping("Idle");
		GetEmotion(EHeads.Blush, "Blush head", "Blush pupils", "Blush eyeback");
		GetEmotion(EHeads.Happy, "Happy head", "Happy Pupils", "Happy eyeback", "Happy jaw")._qL2MEiFtBpbdxqUUTSqOgOsEK4j("Happy blink");
		GetEmotion(EHeads.Sad, "Sad head", "Sad pupils", "Sad eye back")._qL2MEiFtBpbdxqUUTSqOgOsEK4j("Sad blink");
		GetEmotion(EHeads.Smirk, "Smirk Head", "Smirk Pupil", "Smirk eye back")._qL2MEiFtBpbdxqUUTSqOgOsEK4j("Smirk Blink");
		GetPose(EPoses.Shy, "Shy body")._6NcgB9eEKq8eKu8SgNWnKbLsDhB("Seth cock");
		GetPose(EPoses.Gesture, "Gesture Body")._6NcgB9eEKq8eKu8SgNWnKbLsDhB("Seth cock");
		GetClothes(EPoses.Shy, EClothes.Top, "Shy top")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._9mDS3yizOswyCzK6V3LBhafV7Dh();
		GetClothes(EPoses.Shy, EClothes.Pants, "Pants")._dUWotuFGWMaIlD1IFkXcXUhjchR()._mgkfAuKt1tsSRmn1YmxkzbHikc();
		GetClothes(EPoses.Gesture, EClothes.Top, "Gesture top")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._9mDS3yizOswyCzK6V3LBhafV7Dh();
		GetClothes(EPoses.Gesture, EClothes.Pants, "Pants")._dUWotuFGWMaIlD1IFkXcXUhjchR()._mgkfAuKt1tsSRmn1YmxkzbHikc();
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
			Y = 1120f;
			break;
		case NPCLocation.Left:
			FlipX = false;
			X = 400f;
			Y = 1120f;
			break;
		case NPCLocation.Right:
			FlipX = true;
			X = 1520f;
			Y = 1120f;
			break;
		}
	}
}
