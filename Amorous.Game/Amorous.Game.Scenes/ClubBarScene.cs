namespace Amorous.Game.Scenes;

public class ClubBarScene : AbstractScene
{
	public ClubBarScene(IAmorous game) : base(game)
	{
		AddSpriteLayer("Background", "Assets/Scenes/ClubBar/Base", 0, 0);
		AddSpriteLayerAbove("Bar", "Assets/Scenes/ClubBar/Bar", 0, 0);
		FadingMediaPlayer.Play(AmorousData.ClubTracks, 0.4f, repeat: true, oneOf: true);
	}
}
