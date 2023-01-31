using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class VarryanceNPC : LayerNPC<VarryanceNPC.EHeads, VarryanceNPC.EPoses, VarryanceNPC.EClothes>
{
	public enum EHeads
	{
		None
	}

	public enum EPoses
	{
		None,
		Standing
	}

	public enum EClothes
	{
		None,
		Pants,
		Shirt
	}

	public static string Name = "Varryance";
	public static Color Color = new Color(162, 65, 159);

	public VarryanceNPC(IAmorous game)
		: base(game, "Assets/NPC/Varryance", 1f)
	{
		Width = 850;
		Height = 1649;
		AddPose(EPoses.Standing, "Varryance Body");
		AddClothes(EPoses.Standing, EClothes.Shirt, "Varryance Shirt").AsShirt().AsCloth();
		AddClothes(EPoses.Standing, EClothes.Pants, "Varryance Pants").AsPants().AsCloth();
		NudesBehindShirt = false;
		NudesBehindPants = true;
	}

	protected override string[] GetPieces()
	{
		return new string[3] { "Varryance Body", "Varryance Shirt", "Varryance Pants" };
	}

	public override void SetLocation(NPCLocation location)
	{
		base.SetLocation(location);
		switch (location)
		{
			case NPCLocation.Middle:
				FlipX = false;
				X = 735f;
				Y = 0f;
				base.Scale = 1f;
				break;
			case NPCLocation.Left:
				FlipX = true;
				X = -300f;
				Y = 0f;
				base.Scale = 1f;
				break;
			case NPCLocation.Right:
				FlipX = false;
				X = 1370f;
				Y = 0f;
				base.Scale = 1f;
				break;
		}
	}
}
