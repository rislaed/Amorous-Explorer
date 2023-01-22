using System;
using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class DustinNPC : SpineNPC<DustinNPC.EHeads, DustinNPC.EPoses, DustinNPC.EClothes>
{
	public enum EHeads
	{
		None,
		Neutral,
		Angry,
		Blush,
		Sad
	}

	public enum EPoses
	{
		None,
		Neutral,
		Gesture
	}

	public enum EClothes
	{
		None,
		Shirt,
		Pants
	}

	public static string _RB8fRXeQvK5vs7JEA0XfVCEpg1i = "Dustin";

	public static Color _9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA;

	public DustinNPC(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0, "Assets/NPC/Dustin/Dustin", 1f, bool_0: true)
	{
		while (true)
		{
			int num = -1188929686;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE0493B6Bu) % 10u)
				{
				case 9u:
					_upl1k7yzBzlU7vErvbydGmXROfA = true;
					num = ((int)num2 * -738617529) ^ -163297875;
					continue;
				case 7u:
					DustinNPC.smethod_19(DustinNPC.smethod_18((_tfDAeR6npiqJMLRSXPO1DxGA0TgA)this), "Idle", (Action<int>)null);
					DustinNPC.smethod_20(_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Neutral, "Neutral Mane", "Neutral eye back", "Neutral pupil", "Neutral jaw", "Neutral head"), "Neutral blink");
					DustinNPC.smethod_20(_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Angry, "Angry mane", "Angry eyeback", "Angry pupil", "Angry head"), "Angry blink");
					DustinNPC.smethod_20(_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Blush, "Blush mane", "Blush eye back", "Blush pupil", "Blush head"), "Blush blink");
					num = ((int)num2 * -1615084381) ^ 0x33280B7E;
					continue;
				case 6u:
					DustinNPC.smethod_20(_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Sad, "Sad earback", "Sad mane", "Sad eyeback", "Sad pupils", "Sad head"), "Sad blink");
					num = ((int)num2 * -829587058) ^ 0x10D66867;
					continue;
				case 4u:
					DustinNPC.smethod_25(DustinNPC.smethod_24(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Neutral, EClothes.Pants, "Pants")));
					num = (int)(num2 * 1737701995) ^ -1616732642;
					continue;
				case 3u:
					DustinNPC.smethod_23(DustinNPC.smethod_22(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Gesture, EClothes.Shirt, "Gesture shirt")));
					num = ((int)num2 * -861304010) ^ 0xDDD18C6;
					continue;
				case 2u:
					_J4giDjnRtYmiHMmzwRZ0ThvfAhH = false;
					num = ((int)num2 * -2051524469) ^ 0xD2CEC5C;
					continue;
				case 1u:
					DustinNPC.smethod_25(DustinNPC.smethod_24(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Gesture, EClothes.Pants, "Pants")));
					num = ((int)num2 * -2001794899) ^ -698822884;
					continue;
				case 0u:
					DustinNPC.smethod_21(_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Neutral, "Body Neutral", "Neutral thumb"), new string[1] { "Cock" });
					DustinNPC.smethod_21(_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Gesture, "Body Gesture"), new string[1] { "Cock" });
					DustinNPC.smethod_23(DustinNPC.smethod_22(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Neutral, EClothes.Shirt, "Neutral shirt")));
					num = (int)(num2 * 1377384309) ^ -1426714263;
					continue;
				default:
					return;
				case 8u:
					break;
				case 5u:
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
		case NPCLocation.Left:
			DustinNPC.smethod_26((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: false);
			DustinNPC.smethod_27((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 400f);
			num = 1378094503;
			goto IL_00ad;
		default:
			goto IL_0036;
		case NPCLocation.Middle:
			goto IL_003d;
		case NPCLocation.Right:
			goto IL_00eb;
			IL_00ad:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x61A8C7F8u) % 11u)
				{
				case 10u:
					break;
				case 8u:
					goto IL_0036;
				case 7u:
					goto IL_003d;
				case 6u:
					DustinNPC.smethod_27((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1520f);
					DustinNPC.smethod_28((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1100f);
					num = (int)(num2 * 1674413374) ^ -1057388390;
					continue;
				case 5u:
					DustinNPC.smethod_28((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1100f);
					num = ((int)num2 * -1472908635) ^ -1337059971;
					continue;
				case 4u:
					DustinNPC.smethod_27((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 960f);
					DustinNPC.smethod_28((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, 1100f);
					num = (int)(num2 * 516179411) ^ -627154345;
					continue;
				default:
					return;
				case 9u:
					goto IL_00eb;
				case 0u:
					return;
				case 1u:
					return;
				case 2u:
					return;
				case 3u:
					return;
				}
				break;
			}
			goto case NPCLocation.Left;
			IL_00eb:
			DustinNPC.smethod_26((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: false);
			num = 440721188;
			goto IL_00ad;
			IL_003d:
			DustinNPC.smethod_26((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)this, bool_0: false);
			num = 2071187274;
			goto IL_00ad;
			IL_0036:
			num = 724981534;
			goto IL_00ad;
		}
	}

	static DustinNPC()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			int num = -1094046505;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC5859AAEu) % 3u)
				{
				case 1u:
					goto IL_000d;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_000d:
				_9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA = new Color(242, 208, 150);
				num = (int)(num2 * 1221004592) ^ -1326380760;
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
		return _EZ0kOLXoEoEfWGQDdTbNqaPzDUh_0._mgkfAuKt1tsSRmn1YmxkzbHikc();
	}

	void method_0(NPCLocation npclocation_0)
	{
		base._nGGBtYpZ8pI1BmE2c2ke63UjGDP(npclocation_0);
	}

	static void smethod_26(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, bool bool_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_Pv8G2bIbjHmJYrVXhNyr64NSPXn = bool_0;
	}

	static void smethod_27(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, float float_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_7Xn1C5tjYnmIif1iZKV8AWsEEbL = float_0;
	}

	static void smethod_28(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, float float_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_bCjZ3VSXGKyhmykd2zCnQBiSpDf = float_0;
	}
}
