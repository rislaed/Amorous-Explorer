namespace Amorous.Game.Scenes;

public class JaxApartmentScene : TimeOfDayScene
{
	public JaxApartmentScene(IAmorous game)
		: base(game)
	{
		AddSpriteLayer("Background", "Assets/Scenes/JaxApartment/jax background apartment", 0, 0);
		FadingMediaPlayer.PlayOnRepeat(AmorousData.SunFunkTrack, 0.4f);
	}
}
