using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class DustinNPC : SpineNPC<DustinNPC.EHeads, DustinNPC.EPoses, DustinNPC.EClothes>
{
	public enum EHeads
	{
		None,
		Neutral,
		Angry,
		Blush,
		Sad
	}

	public enum EPoses
	{
		None,
		Neutral,
		Gesture
	}

	public enum EClothes
	{
		None,
		Shirt,
		Pants
	}

	public static string Name = "Dustin";
	public static Color Color = new Color(242, 208, 150);

	public DustinNPC(IAmorous game)
		: base(game, "Assets/NPC/Dustin/Dustin", 1f, premultipliedAlpha: true)
	{
		base.Spine.StartAnimationWithLooping("Idle");
		AddEmotion(EHeads.Neutral, "Neutral Mane", "Neutral eye back", "Neutral pupil", "Neutral jaw", "Neutral head").WithBlinking("Neutral blink");
		AddEmotion(EHeads.Angry, "Angry mane", "Angry eyeback", "Angry pupil", "Angry head").WithBlinking("Angry blink");
		AddEmotion(EHeads.Blush, "Blush mane", "Blush eye back", "Blush pupil", "Blush head").WithBlinking("Blush blink");
		AddEmotion(EHeads.Sad, "Sad earback", "Sad mane", "Sad eyeback", "Sad pupils", "Sad head").WithBlinking("Sad blink");
		AddPose(EPoses.Neutral, "Body Neutral", "Neutral thumb").AddNudes("Cock");
		AddPose(EPoses.Gesture, "Body Gesture").AddNudes("Cock");
		AddClothes(EPoses.Neutral, EClothes.Shirt, "Neutral shirt").AsShirt().AsNudes();
		AddClothes(EPoses.Neutral, EClothes.Pants, "Pants").AsPants().AsCloth();
		AddClothes(EPoses.Gesture, EClothes.Shirt, "Gesture shirt").AsShirt().AsNudes();
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
				Y = 1100f;
				break;
			case NPCLocation.Left:
				FlipX = false;
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
