namespace Amorous.Game.Scenes;

public class BuildingRoofScene : AbstractScene
{
	public BuildingRoofScene(IAmorous game)
		: base(game)
	{
		AddSpriteLayer("Background", "Assets/Scenes/BuildingRoof/Background", 0, 0);
		FadingMediaPlayer.PlayOnRepeat(AmorousData.SimulateTrack, 0.4f);
	}
}
