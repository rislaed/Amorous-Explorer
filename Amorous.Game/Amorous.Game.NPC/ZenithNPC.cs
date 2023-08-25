using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class ZenithNPC : SpineNPC<ZenithNPC.EHeads, ZenithNPC.EPoses, ZenithNPC.EClothes>
{
	public enum EHeads
	{
		None,
		Angry,
		Blush,
		Happy,
		NotAmused
	}

	public enum EPoses
	{
		None,
		ArmsFolded,
		HandsOnHips
	}

	public enum EClothes
	{
		None,
		Security,
		Shirt,
		Pants
	}

	public static string Name = "Zenith";
	public static Color Color = new Color(155, 213, 154);

	public ZenithNPC(IAmorous game)
		: base(game, "Assets/NPC/Zenith/Zenith", 1f, premultipliedAlpha: true)
	{
		base.Skeleton.StartAnimationWithLooping("animation");
		AddEmotion(EHeads.Angry, "Head angry", "Eye Back", "Pupils").WithBlinking("Blink");
		AddEmotion(EHeads.Blush, "Head Blush", "Eye Back", "Pupils").WithBlinking("Blink");
		AddEmotion(EHeads.Happy, "Head Happy", "Eye Back", "Pupils").WithBlinking("Blink");
		AddEmotion(EHeads.NotAmused, "Head Un-amused", "Eye Back", "Pupils").WithBlinking("Blink");
		AddPose(EPoses.ArmsFolded, "Body fold arms", "Wing left", "Wing right");
		AddPose(EPoses.HandsOnHips, "Body hips", "Wing left", "Wing right");
		AddClothes(EPoses.ArmsFolded, EClothes.Security, "Security fold arms").AsShirt();
		AddClothes(EPoses.ArmsFolded, EClothes.Shirt, "Shirt fold arms").AsShirt();
		AddClothes(EPoses.ArmsFolded, EClothes.Pants, "Pants fold arms").AsPants();
		AddClothes(EPoses.HandsOnHips, EClothes.Security, "Security hips").AsShirt();
		AddClothes(EPoses.HandsOnHips, EClothes.Shirt, "Shirt hips").AsShirt();
		AddClothes(EPoses.HandsOnHips, EClothes.Pants, "Pants hips").AsPants();
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
				X = 1000f;
				Y = 1090f;
				break;
			case NPCLocation.Left:
				FlipX = false;
				X = 380f;
				Y = 1090f;
				break;
			case NPCLocation.Right:
				FlipX = false;
				X = 1540f;
				Y = 1090f;
				break;
		}
	}
}
