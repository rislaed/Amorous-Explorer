namespace Amorous.Game.Scenes;

public class BedsideScene : TimeOfDayScene
{
	public BedsideScene(IAmorous game)
		: base(game)
	{
		AddTexturedLayer("Background", "Assets/Scenes/Bedside/Background", 0, 0);
		FadingMediaPlayer._l94kUraQ13OohoVwwxKC37hG7Pc("Assets/Music/DanMasterFlash - Sun Funk", 0.4f);
	}
}
