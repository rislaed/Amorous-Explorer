using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class GangANPC : LayerNPC<GangANPC.EHeads, GangANPC.EPoses, GangANPC.EClothes>
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

	public static string _RB8fRXeQvK5vs7JEA0XfVCEpg1i = "Kazee Fullford";

	public static Color _9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA;

	public GangANPC(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0, "Assets/NPC/GangA", 1f)
	{
		while (true)
		{
			int num = -2066497945;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9AC98E50u) % 6u)
				{
				case 5u:
					GangANPC.smethod_17(GangANPC.smethod_16(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Neutral, EClothes.Shirt, "Kazee and Taylor Shirts")));
					num = (int)(num2 * 1523062491) ^ -953210445;
					continue;
				case 3u:
					_je8rVfyg4zywmqSi4Ozx1z7wJ4b = 1182;
					num = (int)((num2 * 2024642270) ^ 0x7FFCDF8);
					continue;
				case 2u:
					_WJfGWBzn4wgdGBnMWRH2pcJ3AqH = 966;
					num = ((int)num2 * -1946377923) ^ -168495123;
					continue;
				case 1u:
					_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Neutral, "Kazee and Taylor Nude");
					num = (int)((num2 * 1318744022) ^ 0x2469DA85);
					continue;
				case 0u:
					break;
				default:
					GangANPC.smethod_19(GangANPC.smethod_18(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Neutral, EClothes.Pants, "Kazee and Taylor Pants")));
					_J4giDjnRtYmiHMmzwRZ0ThvfAhH = false;
					_upl1k7yzBzlU7vErvbydGmXROfA = true;
					return;
				}
				break;
			}
		}
	}

	protected override string[] _zBK8PXhWw9GtXK9IHkvbuvhbigE()
	{
		return new string[3] { "Kazee and Taylor Nude", "Kazee and Taylor Pants", "Kazee and Taylor Shirts" };
	}

	public override void _nGGBtYpZ8pI1BmE2c2ke63UjGDP(NPCLocation npclocation_0)
	{
		this.method_0(npclocation_0);
		int num;
		switch (npclocation_0)
		{
		case NPCLocation.Left:
			GangANPC.smethod_20((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: false);
			num = -1828860011;
			goto IL_0107;
		case NPCLocation.Middle:
			goto IL_00f4;
		default:
			goto IL_0102;
		case NPCLocation.Right:
			goto IL_0151;
			IL_0107:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x95DB8444u) % 14u)
				{
				case 13u:
					GangANPC.smethod_22((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 114f);
					num = (int)((num2 * 1586203172) ^ 0x7D49CFA6);
					continue;
				case 11u:
					GangANPC.smethod_21((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, -100f);
					GangANPC.smethod_22((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 114f);
					num = (int)(num2 * 1803981939) ^ -1504563760;
					continue;
				case 10u:
					GangANPC.smethod_21((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 838f);
					num = (int)(num2 * 2106433745) ^ -1804822757;
					continue;
				case 9u:
					GangANPC.smethod_23((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1f);
					num = ((int)num2 * -920395104) ^ 0x6C2B2A64;
					continue;
				case 6u:
					GangANPC.smethod_23((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1f);
					num = (int)((num2 * 394888936) ^ 0x6925C749);
					continue;
				case 5u:
					GangANPC.smethod_21((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 369f);
					GangANPC.smethod_22((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 114f);
					GangANPC.smethod_23((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1f);
					num = ((int)num2 * -1414374759) ^ 0x18AAAD7D;
					continue;
				case 4u:
					break;
				case 2u:
					goto IL_00f4;
				case 0u:
					goto IL_0102;
				default:
					return;
				case 1u:
					goto IL_0151;
				case 3u:
					return;
				case 7u:
					return;
				case 8u:
					return;
				case 12u:
					return;
				}
				break;
			}
			goto case NPCLocation.Left;
			IL_0151:
			GangANPC.smethod_20((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: true);
			num = -2037541612;
			goto IL_0107;
			IL_0102:
			num = -2000758567;
			goto IL_0107;
			IL_00f4:
			GangANPC.smethod_20((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: false);
			num = -771499171;
			goto IL_0107;
		}
	}

	static GangANPC()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			int num = -1488326209;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBC7EEB54u) % 3u)
				{
				case 1u:
					goto IL_000d;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_000d:
				_9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA = new Color(220, 0, 0);
				num = ((int)num2 * -54659354) ^ 0x7E7C3034;
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
