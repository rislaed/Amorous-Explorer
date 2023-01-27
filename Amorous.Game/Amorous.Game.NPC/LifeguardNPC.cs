using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class LifeguardNPC : LayerNPC<LifeguardNPC.EHeads, LifeguardNPC.EPoses, LifeguardNPC.EClothes>
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

	public static string Name = "Riptide";

	public static Color Color = new Color(244, 146, 66);

	public LifeguardNPC(IAmorous game)
		: base(game, "Assets/NPC/Lifeguard", 1f)
	{
		GetPose(EPoses.Standing, "Riptide - Nude");
		GetClothes(EPoses.Standing, EClothes.Pants, "Riptide - Pants")._dUWotuFGWMaIlD1IFkXcXUhjchR()._mgkfAuKt1tsSRmn1YmxkzbHikc();
		GetClothes(EPoses.Standing, EClothes.Shirt, "Riptide - Shirt")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._9mDS3yizOswyCzK6V3LBhafV7Dh();
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
			X = 689f;
			Y = 102f;
			break;
		case NPCLocation.Left:
			FlipX = true;
			X = -271f;
			Y = 102f;
			break;
		case NPCLocation.Right:
			FlipX = false;
			X = 1320f;
			Y = 102f;
			break;
		}
	}
}
