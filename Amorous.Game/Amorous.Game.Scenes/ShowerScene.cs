namespace Amorous.Game.Scenes;

public class ShowerScene : AbstractScene
{
	public ShowerScene(IAmorous game)
		: base(game)
	{
		AddTexturedLayer("Background", "Assets/Scenes/Shower/Shower BG", 0, 0);
		FadingMediaPlayer.PlayOnRepeat(AmorousData.LongGoneTrack, 0.4f);
	}
}
