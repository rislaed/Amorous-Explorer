namespace Amorous.Game.Scenes;

public class BarScene : AbstractScene
{
	public BarScene(IAmorous game)
		: base(game)
	{
		AddTexturedLayer("Background", "Assets/Scenes/Bar/Background", 0, 0);
		FadingMediaPlayer._l94kUraQ13OohoVwwxKC37hG7Pc("Assets/Music/Steampianist - O Morro Nao Tem Vez", 0.4f);
	}
}
