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
		: base(game, "Assets/NPC/SororityGirl", 1f)
	{
		GetPose(EPoses.Standing, "Sorority Girl Body");
		GetClothes(EPoses.Standing, EClothes.Pants, "Sorority Girl Pants")._dUWotuFGWMaIlD1IFkXcXUhjchR()._mgkfAuKt1tsSRmn1YmxkzbHikc();
		GetClothes(EPoses.Standing, EClothes.Shirt, "Sorority Girl Top")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._9mDS3yizOswyCzK6V3LBhafV7Dh();
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
