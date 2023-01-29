using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class RoseWoodNPC : LayerNPC<RoseWoodNPC.EHeads, RoseWoodNPC.EPoses, RoseWoodNPC.EClothes>
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
		Shirt,
		Shorts
	}

	public static string Name = "Rose Wood";

	public static Color Color = new Color(195, 69, 81);

	public RoseWoodNPC(IAmorous game)
		: base(game, "Assets/NPC/RoseWood", 1f)
	{
		AddPose(EPoses.Standing, "Rose Wood Body");
		AddClothes(EPoses.Standing, EClothes.Shorts, "Rose Wood Shorts").AsPants().AsCloth();
		AddClothes(EPoses.Standing, EClothes.Shirt, "Rose Wood Shirt").AsShirt().AsNudes();
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
			X = 725f;
			Y = 130f;
			break;
		case NPCLocation.Left:
			FlipX = false;
			X = 100f;
			Y = 130f;
			break;
		case NPCLocation.Right:
			FlipX = true;
			X = 1351f;
			Y = 130f;
			break;
		}
	}
}
