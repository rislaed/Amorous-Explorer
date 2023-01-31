using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;

namespace Amorous.Game.Scenes;

public class SkyGazeScene : AbstractScene
{
	private readonly List<int> _offsets;
	private readonly AbstractLayer _cloud1;
	private readonly AbstractLayer _cloud2;
	private readonly AbstractLayer _cloud3;

	public SkyGazeScene(IAmorous game)
		: base(game)
	{
		AddSpriteLayer("Background", "Assets/Scenes/SkyGaze/Background", 0, 0);
		List<int> x = new List<int>
		{
			Utils.Random(0, 320),
			Utils.Random(640, 960),
			Utils.Random(1280, 1600)
		}.OrderBy((int value) => Utils.Random()).ToList();
		List<int> y = new List<int>
		{
			Utils.Random(0, 20),
			Utils.Random(140, 160),
			Utils.Random(280, 300)
		}.OrderBy((int int_0) => Utils.Random()).ToList();
		_offsets = new List<int>
		{
			Utils.Random(5, 25),
			Utils.Random(5, 25),
			Utils.Random(5, 25)
		};
		_cloud1 = AddSpriteLayer("Cloud1", "Assets/Scenes/SkyGaze/Cloud1", x[0], y[0]);
		_cloud2 = AddSpriteLayer("Cloud2", "Assets/Scenes/SkyGaze/Cloud2", x[1], y[1]);
		_cloud3 = AddSpriteLayer("Cloud3", "Assets/Scenes/SkyGaze/Cloud3", x[2], y[2]);
		FadingMediaPlayer.PlayOnRepeat(AmorousData.SimulateTrack, 0.4f);
	}

	public override void Update(GameTime gameTime)
	{
		base.Update(gameTime);
		float ticks = (float)gameTime.ElapsedGameTime.Milliseconds / 1000f;
		UpdatePosition(_cloud1, ticks * (float)_offsets[0]);
		UpdatePosition(_cloud2, ticks * (float)_offsets[1]);
		UpdatePosition(_cloud3, ticks * (float)_offsets[2]);
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
