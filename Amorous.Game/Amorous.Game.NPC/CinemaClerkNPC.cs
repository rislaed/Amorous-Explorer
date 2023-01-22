using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class CinemaClerkNPC : LayerNPC<CinemaClerkNPC.EHeads, CinemaClerkNPC.EPoses, CinemaClerkNPC.EClothes>
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
		Vest,
		Pants
	}

	public static string _RB8fRXeQvK5vs7JEA0XfVCEpg1i = "Cryptic";

	public static Color _9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA = new Color(255, 24, 24);

	public CinemaClerkNPC(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0, "Assets/NPC/CinemaClerk", 1f)
	{
		while (true)
		{
			int num = 647889484;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2F6FA015u) % 4u)
				{
				case 1u:
					_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Standing, "Cinema Clerk Expressions");
					num = ((int)num2 * -372596738) ^ 0x77CAC82F;
					continue;
				case 0u:
					CinemaClerkNPC.smethod_17(CinemaClerkNPC.smethod_16(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Standing, EClothes.Pants, "Cinema Clerk Expressions - Pants")));
					CinemaClerkNPC.smethod_19(CinemaClerkNPC.smethod_18(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Standing, EClothes.Vest, "Cinema Clerk Expressions - Vest")));
					num = ((int)num2 * -1190724031) ^ -681494229;
					continue;
				case 3u:
					break;
				default:
					_J4giDjnRtYmiHMmzwRZ0ThvfAhH = false;
					_upl1k7yzBzlU7vErvbydGmXROfA = true;
					return;
				}
				break;
			}
		}
	}

	public override void _nGGBtYpZ8pI1BmE2c2ke63UjGDP(NPCLocation npclocation_0)
	{
		this.method_0(npclocation_0);
		while (true)
		{
			int num = -893358528;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBE4303D4u) % 14u)
				{
				case 13u:
					CinemaClerkNPC.smethod_20((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: false);
					num = -493091790;
					continue;
				case 12u:
					CinemaClerkNPC.smethod_21((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1016f);
					num = ((int)num2 * -1615970529) ^ -1530955717;
					continue;
				case 10u:
					switch (npclocation_0)
					{
					case NPCLocation.Right:
						break;
					default:
						goto IL_004e;
					case NPCLocation.Middle:
						goto IL_0060;
					case NPCLocation.Left:
						goto IL_006e;
					}
					goto case 13u;
				case 3u:
					goto IL_0060;
				case 8u:
					goto IL_006e;
				case 9u:
					CinemaClerkNPC.smethod_21((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 413f);
					num = (int)((num2 * 454908848) ^ 0x4D17A54A);
					continue;
				case 7u:
					CinemaClerkNPC.smethod_21((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, -190f);
					num = (int)((num2 * 1295760633) ^ 0x1AB9ACDB);
					continue;
				case 4u:
					CinemaClerkNPC.smethod_22((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 22f);
					num = (int)(num2 * 798160989) ^ -1558032573;
					continue;
				case 1u:
					CinemaClerkNPC.smethod_22((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 22f);
					num = (int)(num2 * 794213428) ^ -641349332;
					continue;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				case 5u:
					return;
				case 6u:
					CinemaClerkNPC.smethod_22((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 22f);
					return;
				case 11u:
					return;
					IL_006e:
					CinemaClerkNPC.smethod_20((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: true);
					num = -590228645;
					continue;
					IL_0060:
					CinemaClerkNPC.smethod_20((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: false);
					num = -1934081387;
					continue;
					IL_004e:
					num = (int)(num2 * 1766739907) ^ -1612962555;
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
