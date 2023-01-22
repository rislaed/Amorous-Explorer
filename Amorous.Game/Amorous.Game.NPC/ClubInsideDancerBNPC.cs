using System;
using Amorous.Engine.NPC;

namespace Amorous.Game.NPC;

public class ClubInsideDancerBNPC : SpineNPC<ClubInsideDancerBNPC.EHeads, ClubInsideDancerBNPC.EPoses, ClubInsideDancerBNPC.EClothes>
{
	public enum EHeads
	{
		None,
		Happy
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
		Skirt
	}

	public ClubInsideDancerBNPC(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0, _003CModule_003E.smethod_28<string>(4106377407u), 0.7f, bool_0: true)
	{
		ClubInsideDancerBNPC.smethod_19(ClubInsideDancerBNPC.smethod_18((_tfDAeR6npiqJMLRSXPO1DxGA0TgA)this), _003CModule_003E.smethod_25<string>(808152079u), (Action<int>)null);
		_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Happy, _003CModule_003E.smethod_28<string>(823936099u), _003CModule_003E.smethod_26<string>(1470227847u), _003CModule_003E.smethod_28<string>(3992201521u));
		_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Dancing, _003CModule_003E.smethod_24<string>(693169383u), _003CModule_003E.smethod_28<string>(940678579u), _003CModule_003E.smethod_26<string>(3894539116u));
		ClubInsideDancerBNPC.smethod_21(ClubInsideDancerBNPC.smethod_20(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Dancing, EClothes.Shirt, _003CModule_003E.smethod_25<string>(1278196150u))));
		ClubInsideDancerBNPC.smethod_23(ClubInsideDancerBNPC.smethod_22(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Dancing, EClothes.Skirt, _003CModule_003E.smethod_26<string>(2584950814u))));
		_J4giDjnRtYmiHMmzwRZ0ThvfAhH = true;
		_upl1k7yzBzlU7vErvbydGmXROfA = true;
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
