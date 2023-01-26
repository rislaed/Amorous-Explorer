using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class JasonDartsonNPC : LayerNPC<JasonDartsonNPC.EHeads, JasonDartsonNPC.EPoses, JasonDartsonNPC.EClothes>
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

	public static string Name = "Jason Dartson";

	public static Color Color = new Color(122, 53, 54);

	public JasonDartsonNPC(IAmorous game)
		: base(Game, "Assets/NPC/JasonDartson", 0.9f)
	{
		_zDmJ8ztQTMoRvRw2LsNKu5foPpF(EPoses.Standing, "Jason Body")._6NcgB9eEKq8eKu8SgNWnKbLsDhB("Jason Cock");
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Standing, EClothes.Pants, "Jason Pants")._dUWotuFGWMaIlD1IFkXcXUhjchR()._mgkfAuKt1tsSRmn1YmxkzbHikc();
		_ccFOL4TZ4tCLpGUyk1Z9D4UfzEh(EPoses.Standing, EClothes.Shirt, "Jason Shirt")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._9mDS3yizOswyCzK6V3LBhafV7Dh();
		_J4giDjnRtYmiHMmzwRZ0ThvfAhH = false;
		_upl1k7yzBzlU7vErvbydGmXROfA = true;
	}

	public override void SetLocation(NPCLocation npclocation_0)
	{
		base.SetLocation(npclocation_0);
		switch (npclocation_0)
		{
		case NPCLocation.Middle:
			FlipX = false;
			X = 685f;
			Y = 50f;
			break;
		case NPCLocation.Left:
			FlipX = false;
			X = 100f;
			Y = 50f;
			break;
		case NPCLocation.Right:
			FlipX = true;
			X = 1270f;
			Y = 50f;
			break;
		}
	}
}
