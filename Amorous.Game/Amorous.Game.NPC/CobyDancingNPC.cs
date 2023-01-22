using System;
using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class CobyDancingNPC : SpineNPC<CobyDancingNPC.EHeads, CobyDancingNPC.EPoses, CobyDancingNPC.EClothes>
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
		Shorts,
		Sleeves
	}

	public static Color _9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA = new Color(104, 193, 255);

	public CobyDancingNPC(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0, _003CModule_003E.smethod_28<string>(4169308428u), 0.8f, bool_0: true)
	{
		while (true)
		{
			int num = -1056255311;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE1731893u) % 10u)
				{
				case 9u:
					CobyDancingNPC.smethod_24(CobyDancingNPC.smethod_23(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Dancing, EClothes.Shorts, _003CModule_003E.smethod_27<string>(1147212589u), _003CModule_003E.smethod_27<string>(2108410868u), _003CModule_003E.smethod_24<string>(2301122586u))));
					num = (int)((num2 * 1042631655) ^ 0x79DC3F1);
					continue;
				case 8u:
					_J4giDjnRtYmiHMmzwRZ0ThvfAhH = false;
					_upl1k7yzBzlU7vErvbydGmXROfA = true;
					num = (int)((num2 * 613473034) ^ 0x4624A3E);
					continue;
				case 7u:
					CobyDancingNPC.smethod_22(CobyDancingNPC.smethod_21(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Dancing, EClothes.Sleeves, _003CModule_003E.smethod_26<string>(3725419396u), _003CModule_003E.smethod_24<string>(1049401005u))));
					num = (int)((num2 * 90662058) ^ 0x3D97DC6B);
					continue;
				case 6u:
					CobyDancingNPC.smethod_22(CobyDancingNPC.smethod_21(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Dancing, EClothes.Shirt, _003CModule_003E.smethod_24<string>(3217743035u))));
					num = ((int)num2 * -1554209423) ^ 0x50CD81E2;
					continue;
				case 5u:
					CobyDancingNPC.smethod_19(CobyDancingNPC.smethod_18((_tfDAeR6npiqJMLRSXPO1DxGA0TgA)this), _003CModule_003E.smethod_26<string>(4184661290u), (Action<int>)null);
					num = (int)(num2 * 673706798) ^ -738237062;
					continue;
				case 4u:
					_je8rVfyg4zywmqSi4Ozx1z7wJ4b = 600;
					num = ((int)num2 * -1795829623) ^ -992035461;
					continue;
				case 3u:
					_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Happy, _003CModule_003E.smethod_26<string>(3118720144u), _003CModule_003E.smethod_25<string>(2078828994u), _003CModule_003E.smethod_25<string>(4093303584u), _003CModule_003E.smethod_24<string>(1310611829u));
					CobyDancingNPC.smethod_20(_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Dancing, _003CModule_003E.smethod_28<string>(414952704u), _003CModule_003E.smethod_25<string>(1810232382u), _003CModule_003E.smethod_27<string>(1927548168u), _003CModule_003E.smethod_25<string>(1357696498u), _003CModule_003E.smethod_25<string>(823839569u), _003CModule_003E.smethod_25<string>(937293393u)), new string[2]
					{
						_003CModule_003E.smethod_28<string>(236083439u),
						_003CModule_003E.smethod_25<string>(1078785902u)
					});
					num = (int)(num2 * 1588930926) ^ -1813722303;
					continue;
				case 2u:
					_WJfGWBzn4wgdGBnMWRH2pcJ3AqH = 800;
					num = ((int)num2 * -2033589756) ^ 0x76BF777C;
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
			int num = -1205501701;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBB1947DBu) % 7u)
				{
				case 6u:
					switch (npclocation_0)
					{
					case NPCLocation.Middle:
						goto IL_002c;
					case NPCLocation.Left:
						goto IL_0084;
					case NPCLocation.Right:
						goto IL_00a2;
					}
					num = ((int)num2 * -474530595) ^ 0xB09BBE4;
					continue;
				case 4u:
					goto IL_002c;
				case 5u:
					break;
				default:
					CobyDancingNPC.smethod_27((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1120f);
					return;
				case 3u:
					return;
				case 0u:
					goto IL_0084;
				case 2u:
					goto IL_00a2;
					IL_00a2:
					CobyDancingNPC.smethod_25((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: true);
					CobyDancingNPC.smethod_26((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1520f);
					CobyDancingNPC.smethod_27((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1120f);
					return;
					IL_0084:
					CobyDancingNPC.smethod_25((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: false);
					CobyDancingNPC.smethod_26((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 400f);
					CobyDancingNPC.smethod_27((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1120f);
					return;
					IL_002c:
					CobyDancingNPC.smethod_25((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: false);
					CobyDancingNPC.smethod_26((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 960f);
					num = -139590120;
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

	static _NaKchYC4I4GjWR34SfBLAktysCE smethod_20(_NaKchYC4I4GjWR34SfBLAktysCE _NaKchYC4I4GjWR34SfBLAktysCE_0, string[] string_0)
	{
		return _NaKchYC4I4GjWR34SfBLAktysCE_0._6NcgB9eEKq8eKu8SgNWnKbLsDhB(string_0);
	}

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_21(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._XJUU6QdUDN3lYoRweLWOMaWqcUE();
	}

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_22(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._9mDS3yizOswyCzK6V3LBhafV7Dh();
	}

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_23(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._dUWotuFGWMaIlD1IFkXcXUhjchR();
	}

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_24(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._mgkfAuKt1tsSRmn1YmxkzbHikc();
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
