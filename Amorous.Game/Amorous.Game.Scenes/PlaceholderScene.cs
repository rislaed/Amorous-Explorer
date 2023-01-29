namespace Amorous.Game.Scenes;

public class PlaceholderScene : AbstractScene
{
	public PlaceholderScene(IAmorous game)
		: base(game)
	{
		AddSpriteLayer("Background", "Assets/Scenes/Placeholder/Background", 0, 0);
		FadingMediaPlayer.Complete();
	}
}
