namespace Amorous.Game.Scenes;

public class ZenithDate1MiniGameScene : ShootingRangeMiniGameScene
{
	public ZenithDate1MiniGameScene(IAmorous game)
		: base(game) {}

	protected override void _5Z9jaXDcRYm0wNlEm1aTutL9kSH()
	{
		base.Game.SwitchToScene<ZenithDate1PostMiniGameScene>();
	}
}
