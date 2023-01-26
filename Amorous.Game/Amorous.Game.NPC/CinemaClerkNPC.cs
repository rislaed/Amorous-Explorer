using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class CinemaClerkNPC : LayerNPC<CinemaClerkNPC.EHeads, CinemaClerkNPC.EPoses, CinemaClerkNPC.EClothes>
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
		Vest,
		Pants
	}

	public static string Name = "Cryptic";

	public static Color Color = new Color(255, 24, 24);

	public CinemaClerkNPC(IAmorous game)
		: base(Game, "Assets/NPC/CinemaClerk", 1f)
	{
		_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Standing, "Cinema Clerk Expressions");
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Standing, EClothes.Pants, "Cinema Clerk Expressions - Pants")._dUWotuFGWMaIlD1IFkXcXUhjchR()._mgkfAuKt1tsSRmn1YmxkzbHikc();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Standing, EClothes.Vest, "Cinema Clerk Expressions - Vest")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._9mDS3yizOswyCzK6V3LBhafV7Dh();
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
			X = 413f;
			Y = 22f;
			break;
		case NPCLocation.Left:
			FlipX = true;
			X = -190f;
			Y = 22f;
			break;
		case NPCLocation.Right:
			FlipX = false;
			X = 1016f;
			Y = 22f;
			break;
		}
	}
}
