using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Spine;

namespace Amorous.Game.Scenes;

public class DrivingScene : AbstractScene
{
	public const string VariantSunset = "Sunset";
	public const string VariantNight = "Night";
	public const string VariantDay = "Day";

	private const int _B68ctrDW0hRDkXziVHKCjKFP4qOA = 1280;

	private const float _4bHwLPLFG7ngyPTFDFH6R0qj9fE = 0.25f;

	private const float _jKachG4OFgumvh4coAfrPYvYvE6 = 0.5f;

	private const float _tpdb62hWwmsf91RJNNUulTzZfAk = 0.9f;

	private TexturedLayer _2WuocFtGsvuqlLRNzg1JvWYdCPu;

	private TexturedLayer _keMqzR2MH8pk2eRBjpmBvvHsKkH;

	private TexturedLayer _NtI6JcCZUIU6eqmZEqieFBtS51g;

	private readonly TexturedLayer[] _cmNp2s95voDHTlRfEo0WKjoNC5D = new TexturedLayer[3];

	private int _HuRva9O1Dird7HCHNvEYAhbEXEx;

	private TexturedLayer _SwpBYcoXXTll45NBeycIpflE8r;

	private TexturedLayer _ywjql7DttUMPriZ95ycoakuivHF;

	private float _rn1x58VMBD9DAD7YIR46LqTEfMP;

	private float _DEdZRCjltS13jKpC2YJkZY838ZK;

	private float _5F3aFNnUdPR4Jd8EFDxoRL2ITlV;

	public DrivingScene(IAmorous game)
		: base(game)
	{
		SetVariant("Day");
		FadingMediaPlayer._l94kUraQ13OohoVwwxKC37hG7Pc("Assets/Music/AudioDriver - Detective's Scoop", 0.4f);
	}

	public override void SetVariant(string daytime)
	{
		base.SetVariant(daytime);
		_2WuocFtGsvuqlLRNzg1JvWYdCPu = AddTexturedLayer("Background", "Assets/Scenes/Driving/" + daytime + " Background", 0, 0);
		_keMqzR2MH8pk2eRBjpmBvvHsKkH = AddTexturedLayer("Background", "Assets/Scenes/Driving/" + daytime + " Background 2", 0, 680);
		_NtI6JcCZUIU6eqmZEqieFBtS51g = AddTexturedLayer("Background", "Assets/Scenes/Driving/" + daytime + " Foreground", 0, 0);
		_cmNp2s95voDHTlRfEo0WKjoNC5D[0] = AddTexturedLayer("Background", "Assets/Scenes/Driving/" + daytime + " Tree A", 0, 0);
		_cmNp2s95voDHTlRfEo0WKjoNC5D[1] = AddTexturedLayer("Background", "Assets/Scenes/Driving/" + daytime + " Tree B", 0, 0);
		_cmNp2s95voDHTlRfEo0WKjoNC5D[2] = AddTexturedLayer("Background", "Assets/Scenes/Driving/" + daytime + " Tree C", 0, 0);
		_HuRva9O1Dird7HCHNvEYAhbEXEx = Randoms.Next(0, _cmNp2s95voDHTlRfEo0WKjoNC5D.Length - 1);
		_jLqsVc7ZjWokEg8zjm4aue7Vfwr();
		_rn1x58VMBD9DAD7YIR46LqTEfMP = Randoms.Next(-1920, 0);
		_DEdZRCjltS13jKpC2YJkZY838ZK = Randoms.Next(-1920, 0);
		_5F3aFNnUdPR4Jd8EFDxoRL2ITlV = Randoms.Next(-1920, 0);
	}

	public override void Update(GameTime gameTime)
	{
		base.Update(gameTime);
		float num = (float)(1280.0 * gameTime.ElapsedGameTime.TotalSeconds);
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
		_ywjql7DttUMPriZ95ycoakuivHF.Flip = Randoms.NextBool();
	}

	public override void Draw(SpriteBatch spriteBatch, SkeletonMeshRenderer skeletonMeshRenderer, Matrix matrix_0)
	{
		base.Draw(spriteBatch, skeletonMeshRenderer, matrix_0);
		spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.NonPremultiplied);
		_2WuocFtGsvuqlLRNzg1JvWYdCPu.Draw(spriteBatch);
		_keMqzR2MH8pk2eRBjpmBvvHsKkH.X = _rn1x58VMBD9DAD7YIR46LqTEfMP;
		_keMqzR2MH8pk2eRBjpmBvvHsKkH.Draw(spriteBatch);
		_keMqzR2MH8pk2eRBjpmBvvHsKkH.X = _rn1x58VMBD9DAD7YIR46LqTEfMP + 1920f;
		_keMqzR2MH8pk2eRBjpmBvvHsKkH.Flip = true;
		_keMqzR2MH8pk2eRBjpmBvvHsKkH.Draw(spriteBatch);
		_keMqzR2MH8pk2eRBjpmBvvHsKkH.X = _rn1x58VMBD9DAD7YIR46LqTEfMP + 3840f;
		_keMqzR2MH8pk2eRBjpmBvvHsKkH.Flip = false;
		_keMqzR2MH8pk2eRBjpmBvvHsKkH.Draw(spriteBatch);
		_SwpBYcoXXTll45NBeycIpflE8r.X = _5F3aFNnUdPR4Jd8EFDxoRL2ITlV;
		_ywjql7DttUMPriZ95ycoakuivHF.X = _5F3aFNnUdPR4Jd8EFDxoRL2ITlV + 1920f;
		_SwpBYcoXXTll45NBeycIpflE8r.Draw(spriteBatch);
		_ywjql7DttUMPriZ95ycoakuivHF.Draw(spriteBatch);
		_NtI6JcCZUIU6eqmZEqieFBtS51g.X = _DEdZRCjltS13jKpC2YJkZY838ZK;
		_NtI6JcCZUIU6eqmZEqieFBtS51g.Draw(spriteBatch);
		_NtI6JcCZUIU6eqmZEqieFBtS51g.X = _DEdZRCjltS13jKpC2YJkZY838ZK + 1920f;
		_NtI6JcCZUIU6eqmZEqieFBtS51g.Flip = true;
		_NtI6JcCZUIU6eqmZEqieFBtS51g.Draw(spriteBatch);
		_NtI6JcCZUIU6eqmZEqieFBtS51g.X = _DEdZRCjltS13jKpC2YJkZY838ZK + 3840f;
		_NtI6JcCZUIU6eqmZEqieFBtS51g.Flip = false;
		_NtI6JcCZUIU6eqmZEqieFBtS51g.Draw(spriteBatch);
		spriteBatch.End();
	}
}
