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
		: base(Game, "Assets/NPC/Remy/Remy", 0.75f, bool_0: true)
	{
		base.Spine.StartAnimationWithLooping("animation");
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
