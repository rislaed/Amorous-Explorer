namespace Amorous.Game.Scenes;

public class ConCenterScene : AbstractScene
{
	public ConCenterScene(IAmorous game)
		: base(game)
	{
		AddTexturedLayer("Background", "Assets/Scenes/ConCenter/Con Center BG", 0, 0);
		FadingMediaPlayer.PlayOnRepeat(AmorousData.FreeFloatingTrack, 0.4f);
	}
}
