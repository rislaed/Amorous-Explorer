using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class SecurityGuardNPC : LayerNPC<SecurityGuardNPC.EHeads, SecurityGuardNPC.EPoses, SecurityGuardNPC.EClothes>
{
	public enum EHeads
	{
		None
	}

	public enum EPoses
	{
		None,
		Neutral
	}

	public enum EClothes
	{
		None,
		Shirt,
		Pants
	}

	public static string Name = "Alexis Pryde";

	public static Color Color = new Color(17, 178, 105);

	public SecurityGuardNPC(IAmorous game)
		: base(game, "Assets/NPC/SecurityGuard", 1f)
	{
		Width = 452;
		Height = 945;
		GetPose(EPoses.Neutral, "Alexis Nude", "Alexis Tufts");
		GetClothes(EPoses.Neutral, EClothes.Shirt, "Alexis Shirt")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._9mDS3yizOswyCzK6V3LBhafV7Dh();
		GetClothes(EPoses.Neutral, EClothes.Pants, "Alexis Pants")._dUWotuFGWMaIlD1IFkXcXUhjchR()._mgkfAuKt1tsSRmn1YmxkzbHikc();
		_J4giDjnRtYmiHMmzwRZ0ThvfAhH = true;
		_upl1k7yzBzlU7vErvbydGmXROfA = true;
	}

	protected override string[] _zBK8PXhWw9GtXK9IHkvbuvhbigE()
	{
		return new string[4] { "Alexis Nude", "Alexis Tufts", "Alexis Pants", "Alexis Shirt" };
	}

	public override void SetLocation(NPCLocation npclocation_0)
	{
		base.SetLocation(npclocation_0);
		switch (npclocation_0)
		{
		case NPCLocation.Middle:
			FlipX = false;
			X = 734f;
			Y = 135f;
			base.Scale = 1f;
			break;
		case NPCLocation.Left:
			FlipX = true;
			X = 100f;
			Y = 135f;
			base.Scale = 1f;
			break;
		case NPCLocation.Right:
			FlipX = false;
			X = 1368f;
			Y = 135f;
			base.Scale = 1f;
			break;
		}
	}
}
