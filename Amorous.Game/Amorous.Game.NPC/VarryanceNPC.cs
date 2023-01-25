using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class VarryanceNPC : LayerNPC<VarryanceNPC.EHeads, VarryanceNPC.EPoses, VarryanceNPC.EClothes>
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
		Pants,
		Shirt
	}

	public static string Name = "Varryance";

	public static Color Color = new Color(162, 65, 159);

	public VarryanceNPC(IAmorous game)
		: base(Game, "Assets/NPC/Varryance", 1f)
	{
		Width = 850;
		Height = 1649;
		_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Standing, "Varryance Body");
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Standing, EClothes.Shirt, "Varryance Shirt")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._mgkfAuKt1tsSRmn1YmxkzbHikc();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Standing, EClothes.Pants, "Varryance Pants")._dUWotuFGWMaIlD1IFkXcXUhjchR()._mgkfAuKt1tsSRmn1YmxkzbHikc();
		_J4giDjnRtYmiHMmzwRZ0ThvfAhH = false;
		_upl1k7yzBzlU7vErvbydGmXROfA = true;
	}

	protected override string[] _zBK8PXhWw9GtXK9IHkvbuvhbigE()
	{
		return new string[3] { "Varryance Body", "Varryance Shirt", "Varryance Pants" };
	}

	public override void _nGGBtYpZ8pI1BmE2c2ke63UjGDP(NPCLocation npclocation_0)
	{
		base._nGGBtYpZ8pI1BmE2c2ke63UjGDP(npclocation_0);
		switch (npclocation_0)
		{
		case NPCLocation.Middle:
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_Pv8G2bIbjHmJYrVXhNyr64NSPXn = false;
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EX = 735f;
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EY = 0f;
			base._fO7gSlrDDNMoHR4FO5QXAq8fUyA = 1f;
			break;
		case NPCLocation.Left:
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_Pv8G2bIbjHmJYrVXhNyr64NSPXn = true;
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EX = -300f;
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EY = 0f;
			base._fO7gSlrDDNMoHR4FO5QXAq8fUyA = 1f;
			break;
		case NPCLocation.Right:
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_Pv8G2bIbjHmJYrVXhNyr64NSPXn = false;
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EX = 1370f;
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EY = 0f;
			base._fO7gSlrDDNMoHR4FO5QXAq8fUyA = 1f;
			break;
		}
	}
}
