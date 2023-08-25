namespace Amorous.Game.Scenes;

public class GameStoreScene : AbstractScene
{
	public GameStoreScene(IAmorous game) : base(game)
	{
		AddSpriteLayer("Background", "Assets/Scenes/GameStore/Game store BG", 0, 0);
		FadingMediaPlayer.PlayOnRepeat(AmorousData.FlyinTrack, 0.4f);
	}
}
