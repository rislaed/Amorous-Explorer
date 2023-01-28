namespace Amorous.Game.Scenes;

public class FlowerShopScene : AbstractScene
{
	public FlowerShopScene(IAmorous game)
		: base(game)
	{
		AddTexturedLayer("Background", "Assets/Scenes/FlowerShop/Background", 0, 0);
		FadingMediaPlayer._l94kUraQ13OohoVwwxKC37hG7Pc("Assets/Music/Warhector - Free Floating", 0.4f);
	}
}
