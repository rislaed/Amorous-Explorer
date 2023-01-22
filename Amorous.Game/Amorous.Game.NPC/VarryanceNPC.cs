using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class VarryanceNPC : LayerNPC<VarryanceNPC.EHeads, VarryanceNPC.EPoses, VarryanceNPC.EClothes>
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
		Pants,
		Shirt
	}

	public static string _RB8fRXeQvK5vs7JEA0XfVCEpg1i = "Varryance";

	public static Color _9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA = new Color(162, 65, 159);

	public VarryanceNPC(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0, "Assets/NPC/Varryance", 1f)
	{
		while (true)
		{
			int num = -1797181613;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFD6C932Au) % 8u)
				{
				case 7u:
					_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Standing, "Varryance Body");
					num = ((int)num2 * -1499453910) ^ 0xD123FF9;
					continue;
				case 6u:
					_upl1k7yzBzlU7vErvbydGmXROfA = true;
					num = (int)((num2 * 545146963) ^ 0x2D970DF2);
					continue;
				case 5u:
					VarryanceNPC.smethod_17(VarryanceNPC.smethod_16(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Standing, EClothes.Shirt, "Varryance Shirt")));
					num = (int)((num2 * 2128211301) ^ 0x474269DB);
					continue;
				case 3u:
					_WJfGWBzn4wgdGBnMWRH2pcJ3AqH = 1649;
					num = ((int)num2 * -497855552) ^ -901334467;
					continue;
				case 1u:
					_je8rVfyg4zywmqSi4Ozx1z7wJ4b = 850;
					num = (int)(num2 * 1126153955) ^ -1846952774;
					continue;
				case 0u:
					VarryanceNPC.smethod_17(VarryanceNPC.smethod_18(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Standing, EClothes.Pants, "Varryance Pants")));
					_J4giDjnRtYmiHMmzwRZ0ThvfAhH = false;
					num = ((int)num2 * -1203273739) ^ 0x130FADC;
					continue;
				default:
					return;
				case 4u:
					break;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	protected override string[] _zBK8PXhWw9GtXK9IHkvbuvhbigE()
	{
		return new string[3] { "Varryance Body", "Varryance Shirt", "Varryance Pants" };
	}

	public override void _nGGBtYpZ8pI1BmE2c2ke63UjGDP(NPCLocation npclocation_0)
	{
		this.method_0(npclocation_0);
		int num;
		switch (npclocation_0)
		{
		case NPCLocation.Left:
			VarryanceNPC.smethod_19((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: true);
			VarryanceNPC.smethod_20((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, -300f);
			num = 781010604;
			goto IL_00e3;
		case NPCLocation.Middle:
			goto IL_007b;
		default:
			goto IL_0094;
		case NPCLocation.Right:
			goto IL_0125;
			IL_00e3:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x29ACA4A8u) % 12u)
				{
				case 9u:
					VarryanceNPC.smethod_22((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1f);
					num = ((int)num2 * -422567317) ^ -2099650117;
					continue;
				case 7u:
					break;
				case 6u:
					VarryanceNPC.smethod_21((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 0f);
					VarryanceNPC.smethod_22((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1f);
					num = ((int)num2 * -1975189466) ^ -37050603;
					continue;
				case 4u:
					goto IL_007b;
				case 3u:
					goto IL_0094;
				case 2u:
					VarryanceNPC.smethod_20((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1370f);
					VarryanceNPC.smethod_21((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 0f);
					num = (int)(num2 * 1795485830) ^ -1200918283;
					continue;
				case 0u:
					VarryanceNPC.smethod_21((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 0f);
					VarryanceNPC.smethod_22((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1f);
					num = ((int)num2 * -1880553026) ^ 0x6EB3E99B;
					continue;
				default:
					return;
				case 5u:
					goto IL_0125;
				case 1u:
					return;
				case 8u:
					return;
				case 10u:
					return;
				case 11u:
					return;
				}
				break;
			}
			goto case NPCLocation.Left;
			IL_0125:
			VarryanceNPC.smethod_19((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: false);
			num = 1489795186;
			goto IL_00e3;
			IL_0094:
			num = 423362786;
			goto IL_00e3;
			IL_007b:
			VarryanceNPC.smethod_19((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: false);
			VarryanceNPC.smethod_20((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 735f);
			num = 1793759830;
			goto IL_00e3;
		}
	}

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_16(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._XJUU6QdUDN3lYoRweLWOMaWqcUE();
	}

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_17(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._mgkfAuKt1tsSRmn1YmxkzbHikc();
	}

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_18(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._dUWotuFGWMaIlD1IFkXcXUhjchR();
	}

	void method_0(NPCLocation npclocation_0)
	{
		base._nGGBtYpZ8pI1BmE2c2ke63UjGDP(npclocation_0);
	}

	static void smethod_19(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, bool bool_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_Pv8G2bIbjHmJYrVXhNyr64NSPXn = bool_0;
	}

	static void smethod_20(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, float float_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_7Xn1C5tjYnmIif1iZKV8AWsEEbL = float_0;
	}

	static void smethod_21(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, float float_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_bCjZ3VSXGKyhmykd2zCnQBiSpDf = float_0;
	}

	static void smethod_22(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, float float_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._fO7gSlrDDNMoHR4FO5QXAq8fUyA = float_0;
	}
}
