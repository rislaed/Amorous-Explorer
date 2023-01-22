using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class LifeguardNPC : LayerNPC<LifeguardNPC.EHeads, LifeguardNPC.EPoses, LifeguardNPC.EClothes>
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

	public static string _RB8fRXeQvK5vs7JEA0XfVCEpg1i = _003CModule_003E.smethod_27<string>(4171764370u);

	public static Color _9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA = new Color(244, 146, 66);

	public LifeguardNPC(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0, _003CModule_003E.smethod_28<string>(68746444u), 1f)
	{
		while (true)
		{
			int num = 973118402;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1310CC70u) % 5u)
				{
				case 3u:
					_J4giDjnRtYmiHMmzwRZ0ThvfAhH = false;
					_upl1k7yzBzlU7vErvbydGmXROfA = true;
					num = ((int)num2 * -1399120277) ^ -1496239523;
					continue;
				case 2u:
					_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Standing, _003CModule_003E.smethod_27<string>(3452922109u));
					LifeguardNPC.smethod_17(LifeguardNPC.smethod_16(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Standing, EClothes.Pants, _003CModule_003E.smethod_25<string>(976079090u))));
					num = ((int)num2 * -980979245) ^ 0x51BA0089;
					continue;
				case 1u:
					LifeguardNPC.smethod_19(LifeguardNPC.smethod_18(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Standing, EClothes.Shirt, _003CModule_003E.smethod_26<string>(2521963848u))));
					num = (int)(num2 * 1891576724) ^ -1090276498;
					continue;
				default:
					return;
				case 0u:
					break;
				case 4u:
					return;
				}
				break;
			}
		}
	}

	public override void _nGGBtYpZ8pI1BmE2c2ke63UjGDP(NPCLocation npclocation_0)
	{
		this.method_0(npclocation_0);
		int num;
		switch (npclocation_0)
		{
		default:
			num = -1061270968;
			goto IL_0072;
		case NPCLocation.Middle:
			goto IL_003e;
		case NPCLocation.Left:
			goto IL_004c;
		case NPCLocation.Right:
			goto IL_00ac;
			IL_0072:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE9C5584Cu) % 10u)
				{
				case 9u:
					LifeguardNPC.smethod_21((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, -271f);
					num = ((int)num2 * -833666327) ^ 0xBFA9DA1;
					continue;
				case 5u:
					break;
				case 4u:
					goto IL_003e;
				case 2u:
					goto IL_004c;
				case 1u:
					LifeguardNPC.smethod_21((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 689f);
					num = ((int)num2 * -2087495138) ^ 0x15284B21;
					continue;
				case 0u:
					goto IL_00ac;
				default:
					LifeguardNPC.smethod_22((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 102f);
					return;
				case 6u:
					return;
				case 7u:
					LifeguardNPC.smethod_22((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 102f);
					return;
				case 8u:
					LifeguardNPC.smethod_22((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 102f);
					return;
				}
				break;
			}
			goto default;
			IL_00ac:
			LifeguardNPC.smethod_20((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: false);
			LifeguardNPC.smethod_21((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1320f);
			num = -70541059;
			goto IL_0072;
			IL_004c:
			LifeguardNPC.smethod_20((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: true);
			num = -875263205;
			goto IL_0072;
			IL_003e:
			LifeguardNPC.smethod_20((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: false);
			num = -2139807671;
			goto IL_0072;
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
