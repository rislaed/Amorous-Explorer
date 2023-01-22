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

	public static string _RB8fRXeQvK5vs7JEA0XfVCEpg1i = "Alexis Pryde";

	public static Color _9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA = new Color(17, 178, 105);

	public SecurityGuardNPC(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0, "Assets/NPC/SecurityGuard", 1f)
	{
		_je8rVfyg4zywmqSi4Ozx1z7wJ4b = 452;
		_WJfGWBzn4wgdGBnMWRH2pcJ3AqH = 945;
		_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Neutral, "Alexis Nude", "Alexis Tufts");
		SecurityGuardNPC.smethod_17(SecurityGuardNPC.smethod_16(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Neutral, EClothes.Shirt, "Alexis Shirt")));
		SecurityGuardNPC.smethod_19(SecurityGuardNPC.smethod_18(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Neutral, EClothes.Pants, "Alexis Pants")));
		_J4giDjnRtYmiHMmzwRZ0ThvfAhH = true;
		_upl1k7yzBzlU7vErvbydGmXROfA = true;
	}

	protected override string[] _zBK8PXhWw9GtXK9IHkvbuvhbigE()
	{
		return new string[4] { "Alexis Nude", "Alexis Tufts", "Alexis Pants", "Alexis Shirt" };
	}

	public override void _nGGBtYpZ8pI1BmE2c2ke63UjGDP(NPCLocation npclocation_0)
	{
		this.method_0(npclocation_0);
		switch (npclocation_0)
		{
		case NPCLocation.Middle:
			SecurityGuardNPC.smethod_20((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: false);
			SecurityGuardNPC.smethod_21((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 734f);
			SecurityGuardNPC.smethod_22((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 135f);
			SecurityGuardNPC.smethod_23((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1f);
			break;
		case NPCLocation.Left:
			SecurityGuardNPC.smethod_20((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: true);
			SecurityGuardNPC.smethod_21((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 100f);
			SecurityGuardNPC.smethod_22((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 135f);
			SecurityGuardNPC.smethod_23((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1f);
			break;
		case NPCLocation.Right:
			SecurityGuardNPC.smethod_20((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: false);
			SecurityGuardNPC.smethod_21((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1368f);
			SecurityGuardNPC.smethod_22((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 135f);
			SecurityGuardNPC.smethod_23((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1f);
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

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_18(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._dUWotuFGWMaIlD1IFkXcXUhjchR();
	}

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_19(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._mgkfAuKt1tsSRmn1YmxkzbHikc();
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

	static void smethod_23(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, float float_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._fO7gSlrDDNMoHR4FO5QXAq8fUyA = float_0;
	}
}
