using System;
using System.Linq;
using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class MercyNPC : SpineNPC<MercyNPC.EHeads, MercyNPC.EPoses, MercyNPC.EClothes>
{
	public enum EHeads
	{
		None,
		Angry,
		Happy,
		Sad,
		BlushConfident,
		BlushShy
	}

	public enum EPoses
	{
		None,
		Standing,
		ArmsShy
	}

	public enum EClothes
	{
		None,
		Dress,
		SkimpyDress,
		SportsBra,
		SportsShorts,
		Necklace
	}

	public static string Name = "Mercy";

	public static Color Color = new Color(172, 135, 255);

	public MercyNPC(IAmorous game)
		: base(Game, "Assets/NPC/Mercy/Mercy", 1f, bool_0: true)
	{
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._C5vPbZ72rpVMDWGuHxZuR5FNpAH("animation");
		string[] first = new string[7] { "Pupils", "Eyeback", "Hair back", "Hairlock left", "Fringe", "Horn", "Horn tip" };
		_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Angry, first.Union(new string[2] { "Angry head", "AngrySad ear" }).ToArray());
		_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Happy, first.Union(new string[3] { "Happy head", "Happy Jaw", "Happy ear" }).ToArray())._qL2MEiFtBpbdxqUUTSqOgOsEK4j("Happy blink");
		_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Sad, first.Union(new string[2] { "Sad head", "AngrySad ear" }).ToArray())._qL2MEiFtBpbdxqUUTSqOgOsEK4j("Sad Blink");
		_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.BlushConfident, first.Union(new string[2] { "Blush Confident Head", "AngrySad ear" }).ToArray());
		_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.BlushShy, first.Union(new string[2] { "Blush Shy Head", "AngrySad ear" }).ToArray())._qL2MEiFtBpbdxqUUTSqOgOsEK4j("Sad Blink");
		_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Standing, "Body one", "Arm left hip", "Arm right hip", "Tail");
		_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.ArmsShy, "Body one", "Arms shy", "Arms shy back", "Tail");
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Standing, EClothes.Dress, "Dress")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._dUWotuFGWMaIlD1IFkXcXUhjchR();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Standing, EClothes.SkimpyDress, "Skimpy Dress")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._dUWotuFGWMaIlD1IFkXcXUhjchR();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Standing, EClothes.SportsBra, "Sports Bra")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._KCZzL8xtjbw97bTOV0k8JDz3olE();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Standing, EClothes.SportsShorts, "Sports Shorts")._dUWotuFGWMaIlD1IFkXcXUhjchR()._B19pyNfKCkJxZB1oCC3WzfkqEQF();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Standing, EClothes.Necklace, "Necklace");
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.ArmsShy, EClothes.Dress, "Dress")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._dUWotuFGWMaIlD1IFkXcXUhjchR();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.ArmsShy, EClothes.SkimpyDress, "Skimpy Dress")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._dUWotuFGWMaIlD1IFkXcXUhjchR();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.ArmsShy, EClothes.SportsBra, "Sports Bra")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._KCZzL8xtjbw97bTOV0k8JDz3olE();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.ArmsShy, EClothes.SportsShorts, "Sports Shorts")._dUWotuFGWMaIlD1IFkXcXUhjchR()._B19pyNfKCkJxZB1oCC3WzfkqEQF();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.ArmsShy, EClothes.Necklace, "Necklace");
		_J4giDjnRtYmiHMmzwRZ0ThvfAhH = true;
		_upl1k7yzBzlU7vErvbydGmXROfA = true;
	}

	public override void _nGGBtYpZ8pI1BmE2c2ke63UjGDP(NPCLocation npclocation_0)
	{
		base._nGGBtYpZ8pI1BmE2c2ke63UjGDP(npclocation_0);
		switch (npclocation_0)
		{
		case NPCLocation.Middle:
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_Pv8G2bIbjHmJYrVXhNyr64NSPXn = false;
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EX = 960f;
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EY = 1090f;
			break;
		case NPCLocation.Left:
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_Pv8G2bIbjHmJYrVXhNyr64NSPXn = false;
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EX = 320f;
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EY = 1090f;
			break;
		case NPCLocation.Right:
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_Pv8G2bIbjHmJYrVXhNyr64NSPXn = true;
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EX = 1600f;
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EY = 1090f;
			break;
		}
	}
}
