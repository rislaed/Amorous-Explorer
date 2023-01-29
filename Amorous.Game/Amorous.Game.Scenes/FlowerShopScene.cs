namespace Amorous.Game.Scenes;

public class FlowerShopScene : AbstractScene
{
	public FlowerShopScene(IAmorous game)
		: base(game)
	{
		AddTexturedLayer("Background", "Assets/Scenes/FlowerShop/Background", 0, 0);
		FadingMediaPlayer.PlayOnRepeat(AmorousData.FreeFloatingTrack, 0.4f);
	}
}
