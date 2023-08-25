using Amorous.Game.NPC;

namespace Amorous.Game.Scenes;

public class ClubUpstairsScene : AbstractScene
{
	private const int OFFSET_LEFT = -1295;
	private RoseWoodNPC roseWood;
	private ClubStaticZenithNPC zenith;
	private readonly bool showZenith;

	public ClubUpstairsScene(IAmorous game) : base(game)
	{
		AddSpriteLayer("Background", "Assets/Scenes/ClubUpstairs/Upstairs Hall main", OFFSET_LEFT, 0);
		AddClickableLayer("Elevator", "Assets/Scenes/ClubUpstairs/Elevator Door Selectable", -919, 103, OnDownstairsClick);
		AddClickableLayer("Stairs", "Assets/Scenes/ClubUpstairs/Staircase Selectable", -245, 20, OnDownstairsClick);
		AddClickableLayer("Door", "Assets/Scenes/ClubUpstairs/Pool Door Selectable", 2533, 0, OnDoorClick);
		Game.Canvas.SetOverscroll(OFFSET_LEFT, 1295, 0, 0);
		FadingMediaPlayer.Play(AmorousData.ClubTracks, 0.4f, repeat: true, oneOf: true);
		PlayerData data = PlayerPreferences.GetPlayerData();
		showZenith = !data.HasFlag(AmorousData.ZenithLeftClub);
		if (showZenith)
		{
			AddSpriteLayer("Shadow", "Assets/Scenes/ClubUpstairs/ShadowZenith", 540, 712);
			AddSpriteLayer("Shadow", "Assets/Scenes/ClubUpstairs/ShadowRose", 930, 700);
		}
	}

	public override void Start()
	{
		if (showZenith)
		{
			roseWood = base.Game.GetNPCLayerAt<RoseWoodNPC>(LayerOrder.Background);
			roseWood.LockedOnScreen = false;
			roseWood.SetEmotion(RoseWoodNPC.EHeads.None);
			roseWood.SetPose(RoseWoodNPC.EPoses.Standing);
			roseWood.SetClothes(RoseWoodNPC.EClothes.Shirt, RoseWoodNPC.EClothes.Shorts);
			roseWood.X = 950f;
			roseWood.Y = 160f;
			roseWood.Scale = 0.4f;
			roseWood.FlipX = true;
			zenith = base.Game.GetNPCLayerAt<ClubStaticZenithNPC>(LayerOrder.Foreground);
			zenith.X = 580f;
			zenith.Y = 10f;
			zenith.Click = OnZenithClick;
		}
	}

	private void OnDoorClick()
	{
		base.Game.StartScene<ClubPoolScene>();
	}

	private void OnDownstairsClick()
	{
		base.Game.StartScene<ClubLoungeScene>();
	}

	private void OnZenithClick()
	{
		base.Game.PlayCutscene(AmorousData.ZenithPreDate);
	}
}
