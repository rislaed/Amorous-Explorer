using System;
using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class CobyNPC : SpineNPC<CobyNPC.EHeads, CobyNPC.EPoses, CobyNPC.EClothes>
{
	public enum EHeads
	{
		None,
		Sad,
		Cocky,
		Flirty,
		Happy
	}

	public enum EPoses
	{
		None,
		Flirty,
		Shy,
		Chill
	}

	public enum EClothes
	{
		None,
		Shirt,
		Shorts,
		Sleeves,
		Underwear
	}

	public static string Name = "Coby";

	public static Color Color = new Color(104, 193, 255);

	public CobyNPC(IAmorous game)
		: base(Game, "Assets/NPC/Coby/Coby", 1f, bool_0: true)
	{
		base.Spine.StartAnimationWithLooping("Breathing");
		_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Sad, "Sad Head", "Sad Pupils", "Sad Eye back")._qL2MEiFtBpbdxqUUTSqOgOsEK4j("Sad Blink");
		_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Cocky, "Cocky Head", "Cocky Pupils", "Cocky Black eye back", "Cocky Jaw")._qL2MEiFtBpbdxqUUTSqOgOsEK4j("Cocky Blink");
		_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Flirty, "Flirty Head", "Flirty Pupils", "Flirty Black eye back", "Flirty Jaw")._qL2MEiFtBpbdxqUUTSqOgOsEK4j("Flirty Blink");
		_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Happy, "Happy Head", "Happy Pupil", "Happy Black eye back", "Happy Jaw")._qL2MEiFtBpbdxqUUTSqOgOsEK4j("Happy Blink");
		_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Flirty, "Neck puff", "Flirty Bod", "Leg extension")._6NcgB9eEKq8eKu8SgNWnKbLsDhB("Flirty cock");
		_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Shy, "Neck puff", "Shy Bod")._6NcgB9eEKq8eKu8SgNWnKbLsDhB("Chill/Shy Cock");
		_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Chill, "Neck puff", "Chill Bod")._6NcgB9eEKq8eKu8SgNWnKbLsDhB("Chill cock");
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Flirty, EClothes.Shirt, "Flirty shirt only")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._9mDS3yizOswyCzK6V3LBhafV7Dh();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Flirty, EClothes.Shorts, "Flirty outfit")._dUWotuFGWMaIlD1IFkXcXUhjchR()._B19pyNfKCkJxZB1oCC3WzfkqEQF()._mgkfAuKt1tsSRmn1YmxkzbHikc();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Flirty, EClothes.Sleeves, "Flirty Sleeves")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._9mDS3yizOswyCzK6V3LBhafV7Dh();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Flirty, EClothes.Underwear, "Flirty underwear")._dUWotuFGWMaIlD1IFkXcXUhjchR()._mgkfAuKt1tsSRmn1YmxkzbHikc();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Shy, EClothes.Shirt, "Shy shirt only")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._9mDS3yizOswyCzK6V3LBhafV7Dh();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Shy, EClothes.Shorts, "Shy outfit")._dUWotuFGWMaIlD1IFkXcXUhjchR()._B19pyNfKCkJxZB1oCC3WzfkqEQF()._mgkfAuKt1tsSRmn1YmxkzbHikc();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Shy, EClothes.Sleeves, "Shy sleeves")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._9mDS3yizOswyCzK6V3LBhafV7Dh();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Shy, EClothes.Underwear, "Shy underwear")._dUWotuFGWMaIlD1IFkXcXUhjchR()._mgkfAuKt1tsSRmn1YmxkzbHikc();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Chill, EClothes.Shirt, "Chill shirt only")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._9mDS3yizOswyCzK6V3LBhafV7Dh();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Chill, EClothes.Shorts, "Chil outfit")._dUWotuFGWMaIlD1IFkXcXUhjchR()._B19pyNfKCkJxZB1oCC3WzfkqEQF()._mgkfAuKt1tsSRmn1YmxkzbHikc();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Chill, EClothes.Sleeves, "Chill Sleeves")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._9mDS3yizOswyCzK6V3LBhafV7Dh();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Chill, EClothes.Underwear, "Chill underwear")._dUWotuFGWMaIlD1IFkXcXUhjchR()._B19pyNfKCkJxZB1oCC3WzfkqEQF()._mgkfAuKt1tsSRmn1YmxkzbHikc();
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
