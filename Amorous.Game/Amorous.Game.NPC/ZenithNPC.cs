using System;
using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class ZenithNPC : SpineNPC<ZenithNPC.EHeads, ZenithNPC.EPoses, ZenithNPC.EClothes>
{
	public enum EHeads
	{
		None,
		Angry,
		Blush,
		Happy,
		NotAmused
	}

	public enum EPoses
	{
		None,
		ArmsFolded,
		HandsOnHips
	}

	public enum EClothes
	{
		None,
		Security,
		Shirt,
		Pants
	}

	public static string Name = "Zenith";

	public static Color Color = new Color(155, 213, 154);

	public ZenithNPC(IAmorous game)
		: base(Game, "Assets/NPC/Zenith/Zenith", 1f, bool_0: true)
	{
		base.Spine.StartAnimationWithLooping("animation");
		_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Angry, "Head angry", "Eye Back", "Pupils")._qL2MEiFtBpbdxqUUTSqOgOsEK4j("Blink");
		_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Blush, "Head Blush", "Eye Back", "Pupils")._qL2MEiFtBpbdxqUUTSqOgOsEK4j("Blink");
		_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Happy, "Head Happy", "Eye Back", "Pupils")._qL2MEiFtBpbdxqUUTSqOgOsEK4j("Blink");
		_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.NotAmused, "Head Un-amused", "Eye Back", "Pupils")._qL2MEiFtBpbdxqUUTSqOgOsEK4j("Blink");
		_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.ArmsFolded, "Body fold arms", "Wing left", "Wing right");
		_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.HandsOnHips, "Body hips", "Wing left", "Wing right");
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.ArmsFolded, EClothes.Security, "Security fold arms")._XJUU6QdUDN3lYoRweLWOMaWqcUE();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.ArmsFolded, EClothes.Shirt, "Shirt fold arms")._XJUU6QdUDN3lYoRweLWOMaWqcUE();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.ArmsFolded, EClothes.Pants, "Pants fold arms")._dUWotuFGWMaIlD1IFkXcXUhjchR();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.HandsOnHips, EClothes.Security, "Security hips")._XJUU6QdUDN3lYoRweLWOMaWqcUE();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.HandsOnHips, EClothes.Shirt, "Shirt hips")._XJUU6QdUDN3lYoRweLWOMaWqcUE();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.HandsOnHips, EClothes.Pants, "Pants hips")._dUWotuFGWMaIlD1IFkXcXUhjchR();
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
			X = 1000f;
			Y = 1090f;
			break;
		case NPCLocation.Left:
			FlipX = false;
			X = 380f;
			Y = 1090f;
			break;
		case NPCLocation.Right:
			FlipX = false;
			X = 1540f;
			Y = 1090f;
			break;
		}
	}
}
