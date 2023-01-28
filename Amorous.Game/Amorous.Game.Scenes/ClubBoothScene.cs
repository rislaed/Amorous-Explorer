namespace Amorous.Game.Scenes;

public class ClubBoothScene : AbstractScene
{
	public ClubBoothScene(IAmorous game)
		: base(game)
	{
		AddTexturedLayer("Background", "Assets/Scenes/ClubBooth/Background booth", 0, 0);
		AddForegroundTexturedLayer("Table", "Assets/Scenes/ClubBooth/Background booth table", 0, 0);
		FadingMediaPlayer._QrgbXEg7MMeD9Ybz12fFVsbmAd9(_KZ7hNP1K5E99Xfup1lTZ9UDrxPE._oCy13KHJxLHriH7TwMiQ1qKJ8Uc, 0.4f, repeat: true, oneOf: true);
	}
}
