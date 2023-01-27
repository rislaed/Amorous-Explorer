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
		GetPose(EPoses.Reading, "Sonic Fox Expressions");
		GetClothes(EPoses.Reading, EClothes.Pants, "Sonic Fox Expressions - Pants")._dUWotuFGWMaIlD1IFkXcXUhjchR()._mgkfAuKt1tsSRmn1YmxkzbHikc();
		GetClothes(EPoses.Reading, EClothes.Shirt, "Sonic Fox Expressions - Shirt")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._9mDS3yizOswyCzK6V3LBhafV7Dh();
		_J4giDjnRtYmiHMmzwRZ0ThvfAhH = false;
		_upl1k7yzBzlU7vErvbydGmXROfA = true;
	}

	public override void SetLocation(NPCLocation npclocation_0)
	{
		base.SetLocation(npclocation_0);
		switch (npclocation_0)
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
