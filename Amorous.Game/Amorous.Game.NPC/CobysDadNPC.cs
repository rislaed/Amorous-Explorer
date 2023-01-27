using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class CobysDadNPC : LayerNPC<CobysDadNPC.EHeads, CobysDadNPC.EPoses, CobysDadNPC.EClothes>
{
	public enum EHeads
	{
		None,
		Stern
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

	public static string Name = "Coby's Dad";

	public static Color Color = new Color(176, 206, 255);

	public CobysDadNPC(IAmorous game)
		: base(game, "Assets/NPC/CobysDad", 1f)
	{
		GetEmotion(EHeads.Stern, "Coby's Dad eye", "Coby's Dad Head");
		GetPose(EPoses.Standing, "Coby's Dad Body");
		GetClothes(EPoses.Standing, EClothes.Pants, "Coby's Dad Pants")._dUWotuFGWMaIlD1IFkXcXUhjchR()._mgkfAuKt1tsSRmn1YmxkzbHikc();
		GetClothes(EPoses.Standing, EClothes.Shirt, "Coby's Dad Shirt")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._9mDS3yizOswyCzK6V3LBhafV7Dh();
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
			X = 612f;
			Y = 24f;
			break;
		case NPCLocation.Left:
			FlipX = true;
			X = -160f;
			Y = 24f;
			break;
		case NPCLocation.Right:
			FlipX = false;
			X = 1185f;
			Y = 24f;
			break;
		}
	}
}
