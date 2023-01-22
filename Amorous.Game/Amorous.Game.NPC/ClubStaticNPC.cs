using Amorous.Engine.NPC;

namespace Amorous.Game.NPC;

public abstract class ClubStaticNPC : LayerNPC<ClubStaticNPC.EHeads, ClubStaticNPC.EPoses, ClubStaticNPC.EClothes>
{
	public enum EHeads
	{
		None
	}

	public enum EPoses
	{
		None,
		Nude
	}

	public enum EClothes
	{
		None,
		Shirt,
		Pants
	}

	protected ClubStaticNPC(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0, string string_0, string string_1, bool bool_0, bool bool_1)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0, string_0, 1f)
	{
		_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Nude, ClubStaticNPC.smethod_16(_003CModule_003E.smethod_28<string>(2423202739u), (object)string_1));
		if (bool_0)
		{
			ClubStaticNPC.smethod_17(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Nude, EClothes.Shirt, ClubStaticNPC.smethod_16(_003CModule_003E.smethod_24<string>(3004454012u), (object)string_1)));
		}
		if (bool_1)
		{
			ClubStaticNPC.smethod_18(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Nude, EClothes.Pants, ClubStaticNPC.smethod_16(_003CModule_003E.smethod_28<string>(729300037u), (object)string_1)));
		}
	}

	public override void _g9Sx54kMPiHz5jrqWh4Kb1pTijH()
	{
		this.method_0();
		_g3oEqGBkN3YHUPosRq2nIP2sX0D(EHeads.None);
		_tDFvus0ZCanjp81eOiDzoMXJiuf(EPoses.Nude);
		_09vxUzgOn7J7DFZEwsTh7lgEIhB(EClothes.Shirt, EClothes.Pants);
	}

	static string smethod_16(string string_0, object object_0)
	{
		return string.Format(string_0, object_0);
	}

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_17(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._XJUU6QdUDN3lYoRweLWOMaWqcUE();
	}

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_18(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._dUWotuFGWMaIlD1IFkXcXUhjchR();
	}

	void method_0()
	{
		base._g9Sx54kMPiHz5jrqWh4Kb1pTijH();
	}
}
