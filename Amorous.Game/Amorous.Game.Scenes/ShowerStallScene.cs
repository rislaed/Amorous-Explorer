namespace Amorous.Game.Scenes;

public class ShowerStallScene : AbstractScene
{
	public ShowerStallScene(IAmorous game)
		: base(game)
	{
		AddTexturedLayer("Background", "Assets/Scenes/ShowerStall/Background", 0, 0);
		FadingMediaPlayer.PlayOnRepeat(AmorousData.FlyinTrack, 0.4f);
	}
}
