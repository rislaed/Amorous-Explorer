using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class CosplayerJacquelineNPC : LayerNPC<CosplayerJacquelineNPC.EHeads, CosplayerJacquelineNPC.EPoses, CosplayerJacquelineNPC.EClothes>
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

	public static string Name = "Jacqueline Knight";

	public static Color Color = new Color(138, 148, 170);

	public CosplayerJacquelineNPC(IAmorous game)
		: base(game, "Assets/NPC/CosplayerJacqueline", 1f)
	{
		GetPose(EPoses.Standing, "Jacqueline Knight (nude)");
		GetClothes(EPoses.Standing, EClothes.Shirt, "Jacqueline Knight (shirt)")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._9mDS3yizOswyCzK6V3LBhafV7Dh();
		GetClothes(EPoses.Standing, EClothes.Pants, "Jacqueline Knight (pants)")._dUWotuFGWMaIlD1IFkXcXUhjchR()._mgkfAuKt1tsSRmn1YmxkzbHikc();
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
			X = 545f;
			Y = 0f;
			break;
		case NPCLocation.Left:
			FlipX = true;
			X = -200f;
			Y = 0f;
			break;
		case NPCLocation.Right:
			FlipX = false;
			X = 1166f;
			Y = 0f;
			break;
		}
	}
}
