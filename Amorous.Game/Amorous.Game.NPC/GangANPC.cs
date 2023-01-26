using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class GangANPC : LayerNPC<GangANPC.EHeads, GangANPC.EPoses, GangANPC.EClothes>
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

	public static string Name = "Kazee Fullford";

	public static Color Color = new Color(220, 0, 0);

	public GangANPC(IAmorous game)
		: base(Game, "Assets/NPC/GangA", 1f)
	{
		Width = 1182;
		Height = 966;
		_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Neutral, "Kazee and Taylor Nude");
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Neutral, EClothes.Shirt, "Kazee and Taylor Shirts")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._9mDS3yizOswyCzK6V3LBhafV7Dh();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Neutral, EClothes.Pants, "Kazee and Taylor Pants")._dUWotuFGWMaIlD1IFkXcXUhjchR()._mgkfAuKt1tsSRmn1YmxkzbHikc();
		_J4giDjnRtYmiHMmzwRZ0ThvfAhH = false;
		_upl1k7yzBzlU7vErvbydGmXROfA = true;
	}

	protected override string[] _zBK8PXhWw9GtXK9IHkvbuvhbigE()
	{
		return new string[3] { "Kazee and Taylor Nude", "Kazee and Taylor Pants", "Kazee and Taylor Shirts" };
	}

	public override void SetLocation(NPCLocation npclocation_0)
	{
		base.SetLocation(npclocation_0);
		switch (npclocation_0)
		{
		case NPCLocation.Middle:
			FlipX = false;
			X = 369f;
			Y = 114f;
			base.Scale = 1f;
			break;
		case NPCLocation.Left:
			FlipX = false;
			X = -100f;
			Y = 114f;
			base.Scale = 1f;
			break;
		case NPCLocation.Right:
			FlipX = true;
			X = 838f;
			Y = 114f;
			base.Scale = 1f;
			break;
		}
	}
}
