using Amorous.Engine.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.NPC;

public class KaneNPC : LayerNPC<KaneNPC.EHeads, KaneNPC.EPoses, KaneNPC.EClothes>
{
	public enum EHeads
	{
		None,
		Angry
	}

	public enum EPoses
	{
		None,
		Stern
	}

	public enum EClothes
	{
		None,
		Shirt,
		Shorts
	}

	public static string Name = "Kane";

	public static Color Color = new Color(233, 193, 150);

	public KaneNPC(IAmorous game)
		: base(game, "Assets/NPC/Kane", 1f)
	{
		Width = 1110;
		Height = 1965;
		GetEmotion(EHeads.Angry, "Plate", "Eyeback", "Pupil", "Head")._qL2MEiFtBpbdxqUUTSqOgOsEK4j("Blink");
		GetPose(EPoses.Stern, "Stern")._6NcgB9eEKq8eKu8SgNWnKbLsDhB("Dick");
		GetClothes(EPoses.Stern, EClothes.Shirt, "Stern Shirt")._XJUU6QdUDN3lYoRweLWOMaWqcUE()._9mDS3yizOswyCzK6V3LBhafV7Dh();
		GetClothes(EPoses.Stern, EClothes.Shorts, "Stern Shorts")._dUWotuFGWMaIlD1IFkXcXUhjchR()._mgkfAuKt1tsSRmn1YmxkzbHikc();
		_J4giDjnRtYmiHMmzwRZ0ThvfAhH = false;
		_upl1k7yzBzlU7vErvbydGmXROfA = true;
	}

	protected override string[] _zBK8PXhWw9GtXK9IHkvbuvhbigE()
	{
		return new string[8] { "Plate", "Stern", "Stern Shirt", "Stern Shorts", "Eyeback", "Pupil", "Blink", "Head" };
	}

	public override void SetLocation(NPCLocation npclocation_0)
	{
		base.SetLocation(npclocation_0);
		switch (npclocation_0)
		{
		case NPCLocation.Middle:
			FlipX = false;
			X = 305f;
			Y = 0f;
			base.Scale = 1f;
			break;
		case NPCLocation.Left:
			FlipX = false;
			X = -260f;
			Y = 0f;
			base.Scale = 1f;
			break;
		case NPCLocation.Right:
			FlipX = true;
			X = 1070f;
			Y = 0f;
			base.Scale = 1f;
			break;
		}
	}
}
