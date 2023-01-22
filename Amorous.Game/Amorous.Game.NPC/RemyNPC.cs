using System;
using System.Linq;
using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class RemyNPC : SpineNPC<RemyNPC.EHeads, RemyNPC.EPoses, RemyNPC.EClothes>
{
	public enum EHeads
	{
		None,
		Blushing,
		Happy,
		Sad,
		Shocked
	}

	public enum EPoses
	{
		None,
		LeftArm,
		RightArm,
		BothArms,
		Shy
	}

	public enum EClothes
	{
		None,
		Apron,
		Pants,
		Sweater,
		Swimsuit
	}

	public static string _RB8fRXeQvK5vs7JEA0XfVCEpg1i = _003CModule_003E.smethod_25<string>(900653164u);

	public static Color _9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA;

	public RemyNPC(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0, _003CModule_003E.smethod_28<string>(747556564u), 0.75f, bool_0: true)
	{
		string[] first2 = default(string[]);
		string[] first = default(string[]);
		while (true)
		{
			int num = -1534393164;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD965E3BCu) % 20u)
				{
				case 19u:
					RemyNPC.smethod_22(RemyNPC.smethod_21(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.BothArms, EClothes.Apron, _003CModule_003E.smethod_24<string>(3590267130u))));
					num = ((int)num2 * -767397817) ^ -716808233;
					continue;
				case 18u:
					RemyNPC.smethod_20(_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Blushing, first2.Union(new string[2]
					{
						_003CModule_003E.smethod_27<string>(595639335u),
						_003CModule_003E.smethod_24<string>(49891244u)
					}).ToArray()), _003CModule_003E.smethod_28<string>(1937035573u));
					num = (int)((num2 * 1549019530) ^ 0x5509B9C5);
					continue;
				case 17u:
					RemyNPC.smethod_20(_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Happy, first2.Union(new string[2]
					{
						_003CModule_003E.smethod_26<string>(1207448802u),
						_003CModule_003E.smethod_24<string>(49891244u)
					}).ToArray()), _003CModule_003E.smethod_25<string>(7519235u));
					_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Sad, first2.Union(new string[2]
					{
						_003CModule_003E.smethod_27<string>(3808288324u),
						_003CModule_003E.smethod_27<string>(1658996049u)
					}).ToArray());
					num = ((int)num2 * -952137052) ^ -1264377943;
					continue;
				case 15u:
					RemyNPC.smethod_23(RemyNPC.smethod_22(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.RightArm, EClothes.Pants, _003CModule_003E.smethod_28<string>(585660529u))));
					RemyNPC.smethod_24(RemyNPC.smethod_21(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.RightArm, EClothes.Sweater, _003CModule_003E.smethod_26<string>(2541849760u), _003CModule_003E.smethod_26<string>(3803320796u), _003CModule_003E.smethod_28<string>(135202181u), _003CModule_003E.smethod_24<string>(2645766938u), _003CModule_003E.smethod_27<string>(1441085486u))));
					RemyNPC.smethod_22(RemyNPC.smethod_21(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.RightArm, EClothes.Swimsuit, _003CModule_003E.smethod_25<string>(1280774646u))));
					num = ((int)num2 * -364096759) ^ -1447937420;
					continue;
				case 14u:
					_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.LeftArm, first.Union(new string[3]
					{
						_003CModule_003E.smethod_24<string>(2309915889u),
						_003CModule_003E.smethod_25<string>(1551949754u),
						_003CModule_003E.smethod_28<string>(2393739117u)
					}).ToArray());
					num = ((int)num2 * -464748331) ^ -2141715229;
					continue;
				case 13u:
					_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Shocked, first2.Union(new string[2]
					{
						_003CModule_003E.smethod_27<string>(3568674237u),
						_003CModule_003E.smethod_24<string>(49891244u)
					}).ToArray());
					first = new string[5]
					{
						_003CModule_003E.smethod_28<string>(3520440991u),
						_003CModule_003E.smethod_25<string>(3403004783u),
						_003CModule_003E.smethod_27<string>(232163289u),
						_003CModule_003E.smethod_28<string>(823936099u),
						_003CModule_003E.smethod_27<string>(2371827011u)
					};
					num = (int)(num2 * 715152830) ^ -587584688;
					continue;
				case 12u:
					RemyNPC.smethod_19(RemyNPC.smethod_18((_tfDAeR6npiqJMLRSXPO1DxGA0TgA)this), _003CModule_003E.smethod_24<string>(3841390518u), (Action<int>)null);
					first2 = new string[5]
					{
						_003CModule_003E.smethod_25<string>(4211373115u),
						_003CModule_003E.smethod_25<string>(2383632807u),
						_003CModule_003E.smethod_24<string>(857992389u),
						_003CModule_003E.smethod_25<string>(2517931113u),
						_003CModule_003E.smethod_26<string>(547705540u)
					};
					num = (int)(num2 * 1110286835) ^ -1703342214;
					continue;
				case 11u:
					RemyNPC.smethod_22(RemyNPC.smethod_21(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.LeftArm, EClothes.Swimsuit, _003CModule_003E.smethod_26<string>(468960649u))));
					num = ((int)num2 * -576122499) ^ 0x4A9A97CD;
					continue;
				case 10u:
					RemyNPC.smethod_23(RemyNPC.smethod_22(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.BothArms, EClothes.Pants, _003CModule_003E.smethod_26<string>(2390174947u))));
					num = (int)(num2 * 397187381) ^ -597746561;
					continue;
				case 9u:
					_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.RightArm, first.Union(new string[3]
					{
						_003CModule_003E.smethod_28<string>(3919500588u),
						_003CModule_003E.smethod_25<string>(3026652624u),
						_003CModule_003E.smethod_24<string>(2972824684u)
					}).ToArray());
					_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.BothArms, first.Union(new string[5]
					{
						_003CModule_003E.smethod_26<string>(3603573451u),
						_003CModule_003E.smethod_25<string>(1551949754u),
						_003CModule_003E.smethod_24<string>(2427978413u),
						_003CModule_003E.smethod_28<string>(3523007585u),
						_003CModule_003E.smethod_28<string>(3469042240u)
					}).ToArray());
					num = ((int)num2 * -33344884) ^ 0xE5390E7;
					continue;
				case 8u:
					RemyNPC.smethod_23(RemyNPC.smethod_22(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Shy, EClothes.Pants, _003CModule_003E.smethod_28<string>(585660529u))));
					num = ((int)num2 * -1485977578) ^ 0x5621F540;
					continue;
				case 7u:
					_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Shy, first.Union(new string[1] { _003CModule_003E.smethod_26<string>(1328451256u) }).ToArray());
					RemyNPC.smethod_22(RemyNPC.smethod_21(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.LeftArm, EClothes.Apron, _003CModule_003E.smethod_27<string>(3100297825u))));
					num = ((int)num2 * -216417750) ^ -1326344964;
					continue;
				case 6u:
					RemyNPC.smethod_23(RemyNPC.smethod_22(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.LeftArm, EClothes.Pants, _003CModule_003E.smethod_27<string>(2385072818u))));
					RemyNPC.smethod_24(RemyNPC.smethod_21(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.LeftArm, EClothes.Sweater, _003CModule_003E.smethod_24<string>(1501814744u), _003CModule_003E.smethod_24<string>(439252028u), _003CModule_003E.smethod_28<string>(135202181u), _003CModule_003E.smethod_25<string>(810730575u))));
					num = ((int)num2 * -2122244097) ^ 0x25232B49;
					continue;
				case 5u:
					RemyNPC.smethod_24(RemyNPC.smethod_21(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.BothArms, EClothes.Sweater, _003CModule_003E.smethod_28<string>(303343412u), _003CModule_003E.smethod_28<string>(531695184u), _003CModule_003E.smethod_27<string>(3819140086u), _003CModule_003E.smethod_24<string>(2527704414u), _003CModule_003E.smethod_26<string>(2033781311u))));
					num = ((int)num2 * -900993450) ^ 0x7A8F819F;
					continue;
				case 4u:
					RemyNPC.smethod_22(RemyNPC.smethod_21(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Shy, EClothes.Apron, _003CModule_003E.smethod_27<string>(3100297825u))));
					num = ((int)num2 * -2137380092) ^ 0x5B3D28AC;
					continue;
				case 2u:
					RemyNPC.smethod_22(RemyNPC.smethod_21(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.RightArm, EClothes.Apron, _003CModule_003E.smethod_27<string>(3100297825u))));
					num = ((int)num2 * -974691074) ^ 0x30483A33;
					continue;
				case 1u:
					RemyNPC.smethod_22(RemyNPC.smethod_21(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.BothArms, EClothes.Swimsuit, _003CModule_003E.smethod_27<string>(3347146420u))));
					num = (int)((num2 * 2110979182) ^ 0x265A88EA);
					continue;
				case 0u:
					RemyNPC.smethod_24(RemyNPC.smethod_21(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Shy, EClothes.Sweater, _003CModule_003E.smethod_24<string>(1501814744u), _003CModule_003E.smethod_26<string>(3803320796u), _003CModule_003E.smethod_27<string>(3819140086u), _003CModule_003E.smethod_24<string>(2645766938u))));
					RemyNPC.smethod_22(RemyNPC.smethod_21(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Shy, EClothes.Swimsuit, _003CModule_003E.smethod_24<string>(984098299u))));
					_J4giDjnRtYmiHMmzwRZ0ThvfAhH = true;
					num = ((int)num2 * -1539056697) ^ -488995469;
					continue;
				case 16u:
					break;
				default:
					_upl1k7yzBzlU7vErvbydGmXROfA = true;
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
		default:
			num = 890031072;
			goto IL_00b2;
		case NPCLocation.Left:
			goto IL_0059;
		case NPCLocation.Middle:
			goto IL_0067;
		case NPCLocation.Right:
			goto IL_00f4;
			IL_00b2:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x37DFB443u) % 12u)
				{
				case 10u:
					break;
				case 9u:
					RemyNPC.smethod_27((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1200f);
					num = ((int)num2 * -1334671940) ^ -1404594343;
					continue;
				case 8u:
					RemyNPC.smethod_27((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1200f);
					num = ((int)num2 * -24191371) ^ -1150493653;
					continue;
				case 6u:
					goto IL_0059;
				case 5u:
					goto IL_0067;
				case 3u:
					RemyNPC.smethod_26((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 380f);
					num = ((int)num2 * -730256357) ^ -932463641;
					continue;
				case 1u:
					RemyNPC.smethod_27((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1200f);
					num = ((int)num2 * -1381983471) ^ 0x25EE94EE;
					continue;
				default:
					return;
				case 7u:
					goto IL_00f4;
				case 0u:
					return;
				case 2u:
					return;
				case 4u:
					return;
				case 11u:
					return;
				}
				break;
			}
			goto default;
			IL_00f4:
			RemyNPC.smethod_25((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: true);
			RemyNPC.smethod_26((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1540f);
			num = 367199662;
			goto IL_00b2;
			IL_0067:
			RemyNPC.smethod_25((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: false);
			RemyNPC.smethod_26((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1000f);
			num = 433407107;
			goto IL_00b2;
			IL_0059:
			RemyNPC.smethod_25((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: false);
			num = 327984796;
			goto IL_00b2;
		}
	}

	static RemyNPC()
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			int num = -1535705433;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB7C0E0E7u) % 3u)
				{
				case 1u:
					goto IL_0011;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_0011:
				_9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA = new Color(255, 102, 51);
				num = (int)(num2 * 187053185) ^ -1008894063;
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

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_23(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._B19pyNfKCkJxZB1oCC3WzfkqEQF();
	}

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_24(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._KCZzL8xtjbw97bTOV0k8JDz3olE();
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
