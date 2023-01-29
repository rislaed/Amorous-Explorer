namespace Amorous.Game.Scenes;

public class CinemaLobbyScene : AbstractScene
{
	public CinemaLobbyScene(IAmorous game)
		: base(game)
	{
		AddTexturedLayer("Background", "Assets/Scenes/CinemaLobby/Cinema Lobby", 0, 0);
		FadingMediaPlayer.PlayOnRepeat(AmorousData.SimulateTrack, 0.4f);
	}
}
