namespace Amorous.Game.Scenes;

public class ClubBoothScene : AbstractScene
{
	public ClubBoothScene(IAmorous game)
		: base(game)
	{
		AddTexturedLayer("Background", "Assets/Scenes/ClubBooth/Background booth", 0, 0);
		AddForegroundTexturedLayer("Table", "Assets/Scenes/ClubBooth/Background booth table", 0, 0);
		FadingMediaPlayer.Play(AmorousData.ClubTracks, 0.4f, repeat: true, oneOf: true);
	}
}
