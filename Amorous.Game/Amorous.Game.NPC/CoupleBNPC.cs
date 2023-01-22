using System;
using Amorous.Engine.NPC;

namespace Amorous.Game.NPC;

public class CoupleBNPC : SpineNPC<CoupleBNPC.EHeads, CoupleBNPC.EPoses, CoupleBNPC.EClothes>
{
	public enum EHeads
	{
		None
	}

	public enum EPoses
	{
		None,
		Waving
	}

	public enum EClothes
	{
		None,
		Shirt,
		Pants
	}

	public CoupleBNPC(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0, _003CModule_003E.smethod_28<string>(380527183u), 1f, bool_0: true)
	{
		while (true)
		{
			int num = 579283785;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x43C5EB73u) % 6u)
				{
				case 5u:
					_J4giDjnRtYmiHMmzwRZ0ThvfAhH = true;
					_upl1k7yzBzlU7vErvbydGmXROfA = true;
					num = (int)((num2 * 90434849) ^ 0x345EE635);
					continue;
				case 4u:
					_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Waving, _003CModule_003E.smethod_27<string>(3425850685u), _003CModule_003E.smethod_25<string>(1040758004u), _003CModule_003E.smethod_24<string>(1551030678u));
					CoupleBNPC.smethod_20(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Waving, EClothes.Shirt, _003CModule_003E.smethod_26<string>(1107175751u)));
					num = ((int)num2 * -1113388198) ^ -1850195045;
					continue;
				case 2u:
					CoupleBNPC.smethod_19(CoupleBNPC.smethod_18((_tfDAeR6npiqJMLRSXPO1DxGA0TgA)this), _003CModule_003E.smethod_27<string>(2231397504u), (Action<int>)null);
					num = ((int)num2 * -1679065564) ^ 0xC9F0C7;
					continue;
				case 0u:
					CoupleBNPC.smethod_21(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Waving, EClothes.Pants, _003CModule_003E.smethod_26<string>(1674901936u)));
					num = ((int)num2 * -1294170961) ^ 0xF7D350C;
					continue;
				default:
					return;
				case 3u:
					break;
				case 1u:
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
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._dUWotuFGWMaIlD1IFkXcXUhjchR();
	}
}
