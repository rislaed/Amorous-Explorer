namespace Amorous.Game.Scenes;

public class BarScene : AbstractScene
{
	public BarScene(IAmorous game)
		: base(game)
	{
		AddSpriteLayer("Background", "Assets/Scenes/Bar/Background", 0, 0);
		FadingMediaPlayer.PlayOnRepeat(AmorousData.OMorroNaoTemVezTrack, 0.4f);
	}
}
