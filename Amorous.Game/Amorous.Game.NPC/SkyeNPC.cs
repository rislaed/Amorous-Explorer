using System;
using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class SkyeNPC : SpineNPC<SkyeNPC.EHeads, SkyeNPC.EPoses, SkyeNPC.EClothes>
{
	public enum EHeads
	{
		None,
		Angry,
		Blush,
		Sad,
		Happy,
		Neutral
	}

	public enum EPoses
	{
		None,
		Suggestive,
		Guarded
	}

	public enum EClothes
	{
		None,
		Hoodie,
		Shirt,
		Shorts
	}

	public static string _RB8fRXeQvK5vs7JEA0XfVCEpg1i = "Skye";

	public static Color _9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA = new Color(248, 255, 167);

	public SkyeNPC(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0, "Assets/NPC/Skye/Skye", 1f, bool_0: true)
	{
		while (true)
		{
			int num = -737535048;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD7F08170u) % 12u)
				{
				case 11u:
					_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Blush, "Blush head", "Blush pupils", "Blush eye back");
					_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Sad, "Sad Head", "Sad pupil", "Sad eye back");
					num = (int)((num2 * 1102439912) ^ 0x120B863);
					continue;
				case 10u:
					_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Angry, "Angry Head", "Angry pupil", "Angry eyeback");
					num = ((int)num2 * -1711602647) ^ -370060667;
					continue;
				case 9u:
					SkyeNPC.smethod_25(SkyeNPC.smethod_24(SkyeNPC.smethod_23(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Suggestive, EClothes.Hoodie, "Suggestive hoodie"))));
					num = ((int)num2 * -235415308) ^ 0x4774B26;
					continue;
				case 7u:
					SkyeNPC.smethod_22(_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Neutral, "Neutral head", "Neutral pupil", "Neutral eye back", "Neutral jaw"), "Neutral blink");
					_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Suggestive, "Suggestive Body", "Suggestive boobs", "Suggestive Tail");
					_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Guarded, "Guarded body", "Guarded boobs", "Guarded boob cover", "Guarded tail");
					num = ((int)num2 * -223700293) ^ 0x7C66D52C;
					continue;
				case 6u:
					SkyeNPC.smethod_25(SkyeNPC.smethod_23(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Suggestive, EClothes.Shirt, "Suggestive shirt")));
					num = ((int)num2 * -726403166) ^ -1889279611;
					continue;
				case 5u:
					SkyeNPC.smethod_21(SkyeNPC.smethod_20((_tfDAeR6npiqJMLRSXPO1DxGA0TgA)this), "Idle", (Action<int>)null);
					num = (int)(num2 * 2113926561) ^ -1628804205;
					continue;
				case 4u:
					SkyeNPC.smethod_19((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, new Type[2]
					{
						SkyeNPC.smethod_18(typeof(SkyeBlueNPC).TypeHandle),
						SkyeNPC.smethod_18(typeof(SkyeGrayNPC).TypeHandle)
					});
					num = (int)(num2 * 1316201438) ^ -1256456283;
					continue;
				case 3u:
					SkyeNPC.smethod_22(_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Happy, "Happy head", "Happy pupil", "Happy eye back", "Happy jaw"), "Happy blink");
					num = ((int)num2 * -72897308) ^ -476637449;
					continue;
				case 1u:
					SkyeNPC.smethod_28(SkyeNPC.smethod_27(SkyeNPC.smethod_26(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Suggestive, EClothes.Shorts, "Suggestive shorts"))));
					SkyeNPC.smethod_25(SkyeNPC.smethod_24(SkyeNPC.smethod_23(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Guarded, EClothes.Hoodie, "Guarded hoodie"))));
					SkyeNPC.smethod_25(SkyeNPC.smethod_23(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Guarded, EClothes.Shirt, "Guarded shirt")));
					SkyeNPC.smethod_28(SkyeNPC.smethod_27(SkyeNPC.smethod_26(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Guarded, EClothes.Shorts, "Guarded shorts"))));
					num = (int)(num2 * 140616429) ^ -191135971;
					continue;
				case 0u:
					_J4giDjnRtYmiHMmzwRZ0ThvfAhH = true;
					_upl1k7yzBzlU7vErvbydGmXROfA = true;
					num = (int)(num2 * 411438503) ^ -1648567876;
					continue;
				default:
					return;
				case 2u:
					break;
				case 8u:
					return;
				}
				break;
			}
		}
	}

	public override void _nGGBtYpZ8pI1BmE2c2ke63UjGDP(NPCLocation npclocation_0)
	{
		this.method_0(npclocation_0);
		if (npclocation_0 != NPCLocation.Left)
		{
			goto IL_00a6;
		}
		goto IL_00e9;
		IL_00e9:
		SkyeNPC.smethod_29((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: false);
		int num = -360314067;
		goto IL_00ab;
		IL_00ab:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x8BA8D672u) % 11u)
			{
			case 8u:
				num = ((int)num2 * -1676762009) ^ -2137547969;
				continue;
			case 7u:
				SkyeNPC.smethod_30((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 400f);
				num = ((int)num2 * -850618743) ^ -1109571911;
				continue;
			case 6u:
				SkyeNPC.smethod_31((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1120f);
				num = (int)((num2 * 1357779939) ^ 0xB9606DA);
				continue;
			case 5u:
				SkyeNPC.smethod_30((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 960f);
				num = (int)((num2 * 881479184) ^ 0x11B0DADA);
				continue;
			case 2u:
			{
				int num3;
				int num4;
				if (npclocation_0 != NPCLocation.Right)
				{
					num3 = -1780950328;
					num4 = -1780950328;
				}
				else
				{
					num3 = -427950323;
					num4 = -427950323;
				}
				num = num3 ^ ((int)num2 * -648642948);
				continue;
			}
			case 1u:
				SkyeNPC.smethod_29((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: false);
				num = -446522497;
				continue;
			case 0u:
				break;
			default:
				return;
			case 9u:
				goto IL_00e9;
			case 3u:
				SkyeNPC.smethod_31((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1120f);
				return;
			case 4u:
				SkyeNPC.smethod_29((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: true);
				SkyeNPC.smethod_30((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1520f);
				SkyeNPC.smethod_31((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1120f);
				return;
			case 10u:
				return;
			}
			break;
		}
		goto IL_00a6;
		IL_00a6:
		num = -161057946;
		goto IL_00ab;
	}

	static Type smethod_18(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	static void smethod_19(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, Type[] type_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._rAt6TRbgK04lvrs5QPjcd0n26pk = type_0;
	}

	static _nHdiyIURlAiaNZ8u6MKzxjcwnyL smethod_20(_tfDAeR6npiqJMLRSXPO1DxGA0TgA _tfDAeR6npiqJMLRSXPO1DxGA0TgA_0)
	{
		return _tfDAeR6npiqJMLRSXPO1DxGA0TgA_0._1BgOJ3z4ZUXNS2L4JWf24pr41hB;
	}

	static void smethod_21(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0, string string_0, Action<int> action_0)
	{
		_nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._C5vPbZ72rpVMDWGuHxZuR5FNpAH(string_0, action_0);
	}

	static _xmfdPa5IagU3cXbLL61gyoXAV7gA smethod_22(_xmfdPa5IagU3cXbLL61gyoXAV7gA _xmfdPa5IagU3cXbLL61gyoXAV7gA_0, string string_0)
	{
		return _xmfdPa5IagU3cXbLL61gyoXAV7gA_0._qL2MEiFtBpbdxqUUTSqOgOsEK4j(string_0);
	}

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_23(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._XJUU6QdUDN3lYoRweLWOMaWqcUE();
	}

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_24(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._KCZzL8xtjbw97bTOV0k8JDz3olE();
	}

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_25(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._9mDS3yizOswyCzK6V3LBhafV7Dh();
	}

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_26(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._dUWotuFGWMaIlD1IFkXcXUhjchR();
	}

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_27(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._B19pyNfKCkJxZB1oCC3WzfkqEQF();
	}

	static _EZ0kOLXoEoEfWGQDdTbNqaPzDUh smethod_28(_EZ0kOLXoEoEfWGQDdTbNqaPzDUh _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0)
	{
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._mgkfAuKt1tsSRmn1YmxkzbHikc();
	}

	void method_0(NPCLocation npclocation_0)
	{
		base._nGGBtYpZ8pI1BmE2c2ke63UjGDP(npclocation_0);
	}

	static void smethod_29(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, bool bool_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_Pv8G2bIbjHmJYrVXhNyr64NSPXn = bool_0;
	}

	static void smethod_30(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, float float_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_7Xn1C5tjYnmIif1iZKV8AWsEEbL = float_0;
	}

	static void smethod_31(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, float float_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_bCjZ3VSXGKyhmykd2zCnQBiSpDf = float_0;
	}
}
