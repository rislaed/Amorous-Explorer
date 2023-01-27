namespace Amorous.Game.Scenes;

public class ZenithDate3ABScene : AbstractScene
{
	public ZenithDate3ABScene(IAmorous game)
		: base(game)
	{
	}

	public override void StopCutscene()
	{
		base.Game.RequestScene("ZenithDate");
	}
}
