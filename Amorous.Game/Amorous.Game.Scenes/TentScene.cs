namespace Amorous.Game.Scenes;

public class TentScene : AbstractScene
{
	public TentScene(IAmorous game)
		: base(game)
	{
		AddTexturedLayer("Background", "Assets/Scenes/Tent/Background", 0, 0);
		FadingMediaPlayer.PlayOnRepeat(AmorousData.FreeFloatingTrack, 0.4f);
	}
}
