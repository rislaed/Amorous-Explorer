namespace Amorous.Game.Scenes;

public class ClubUpstairsStaffRoomScene : AbstractScene
{
	public ClubUpstairsStaffRoomScene(IAmorous game)
		: base(game)
	{
		AddTexturedLayer("Background", "Assets/Scenes/ClubUpstairsStaffRoom/Background", 0, 0);
		FadingMediaPlayer.Play(AmorousData.ClubTracks, 0.4f, repeat: true, oneOf: true);
	}
}
