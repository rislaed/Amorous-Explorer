namespace Amorous.Game.Scenes;

public class SethApartmentScene : TimeOfDayScene
{
	public SethApartmentScene(IAmorous game)
		: base(game)
	{
		AddTexturedLayer("Background", "Assets/Scenes/SethApartment/Background", 0, 0);
		FadingMediaPlayer._l94kUraQ13OohoVwwxKC37hG7Pc("Assets/Music/Father-of-Death - Happy Jazz Shit", 0.4f);
	}
}
