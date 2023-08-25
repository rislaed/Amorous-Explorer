using Amorous.Engine.NPC;

namespace Amorous.Game.NPC;

public class ClubLoungeEFNPC : LayerNPC<ClubLoungeEFNPC.EHeads, ClubLoungeEFNPC.EPoses, ClubLoungeEFNPC.EClothes>
{
	public enum EHeads
	{
		None
	}

	public enum EPoses
	{
		None,
		Sitting
	}

	public enum EClothes
	{
		None,
		Shirt,
		Pants
	}

	public ClubLoungeEFNPC(IAmorous game) : base(game, "Assets/NPC/ClubLoungeStatic", 1f)
	{
		AddPose(EPoses.Sitting, "E F club nude").AddNudes("E F club nude cock");
		AddClothes(EPoses.Sitting, EClothes.Shirt, "E F club shirt").AsShirt().AsNudes();
		AddClothes(EPoses.Sitting, EClothes.Pants, "E F club pants").AsPants().AsCloth();
		NudesBehindShirt = false;
		NudesBehindPants = true;
	}
}
