using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class GamestoreClerkNPC : LayerNPC<GamestoreClerkNPC.EHeads, GamestoreClerkNPC.EPoses, GamestoreClerkNPC.EClothes>
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

	public static string Name = "Game Store Clerk";

	public static Color Color = new Color(252, 137, 76);

	public GamestoreClerkNPC(IAmorous game)
		: base(Game, "Assets/NPC/GamestoreClerk", 1f)
	{
		_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Standing, "Kula Game Store Clerk (nude)");
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Standing, EClothes.Pants, "Kula Game Store Clerk (pants)")._dUWotuFGWMaIlD1IFkXcXUhjchR()._mgkfAuKt1tsSRmn1YmxkzbHikc();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Standing, EClothes.Shirt, "Kula Game Store Clerk (shirt)")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._9mDS3yizOswyCzK6V3LBhafV7Dh();
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
			X = 545f;
			Y = 0f;
			break;
		case NPCLocation.Left:
			FlipX = true;
			X = -80f;
			Y = 0f;
			break;
		case NPCLocation.Right:
			FlipX = false;
			X = 1166f;
			Y = 0f;
			break;
		}
	}
}
