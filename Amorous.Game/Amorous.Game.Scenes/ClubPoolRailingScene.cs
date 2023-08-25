namespace Amorous.Game.Scenes;

public class ClubPoolRailingScene : AbstractScene
{
	public ClubPoolRailingScene(IAmorous game) : base(game)
	{
		AddSpriteLayer("Background", "Assets/Scenes/ClubPoolRailing/Background", 0, 0);
		FadingMediaPlayer.Play(AmorousData.ClubTracks, 0.4f, repeat: true, oneOf: true);
	}
}
