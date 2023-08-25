using Amorous.Game.NPC;

namespace Amorous.Game.Scenes;

public class ClubEntranceScene : AbstractScene
{
	private KaneNPC kane;
	private NPCLayer kaneLayer;

	public ClubEntranceScene(IAmorous game) : base(game)
	{
		AddSpriteLayer("Background", "Assets/Scenes/ClubEntrance/Club Front", -535, 0);
		AddSpriteLayer("Rope Back", "Assets/Scenes/ClubEntrance/Club Front Ropes (behind)", -535, 0);
		AddAnimatedLayer("Lights", -535, 0, 500, "Assets/Scenes/ClubEntrance/Club Front Glow (option one)", "Assets/Scenes/ClubEntrance/Club Front Glow (option two)");
		AddClickableLayer("Entrance", "Assets/Scenes/ClubEntrance/Club Entrance Door Selectable", 410, 96, OnDoorClick);
		AddClickableLayer("Club Back", "Assets/Scenes/ClubEntrance/Back of Club Selectable", -535, 0, OnClubBackClick);
		AddSpriteLayer("Rope Front", "Assets/Scenes/ClubEntrance/Club Front Ropes (infront)", -535, 0);
		Game.Canvas.SetOverscroll(-535, 535, 0, 0);
		FadingMediaPlayer.Play(AmorousData.ClubTracks, 0.4f, repeat: true, oneOf: true);
		PlayerData data = PlayerPreferences.GetPlayerData();
		if (data.GetStage(AmorousData.Prologue) >= AmorousData.PhoneAllowedState)
		{
			PhoneOverlay.Enabled = true;
		}
	}

	public override void Start()
	{
		kane = base.Game.GetNPCLayerAt<KaneNPC>(LayerOrder.Background);
		kaneLayer = GetNPCLayer<KaneNPC>();
		kaneLayer.CutsceneChange = delegate
		{
			kaneLayer.ZOrder = 1;
			kaneLayer.LayerOrder = 0;
			kane.LockedOnScreen = false;
			kane.SetEmotion(KaneNPC.EHeads.Angry);
			kane.SetPose(KaneNPC.EPoses.Stern);
			kane.SetClothes(KaneNPC.EClothes.Shirt, KaneNPC.EClothes.Shorts);
			kane.X = -25f;
			kane.Y = 180f;
			kane.Scale = 0.4f;
			kane.Click = OnKaneClick;
			RefreshLayerOrdering();
		};
		ClubEntranceABNPC clubEntranceABNPC = base.Game.GetNPCLayerAt<ClubEntranceABNPC>(LayerOrder.Background);
		clubEntranceABNPC.SetPose(ClubStaticNPC.EPoses.Nude);
		clubEntranceABNPC.SetClothes(ClubStaticNPC.EClothes.Pants, ClubStaticNPC.EClothes.Shirt);
		clubEntranceABNPC.X = -325f;
		clubEntranceABNPC.Y = 300f;
		GetNPCLayer<ClubEntranceABNPC>().LayerOrder = 1;
		ClubEntranceCNPC clubEntranceCNPC = base.Game.GetNPCLayerAt<ClubEntranceCNPC>(LayerOrder.Background);
		clubEntranceCNPC.SetPose(ClubStaticNPC.EPoses.Nude);
		clubEntranceCNPC.SetClothes(ClubStaticNPC.EClothes.Pants, ClubStaticNPC.EClothes.Shirt);
		clubEntranceCNPC.X = 1630f;
		clubEntranceCNPC.Y = 205f;
		ClubEntranceDNPC clubEntranceDNPC = base.Game.GetNPCLayerAt<ClubEntranceDNPC>(LayerOrder.Background);
		clubEntranceDNPC.SetPose(ClubStaticNPC.EPoses.Nude);
		clubEntranceDNPC.SetClothes(ClubStaticNPC.EClothes.Pants, ClubStaticNPC.EClothes.Shirt);
		clubEntranceDNPC.X = 1930f;
		clubEntranceDNPC.Y = 255f;
		GetNPCLayer<ClubEntranceCNPC>().LayerOrder = 1;
		GetNPCLayer<ClubEntranceDNPC>().LayerOrder = 1;
	}

	private void OnDoorClick()
	{
		base.Game.StartScene<ClubInsideScene>();
	}

	private void OnClubBackClick()
	{
		base.Game.StartScene<ClubBackScene>();
	}

	private void OnKaneClick()
	{
		kaneLayer.ZOrder = 3;
		kaneLayer.LayerOrder = 0;
		kane.Click = null;
		kane.IsHovered = false;
		RefreshLayerOrdering();
		base.Game.PlayCutscene(AmorousData.Kane);
	}
}
