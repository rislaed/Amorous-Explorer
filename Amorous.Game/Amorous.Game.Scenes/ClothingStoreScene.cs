namespace Amorous.Game.Scenes;

public class ClothingStoreScene : AbstractScene
{
	public ClothingStoreScene(IAmorous game)
		: base(game)
	{
		AddTexturedLayer("Background", "Assets/Scenes/ClothingStore/clothing store BG", 0, 0);
		FadingMediaPlayer.PlayOnRepeat(AmorousData.FlyinTrack, 0.4f);
	}
}
