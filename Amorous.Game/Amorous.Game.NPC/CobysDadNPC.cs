using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class CobysDadNPC : LayerNPC<CobysDadNPC.EHeads, CobysDadNPC.EPoses, CobysDadNPC.EClothes>
{
	public enum EHeads
	{
		None,
		Stern
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

	public static string Name = "Coby's Dad";

	public static Color Color = new Color(176, 206, 255);

	public CobysDadNPC(IAmorous game)
		: base(Game, "Assets/NPC/CobysDad", 1f)
	{
		_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Stern, "Coby's Dad eye", "Coby's Dad Head");
		_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Standing, "Coby's Dad Body");
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Standing, EClothes.Pants, "Coby's Dad Pants")._dUWotuFGWMaIlD1IFkXcXUhjchR()._mgkfAuKt1tsSRmn1YmxkzbHikc();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Standing, EClothes.Shirt, "Coby's Dad Shirt")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._9mDS3yizOswyCzK6V3LBhafV7Dh();
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
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EX = 612f;
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EY = 24f;
			break;
		case NPCLocation.Left:
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_Pv8G2bIbjHmJYrVXhNyr64NSPXn = true;
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EX = -160f;
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EY = 24f;
			break;
		case NPCLocation.Right:
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_Pv8G2bIbjHmJYrVXhNyr64NSPXn = false;
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EX = 1185f;
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EY = 24f;
			break;
		}
	}
}
