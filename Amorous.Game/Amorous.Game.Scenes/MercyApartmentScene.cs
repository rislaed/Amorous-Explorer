namespace Amorous.Game.Scenes;

public class MercyApartmentScene : TimeOfDayScene
{
	public MercyApartmentScene(IAmorous game)
		: base(game)
	{
		AddTexturedLayer("Background", "Assets/Scenes/MercyApartment/Background", 0, 0);
		FadingMediaPlayer._l94kUraQ13OohoVwwxKC37hG7Pc("Assets/Music/DanMasterFlash - Sun Funk", 0.4f);
	}
}
