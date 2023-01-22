using System;
using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class ZenithNPC : SpineNPC<ZenithNPC.EHeads, ZenithNPC.EPoses, ZenithNPC.EClothes>
{
	public enum EHeads
	{
		None,
		Angry,
		Blush,
		Happy,
		NotAmused
	}

	public enum EPoses
	{
		None,
		ArmsFolded,
		HandsOnHips
	}

	public enum EClothes
	{
		None,
		Security,
		Shirt,
		Pants
	}

	public static string _RB8fRXeQvK5vs7JEA0XfVCEpg1i = _003CModule_003E.smethod_26<string>(2715142201u);

	public static Color _9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA = new Color(155, 213, 154);

	public ZenithNPC(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0, _003CModule_003E.smethod_27<string>(2877894685u), 1f, bool_0: true)
	{
		while (true)
		{
			int num = 1877643133;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7B4F7A9Du) % 9u)
				{
				case 8u:
					ZenithNPC.smethod_20(_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Angry, _003CModule_003E.smethod_24<string>(1539237707u), _003CModule_003E.smethod_28<string>(2994082169u), _003CModule_003E.smethod_28<string>(1245735061u)), _003CModule_003E.smethod_25<string>(1985894881u));
					num = ((int)num2 * -802343234) ^ -1398660638;
					continue;
				case 7u:
					_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.HandsOnHips, _003CModule_003E.smethod_24<string>(1560573898u), _003CModule_003E.smethod_24<string>(207626482u), _003CModule_003E.smethod_28<string>(2825940938u));
					num = (int)((num2 * 1271453272) ^ 0x649912CE);
					continue;
				case 6u:
					ZenithNPC.smethod_20(_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Blush, _003CModule_003E.smethod_26<string>(499633008u), _003CModule_003E.smethod_24<string>(1696972945u), _003CModule_003E.smethod_24<string>(3391565045u)), _003CModule_003E.smethod_27<string>(1525157651u));
					num = ((int)num2 * -161919845) ^ -1968261875;
					continue;
				case 5u:
					ZenithNPC.smethod_20(_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Happy, _003CModule_003E.smethod_28<string>(2219352690u), _003CModule_003E.smethod_27<string>(3121126026u), _003CModule_003E.smethod_25<string>(1652727612u)), _003CModule_003E.smethod_28<string>(2999848304u));
					ZenithNPC.smethod_20(_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.NotAmused, _003CModule_003E.smethod_25<string>(3248944565u), _003CModule_003E.smethod_24<string>(1696972945u), _003CModule_003E.smethod_27<string>(1281926310u)), _003CModule_003E.smethod_25<string>(1985894881u));
					_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.ArmsFolded, _003CModule_003E.smethod_25<string>(3987585248u), _003CModule_003E.smethod_28<string>(1017862350u), _003CModule_003E.smethod_27<string>(499840085u));
					num = (int)(num2 * 2068157731) ^ -1553551670;
					continue;
				case 4u:
					_J4giDjnRtYmiHMmzwRZ0ThvfAhH = false;
					_upl1k7yzBzlU7vErvbydGmXROfA = true;
					num = (int)((num2 * 996774024) ^ 0x235F56DA);
					continue;
				case 3u:
					ZenithNPC.smethod_19(ZenithNPC.smethod_18((_tfDAeR6npiqJMLRSXPO1DxGA0TgA)this), _003CModule_003E.smethod_26<string>(4184661290u), (Action<int>)null);
					num = ((int)num2 * -637276564) ^ -218693063;
					continue;
				case 2u:
					ZenithNPC.smethod_21(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.ArmsFolded, EClothes.Security, _003CModule_003E.smethod_24<string>(3031583838u)));
					ZenithNPC.smethod_21(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.ArmsFolded, EClothes.Shirt, _003CModule_003E.smethod_25<string>(831575057u)));
					ZenithNPC.smethod_22(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.ArmsFolded, EClothes.Pants, _003CModule_003E.smethod_27<string>(4079582374u)));
					ZenithNPC.smethod_21(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.HandsOnHips, EClothes.Security, _003CModule_003E.smethod_27<string>(24229165u)));
					ZenithNPC.smethod_21(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.HandsOnHips, EClothes.Shirt, _003CModule_003E.smethod_27<string>(1697910520u)));
					ZenithNPC.smethod_22(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.HandsOnHips, EClothes.Pants, _003CModule_003E.smethod_24<string>(3077050187u)));
					num = ((int)num2 * -1110292910) ^ 0x681EFBD3;
					continue;
				default:
					return;
				case 0u:
					break;
				case 1u:
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
			int num = 1738458467;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x560F785Au) % 14u)
				{
				case 12u:
					ZenithNPC.smethod_24((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1540f);
					num = (int)(num2 * 1308396484) ^ -4021831;
					continue;
				case 11u:
					switch (npclocation_0)
					{
					case NPCLocation.Middle:
						goto IL_004f;
					case NPCLocation.Left:
						goto IL_0060;
					case NPCLocation.Right:
						goto IL_006e;
					}
					num = ((int)num2 * -359884535) ^ 0x78632BDD;
					continue;
				case 8u:
					goto IL_004f;
				case 2u:
					goto IL_0060;
				case 9u:
					goto IL_006e;
				case 7u:
					ZenithNPC.smethod_25((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1090f);
					num = ((int)num2 * -139226303) ^ -1545883481;
					continue;
				case 4u:
					ZenithNPC.smethod_24((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 380f);
					num = (int)(num2 * 1227161551) ^ -2081161903;
					continue;
				case 3u:
					ZenithNPC.smethod_25((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1090f);
					num = (int)(num2 * 1005605369) ^ -332809236;
					continue;
				case 1u:
					ZenithNPC.smethod_24((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1000f);
					ZenithNPC.smethod_25((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1090f);
					num = (int)(num2 * 467442579) ^ -2121296389;
					continue;
				default:
					return;
				case 5u:
					break;
				case 0u:
					return;
				case 6u:
					return;
				case 10u:
					return;
				case 13u:
					return;
					IL_006e:
					ZenithNPC.smethod_23((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: false);
					num = 1387617628;
					continue;
					IL_0060:
					ZenithNPC.smethod_23((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: false);
					num = 924322946;
					continue;
					IL_004f:
					ZenithNPC.smethod_23((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: false);
					num = 1133896805;
					continue;
				}
				break;
			}
		}
	}

	static _nHdiyIURlAiaNZ8u6MKzxjcwnyL smethod_18(_tfDAeR6npiqJMLRSXPO1DxGA0TgA _tfDAeR6npiqJMLRSXPO1DxGA0TgA_0)
	{
		return _tfDAeR6npiqJMLRSXPO1DxGA0TgA_0._1BgOJ3z4ZUXNS2L4JWf24pr41hB;
	}

	static void smethod_19(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0, string string_0, Action<int> action_0)
	{
		_nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._C5vPbZ72rpVMDWGuHxZuR5FNpAH(string_0, action_0);
	}

	static _xmfdPa5IagU3cXbLL61gyoXAV7gA smethod_20(_xmfdPa5IagU3cXbLL61gyoXAV7gA _xmfdPa5IagU3cXbLL61gyoXAV7gA_0, string string_0)
	{
		return _xmfdPa5IagU3cXbLL61gyoXAV7gA_0._qL2MEiFtBpbdxqUUTSqOgOsEK4j(string_0);
	}

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_21(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._XJUU6QdUDN3lYoRweLWOMaWqcUE();
	}

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_22(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._dUWotuFGWMaIlD1IFkXcXUhjchR();
	}

	void method_0(NPCLocation npclocation_0)
	{
		base._nGGBtYpZ8pI1BmE2c2ke63UjGDP(npclocation_0);
	}

	static void smethod_23(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, bool bool_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_Pv8G2bIbjHmJYrVXhNyr64NSPXn = bool_0;
	}

	static void smethod_24(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, float float_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_7Xn1C5tjYnmIif1iZKV8AWsEEbL = float_0;
	}

	static void smethod_25(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, float float_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_bCjZ3VSXGKyhmykd2zCnQBiSpDf = float_0;
	}
}
