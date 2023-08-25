namespace Amorous.Game.Scenes;

public class AquariumScene : AbstractScene
{
	public AquariumScene(IAmorous game) : base(game)
	{
		AddSpriteLayer("Background", "Assets/Scenes/Aquarium/Background", 0, 0);
		FadingMediaPlayer.PlayOnRepeat(AmorousData.InAFingerBlinkTrack, 0.4f);
	}
}
