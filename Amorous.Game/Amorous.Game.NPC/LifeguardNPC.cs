using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class LifeguardNPC : LayerNPC<LifeguardNPC.EHeads, LifeguardNPC.EPoses, LifeguardNPC.EClothes>
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

	public static string Name = "Riptide";
	public static Color Color = new Color(244, 146, 66);

	public LifeguardNPC(IAmorous game)
		: base(game, "Assets/NPC/Lifeguard", 1f)
	{
		AddPose(EPoses.Standing, "Riptide - Nude");
		AddClothes(EPoses.Standing, EClothes.Pants, "Riptide - Pants").AsPants().AsCloth();
		AddClothes(EPoses.Standing, EClothes.Shirt, "Riptide - Shirt").AsShirt().AsNudes();
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
				X = 689f;
				Y = 102f;
				break;
			case NPCLocation.Left:
				FlipX = true;
				X = -271f;
				Y = 102f;
				break;
			case NPCLocation.Right:
				FlipX = false;
				X = 1320f;
				Y = 102f;
				break;
		}
	}
}
