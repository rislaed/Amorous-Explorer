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
		GetPose(EPoses.Standing, "Rose Wood Body");
		GetClothes(EPoses.Standing, EClothes.Shorts, "Rose Wood Shorts")._dUWotuFGWMaIlD1IFkXcXUhjchR()._mgkfAuKt1tsSRmn1YmxkzbHikc();
		GetClothes(EPoses.Standing, EClothes.Shirt, "Rose Wood Shirt")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._9mDS3yizOswyCzK6V3LBhafV7Dh();
		_J4giDjnRtYmiHMmzwRZ0ThvfAhH = true;
		_upl1k7yzBzlU7vErvbydGmXROfA = true;
	}

	public override void SetLocation(NPCLocation npclocation_0)
	{
		base.SetLocation(npclocation_0);
		switch (npclocation_0)
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
