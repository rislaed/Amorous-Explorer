using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class ChefAssissantNPC : LayerNPC<ChefAssissantNPC.EHeads, ChefAssissantNPC.EPoses, ChefAssissantNPC.EClothes>
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

	public static string _RB8fRXeQvK5vs7JEA0XfVCEpg1i = _003CModule_003E.smethod_27<string>(316235454u);

	public static Color _9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA = new Color(204, 149, 0);

	public ChefAssissantNPC(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0, _003CModule_003E.smethod_25<string>(3535482392u), 1f)
	{
		_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Standing, _003CModule_003E.smethod_28<string>(1407631096u));
		ChefAssissantNPC.smethod_17(ChefAssissantNPC.smethod_16(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Standing, EClothes.Pants, _003CModule_003E.smethod_24<string>(3246372695u))));
		ChefAssissantNPC.smethod_19(ChefAssissantNPC.smethod_18(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Standing, EClothes.Shirt, _003CModule_003E.smethod_27<string>(73004113u))));
		_J4giDjnRtYmiHMmzwRZ0ThvfAhH = false;
		_upl1k7yzBzlU7vErvbydGmXROfA = true;
	}

	public override void _nGGBtYpZ8pI1BmE2c2ke63UjGDP(NPCLocation npclocation_0)
	{
		this.method_0(npclocation_0);
		int num;
		switch (npclocation_0)
		{
		case NPCLocation.Middle:
			ChefAssissantNPC.smethod_20((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: false);
			num = 1746873237;
			goto IL_0089;
		default:
			goto IL_005f;
		case NPCLocation.Left:
			goto IL_00c3;
		case NPCLocation.Right:
			break;
			IL_0089:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC774C8Fu) % 10u)
				{
				case 8u:
					ChefAssissantNPC.smethod_21((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 636f);
					num = ((int)num2 * -1932015554) ^ -476054247;
					continue;
				case 7u:
					break;
				case 4u:
					ChefAssissantNPC.smethod_22((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 117f);
					num = (int)((num2 * 1359353144) ^ 0x16EF9796);
					continue;
				case 2u:
					goto IL_005f;
				case 0u:
					ChefAssissantNPC.smethod_21((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 0f);
					ChefAssissantNPC.smethod_22((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 117f);
					num = (int)((num2 * 524641321) ^ 0x2572544A);
					continue;
				default:
					return;
				case 5u:
					goto IL_00c3;
				case 1u:
					return;
				case 3u:
					return;
				case 9u:
					return;
				case 6u:
					goto end_IL_000a;
				}
				break;
			}
			goto case NPCLocation.Middle;
			IL_00c3:
			ChefAssissantNPC.smethod_20((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: true);
			num = 325751357;
			goto IL_0089;
			IL_005f:
			num = 19239176;
			goto IL_0089;
			end_IL_000a:
			break;
		}
		ChefAssissantNPC.smethod_20((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: false);
		ChefAssissantNPC.smethod_21((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1272f);
		ChefAssissantNPC.smethod_22((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 117f);
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
