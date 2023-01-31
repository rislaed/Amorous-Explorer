using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class SororityGirlNPC : LayerNPC<SororityGirlNPC.EHeads, SororityGirlNPC.EPoses, SororityGirlNPC.EClothes>
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

	public static string Name = "Lunar";
	public static Color Color = new Color(221, 110, 218);

	public SororityGirlNPC(IAmorous game)
		: base(game, "Assets/NPC/SororityGirl", 1f)
	{
		AddPose(EPoses.Standing, "Sorority Girl Body");
		AddClothes(EPoses.Standing, EClothes.Pants, "Sorority Girl Pants").AsPants().AsCloth();
		AddClothes(EPoses.Standing, EClothes.Shirt, "Sorority Girl Top").AsShirt().AsNudes();
		NudesBehindShirt = true;
		NudesBehindPants = true;
	}

	public override void SetLocation(NPCLocation location)
	{
		base.SetLocation(location);
		switch (location)
		{
			case NPCLocation.Middle:
				FlipX = false;
				X = 665f;
				Y = 126f;
				break;
			case NPCLocation.Left:
				FlipX = true;
				X = -60f;
				Y = 126f;
				break;
			case NPCLocation.Right:
				FlipX = false;
				X = 1390f;
				Y = 126f;
				break;
		}
	}
}
