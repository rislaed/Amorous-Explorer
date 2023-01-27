using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class CosplayerHaneNPC : LayerNPC<CosplayerHaneNPC.EHeads, CosplayerHaneNPC.EPoses, CosplayerHaneNPC.EClothes>
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
		Jacket
	}

	public static string Name = "Hane Maxwell";

	public static Color Color = new Color(186, 78, 60);

	public CosplayerHaneNPC(IAmorous game)
		: base(game, "Assets/NPC/CosplayerHane", 1f)
	{
		GetPose(EPoses.Standing, "Hane Maxwell Cosplayer (nude)");
		GetClothes(EPoses.Standing, EClothes.Jacket, "Hane Maxwell Cosplayer (clothed)")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._9mDS3yizOswyCzK6V3LBhafV7Dh();
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
			X = 413f;
			Y = 0f;
			break;
		case NPCLocation.Left:
			FlipX = true;
			X = -190f;
			Y = 0f;
			break;
		case NPCLocation.Right:
			FlipX = false;
			X = 1016f;
			Y = 0f;
			break;
		}
	}
}
