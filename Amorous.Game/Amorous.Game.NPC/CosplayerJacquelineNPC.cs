using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class CosplayerJacquelineNPC : LayerNPC<CosplayerJacquelineNPC.EHeads, CosplayerJacquelineNPC.EPoses, CosplayerJacquelineNPC.EClothes>
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

	public static string _RB8fRXeQvK5vs7JEA0XfVCEpg1i = "Jacqueline Knight";

	public static Color _9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA = new Color(138, 148, 170);

	public CosplayerJacquelineNPC(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0, "Assets/NPC/CosplayerJacqueline", 1f)
	{
		while (true)
		{
			int num = -1654908214;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC1F4156Du) % 6u)
				{
				case 5u:
					CosplayerJacquelineNPC.smethod_19(CosplayerJacquelineNPC.smethod_18(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Standing, EClothes.Pants, "Jacqueline Knight (pants)")));
					num = (int)(num2 * 963588473) ^ -466316024;
					continue;
				case 4u:
					_J4giDjnRtYmiHMmzwRZ0ThvfAhH = true;
					num = ((int)num2 * -111010245) ^ -2063968854;
					continue;
				case 1u:
					_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Standing, "Jacqueline Knight (nude)");
					num = (int)((num2 * 1962304096) ^ 0x570D2139);
					continue;
				case 0u:
					CosplayerJacquelineNPC.smethod_17(CosplayerJacquelineNPC.smethod_16(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Standing, EClothes.Shirt, "Jacqueline Knight (shirt)")));
					num = (int)((num2 * 2012805698) ^ 0x46FF36FC);
					continue;
				case 2u:
					break;
				default:
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
			int num = -759517203;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x89547DFEu) % 12u)
				{
				case 11u:
					CosplayerJacquelineNPC.smethod_21((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1166f);
					CosplayerJacquelineNPC.smethod_22((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 0f);
					num = ((int)num2 * -760445758) ^ 0x6AF28892;
					continue;
				case 10u:
					CosplayerJacquelineNPC.smethod_20((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: true);
					CosplayerJacquelineNPC.smethod_21((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, -200f);
					CosplayerJacquelineNPC.smethod_22((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 0f);
					num = -1619733455;
					continue;
				case 8u:
					goto IL_0058;
				case 5u:
					CosplayerJacquelineNPC.smethod_22((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 0f);
					num = (int)(num2 * 1014078933) ^ -2066328678;
					continue;
				case 4u:
					goto IL_0080;
				case 3u:
					switch (npclocation_0)
					{
					case NPCLocation.Left:
						break;
					case NPCLocation.Middle:
						goto IL_0058;
					case NPCLocation.Right:
						goto IL_0080;
					default:
						goto IL_00a2;
					}
					goto case 10u;
				case 0u:
					CosplayerJacquelineNPC.smethod_21((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 545f);
					num = ((int)num2 * -445682879) ^ 0x1995813F;
					continue;
				default:
					return;
				case 6u:
					break;
				case 1u:
					return;
				case 2u:
					return;
				case 7u:
					return;
				case 9u:
					return;
					IL_00a2:
					num = ((int)num2 * -632116220) ^ -1574973397;
					continue;
					IL_0080:
					CosplayerJacquelineNPC.smethod_20((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: false);
					num = -801720087;
					continue;
					IL_0058:
					CosplayerJacquelineNPC.smethod_20((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: false);
					num = -940339246;
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
}
