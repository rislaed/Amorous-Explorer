namespace Amorous.Game.Scenes;

public class ClubLoungeElevatorScene : AbstractScene
{
	public ClubLoungeElevatorScene(IAmorous game)
		: base(game)
	{
		AddSpriteLayer("Background", "Assets/Scenes/ClubLoungeElevator/elevator BG", 0, 0);
		FadingMediaPlayer.Play(AmorousData.ClubTracks, 0.4f, repeat: true, oneOf: true);
	}
}
