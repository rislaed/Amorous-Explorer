using System;
using System.Linq;
using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class MercyNPC : SpineNPC<MercyNPC.EHeads, MercyNPC.EPoses, MercyNPC.EClothes>
{
	public enum EHeads
	{
		None,
		Angry,
		Happy,
		Sad,
		BlushConfident,
		BlushShy
	}

	public enum EPoses
	{
		None,
		Standing,
		ArmsShy
	}

	public enum EClothes
	{
		None,
		Dress,
		SkimpyDress,
		SportsBra,
		SportsShorts,
		Necklace
	}

	public static string _RB8fRXeQvK5vs7JEA0XfVCEpg1i = _003CModule_003E.smethod_28<string>(2242245941u);

	public static Color _9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA = new Color(172, 135, 255);

	public MercyNPC(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0, _003CModule_003E.smethod_25<string>(3388399863u), 1f, bool_0: true)
	{
		MercyNPC.smethod_19(MercyNPC.smethod_18((_tfDAeR6npiqJMLRSXPO1DxGA0TgA)this), _003CModule_003E.smethod_26<string>(4184661290u), (Action<int>)null);
		string[] first = new string[7]
		{
			_003CModule_003E.smethod_27<string>(1281926310u),
			_003CModule_003E.smethod_27<string>(3869781642u),
			_003CModule_003E.smethod_27<string>(2715993578u),
			_003CModule_003E.smethod_25<string>(3992742240u),
			_003CModule_003E.smethod_27<string>(630293153u),
			_003CModule_003E.smethod_26<string>(3716319931u),
			_003CModule_003E.smethod_25<string>(4191611203u)
		};
		_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Angry, first.Union(new string[2]
		{
			_003CModule_003E.smethod_24<string>(3683449579u),
			_003CModule_003E.smethod_27<string>(815416506u)
		}).ToArray());
		MercyNPC.smethod_20(_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Happy, first.Union(new string[3]
		{
			_003CModule_003E.smethod_26<string>(3222322425u),
			_003CModule_003E.smethod_24<string>(2232275996u),
			_003CModule_003E.smethod_28<string>(3888753669u)
		}).ToArray()), _003CModule_003E.smethod_28<string>(2218069393u));
		MercyNPC.smethod_20(_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Sad, first.Union(new string[2]
		{
			_003CModule_003E.smethod_24<string>(3919574627u),
			_003CModule_003E.smethod_24<string>(3975334113u)
		}).ToArray()), _003CModule_003E.smethod_24<string>(3537507312u));
		_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.BlushConfident, first.Union(new string[2]
		{
			_003CModule_003E.smethod_28<string>(1401864961u),
			_003CModule_003E.smethod_25<string>(232389672u)
		}).ToArray());
		MercyNPC.smethod_20(_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.BlushShy, first.Union(new string[2]
		{
			_003CModule_003E.smethod_25<string>(903881202u),
			_003CModule_003E.smethod_27<string>(815416506u)
		}).ToArray()), _003CModule_003E.smethod_24<string>(3537507312u));
		_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Standing, _003CModule_003E.smethod_24<string>(225213088u), _003CModule_003E.smethod_26<string>(2267530245u), _003CModule_003E.smethod_27<string>(3679933788u), _003CModule_003E.smethod_25<string>(3436741745u));
		_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.ArmsShy, _003CModule_003E.smethod_28<string>(3155978204u), _003CModule_003E.smethod_25<string>(1908540001u), _003CModule_003E.smethod_26<string>(3933467449u), _003CModule_003E.smethod_27<string>(2371827011u));
		MercyNPC.smethod_22(MercyNPC.smethod_21(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Standing, EClothes.Dress, _003CModule_003E.smethod_24<string>(1696223028u))));
		MercyNPC.smethod_22(MercyNPC.smethod_21(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Standing, EClothes.SkimpyDress, _003CModule_003E.smethod_28<string>(1065582499u))));
		MercyNPC.smethod_23(MercyNPC.smethod_21(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Standing, EClothes.SportsBra, _003CModule_003E.smethod_25<string>(3050075602u))));
		MercyNPC.smethod_24(MercyNPC.smethod_22(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Standing, EClothes.SportsShorts, _003CModule_003E.smethod_24<string>(888121883u))));
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Standing, EClothes.Necklace, _003CModule_003E.smethod_27<string>(2492715115u));
		MercyNPC.smethod_22(MercyNPC.smethod_21(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.ArmsShy, EClothes.Dress, _003CModule_003E.smethod_27<string>(3443936955u))));
		MercyNPC.smethod_22(MercyNPC.smethod_21(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.ArmsShy, EClothes.SkimpyDress, _003CModule_003E.smethod_26<string>(42966321u))));
		MercyNPC.smethod_23(MercyNPC.smethod_21(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.ArmsShy, EClothes.SportsBra, _003CModule_003E.smethod_26<string>(245199405u))));
		MercyNPC.smethod_24(MercyNPC.smethod_22(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.ArmsShy, EClothes.SportsShorts, _003CModule_003E.smethod_28<string>(3102012859u))));
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.ArmsShy, EClothes.Necklace, _003CModule_003E.smethod_25<string>(3520119673u));
		_J4giDjnRtYmiHMmzwRZ0ThvfAhH = true;
		_upl1k7yzBzlU7vErvbydGmXROfA = true;
	}

	public override void _nGGBtYpZ8pI1BmE2c2ke63UjGDP(NPCLocation npclocation_0)
	{
		this.method_0(npclocation_0);
		int num;
		switch (npclocation_0)
		{
		default:
			num = 1869106861;
			goto IL_002e;
		case NPCLocation.Middle:
			goto IL_0022;
		case NPCLocation.Right:
			goto IL_0059;
		case NPCLocation.Left:
			break;
			IL_002e:
			switch ((uint)(num ^ 0x102195A4) % 7u)
			{
			case 6u:
				break;
			case 2u:
				goto IL_0022;
			case 1u:
				goto IL_0059;
			default:
				MercyNPC.smethod_26((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 960f);
				MercyNPC.smethod_27((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1090f);
				return;
			case 3u:
				return;
			case 4u:
				goto end_IL_000a;
			case 5u:
				MercyNPC.smethod_26((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1600f);
				MercyNPC.smethod_27((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1090f);
				return;
			}
			goto default;
			IL_0059:
			MercyNPC.smethod_25((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: true);
			num = 39716073;
			goto IL_002e;
			IL_0022:
			MercyNPC.smethod_25((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: false);
			num = 409823781;
			goto IL_002e;
			end_IL_000a:
			break;
		}
		MercyNPC.smethod_25((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: false);
		MercyNPC.smethod_26((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 320f);
		MercyNPC.smethod_27((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1090f);
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

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_23(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._KCZzL8xtjbw97bTOV0k8JDz3olE();
	}

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_24(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._B19pyNfKCkJxZB1oCC3WzfkqEQF();
	}

	void method_0(NPCLocation npclocation_0)
	{
		base._nGGBtYpZ8pI1BmE2c2ke63UjGDP(npclocation_0);
	}

	static void smethod_25(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, bool bool_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_Pv8G2bIbjHmJYrVXhNyr64NSPXn = bool_0;
	}

	static void smethod_26(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, float float_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_7Xn1C5tjYnmIif1iZKV8AWsEEbL = float_0;
	}

	static void smethod_27(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, float float_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_bCjZ3VSXGKyhmykd2zCnQBiSpDf = float_0;
	}
}
