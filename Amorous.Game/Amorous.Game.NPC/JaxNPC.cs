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

	public JaxNPC(IAmorous game) : this(game, "Assets/NPC/Jax/Jax") {}

	public JaxNPC(IAmorous game, string path)
		: base(game, path, 1f, premultipliedAlpha: true)
	{
		Width = 904;
		Height = 1008;
		base.Variations = new Type[2]
		{
			typeof(JaxPurpleNPC),
			typeof(JaxRedNPC)
		};
		base.Skeleton.StartAnimationWithLooping("animation");
		AddEmotion(EHeads.Grumpy, "Grumpy Head", "Grumpy pupils", "Grumpy eyes back").WithBlinking("Grumpy Blink");
		AddEmotion(EHeads.Smirk, "Smirk head", "Smirk pupils", "Smirk eyes back").WithBlinking("Smirk Blink");
		AddEmotion(EHeads.Sad, "Sad Head", "Sad pupil", "Sad eye back", "Flirty Jaw").WithBlinking("Sad blink");
		AddEmotion(EHeads.Frustrated, "Frustrated Head", "Frustrated pupil", "Frustrated eye back").WithBlinking("Frustrated blink");
		AddEmotion(EHeads.Cheeky, "Cheeky Head", "Cheeky pupils", "Cheeky eye back").WithBlinking("Cheeky Blink");
		AddEmotion(EHeads.Unamused, "Unamused Head", "Unamused Pupils", "Unamused eye back").WithBlinking("Unamused Blink");
		AddEmotion(EHeads.Happy, "Happy head", "Happy pupil", "Happy eye back", "Happy jaw").WithBlinking("Happy Blink");
		AddPose(EPoses.Chill, "Body", "Right arm GestureChill", "Left arm chill", "Left thumb Chill").AddNudes("Cock");
		AddPose(EPoses.Gesture, "Body", "Right arm GestureChill", "Left arm Gesture").AddNudes("Cock");
		AddPose(EPoses.Defensive, "Body", "Right arm defensive", "Left Arm defensive").AddNudes("Cock");
		AddPose(EPoses.Shy, "Body", "Right arm shy", "Left arm shy").AddNudes("Cock");
		AddClothes(EPoses.Chill, EClothes.TuxChest, "Tux chest", "Tux Right arm GestureChill", "Tux Left arm chill").AsShirt().AsNudes();
		AddClothes(EPoses.Chill, EClothes.TuxUnderwear, "Tux underwear").AsPants().AsCloth();
		AddClothes(EPoses.Chill, EClothes.CasualJacket, "Casual body", "Casual right arm GestureChill", "Casual left arm chill").AsShirt().AsNudes();
		AddClothes(EPoses.Chill, EClothes.CasualPants, "Casual shorts").AsPants().AsCensoringPants().AsCloth();
		AddClothes(EPoses.Gesture, EClothes.TuxChest, "Tux chest", "Tux Right arm GestureChill", "Tux left arm gesture").AsShirt().AsNudes();
		AddClothes(EPoses.Gesture, EClothes.TuxUnderwear, "Tux underwear").AsPants().AsCloth();
		AddClothes(EPoses.Gesture, EClothes.CasualJacket, "Casual body", "Casual right arm GestureChill", "Casual left arm Gesture copy 2").AsShirt().AsNudes();
		AddClothes(EPoses.Gesture, EClothes.CasualPants, "Casual shorts").AsPants().AsCensoringPants().AsCloth();
		AddClothes(EPoses.Defensive, EClothes.TuxChest, "Tux chest", "Tux Right arm defensive").AsShirt().AsNudes();
		AddClothes(EPoses.Defensive, EClothes.TuxUnderwear, "Tux underwear").AsPants().AsCloth();
		AddClothes(EPoses.Defensive, EClothes.CasualJacket, "Casual body", "Casual right arm defensive", "Casual left arm defensive").AsShirt().AsNudes();
		AddClothes(EPoses.Defensive, EClothes.CasualPants, "Casual shorts").AsPants().AsCensoringPants().AsCloth();
		AddClothes(EPoses.Shy, EClothes.TuxChest, "Tux chest", "Tux right arm shy").AsShirt().AsNudes();
		AddClothes(EPoses.Shy, EClothes.TuxUnderwear, "Tux underwear").AsPants().AsCloth();
		AddClothes(EPoses.Shy, EClothes.CasualJacket, "Casual body", "Casual right arm shy", "Casual left arm shy").AsShirt().AsNudes();
		AddClothes(EPoses.Shy, EClothes.CasualPants, "Casual shorts").AsPants().AsCensoringPants().AsCloth();
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
