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
		_6hE3geqxrB1vCirtSWHxIJjlTQB("Day");
		_UmxbIbk7pgaod0bD7pS309P3Lns._l94kUraQ13OohoVwwxKC37hG7Pc("Assets/Music/AudioDriver - Detective's Scoop", 0.4f);
	}

	public override void _6hE3geqxrB1vCirtSWHxIJjlTQB(string string_0)
	{
		base._6hE3geqxrB1vCirtSWHxIJjlTQB(string_0);
		_2WuocFtGsvuqlLRNzg1JvWYdCPu = _0O8D0mBgmrh0sLOGcLVvGNOHKLCA("Background", "Assets/Scenes/Driving/" + string_0 + " Background", 0, 0);
		_keMqzR2MH8pk2eRBjpmBvvHsKkH = _0O8D0mBgmrh0sLOGcLVvGNOHKLCA("Background", "Assets/Scenes/Driving/" + string_0 + " Background 2", 0, 680);
		_NtI6JcCZUIU6eqmZEqieFBtS51g = _0O8D0mBgmrh0sLOGcLVvGNOHKLCA("Background", "Assets/Scenes/Driving/" + string_0 + " Foreground", 0, 0);
		_cmNp2s95voDHTlRfEo0WKjoNC5D[0] = _0O8D0mBgmrh0sLOGcLVvGNOHKLCA("Background", "Assets/Scenes/Driving/" + string_0 + " Tree A", 0, 0);
		_cmNp2s95voDHTlRfEo0WKjoNC5D[1] = _0O8D0mBgmrh0sLOGcLVvGNOHKLCA("Background", "Assets/Scenes/Driving/" + string_0 + " Tree B", 0, 0);
		_cmNp2s95voDHTlRfEo0WKjoNC5D[2] = _0O8D0mBgmrh0sLOGcLVvGNOHKLCA("Background", "Assets/Scenes/Driving/" + string_0 + " Tree C", 0, 0);
		_HuRva9O1Dird7HCHNvEYAhbEXEx = _boyt8NIMtKsAGSTcjHeL0WMbFxs._07xTWbIEgzxJYsYwFKDbbKNvu4G(0, _cmNp2s95voDHTlRfEo0WKjoNC5D.Length - 1);
		_jLqsVc7ZjWokEg8zjm4aue7Vfwr();
		_rn1x58VMBD9DAD7YIR46LqTEfMP = _boyt8NIMtKsAGSTcjHeL0WMbFxs._07xTWbIEgzxJYsYwFKDbbKNvu4G(-1920, 0);
		_DEdZRCjltS13jKpC2YJkZY838ZK = _boyt8NIMtKsAGSTcjHeL0WMbFxs._07xTWbIEgzxJYsYwFKDbbKNvu4G(-1920, 0);
		_5F3aFNnUdPR4Jd8EFDxoRL2ITlV = _boyt8NIMtKsAGSTcjHeL0WMbFxs._07xTWbIEgzxJYsYwFKDbbKNvu4G(-1920, 0);
	}

	public override void _tiBFUHPEkedkbgvuX3whdeyjhKo(GameTime gameTime_0)
	{
		base._tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime_0);
		float num = (float)(1280.0 * gameTime_0.ElapsedGameTime.TotalSeconds);
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
		_ywjql7DttUMPriZ95ycoakuivHF._PXBbI2AED2MyzkuXicgwalICf26 = _boyt8NIMtKsAGSTcjHeL0WMbFxs._gbHIDTfALwKhXkamYJbKsAUKL2E();
	}

	public override void _f5ctqAmdNsZ889UjM4LxDm8WGxA(SpriteBatch spriteBatch_0, SkeletonMeshRenderer skeletonMeshRenderer_0, Matrix matrix_0)
	{
		base._f5ctqAmdNsZ889UjM4LxDm8WGxA(spriteBatch_0, skeletonMeshRenderer_0, matrix_0);
		spriteBatch_0._g9Sx54kMPiHz5jrqWh4Kb1pTijH(SpriteSortMode.Deferred, BlendState.NonPremultiplied);
		_2WuocFtGsvuqlLRNzg1JvWYdCPu._f5ctqAmdNsZ889UjM4LxDm8WGxA(spriteBatch_0);
		_keMqzR2MH8pk2eRBjpmBvvHsKkH._7Xn1C5tjYnmIif1iZKV8AWsEEbL = _rn1x58VMBD9DAD7YIR46LqTEfMP;
		_keMqzR2MH8pk2eRBjpmBvvHsKkH._f5ctqAmdNsZ889UjM4LxDm8WGxA(spriteBatch_0);
		_keMqzR2MH8pk2eRBjpmBvvHsKkH._7Xn1C5tjYnmIif1iZKV8AWsEEbL = _rn1x58VMBD9DAD7YIR46LqTEfMP + 1920f;
		_keMqzR2MH8pk2eRBjpmBvvHsKkH._PXBbI2AED2MyzkuXicgwalICf26 = true;
		_keMqzR2MH8pk2eRBjpmBvvHsKkH._f5ctqAmdNsZ889UjM4LxDm8WGxA(spriteBatch_0);
		_keMqzR2MH8pk2eRBjpmBvvHsKkH._7Xn1C5tjYnmIif1iZKV8AWsEEbL = _rn1x58VMBD9DAD7YIR46LqTEfMP + 3840f;
		_keMqzR2MH8pk2eRBjpmBvvHsKkH._PXBbI2AED2MyzkuXicgwalICf26 = false;
		_keMqzR2MH8pk2eRBjpmBvvHsKkH._f5ctqAmdNsZ889UjM4LxDm8WGxA(spriteBatch_0);
		_SwpBYcoXXTll45NBeycIpflE8r._7Xn1C5tjYnmIif1iZKV8AWsEEbL = _5F3aFNnUdPR4Jd8EFDxoRL2ITlV;
		_ywjql7DttUMPriZ95ycoakuivHF._7Xn1C5tjYnmIif1iZKV8AWsEEbL = _5F3aFNnUdPR4Jd8EFDxoRL2ITlV + 1920f;
		_SwpBYcoXXTll45NBeycIpflE8r._f5ctqAmdNsZ889UjM4LxDm8WGxA(spriteBatch_0);
		_ywjql7DttUMPriZ95ycoakuivHF._f5ctqAmdNsZ889UjM4LxDm8WGxA(spriteBatch_0);
		_NtI6JcCZUIU6eqmZEqieFBtS51g._7Xn1C5tjYnmIif1iZKV8AWsEEbL = _DEdZRCjltS13jKpC2YJkZY838ZK;
		_NtI6JcCZUIU6eqmZEqieFBtS51g._f5ctqAmdNsZ889UjM4LxDm8WGxA(spriteBatch_0);
		_NtI6JcCZUIU6eqmZEqieFBtS51g._7Xn1C5tjYnmIif1iZKV8AWsEEbL = _DEdZRCjltS13jKpC2YJkZY838ZK + 1920f;
		_NtI6JcCZUIU6eqmZEqieFBtS51g._PXBbI2AED2MyzkuXicgwalICf26 = true;
		_NtI6JcCZUIU6eqmZEqieFBtS51g._f5ctqAmdNsZ889UjM4LxDm8WGxA(spriteBatch_0);
		_NtI6JcCZUIU6eqmZEqieFBtS51g._7Xn1C5tjYnmIif1iZKV8AWsEEbL = _DEdZRCjltS13jKpC2YJkZY838ZK + 3840f;
		_NtI6JcCZUIU6eqmZEqieFBtS51g._PXBbI2AED2MyzkuXicgwalICf26 = false;
		_NtI6JcCZUIU6eqmZEqieFBtS51g._f5ctqAmdNsZ889UjM4LxDm8WGxA(spriteBatch_0);
		spriteBatch_0.End();
	}
}
