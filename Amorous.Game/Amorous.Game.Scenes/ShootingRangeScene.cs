namespace Amorous.Game.Scenes;

public class ShootingRangeScene : AbstractScene
{
	public ShootingRangeScene(IAmorous game)
		: base(game)
	{
		AddTexturedLayer("Backdrop", "Assets/Scenes/ShootingRange/Backdrop", 600, 180);
		AddTexturedLayer("Background", "Assets/Scenes/ShootingRange/Background", 0, 0);
		AddTexturedLayer("Countertop", "Assets/Scenes/ShootingRange/Countertop", 0, 0);
		FadingMediaPlayer.PlayOnRepeat(AmorousData.MechTrack, 0.4f);
	}
}
