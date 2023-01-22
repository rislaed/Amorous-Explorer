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

	public static string _RB8fRXeQvK5vs7JEA0XfVCEpg1i = _003CModule_003E.smethod_26<string>(972901111u);

	public static Color _9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA = new Color(186, 78, 60);

	public CosplayerHaneNPC(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0, _003CModule_003E.smethod_25<string>(524301005u), 1f)
	{
		while (true)
		{
			int num = 1824451260;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x181CAE61u) % 4u)
				{
				case 3u:
					CosplayerHaneNPC.smethod_17(CosplayerHaneNPC.smethod_16(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Standing, EClothes.Jacket, _003CModule_003E.smethod_25<string>(1598687453u))));
					num = ((int)num2 * -1492571897) ^ -1485282322;
					continue;
				case 1u:
					_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Standing, _003CModule_003E.smethod_27<string>(522418932u));
					num = ((int)num2 * -1833023278) ^ 0x75F5DE98;
					continue;
				case 0u:
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
			int num = -967955065;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9AE2D7B3u) % 10u)
				{
				case 8u:
					CosplayerHaneNPC.smethod_20((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 0f);
					num = ((int)num2 * -53173923) ^ -2053405584;
					continue;
				case 7u:
					CosplayerHaneNPC.smethod_18((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: true);
					num = -1865969555;
					continue;
				case 6u:
					switch (npclocation_0)
					{
					case NPCLocation.Left:
						break;
					default:
						goto IL_0048;
					case NPCLocation.Middle:
						goto IL_0057;
					case NPCLocation.Right:
						goto IL_0070;
					}
					goto case 7u;
				case 4u:
					goto IL_0057;
				case 2u:
					goto IL_0070;
				default:
					return;
				case 3u:
					break;
				case 0u:
					CosplayerHaneNPC.smethod_19((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, -190f);
					CosplayerHaneNPC.smethod_20((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 0f);
					return;
				case 1u:
					return;
				case 5u:
					CosplayerHaneNPC.smethod_20((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 0f);
					return;
				case 9u:
					return;
					IL_0070:
					CosplayerHaneNPC.smethod_18((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: false);
					CosplayerHaneNPC.smethod_19((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1016f);
					num = -1150278386;
					continue;
					IL_0057:
					CosplayerHaneNPC.smethod_18((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: false);
					CosplayerHaneNPC.smethod_19((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 413f);
					num = -112486439;
					continue;
					IL_0048:
					num = ((int)num2 * -573995251) ^ -1075080474;
					continue;
				}
				break;
			}
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
