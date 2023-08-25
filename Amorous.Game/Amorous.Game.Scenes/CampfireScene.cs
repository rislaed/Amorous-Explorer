namespace Amorous.Game.Scenes;

public class CampfireScene : AbstractScene
{
	public CampfireScene(IAmorous game) : base(game)
	{
		AddLayer(new CampfireSpineLayer(this), 0);
		FadingMediaPlayer.PlayOnRepeat(AmorousData.FreeFloatingTrack, 0.4f);
	}
}
