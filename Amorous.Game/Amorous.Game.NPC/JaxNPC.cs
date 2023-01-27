using System;
using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class JaxNPC : SpineNPC<JaxNPC.EHeads, JaxNPC.EPoses, JaxNPC.EClothes>
{
	public enum EHeads
	{
		None,
		Grumpy,
		Smirk,
		Sad,
		Frustrated,
		Cheeky,
		Unamused,
		Happy
	}

	public enum EPoses
	{
		None,
		Chill,
		Gesture,
		Defensive,
		Shy
	}

	public enum EClothes
	{
		None,
		TuxChest,
		TuxUnderwear,
		CasualJacket,
		CasualPants
	}

	public static string Name = "Jax";
	public static Color Color = new Color(113, 227, 255);

	public JaxNPC(IAmorous game)
		: this(game, "Assets/NPC/Jax/Jax")
	{
	}

	public JaxNPC(IAmorous game, string string_0)
		: base(game, string_0, 1f, bool_0: true)
	{
		Width = 904;
		Height = 1008;
		base._rAt6TRbgK04lvrs5QPjcd0n26pk = new Type[2]
		{
			typeof(JaxPurpleNPC),
			typeof(JaxRedNPC)
		};
		base.Spine.StartAnimationWithLooping("animation");
		GetEmotion(EHeads.Grumpy, "Grumpy Head", "Grumpy pupils", "Grumpy eyes back")._qL2MEiFtBpbdxqUUTSqOgOsEK4j("Grumpy Blink");
		GetEmotion(EHeads.Smirk, "Smirk head", "Smirk pupils", "Smirk eyes back")._qL2MEiFtBpbdxqUUTSqOgOsEK4j("Smirk Blink");
		GetEmotion(EHeads.Sad, "Sad Head", "Sad pupil", "Sad eye back", "Flirty Jaw")._qL2MEiFtBpbdxqUUTSqOgOsEK4j("Sad blink");
		GetEmotion(EHeads.Frustrated, "Frustrated Head", "Frustrated pupil", "Frustrated eye back")._qL2MEiFtBpbdxqUUTSqOgOsEK4j("Frustrated blink");
		GetEmotion(EHeads.Cheeky, "Cheeky Head", "Cheeky pupils", "Cheeky eye back")._qL2MEiFtBpbdxqUUTSqOgOsEK4j("Cheeky Blink");
		GetEmotion(EHeads.Unamused, "Unamused Head", "Unamused Pupils", "Unamused eye back")._qL2MEiFtBpbdxqUUTSqOgOsEK4j("Unamused Blink");
		GetEmotion(EHeads.Happy, "Happy head", "Happy pupil", "Happy eye back", "Happy jaw")._qL2MEiFtBpbdxqUUTSqOgOsEK4j("Happy Blink");
		GetPose(EPoses.Chill, "Body", "Right arm GestureChill", "Left arm chill", "Left thumb Chill")._6NcgB9eEKq8eKu8SgNWnKbLsDhB("Cock");
		GetPose(EPoses.Gesture, "Body", "Right arm GestureChill", "Left arm Gesture")._6NcgB9eEKq8eKu8SgNWnKbLsDhB("Cock");
		GetPose(EPoses.Defensive, "Body", "Right arm defensive", "Left Arm defensive")._6NcgB9eEKq8eKu8SgNWnKbLsDhB("Cock");
		GetPose(EPoses.Shy, "Body", "Right arm shy", "Left arm shy")._6NcgB9eEKq8eKu8SgNWnKbLsDhB("Cock");
		GetClothes(EPoses.Chill, EClothes.TuxChest, "Tux chest", "Tux Right arm GestureChill", "Tux Left arm chill")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._9mDS3yizOswyCzK6V3LBhafV7Dh();
		GetClothes(EPoses.Chill, EClothes.TuxUnderwear, "Tux underwear")._dUWotuFGWMaIlD1IFkXcXUhjchR()._mgkfAuKt1tsSRmn1YmxkzbHikc();
		GetClothes(EPoses.Chill, EClothes.CasualJacket, "Casual body", "Casual right arm GestureChill", "Casual left arm chill")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._9mDS3yizOswyCzK6V3LBhafV7Dh();
		GetClothes(EPoses.Chill, EClothes.CasualPants, "Casual shorts")._dUWotuFGWMaIlD1IFkXcXUhjchR()._B19pyNfKCkJxZB1oCC3WzfkqEQF()._mgkfAuKt1tsSRmn1YmxkzbHikc();
		GetClothes(EPoses.Gesture, EClothes.TuxChest, "Tux chest", "Tux Right arm GestureChill", "Tux left arm gesture")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._9mDS3yizOswyCzK6V3LBhafV7Dh();
		GetClothes(EPoses.Gesture, EClothes.TuxUnderwear, "Tux underwear")._dUWotuFGWMaIlD1IFkXcXUhjchR()._mgkfAuKt1tsSRmn1YmxkzbHikc();
		GetClothes(EPoses.Gesture, EClothes.CasualJacket, "Casual body", "Casual right arm GestureChill", "Casual left arm Gesture copy 2")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._9mDS3yizOswyCzK6V3LBhafV7Dh();
		GetClothes(EPoses.Gesture, EClothes.CasualPants, "Casual shorts")._dUWotuFGWMaIlD1IFkXcXUhjchR()._B19pyNfKCkJxZB1oCC3WzfkqEQF()._mgkfAuKt1tsSRmn1YmxkzbHikc();
		GetClothes(EPoses.Defensive, EClothes.TuxChest, "Tux chest", "Tux Right arm defensive")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._9mDS3yizOswyCzK6V3LBhafV7Dh();
		GetClothes(EPoses.Defensive, EClothes.TuxUnderwear, "Tux underwear")._dUWotuFGWMaIlD1IFkXcXUhjchR()._mgkfAuKt1tsSRmn1YmxkzbHikc();
		GetClothes(EPoses.Defensive, EClothes.CasualJacket, "Casual body", "Casual right arm defensive", "Casual left arm defensive")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._9mDS3yizOswyCzK6V3LBhafV7Dh();
		GetClothes(EPoses.Defensive, EClothes.CasualPants, "Casual shorts")._dUWotuFGWMaIlD1IFkXcXUhjchR()._B19pyNfKCkJxZB1oCC3WzfkqEQF()._mgkfAuKt1tsSRmn1YmxkzbHikc();
		GetClothes(EPoses.Shy, EClothes.TuxChest, "Tux chest", "Tux right arm shy")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._9mDS3yizOswyCzK6V3LBhafV7Dh();
		GetClothes(EPoses.Shy, EClothes.TuxUnderwear, "Tux underwear")._dUWotuFGWMaIlD1IFkXcXUhjchR()._mgkfAuKt1tsSRmn1YmxkzbHikc();
		GetClothes(EPoses.Shy, EClothes.CasualJacket, "Casual body", "Casual right arm shy", "Casual left arm shy")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._9mDS3yizOswyCzK6V3LBhafV7Dh();
		GetClothes(EPoses.Shy, EClothes.CasualPants, "Casual shorts")._dUWotuFGWMaIlD1IFkXcXUhjchR()._B19pyNfKCkJxZB1oCC3WzfkqEQF()._mgkfAuKt1tsSRmn1YmxkzbHikc();
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
			Y = 1100f;
			break;
		case NPCLocation.Left:
			FlipX = true;
			X = 400f;
			Y = 1100f;
			break;
		case NPCLocation.Right:
			FlipX = false;
			X = 1520f;
			Y = 1100f;
			break;
		}
	}
}
