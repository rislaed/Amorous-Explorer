using Microsoft.Xna.Framework;

namespace Amorous.Game.Scenes;

public class ClubPoolWaterScene : AbstractScene
{
	public ClubPoolWaterScene(IAmorous game)
		: base(game)
	{
		AddTexturedLayer("Background", "Assets/Scenes/ClubPoolWater/Background", 0, 0);
		ClubPoolWaterSpineLayer waterLeft = new ClubPoolWaterSpineLayer(this, 700f, new Rectangle(0, -190, 1920, 1080), inversed: true)
		{
			OffsetX = 600f,
			OffsetY = 750f,
			Scale = 2f
		};
		ClubPoolWaterSpineLayer waterRight = new ClubPoolWaterSpineLayer(this, 700f, new Rectangle(0, 0, 1920, 1080), inversed: true)
		{
			OffsetX = 1200f,
			OffsetY = 750f,
			Scale = 2f
		};
		AddLayer(waterLeft, 0);
		AddLayer(waterRight, 2);
		FadingMediaPlayer.Play(AmorousData.ClubTracks, 0.4f, repeat: true, oneOf: true);
	}
}
