using System;
using Amorous.Engine.NPC;

namespace Amorous.Game.NPC;

public class ClubLoungeDancerANPC : SpineNPC<ClubLoungeDancerANPC.EHeads, ClubLoungeDancerANPC.EPoses, ClubLoungeDancerANPC.EClothes>
{
	public enum EHeads
	{
		None,
		Smirk
	}

	public enum EPoses
	{
		None,
		Dancing
	}

	public enum EClothes
	{
		None,
		Shirt,
		Shorts
	}

	public ClubLoungeDancerANPC(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0, _003CModule_003E.smethod_26<string>(2028809833u), 1f, bool_0: true)
	{
		while (true)
		{
			int num = 622064657;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x47DBF6CCu) % 5u)
				{
				case 4u:
					ClubLoungeDancerANPC.smethod_21(ClubLoungeDancerANPC.smethod_20(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Dancing, EClothes.Shirt, _003CModule_003E.smethod_27<string>(3837226356u))));
					ClubLoungeDancerANPC.smethod_23(ClubLoungeDancerANPC.smethod_22(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Dancing, EClothes.Shorts, _003CModule_003E.smethod_27<string>(3532501697u), _003CModule_003E.smethod_24<string>(3772132526u))));
					num = ((int)num2 * -626765912) ^ 0x90363C5;
					continue;
				case 2u:
					_J4giDjnRtYmiHMmzwRZ0ThvfAhH = true;
					_upl1k7yzBzlU7vErvbydGmXROfA = true;
					num = (int)((num2 * 1634815871) ^ 0x39D5B6CF);
					continue;
				case 1u:
					ClubLoungeDancerANPC.smethod_19(ClubLoungeDancerANPC.smethod_18((_tfDAeR6npiqJMLRSXPO1DxGA0TgA)this), _003CModule_003E.smethod_25<string>(3692662391u), (Action<int>)null);
					_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Smirk, _003CModule_003E.smethod_28<string>(908648363u), _003CModule_003E.smethod_24<string>(1138833869u), _003CModule_003E.smethod_26<string>(483076326u), _003CModule_003E.smethod_27<string>(3079817510u), _003CModule_003E.smethod_27<string>(1466406264u));
					_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Dancing, _003CModule_003E.smethod_24<string>(1428674353u), _003CModule_003E.smethod_28<string>(3520440991u), _003CModule_003E.smethod_26<string>(3745305308u), _003CModule_003E.smethod_28<string>(322079000u), _003CModule_003E.smethod_24<string>(4053723923u), _003CModule_003E.smethod_28<string>(4112622603u), _003CModule_003E.smethod_24<string>(3227286255u), _003CModule_003E.smethod_27<string>(2813659436u), _003CModule_003E.smethod_26<string>(259270348u));
					num = (int)(num2 * 296986908) ^ -1478927738;
					continue;
				default:
					return;
				case 0u:
					break;
				case 3u:
					return;
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

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_20(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._XJUU6QdUDN3lYoRweLWOMaWqcUE();
	}

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_21(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._9mDS3yizOswyCzK6V3LBhafV7Dh();
	}

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_22(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._dUWotuFGWMaIlD1IFkXcXUhjchR();
	}

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_23(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._mgkfAuKt1tsSRmn1YmxkzbHikc();
	}
}
