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
		while (true)
		{
			int num = -1627350306;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA96E7065u) % 7u)
				{
				case 6u:
					GamestoreClerkNPC.smethod_17(GamestoreClerkNPC.smethod_16(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Standing, EClothes.Pants, "Kula Game Store Clerk (pants)")));
					num = ((int)num2 * -179760713) ^ -1699956428;
					continue;
				case 4u:
					_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Standing, "Kula Game Store Clerk (nude)");
					num = ((int)num2 * -480122135) ^ 0x3E0A4E9B;
					continue;
				case 3u:
					_upl1k7yzBzlU7vErvbydGmXROfA = true;
					num = (int)(num2 * 1800072372) ^ -691165582;
					continue;
				case 2u:
					_J4giDjnRtYmiHMmzwRZ0ThvfAhH = false;
					num = ((int)num2 * -2091970529) ^ 0x6840B78C;
					continue;
				case 1u:
					GamestoreClerkNPC.smethod_19(GamestoreClerkNPC.smethod_18(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Standing, EClothes.Shirt, "Kula Game Store Clerk (shirt)")));
					num = (int)((num2 * 324612433) ^ 0x7AF2E52F);
					continue;
				default:
					return;
				case 0u:
					break;
				case 5u:
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
			int num = -1784568712;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBC2371A4u) % 12u)
				{
				case 11u:
					GamestoreClerkNPC.smethod_20((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: false);
					num = -495092468;
					continue;
				case 9u:
					GamestoreClerkNPC.smethod_22((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 0f);
					num = (int)(num2 * 1179328733) ^ -1151765162;
					continue;
				case 8u:
					GamestoreClerkNPC.smethod_21((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1166f);
					GamestoreClerkNPC.smethod_22((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 0f);
					num = (int)((num2 * 1108555439) ^ 0x56F4BB74);
					continue;
				case 7u:
					goto IL_005f;
				case 5u:
					goto IL_006d;
				case 4u:
					switch (npclocation_0)
					{
					case NPCLocation.Right:
						break;
					case NPCLocation.Left:
						goto IL_005f;
					case NPCLocation.Middle:
						goto IL_006d;
					default:
						goto IL_00a5;
					}
					goto case 11u;
				case 2u:
					GamestoreClerkNPC.smethod_21((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, -80f);
					num = ((int)num2 * -263350217) ^ -1793456449;
					continue;
				default:
					return;
				case 10u:
					break;
				case 0u:
					return;
				case 1u:
					return;
				case 3u:
					return;
				case 6u:
					return;
					IL_00a5:
					num = (int)(num2 * 1751040557) ^ -1734437306;
					continue;
					IL_006d:
					GamestoreClerkNPC.smethod_20((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: false);
					GamestoreClerkNPC.smethod_21((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 545f);
					GamestoreClerkNPC.smethod_22((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 0f);
					num = -917676979;
					continue;
					IL_005f:
					GamestoreClerkNPC.smethod_20((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: true);
					num = -928039562;
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
