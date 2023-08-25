using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class SecurityGuardNPC : LayerNPC<SecurityGuardNPC.EHeads, SecurityGuardNPC.EPoses, SecurityGuardNPC.EClothes>
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

	public static string Name = "Alexis Pryde";
	public static Color Color = new Color(17, 178, 105);

	public SecurityGuardNPC(IAmorous game) : base(game, "Assets/NPC/SecurityGuard", 1f)
	{
		Width = 452;
		Height = 945;
		AddPose(EPoses.Neutral, "Alexis Nude", "Alexis Tufts");
		AddClothes(EPoses.Neutral, EClothes.Shirt, "Alexis Shirt").AsShirt().AsNudes();
		AddClothes(EPoses.Neutral, EClothes.Pants, "Alexis Pants").AsPants().AsCloth();
		NudesBehindShirt = true;
		NudesBehindPants = true;
	}

	protected override string[] GetPieces()
	{
		return new string[4] { "Alexis Nude", "Alexis Tufts", "Alexis Pants", "Alexis Shirt" };
	}

	public override void SetLocation(NPCLocation location)
	{
		base.SetLocation(location);
		switch (location)
		{
			case NPCLocation.Middle:
				FlipX = false;
				X = 734f;
				Y = 135f;
				base.Scale = 1f;
				break;
			case NPCLocation.Left:
				FlipX = true;
				X = 100f;
				Y = 135f;
				base.Scale = 1f;
				break;
			case NPCLocation.Right:
				FlipX = false;
				X = 1368f;
				Y = 135f;
				base.Scale = 1f;
				break;
		}
	}
}
