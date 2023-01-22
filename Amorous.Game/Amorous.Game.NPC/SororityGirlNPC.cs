using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class SororityGirlNPC : LayerNPC<SororityGirlNPC.EHeads, SororityGirlNPC.EPoses, SororityGirlNPC.EClothes>
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

	public static string _RB8fRXeQvK5vs7JEA0XfVCEpg1i = "Lunar";

	public static Color _9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA = new Color(221, 110, 218);

	public SororityGirlNPC(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0, "Assets/NPC/SororityGirl", 1f)
	{
		_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Standing, "Sorority Girl Body");
		SororityGirlNPC.smethod_17(SororityGirlNPC.smethod_16(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Standing, EClothes.Pants, "Sorority Girl Pants")));
		SororityGirlNPC.smethod_19(SororityGirlNPC.smethod_18(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Standing, EClothes.Shirt, "Sorority Girl Top")));
		_J4giDjnRtYmiHMmzwRZ0ThvfAhH = true;
		_upl1k7yzBzlU7vErvbydGmXROfA = true;
	}

	public override void _nGGBtYpZ8pI1BmE2c2ke63UjGDP(NPCLocation npclocation_0)
	{
		this.method_0(npclocation_0);
		while (true)
		{
			int num = -1711865782;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x92CED239u) % 11u)
				{
				case 9u:
					SororityGirlNPC.smethod_20((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: false);
					num = -396770710;
					continue;
				case 8u:
					SororityGirlNPC.smethod_21((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, -60f);
					num = (int)(num2 * 1370335207) ^ -1128080050;
					continue;
				case 5u:
					goto IL_0034;
				case 4u:
					switch (npclocation_0)
					{
					case NPCLocation.Middle:
						break;
					case NPCLocation.Left:
						goto IL_0034;
					default:
						goto IL_0056;
					case NPCLocation.Right:
						goto IL_0065;
					}
					goto case 9u;
				case 1u:
					goto IL_0065;
				case 0u:
					SororityGirlNPC.smethod_21((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1390f);
					SororityGirlNPC.smethod_22((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 126f);
					num = ((int)num2 * -1781951580) ^ 0x7EFE1F2C;
					continue;
				case 2u:
					break;
				case 3u:
					SororityGirlNPC.smethod_22((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 126f);
					return;
				case 6u:
					return;
				case 7u:
					return;
				default:
					{
						SororityGirlNPC.smethod_21((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 665f);
						SororityGirlNPC.smethod_22((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 126f);
						return;
					}
					IL_0065:
					SororityGirlNPC.smethod_20((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: false);
					num = -1627526896;
					continue;
					IL_0056:
					num = ((int)num2 * -2049392748) ^ 0x5B7C8FF2;
					continue;
					IL_0034:
					SororityGirlNPC.smethod_20((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: true);
					num = -1036942942;
					continue;
				}
				break;
			}
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
