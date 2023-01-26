using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class CosplayerLexyNPC : LayerNPC<CosplayerLexyNPC.EHeads, CosplayerLexyNPC.EPoses, CosplayerLexyNPC.EClothes>
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
		Costume
	}

	public static string Name = "Lexy";

	public static Color Color = new Color(60, 128, 241);

	public CosplayerLexyNPC(IAmorous game)
		: base(Game, "Assets/NPC/CosplayerLexy", 1f)
	{
		_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Standing, "Lexy Cosplayer (nude)")._6NcgB9eEKq8eKu8SgNWnKbLsDhB("Lexy Cosplayer (fringe for nude)");
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Standing, EClothes.Costume, "Lexy Cosplayer (clothed)")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._dUWotuFGWMaIlD1IFkXcXUhjchR()._mgkfAuKt1tsSRmn1YmxkzbHikc();
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
			Y = 0f;
			break;
		case NPCLocation.Left:
			FlipX = true;
			X = -280f;
			Y = 0f;
			break;
		case NPCLocation.Right:
			FlipX = false;
			X = 1016f;
			Y = 0f;
			break;
		}
	}
}
