using System;
using System.Runtime.CompilerServices;
using Amorous.Engine.NPC;

namespace Amorous.Game.NPC;

public class ClubInsideDancerANPC : SpineNPC<ClubInsideDancerANPC.EHeads, ClubInsideDancerANPC.EPoses, ClubInsideDancerANPC.EClothes>
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
		Pants
	}

	private int _MRHxrmqa7mb7D9woehQMcBaVzSfA;

	private int _CuajPz31r9WOAgF3NIMwGAOneYc;

	private int _ujQoS5Vtc4de0wSOTrBu7W9PbRc;

	public ClubInsideDancerANPC(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0, "Assets/NPC/ClubInsideStatic/Dancer A", 0.8f, bool_0: true)
	{
		while (true)
		{
			int num = -238617530;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAA29D7B0u) % 4u)
				{
				case 2u:
					ClubInsideDancerANPC.smethod_19(ClubInsideDancerANPC.smethod_18((_tfDAeR6npiqJMLRSXPO1DxGA0TgA)this), "Dance_B", (Action<int>)null);
					ClubInsideDancerANPC.smethod_20(_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Happy, "Eye", "Head", "Jaw", "Pupil"), "Blink");
					ClubInsideDancerANPC.smethod_21(_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Dancing, "Arm left", "Character", "Forearm right", "Leg left", "Leg right", "Tail", "shoulder right"), new string[1] { "Cock" });
					ClubInsideDancerANPC.smethod_23(ClubInsideDancerANPC.smethod_22(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Dancing, EClothes.Shirt, "Shirt")));
					num = (int)((num2 * 1955871607) ^ 0x579FBE83);
					continue;
				case 1u:
					ClubInsideDancerANPC.smethod_25(ClubInsideDancerANPC.smethod_24(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Dancing, EClothes.Pants, "Pants crotch", "Pants left", "Pants right")));
					_J4giDjnRtYmiHMmzwRZ0ThvfAhH = false;
					_upl1k7yzBzlU7vErvbydGmXROfA = true;
					num = (int)((num2 * 1973836194) ^ 0x52AFCC6D);
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

	public void _KDimeEJ9On2dWcynEqeEZz9c8DE(int int_0, int int_1)
	{
		_MRHxrmqa7mb7D9woehQMcBaVzSfA = int_0;
		while (true)
		{
			int num = -235018692;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEED3A125u) % 4u)
				{
				case 2u:
					ClubInsideDancerANPC.smethod_26(ClubInsideDancerANPC.smethod_18((_tfDAeR6npiqJMLRSXPO1DxGA0TgA)this), "Dance_B", "Dance_A", 0.5f);
					_ujQoS5Vtc4de0wSOTrBu7W9PbRc = _MRHxrmqa7mb7D9woehQMcBaVzSfA;
					num = (int)((num2 * 1301120) ^ 0x6C2E1F6A);
					continue;
				case 1u:
					_CuajPz31r9WOAgF3NIMwGAOneYc = int_1;
					ClubInsideDancerANPC.smethod_26(ClubInsideDancerANPC.smethod_18((_tfDAeR6npiqJMLRSXPO1DxGA0TgA)this), "Dance_A", "Dance_B", 0.5f);
					num = (int)(num2 * 1096314718) ^ -1292970263;
					continue;
				case 0u:
					break;
				default:
					_W59CJD6wYGEUk3hOFlZnc3R24Ct();
					return;
				}
				break;
			}
		}
	}

	public void _W59CJD6wYGEUk3hOFlZnc3R24Ct()
	{
		ClubInsideDancerANPC.smethod_27(ClubInsideDancerANPC.smethod_18((_tfDAeR6npiqJMLRSXPO1DxGA0TgA)this), "Dance_A", bool_0: true, 0f, (Action<int>)delegate
		{
			_ujQoS5Vtc4de0wSOTrBu7W9PbRc--;
			if (_ujQoS5Vtc4de0wSOTrBu7W9PbRc <= 0)
			{
				while (true)
				{
					int num = -136277278;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0x960E416Fu) % 4u)
						{
						case 1u:
							_ujQoS5Vtc4de0wSOTrBu7W9PbRc = _CuajPz31r9WOAgF3NIMwGAOneYc;
							num = (int)((num2 * 1240573637) ^ 0x111871E2);
							continue;
						case 0u:
							_QxrbucYEdHM0AE1Mfd0LKZp28pv();
							num = (int)(num2 * 1125799162) ^ -693237584;
							continue;
						default:
							return;
						case 2u:
							break;
						case 3u:
							return;
						}
						break;
					}
				}
			}
		}, (Action)null);
	}

	public void _QxrbucYEdHM0AE1Mfd0LKZp28pv()
	{
		ClubInsideDancerANPC.smethod_27(ClubInsideDancerANPC.smethod_18((_tfDAeR6npiqJMLRSXPO1DxGA0TgA)this), "Dance_B", bool_0: true, 0f, (Action<int>)delegate
		{
			_ujQoS5Vtc4de0wSOTrBu7W9PbRc--;
			if (_ujQoS5Vtc4de0wSOTrBu7W9PbRc <= 0)
			{
				while (true)
				{
					int num = -855881375;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0xC2007C67u) % 4u)
						{
						case 3u:
							_W59CJD6wYGEUk3hOFlZnc3R24Ct();
							num = ((int)num2 * -1361403863) ^ 0x78FD5C41;
							continue;
						case 2u:
							_ujQoS5Vtc4de0wSOTrBu7W9PbRc = _MRHxrmqa7mb7D9woehQMcBaVzSfA;
							num = ((int)num2 * -1819599391) ^ 0x6065B91E;
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
		}, (Action)null);
	}

	[CompilerGenerated]
	private void _ERS5by8UZMa9rquJdzZ76kEtcKk(int int_0)
	{
		_ujQoS5Vtc4de0wSOTrBu7W9PbRc--;
		if (_ujQoS5Vtc4de0wSOTrBu7W9PbRc > 0)
		{
			return;
		}
		while (true)
		{
			int num = -136277278;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x960E416Fu) % 4u)
				{
				case 1u:
					_ujQoS5Vtc4de0wSOTrBu7W9PbRc = _CuajPz31r9WOAgF3NIMwGAOneYc;
					num = (int)((num2 * 1240573637) ^ 0x111871E2);
					continue;
				case 0u:
					_QxrbucYEdHM0AE1Mfd0LKZp28pv();
					num = (int)(num2 * 1125799162) ^ -693237584;
					continue;
				default:
					return;
				case 2u:
					break;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	[CompilerGenerated]
	private void _d8hOCRtKY4lKcCvED7zuBZRhVt9(int int_0)
	{
		_ujQoS5Vtc4de0wSOTrBu7W9PbRc--;
		if (_ujQoS5Vtc4de0wSOTrBu7W9PbRc > 0)
		{
			return;
		}
		while (true)
		{
			int num = -855881375;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC2007C67u) % 4u)
				{
				case 3u:
					_W59CJD6wYGEUk3hOFlZnc3R24Ct();
					num = ((int)num2 * -1361403863) ^ 0x78FD5C41;
					continue;
				case 2u:
					_ujQoS5Vtc4de0wSOTrBu7W9PbRc = _MRHxrmqa7mb7D9woehQMcBaVzSfA;
					num = ((int)num2 * -1819599391) ^ 0x6065B91E;
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

	static void smethod_26(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0, string string_0, string string_1, float float_0)
	{
		_nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._zqRttWc6EZHjk1LAoNrCy0Qamk2(string_0, string_1, float_0);
	}

	static void smethod_27(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0, string string_0, bool bool_0, float float_0, Action<int> action_0, Action action_1)
	{
		_nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._a2lgCWeMj1Hr65gQZxslDkqeUdd(string_0, bool_0, float_0, action_0, action_1);
	}
}
