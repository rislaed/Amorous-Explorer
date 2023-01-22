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
		ClubInsideDancerANPC.smethod_19(ClubInsideDancerANPC.smethod_18((_tfDAeR6npiqJMLRSXPO1DxGA0TgA)this), "Dance_B", (Action<int>)null);
		ClubInsideDancerANPC.smethod_20(_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Happy, "Eye", "Head", "Jaw", "Pupil"), "Blink");
		ClubInsideDancerANPC.smethod_21(_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Dancing, "Arm left", "Character", "Forearm right", "Leg left", "Leg right", "Tail", "shoulder right"), new string[1] { "Cock" });
		ClubInsideDancerANPC.smethod_23(ClubInsideDancerANPC.smethod_22(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Dancing, EClothes.Shirt, "Shirt")));
		ClubInsideDancerANPC.smethod_25(ClubInsideDancerANPC.smethod_24(_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Dancing, EClothes.Pants, "Pants crotch", "Pants left", "Pants right")));
		_J4giDjnRtYmiHMmzwRZ0ThvfAhH = false;
		_upl1k7yzBzlU7vErvbydGmXROfA = true;
	}

	public void _KDimeEJ9On2dWcynEqeEZz9c8DE(int int_0, int int_1)
	{
		_MRHxrmqa7mb7D9woehQMcBaVzSfA = int_0;
		_CuajPz31r9WOAgF3NIMwGAOneYc = int_1;
		ClubInsideDancerANPC.smethod_26(ClubInsideDancerANPC.smethod_18((_tfDAeR6npiqJMLRSXPO1DxGA0TgA)this), "Dance_A", "Dance_B", 0.5f);
		ClubInsideDancerANPC.smethod_26(ClubInsideDancerANPC.smethod_18((_tfDAeR6npiqJMLRSXPO1DxGA0TgA)this), "Dance_B", "Dance_A", 0.5f);
		_ujQoS5Vtc4de0wSOTrBu7W9PbRc = _MRHxrmqa7mb7D9woehQMcBaVzSfA;
		_W59CJD6wYGEUk3hOFlZnc3R24Ct();
	}

	public void _W59CJD6wYGEUk3hOFlZnc3R24Ct()
	{
		ClubInsideDancerANPC.smethod_27(ClubInsideDancerANPC.smethod_18((_tfDAeR6npiqJMLRSXPO1DxGA0TgA)this), "Dance_A", bool_0: true, 0f, (Action<int>)delegate
		{
			_ujQoS5Vtc4de0wSOTrBu7W9PbRc--;
			if (_ujQoS5Vtc4de0wSOTrBu7W9PbRc <= 0)
			{
				_ujQoS5Vtc4de0wSOTrBu7W9PbRc = _CuajPz31r9WOAgF3NIMwGAOneYc;
				_QxrbucYEdHM0AE1Mfd0LKZp28pv();
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
				_ujQoS5Vtc4de0wSOTrBu7W9PbRc = _MRHxrmqa7mb7D9woehQMcBaVzSfA;
				_W59CJD6wYGEUk3hOFlZnc3R24Ct();
			}
		}, (Action)null);
	}

	[CompilerGenerated]
	private void _ERS5by8UZMa9rquJdzZ76kEtcKk(int int_0)
	{
		_ujQoS5Vtc4de0wSOTrBu7W9PbRc--;
		if (_ujQoS5Vtc4de0wSOTrBu7W9PbRc <= 0)
		{
			_ujQoS5Vtc4de0wSOTrBu7W9PbRc = _CuajPz31r9WOAgF3NIMwGAOneYc;
			_QxrbucYEdHM0AE1Mfd0LKZp28pv();
		}
	}

	[CompilerGenerated]
	private void _d8hOCRtKY4lKcCvED7zuBZRhVt9(int int_0)
	{
		_ujQoS5Vtc4de0wSOTrBu7W9PbRc--;
		if (_ujQoS5Vtc4de0wSOTrBu7W9PbRc <= 0)
		{
			_ujQoS5Vtc4de0wSOTrBu7W9PbRc = _MRHxrmqa7mb7D9woehQMcBaVzSfA;
			_W59CJD6wYGEUk3hOFlZnc3R24Ct();
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
