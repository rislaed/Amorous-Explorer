namespace Amorous.Game.Scenes;

public class CinemaLobbyScene : AbstractScene
{
	public CinemaLobbyScene(IAmorous game)
		: base(game)
	{
		AddTexturedLayer("Background", "Assets/Scenes/CinemaLobby/Cinema Lobby", 0, 0);
		_UmxbIbk7pgaod0bD7pS309P3Lns._l94kUraQ13OohoVwwxKC37hG7Pc("Assets/Music/DJ-ZEK - Simulate", 0.4f);
	}
}
