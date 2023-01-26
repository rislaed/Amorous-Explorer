using System;
using Amorous.Engine.NPC;

namespace Amorous.Game.NPC;

public class ClubInsideDancerCNPC : SpineNPC<ClubInsideDancerCNPC.EHeads, ClubInsideDancerCNPC.EPoses, ClubInsideDancerCNPC.EClothes>
{
	public enum EHeads
	{
		None,
		Smirk
	}

	public enum EPoses
	{
		None,
		Dancing
	}

	public enum EClothes
	{
		None,
		Shorts
	}

	public ClubInsideDancerCNPC(IAmorous game)
		: base(Game, "Assets/NPC/ClubInsideStatic/Dancer C", 0.7f, bool_0: true)
	{
		base.Spine.StartAnimationWithLooping("Dance A");
		_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Smirk, "Head", "Pupil", "eye");
		_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Dancing, "Arm close", "Character");
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Dancing, EClothes.Shorts, "Shorts")._dUWotuFGWMaIlD1IFkXcXUhjchR()._mgkfAuKt1tsSRmn1YmxkzbHikc();
		_J4giDjnRtYmiHMmzwRZ0ThvfAhH = false;
		_upl1k7yzBzlU7vErvbydGmXROfA = true;
	}
}
