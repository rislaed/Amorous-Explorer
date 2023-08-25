namespace Amorous.Game.Scenes;

public class BuildingInsideScene : AbstractScene
{
	public BuildingInsideScene(IAmorous game) : base(game)
	{
		AddSpriteLayer("Background", "Assets/Scenes/BuildingInside/Background", 0, 0);
		FadingMediaPlayer.PlayOnRepeat(AmorousData.SimulateTrack, 0.4f);
	}
}
