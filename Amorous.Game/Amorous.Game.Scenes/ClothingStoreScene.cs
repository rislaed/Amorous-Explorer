namespace Amorous.Game.Scenes;

public class ClothingStoreScene : AbstractScene
{
	public ClothingStoreScene(IAmorous game)
		: base(game)
	{
		AddTexturedLayer("Background", "Assets/Scenes/ClothingStore/clothing store BG", 0, 0);
		FadingMediaPlayer._l94kUraQ13OohoVwwxKC37hG7Pc("Assets/Music/Rekuiem - Flyin", 0.4f);
	}
}
