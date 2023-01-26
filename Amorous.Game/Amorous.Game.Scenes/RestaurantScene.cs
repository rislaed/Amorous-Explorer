namespace Amorous.Game.Scenes;

public class RestaurantScene : AbstractScene
{
	public RestaurantScene(IAmorous game)
		: base(game)
	{
		AddTexturedLayer("Background", "Assets/Scenes/Restaurant/Background", 0, 0);
		AddForegroundTexturedLayer("Bar", "Assets/Scenes/Restaurant/Table", 0, 0);
		_UmxbIbk7pgaod0bD7pS309P3Lns._l94kUraQ13OohoVwwxKC37hG7Pc("Assets/Music/Steampianist - O Morro Nao Tem Vez", 0.4f);
	}
}
