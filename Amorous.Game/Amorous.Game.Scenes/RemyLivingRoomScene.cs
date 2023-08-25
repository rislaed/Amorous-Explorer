namespace Amorous.Game.Scenes;

public class RemyLivingRoomScene : TimeOfDayScene
{
	public RemyLivingRoomScene(IAmorous game) : base(game)
	{
		AddSpriteLayer("Background", "Assets/Scenes/RemyLivingRoom/Background", 0, 0);
	}
}
