using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class CobysDadNPC : LayerNPC<CobysDadNPC.EHeads, CobysDadNPC.EPoses, CobysDadNPC.EClothes>
{
	public enum EHeads
	{
		None,
		Stern
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

	public static string _RB8fRXeQvK5vs7JEA0XfVCEpg1i = "Coby's Dad";

	public static Color _9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA = new Color(176, 206, 255);

	public CobysDadNPC(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0, "Assets/NPC/CobysDad", 1f)
	{
		while (true)
		{
			int num = -689064816;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA2576508u) % 5u)
				{
				case 4u:
					_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Standing, "Coby's Dad Body");
					CobysDadNPC.smethod_17(CobysDadNPC.smethod_16(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Standing, EClothes.Pants, "Coby's Dad Pants")));
					CobysDadNPC.smethod_19(CobysDadNPC.smethod_18(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Standing, EClothes.Shirt, "Coby's Dad Shirt")));
					_J4giDjnRtYmiHMmzwRZ0ThvfAhH = false;
					num = (int)((num2 * 613320299) ^ 0x3D4E943D);
					continue;
				case 3u:
					_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Stern, "Coby's Dad eye", "Coby's Dad Head");
					num = ((int)num2 * -1586422666) ^ -146145270;
					continue;
				case 1u:
					_upl1k7yzBzlU7vErvbydGmXROfA = true;
					num = (int)((num2 * 47572988) ^ 0x1D0A97B9);
					continue;
				default:
					return;
				case 0u:
					break;
				case 2u:
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
			int num = 827592685;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x36AF37B4u) % 12u)
				{
				case 11u:
					CobysDadNPC.smethod_21((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1185f);
					CobysDadNPC.smethod_22((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 24f);
					num = (int)(num2 * 475538445) ^ -496793094;
					continue;
				case 9u:
					CobysDadNPC.smethod_20((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: false);
					num = 208243755;
					continue;
				case 8u:
					goto IL_0042;
				case 4u:
					goto IL_0050;
				case 2u:
					CobysDadNPC.smethod_22((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 24f);
					num = (int)((num2 * 281027384) ^ 0x719E80B6);
					continue;
				case 1u:
					switch (npclocation_0)
					{
					case NPCLocation.Right:
						break;
					case NPCLocation.Middle:
						goto IL_0042;
					case NPCLocation.Left:
						goto IL_0050;
					default:
						goto IL_0097;
					}
					goto case 9u;
				case 0u:
					CobysDadNPC.smethod_21((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 612f);
					num = ((int)num2 * -1003854382) ^ 0x779F0322;
					continue;
				default:
					return;
				case 7u:
					break;
				case 3u:
					return;
				case 5u:
					return;
				case 6u:
					CobysDadNPC.smethod_22((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 24f);
					return;
				case 10u:
					return;
					IL_0097:
					num = (int)((num2 * 783477454) ^ 0x5B647A01);
					continue;
					IL_0050:
					CobysDadNPC.smethod_20((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: true);
					CobysDadNPC.smethod_21((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, -160f);
					num = 1109246090;
					continue;
					IL_0042:
					CobysDadNPC.smethod_20((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: false);
					num = 334994532;
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
