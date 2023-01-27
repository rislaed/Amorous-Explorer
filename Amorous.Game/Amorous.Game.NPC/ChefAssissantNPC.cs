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

	public ChefAssissantNPC(IAmorous game)
		: base(game, "Assets/NPC/ChefAssissant", 1f)
	{
		GetPose(EPoses.Standing, "Wraak Veldheer - Nude");
		GetClothes(EPoses.Standing, EClothes.Pants, "Wraak Veldheer - Pants")._dUWotuFGWMaIlD1IFkXcXUhjchR()._mgkfAuKt1tsSRmn1YmxkzbHikc();
		GetClothes(EPoses.Standing, EClothes.Shirt, "Wraak Veldheer - Shirt")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._9mDS3yizOswyCzK6V3LBhafV7Dh();
		_J4giDjnRtYmiHMmzwRZ0ThvfAhH = false;
		_upl1k7yzBzlU7vErvbydGmXROfA = true;
	}

	public override void SetLocation(NPCLocation npclocation_0)
	{
		base.SetLocation(npclocation_0);
		switch (npclocation_0)
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
