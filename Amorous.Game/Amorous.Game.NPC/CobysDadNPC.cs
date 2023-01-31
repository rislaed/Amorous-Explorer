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
		AddEmotion(EHeads.Stern, "Coby's Dad eye", "Coby's Dad Head");
		AddPose(EPoses.Standing, "Coby's Dad Body");
		AddClothes(EPoses.Standing, EClothes.Pants, "Coby's Dad Pants").AsPants().AsCloth();
		AddClothes(EPoses.Standing, EClothes.Shirt, "Coby's Dad Shirt").AsShirt().AsNudes();
		NudesBehindShirt = false;
		NudesBehindPants = true;
	}

	public override void SetLocation(NPCLocation location)
	{
		base.SetLocation(location);
		switch (location)
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
