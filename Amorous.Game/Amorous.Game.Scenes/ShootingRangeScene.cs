namespace Amorous.Game.Scenes;

public class ShootingRangeScene : AbstractScene
{
	public ShootingRangeScene(IAmorous game)
		: base(game)
	{
		AddTexturedLayer("Backdrop", "Assets/Scenes/ShootingRange/Backdrop", 600, 180);
		AddTexturedLayer("Background", "Assets/Scenes/ShootingRange/Background", 0, 0);
		AddTexturedLayer("Countertop", "Assets/Scenes/ShootingRange/Countertop", 0, 0);
		FadingMediaPlayer._l94kUraQ13OohoVwwxKC37hG7Pc("Assets/Music/Mittsies - Mech", 0.4f);
	}
}
