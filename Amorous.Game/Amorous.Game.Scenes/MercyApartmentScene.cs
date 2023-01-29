namespace Amorous.Game.Scenes;

public class MercyApartmentScene : TimeOfDayScene
{
	public MercyApartmentScene(IAmorous game)
		: base(game)
	{
		AddSpriteLayer("Background", "Assets/Scenes/MercyApartment/Background", 0, 0);
		FadingMediaPlayer.PlayOnRepeat(AmorousData.SunFunkTrack, 0.4f);
	}
}
