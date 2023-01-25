using System;
using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class SkyeNPC : SpineNPC<SkyeNPC.EHeads, SkyeNPC.EPoses, SkyeNPC.EClothes>
{
	public enum EHeads
	{
		None,
		Angry,
		Blush,
		Sad,
		Happy,
		Neutral
	}

	public enum EPoses
	{
		None,
		Suggestive,
		Guarded
	}

	public enum EClothes
	{
		None,
		Hoodie,
		Shirt,
		Shorts
	}

	public static string Name = "Skye";

	public static Color Color = new Color(248, 255, 167);

	public SkyeNPC(IAmorous game)
		: base(Game, "Assets/NPC/Skye/Skye", 1f, bool_0: true)
	{
		base._rAt6TRbgK04lvrs5QPjcd0n26pk = new Type[2]
		{
			typeof(SkyeBlueNPC),
			typeof(SkyeGrayNPC)
		};
		base._1BgOJ3z4ZUXNS2L4JWf24pr41hB._C5vPbZ72rpVMDWGuHxZuR5FNpAH("Idle");
		_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Angry, "Angry Head", "Angry pupil", "Angry eyeback");
		_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Blush, "Blush head", "Blush pupils", "Blush eye back");
		_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Sad, "Sad Head", "Sad pupil", "Sad eye back");
		_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Happy, "Happy head", "Happy pupil", "Happy eye back", "Happy jaw")._qL2MEiFtBpbdxqUUTSqOgOsEK4j("Happy blink");
		_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Neutral, "Neutral head", "Neutral pupil", "Neutral eye back", "Neutral jaw")._qL2MEiFtBpbdxqUUTSqOgOsEK4j("Neutral blink");
		_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Suggestive, "Suggestive Body", "Suggestive boobs", "Suggestive Tail");
		_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Guarded, "Guarded body", "Guarded boobs", "Guarded boob cover", "Guarded tail");
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Suggestive, EClothes.Hoodie, "Suggestive hoodie")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._KCZzL8xtjbw97bTOV0k8JDz3olE()._9mDS3yizOswyCzK6V3LBhafV7Dh();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Suggestive, EClothes.Shirt, "Suggestive shirt")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._9mDS3yizOswyCzK6V3LBhafV7Dh();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Suggestive, EClothes.Shorts, "Suggestive shorts")._dUWotuFGWMaIlD1IFkXcXUhjchR()._B19pyNfKCkJxZB1oCC3WzfkqEQF()._mgkfAuKt1tsSRmn1YmxkzbHikc();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Guarded, EClothes.Hoodie, "Guarded hoodie")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._KCZzL8xtjbw97bTOV0k8JDz3olE()._9mDS3yizOswyCzK6V3LBhafV7Dh();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Guarded, EClothes.Shirt, "Guarded shirt")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._9mDS3yizOswyCzK6V3LBhafV7Dh();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Guarded, EClothes.Shorts, "Guarded shorts")._dUWotuFGWMaIlD1IFkXcXUhjchR()._B19pyNfKCkJxZB1oCC3WzfkqEQF()._mgkfAuKt1tsSRmn1YmxkzbHikc();
		_J4giDjnRtYmiHMmzwRZ0ThvfAhH = true;
		_upl1k7yzBzlU7vErvbydGmXROfA = true;
	}

	public override void _nGGBtYpZ8pI1BmE2c2ke63UjGDP(NPCLocation npclocation_0)
	{
		base._nGGBtYpZ8pI1BmE2c2ke63UjGDP(npclocation_0);
		switch (npclocation_0)
		{
		default:
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_Pv8G2bIbjHmJYrVXhNyr64NSPXn = false;
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EX = 960f;
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EY = 1120f;
			break;
		case NPCLocation.Right:
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_Pv8G2bIbjHmJYrVXhNyr64NSPXn = true;
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EX = 1520f;
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EY = 1120f;
			break;
		case NPCLocation.Left:
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_Pv8G2bIbjHmJYrVXhNyr64NSPXn = false;
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EX = 400f;
			_QGGOTxZ8aNWGh0hc26wcmx8wmwT_002EY = 1120f;
			break;
		}
	}
}
