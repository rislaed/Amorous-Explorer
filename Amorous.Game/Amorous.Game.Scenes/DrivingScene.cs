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
		DrivingScene.smethod_14((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Day");
		DrivingScene.smethod_15("Assets/Music/AudioDriver - Detective's Scoop", 0.4f);
	}

	public override void _6hE3geqxrB1vCirtSWHxIJjlTQB(string string_0)
	{
		this.method_0(string_0);
		_2WuocFtGsvuqlLRNzg1JvWYdCPu = DrivingScene.smethod_17((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Background", DrivingScene.smethod_16("Assets/Scenes/Driving/", string_0, " Background"), 0, 0);
		_keMqzR2MH8pk2eRBjpmBvvHsKkH = DrivingScene.smethod_17((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Background", DrivingScene.smethod_16("Assets/Scenes/Driving/", string_0, " Background 2"), 0, 680);
		_NtI6JcCZUIU6eqmZEqieFBtS51g = DrivingScene.smethod_17((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Background", DrivingScene.smethod_16("Assets/Scenes/Driving/", string_0, " Foreground"), 0, 0);
		_cmNp2s95voDHTlRfEo0WKjoNC5D[0] = DrivingScene.smethod_17((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Background", DrivingScene.smethod_16("Assets/Scenes/Driving/", string_0, " Tree A"), 0, 0);
		_cmNp2s95voDHTlRfEo0WKjoNC5D[1] = DrivingScene.smethod_17((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Background", DrivingScene.smethod_16("Assets/Scenes/Driving/", string_0, " Tree B"), 0, 0);
		_cmNp2s95voDHTlRfEo0WKjoNC5D[2] = DrivingScene.smethod_17((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Background", DrivingScene.smethod_16("Assets/Scenes/Driving/", string_0, " Tree C"), 0, 0);
		_HuRva9O1Dird7HCHNvEYAhbEXEx = DrivingScene.smethod_18(0, _cmNp2s95voDHTlRfEo0WKjoNC5D.Length - 1);
		_jLqsVc7ZjWokEg8zjm4aue7Vfwr();
		_rn1x58VMBD9DAD7YIR46LqTEfMP = DrivingScene.smethod_18(-1920, 0);
		_DEdZRCjltS13jKpC2YJkZY838ZK = DrivingScene.smethod_18(-1920, 0);
		_5F3aFNnUdPR4Jd8EFDxoRL2ITlV = DrivingScene.smethod_18(-1920, 0);
	}

	public override void _tiBFUHPEkedkbgvuX3whdeyjhKo(GameTime gameTime_0)
	{
		this.method_1(gameTime_0);
		float num = (float)(1280.0 * DrivingScene.smethod_19(gameTime_0).TotalSeconds);
		_rn1x58VMBD9DAD7YIR46LqTEfMP -= num * 0.25f;
		if (_rn1x58VMBD9DAD7YIR46LqTEfMP < -3840f)
		{
			_rn1x58VMBD9DAD7YIR46LqTEfMP += 3840f;
		}
		_5F3aFNnUdPR4Jd8EFDxoRL2ITlV -= num * 0.5f;
		if (_5F3aFNnUdPR4Jd8EFDxoRL2ITlV < -1920f)
		{
			_5F3aFNnUdPR4Jd8EFDxoRL2ITlV = 0f;
			_jLqsVc7ZjWokEg8zjm4aue7Vfwr();
		}
		_DEdZRCjltS13jKpC2YJkZY838ZK -= num * 0.9f;
		if (_DEdZRCjltS13jKpC2YJkZY838ZK < -3840f)
		{
			_DEdZRCjltS13jKpC2YJkZY838ZK += 3840f;
		}
	}

	private void _jLqsVc7ZjWokEg8zjm4aue7Vfwr()
	{
		_SwpBYcoXXTll45NBeycIpflE8r = _cmNp2s95voDHTlRfEo0WKjoNC5D[_HuRva9O1Dird7HCHNvEYAhbEXEx];
		_HuRva9O1Dird7HCHNvEYAhbEXEx++;
		if (_HuRva9O1Dird7HCHNvEYAhbEXEx >= _cmNp2s95voDHTlRfEo0WKjoNC5D.Length)
		{
			_HuRva9O1Dird7HCHNvEYAhbEXEx = 0;
		}
		_ywjql7DttUMPriZ95ycoakuivHF = _cmNp2s95voDHTlRfEo0WKjoNC5D[_HuRva9O1Dird7HCHNvEYAhbEXEx];
		DrivingScene.smethod_21(_ywjql7DttUMPriZ95ycoakuivHF, DrivingScene.smethod_20());
	}

	public override void _f5ctqAmdNsZ889UjM4LxDm8WGxA(SpriteBatch spriteBatch_0, SkeletonMeshRenderer skeletonMeshRenderer_0, Matrix matrix_0)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		this.method_2(spriteBatch_0, skeletonMeshRenderer_0, matrix_0);
		DrivingScene.smethod_22(spriteBatch_0, (SpriteSortMode)0, BlendState.NonPremultiplied, (SamplerState)null, (DepthStencilState)null, (RasterizerState)null, (Effect)null, (Matrix?)null);
		DrivingScene.smethod_23((_ujAkjlfN5TywwbLAUDzPvtab6uJ)_2WuocFtGsvuqlLRNzg1JvWYdCPu, spriteBatch_0);
		DrivingScene.smethod_24((_ujAkjlfN5TywwbLAUDzPvtab6uJ)_keMqzR2MH8pk2eRBjpmBvvHsKkH, _rn1x58VMBD9DAD7YIR46LqTEfMP);
		DrivingScene.smethod_23((_ujAkjlfN5TywwbLAUDzPvtab6uJ)_keMqzR2MH8pk2eRBjpmBvvHsKkH, spriteBatch_0);
		DrivingScene.smethod_24((_ujAkjlfN5TywwbLAUDzPvtab6uJ)_keMqzR2MH8pk2eRBjpmBvvHsKkH, _rn1x58VMBD9DAD7YIR46LqTEfMP + 1920f);
		DrivingScene.smethod_21(_keMqzR2MH8pk2eRBjpmBvvHsKkH, bool_0: true);
		DrivingScene.smethod_23((_ujAkjlfN5TywwbLAUDzPvtab6uJ)_keMqzR2MH8pk2eRBjpmBvvHsKkH, spriteBatch_0);
		DrivingScene.smethod_24((_ujAkjlfN5TywwbLAUDzPvtab6uJ)_keMqzR2MH8pk2eRBjpmBvvHsKkH, _rn1x58VMBD9DAD7YIR46LqTEfMP + 3840f);
		DrivingScene.smethod_21(_keMqzR2MH8pk2eRBjpmBvvHsKkH, bool_0: false);
		DrivingScene.smethod_23((_ujAkjlfN5TywwbLAUDzPvtab6uJ)_keMqzR2MH8pk2eRBjpmBvvHsKkH, spriteBatch_0);
		DrivingScene.smethod_24((_ujAkjlfN5TywwbLAUDzPvtab6uJ)_SwpBYcoXXTll45NBeycIpflE8r, _5F3aFNnUdPR4Jd8EFDxoRL2ITlV);
		DrivingScene.smethod_24((_ujAkjlfN5TywwbLAUDzPvtab6uJ)_ywjql7DttUMPriZ95ycoakuivHF, _5F3aFNnUdPR4Jd8EFDxoRL2ITlV + 1920f);
		DrivingScene.smethod_23((_ujAkjlfN5TywwbLAUDzPvtab6uJ)_SwpBYcoXXTll45NBeycIpflE8r, spriteBatch_0);
		DrivingScene.smethod_23((_ujAkjlfN5TywwbLAUDzPvtab6uJ)_ywjql7DttUMPriZ95ycoakuivHF, spriteBatch_0);
		DrivingScene.smethod_24((_ujAkjlfN5TywwbLAUDzPvtab6uJ)_NtI6JcCZUIU6eqmZEqieFBtS51g, _DEdZRCjltS13jKpC2YJkZY838ZK);
		DrivingScene.smethod_23((_ujAkjlfN5TywwbLAUDzPvtab6uJ)_NtI6JcCZUIU6eqmZEqieFBtS51g, spriteBatch_0);
		DrivingScene.smethod_24((_ujAkjlfN5TywwbLAUDzPvtab6uJ)_NtI6JcCZUIU6eqmZEqieFBtS51g, _DEdZRCjltS13jKpC2YJkZY838ZK + 1920f);
		DrivingScene.smethod_21(_NtI6JcCZUIU6eqmZEqieFBtS51g, bool_0: true);
		DrivingScene.smethod_23((_ujAkjlfN5TywwbLAUDzPvtab6uJ)_NtI6JcCZUIU6eqmZEqieFBtS51g, spriteBatch_0);
		DrivingScene.smethod_24((_ujAkjlfN5TywwbLAUDzPvtab6uJ)_NtI6JcCZUIU6eqmZEqieFBtS51g, _DEdZRCjltS13jKpC2YJkZY838ZK + 3840f);
		DrivingScene.smethod_21(_NtI6JcCZUIU6eqmZEqieFBtS51g, bool_0: false);
		DrivingScene.smethod_23((_ujAkjlfN5TywwbLAUDzPvtab6uJ)_NtI6JcCZUIU6eqmZEqieFBtS51g, spriteBatch_0);
		DrivingScene.smethod_25(spriteBatch_0);
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
