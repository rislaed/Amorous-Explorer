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
		List<int> list = default(List<int>);
		List<int> list2 = default(List<int>);
		while (true)
		{
			int num = -2099997372;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA08BA653u) % 7u)
				{
				case 5u:
					_NGOOUGHxCQRJ95YqBGvCZoDVi1K = SkyGazeScene.smethod_14((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, _003CModule_003E.smethod_27<string>(1971830539u), _003CModule_003E.smethod_28<string>(3508754835u), list[0], list2[0]);
					num = ((int)num2 * -1639221724) ^ -1643866171;
					continue;
				case 4u:
					_5ucKPpTFNOSSSAiQwUdMbhUYRPC = SkyGazeScene.smethod_14((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, _003CModule_003E.smethod_28<string>(1250217899u), _003CModule_003E.smethod_27<string>(1975447793u), list[1], list2[1]);
					num = (int)(num2 * 1608653837) ^ -279214624;
					continue;
				case 3u:
					SkyGazeScene.smethod_14((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, _003CModule_003E.smethod_27<string>(3171999506u), _003CModule_003E.smethod_26<string>(2675280909u), 0, 0);
					num = (int)((num2 * 1661157880) ^ 0x6F483F1A);
					continue;
				case 2u:
					list = new List<int>
					{
						SkyGazeScene.smethod_15(0, 320),
						SkyGazeScene.smethod_15(640, 960),
						SkyGazeScene.smethod_15(1280, 1600)
					}.OrderBy((int int_0) => _003C_003Ec.smethod_0()).ToList();
					num = -1266790497;
					continue;
				case 1u:
					list2 = new List<int>
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
					num = -142741596;
					continue;
				case 0u:
					break;
				default:
					_6pX8CiiBs3G2EaPqh95VdNHT3tu = SkyGazeScene.smethod_14((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, _003CModule_003E.smethod_28<string>(2325521022u), _003CModule_003E.smethod_27<string>(4128357322u), list[2], list2[2]);
					SkyGazeScene.smethod_16(_003CModule_003E.smethod_26<string>(210443793u), 0.4f);
					return;
				}
				break;
			}
		}
	}

	public override void _tiBFUHPEkedkbgvuX3whdeyjhKo(GameTime gameTime_0)
	{
		this.method_0(gameTime_0);
		TimeSpan timeSpan = SkyGazeScene.smethod_17(gameTime_0);
		float num3 = default(float);
		while (true)
		{
			int num = 1676744232;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x19B393C5u) % 4u)
				{
				case 3u:
					_bjpyoqmBBp7S93le3SbErTR7MMC(_5ucKPpTFNOSSSAiQwUdMbhUYRPC, num3 * (float)_9E0R2wzMPmvJcqYjxpEg08yWHxM[1]);
					_bjpyoqmBBp7S93le3SbErTR7MMC(_6pX8CiiBs3G2EaPqh95VdNHT3tu, num3 * (float)_9E0R2wzMPmvJcqYjxpEg08yWHxM[2]);
					num = (int)((num2 * 1895837876) ^ 0x19B2AF31);
					continue;
				case 1u:
					num3 = (float)timeSpan.Milliseconds / 1000f;
					_bjpyoqmBBp7S93le3SbErTR7MMC(_NGOOUGHxCQRJ95YqBGvCZoDVi1K, num3 * (float)_9E0R2wzMPmvJcqYjxpEg08yWHxM[0]);
					num = ((int)num2 * -1479152827) ^ 0x2F56EF37;
					continue;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	private void _bjpyoqmBBp7S93le3SbErTR7MMC(_ujAkjlfN5TywwbLAUDzPvtab6uJ _ujAkjlfN5TywwbLAUDzPvtab6uJ_0, float float_0)
	{
		SkyGazeScene.smethod_19(_ujAkjlfN5TywwbLAUDzPvtab6uJ_0, SkyGazeScene.smethod_18(_ujAkjlfN5TywwbLAUDzPvtab6uJ_0) - float_0);
		while (true)
		{
			int num = -281299783;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEF69E1F4u) % 4u)
				{
				case 2u:
					SkyGazeScene.smethod_19(_ujAkjlfN5TywwbLAUDzPvtab6uJ_0, 1920f);
					num = (int)(num2 * 1000891686) ^ -1520674917;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (SkyGazeScene.smethod_18(_ujAkjlfN5TywwbLAUDzPvtab6uJ_0) + (float)SkyGazeScene.smethod_20(_ujAkjlfN5TywwbLAUDzPvtab6uJ_0) < 0f)
					{
						num3 = -537143685;
						num4 = -537143685;
					}
					else
					{
						num3 = -428559474;
						num4 = -428559474;
					}
					num = num3 ^ (int)(num2 * 2128426629);
					continue;
				}
				default:
					return;
				case 0u:
					break;
				case 3u:
					return;
				}
				break;
			}
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
