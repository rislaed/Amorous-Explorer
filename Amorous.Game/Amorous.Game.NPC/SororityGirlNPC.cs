using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class SororityGirlNPC : LayerNPC<SororityGirlNPC.EHeads, SororityGirlNPC.EPoses, SororityGirlNPC.EClothes>
{
	public enum EHeads
	{
		None
	}

	public enum EPoses
	{
		None,
		Standing
	}

	public enum EClothes
	{
		None,
		Shirt,
		Pants
	}

	public static string Name = "Lunar";

	public static Color Color = new Color(221, 110, 218);

	public SororityGirlNPC(IAmorous game)
		: base(Game, "Assets/NPC/SororityGirl", 1f)
	{
		_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Standing, "Sorority Girl Body");
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Standing, EClothes.Pants, "Sorority Girl Pants")._dUWotuFGWMaIlD1IFkXcXUhjchR()._mgkfAuKt1tsSRmn1YmxkzbHikc();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Standing, EClothes.Shirt, "Sorority Girl Top")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._9mDS3yizOswyCzK6V3LBhafV7Dh();
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
			X = 665f;
			Y = 126f;
			break;
		case NPCLocation.Left:
			FlipX = true;
			X = -60f;
			Y = 126f;
			break;
		case NPCLocation.Right:
			FlipX = false;
			X = 1390f;
			Y = 126f;
			break;
		}
	}
}
