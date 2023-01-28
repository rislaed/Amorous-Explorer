namespace Amorous.Game.Scenes;

public class PlaceholderScene : AbstractScene
{
	public PlaceholderScene(IAmorous game)
		: base(game)
	{
		AddTexturedLayer("Background", "Assets/Scenes/Placeholder/Background", 0, 0);
		FadingMediaPlayer.BeginCutscene();
	}
}
