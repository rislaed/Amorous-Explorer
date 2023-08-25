namespace Amorous.Game.Scenes;

public class BeachScene : AbstractScene
{
	public BeachScene(IAmorous game) : base(game)
	{
		AddSpriteLayer("Background", "Assets/Scenes/Beach/Beach Background", 0, 0);
		if (base.Game.Cutscene != null && base.Game.Cutscene.Data.Name == AmorousData.DustinDate && base.Game.Cutscene.Stage.StageData.Stage == 60)
		{
			FadingMediaPlayer.PlayOnRepeat(AmorousData.InAFingerBlinkTrack, 0.4f);
		}
		else
		{
			FadingMediaPlayer.PlayOnRepeat(AmorousData.FreeFloatingTrack, 0.4f);
		}
	}
}
