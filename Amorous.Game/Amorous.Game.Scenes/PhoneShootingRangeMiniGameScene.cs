namespace Amorous.Game.Scenes;

public class PhoneShootingRangeMiniGameScene : ShootingRangeMiniGameScene
{
	public PhoneShootingRangeMiniGameScene(IAmorous game)
		: base(game)
	{
		base.ExitWhenEscape = true;
	}

	protected override void Exit()
	{
		base.Game.StartScene<BedroomScene>();
	}
}
