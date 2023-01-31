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
		: base(game, "Assets/NPC/Skye/Skye", 1f, premultipliedAlpha: true)
	{
		base.Variations = new Type[2]
		{
			typeof(SkyeBlueNPC),
			typeof(SkyeGrayNPC)
		};
		base.Spine.StartAnimationWithLooping("Idle");
		AddEmotion(EHeads.Angry, "Angry Head", "Angry pupil", "Angry eyeback");
		AddEmotion(EHeads.Blush, "Blush head", "Blush pupils", "Blush eye back");
		AddEmotion(EHeads.Sad, "Sad Head", "Sad pupil", "Sad eye back");
		AddEmotion(EHeads.Happy, "Happy head", "Happy pupil", "Happy eye back", "Happy jaw").WithBlinking("Happy blink");
		AddEmotion(EHeads.Neutral, "Neutral head", "Neutral pupil", "Neutral eye back", "Neutral jaw").WithBlinking("Neutral blink");
		AddPose(EPoses.Suggestive, "Suggestive Body", "Suggestive boobs", "Suggestive Tail");
		AddPose(EPoses.Guarded, "Guarded body", "Guarded boobs", "Guarded boob cover", "Guarded tail");
		AddClothes(EPoses.Suggestive, EClothes.Hoodie, "Suggestive hoodie").AsShirt().AsCensoredShirt().AsNudes();
		AddClothes(EPoses.Suggestive, EClothes.Shirt, "Suggestive shirt").AsShirt().AsNudes();
		AddClothes(EPoses.Suggestive, EClothes.Shorts, "Suggestive shorts").AsPants().AsCensoredPants().AsCloth();
		AddClothes(EPoses.Guarded, EClothes.Hoodie, "Guarded hoodie").AsShirt().AsCensoredShirt().AsNudes();
		AddClothes(EPoses.Guarded, EClothes.Shirt, "Guarded shirt").AsShirt().AsNudes();
		AddClothes(EPoses.Guarded, EClothes.Shorts, "Guarded shorts").AsPants().AsCensoredPants().AsCloth();
		NudesBehindShirt = true;
		NudesBehindPants = true;
	}

	public override void SetLocation(NPCLocation location)
	{
		base.SetLocation(location);
		switch (location)
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
