namespace Amorous.Game.Scenes;

public class BuildingOutsideScene : AbstractScene
{
	public BuildingOutsideScene(IAmorous game)
		: base(game)
	{
		AddTexturedLayer("Background", "Assets/Scenes/BuildingOutside/Background", 0, 0);
		FadingMediaPlayer._l94kUraQ13OohoVwwxKC37hG7Pc("Assets/Music/DJ-ZEK - Simulate", 0.4f);
	}
}
