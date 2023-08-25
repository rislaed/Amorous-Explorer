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
		: base(game, "Assets/NPC/Coby/Coby", 1f, premultipliedAlpha: true)
	{
		base.Skeleton.StartAnimationWithLooping("Breathing");
		AddEmotion(EHeads.Sad, "Sad Head", "Sad Pupils", "Sad Eye back").WithBlinking("Sad Blink");
		AddEmotion(EHeads.Cocky, "Cocky Head", "Cocky Pupils", "Cocky Black eye back", "Cocky Jaw").WithBlinking("Cocky Blink");
		AddEmotion(EHeads.Flirty, "Flirty Head", "Flirty Pupils", "Flirty Black eye back", "Flirty Jaw").WithBlinking("Flirty Blink");
		AddEmotion(EHeads.Happy, "Happy Head", "Happy Pupil", "Happy Black eye back", "Happy Jaw").WithBlinking("Happy Blink");
		AddPose(EPoses.Flirty, "Neck puff", "Flirty Bod", "Leg extension").AddNudes("Flirty cock");
		AddPose(EPoses.Shy, "Neck puff", "Shy Bod").AddNudes("Chill/Shy Cock");
		AddPose(EPoses.Chill, "Neck puff", "Chill Bod").AddNudes("Chill cock");
		AddClothes(EPoses.Flirty, EClothes.Shirt, "Flirty shirt only").AsShirt().AsNudes();
		AddClothes(EPoses.Flirty, EClothes.Shorts, "Flirty outfit").AsPants().AsCensoringPants().AsCloth();
		AddClothes(EPoses.Flirty, EClothes.Sleeves, "Flirty Sleeves").AsShirt().AsNudes();
		AddClothes(EPoses.Flirty, EClothes.Underwear, "Flirty underwear").AsPants().AsCloth();
		AddClothes(EPoses.Shy, EClothes.Shirt, "Shy shirt only").AsShirt().AsNudes();
		AddClothes(EPoses.Shy, EClothes.Shorts, "Shy outfit").AsPants().AsCensoringPants().AsCloth();
		AddClothes(EPoses.Shy, EClothes.Sleeves, "Shy sleeves").AsShirt().AsNudes();
		AddClothes(EPoses.Shy, EClothes.Underwear, "Shy underwear").AsPants().AsCloth();
		AddClothes(EPoses.Chill, EClothes.Shirt, "Chill shirt only").AsShirt().AsNudes();
		AddClothes(EPoses.Chill, EClothes.Shorts, "Chil outfit").AsPants().AsCensoringPants().AsCloth();
		AddClothes(EPoses.Chill, EClothes.Sleeves, "Chill Sleeves").AsShirt().AsNudes();
		AddClothes(EPoses.Chill, EClothes.Underwear, "Chill underwear").AsPants().AsCensoringPants().AsCloth();
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
