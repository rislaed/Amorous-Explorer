namespace Amorous.Game.Scenes;

public class SpaScene : AbstractScene
{
	public SpaScene(IAmorous game) : base(game)
	{
		AddSpriteLayer("Background", "Assets/Scenes/Spa/Background", 0, 0);
		FadingMediaPlayer.PlayOnRepeat(AmorousData.FlyinTrack, 0.4f);
	}
}
