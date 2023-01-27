using System;
using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class SkyeNPC : SpineNPC<SkyeNPC.EHeads, SkyeNPC.EPoses, SkyeNPC.EClothes>
{
	public enum EHeads
	{
		None,
		Angry,
		Blush,
		Sad,
		Happy,
		Neutral
	}

	public enum EPoses
	{
		None,
		Suggestive,
		Guarded
	}

	public enum EClothes
	{
		None,
		Hoodie,
		Shirt,
		Shorts
	}

	public static string Name = "Skye";

	public static Color Color = new Color(248, 255, 167);

	public SkyeNPC(IAmorous game)
		: base(game, "Assets/NPC/Skye/Skye", 1f, bool_0: true)
	{
		base._rAt6TRbgK04lvrs5QPjcd0n26pk = new Type[2]
		{
			typeof(SkyeBlueNPC),
			typeof(SkyeGrayNPC)
		};
		base.Spine.StartAnimationWithLooping("Idle");
		GetEmotion(EHeads.Angry, "Angry Head", "Angry pupil", "Angry eyeback");
		GetEmotion(EHeads.Blush, "Blush head", "Blush pupils", "Blush eye back");
		GetEmotion(EHeads.Sad, "Sad Head", "Sad pupil", "Sad eye back");
		GetEmotion(EHeads.Happy, "Happy head", "Happy pupil", "Happy eye back", "Happy jaw")._qL2MEiFtBpbdxqUUTSqOgOsEK4j("Happy blink");
		GetEmotion(EHeads.Neutral, "Neutral head", "Neutral pupil", "Neutral eye back", "Neutral jaw")._qL2MEiFtBpbdxqUUTSqOgOsEK4j("Neutral blink");
		GetPose(EPoses.Suggestive, "Suggestive Body", "Suggestive boobs", "Suggestive Tail");
		GetPose(EPoses.Guarded, "Guarded body", "Guarded boobs", "Guarded boob cover", "Guarded tail");
		GetClothes(EPoses.Suggestive, EClothes.Hoodie, "Suggestive hoodie")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._KCZzL8xtjbw97bTOV0k8JDz3olE()._9mDS3yizOswyCzK6V3LBhafV7Dh();
		GetClothes(EPoses.Suggestive, EClothes.Shirt, "Suggestive shirt")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._9mDS3yizOswyCzK6V3LBhafV7Dh();
		GetClothes(EPoses.Suggestive, EClothes.Shorts, "Suggestive shorts")._dUWotuFGWMaIlD1IFkXcXUhjchR()._B19pyNfKCkJxZB1oCC3WzfkqEQF()._mgkfAuKt1tsSRmn1YmxkzbHikc();
		GetClothes(EPoses.Guarded, EClothes.Hoodie, "Guarded hoodie")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._KCZzL8xtjbw97bTOV0k8JDz3olE()._9mDS3yizOswyCzK6V3LBhafV7Dh();
		GetClothes(EPoses.Guarded, EClothes.Shirt, "Guarded shirt")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._9mDS3yizOswyCzK6V3LBhafV7Dh();
		GetClothes(EPoses.Guarded, EClothes.Shorts, "Guarded shorts")._dUWotuFGWMaIlD1IFkXcXUhjchR()._B19pyNfKCkJxZB1oCC3WzfkqEQF()._mgkfAuKt1tsSRmn1YmxkzbHikc();
		_J4giDjnRtYmiHMmzwRZ0ThvfAhH = true;
		_upl1k7yzBzlU7vErvbydGmXROfA = true;
	}

	public override void SetLocation(NPCLocation npclocation_0)
	{
		base.SetLocation(npclocation_0);
		switch (npclocation_0)
		{
		default:
			FlipX = false;
			X = 960f;
			Y = 1120f;
			break;
		case NPCLocation.Right:
			FlipX = true;
			X = 1520f;
			Y = 1120f;
			break;
		case NPCLocation.Left:
			FlipX = false;
			X = 400f;
			Y = 1120f;
			break;
		}
	}
}
