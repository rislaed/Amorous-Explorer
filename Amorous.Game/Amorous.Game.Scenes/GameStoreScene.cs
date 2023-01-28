namespace Amorous.Game.Scenes;

public class GameStoreScene : AbstractScene
{
	public GameStoreScene(IAmorous game)
		: base(game)
	{
		AddTexturedLayer("Background", "Assets/Scenes/GameStore/Game store BG", 0, 0);
		FadingMediaPlayer._l94kUraQ13OohoVwwxKC37hG7Pc("Assets/Music/Rekuiem - Flyin", 0.4f);
	}
}
