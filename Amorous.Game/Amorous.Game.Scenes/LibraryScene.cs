namespace Amorous.Game.Scenes;

public class LibraryScene : AbstractScene
{
	public LibraryScene(IAmorous game)
		: base(game)
	{
		AddTexturedLayer("Background", "Assets/Scenes/Library/Background", 0, 0);
		FadingMediaPlayer.PlayOnRepeat(AmorousData.OutdatedTrack, 0.4f);
	}
}
