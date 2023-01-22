using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class CosplayerHaneNPC : LayerNPC<CosplayerHaneNPC.EHeads, CosplayerHaneNPC.EPoses, CosplayerHaneNPC.EClothes>
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
		Jacket
	}

	public static string _RB8fRXeQvK5vs7JEA0XfVCEpg1i = "Hane Maxwell";

	public static Color _9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA = new Color(186, 78, 60);

	public CosplayerHaneNPC(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0, "Assets/NPC/CosplayerHane", 1f)
	{
		_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Standing, "Hane Maxwell Cosplayer (nude)");
		CosplayerHaneNPC.smethod_17(CosplayerHaneNPC.smethod_16(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Standing, EClothes.Jacket, "Hane Maxwell Cosplayer (clothed)")));
		_J4giDjnRtYmiHMmzwRZ0ThvfAhH = false;
		_upl1k7yzBzlU7vErvbydGmXROfA = true;
	}

	public override void _nGGBtYpZ8pI1BmE2c2ke63UjGDP(NPCLocation npclocation_0)
	{
		this.method_0(npclocation_0);
		switch (npclocation_0)
		{
		case NPCLocation.Middle:
			CosplayerHaneNPC.smethod_18((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: false);
			CosplayerHaneNPC.smethod_19((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 413f);
			CosplayerHaneNPC.smethod_20((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 0f);
			break;
		case NPCLocation.Left:
			CosplayerHaneNPC.smethod_18((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: true);
			CosplayerHaneNPC.smethod_19((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, -190f);
			CosplayerHaneNPC.smethod_20((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 0f);
			break;
		case NPCLocation.Right:
			CosplayerHaneNPC.smethod_18((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: false);
			CosplayerHaneNPC.smethod_19((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1016f);
			CosplayerHaneNPC.smethod_20((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 0f);
			break;
		}
	}

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_16(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._XJUU6QdUDN3lYoRweLWOMaWqcUE();
	}

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_17(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._9mDS3yizOswyCzK6V3LBhafV7Dh();
	}

	void method_0(NPCLocation npclocation_0)
	{
		base._nGGBtYpZ8pI1BmE2c2ke63UjGDP(npclocation_0);
	}

	static void smethod_18(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, bool bool_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_Pv8G2bIbjHmJYrVXhNyr64NSPXn = bool_0;
	}

	static void smethod_19(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, float float_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_7Xn1C5tjYnmIif1iZKV8AWsEEbL = float_0;
	}

	static void smethod_20(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, float float_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_bCjZ3VSXGKyhmykd2zCnQBiSpDf = float_0;
	}
}
