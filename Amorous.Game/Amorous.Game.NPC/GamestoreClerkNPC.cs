using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class GamestoreClerkNPC : LayerNPC<GamestoreClerkNPC.EHeads, GamestoreClerkNPC.EPoses, GamestoreClerkNPC.EClothes>
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

	public static string _RB8fRXeQvK5vs7JEA0XfVCEpg1i = "Game Store Clerk";

	public static Color _9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA = new Color(252, 137, 76);

	public GamestoreClerkNPC(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0, "Assets/NPC/GamestoreClerk", 1f)
	{
		_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Standing, "Kula Game Store Clerk (nude)");
		GamestoreClerkNPC.smethod_17(GamestoreClerkNPC.smethod_16(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Standing, EClothes.Pants, "Kula Game Store Clerk (pants)")));
		GamestoreClerkNPC.smethod_19(GamestoreClerkNPC.smethod_18(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Standing, EClothes.Shirt, "Kula Game Store Clerk (shirt)")));
		_J4giDjnRtYmiHMmzwRZ0ThvfAhH = false;
		_upl1k7yzBzlU7vErvbydGmXROfA = true;
	}

	public override void _nGGBtYpZ8pI1BmE2c2ke63UjGDP(NPCLocation npclocation_0)
	{
		this.method_0(npclocation_0);
		switch (npclocation_0)
		{
		case NPCLocation.Middle:
			GamestoreClerkNPC.smethod_20((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: false);
			GamestoreClerkNPC.smethod_21((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 545f);
			GamestoreClerkNPC.smethod_22((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 0f);
			break;
		case NPCLocation.Left:
			GamestoreClerkNPC.smethod_20((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: true);
			GamestoreClerkNPC.smethod_21((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, -80f);
			GamestoreClerkNPC.smethod_22((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 0f);
			break;
		case NPCLocation.Right:
			GamestoreClerkNPC.smethod_20((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: false);
			GamestoreClerkNPC.smethod_21((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1166f);
			GamestoreClerkNPC.smethod_22((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 0f);
			break;
		}
	}

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_16(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._dUWotuFGWMaIlD1IFkXcXUhjchR();
	}

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_17(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._mgkfAuKt1tsSRmn1YmxkzbHikc();
	}

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_18(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._XJUU6QdUDN3lYoRweLWOMaWqcUE();
	}

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_19(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._9mDS3yizOswyCzK6V3LBhafV7Dh();
	}

	void method_0(NPCLocation npclocation_0)
	{
		base._nGGBtYpZ8pI1BmE2c2ke63UjGDP(npclocation_0);
	}

	static void smethod_20(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, bool bool_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_Pv8G2bIbjHmJYrVXhNyr64NSPXn = bool_0;
	}

	static void smethod_21(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, float float_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_7Xn1C5tjYnmIif1iZKV8AWsEEbL = float_0;
	}

	static void smethod_22(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, float float_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_bCjZ3VSXGKyhmykd2zCnQBiSpDf = float_0;
	}
}
