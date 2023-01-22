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

	public static string _RB8fRXeQvK5vs7JEA0XfVCEpg1i = "Placeholder";

	public static Color _9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA = new Color(255, 0, 255);

	public PlaceholderNPC(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0, "Assets/NPC/Placeholder", 1f)
	{
		_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Placeholder, "Placeholder");
	}

	public override void _nGGBtYpZ8pI1BmE2c2ke63UjGDP(NPCLocation npclocation_0)
	{
		this.method_0(npclocation_0);
		switch (npclocation_0)
		{
		case NPCLocation.Middle:
			PlaceholderNPC.smethod_16((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: false);
			PlaceholderNPC.smethod_17((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 685f);
			PlaceholderNPC.smethod_18((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 100f);
			break;
		case NPCLocation.Left:
			PlaceholderNPC.smethod_16((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: true);
			PlaceholderNPC.smethod_17((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 100f);
			PlaceholderNPC.smethod_18((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 100f);
			break;
		case NPCLocation.Right:
			PlaceholderNPC.smethod_16((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: false);
			PlaceholderNPC.smethod_17((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1270f);
			PlaceholderNPC.smethod_18((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 100f);
			break;
		}
	}

	void method_0(NPCLocation npclocation_0)
	{
		base._nGGBtYpZ8pI1BmE2c2ke63UjGDP(npclocation_0);
	}

	static void smethod_16(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, bool bool_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_Pv8G2bIbjHmJYrVXhNyr64NSPXn = bool_0;
	}

	static void smethod_17(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, float float_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_7Xn1C5tjYnmIif1iZKV8AWsEEbL = float_0;
	}

	static void smethod_18(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, float float_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_bCjZ3VSXGKyhmykd2zCnQBiSpDf = float_0;
	}
}
