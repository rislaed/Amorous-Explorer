using Amorous.Game.NPC;
using Microsoft.Xna.Framework;

namespace Amorous.Game.Scenes;

public class SaveMigrationScene : AbstractScene
{
	private readonly string cutscene;
	private readonly string scene;
	private bool completed;

	public SaveMigrationScene(IAmorous game, string cutscene, string scene) : base(game)
	{
		this.cutscene = cutscene;
		this.scene = scene;
		AddSpriteLayer("Background", "Assets/Scenes/Intro/Background", 0, -540);
		AddSpriteLayer("Background", "Assets/Scenes/Intro/Scenery", 0, -170);
		AddSpriteLayerAbove("Title", "Assets/Scenes/MainMenu/Logo", 616, 50);
		FadingMediaPlayer.PlayOnRepeat(AmorousData.TheNightSkyTrack, 0.4f);
	}

	public override void Start()
	{
		CoupleANPC couplesLeft = base.Game.GetNPCLayerAt<CoupleANPC>(LayerOrder.Background);
		couplesLeft.X = 350f;
		couplesLeft.Y = 1090f;
		couplesLeft.SetPose(CoupleANPC.EPoses.Waving);
		couplesLeft.SetClothes(CoupleANPC.EClothes.Shirt, CoupleANPC.EClothes.Pants);
		CoupleBNPC couplesRight = base.Game.GetNPCLayerAt<CoupleBNPC>(LayerOrder.Background);
		couplesRight.X = 550f;
		couplesRight.Y = 1090f;
		couplesRight.SetPose(CoupleBNPC.EPoses.Waving);
		couplesRight.SetClothes(CoupleBNPC.EClothes.Shirt, CoupleBNPC.EClothes.Pants);
		if (cutscene != null)
		{
			base.Game.PlayCutscene(cutscene);
		}
	}

	public override void Update(GameTime gameTime)
	{
		base.Update(gameTime);
		if (!completed && !base.Game.IsScenePending && base.Game.Cutscene == null)
		{
			completed = true;
			base.Game.StartScene(scene);
		}
	}
}
