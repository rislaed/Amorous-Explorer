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
		: base(game, "Assets/NPC/Zenith/Zenith", 1f, premultipliedAlpha: true)
	{
		base.Spine.StartAnimationWithLooping("animation");
		GetEmotion(EHeads.Angry, "Head angry", "Eye Back", "Pupils")._qL2MEiFtBpbdxqUUTSqOgOsEK4j("Blink");
		GetEmotion(EHeads.Blush, "Head Blush", "Eye Back", "Pupils")._qL2MEiFtBpbdxqUUTSqOgOsEK4j("Blink");
		GetEmotion(EHeads.Happy, "Head Happy", "Eye Back", "Pupils")._qL2MEiFtBpbdxqUUTSqOgOsEK4j("Blink");
		GetEmotion(EHeads.NotAmused, "Head Un-amused", "Eye Back", "Pupils")._qL2MEiFtBpbdxqUUTSqOgOsEK4j("Blink");
		GetPose(EPoses.ArmsFolded, "Body fold arms", "Wing left", "Wing right");
		GetPose(EPoses.HandsOnHips, "Body hips", "Wing left", "Wing right");
		GetClothes(EPoses.ArmsFolded, EClothes.Security, "Security fold arms")._XJUU6QdUDN3lYoRweLWOMaWqcUE();
		GetClothes(EPoses.ArmsFolded, EClothes.Shirt, "Shirt fold arms")._XJUU6QdUDN3lYoRweLWOMaWqcUE();
		GetClothes(EPoses.ArmsFolded, EClothes.Pants, "Pants fold arms")._dUWotuFGWMaIlD1IFkXcXUhjchR();
		GetClothes(EPoses.HandsOnHips, EClothes.Security, "Security hips")._XJUU6QdUDN3lYoRweLWOMaWqcUE();
		GetClothes(EPoses.HandsOnHips, EClothes.Shirt, "Shirt hips")._XJUU6QdUDN3lYoRweLWOMaWqcUE();
		GetClothes(EPoses.HandsOnHips, EClothes.Pants, "Pants hips")._dUWotuFGWMaIlD1IFkXcXUhjchR();
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
