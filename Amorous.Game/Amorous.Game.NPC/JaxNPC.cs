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
		: this(Game, "Assets/NPC/Jax/Jax")
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
		_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Grumpy, "Grumpy Head", "Grumpy pupils", "Grumpy eyes back")._qL2MEiFtBpbdxqUUTSqOgOsEK4j("Grumpy Blink");
		_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Smirk, "Smirk head", "Smirk pupils", "Smirk eyes back")._qL2MEiFtBpbdxqUUTSqOgOsEK4j("Smirk Blink");
		_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Sad, "Sad Head", "Sad pupil", "Sad eye back", "Flirty Jaw")._qL2MEiFtBpbdxqUUTSqOgOsEK4j("Sad blink");
		_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Frustrated, "Frustrated Head", "Frustrated pupil", "Frustrated eye back")._qL2MEiFtBpbdxqUUTSqOgOsEK4j("Frustrated blink");
		_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Cheeky, "Cheeky Head", "Cheeky pupils", "Cheeky eye back")._qL2MEiFtBpbdxqUUTSqOgOsEK4j("Cheeky Blink");
		_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Unamused, "Unamused Head", "Unamused Pupils", "Unamused eye back")._qL2MEiFtBpbdxqUUTSqOgOsEK4j("Unamused Blink");
		_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Happy, "Happy head", "Happy pupil", "Happy eye back", "Happy jaw")._qL2MEiFtBpbdxqUUTSqOgOsEK4j("Happy Blink");
		_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Chill, "Body", "Right arm GestureChill", "Left arm chill", "Left thumb Chill")._6NcgB9eEKq8eKu8SgNWnKbLsDhB("Cock");
		_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Gesture, "Body", "Right arm GestureChill", "Left arm Gesture")._6NcgB9eEKq8eKu8SgNWnKbLsDhB("Cock");
		_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Defensive, "Body", "Right arm defensive", "Left Arm defensive")._6NcgB9eEKq8eKu8SgNWnKbLsDhB("Cock");
		_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Shy, "Body", "Right arm shy", "Left arm shy")._6NcgB9eEKq8eKu8SgNWnKbLsDhB("Cock");
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Chill, EClothes.TuxChest, "Tux chest", "Tux Right arm GestureChill", "Tux Left arm chill")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._9mDS3yizOswyCzK6V3LBhafV7Dh();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Chill, EClothes.TuxUnderwear, "Tux underwear")._dUWotuFGWMaIlD1IFkXcXUhjchR()._mgkfAuKt1tsSRmn1YmxkzbHikc();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Chill, EClothes.CasualJacket, "Casual body", "Casual right arm GestureChill", "Casual left arm chill")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._9mDS3yizOswyCzK6V3LBhafV7Dh();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Chill, EClothes.CasualPants, "Casual shorts")._dUWotuFGWMaIlD1IFkXcXUhjchR()._B19pyNfKCkJxZB1oCC3WzfkqEQF()._mgkfAuKt1tsSRmn1YmxkzbHikc();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Gesture, EClothes.TuxChest, "Tux chest", "Tux Right arm GestureChill", "Tux left arm gesture")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._9mDS3yizOswyCzK6V3LBhafV7Dh();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Gesture, EClothes.TuxUnderwear, "Tux underwear")._dUWotuFGWMaIlD1IFkXcXUhjchR()._mgkfAuKt1tsSRmn1YmxkzbHikc();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Gesture, EClothes.CasualJacket, "Casual body", "Casual right arm GestureChill", "Casual left arm Gesture copy 2")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._9mDS3yizOswyCzK6V3LBhafV7Dh();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Gesture, EClothes.CasualPants, "Casual shorts")._dUWotuFGWMaIlD1IFkXcXUhjchR()._B19pyNfKCkJxZB1oCC3WzfkqEQF()._mgkfAuKt1tsSRmn1YmxkzbHikc();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Defensive, EClothes.TuxChest, "Tux chest", "Tux Right arm defensive")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._9mDS3yizOswyCzK6V3LBhafV7Dh();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Defensive, EClothes.TuxUnderwear, "Tux underwear")._dUWotuFGWMaIlD1IFkXcXUhjchR()._mgkfAuKt1tsSRmn1YmxkzbHikc();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Defensive, EClothes.CasualJacket, "Casual body", "Casual right arm defensive", "Casual left arm defensive")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._9mDS3yizOswyCzK6V3LBhafV7Dh();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Defensive, EClothes.CasualPants, "Casual shorts")._dUWotuFGWMaIlD1IFkXcXUhjchR()._B19pyNfKCkJxZB1oCC3WzfkqEQF()._mgkfAuKt1tsSRmn1YmxkzbHikc();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Shy, EClothes.TuxChest, "Tux chest", "Tux right arm shy")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._9mDS3yizOswyCzK6V3LBhafV7Dh();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Shy, EClothes.TuxUnderwear, "Tux underwear")._dUWotuFGWMaIlD1IFkXcXUhjchR()._mgkfAuKt1tsSRmn1YmxkzbHikc();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Shy, EClothes.CasualJacket, "Casual body", "Casual right arm shy", "Casual left arm shy")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._9mDS3yizOswyCzK6V3LBhafV7Dh();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Shy, EClothes.CasualPants, "Casual shorts")._dUWotuFGWMaIlD1IFkXcXUhjchR()._B19pyNfKCkJxZB1oCC3WzfkqEQF()._mgkfAuKt1tsSRmn1YmxkzbHikc();
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
