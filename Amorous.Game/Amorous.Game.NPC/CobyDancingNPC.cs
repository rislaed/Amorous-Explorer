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
		base.Spine.StartAnimationWithLooping("animation");
		_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Happy, "Eyes Back", "Pupil", "Jaw", "Head");
		_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Dancing, "Tail", "Leg right", "Arm right", "Body", "left leg", "Arm left")._6NcgB9eEKq8eKu8SgNWnKbLsDhB("Balls", "Cock");
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Dancing, EClothes.Shirt, "Shirt")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._9mDS3yizOswyCzK6V3LBhafV7Dh();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Dancing, EClothes.Shorts, "Shorts right", "Shorts crotch", "Shorts left")._dUWotuFGWMaIlD1IFkXcXUhjchR()._mgkfAuKt1tsSRmn1YmxkzbHikc();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Dancing, EClothes.Sleeves, "Sleeves right", "Sleeves left")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._9mDS3yizOswyCzK6V3LBhafV7Dh();
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
