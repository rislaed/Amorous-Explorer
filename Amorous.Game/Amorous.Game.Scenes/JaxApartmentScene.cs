namespace Amorous.Game.Scenes;

public class JaxApartmentScene : TimeOfDayScene
{
	public JaxApartmentScene(IAmorous game)
		: base(game)
	{
		AddTexturedLayer("Background", "Assets/Scenes/JaxApartment/jax background apartment", 0, 0);
		FadingMediaPlayer._l94kUraQ13OohoVwwxKC37hG7Pc("Assets/Music/DanMasterFlash - Sun Funk", 0.4f);
	}
}
