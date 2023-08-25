namespace Amorous.Game.Scenes;

public class BedsideScene : TimeOfDayScene
{
	public BedsideScene(IAmorous game) : base(game)
	{
		AddSpriteLayer("Background", "Assets/Scenes/Bedside/Background", 0, 0);
		FadingMediaPlayer.PlayOnRepeat(AmorousData.SunFunkTrack, 0.4f);
	}
}
