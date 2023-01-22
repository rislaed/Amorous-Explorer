using System;
using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class CobyNPC : SpineNPC<CobyNPC.EHeads, CobyNPC.EPoses, CobyNPC.EClothes>
{
	public enum EHeads
	{
		None,
		Sad,
		Cocky,
		Flirty,
		Happy
	}

	public enum EPoses
	{
		None,
		Flirty,
		Shy,
		Chill
	}

	public enum EClothes
	{
		None,
		Shirt,
		Shorts,
		Sleeves,
		Underwear
	}

	public static string _RB8fRXeQvK5vs7JEA0XfVCEpg1i = _003CModule_003E.smethod_25<string>(1468896597u);

	public static Color _9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA = new Color(104, 193, 255);

	public CobyNPC(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0, _003CModule_003E.smethod_28<string>(3642145370u), 1f, bool_0: true)
	{
		while (true)
		{
			int num = 1704874863;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2F399879u) % 15u)
				{
				case 14u:
					CobyNPC.smethod_20(_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Happy, _003CModule_003E.smethod_28<string>(2800960154u), _003CModule_003E.smethod_24<string>(1260645978u), _003CModule_003E.smethod_25<string>(1784555679u), _003CModule_003E.smethod_28<string>(3593946160u)), _003CModule_003E.smethod_27<string>(3811030255u));
					num = (int)((num2 * 192624091) ^ 0x30146626);
					continue;
				case 13u:
					CobyNPC.smethod_23(CobyNPC.smethod_22(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Flirty, EClothes.Shirt, _003CModule_003E.smethod_27<string>(2696156662u))));
					num = ((int)num2 * -1192242492) ^ -614267447;
					continue;
				case 12u:
					_J4giDjnRtYmiHMmzwRZ0ThvfAhH = false;
					_upl1k7yzBzlU7vErvbydGmXROfA = true;
					num = (int)(num2 * 782436719) ^ -756480548;
					continue;
				case 10u:
					CobyNPC.smethod_26(CobyNPC.smethod_25(CobyNPC.smethod_24(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Chill, EClothes.Underwear, _003CModule_003E.smethod_28<string>(1677936882u)))));
					num = ((int)num2 * -1995533177) ^ 0x3313A30C;
					continue;
				case 9u:
					CobyNPC.smethod_21(_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Chill, _003CModule_003E.smethod_24<string>(3703285936u), _003CModule_003E.smethod_27<string>(2220545742u)), new string[1] { _003CModule_003E.smethod_25<string>(237546664u) });
					num = (int)(num2 * 1380077651) ^ -908023747;
					continue;
				case 7u:
					CobyNPC.smethod_23(CobyNPC.smethod_22(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Chill, EClothes.Sleeves, _003CModule_003E.smethod_26<string>(2667024935u))));
					num = (int)(num2 * 1061397964) ^ -969787826;
					continue;
				case 6u:
					CobyNPC.smethod_26(CobyNPC.smethod_24(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Shy, EClothes.Underwear, _003CModule_003E.smethod_28<string>(1281443879u))));
					CobyNPC.smethod_23(CobyNPC.smethod_22(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Chill, EClothes.Shirt, _003CModule_003E.smethod_28<string>(1563760996u))));
					CobyNPC.smethod_26(CobyNPC.smethod_25(CobyNPC.smethod_24(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Chill, EClothes.Shorts, _003CModule_003E.smethod_25<string>(3458127512u)))));
					num = ((int)num2 * -1294443655) ^ 0x531259AA;
					continue;
				case 5u:
					CobyNPC.smethod_23(CobyNPC.smethod_22(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Flirty, EClothes.Sleeves, _003CModule_003E.smethod_28<string>(3371839584u))));
					num = (int)(num2 * 1940827979) ^ -2117195771;
					continue;
				case 4u:
					CobyNPC.smethod_21(_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Flirty, _003CModule_003E.smethod_26<string>(748296376u), _003CModule_003E.smethod_25<string>(2453468713u), _003CModule_003E.smethod_25<string>(2722065325u)), new string[1] { _003CModule_003E.smethod_26<string>(1405553899u) });
					CobyNPC.smethod_21(_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Shy, _003CModule_003E.smethod_26<string>(748296376u), _003CModule_003E.smethod_28<string>(260106101u)), new string[1] { _003CModule_003E.smethod_24<string>(879328580u) });
					num = (int)(num2 * 1452525282) ^ -185096495;
					continue;
				case 3u:
					CobyNPC.smethod_26(CobyNPC.smethod_25(CobyNPC.smethod_24(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Flirty, EClothes.Shorts, _003CModule_003E.smethod_27<string>(3650995756u)))));
					num = ((int)num2 * -1799712807) ^ -1565152588;
					continue;
				case 2u:
					CobyNPC.smethod_20(_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Sad, _003CModule_003E.smethod_28<string>(4175553624u), _003CModule_003E.smethod_25<string>(1611579933u), _003CModule_003E.smethod_27<string>(1382334099u)), _003CModule_003E.smethod_26<string>(4274103160u));
					CobyNPC.smethod_20(_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Cocky, _003CModule_003E.smethod_26<string>(181368948u), _003CModule_003E.smethod_28<string>(1269432548u), _003CModule_003E.smethod_25<string>(2951984497u), _003CModule_003E.smethod_28<string>(3870497142u)), _003CModule_003E.smethod_24<string>(1449054926u));
					CobyNPC.smethod_20(_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Flirty, _003CModule_003E.smethod_26<string>(2062811422u), _003CModule_003E.smethod_25<string>(172976007u), _003CModule_003E.smethod_28<string>(1725657031u), _003CModule_003E.smethod_25<string>(2228814790u)), _003CModule_003E.smethod_27<string>(3404147161u));
					num = (int)(num2 * 244769056) ^ -288337803;
					continue;
				case 1u:
					CobyNPC.smethod_19(CobyNPC.smethod_18((_tfDAeR6npiqJMLRSXPO1DxGA0TgA)this), _003CModule_003E.smethod_24<string>(1830372324u), (Action<int>)null);
					num = ((int)num2 * -440564624) ^ -1460822227;
					continue;
				case 0u:
					CobyNPC.smethod_26(CobyNPC.smethod_24(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Flirty, EClothes.Underwear, _003CModule_003E.smethod_27<string>(1744934822u))));
					CobyNPC.smethod_23(CobyNPC.smethod_22(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Shy, EClothes.Shirt, _003CModule_003E.smethod_28<string>(3257663698u))));
					CobyNPC.smethod_26(CobyNPC.smethod_25(CobyNPC.smethod_24(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Shy, EClothes.Shorts, _003CModule_003E.smethod_27<string>(3658230264u)))));
					CobyNPC.smethod_23(CobyNPC.smethod_22(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Shy, EClothes.Sleeves, _003CModule_003E.smethod_28<string>(3768332587u))));
					num = (int)((num2 * 454567242) ^ 0x3B817EFB);
					continue;
				default:
					return;
				case 8u:
					break;
				case 11u:
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
		case NPCLocation.Middle:
			CobyNPC.smethod_27((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: false);
			num = 423622958;
			goto IL_00d1;
		default:
			goto IL_00a4;
		case NPCLocation.Left:
			goto IL_00c5;
		case NPCLocation.Right:
			goto IL_0117;
			IL_00d1:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x585CF8B5u) % 13u)
				{
				case 12u:
					CobyNPC.smethod_28((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 400f);
					num = (int)(num2 * 1812492165) ^ -1749408473;
					continue;
				case 11u:
					CobyNPC.smethod_29((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1120f);
					num = ((int)num2 * -538087658) ^ 0x28465EC7;
					continue;
				case 10u:
					break;
				case 8u:
					CobyNPC.smethod_29((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1120f);
					num = ((int)num2 * -1609815560) ^ -1980143564;
					continue;
				case 6u:
					CobyNPC.smethod_28((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 960f);
					CobyNPC.smethod_29((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1120f);
					num = ((int)num2 * -1329035913) ^ -597686786;
					continue;
				case 4u:
					goto IL_00a4;
				case 1u:
					CobyNPC.smethod_28((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1520f);
					num = ((int)num2 * -1066272213) ^ 0x8764C9;
					continue;
				case 0u:
					goto IL_00c5;
				default:
					return;
				case 3u:
					goto IL_0117;
				case 2u:
					return;
				case 5u:
					return;
				case 7u:
					return;
				case 9u:
					return;
				}
				break;
			}
			goto case NPCLocation.Middle;
			IL_0117:
			CobyNPC.smethod_27((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: true);
			num = 1074374047;
			goto IL_00d1;
			IL_00c5:
			CobyNPC.smethod_27((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: false);
			num = 1334374563;
			goto IL_00d1;
			IL_00a4:
			num = 1636475902;
			goto IL_00d1;
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

	static _NaKchYC4I4GjWR34SfBLAktysCE smethod_21(_NaKchYC4I4GjWR34SfBLAktysCE _NaKchYC4I4GjWR34SfBLAktysCE_0, string[] string_0)
	{
		return _NaKchYC4I4GjWR34SfBLAktysCE_0._6NcgB9eEKq8eKu8SgNWnKbLsDhB(string_0);
	}

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_22(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._XJUU6QdUDN3lYoRweLWOMaWqcUE();
	}

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_23(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._9mDS3yizOswyCzK6V3LBhafV7Dh();
	}

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_24(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._dUWotuFGWMaIlD1IFkXcXUhjchR();
	}

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_25(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._B19pyNfKCkJxZB1oCC3WzfkqEQF();
	}

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_26(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._mgkfAuKt1tsSRmn1YmxkzbHikc();
	}

	void method_0(NPCLocation npclocation_0)
	{
		base._nGGBtYpZ8pI1BmE2c2ke63UjGDP(npclocation_0);
	}

	static void smethod_27(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, bool bool_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_Pv8G2bIbjHmJYrVXhNyr64NSPXn = bool_0;
	}

	static void smethod_28(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, float float_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_7Xn1C5tjYnmIif1iZKV8AWsEEbL = float_0;
	}

	static void smethod_29(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, float float_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_bCjZ3VSXGKyhmykd2zCnQBiSpDf = float_0;
	}
}
