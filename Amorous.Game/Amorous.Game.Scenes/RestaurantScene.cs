namespace Amorous.Game.Scenes;

public class RestaurantScene : AbstractScene
{
	public RestaurantScene(IAmorous game)
		: base(game)
	{
		AddTexturedLayer("Background", "Assets/Scenes/Restaurant/Background", 0, 0);
		AddForegroundTexturedLayer("Bar", "Assets/Scenes/Restaurant/Table", 0, 0);
		FadingMediaPlayer.PlayOnRepeat(AmorousData.OMorroNaoTemVezTrack, 0.4f);
	}
}
