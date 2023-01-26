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
		: base(Game, "Assets/NPC/Varryance", 1f)
	{
		Width = 850;
		Height = 1649;
		_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Standing, "Varryance Body");
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Standing, EClothes.Shirt, "Varryance Shirt")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._mgkfAuKt1tsSRmn1YmxkzbHikc();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Standing, EClothes.Pants, "Varryance Pants")._dUWotuFGWMaIlD1IFkXcXUhjchR()._mgkfAuKt1tsSRmn1YmxkzbHikc();
		_J4giDjnRtYmiHMmzwRZ0ThvfAhH = false;
		_upl1k7yzBzlU7vErvbydGmXROfA = true;
	}

	protected override string[] _zBK8PXhWw9GtXK9IHkvbuvhbigE()
	{
		return new string[3] { "Varryance Body", "Varryance Shirt", "Varryance Pants" };
	}

	public override void SetLocation(NPCLocation npclocation_0)
	{
		base.SetLocation(npclocation_0);
		switch (npclocation_0)
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
