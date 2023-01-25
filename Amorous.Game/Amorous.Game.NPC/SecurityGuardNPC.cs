using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class SecurityGuardNPC : LayerNPC<SecurityGuardNPC.EHeads, SecurityGuardNPC.EPoses, SecurityGuardNPC.EClothes>
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

	public static string Name = "Alexis Pryde";

	public static Color Color = new Color(17, 178, 105);

	public SecurityGuardNPC(IAmorous game)
		: base(Game, "Assets/NPC/SecurityGuard", 1f)
	{
		Width = 452;
		Height = 945;
		_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Neutral, "Alexis Nude", "Alexis Tufts");
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Neutral, EClothes.Shirt, "Alexis Shirt")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._9mDS3yizOswyCzK6V3LBhafV7Dh();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Neutral, EClothes.Pants, "Alexis Pants")._dUWotuFGWMaIlD1IFkXcXUhjchR()._mgkfAuKt1tsSRmn1YmxkzbHikc();
		_J4giDjnRtYmiHMmzwRZ0ThvfAhH = true;
		_upl1k7yzBzlU7vErvbydGmXROfA = true;
	}

	protected override string[] _zBK8PXhWw9GtXK9IHkvbuvhbigE()
	{
		return new string[4] { "Alexis Nude", "Alexis Tufts", "Alexis Pants", "Alexis Shirt" };
	}

	public override void _nGGBtYpZ8pI1BmE2c2ke63UjGDP(NPCLocation npclocation_0)
	{
		base._nGGBtYpZ8pI1BmE2c2ke63UjGDP(npclocation_0);
		switch (npclocation_0)
		{
		case NPCLocation.Middle:
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_Pv8G2bIbjHmJYrVXhNyr64NSPXn = false;
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EX = 734f;
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EY = 135f;
			base._fO7gSlrDDNMoHR4FO5QXAq8fUyA = 1f;
			break;
		case NPCLocation.Left:
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_Pv8G2bIbjHmJYrVXhNyr64NSPXn = true;
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EX = 100f;
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EY = 135f;
			base._fO7gSlrDDNMoHR4FO5QXAq8fUyA = 1f;
			break;
		case NPCLocation.Right:
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_Pv8G2bIbjHmJYrVXhNyr64NSPXn = false;
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EX = 1368f;
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EY = 135f;
			base._fO7gSlrDDNMoHR4FO5QXAq8fUyA = 1f;
			break;
		}
	}
}
