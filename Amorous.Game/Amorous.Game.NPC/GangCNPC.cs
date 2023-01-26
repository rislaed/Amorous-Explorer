using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class GangCNPC : LayerNPC<GangCNPC.EHeads, GangCNPC.EPoses, GangCNPC.EClothes>
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

	public static string Name = "Jade";

	public static Color Color = new Color(98, 178, 17);

	public GangCNPC(IAmorous game)
		: base(Game, "Assets/NPC/GangC", 1f)
	{
		Width = 610;
		Height = 1002;
		_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Neutral, "Jade Nude");
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Neutral, EClothes.Shirt, "Jade Shirt")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._9mDS3yizOswyCzK6V3LBhafV7Dh();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Neutral, EClothes.Pants, "Jade Pants")._dUWotuFGWMaIlD1IFkXcXUhjchR()._mgkfAuKt1tsSRmn1YmxkzbHikc();
		_J4giDjnRtYmiHMmzwRZ0ThvfAhH = false;
		_upl1k7yzBzlU7vErvbydGmXROfA = true;
	}

	protected override string[] _zBK8PXhWw9GtXK9IHkvbuvhbigE()
	{
		return new string[3] { "Jade Nude", "Jade Pants", "Jade Shirt" };
	}

	public override void SetLocation(NPCLocation npclocation_0)
	{
		base.SetLocation(npclocation_0);
		switch (npclocation_0)
		{
		case NPCLocation.Middle:
			FlipX = false;
			X = 655f;
			Y = 78f;
			base.Scale = 1f;
			break;
		case NPCLocation.Left:
			FlipX = true;
			X = 100f;
			Y = 78f;
			base.Scale = 1f;
			break;
		case NPCLocation.Right:
			FlipX = false;
			X = 1210f;
			Y = 78f;
			base.Scale = 1f;
			break;
		}
	}
}
