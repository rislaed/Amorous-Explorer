using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class GangCNPC : LayerNPC<GangCNPC.EHeads, GangCNPC.EPoses, GangCNPC.EClothes>
{
	public enum EHeads
	{
		None
	}

	public enum EPoses
	{
		None,
		Neutral
	}

	public enum EClothes
	{
		None,
		Shirt,
		Pants
	}

	public static string Name = "Jade";
	public static Color Color = new Color(98, 178, 17);

	public GangCNPC(IAmorous game)
		: base(game, "Assets/NPC/GangC", 1f)
	{
		Width = 610;
		Height = 1002;
		AddPose(EPoses.Neutral, "Jade Nude");
		AddClothes(EPoses.Neutral, EClothes.Shirt, "Jade Shirt").AsShirt().AsNudes();
		AddClothes(EPoses.Neutral, EClothes.Pants, "Jade Pants").AsPants().AsCloth();
		NudesBehindShirt = false;
		NudesBehindPants = true;
	}

	protected override string[] GetPieces()
	{
		return new string[3] { "Jade Nude", "Jade Pants", "Jade Shirt" };
	}

	public override void SetLocation(NPCLocation location)
	{
		base.SetLocation(location);
		switch (location)
		{
			case NPCLocation.Middle:
				FlipX = false;
				X = 655f;
				Y = 78f;
				base.Scale = 1f;
				break;
			case NPCLocation.Left:
				FlipX = true;
				X = 100f;
				Y = 78f;
				base.Scale = 1f;
				break;
			case NPCLocation.Right:
				FlipX = false;
				X = 1210f;
				Y = 78f;
				base.Scale = 1f;
				break;
		}
	}
}
