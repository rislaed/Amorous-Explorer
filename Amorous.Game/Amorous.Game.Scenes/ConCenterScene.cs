namespace Amorous.Game.Scenes;

public class ConCenterScene : AbstractScene
{
	public ConCenterScene(IAmorous game) : base(game)
	{
		AddSpriteLayer("Background", "Assets/Scenes/ConCenter/Con Center BG", 0, 0);
		FadingMediaPlayer.PlayOnRepeat(AmorousData.FreeFloatingTrack, 0.4f);
	}
}
