using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class BartenderNPC : LayerNPC<BartenderNPC.EHeads, BartenderNPC.EPoses, BartenderNPC.EClothes>
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

	public static string Name = "Rou";

	public static Color Color = new Color(116, 116, 116);

	public BartenderNPC(IAmorous game)
		: base(Game, "Assets/NPC/Bartender", 1f)
	{
		Width = 904;
		Height = 1008;
		_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Standing, "Bovine Naked");
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Standing, EClothes.Pants, "Bovine pants")._dUWotuFGWMaIlD1IFkXcXUhjchR()._mgkfAuKt1tsSRmn1YmxkzbHikc();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Standing, EClothes.Shirt, "Bovine Top")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._9mDS3yizOswyCzK6V3LBhafV7Dh();
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
			X = 608f;
			Y = 72f;
			break;
		case NPCLocation.Left:
			FlipX = true;
			X = -160f;
			Y = 72f;
			break;
		case NPCLocation.Right:
			FlipX = false;
			X = 1176f;
			Y = 72f;
			break;
		}
	}
}
