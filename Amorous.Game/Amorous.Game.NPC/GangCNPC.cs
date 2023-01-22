using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class GangCNPC : LayerNPC<GangCNPC.EHeads, GangCNPC.EPoses, GangCNPC.EClothes>
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

	public static string _RB8fRXeQvK5vs7JEA0XfVCEpg1i = "Jade";

	public static Color _9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA = new Color(98, 178, 17);

	public GangCNPC(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0, "Assets/NPC/GangC", 1f)
	{
		while (true)
		{
			int num = 958832479;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5BF67898u) % 5u)
				{
				case 3u:
					GangCNPC.smethod_19(GangCNPC.smethod_18(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Neutral, EClothes.Pants, "Jade Pants")));
					_J4giDjnRtYmiHMmzwRZ0ThvfAhH = false;
					num = (int)((num2 * 2021838610) ^ 0x4BBA3C63);
					continue;
				case 1u:
					_je8rVfyg4zywmqSi4Ozx1z7wJ4b = 610;
					_WJfGWBzn4wgdGBnMWRH2pcJ3AqH = 1002;
					_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Neutral, "Jade Nude");
					num = ((int)num2 * -1092515392) ^ 0x8A89E06;
					continue;
				case 0u:
					GangCNPC.smethod_17(GangCNPC.smethod_16(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Neutral, EClothes.Shirt, "Jade Shirt")));
					num = (int)(num2 * 2020062704) ^ -77358360;
					continue;
				case 4u:
					break;
				default:
					_upl1k7yzBzlU7vErvbydGmXROfA = true;
					return;
				}
				break;
			}
		}
	}

	protected override string[] _zBK8PXhWw9GtXK9IHkvbuvhbigE()
	{
		return new string[3] { "Jade Nude", "Jade Pants", "Jade Shirt" };
	}

	public override void _nGGBtYpZ8pI1BmE2c2ke63UjGDP(NPCLocation npclocation_0)
	{
		this.method_0(npclocation_0);
		while (true)
		{
			int num = -237571535;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8A200608u) % 11u)
				{
				case 10u:
					switch (npclocation_0)
					{
					case NPCLocation.Middle:
						goto IL_002f;
					case NPCLocation.Left:
						goto IL_0053;
					case NPCLocation.Right:
						goto IL_006c;
					}
					num = ((int)num2 * -461590727) ^ -1277369728;
					continue;
				case 4u:
					goto IL_002f;
				case 5u:
					goto IL_0053;
				case 3u:
					goto IL_006c;
				case 6u:
					GangCNPC.smethod_23((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1f);
					num = ((int)num2 * -1980022463) ^ 0x40EECD13;
					continue;
				case 2u:
					GangCNPC.smethod_22((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 78f);
					num = ((int)num2 * -1503807430) ^ -1347068431;
					continue;
				case 8u:
					break;
				case 0u:
					return;
				case 1u:
					GangCNPC.smethod_23((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1f);
					return;
				default:
					GangCNPC.smethod_21((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1210f);
					GangCNPC.smethod_22((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 78f);
					GangCNPC.smethod_23((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1f);
					return;
				case 9u:
					return;
					IL_006c:
					GangCNPC.smethod_20((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: false);
					num = -1334250876;
					continue;
					IL_0053:
					GangCNPC.smethod_20((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: true);
					GangCNPC.smethod_21((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 100f);
					num = -281584330;
					continue;
					IL_002f:
					GangCNPC.smethod_20((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: false);
					GangCNPC.smethod_21((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 655f);
					GangCNPC.smethod_22((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 78f);
					num = -457061502;
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
