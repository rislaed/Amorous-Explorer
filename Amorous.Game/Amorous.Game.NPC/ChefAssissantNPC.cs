using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class ChefAssissantNPC : LayerNPC<ChefAssissantNPC.EHeads, ChefAssissantNPC.EPoses, ChefAssissantNPC.EClothes>
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
		Pants
	}

	public static string Name = "Wraak Veldheer";
	public static Color Color = new Color(204, 149, 0);

	public ChefAssissantNPC(IAmorous game) : base(game, "Assets/NPC/ChefAssissant", 1f)
	{
		AddPose(EPoses.Standing, "Wraak Veldheer - Nude");
		AddClothes(EPoses.Standing, EClothes.Pants, "Wraak Veldheer - Pants").AsPants().AsCloth();
		AddClothes(EPoses.Standing, EClothes.Shirt, "Wraak Veldheer - Shirt").AsShirt().AsNudes();
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
				X = 636f;
				Y = 117f;
				break;
			case NPCLocation.Left:
				FlipX = true;
				X = 0f;
				Y = 117f;
				break;
			case NPCLocation.Right:
				FlipX = false;
				X = 1272f;
				Y = 117f;
				break;
		}
	}
}
