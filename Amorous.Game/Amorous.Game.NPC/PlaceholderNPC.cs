using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class PlaceholderNPC : LayerNPC<PlaceholderNPC.EHeads, PlaceholderNPC.EPoses, PlaceholderNPC.EClothes>
{
	public enum EHeads
	{
		None
	}

	public enum EPoses
	{
		None,
		Placeholder
	}

	public enum EClothes
	{
		None
	}

	public static string Name = "Placeholder";

	public static Color Color = new Color(255, 0, 255);

	public PlaceholderNPC(IAmorous game)
		: base(Game, "Assets/NPC/Placeholder", 1f)
	{
		_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Placeholder, "Placeholder");
	}

	public override void _nGGBtYpZ8pI1BmE2c2ke63UjGDP(NPCLocation npclocation_0)
	{
		base._nGGBtYpZ8pI1BmE2c2ke63UjGDP(npclocation_0);
		switch (npclocation_0)
		{
		case NPCLocation.Middle:
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_Pv8G2bIbjHmJYrVXhNyr64NSPXn = false;
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EX = 685f;
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EY = 100f;
			break;
		case NPCLocation.Left:
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_Pv8G2bIbjHmJYrVXhNyr64NSPXn = true;
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EX = 100f;
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EY = 100f;
			break;
		case NPCLocation.Right:
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_Pv8G2bIbjHmJYrVXhNyr64NSPXn = false;
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EX = 1270f;
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EY = 100f;
			break;
		}
	}
}
