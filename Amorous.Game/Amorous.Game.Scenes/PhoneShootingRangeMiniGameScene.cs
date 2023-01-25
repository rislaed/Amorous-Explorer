namespace Amorous.Game.Scenes;

public class PhoneShootingRangeMiniGameScene : ShootingRangeMiniGameScene
{
	public PhoneShootingRangeMiniGameScene(IAmorous game)
		: base(Game)
	{
		base._F2ao1gdMb4UciyKC7Zly4by95Mn = true;
	}

	protected override void _5Z9jaXDcRYm0wNlEm1aTutL9kSH()
	{
		base.Game.StartScene<BedroomScene>();
	}
}
