using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Spine;

namespace Amorous.Game.Scenes;

public class DrivingScene : _7UlnfykmEmZDFt3BmCKZekI43Ih
{
	public const string _RS0gzIMaA8RvbsLb5OBhWAI8orc = "Sunset";

	public const string _GVrFhyughFuZbNz1GllPUz8qFRC = "Night";

	public const string _3MHNjx9EVkIdQ2cErS7bp0bJSr8A = "Day";

	private const int _B68ctrDW0hRDkXziVHKCjKFP4qOA = 1280;

	private const float _4bHwLPLFG7ngyPTFDFH6R0qj9fE = 0.25f;

	private const float _jKachG4OFgumvh4coAfrPYvYvE6 = 0.5f;

	private const float _tpdb62hWwmsf91RJNNUulTzZfAk = 0.9f;

	private _uqydQVaCmCvK7zzWs5W4gZFpKBu _2WuocFtGsvuqlLRNzg1JvWYdCPu;

	private _uqydQVaCmCvK7zzWs5W4gZFpKBu _keMqzR2MH8pk2eRBjpmBvvHsKkH;

	private _uqydQVaCmCvK7zzWs5W4gZFpKBu _NtI6JcCZUIU6eqmZEqieFBtS51g;

	private readonly _uqydQVaCmCvK7zzWs5W4gZFpKBu[] _cmNp2s95voDHTlRfEo0WKjoNC5D = new _uqydQVaCmCvK7zzWs5W4gZFpKBu[3];

	private int _HuRva9O1Dird7HCHNvEYAhbEXEx;

	private _uqydQVaCmCvK7zzWs5W4gZFpKBu _SwpBYcoXXTll45NBeycIpflE8r;

	private _uqydQVaCmCvK7zzWs5W4gZFpKBu _ywjql7DttUMPriZ95ycoakuivHF;

	private float _rn1x58VMBD9DAD7YIR46LqTEfMP;

	private float _DEdZRCjltS13jKpC2YJkZY838ZK;

	private float _5F3aFNnUdPR4Jd8EFDxoRL2ITlV;

	public DrivingScene(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		while (true)
		{
			int num = 1290639965;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6D2BD5u) % 3u)
				{
				case 1u:
					goto IL_0015;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_0015:
				DrivingScene.smethod_14((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, _003CModule_003E.smethod_28<string>(634338800u));
				DrivingScene.smethod_15(_003CModule_003E.smethod_25<string>(105177312u), 0.4f);
				num = ((int)num2 * -1385853581) ^ 0x6E40CC08;
			}
		}
	}

	public override void _6hE3geqxrB1vCirtSWHxIJjlTQB(string string_0)
	{
		this.method_0(string_0);
		while (true)
		{
			int num = -154937041;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x99F31939u) % 8u)
				{
				case 6u:
					_2WuocFtGsvuqlLRNzg1JvWYdCPu = DrivingScene.smethod_17((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, _003CModule_003E.smethod_27<string>(3171999506u), DrivingScene.smethod_16(_003CModule_003E.smethod_25<string>(2559295306u), string_0, _003CModule_003E.smethod_24<string>(865285858u)), 0, 0);
					_keMqzR2MH8pk2eRBjpmBvvHsKkH = DrivingScene.smethod_17((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, _003CModule_003E.smethod_28<string>(4194768273u), DrivingScene.smethod_16(_003CModule_003E.smethod_24<string>(3144396943u), string_0, _003CModule_003E.smethod_24<string>(2336295798u)), 0, 680);
					num = (int)(num2 * 1776632948) ^ -1680534511;
					continue;
				case 5u:
					_rn1x58VMBD9DAD7YIR46LqTEfMP = DrivingScene.smethod_18(-1920, 0);
					_DEdZRCjltS13jKpC2YJkZY838ZK = DrivingScene.smethod_18(-1920, 0);
					_5F3aFNnUdPR4Jd8EFDxoRL2ITlV = DrivingScene.smethod_18(-1920, 0);
					num = ((int)num2 * -1246216175) ^ -730626040;
					continue;
				case 3u:
					_HuRva9O1Dird7HCHNvEYAhbEXEx = DrivingScene.smethod_18(0, _cmNp2s95voDHTlRfEo0WKjoNC5D.Length - 1);
					_jLqsVc7ZjWokEg8zjm4aue7Vfwr();
					num = ((int)num2 * -1681620836) ^ -1217622160;
					continue;
				case 2u:
					_cmNp2s95voDHTlRfEo0WKjoNC5D[2] = DrivingScene.smethod_17((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, _003CModule_003E.smethod_26<string>(18108931u), DrivingScene.smethod_16(_003CModule_003E.smethod_27<string>(2084840736u), string_0, _003CModule_003E.smethod_27<string>(2571303418u)), 0, 0);
					num = ((int)num2 * -154532391) ^ -1912594648;
					continue;
				case 1u:
					_cmNp2s95voDHTlRfEo0WKjoNC5D[0] = DrivingScene.smethod_17((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, _003CModule_003E.smethod_25<string>(2395767488u), DrivingScene.smethod_16(_003CModule_003E.smethod_27<string>(2084840736u), string_0, _003CModule_003E.smethod_28<string>(3458793267u)), 0, 0);
					_cmNp2s95voDHTlRfEo0WKjoNC5D[1] = DrivingScene.smethod_17((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, _003CModule_003E.smethod_28<string>(4194768273u), DrivingScene.smethod_16(_003CModule_003E.smethod_24<string>(3144396943u), string_0, _003CModule_003E.smethod_28<string>(917939214u)), 0, 0);
					num = (int)((num2 * 684282993) ^ 0x65234C82);
					continue;
				case 0u:
					_NtI6JcCZUIU6eqmZEqieFBtS51g = DrivingScene.smethod_17((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, _003CModule_003E.smethod_28<string>(4194768273u), DrivingScene.smethod_16(_003CModule_003E.smethod_26<string>(2655394997u), string_0, _003CModule_003E.smethod_27<string>(1133618896u)), 0, 0);
					num = (int)((num2 * 1040600061) ^ 0x4A66E160);
					continue;
				default:
					return;
				case 7u:
					break;
				case 4u:
					return;
				}
				break;
			}
		}
	}

	public override void _tiBFUHPEkedkbgvuX3whdeyjhKo(GameTime gameTime_0)
	{
		this.method_1(gameTime_0);
		float num = (float)(1280.0 * DrivingScene.smethod_19(gameTime_0).TotalSeconds);
		while (true)
		{
			int num2 = -1883695315;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x86859E8Cu) % 10u)
				{
				case 8u:
					_rn1x58VMBD9DAD7YIR46LqTEfMP += 3840f;
					num2 = (int)(num3 * 34332350) ^ -799504899;
					continue;
				case 7u:
				{
					_rn1x58VMBD9DAD7YIR46LqTEfMP -= num * 0.25f;
					int num8;
					int num9;
					if (_rn1x58VMBD9DAD7YIR46LqTEfMP < -3840f)
					{
						num8 = -773906580;
						num9 = -773906580;
					}
					else
					{
						num8 = -2066400329;
						num9 = -2066400329;
					}
					num2 = num8 ^ (int)(num3 * 265039086);
					continue;
				}
				case 6u:
					_DEdZRCjltS13jKpC2YJkZY838ZK += 3840f;
					num2 = ((int)num3 * -847098974) ^ 0x172B4DBB;
					continue;
				case 5u:
					_5F3aFNnUdPR4Jd8EFDxoRL2ITlV = 0f;
					_jLqsVc7ZjWokEg8zjm4aue7Vfwr();
					num2 = (int)(num3 * 943574479) ^ -454091363;
					continue;
				case 4u:
				{
					int num6;
					int num7;
					if (_DEdZRCjltS13jKpC2YJkZY838ZK < -3840f)
					{
						num6 = -725653510;
						num7 = -725653510;
					}
					else
					{
						num6 = -1164880825;
						num7 = -1164880825;
					}
					num2 = num6 ^ ((int)num3 * -1907541032);
					continue;
				}
				case 3u:
				{
					int num4;
					int num5;
					if (_5F3aFNnUdPR4Jd8EFDxoRL2ITlV >= -1920f)
					{
						num4 = -515481057;
						num5 = -515481057;
					}
					else
					{
						num4 = -1289400224;
						num5 = -1289400224;
					}
					num2 = num4 ^ ((int)num3 * -1511642133);
					continue;
				}
				case 2u:
					_DEdZRCjltS13jKpC2YJkZY838ZK -= num * 0.9f;
					num2 = -1760046866;
					continue;
				case 1u:
					_5F3aFNnUdPR4Jd8EFDxoRL2ITlV -= num * 0.5f;
					num2 = -1048922049;
					continue;
				default:
					return;
				case 0u:
					break;
				case 9u:
					return;
				}
				break;
			}
		}
	}

	private void _jLqsVc7ZjWokEg8zjm4aue7Vfwr()
	{
		_SwpBYcoXXTll45NBeycIpflE8r = _cmNp2s95voDHTlRfEo0WKjoNC5D[_HuRva9O1Dird7HCHNvEYAhbEXEx];
		while (true)
		{
			int num = -1258663948;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD91CAD68u) % 6u)
				{
				case 4u:
				{
					_HuRva9O1Dird7HCHNvEYAhbEXEx++;
					int num3;
					int num4;
					if (_HuRva9O1Dird7HCHNvEYAhbEXEx >= _cmNp2s95voDHTlRfEo0WKjoNC5D.Length)
					{
						num3 = -1713059088;
						num4 = -1713059088;
					}
					else
					{
						num3 = -1717694073;
						num4 = -1717694073;
					}
					num = num3 ^ (int)(num2 * 892642802);
					continue;
				}
				case 3u:
					_ywjql7DttUMPriZ95ycoakuivHF = _cmNp2s95voDHTlRfEo0WKjoNC5D[_HuRva9O1Dird7HCHNvEYAhbEXEx];
					num = -1658033135;
					continue;
				case 1u:
					DrivingScene.smethod_21(_ywjql7DttUMPriZ95ycoakuivHF, DrivingScene.smethod_20());
					num = ((int)num2 * -604527699) ^ -2111853634;
					continue;
				case 0u:
					_HuRva9O1Dird7HCHNvEYAhbEXEx = 0;
					num = (int)(num2 * 1739291548) ^ -1581069697;
					continue;
				default:
					return;
				case 2u:
					break;
				case 5u:
					return;
				}
				break;
			}
		}
	}

	public override void _f5ctqAmdNsZ889UjM4LxDm8WGxA(SpriteBatch spriteBatch_0, SkeletonMeshRenderer skeletonMeshRenderer_0, Matrix matrix_0)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		this.method_2(spriteBatch_0, skeletonMeshRenderer_0, matrix_0);
		DrivingScene.smethod_22(spriteBatch_0, (SpriteSortMode)0, BlendState.NonPremultiplied, (SamplerState)null, (DepthStencilState)null, (RasterizerState)null, (Effect)null, (Matrix?)null);
		DrivingScene.smethod_23((_ujAkjlfN5TywwbLAUDzPvtab6uJ)_2WuocFtGsvuqlLRNzg1JvWYdCPu, spriteBatch_0);
		while (true)
		{
			int num = -1830524188;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEBBD3F73u) % 16u)
				{
				case 14u:
					DrivingScene.smethod_23((_ujAkjlfN5TywwbLAUDzPvtab6uJ)_NtI6JcCZUIU6eqmZEqieFBtS51g, spriteBatch_0);
					num = ((int)num2 * -669548607) ^ 0x7B200566;
					continue;
				case 13u:
					DrivingScene.smethod_21(_NtI6JcCZUIU6eqmZEqieFBtS51g, bool_0: true);
					DrivingScene.smethod_23((_ujAkjlfN5TywwbLAUDzPvtab6uJ)_NtI6JcCZUIU6eqmZEqieFBtS51g, spriteBatch_0);
					num = ((int)num2 * -2084642962) ^ -1114453167;
					continue;
				case 12u:
					DrivingScene.smethod_21(_keMqzR2MH8pk2eRBjpmBvvHsKkH, bool_0: true);
					DrivingScene.smethod_23((_ujAkjlfN5TywwbLAUDzPvtab6uJ)_keMqzR2MH8pk2eRBjpmBvvHsKkH, spriteBatch_0);
					DrivingScene.smethod_24((_ujAkjlfN5TywwbLAUDzPvtab6uJ)_keMqzR2MH8pk2eRBjpmBvvHsKkH, _rn1x58VMBD9DAD7YIR46LqTEfMP + 3840f);
					DrivingScene.smethod_21(_keMqzR2MH8pk2eRBjpmBvvHsKkH, bool_0: false);
					num = (int)(num2 * 1907871323) ^ -2124366986;
					continue;
				case 11u:
					DrivingScene.smethod_25(spriteBatch_0);
					num = (int)((num2 * 1772891423) ^ 0x17DF631E);
					continue;
				case 10u:
					DrivingScene.smethod_24((_ujAkjlfN5TywwbLAUDzPvtab6uJ)_SwpBYcoXXTll45NBeycIpflE8r, _5F3aFNnUdPR4Jd8EFDxoRL2ITlV);
					num = ((int)num2 * -1514809770) ^ 0x1E583C29;
					continue;
				case 9u:
					DrivingScene.smethod_21(_NtI6JcCZUIU6eqmZEqieFBtS51g, bool_0: false);
					num = ((int)num2 * -1628583070) ^ 0x15437B6F;
					continue;
				case 7u:
					DrivingScene.smethod_24((_ujAkjlfN5TywwbLAUDzPvtab6uJ)_keMqzR2MH8pk2eRBjpmBvvHsKkH, _rn1x58VMBD9DAD7YIR46LqTEfMP);
					DrivingScene.smethod_23((_ujAkjlfN5TywwbLAUDzPvtab6uJ)_keMqzR2MH8pk2eRBjpmBvvHsKkH, spriteBatch_0);
					num = (int)(num2 * 670943917) ^ -2014648040;
					continue;
				case 6u:
					DrivingScene.smethod_24((_ujAkjlfN5TywwbLAUDzPvtab6uJ)_ywjql7DttUMPriZ95ycoakuivHF, _5F3aFNnUdPR4Jd8EFDxoRL2ITlV + 1920f);
					num = ((int)num2 * -1918900396) ^ 0x829F308;
					continue;
				case 5u:
					DrivingScene.smethod_24((_ujAkjlfN5TywwbLAUDzPvtab6uJ)_NtI6JcCZUIU6eqmZEqieFBtS51g, _DEdZRCjltS13jKpC2YJkZY838ZK);
					DrivingScene.smethod_23((_ujAkjlfN5TywwbLAUDzPvtab6uJ)_NtI6JcCZUIU6eqmZEqieFBtS51g, spriteBatch_0);
					DrivingScene.smethod_24((_ujAkjlfN5TywwbLAUDzPvtab6uJ)_NtI6JcCZUIU6eqmZEqieFBtS51g, _DEdZRCjltS13jKpC2YJkZY838ZK + 1920f);
					num = ((int)num2 * -1329429281) ^ 0x17402A85;
					continue;
				case 4u:
					DrivingScene.smethod_24((_ujAkjlfN5TywwbLAUDzPvtab6uJ)_NtI6JcCZUIU6eqmZEqieFBtS51g, _DEdZRCjltS13jKpC2YJkZY838ZK + 3840f);
					num = ((int)num2 * -337418954) ^ 0x12F265C2;
					continue;
				case 3u:
					DrivingScene.smethod_23((_ujAkjlfN5TywwbLAUDzPvtab6uJ)_SwpBYcoXXTll45NBeycIpflE8r, spriteBatch_0);
					num = ((int)num2 * -1903925171) ^ 0x7A25EAE6;
					continue;
				case 2u:
					DrivingScene.smethod_23((_ujAkjlfN5TywwbLAUDzPvtab6uJ)_ywjql7DttUMPriZ95ycoakuivHF, spriteBatch_0);
					num = (int)((num2 * 1418699461) ^ 0x6FC62EDC);
					continue;
				case 1u:
					DrivingScene.smethod_23((_ujAkjlfN5TywwbLAUDzPvtab6uJ)_keMqzR2MH8pk2eRBjpmBvvHsKkH, spriteBatch_0);
					num = (int)(num2 * 2061476832) ^ -2119254919;
					continue;
				case 0u:
					DrivingScene.smethod_24((_ujAkjlfN5TywwbLAUDzPvtab6uJ)_keMqzR2MH8pk2eRBjpmBvvHsKkH, _rn1x58VMBD9DAD7YIR46LqTEfMP + 1920f);
					num = (int)(num2 * 532128506) ^ -2132371585;
					continue;
				default:
					return;
				case 15u:
					break;
				case 8u:
					return;
				}
				break;
			}
		}
	}

	static void smethod_14(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0, string string_0)
	{
		_7UlnfykmEmZDFt3BmCKZekI43Ih_0._6hE3geqxrB1vCirtSWHxIJjlTQB(string_0);
	}

	static void smethod_15(string string_0, float float_0)
	{
		_UmxbIbk7pgaod0bD7pS309P3Lns._l94kUraQ13OohoVwwxKC37hG7Pc(string_0, float_0);
	}

	void method_0(string string_0)
	{
		base._6hE3geqxrB1vCirtSWHxIJjlTQB(string_0);
	}

	static string smethod_16(string string_0, string string_1, string string_2)
	{
		return string_0 + string_1 + string_2;
	}

	static _uqydQVaCmCvK7zzWs5W4gZFpKBu smethod_17(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0, string string_0, string string_1, int int_0, int int_1)
	{
		return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._0O8D0mBgmrh0sLOGcLVvGNOHKLCA(string_0, string_1, int_0, int_1);
	}

	static int smethod_18(int int_0, int int_1)
	{
		return _boyt8NIMtKsAGSTcjHeL0WMbFxs._07xTWbIEgzxJYsYwFKDbbKNvu4G(int_0, int_1);
	}

	void method_1(GameTime gameTime_0)
	{
		base._tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime_0);
	}

	static TimeSpan smethod_19(GameTime gameTime_0)
	{
		return gameTime_0.get_ElapsedGameTime();
	}

	static bool smethod_20()
	{
		return _boyt8NIMtKsAGSTcjHeL0WMbFxs._gbHIDTfALwKhXkamYJbKsAUKL2E();
	}

	static void smethod_21(_uqydQVaCmCvK7zzWs5W4gZFpKBu _uqydQVaCmCvK7zzWs5W4gZFpKBu_0, bool bool_0)
	{
		_uqydQVaCmCvK7zzWs5W4gZFpKBu_0._PXBbI2AED2MyzkuXicgwalICf26 = bool_0;
	}

	void method_2(SpriteBatch spriteBatch_0, SkeletonMeshRenderer skeletonMeshRenderer_0, Matrix matrix_0)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		base._f5ctqAmdNsZ889UjM4LxDm8WGxA(spriteBatch_0, skeletonMeshRenderer_0, matrix_0);
	}

	static void smethod_22(SpriteBatch spriteBatch_0, SpriteSortMode spriteSortMode_0, BlendState blendState_0, SamplerState samplerState_0, DepthStencilState depthStencilState_0, RasterizerState rasterizerState_0, Effect effect_0, Matrix? nullable_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		spriteBatch_0._g9Sx54kMPiHz5jrqWh4Kb1pTijH(spriteSortMode_0, blendState_0, samplerState_0, depthStencilState_0, rasterizerState_0, effect_0, nullable_0);
	}

	static void smethod_23(_ujAkjlfN5TywwbLAUDzPvtab6uJ _ujAkjlfN5TywwbLAUDzPvtab6uJ_0, SpriteBatch spriteBatch_0)
	{
		_ujAkjlfN5TywwbLAUDzPvtab6uJ_0._f5ctqAmdNsZ889UjM4LxDm8WGxA(spriteBatch_0);
	}

	static void smethod_24(_ujAkjlfN5TywwbLAUDzPvtab6uJ _ujAkjlfN5TywwbLAUDzPvtab6uJ_0, float float_0)
	{
		_ujAkjlfN5TywwbLAUDzPvtab6uJ_0._7Xn1C5tjYnmIif1iZKV8AWsEEbL = float_0;
	}

	static void smethod_25(SpriteBatch spriteBatch_0)
	{
		spriteBatch_0.End();
	}
}
