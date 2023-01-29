namespace Amorous.Game.Scenes;

public class PicknickScene : TimeOfDayScene
{
	public PicknickScene(IAmorous game)
		: base(game)
	{
		AddSpriteLayer("Background", "Assets/SexScenes/Jax/Background", 0, 0);
	}
}
