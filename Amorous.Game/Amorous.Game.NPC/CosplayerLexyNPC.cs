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

	public override void _nGGBtYpZ8pI1BmE2c2ke63UjGDP(NPCLocation npclocation_0)
	{
		base._nGGBtYpZ8pI1BmE2c2ke63UjGDP(npclocation_0);
		switch (npclocation_0)
		{
		case NPCLocation.Middle:
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_Pv8G2bIbjHmJYrVXhNyr64NSPXn = false;
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EX = 413f;
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EY = 0f;
			break;
		case NPCLocation.Left:
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_Pv8G2bIbjHmJYrVXhNyr64NSPXn = true;
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EX = -280f;
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EY = 0f;
			break;
		case NPCLocation.Right:
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_Pv8G2bIbjHmJYrVXhNyr64NSPXn = false;
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EX = 1016f;
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EY = 0f;
			break;
		}
	}
}
