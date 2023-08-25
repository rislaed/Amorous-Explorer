using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class SethNPC : SpineNPC<SethNPC.EHeads, SethNPC.EPoses, SethNPC.EClothes>
{
	public enum EHeads
	{
		None,
		Blush,
		Happy,
		Sad,
		Smirk
	}

	public enum EPoses
	{
		None,
		Shy,
		Gesture
	}

	public enum EClothes
	{
		None,
		Top,
		Pants
	}

	public static string Name = "Seth";
	public static Color Color = new Color(176, 255, 83);

	public SethNPC(IAmorous game)
		: base(game, "Assets/NPC/Seth/Seth", 1f, premultipliedAlpha: true)
	{
		base.Skeleton.StartAnimationWithLooping("Idle");
		AddEmotion(EHeads.Blush, "Blush head", "Blush pupils", "Blush eyeback");
		AddEmotion(EHeads.Happy, "Happy head", "Happy Pupils", "Happy eyeback", "Happy jaw").WithBlinking("Happy blink");
		AddEmotion(EHeads.Sad, "Sad head", "Sad pupils", "Sad eye back").WithBlinking("Sad blink");
		AddEmotion(EHeads.Smirk, "Smirk Head", "Smirk Pupil", "Smirk eye back").WithBlinking("Smirk Blink");
		AddPose(EPoses.Shy, "Shy body").AddNudes("Seth cock");
		AddPose(EPoses.Gesture, "Gesture Body").AddNudes("Seth cock");
		AddClothes(EPoses.Shy, EClothes.Top, "Shy top").AsShirt().AsNudes();
		AddClothes(EPoses.Shy, EClothes.Pants, "Pants").AsPants().AsCloth();
		AddClothes(EPoses.Gesture, EClothes.Top, "Gesture top").AsShirt().AsNudes();
		AddClothes(EPoses.Gesture, EClothes.Pants, "Pants").AsPants().AsCloth();
		NudesBehindShirt = false;
		NudesBehindPants = true;
	}

	public override void SetLocation(NPCLocation location)
	{
		base.SetLocation(location);
		switch (location)
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
