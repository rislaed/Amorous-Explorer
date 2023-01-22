using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;

namespace Amorous.Game.Scenes;

public class SkyGazeScene : _7UlnfykmEmZDFt3BmCKZekI43Ih
{
	private readonly List<int> _9E0R2wzMPmvJcqYjxpEg08yWHxM;

	private readonly _ujAkjlfN5TywwbLAUDzPvtab6uJ _NGOOUGHxCQRJ95YqBGvCZoDVi1K;

	private readonly _ujAkjlfN5TywwbLAUDzPvtab6uJ _5ucKPpTFNOSSSAiQwUdMbhUYRPC;

	private readonly _ujAkjlfN5TywwbLAUDzPvtab6uJ _6pX8CiiBs3G2EaPqh95VdNHT3tu;

	public SkyGazeScene(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		SkyGazeScene.smethod_14((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Background", "Assets/Scenes/SkyGaze/Background", 0, 0);
		List<int> list = new List<int>
		{
			SkyGazeScene.smethod_15(0, 320),
			SkyGazeScene.smethod_15(640, 960),
			SkyGazeScene.smethod_15(1280, 1600)
		}.OrderBy((int int_0) => _003C_003Ec.smethod_0()).ToList();
		List<int> list2 = new List<int>
		{
			SkyGazeScene.smethod_15(0, 20),
			SkyGazeScene.smethod_15(140, 160),
			SkyGazeScene.smethod_15(280, 300)
		}.OrderBy((int int_0) => _003C_003Ec.smethod_0()).ToList();
		_9E0R2wzMPmvJcqYjxpEg08yWHxM = new List<int>
		{
			SkyGazeScene.smethod_15(5, 25),
			SkyGazeScene.smethod_15(5, 25),
			SkyGazeScene.smethod_15(5, 25)
		};
		_NGOOUGHxCQRJ95YqBGvCZoDVi1K = SkyGazeScene.smethod_14((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Cloud1", "Assets/Scenes/SkyGaze/Cloud1", list[0], list2[0]);
		_5ucKPpTFNOSSSAiQwUdMbhUYRPC = SkyGazeScene.smethod_14((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Cloud2", "Assets/Scenes/SkyGaze/Cloud2", list[1], list2[1]);
		_6pX8CiiBs3G2EaPqh95VdNHT3tu = SkyGazeScene.smethod_14((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Cloud3", "Assets/Scenes/SkyGaze/Cloud3", list[2], list2[2]);
		SkyGazeScene.smethod_16("Assets/Music/DJ-ZEK - Simulate", 0.4f);
	}

	public override void _tiBFUHPEkedkbgvuX3whdeyjhKo(GameTime gameTime_0)
	{
		this.method_0(gameTime_0);
		float num = (float)SkyGazeScene.smethod_17(gameTime_0).Milliseconds / 1000f;
		_bjpyoqmBBp7S93le3SbErTR7MMC(_NGOOUGHxCQRJ95YqBGvCZoDVi1K, num * (float)_9E0R2wzMPmvJcqYjxpEg08yWHxM[0]);
		_bjpyoqmBBp7S93le3SbErTR7MMC(_5ucKPpTFNOSSSAiQwUdMbhUYRPC, num * (float)_9E0R2wzMPmvJcqYjxpEg08yWHxM[1]);
		_bjpyoqmBBp7S93le3SbErTR7MMC(_6pX8CiiBs3G2EaPqh95VdNHT3tu, num * (float)_9E0R2wzMPmvJcqYjxpEg08yWHxM[2]);
	}

	private void _bjpyoqmBBp7S93le3SbErTR7MMC(_ujAkjlfN5TywwbLAUDzPvtab6uJ _ujAkjlfN5TywwbLAUDzPvtab6uJ_0, float float_0)
	{
		SkyGazeScene.smethod_19(_ujAkjlfN5TywwbLAUDzPvtab6uJ_0, SkyGazeScene.smethod_18(_ujAkjlfN5TywwbLAUDzPvtab6uJ_0) - float_0);
		if (SkyGazeScene.smethod_18(_ujAkjlfN5TywwbLAUDzPvtab6uJ_0) + (float)SkyGazeScene.smethod_20(_ujAkjlfN5TywwbLAUDzPvtab6uJ_0) < 0f)
		{
			SkyGazeScene.smethod_19(_ujAkjlfN5TywwbLAUDzPvtab6uJ_0, 1920f);
		}
	}

	static _uqydQVaCmCvK7zzWs5W4gZFpKBu smethod_14(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0, string string_0, string string_1, int int_0, int int_1)
	{
		return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._0O8D0mBgmrh0sLOGcLVvGNOHKLCA(string_0, string_1, int_0, int_1);
	}

	static int smethod_15(int int_0, int int_1)
	{
		return _boyt8NIMtKsAGSTcjHeL0WMbFxs._07xTWbIEgzxJYsYwFKDbbKNvu4G(int_0, int_1);
	}

	static void smethod_16(string string_0, float float_0)
	{
		_UmxbIbk7pgaod0bD7pS309P3Lns._l94kUraQ13OohoVwwxKC37hG7Pc(string_0, float_0);
	}

	void method_0(GameTime gameTime_0)
	{
		base._tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime_0);
	}

	static TimeSpan smethod_17(GameTime gameTime_0)
	{
		return gameTime_0.get_ElapsedGameTime();
	}

	static float smethod_18(_ujAkjlfN5TywwbLAUDzPvtab6uJ _ujAkjlfN5TywwbLAUDzPvtab6uJ_0)
	{
		return _ujAkjlfN5TywwbLAUDzPvtab6uJ_0._7Xn1C5tjYnmIif1iZKV8AWsEEbL;
	}

	static void smethod_19(_ujAkjlfN5TywwbLAUDzPvtab6uJ _ujAkjlfN5TywwbLAUDzPvtab6uJ_0, float float_0)
	{
		_ujAkjlfN5TywwbLAUDzPvtab6uJ_0._7Xn1C5tjYnmIif1iZKV8AWsEEbL = float_0;
	}

	static int smethod_20(_ujAkjlfN5TywwbLAUDzPvtab6uJ _ujAkjlfN5TywwbLAUDzPvtab6uJ_0)
	{
		return _ujAkjlfN5TywwbLAUDzPvtab6uJ_0._je8rVfyg4zywmqSi4Ozx1z7wJ4b;
	}
}
