namespace Amorous.Game.Scenes;

public class SpaScene : AbstractScene
{
	public SpaScene(IAmorous game)
		: base(game)
	{
		AddTexturedLayer("Background", "Assets/Scenes/Spa/Background", 0, 0);
		_UmxbIbk7pgaod0bD7pS309P3Lns._l94kUraQ13OohoVwwxKC37hG7Pc("Assets/Music/Rekuiem - Flyin", 0.4f);
	}
}
