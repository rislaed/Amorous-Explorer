using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;

namespace Amorous.Game.Scenes;

public class SkyGazeScene : AbstractScene
{
	private readonly List<int> offsetsOfClouds;
	private readonly AbstractLayer cloudFirstLayer;
	private readonly AbstractLayer cloudSecondLayer;
	private readonly AbstractLayer cloudThirdLayer;

	public SkyGazeScene(IAmorous game) : base(game)
	{
		AddSpriteLayer("Background", "Assets/Scenes/SkyGaze/Background", 0, 0);
		List<int> xs = new List<int>
		{
			Utils.Random(0, 320),
			Utils.Random(640, 960),
			Utils.Random(1280, 1600)
		}.OrderBy((int value) => Utils.Random()).ToList();
		List<int> ys = new List<int>
		{
			Utils.Random(0, 20),
			Utils.Random(140, 160),
			Utils.Random(280, 300)
		}.OrderBy((_) => Utils.Random()).ToList();
		offsetsOfClouds = new List<int>
		{
			Utils.Random(5, 25),
			Utils.Random(5, 25),
			Utils.Random(5, 25)
		};
		cloudFirstLayer = AddSpriteLayer("Cloud1", "Assets/Scenes/SkyGaze/Cloud1", xs[0], ys[0]);
		cloudSecondLayer = AddSpriteLayer("Cloud2", "Assets/Scenes/SkyGaze/Cloud2", xs[1], ys[1]);
		cloudThirdLayer = AddSpriteLayer("Cloud3", "Assets/Scenes/SkyGaze/Cloud3", xs[2], ys[2]);
		FadingMediaPlayer.PlayOnRepeat(AmorousData.SimulateTrack, 0.4f);
	}

	public override void Update(GameTime gameTime)
	{
		base.Update(gameTime);
		float ticks = (float)gameTime.ElapsedGameTime.Milliseconds / 1000f;
		UpdatePosition(cloudFirstLayer, ticks * (float)offsetsOfClouds[0]);
		UpdatePosition(cloudSecondLayer, ticks * (float)offsetsOfClouds[1]);
		UpdatePosition(cloudThirdLayer, ticks * (float)offsetsOfClouds[2]);
	}

	private void UpdatePosition(AbstractLayer layer, float offset)
	{
		layer.X -= offset;
		if (layer.X + (float)layer.Width < 0f)
		{
			layer.X = 1920f;
		}
	}
}
