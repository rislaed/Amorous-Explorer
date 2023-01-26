namespace Amorous.Game.Scenes;

public class RemyLivingRoomScene : TimeOfDayScene
{
	public RemyLivingRoomScene(IAmorous game)
		: base(game)
	{
		AddTexturedLayer("Background", "Assets/Scenes/RemyLivingRoom/Background", 0, 0);
	}
}
