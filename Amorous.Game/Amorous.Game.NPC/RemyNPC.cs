using System.Linq;
using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class RemyNPC : SpineNPC<RemyNPC.EHeads, RemyNPC.EPoses, RemyNPC.EClothes>
{
	public enum EHeads
	{
		None,
		Blushing,
		Happy,
		Sad,
		Shocked
	}

	public enum EPoses
	{
		None,
		LeftArm,
		RightArm,
		BothArms,
		Shy
	}

	public enum EClothes
	{
		None,
		Apron,
		Pants,
		Sweater,
		Swimsuit
	}

	public static string Name = "Remy";
	public static Color Color = new Color(255, 102, 51);

	public RemyNPC(IAmorous game)
		: base(game, "Assets/NPC/Remy/Remy", 0.75f, premultipliedAlpha: true)
	{
		base.Spine.StartAnimationWithLooping("animation");
		string[] first = new string[5] { "Fringe", "Ponytail", "Ear left", "Ear right", "Eyes back" };
		AddEmotion(EHeads.Blushing, first.Union(new string[2] { "Head Blush", "Default pupils" }).ToArray()).WithBlinking("Head blush blink");
		AddEmotion(EHeads.Happy, first.Union(new string[2] { "Head Happy", "Default pupils" }).ToArray()).WithBlinking("Head happy blink");
		AddEmotion(EHeads.Sad, first.Union(new string[2] { "Head Sad", "Sad pupils" }).ToArray());
		AddEmotion(EHeads.Shocked, first.Union(new string[2] { "Head Shock", "Default pupils" }).ToArray());
		string[] first2 = new string[5] { "Body", "Breasts", "Torso", "Hair", "Tail" };
		AddPose(EPoses.LeftArm, first2.Union(new string[3] { "Gesture forearm left", "Gesture hand left", "Gesture shoulder left" }).ToArray());
		AddPose(EPoses.RightArm, first2.Union(new string[3] { "Shy arms back", "Gesture forearm right", "Gesture hand right" }).ToArray());
		AddPose(EPoses.BothArms, first2.Union(new string[5] { "Gesture forearm left", "Gesture hand left", "Gesture shoulder left", "Gesture forearm right", "Gesture hand right" }).ToArray());
		AddPose(EPoses.Shy, first2.Union(new string[1] { "Shy arms back" }).ToArray());
		AddClothes(EPoses.LeftArm, EClothes.Apron, "Apron").AsShirt().AsPants();
		AddClothes(EPoses.LeftArm, EClothes.Pants, "Pants").AsPants().AsCensoredPants();
		AddClothes(EPoses.LeftArm, EClothes.Sweater, "Sweater body", "Sweater breasts", "Sweater torso", "Sweater Gesture shoulder left").AsShirt().AsCensoredShirt();
		AddClothes(EPoses.LeftArm, EClothes.Swimsuit, "Swimsuit").AsShirt().AsPants();
		AddClothes(EPoses.RightArm, EClothes.Apron, "Apron").AsShirt().AsPants();
		AddClothes(EPoses.RightArm, EClothes.Pants, "Pants").AsPants().AsCensoredPants();
		AddClothes(EPoses.RightArm, EClothes.Sweater, "Sweater body", "Sweater breasts", "Sweater torso", "Sweater shy arms back", "Sweater Gesture forearm right").AsShirt().AsCensoredShirt();
		AddClothes(EPoses.RightArm, EClothes.Swimsuit, "Swimsuit").AsShirt().AsPants();
		AddClothes(EPoses.BothArms, EClothes.Apron, "Apron").AsShirt().AsPants();
		AddClothes(EPoses.BothArms, EClothes.Pants, "Pants").AsPants().AsCensoredPants();
		AddClothes(EPoses.BothArms, EClothes.Sweater, "Sweater body", "Sweater breasts", "Sweater torso", "Sweater Gesture shoulder left", "Sweater Gesture forearm right").AsShirt().AsCensoredShirt();
		AddClothes(EPoses.BothArms, EClothes.Swimsuit, "Swimsuit").AsShirt().AsPants();
		AddClothes(EPoses.Shy, EClothes.Apron, "Apron").AsShirt().AsPants();
		AddClothes(EPoses.Shy, EClothes.Pants, "Pants").AsPants().AsCensoredPants();
		AddClothes(EPoses.Shy, EClothes.Sweater, "Sweater body", "Sweater breasts", "Sweater torso", "Sweater shy arms back").AsShirt().AsCensoredShirt();
		AddClothes(EPoses.Shy, EClothes.Swimsuit, "Swimsuit").AsShirt().AsPants();
		NudesBehindShirt = true;
		NudesBehindPants = true;
	}

	public override void SetLocation(NPCLocation location)
	{
		base.SetLocation(location);
		switch (location)
		{
			case NPCLocation.Middle:
				FlipX = false;
				X = 1000f;
				Y = 1200f;
				break;
			case NPCLocation.Left:
				FlipX = false;
				X = 380f;
				Y = 1200f;
				break;
			case NPCLocation.Right:
				FlipX = true;
				X = 1540f;
				Y = 1200f;
				break;
		}
	}
}
