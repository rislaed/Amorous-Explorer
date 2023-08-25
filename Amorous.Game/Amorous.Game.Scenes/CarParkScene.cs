namespace Amorous.Game.Scenes;

public class CarParkScene : AbstractScene
{
	public CarParkScene(IAmorous game) : base(game)
	{
		AddSpriteLayer("Background", "Assets/Scenes/CarPark/Car Park Background", 0, 0);
		FadingMediaPlayer.PlayOnRepeat(AmorousData.InAFingerBlinkTrack, 0.4f);
	}
}
