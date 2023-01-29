using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;

namespace Amorous.Game.Scenes;

public class SkyGazeScene : AbstractScene
{
	private readonly List<int> _9E0R2wzMPmvJcqYjxpEg08yWHxM;

	private readonly AbstractLayer _NGOOUGHxCQRJ95YqBGvCZoDVi1K;

	private readonly AbstractLayer _5ucKPpTFNOSSSAiQwUdMbhUYRPC;

	private readonly AbstractLayer _6pX8CiiBs3G2EaPqh95VdNHT3tu;

	public SkyGazeScene(IAmorous game)
		: base(game)
	{
		AddSpriteLayer("Background", "Assets/Scenes/SkyGaze/Background", 0, 0);
		List<int> list = new List<int>
		{
			Randoms.Next(0, 320),
			Randoms.Next(640, 960),
			Randoms.Next(1280, 1600)
		}.OrderBy((int int_0) => Randoms.Next()).ToList();
		List<int> list2 = new List<int>
		{
			Randoms.Next(0, 20),
			Randoms.Next(140, 160),
			Randoms.Next(280, 300)
		}.OrderBy((int int_0) => Randoms.Next()).ToList();
		_9E0R2wzMPmvJcqYjxpEg08yWHxM = new List<int>
		{
			Randoms.Next(5, 25),
			Randoms.Next(5, 25),
			Randoms.Next(5, 25)
		};
		_NGOOUGHxCQRJ95YqBGvCZoDVi1K = AddSpriteLayer("Cloud1", "Assets/Scenes/SkyGaze/Cloud1", list[0], list2[0]);
		_5ucKPpTFNOSSSAiQwUdMbhUYRPC = AddSpriteLayer("Cloud2", "Assets/Scenes/SkyGaze/Cloud2", list[1], list2[1]);
		_6pX8CiiBs3G2EaPqh95VdNHT3tu = AddSpriteLayer("Cloud3", "Assets/Scenes/SkyGaze/Cloud3", list[2], list2[2]);
		FadingMediaPlayer.PlayOnRepeat(AmorousData.SimulateTrack, 0.4f);
	}

	public override void Update(GameTime gameTime)
	{
		base.Update(gameTime);
		float num = (float)gameTime.ElapsedGameTime.Milliseconds / 1000f;
		_bjpyoqmBBp7S93le3SbErTR7MMC(_NGOOUGHxCQRJ95YqBGvCZoDVi1K, num * (float)_9E0R2wzMPmvJcqYjxpEg08yWHxM[0]);
		_bjpyoqmBBp7S93le3SbErTR7MMC(_5ucKPpTFNOSSSAiQwUdMbhUYRPC, num * (float)_9E0R2wzMPmvJcqYjxpEg08yWHxM[1]);
		_bjpyoqmBBp7S93le3SbErTR7MMC(_6pX8CiiBs3G2EaPqh95VdNHT3tu, num * (float)_9E0R2wzMPmvJcqYjxpEg08yWHxM[2]);
	}

	private void _bjpyoqmBBp7S93le3SbErTR7MMC(AbstractLayer layer, float float_0)
	{
		layer.X -= float_0;
		if (layer.X + (float)layer.Width < 0f)
		{
			layer.X = 1920f;
		}
	}
}
