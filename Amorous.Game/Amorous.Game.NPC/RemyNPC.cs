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

	public static string Name = "Remy";
	public static Color Color = new Color(255, 102, 51);

	public RemyNPC(IAmorous game)
		: base(game, "Assets/NPC/Remy/Remy", 0.75f, premultipliedAlpha: true)
	{
		base.Spine.StartAnimationWithLooping("animation");
		string[] first = new string[5] { "Fringe", "Ponytail", "Ear left", "Ear right", "Eyes back" };
		GetEmotion(EHeads.Blushing, first.Union(new string[2] { "Head Blush", "Default pupils" }).ToArray())._qL2MEiFtBpbdxqUUTSqOgOsEK4j("Head blush blink");
		GetEmotion(EHeads.Happy, first.Union(new string[2] { "Head Happy", "Default pupils" }).ToArray())._qL2MEiFtBpbdxqUUTSqOgOsEK4j("Head happy blink");
		GetEmotion(EHeads.Sad, first.Union(new string[2] { "Head Sad", "Sad pupils" }).ToArray());
		GetEmotion(EHeads.Shocked, first.Union(new string[2] { "Head Shock", "Default pupils" }).ToArray());
		string[] first2 = new string[5] { "Body", "Breasts", "Torso", "Hair", "Tail" };
		GetPose(EPoses.LeftArm, first2.Union(new string[3] { "Gesture forearm left", "Gesture hand left", "Gesture shoulder left" }).ToArray());
		GetPose(EPoses.RightArm, first2.Union(new string[3] { "Shy arms back", "Gesture forearm right", "Gesture hand right" }).ToArray());
		GetPose(EPoses.BothArms, first2.Union(new string[5] { "Gesture forearm left", "Gesture hand left", "Gesture shoulder left", "Gesture forearm right", "Gesture hand right" }).ToArray());
		GetPose(EPoses.Shy, first2.Union(new string[1] { "Shy arms back" }).ToArray());
		GetClothes(EPoses.LeftArm, EClothes.Apron, "Apron")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._dUWotuFGWMaIlD1IFkXcXUhjchR();
		GetClothes(EPoses.LeftArm, EClothes.Pants, "Pants")._dUWotuFGWMaIlD1IFkXcXUhjchR()._B19pyNfKCkJxZB1oCC3WzfkqEQF();
		GetClothes(EPoses.LeftArm, EClothes.Sweater, "Sweater body", "Sweater breasts", "Sweater torso", "Sweater Gesture shoulder left")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._KCZzL8xtjbw97bTOV0k8JDz3olE();
		GetClothes(EPoses.LeftArm, EClothes.Swimsuit, "Swimsuit")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._dUWotuFGWMaIlD1IFkXcXUhjchR();
		GetClothes(EPoses.RightArm, EClothes.Apron, "Apron")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._dUWotuFGWMaIlD1IFkXcXUhjchR();
		GetClothes(EPoses.RightArm, EClothes.Pants, "Pants")._dUWotuFGWMaIlD1IFkXcXUhjchR()._B19pyNfKCkJxZB1oCC3WzfkqEQF();
		GetClothes(EPoses.RightArm, EClothes.Sweater, "Sweater body", "Sweater breasts", "Sweater torso", "Sweater shy arms back", "Sweater Gesture forearm right")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._KCZzL8xtjbw97bTOV0k8JDz3olE();
		GetClothes(EPoses.RightArm, EClothes.Swimsuit, "Swimsuit")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._dUWotuFGWMaIlD1IFkXcXUhjchR();
		GetClothes(EPoses.BothArms, EClothes.Apron, "Apron")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._dUWotuFGWMaIlD1IFkXcXUhjchR();
		GetClothes(EPoses.BothArms, EClothes.Pants, "Pants")._dUWotuFGWMaIlD1IFkXcXUhjchR()._B19pyNfKCkJxZB1oCC3WzfkqEQF();
		GetClothes(EPoses.BothArms, EClothes.Sweater, "Sweater body", "Sweater breasts", "Sweater torso", "Sweater Gesture shoulder left", "Sweater Gesture forearm right")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._KCZzL8xtjbw97bTOV0k8JDz3olE();
		GetClothes(EPoses.BothArms, EClothes.Swimsuit, "Swimsuit")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._dUWotuFGWMaIlD1IFkXcXUhjchR();
		GetClothes(EPoses.Shy, EClothes.Apron, "Apron")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._dUWotuFGWMaIlD1IFkXcXUhjchR();
		GetClothes(EPoses.Shy, EClothes.Pants, "Pants")._dUWotuFGWMaIlD1IFkXcXUhjchR()._B19pyNfKCkJxZB1oCC3WzfkqEQF();
		GetClothes(EPoses.Shy, EClothes.Sweater, "Sweater body", "Sweater breasts", "Sweater torso", "Sweater shy arms back")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._KCZzL8xtjbw97bTOV0k8JDz3olE();
		GetClothes(EPoses.Shy, EClothes.Swimsuit, "Swimsuit")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._dUWotuFGWMaIlD1IFkXcXUhjchR();
		_J4giDjnRtYmiHMmzwRZ0ThvfAhH = true;
		_upl1k7yzBzlU7vErvbydGmXROfA = true;
	}

	public override void SetLocation(NPCLocation npclocation_0)
	{
		base.SetLocation(npclocation_0);
		switch (npclocation_0)
		{
		case NPCLocation.Middle:
			FlipX = false;
			X = 1000f;
			Y = 1200f;
			break;
		case NPCLocation.Left:
			FlipX = false;
			X = 380f;
			Y = 1200f;
			break;
		case NPCLocation.Right:
			FlipX = true;
			X = 1540f;
			Y = 1200f;
			break;
		}
	}
}
