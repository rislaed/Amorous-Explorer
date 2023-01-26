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

	public static string Name = "Mercy";

	public static Color Color = new Color(172, 135, 255);

	public MercyNPC(IAmorous game)
		: base(Game, "Assets/NPC/Mercy/Mercy", 1f, bool_0: true)
	{
		base.Spine.StartAnimationWithLooping("animation");
		string[] first = new string[7] { "Pupils", "Eyeback", "Hair back", "Hairlock left", "Fringe", "Horn", "Horn tip" };
		_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Angry, first.Union(new string[2] { "Angry head", "AngrySad ear" }).ToArray());
		_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Happy, first.Union(new string[3] { "Happy head", "Happy Jaw", "Happy ear" }).ToArray())._qL2MEiFtBpbdxqUUTSqOgOsEK4j("Happy blink");
		_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.Sad, first.Union(new string[2] { "Sad head", "AngrySad ear" }).ToArray())._qL2MEiFtBpbdxqUUTSqOgOsEK4j("Sad Blink");
		_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.BlushConfident, first.Union(new string[2] { "Blush Confident Head", "AngrySad ear" }).ToArray());
		_aRXZ6kQYnlqRUMIC19x1vIPD62D(EHeads.BlushShy, first.Union(new string[2] { "Blush Shy Head", "AngrySad ear" }).ToArray())._qL2MEiFtBpbdxqUUTSqOgOsEK4j("Sad Blink");
		_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Standing, "Body one", "Arm left hip", "Arm right hip", "Tail");
		_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.ArmsShy, "Body one", "Arms shy", "Arms shy back", "Tail");
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Standing, EClothes.Dress, "Dress")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._dUWotuFGWMaIlD1IFkXcXUhjchR();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Standing, EClothes.SkimpyDress, "Skimpy Dress")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._dUWotuFGWMaIlD1IFkXcXUhjchR();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Standing, EClothes.SportsBra, "Sports Bra")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._KCZzL8xtjbw97bTOV0k8JDz3olE();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Standing, EClothes.SportsShorts, "Sports Shorts")._dUWotuFGWMaIlD1IFkXcXUhjchR()._B19pyNfKCkJxZB1oCC3WzfkqEQF();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Standing, EClothes.Necklace, "Necklace");
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.ArmsShy, EClothes.Dress, "Dress")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._dUWotuFGWMaIlD1IFkXcXUhjchR();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.ArmsShy, EClothes.SkimpyDress, "Skimpy Dress")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._dUWotuFGWMaIlD1IFkXcXUhjchR();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.ArmsShy, EClothes.SportsBra, "Sports Bra")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._KCZzL8xtjbw97bTOV0k8JDz3olE();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.ArmsShy, EClothes.SportsShorts, "Sports Shorts")._dUWotuFGWMaIlD1IFkXcXUhjchR()._B19pyNfKCkJxZB1oCC3WzfkqEQF();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.ArmsShy, EClothes.Necklace, "Necklace");
		_J4giDjnRtYmiHMmzwRZ0ThvfAhH = true;
		_upl1k7yzBzlU7vErvbydGmXROfA = true;
	}

	public override void SetLocation(NPCLocation npclocation_0)
	{
		base.SetLocation(npclocation_0);
		switch (npclocation_0)
		{
		case NPCLocation.Middle:
			FlipX = false;
			X = 960f;
			Y = 1090f;
			break;
		case NPCLocation.Left:
			FlipX = false;
			X = 320f;
			Y = 1090f;
			break;
		case NPCLocation.Right:
			FlipX = true;
			X = 1600f;
			Y = 1090f;
			break;
		}
	}
}
