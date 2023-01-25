using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class AuthorNPC : LayerNPC<AuthorNPC.EHeads, AuthorNPC.EPoses, AuthorNPC.EClothes>
{
	public enum EHeads
	{
		None
	}

	public enum EPoses
	{
		None,
		Reading
	}

	public enum EClothes
	{
		None,
		Shirt,
		Pants
	}

	public static string Name = "Nik Kovak";

	public static Color Color = new Color(145, 109, 236);

	public AuthorNPC(IAmorous game)
		: base(Game, "Assets/NPC/Author", 1f)
	{
		_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Reading, "Sonic Fox Expressions");
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Reading, EClothes.Pants, "Sonic Fox Expressions - Pants")._dUWotuFGWMaIlD1IFkXcXUhjchR()._mgkfAuKt1tsSRmn1YmxkzbHikc();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Reading, EClothes.Shirt, "Sonic Fox Expressions - Shirt")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._9mDS3yizOswyCzK6V3LBhafV7Dh();
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
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EX = 618f;
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EY = 30f;
			break;
		case NPCLocation.Left:
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_Pv8G2bIbjHmJYrVXhNyr64NSPXn = true;
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EX = 60f;
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EY = 30f;
			break;
		case NPCLocation.Right:
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_Pv8G2bIbjHmJYrVXhNyr64NSPXn = false;
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EX = 1206f;
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EY = 30f;
			break;
		}
	}
}
