using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class CinemaClerkNPC : LayerNPC<CinemaClerkNPC.EHeads, CinemaClerkNPC.EPoses, CinemaClerkNPC.EClothes>
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
		Vest,
		Pants
	}

	public static string Name = "Cryptic";
	public static Color Color = new Color(255, 24, 24);

	public CinemaClerkNPC(IAmorous game) : base(game, "Assets/NPC/CinemaClerk", 1f)
	{
		AddPose(EPoses.Standing, "Cinema Clerk Expressions");
		AddClothes(EPoses.Standing, EClothes.Pants, "Cinema Clerk Expressions - Pants").AsPants().AsCloth();
		AddClothes(EPoses.Standing, EClothes.Vest, "Cinema Clerk Expressions - Vest").AsShirt().AsNudes();
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
				X = 413f;
				Y = 22f;
				break;
			case NPCLocation.Left:
				FlipX = true;
				X = -190f;
				Y = 22f;
				break;
			case NPCLocation.Right:
				FlipX = false;
				X = 1016f;
				Y = 22f;
				break;
		}
	}
}
