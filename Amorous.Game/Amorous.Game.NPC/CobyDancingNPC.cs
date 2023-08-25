using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class CobyDancingNPC : SpineNPC<CobyDancingNPC.EHeads, CobyDancingNPC.EPoses, CobyDancingNPC.EClothes>
{
	public enum EHeads
	{
		None,
		Happy
	}

	public enum EPoses
	{
		None,
		Dancing
	}

	public enum EClothes
	{
		None,
		Shirt,
		Shorts,
		Sleeves
	}

	public static Color Color = new Color(104, 193, 255);

	public CobyDancingNPC(IAmorous game)
		: base(game, "Assets/NPC/CobyDancing/Coby", 0.8f, premultipliedAlpha: true)
	{
		Width = 600;
		Height = 800;
		base.Skeleton.StartAnimationWithLooping("animation");
		AddEmotion(EHeads.Happy, "Eyes Back", "Pupil", "Jaw", "Head");
		AddPose(EPoses.Dancing, "Tail", "Leg right", "Arm right", "Body", "left leg", "Arm left").AddNudes("Balls", "Cock");
		AddClothes(EPoses.Dancing, EClothes.Shirt, "Shirt").AsShirt().AsNudes();
		AddClothes(EPoses.Dancing, EClothes.Shorts, "Shorts right", "Shorts crotch", "Shorts left").AsPants().AsCloth();
		AddClothes(EPoses.Dancing, EClothes.Sleeves, "Sleeves right", "Sleeves left").AsShirt().AsNudes();
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
