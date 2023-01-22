using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class KaneNPC : LayerNPC<KaneNPC.EHeads, KaneNPC.EPoses, KaneNPC.EClothes>
{
	public enum EHeads
	{
		None,
		Angry
	}

	public enum EPoses
	{
		None,
		Stern
	}

	public enum EClothes
	{
		None,
		Shirt,
		Shorts
	}

	public static string _RB8fRXeQvK5vs7JEA0XfVCEpg1i = "Kane";

	public static Color _9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA = new Color(233, 193, 150);

	public KaneNPC(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0, "Assets/NPC/Kane", 1f)
	{
		_je8rVfyg4zywmqSi4Ozx1z7wJ4b = 1110;
		_WJfGWBzn4wgdGBnMWRH2pcJ3AqH = 1965;
		KaneNPC.smethod_16(_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Angry, "Plate", "Eyeback", "Pupil", "Head"), "Blink");
		KaneNPC.smethod_17(_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Stern, "Stern"), new string[1] { "Dick" });
		KaneNPC.smethod_19(KaneNPC.smethod_18(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Stern, EClothes.Shirt, "Stern Shirt")));
		KaneNPC.smethod_21(KaneNPC.smethod_20(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Stern, EClothes.Shorts, "Stern Shorts")));
		_J4giDjnRtYmiHMmzwRZ0ThvfAhH = false;
		_upl1k7yzBzlU7vErvbydGmXROfA = true;
	}

	protected override string[] _zBK8PXhWw9GtXK9IHkvbuvhbigE()
	{
		return new string[8] { "Plate", "Stern", "Stern Shirt", "Stern Shorts", "Eyeback", "Pupil", "Blink", "Head" };
	}

	public override void _nGGBtYpZ8pI1BmE2c2ke63UjGDP(NPCLocation npclocation_0)
	{
		this.method_0(npclocation_0);
		switch (npclocation_0)
		{
		case NPCLocation.Middle:
			KaneNPC.smethod_22((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: false);
			KaneNPC.smethod_23((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 305f);
			KaneNPC.smethod_24((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 0f);
			KaneNPC.smethod_25((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1f);
			break;
		case NPCLocation.Left:
			KaneNPC.smethod_22((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: false);
			KaneNPC.smethod_23((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, -260f);
			KaneNPC.smethod_24((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 0f);
			KaneNPC.smethod_25((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1f);
			break;
		case NPCLocation.Right:
			KaneNPC.smethod_22((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: true);
			KaneNPC.smethod_23((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1070f);
			KaneNPC.smethod_24((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 0f);
			KaneNPC.smethod_25((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1f);
			break;
		}
	}

	static _xmfdPa5IagU3cXbLL61gyoXAV7gA smethod_16(_xmfdPa5IagU3cXbLL61gyoXAV7gA _xmfdPa5IagU3cXbLL61gyoXAV7gA_0, string string_0)
	{
		return _xmfdPa5IagU3cXbLL61gyoXAV7gA_0._qL2MEiFtBpbdxqUUTSqOgOsEK4j(string_0);
	}

	static _NaKchYC4I4GjWR34SfBLAktysCE smethod_17(_NaKchYC4I4GjWR34SfBLAktysCE _NaKchYC4I4GjWR34SfBLAktysCE_0, string[] string_0)
	{
		return _NaKchYC4I4GjWR34SfBLAktysCE_0._6NcgB9eEKq8eKu8SgNWnKbLsDhB(string_0);
	}

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_18(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._XJUU6QdUDN3lYoRweLWOMaWqcUE();
	}

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_19(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._9mDS3yizOswyCzK6V3LBhafV7Dh();
	}

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_20(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._dUWotuFGWMaIlD1IFkXcXUhjchR();
	}

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_21(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._mgkfAuKt1tsSRmn1YmxkzbHikc();
	}

	void method_0(NPCLocation npclocation_0)
	{
		base._nGGBtYpZ8pI1BmE2c2ke63UjGDP(npclocation_0);
	}

	static void smethod_22(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, bool bool_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_Pv8G2bIbjHmJYrVXhNyr64NSPXn = bool_0;
	}

	static void smethod_23(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, float float_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_7Xn1C5tjYnmIif1iZKV8AWsEEbL = float_0;
	}

	static void smethod_24(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, float float_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_bCjZ3VSXGKyhmykd2zCnQBiSpDf = float_0;
	}

	static void smethod_25(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, float float_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._fO7gSlrDDNMoHR4FO5QXAq8fUyA = float_0;
	}
}
