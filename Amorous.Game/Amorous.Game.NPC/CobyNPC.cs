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
		: base(game, "Assets/NPC/Coby/Coby", 1f, bool_0: true)
	{
		base.Spine.StartAnimationWithLooping("Breathing");
		GetEmotion(EHeads.Sad, "Sad Head", "Sad Pupils", "Sad Eye back")._qL2MEiFtBpbdxqUUTSqOgOsEK4j("Sad Blink");
		GetEmotion(EHeads.Cocky, "Cocky Head", "Cocky Pupils", "Cocky Black eye back", "Cocky Jaw")._qL2MEiFtBpbdxqUUTSqOgOsEK4j("Cocky Blink");
		GetEmotion(EHeads.Flirty, "Flirty Head", "Flirty Pupils", "Flirty Black eye back", "Flirty Jaw")._qL2MEiFtBpbdxqUUTSqOgOsEK4j("Flirty Blink");
		GetEmotion(EHeads.Happy, "Happy Head", "Happy Pupil", "Happy Black eye back", "Happy Jaw")._qL2MEiFtBpbdxqUUTSqOgOsEK4j("Happy Blink");
		GetPose(EPoses.Flirty, "Neck puff", "Flirty Bod", "Leg extension")._6NcgB9eEKq8eKu8SgNWnKbLsDhB("Flirty cock");
		GetPose(EPoses.Shy, "Neck puff", "Shy Bod")._6NcgB9eEKq8eKu8SgNWnKbLsDhB("Chill/Shy Cock");
		GetPose(EPoses.Chill, "Neck puff", "Chill Bod")._6NcgB9eEKq8eKu8SgNWnKbLsDhB("Chill cock");
		GetClothes(EPoses.Flirty, EClothes.Shirt, "Flirty shirt only")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._9mDS3yizOswyCzK6V3LBhafV7Dh();
		GetClothes(EPoses.Flirty, EClothes.Shorts, "Flirty outfit")._dUWotuFGWMaIlD1IFkXcXUhjchR()._B19pyNfKCkJxZB1oCC3WzfkqEQF()._mgkfAuKt1tsSRmn1YmxkzbHikc();
		GetClothes(EPoses.Flirty, EClothes.Sleeves, "Flirty Sleeves")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._9mDS3yizOswyCzK6V3LBhafV7Dh();
		GetClothes(EPoses.Flirty, EClothes.Underwear, "Flirty underwear")._dUWotuFGWMaIlD1IFkXcXUhjchR()._mgkfAuKt1tsSRmn1YmxkzbHikc();
		GetClothes(EPoses.Shy, EClothes.Shirt, "Shy shirt only")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._9mDS3yizOswyCzK6V3LBhafV7Dh();
		GetClothes(EPoses.Shy, EClothes.Shorts, "Shy outfit")._dUWotuFGWMaIlD1IFkXcXUhjchR()._B19pyNfKCkJxZB1oCC3WzfkqEQF()._mgkfAuKt1tsSRmn1YmxkzbHikc();
		GetClothes(EPoses.Shy, EClothes.Sleeves, "Shy sleeves")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._9mDS3yizOswyCzK6V3LBhafV7Dh();
		GetClothes(EPoses.Shy, EClothes.Underwear, "Shy underwear")._dUWotuFGWMaIlD1IFkXcXUhjchR()._mgkfAuKt1tsSRmn1YmxkzbHikc();
		GetClothes(EPoses.Chill, EClothes.Shirt, "Chill shirt only")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._9mDS3yizOswyCzK6V3LBhafV7Dh();
		GetClothes(EPoses.Chill, EClothes.Shorts, "Chil outfit")._dUWotuFGWMaIlD1IFkXcXUhjchR()._B19pyNfKCkJxZB1oCC3WzfkqEQF()._mgkfAuKt1tsSRmn1YmxkzbHikc();
		GetClothes(EPoses.Chill, EClothes.Sleeves, "Chill Sleeves")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._9mDS3yizOswyCzK6V3LBhafV7Dh();
		GetClothes(EPoses.Chill, EClothes.Underwear, "Chill underwear")._dUWotuFGWMaIlD1IFkXcXUhjchR()._B19pyNfKCkJxZB1oCC3WzfkqEQF()._mgkfAuKt1tsSRmn1YmxkzbHikc();
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
