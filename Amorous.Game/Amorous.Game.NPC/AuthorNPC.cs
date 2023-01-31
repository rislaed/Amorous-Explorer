using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class AuthorNPC : LayerNPC<AuthorNPC.EHeads, AuthorNPC.EPoses, AuthorNPC.EClothes>
{
	public enum EHeads
	{
		None
	}

	public enum EPoses
	{
		None,
		Reading
	}

	public enum EClothes
	{
		None,
		Shirt,
		Pants
	}

	public static string Name = "Nik Kovak";
	public static Color Color = new Color(145, 109, 236);

	public AuthorNPC(IAmorous game)
		: base(game, "Assets/NPC/Author", 1f)
	{
		AddPose(EPoses.Reading, "Sonic Fox Expressions");
		AddClothes(EPoses.Reading, EClothes.Pants, "Sonic Fox Expressions - Pants").AsPants().AsCloth();
		AddClothes(EPoses.Reading, EClothes.Shirt, "Sonic Fox Expressions - Shirt").AsShirt().AsNudes();
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
				X = 618f;
				Y = 30f;
				break;
			case NPCLocation.Left:
				FlipX = true;
				X = 60f;
				Y = 30f;
				break;
			case NPCLocation.Right:
				FlipX = false;
				X = 1206f;
				Y = 30f;
				break;
		}
	}
}
