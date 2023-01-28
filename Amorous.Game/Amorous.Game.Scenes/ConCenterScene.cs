namespace Amorous.Game.Scenes;

public class ConCenterScene : AbstractScene
{
	public ConCenterScene(IAmorous game)
		: base(game)
	{
		AddTexturedLayer("Background", "Assets/Scenes/ConCenter/Con Center BG", 0, 0);
		FadingMediaPlayer._l94kUraQ13OohoVwwxKC37hG7Pc("Assets/Music/Warhector - Free Floating", 0.4f);
	}
}
