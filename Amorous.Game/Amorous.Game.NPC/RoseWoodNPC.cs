using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class RoseWoodNPC : LayerNPC<RoseWoodNPC.EHeads, RoseWoodNPC.EPoses, RoseWoodNPC.EClothes>
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
		Shorts
	}

	public static string _RB8fRXeQvK5vs7JEA0XfVCEpg1i = _003CModule_003E.smethod_25<string>(2006739363u);

	public static Color _9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA = new Color(195, 69, 81);

	public RoseWoodNPC(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0, _003CModule_003E.smethod_25<string>(733483952u), 1f)
	{
		while (true)
		{
			int num = -2011707511;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA02503D4u) % 5u)
				{
				case 4u:
					_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Standing, _003CModule_003E.smethod_28<string>(1590983199u));
					num = (int)(num2 * 106022831) ^ -2034179393;
					continue;
				case 1u:
					RoseWoodNPC.smethod_19(RoseWoodNPC.smethod_18(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Standing, EClothes.Shirt, _003CModule_003E.smethod_26<string>(424217347u))));
					_J4giDjnRtYmiHMmzwRZ0ThvfAhH = true;
					_upl1k7yzBzlU7vErvbydGmXROfA = true;
					num = (int)((num2 * 512282757) ^ 0x3184DCFC);
					continue;
				case 0u:
					RoseWoodNPC.smethod_17(RoseWoodNPC.smethod_16(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Standing, EClothes.Shorts, _003CModule_003E.smethod_26<string>(171425992u))));
					num = ((int)num2 * -1337295347) ^ 0x1F574259;
					continue;
				default:
					return;
				case 2u:
					break;
				case 3u:
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
		case NPCLocation.Left:
			RoseWoodNPC.smethod_20((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: false);
			num = -314874322;
			goto IL_007d;
		case NPCLocation.Middle:
			goto IL_0045;
		default:
			goto IL_005e;
		case NPCLocation.Right:
			goto IL_00b7;
			IL_007d:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD0EE8CA3u) % 10u)
				{
				case 9u:
					RoseWoodNPC.smethod_21((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 100f);
					num = ((int)num2 * -584087302) ^ 0x6FE3431A;
					continue;
				case 8u:
					break;
				case 7u:
					goto IL_0045;
				case 4u:
					goto IL_005e;
				case 0u:
					RoseWoodNPC.smethod_22((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 130f);
					num = ((int)num2 * -1397497777) ^ -3486022;
					continue;
				case 6u:
					goto IL_00b7;
				case 1u:
					return;
				case 2u:
					return;
				default:
					RoseWoodNPC.smethod_22((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 130f);
					return;
				case 5u:
					RoseWoodNPC.smethod_22((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 130f);
					return;
				}
				break;
			}
			goto case NPCLocation.Left;
			IL_00b7:
			RoseWoodNPC.smethod_20((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: true);
			RoseWoodNPC.smethod_21((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1351f);
			num = -791092261;
			goto IL_007d;
			IL_005e:
			num = -577718917;
			goto IL_007d;
			IL_0045:
			RoseWoodNPC.smethod_20((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: false);
			RoseWoodNPC.smethod_21((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 725f);
			num = -772522132;
			goto IL_007d;
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
