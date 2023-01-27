using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class ExBoyfriendNPC : LayerNPC<ExBoyfriendNPC.EHeads, ExBoyfriendNPC.EPoses, ExBoyfriendNPC.EClothes>
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

	public static string Name = "Vareoth";

	public static Color Color = new Color(139, 215, 125);

	public ExBoyfriendNPC(IAmorous game)
		: base(game, "Assets/NPC/ExBoyfriend", 1f)
	{
		GetPose(EPoses.Standing, "Dustin's Ex Boyfriend Expressions");
		GetClothes(EPoses.Standing, EClothes.Pants, "Dustin's Ex Boyfriend Expressions - Pants")._dUWotuFGWMaIlD1IFkXcXUhjchR()._mgkfAuKt1tsSRmn1YmxkzbHikc();
		GetClothes(EPoses.Standing, EClothes.Shirt, "Dustin's Ex Boyfriend Expressions - Shirt")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._9mDS3yizOswyCzK6V3LBhafV7Dh();
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
			X = 546f;
			Y = 177f;
			break;
		case NPCLocation.Left:
			FlipX = false;
			X = -120f;
			Y = 177f;
			break;
		case NPCLocation.Right:
			FlipX = true;
			X = 1412f;
			Y = 177f;
			break;
		}
	}
}
