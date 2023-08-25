using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class KaneNPC : LayerNPC<KaneNPC.EHeads, KaneNPC.EPoses, KaneNPC.EClothes>
{
	public enum EHeads
	{
		None,
		Angry
	}

	public enum EPoses
	{
		None,
		Stern
	}

	public enum EClothes
	{
		None,
		Shirt,
		Shorts
	}

	public static string Name = "Kane";
	public static Color Color = new Color(233, 193, 150);

	public KaneNPC(IAmorous game) : base(game, "Assets/NPC/Kane", 1f)
	{
		Width = 1110;
		Height = 1965;
		AddEmotion(EHeads.Angry, "Plate", "Eyeback", "Pupil", "Head").WithBlinking("Blink");
		AddPose(EPoses.Stern, "Stern").AddNudes("Dick");
		AddClothes(EPoses.Stern, EClothes.Shirt, "Stern Shirt").AsShirt().AsNudes();
		AddClothes(EPoses.Stern, EClothes.Shorts, "Stern Shorts").AsPants().AsCloth();
		NudesBehindShirt = false;
		NudesBehindPants = true;
	}

	protected override string[] GetPieces()
	{
		return new string[8] { "Plate", "Stern", "Stern Shirt", "Stern Shorts", "Eyeback", "Pupil", "Blink", "Head" };
	}

	public override void SetLocation(NPCLocation location)
	{
		base.SetLocation(location);
		switch (location)
		{
			case NPCLocation.Middle:
				FlipX = false;
				X = 305f;
				Y = 0f;
				base.Scale = 1f;
				break;
			case NPCLocation.Left:
				FlipX = false;
				X = -260f;
				Y = 0f;
				base.Scale = 1f;
				break;
			case NPCLocation.Right:
				FlipX = true;
				X = 1070f;
				Y = 0f;
				base.Scale = 1f;
				break;
		}
	}
}
