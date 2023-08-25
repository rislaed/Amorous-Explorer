namespace Amorous.Game.Scenes;

public class ClubInsideDJBoothScene : AbstractScene
{
	public ClubInsideDJBoothScene(IAmorous game) : base(game)
	{
		AddSpriteLayer("Background", "Assets/Scenes/ClubInsideDJBooth/Background", 0, 0);
		FadingMediaPlayer.Play(AmorousData.ClubTracks, 0.4f, repeat: true, oneOf: true);
	}
}
