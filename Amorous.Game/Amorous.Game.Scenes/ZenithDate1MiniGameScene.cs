namespace Amorous.Game.Scenes;

public class ZenithDate1MiniGameScene : ShootingRangeMiniGameScene
{
	public ZenithDate1MiniGameScene(IAmorous game)
		: base(game) {}

	protected override void Exit()
	{
		base.Game.SwitchToScene<ZenithDate1PostMiniGameScene>();
	}
}
