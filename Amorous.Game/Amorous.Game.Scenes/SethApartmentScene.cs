namespace Amorous.Game.Scenes;

public class SethApartmentScene : TimeOfDayScene
{
	public SethApartmentScene(IAmorous game)
		: base(game)
	{
		AddSpriteLayer("Background", "Assets/Scenes/SethApartment/Background", 0, 0);
		FadingMediaPlayer.PlayOnRepeat(AmorousData.HappyJazzShitTrack, 0.4f);
	}
}
