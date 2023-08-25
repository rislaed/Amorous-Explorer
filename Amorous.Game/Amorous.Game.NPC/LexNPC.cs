using System.Linq;
using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class LexNPC : SpineNPC<LexNPC.EHeads, LexNPC.EPoses, LexNPC.EClothes>
{
	public enum EHeads
	{
		None,
		Happy,
		Angry,
		Sad,
		Embarrassed
	}

	public enum EPoses
	{
		None,
		Neutral,
		Gesture,
		GestureDrink,
		GestureSigaret
	}

	public enum EClothes
	{
		None,
		Jacket,
		Jeans,
		Panties,
		Boxers,
		DickSoft,
		DickHard
	}

	public static string Name = "Lex";
	public static Color Color = new Color(255, 128, 0);

	public LexNPC(IAmorous game)
		: base(game, "Assets/NPC/Lex/Lex", 1f, premultipliedAlpha: true)
	{
		base.Skeleton.StartAnimationWithLooping("animation");
		string[] first = new string[5] { "Fringe", "Hair back", "Pupils", "Eyes back", "Ear" };
		AddEmotion(EHeads.Happy, first.Union(new string[1] { "Head happy" }).ToArray()).WithBlinking("Blink");
		AddEmotion(EHeads.Angry, first.Union(new string[1] { "Head angry" }).ToArray()).WithBlinking("Blink");
		AddEmotion(EHeads.Sad, first.Union(new string[1] { "Head sad" }).ToArray()).WithBlinking("Blink");
		AddEmotion(EHeads.Embarrassed, first.Union(new string[1] { "Head blush" }).ToArray()).WithBlinking("Blink");
		AddPose(EPoses.Neutral, "Body neutral", "Shoulder neutral", "Forearm neutral", "Tail");
		AddPose(EPoses.Gesture, "Body neutral", "Shoulder gesture", "Forearm gesture", "Hand gesture", "Tail");
		AddPose(EPoses.GestureDrink, "Body neutral", "Shoulder gesture", "Forearm gesture", "Hand drink", "Tail");
		AddPose(EPoses.GestureSigaret, "Body neutral", "Shoulder gesture", "Forearm gesture", "Hand cig", "Tail");
		AddClothes(EPoses.Neutral, EClothes.Jacket, "Jacket", "Shoulder neutral jacket", "Forearm neutral jacket").AsShirt();
		AddClothes(EPoses.Gesture, EClothes.Jacket, "Jacket", "Shoulder gesture jacket", "Forearm gesture jacket").AsShirt();
		AddClothes(EPoses.GestureDrink, EClothes.Jacket, "Jacket", "Shoulder gesture jacket", "Forearm gesture jacket").AsShirt();
		AddClothes(EPoses.GestureSigaret, EClothes.Jacket, "Jacket", "Shoulder gesture jacket", "Forearm gesture jacket").AsShirt();
		AddClothes(EPoses.Neutral, EClothes.Jeans, "Jeans").AsPants().AsCensoringPants();
		AddClothes(EPoses.Gesture, EClothes.Jeans, "Jeans").AsPants().AsCensoringPants();
		AddClothes(EPoses.GestureDrink, EClothes.Jeans, "Jeans").AsPants().AsCensoringPants();
		AddClothes(EPoses.GestureSigaret, EClothes.Jeans, "Jeans").AsPants().AsCensoringPants();
		AddClothes(EPoses.Neutral, EClothes.Panties, "Panties").AsPants();
		AddClothes(EPoses.Gesture, EClothes.Panties, "Panties").AsPants();
		AddClothes(EPoses.GestureDrink, EClothes.Panties, "Panties").AsPants();
		AddClothes(EPoses.GestureSigaret, EClothes.Panties, "Panties").AsPants();
		AddClothes(EPoses.Neutral, EClothes.Boxers, "Boxers").AsPants();
		AddClothes(EPoses.Gesture, EClothes.Boxers, "Boxers").AsPants();
		AddClothes(EPoses.GestureDrink, EClothes.Boxers, "Boxers").AsPants();
		AddClothes(EPoses.GestureSigaret, EClothes.Boxers, "Boxers").AsPants();
		AddClothes(EPoses.Neutral, EClothes.DickSoft, "Male balls", "Male dick soft");
		AddClothes(EPoses.Gesture, EClothes.DickSoft, "Male balls", "Male dick soft");
		AddClothes(EPoses.GestureDrink, EClothes.DickSoft, "Male balls", "Male dick soft");
		AddClothes(EPoses.GestureSigaret, EClothes.DickSoft, "Male balls", "Male dick soft");
		AddClothes(EPoses.Neutral, EClothes.DickHard, "Male balls", "Male dick hard");
		AddClothes(EPoses.Gesture, EClothes.DickHard, "Male balls", "Male dick hard");
		AddClothes(EPoses.GestureDrink, EClothes.DickHard, "Male balls", "Male dick hard");
		AddClothes(EPoses.GestureSigaret, EClothes.DickHard, "Male balls", "Male dick hard");
		base.Skeleton.OverlayWith("Male dick soft", "Jacket");
		base.Skeleton.OverlayWith("Male dick hard", "Male dick soft");
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
				Y = 1090f;
				break;
			case NPCLocation.Left:
				FlipX = false;
				X = 400f;
				Y = 1090f;
				break;
			case NPCLocation.Right:
				FlipX = false;
				X = 1520f;
				Y = 1090f;
				break;
		}
	}
}
