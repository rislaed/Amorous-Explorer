namespace Amorous.Game.Scenes;

public class KitchenScene : AbstractScene
{
	public KitchenScene(IAmorous game)
		: base(game)
	{
		AddTexturedLayer("Background", "Assets/Scenes/Kitchen/Background", 0, 0);
		FadingMediaPlayer._l94kUraQ13OohoVwwxKC37hG7Pc("Assets/Music/Warhector - Free Floating", 0.4f);
	}
}
