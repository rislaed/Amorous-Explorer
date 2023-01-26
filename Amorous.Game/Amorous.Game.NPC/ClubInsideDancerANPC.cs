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

	public ClubInsideDancerANPC(IAmorous game)
		: base(Game, "Assets/NPC/ClubInsideStatic/Dancer A", 0.8f, bool_0: true)
	{
		base.Spine.StartAnimationWithLooping("Dance_B");
		_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Happy, "Eye", "Head", "Jaw", "Pupil")._qL2MEiFtBpbdxqUUTSqOgOsEK4j("Blink");
		_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Dancing, "Arm left", "Character", "Forearm right", "Leg left", "Leg right", "Tail", "shoulder right")._6NcgB9eEKq8eKu8SgNWnKbLsDhB("Cock");
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Dancing, EClothes.Shirt, "Shirt")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._9mDS3yizOswyCzK6V3LBhafV7Dh();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Dancing, EClothes.Pants, "Pants crotch", "Pants left", "Pants right")._dUWotuFGWMaIlD1IFkXcXUhjchR()._mgkfAuKt1tsSRmn1YmxkzbHikc();
		_J4giDjnRtYmiHMmzwRZ0ThvfAhH = false;
		_upl1k7yzBzlU7vErvbydGmXROfA = true;
	}

	public void _KDimeEJ9On2dWcynEqeEZz9c8DE(int int_0, int int_1)
	{
		_MRHxrmqa7mb7D9woehQMcBaVzSfA = int_0;
		_CuajPz31r9WOAgF3NIMwGAOneYc = int_1;
		base.Spine.SetMix("Dance_A", "Dance_B", 0.5f);
		base.Spine.SetMix("Dance_B", "Dance_A", 0.5f);
		_ujQoS5Vtc4de0wSOTrBu7W9PbRc = _MRHxrmqa7mb7D9woehQMcBaVzSfA;
		_W59CJD6wYGEUk3hOFlZnc3R24Ct();
	}

	public void _W59CJD6wYGEUk3hOFlZnc3R24Ct()
	{
		base.Spine.AddAnimation("Dance_A", bool_0: true, 0f, delegate
		{
			_ujQoS5Vtc4de0wSOTrBu7W9PbRc--;
			if (_ujQoS5Vtc4de0wSOTrBu7W9PbRc <= 0)
			{
				_ujQoS5Vtc4de0wSOTrBu7W9PbRc = _CuajPz31r9WOAgF3NIMwGAOneYc;
				_QxrbucYEdHM0AE1Mfd0LKZp28pv();
			}
		});
	}

	public void _QxrbucYEdHM0AE1Mfd0LKZp28pv()
	{
		base.Spine.AddAnimation("Dance_B", bool_0: true, 0f, delegate
		{
			_ujQoS5Vtc4de0wSOTrBu7W9PbRc--;
			if (_ujQoS5Vtc4de0wSOTrBu7W9PbRc <= 0)
			{
				_ujQoS5Vtc4de0wSOTrBu7W9PbRc = _MRHxrmqa7mb7D9woehQMcBaVzSfA;
				_W59CJD6wYGEUk3hOFlZnc3R24Ct();
			}
		});
	}
}
