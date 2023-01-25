using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class ExBoyfriendNPC : LayerNPC<ExBoyfriendNPC.EHeads, ExBoyfriendNPC.EPoses, ExBoyfriendNPC.EClothes>
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

	public static string Name = "Vareoth";

	public static Color Color = new Color(139, 215, 125);

	public ExBoyfriendNPC(IAmorous game)
		: base(Game, "Assets/NPC/ExBoyfriend", 1f)
	{
		_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Standing, "Dustin's Ex Boyfriend Expressions");
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Standing, EClothes.Pants, "Dustin's Ex Boyfriend Expressions - Pants")._dUWotuFGWMaIlD1IFkXcXUhjchR()._mgkfAuKt1tsSRmn1YmxkzbHikc();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Standing, EClothes.Shirt, "Dustin's Ex Boyfriend Expressions - Shirt")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._9mDS3yizOswyCzK6V3LBhafV7Dh();
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
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EX = 546f;
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EY = 177f;
			break;
		case NPCLocation.Left:
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_Pv8G2bIbjHmJYrVXhNyr64NSPXn = false;
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EX = -120f;
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EY = 177f;
			break;
		case NPCLocation.Right:
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_Pv8G2bIbjHmJYrVXhNyr64NSPXn = true;
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EX = 1412f;
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EY = 177f;
			break;
		}
	}
}
