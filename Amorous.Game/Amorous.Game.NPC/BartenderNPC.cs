using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class BartenderNPC : LayerNPC<BartenderNPC.EHeads, BartenderNPC.EPoses, BartenderNPC.EClothes>
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

	public static string Name = "Rou";
	public static Color Color = new Color(116, 116, 116);

	public BartenderNPC(IAmorous game)
		: base(game, "Assets/NPC/Bartender", 1f)
	{
		Width = 904;
		Height = 1008;
		AddPose(EPoses.Standing, "Bovine Naked");
		AddClothes(EPoses.Standing, EClothes.Pants, "Bovine pants").AsPants().AsCloth();
		AddClothes(EPoses.Standing, EClothes.Shirt, "Bovine Top").AsShirt().AsNudes();
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
				X = 608f;
				Y = 72f;
				break;
			case NPCLocation.Left:
				FlipX = true;
				X = -160f;
				Y = 72f;
				break;
			case NPCLocation.Right:
				FlipX = false;
				X = 1176f;
				Y = 72f;
				break;
		}
	}
}
