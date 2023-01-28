namespace Amorous.Game.Scenes;

public class SaunaScene : AbstractScene
{
	public SaunaScene(IAmorous game)
		: base(game)
	{
		AddTexturedLayer("Background", "Assets/Scenes/Sauna/Background", 0, 0);
		FadingMediaPlayer._l94kUraQ13OohoVwwxKC37hG7Pc("Assets/Music/Rekuiem - Flyin", 0.4f);
	}
}
