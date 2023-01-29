namespace Amorous.Game.Scenes;

public class BuildingOutsideScene : AbstractScene
{
	public BuildingOutsideScene(IAmorous game)
		: base(game)
	{
		AddTexturedLayer("Background", "Assets/Scenes/BuildingOutside/Background", 0, 0);
		FadingMediaPlayer.PlayOnRepeat(AmorousData.SimulateTrack, 0.4f);
	}
}
