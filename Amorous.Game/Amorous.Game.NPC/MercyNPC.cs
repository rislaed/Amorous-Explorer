using System.Linq;
using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class MercyNPC : SpineNPC<MercyNPC.EHeads, MercyNPC.EPoses, MercyNPC.EClothes>
{
	public enum EHeads
	{
		None,
		Angry,
		Happy,
		Sad,
		BlushConfident,
		BlushShy
	}

	public enum EPoses
	{
		None,
		Standing,
		ArmsShy
	}

	public enum EClothes
	{
		None,
		Dress,
		SkimpyDress,
		SportsBra,
		SportsShorts,
		Necklace
	}

	public static string Name = "Mercy";
	public static Color Color = new Color(172, 135, 255);

	public MercyNPC(IAmorous game)
		: base(game, "Assets/NPC/Mercy/Mercy", 1f, premultipliedAlpha: true)
	{
		base.Spine.StartAnimationWithLooping("animation");
		string[] first = new string[7] { "Pupils", "Eyeback", "Hair back", "Hairlock left", "Fringe", "Horn", "Horn tip" };
		AddEmotion(EHeads.Angry, first.Union(new string[2] { "Angry head", "AngrySad ear" }).ToArray());
		AddEmotion(EHeads.Happy, first.Union(new string[3] { "Happy head", "Happy Jaw", "Happy ear" }).ToArray()).WithBlinking("Happy blink");
		AddEmotion(EHeads.Sad, first.Union(new string[2] { "Sad head", "AngrySad ear" }).ToArray()).WithBlinking("Sad Blink");
		AddEmotion(EHeads.BlushConfident, first.Union(new string[2] { "Blush Confident Head", "AngrySad ear" }).ToArray());
		AddEmotion(EHeads.BlushShy, first.Union(new string[2] { "Blush Shy Head", "AngrySad ear" }).ToArray()).WithBlinking("Sad Blink");
		AddPose(EPoses.Standing, "Body one", "Arm left hip", "Arm right hip", "Tail");
		AddPose(EPoses.ArmsShy, "Body one", "Arms shy", "Arms shy back", "Tail");
		AddClothes(EPoses.Standing, EClothes.Dress, "Dress").AsShirt().AsPants();
		AddClothes(EPoses.Standing, EClothes.SkimpyDress, "Skimpy Dress").AsShirt().AsPants();
		AddClothes(EPoses.Standing, EClothes.SportsBra, "Sports Bra").AsShirt().AsCensoredShirt();
		AddClothes(EPoses.Standing, EClothes.SportsShorts, "Sports Shorts").AsPants().AsCensoredPants();
		AddClothes(EPoses.Standing, EClothes.Necklace, "Necklace");
		AddClothes(EPoses.ArmsShy, EClothes.Dress, "Dress").AsShirt().AsPants();
		AddClothes(EPoses.ArmsShy, EClothes.SkimpyDress, "Skimpy Dress").AsShirt().AsPants();
		AddClothes(EPoses.ArmsShy, EClothes.SportsBra, "Sports Bra").AsShirt().AsCensoredShirt();
		AddClothes(EPoses.ArmsShy, EClothes.SportsShorts, "Sports Shorts").AsPants().AsCensoredPants();
		AddClothes(EPoses.ArmsShy, EClothes.Necklace, "Necklace");
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
				X = 960f;
				Y = 1090f;
				break;
			case NPCLocation.Left:
				FlipX = false;
				X = 320f;
				Y = 1090f;
				break;
			case NPCLocation.Right:
				FlipX = true;
				X = 1600f;
				Y = 1090f;
				break;
		}
	}
}
