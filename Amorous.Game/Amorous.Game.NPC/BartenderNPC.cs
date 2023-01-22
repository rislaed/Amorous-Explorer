using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class BartenderNPC : LayerNPC<BartenderNPC.EHeads, BartenderNPC.EPoses, BartenderNPC.EClothes>
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

	public static string _RB8fRXeQvK5vs7JEA0XfVCEpg1i = "Rou";

	public static Color _9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA;

	public BartenderNPC(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0, "Assets/NPC/Bartender", 1f)
	{
		_je8rVfyg4zywmqSi4Ozx1z7wJ4b = 904;
		_WJfGWBzn4wgdGBnMWRH2pcJ3AqH = 1008;
		_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Standing, "Bovine Naked");
		BartenderNPC.smethod_17(BartenderNPC.smethod_16(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Standing, EClothes.Pants, "Bovine pants")));
		BartenderNPC.smethod_19(BartenderNPC.smethod_18(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Standing, EClothes.Shirt, "Bovine Top")));
		_J4giDjnRtYmiHMmzwRZ0ThvfAhH = false;
		_upl1k7yzBzlU7vErvbydGmXROfA = true;
	}

	public override void _nGGBtYpZ8pI1BmE2c2ke63UjGDP(NPCLocation npclocation_0)
	{
		this.method_0(npclocation_0);
		while (true)
		{
			int num = -287045776;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCCB0CEA9u) % 14u)
				{
				case 12u:
					BartenderNPC.smethod_20((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: true);
					num = -1682481269;
					continue;
				case 11u:
					BartenderNPC.smethod_22((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 72f);
					num = (int)(num2 * 645090159) ^ -582397185;
					continue;
				case 9u:
					BartenderNPC.smethod_21((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1176f);
					num = ((int)num2 * -322928342) ^ -1553289102;
					continue;
				case 8u:
					BartenderNPC.smethod_21((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, -160f);
					num = ((int)num2 * -587452038) ^ -767650157;
					continue;
				case 7u:
					goto IL_0071;
				case 6u:
					BartenderNPC.smethod_22((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 72f);
					num = (int)((num2 * 1153182421) ^ 0x6C1C031A);
					continue;
				case 5u:
					switch (npclocation_0)
					{
					case NPCLocation.Left:
						break;
					case NPCLocation.Middle:
						goto IL_0071;
					default:
						goto IL_00ad;
					case NPCLocation.Right:
						goto IL_00bc;
					}
					goto case 12u;
				case 0u:
					goto IL_00bc;
				case 4u:
					BartenderNPC.smethod_21((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 608f);
					BartenderNPC.smethod_22((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 72f);
					num = (int)((num2 * 348747794) ^ 0x6ECCB63F);
					continue;
				default:
					return;
				case 2u:
					break;
				case 1u:
					return;
				case 3u:
					return;
				case 10u:
					return;
				case 13u:
					return;
					IL_00bc:
					BartenderNPC.smethod_20((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: false);
					num = -804119546;
					continue;
					IL_00ad:
					num = ((int)num2 * -1980982771) ^ 0x52F9B9A1;
					continue;
					IL_0071:
					BartenderNPC.smethod_20((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: false);
					num = -587724833;
					continue;
				}
				break;
			}
		}
	}

	static BartenderNPC()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			int num = -251193026;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF340D69Bu) % 3u)
				{
				case 1u:
					goto IL_000d;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_000d:
				_9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA = new Color(116, 116, 116);
				num = (int)((num2 * 601172431) ^ 0x7423CF8E);
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
