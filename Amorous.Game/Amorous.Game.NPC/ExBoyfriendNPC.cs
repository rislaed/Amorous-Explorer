using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class ExBoyfriendNPC : LayerNPC<ExBoyfriendNPC.EHeads, ExBoyfriendNPC.EPoses, ExBoyfriendNPC.EClothes>
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

	public static string Name = "Vareoth";
	public static Color Color = new Color(139, 215, 125);

	public ExBoyfriendNPC(IAmorous game)
		: base(game, "Assets/NPC/ExBoyfriend", 1f)
	{
		AddPose(EPoses.Standing, "Dustin's Ex Boyfriend Expressions");
		AddClothes(EPoses.Standing, EClothes.Pants, "Dustin's Ex Boyfriend Expressions - Pants").AsPants().AsCloth();
		AddClothes(EPoses.Standing, EClothes.Shirt, "Dustin's Ex Boyfriend Expressions - Shirt").AsShirt().AsNudes();
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
				X = 546f;
				Y = 177f;
				break;
			case NPCLocation.Left:
				FlipX = false;
				X = -120f;
				Y = 177f;
				break;
			case NPCLocation.Right:
				FlipX = true;
				X = 1412f;
				Y = 177f;
				break;
		}
	}
}
