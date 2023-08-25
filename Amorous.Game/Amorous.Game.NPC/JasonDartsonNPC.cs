using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class JasonDartsonNPC : LayerNPC<JasonDartsonNPC.EHeads, JasonDartsonNPC.EPoses, JasonDartsonNPC.EClothes>
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

	public static string Name = "Jason Dartson";
	public static Color Color = new Color(122, 53, 54);

	public JasonDartsonNPC(IAmorous game) : base(game, "Assets/NPC/JasonDartson", 0.9f)
	{
		AddPose(EPoses.Standing, "Jason Body").AddNudes("Jason Cock");
		AddClothes(EPoses.Standing, EClothes.Pants, "Jason Pants").AsPants().AsCloth();
		AddClothes(EPoses.Standing, EClothes.Shirt, "Jason Shirt").AsShirt().AsNudes();
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
				X = 685f;
				Y = 50f;
				break;
			case NPCLocation.Left:
				FlipX = false;
				X = 100f;
				Y = 50f;
				break;
			case NPCLocation.Right:
				FlipX = true;
				X = 1270f;
				Y = 50f;
				break;
		}
	}
}
