namespace Amorous.Game.Scenes;

public class KitchenScene : AbstractScene
{
	public KitchenScene(IAmorous game)
		: base(game)
	{
		AddTexturedLayer("Background", "Assets/Scenes/Kitchen/Background", 0, 0);
		FadingMediaPlayer.PlayOnRepeat(AmorousData.FreeFloatingTrack, 0.4f);
	}
}
