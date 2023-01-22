using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class ExBoyfriendNPC : LayerNPC<ExBoyfriendNPC.EHeads, ExBoyfriendNPC.EPoses, ExBoyfriendNPC.EClothes>
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

	public static string _RB8fRXeQvK5vs7JEA0XfVCEpg1i = "Vareoth";

	public static Color _9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA = new Color(139, 215, 125);

	public ExBoyfriendNPC(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0, "Assets/NPC/ExBoyfriend", 1f)
	{
		_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Standing, "Dustin's Ex Boyfriend Expressions");
		ExBoyfriendNPC.smethod_17(ExBoyfriendNPC.smethod_16(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Standing, EClothes.Pants, "Dustin's Ex Boyfriend Expressions - Pants")));
		ExBoyfriendNPC.smethod_19(ExBoyfriendNPC.smethod_18(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Standing, EClothes.Shirt, "Dustin's Ex Boyfriend Expressions - Shirt")));
		_J4giDjnRtYmiHMmzwRZ0ThvfAhH = false;
		_upl1k7yzBzlU7vErvbydGmXROfA = true;
	}

	public override void _nGGBtYpZ8pI1BmE2c2ke63UjGDP(NPCLocation npclocation_0)
	{
		this.method_0(npclocation_0);
		while (true)
		{
			int num = -1531662088;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB010C456u) % 10u)
				{
				case 6u:
					ExBoyfriendNPC.smethod_20((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: true);
					num = -2116263868;
					continue;
				case 5u:
					ExBoyfriendNPC.smethod_22((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 177f);
					num = ((int)num2 * -1829611475) ^ -280216020;
					continue;
				case 4u:
					switch (npclocation_0)
					{
					case NPCLocation.Right:
						break;
					default:
						goto IL_0048;
					case NPCLocation.Middle:
						goto IL_0057;
					case NPCLocation.Left:
						goto IL_0065;
					}
					goto case 6u;
				case 3u:
					goto IL_0057;
				case 2u:
					goto IL_0065;
				case 7u:
					break;
				case 0u:
					ExBoyfriendNPC.smethod_21((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1412f);
					ExBoyfriendNPC.smethod_22((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 177f);
					return;
				case 1u:
					return;
				default:
					ExBoyfriendNPC.smethod_21((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 546f);
					ExBoyfriendNPC.smethod_22((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 177f);
					return;
				case 9u:
					return;
					IL_0065:
					ExBoyfriendNPC.smethod_20((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: false);
					ExBoyfriendNPC.smethod_21((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, -120f);
					num = -1797823047;
					continue;
					IL_0057:
					ExBoyfriendNPC.smethod_20((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: false);
					num = -1632586292;
					continue;
					IL_0048:
					num = (int)(num2 * 745334949) ^ -557613971;
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
