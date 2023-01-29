namespace Amorous.Game.Scenes;

public class SaunaScene : AbstractScene
{
	public SaunaScene(IAmorous game)
		: base(game)
	{
		AddTexturedLayer("Background", "Assets/Scenes/Sauna/Background", 0, 0);
		FadingMediaPlayer.PlayOnRepeat(AmorousData.FlyinTrack, 0.4f);
	}
}
