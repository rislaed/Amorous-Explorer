namespace Amorous.Game.Scenes;

public class ZenithDate1PostMiniGameScene : AbstractScene
{
	public ZenithDate1PostMiniGameScene(IAmorous game)
		: base(game) {}

	public override void Begin()
	{
		base.Game.StartCutscene(AmorousData.ZenithDate);
	}
}
