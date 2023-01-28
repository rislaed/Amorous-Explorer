namespace Amorous.Game.Scenes;

public class AquariumScene : AbstractScene
{
	public AquariumScene(IAmorous game)
		: base(game)
	{
		AddTexturedLayer("Background", "Assets/Scenes/Aquarium/Background", 0, 0);
		FadingMediaPlayer._l94kUraQ13OohoVwwxKC37hG7Pc("Assets/Music/Hopeku - In A Finger Blink", 0.4f);
	}
}
