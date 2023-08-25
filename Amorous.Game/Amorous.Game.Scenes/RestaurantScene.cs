namespace Amorous.Game.Scenes;

public class RestaurantScene : AbstractScene
{
	public RestaurantScene(IAmorous game) : base(game)
	{
		AddSpriteLayer("Background", "Assets/Scenes/Restaurant/Background", 0, 0);
		AddSpriteLayerAbove("Bar", "Assets/Scenes/Restaurant/Table", 0, 0);
		FadingMediaPlayer.PlayOnRepeat(AmorousData.OMorroNaoTemVezTrack, 0.4f);
	}
}
