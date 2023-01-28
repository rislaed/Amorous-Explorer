namespace Amorous.Game.Scenes;

public class BuildingInsideScene : AbstractScene
{
	public BuildingInsideScene(IAmorous game)
		: base(game)
	{
		AddTexturedLayer("Background", "Assets/Scenes/BuildingInside/Background", 0, 0);
		FadingMediaPlayer._l94kUraQ13OohoVwwxKC37hG7Pc("Assets/Music/DJ-ZEK - Simulate", 0.4f);
	}
}
