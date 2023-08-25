using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class GangANPC : LayerNPC<GangANPC.EHeads, GangANPC.EPoses, GangANPC.EClothes>
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

	public static string Name = "Kazee Fullford";
	public static Color Color = new Color(220, 0, 0);

	public GangANPC(IAmorous game) : base(game, "Assets/NPC/GangA", 1f)
	{
		Width = 1182;
		Height = 966;
		AddPose(EPoses.Neutral, "Kazee and Taylor Nude");
		AddClothes(EPoses.Neutral, EClothes.Shirt, "Kazee and Taylor Shirts").AsShirt().AsNudes();
		AddClothes(EPoses.Neutral, EClothes.Pants, "Kazee and Taylor Pants").AsPants().AsCloth();
		NudesBehindShirt = false;
		NudesBehindPants = true;
	}

	protected override string[] GetPieces()
	{
		return new string[3] { "Kazee and Taylor Nude", "Kazee and Taylor Pants", "Kazee and Taylor Shirts" };
	}

	public override void SetLocation(NPCLocation location)
	{
		base.SetLocation(location);
		switch (location)
		{
			case NPCLocation.Middle:
				FlipX = false;
				X = 369f;
				Y = 114f;
				base.Scale = 1f;
				break;
			case NPCLocation.Left:
				FlipX = false;
				X = -100f;
				Y = 114f;
				base.Scale = 1f;
				break;
			case NPCLocation.Right:
				FlipX = true;
				X = 838f;
				Y = 114f;
				base.Scale = 1f;
				break;
		}
	}
}
