using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Spine;

namespace Amorous.Game.Scenes;

public class CookingMiniGameScene : AbstractScene
{
	private class GUI : InteractableOverlay
	{
		private readonly ButtonInteractable _wmL1cFR5CsMqZS9jOXyCnmqveCG;

		public bool _k8HavJ0P5yWjzHBpsDOOGVNY8MM
		{
			set
			{
				_wmL1cFR5CsMqZS9jOXyCnmqveCG.Visible = value;
			}
		}

		public GUI(IAmorous game, Action action_0)
			: base(game)
		{
			_wmL1cFR5CsMqZS9jOXyCnmqveCG = AddButtonInteractable("Assets/Scenes/Cooking/Button", "Assets/Scenes/Cooking/Button hover", "Assets/Gui/Fonts/Bold-26", "Stop cooking!", Color.White, 832, 970, new Rectangle(832, 970, 256, 102), action_0);
			_wmL1cFR5CsMqZS9jOXyCnmqveCG.Visible = false;
		}
	}

	private enum EIngrediants
	{
		OnionsGarlic,
		GroundBeef,
		Carrots,
		TinnedTomatoes,
		Herbs,
		Pasta,
		None
	}

	private const int _ZjOVtPUGk7JcvTYzI75PArDFAhk = 5;

	private const float _Apm54GslyyOSpmco0hQZUPEwDXB = 2.5f;

	private const float _IOkmdPXdqA5XP7KDGaAleOrsdYs = 4.5f;

	private readonly GUI _overlay;

	private readonly SpineRenderer _bFjOLB3sqVGFgwwMENJRlZ5vouC;

	private readonly RandomSoundEffect _WwmWk5kaVSyVGOqHYV9xCL01Mmq;

	private readonly RandomSoundEffect _Yl6cx6lo29nhZhAYCwYNXftaePb;

	private readonly RandomSoundEffect _R1mDpxg72ZTKnMeOQ0sH8szndlG;

	private readonly RandomSoundEffect _E5COS2Wew1BQS9CZNJcDAnV99Y;

	private readonly RandomSoundEffect _NCyPsw4quyw64ZmYLMqlIaQaclA;

	private readonly RandomSoundEffect _gDkX1mAt76eLA8P3gGXs2wM5wTE;

	private readonly RandomSoundEffect _7f8HjbO7kyXkAQLb2mIqPJKHcLb;

	private readonly RandomSoundEffect _vdz7lnEalvPxBPYYcR15bPICZOc;

	private readonly RandomSoundEffect _3h9I4xBs98PF8vAbLXJAdpmHA8dA;

	private readonly RandomSoundEffect _QQrPUpwIvHnFnZeHb0cfL7CPSHh;

	private readonly RandomSoundEffect _8CTAuE7kLwrQAWKi1EOgTa2AKEx;

	private readonly RandomSoundEffect _MHlWAOoiEHfmdM0FqWO6WSRbC1hA;

	private readonly AbstractLayer _urxVZoSWXCtbeM9oQmVXW0Fb7co;

	private readonly AbstractLayer _RZsDgwVY7R44E6mMbUF7YWYyBjK;

	private readonly AbstractLayer _9cxzh98qcLMOVst3Rlmc4AaYoBp;

	private bool _h5v8MyOj54KK9SVZpYnagzRPLMP;

	private bool _HXs79I5YAlnCxHxJS0JxD7jccyt;

	private bool _HylCIZnie9TY7iCNyKurgxQFFji;

	private bool _mOljPVTpQkVD6dwmmr9m28l6fc;

	private bool _g0GLDf9i20jtYweGI1DAr0f9WON;

	private bool _ylWBqGZTor7PB0HyMRwAuoV4hvH;

	private EIngrediants _tJRouny7ZhgCxrAgyXFLsqSeAMT;

	private bool _oadA2EQp5TIkaydfB8B5lpw5Cmu;

	private float _2Kg9JelDMoLPl78Uv5Lb5ygQff;

	private bool _K8aZsmpWRImwc2JedT7KcW3wdYQ;

	private bool _p28QNaoEJvHENbJjA4icWq92tkI;

	private bool _Iqfa1mamDp2busajsE8iPWnCKbDA;

	private float _eRokloBwt8FsjBWpKBDmNKscCLH;

	private List<EIngrediants> _NDwc6JiCbSmdqmQRU3taXzILgTBb;

	private float _JuZlzgvacKG5z0tmPuFzmPPGDog;

	public bool _c9i4Rbj8ENw5b6aqNq271voBctc { get; set; }

	public bool Completable { get; set; }

	public bool _T81AMuUIGw7sZkYmJkIpiDPosrD { get; set; }

	public CookingMiniGameScene(IAmorous game)
		: base(game)
	{
		_overlay = new GUI(game, _Ee9VcMQIfuD0ElqFdXVvMHxofkf);
		base.Game.SetOverlay(_overlay);
		AddTexturedLayer("Background", "Assets/Scenes/Cooking/Background", 0, 0);
		_urxVZoSWXCtbeM9oQmVXW0Fb7co = AddForegroundTexturedLayer("Background", "Assets/Scenes/Cooking/Bad", 0, 0);
		_urxVZoSWXCtbeM9oQmVXW0Fb7co.Visible = false;
		_RZsDgwVY7R44E6mMbUF7YWYyBjK = AddForegroundTexturedLayer("Background", "Assets/Scenes/Cooking/Okay", 0, 0);
		_RZsDgwVY7R44E6mMbUF7YWYyBjK.Visible = false;
		_9cxzh98qcLMOVst3Rlmc4AaYoBp = AddForegroundTexturedLayer("Background", "Assets/Scenes/Cooking/Excellent", 0, 0);
		_9cxzh98qcLMOVst3Rlmc4AaYoBp.Visible = false;
		SpineDrawableLayer spineLayer = new SpineDrawableLayer(this, "Cooking");
		_bFjOLB3sqVGFgwwMENJRlZ5vouC = game.Content.LoadSkeleton("Assets/Scenes/Cooking/Cooking");
		_bFjOLB3sqVGFgwwMENJRlZ5vouC.X = 960f;
		_bFjOLB3sqVGFgwwMENJRlZ5vouC.Y = 540f;
		_WwmWk5kaVSyVGOqHYV9xCL01Mmq = new RandomSoundEffect(game.Content);
		_WwmWk5kaVSyVGOqHYV9xCL01Mmq.Append("Assets/Sounds/MiniGames/Cooking/Pan spawn");
		_Yl6cx6lo29nhZhAYCwYNXftaePb = new RandomSoundEffect(game.Content);
		_Yl6cx6lo29nhZhAYCwYNXftaePb.Append("Assets/Sounds/MiniGames/Cooking/Add ingrediant");
		_R1mDpxg72ZTKnMeOQ0sH8szndlG = new RandomSoundEffect(game.Content);
		_R1mDpxg72ZTKnMeOQ0sH8szndlG.Append("Assets/Sounds/MiniGames/Cooking/Onion");
		_E5COS2Wew1BQS9CZNJcDAnV99Y = new RandomSoundEffect(game.Content);
		_E5COS2Wew1BQS9CZNJcDAnV99Y.Append("Assets/Sounds/MiniGames/Cooking/Beef");
		_NCyPsw4quyw64ZmYLMqlIaQaclA = new RandomSoundEffect(game.Content);
		_NCyPsw4quyw64ZmYLMqlIaQaclA.Append("Assets/Sounds/MiniGames/Cooking/Carrots");
		_gDkX1mAt76eLA8P3gGXs2wM5wTE = new RandomSoundEffect(game.Content);
		_gDkX1mAt76eLA8P3gGXs2wM5wTE.Append("Assets/Sounds/MiniGames/Cooking/Tomatoe");
		_7f8HjbO7kyXkAQLb2mIqPJKHcLb = new RandomSoundEffect(game.Content);
		_7f8HjbO7kyXkAQLb2mIqPJKHcLb.Append("Assets/Sounds/MiniGames/Cooking/Bay leaves");
		_vdz7lnEalvPxBPYYcR15bPICZOc = new RandomSoundEffect(game.Content);
		_vdz7lnEalvPxBPYYcR15bPICZOc.Append("Assets/Sounds/MiniGames/Cooking/Burning");
		_3h9I4xBs98PF8vAbLXJAdpmHA8dA = new RandomSoundEffect(game.Content);
		_3h9I4xBs98PF8vAbLXJAdpmHA8dA.Append("Assets/Sounds/MiniGames/Cooking/Drum roll");
		_QQrPUpwIvHnFnZeHb0cfL7CPSHh = new RandomSoundEffect(game.Content);
		_QQrPUpwIvHnFnZeHb0cfL7CPSHh.Append("Assets/Sounds/MiniGames/Cooking/Bad food");
		_8CTAuE7kLwrQAWKi1EOgTa2AKEx = new RandomSoundEffect(game.Content);
		_8CTAuE7kLwrQAWKi1EOgTa2AKEx.Append("Assets/Sounds/MiniGames/Cooking/Ok food");
		_MHlWAOoiEHfmdM0FqWO6WSRbC1hA = new RandomSoundEffect(game.Content);
		_MHlWAOoiEHfmdM0FqWO6WSRbC1hA.Append("Assets/Sounds/MiniGames/Cooking/Great food");
		RefreshSubscene();
		spineLayer.OnUpdate = delegate(GameTime gameTime)
		{
			_bFjOLB3sqVGFgwwMENJRlZ5vouC.Update(gameTime);
		};
		spineLayer.OnSpineDraw = delegate(SpriteBatch spriteBatch, SkeletonMeshRenderer skeletonMeshRenderer)
		{
			_bFjOLB3sqVGFgwwMENJRlZ5vouC.Draw(skeletonMeshRenderer, null, _YwAdHC5A5VB16lereNxJLkAP3Z9A);
		};
		AddLayer(spineLayer, 0);
		FadingMediaPlayer.PlayOnRepeat(AmorousData.FreeFloatingTrack, 0.1f);
	}

	private bool _YwAdHC5A5VB16lereNxJLkAP3Z9A(int int_0, string string_0)
	{
		switch (string_0)
		{
		case "Pasta":
			return _h5v8MyOj54KK9SVZpYnagzRPLMP;
		case "Onions bowl shadow":
		case "Onions bowl glow":
		case "Onions bowl":
			return !_HXs79I5YAlnCxHxJS0JxD7jccyt;
		default:
			return true;
		case "BayThyme 1":
		case "BayThyme 2":
			return _ylWBqGZTor7PB0HyMRwAuoV4hvH;
		case "Bayleaves bowl shadow":
		case "Bayleaves bowl glow":
		case "Bayleaves bowl":
			return !_ylWBqGZTor7PB0HyMRwAuoV4hvH;
		case "Sauce 1":
		case "Sauce 2":
			return _g0GLDf9i20jtYweGI1DAr0f9WON;
		case "Tomatoe bowl shadow":
		case "Tomatoe bowl glow":
		case "Tomatoe bowl":
			return !_g0GLDf9i20jtYweGI1DAr0f9WON;
		case "Carrots 1":
		case "Carrots 2":
			return _mOljPVTpQkVD6dwmmr9m28l6fc;
		case "Carrot bowl shadow":
		case "Carrot bowl glow":
		case "Carrot bowl":
			return !_mOljPVTpQkVD6dwmmr9m28l6fc;
		case "Ground Beef 1":
		case "Ground Beef 2":
			return _HylCIZnie9TY7iCNyKurgxQFFji;
		case "Ground beef bowl shadow":
		case "Ground beef bowl glow":
		case "Ground beef bowl":
			return !_HylCIZnie9TY7iCNyKurgxQFFji;
		case "OnionsGarlic 1":
		case "OnionsGarlic 2":
			return _HXs79I5YAlnCxHxJS0JxD7jccyt;
		}
	}

	private void RefreshSubscene()
	{
		_K8aZsmpWRImwc2JedT7KcW3wdYQ = true;
		_h5v8MyOj54KK9SVZpYnagzRPLMP = false;
		_HXs79I5YAlnCxHxJS0JxD7jccyt = false;
		_HylCIZnie9TY7iCNyKurgxQFFji = false;
		_mOljPVTpQkVD6dwmmr9m28l6fc = false;
		_g0GLDf9i20jtYweGI1DAr0f9WON = false;
		_ylWBqGZTor7PB0HyMRwAuoV4hvH = false;
		_NDwc6JiCbSmdqmQRU3taXzILgTBb = new List<EIngrediants>();
		_bFjOLB3sqVGFgwwMENJRlZ5vouC.SetVisibility(0f);
		_WwmWk5kaVSyVGOqHYV9xCL01Mmq.PlayNext();
		_bFjOLB3sqVGFgwwMENJRlZ5vouC.StartAnimation("Pan spawn", delegate
		{
			_K8aZsmpWRImwc2JedT7KcW3wdYQ = false;
		});
		_tJRouny7ZhgCxrAgyXFLsqSeAMT = EIngrediants.None;
	}

	public override void Update(GameTime gameTime)
	{
		base.Update(gameTime);
		if (_Iqfa1mamDp2busajsE8iPWnCKbDA)
		{
			_eRokloBwt8FsjBWpKBDmNKscCLH += (float)gameTime.ElapsedGameTime.Milliseconds / 1000f;
			if (_eRokloBwt8FsjBWpKBDmNKscCLH > 3f)
			{
				_Iqfa1mamDp2busajsE8iPWnCKbDA = false;
				_vXYwDfsbbgNVJzdeudgo8WR1maV();
			}
		}
		if (Completable || !_c9i4Rbj8ENw5b6aqNq271voBctc)
		{
			return;
		}
		if (_oadA2EQp5TIkaydfB8B5lpw5Cmu)
		{
			_2Kg9JelDMoLPl78Uv5Lb5ygQff += (float)gameTime.ElapsedGameTime.Milliseconds / 1000f;
		}
		if (_K8aZsmpWRImwc2JedT7KcW3wdYQ || _p28QNaoEJvHENbJjA4icWq92tkI || _h5v8MyOj54KK9SVZpYnagzRPLMP)
		{
			return;
		}
		Point point = base.Game.Mouse.Rescale(base.Game.Controller.Cursor);
		if (_HXs79I5YAlnCxHxJS0JxD7jccyt || !_bFjOLB3sqVGFgwwMENJRlZ5vouC.InAttachment("Onions bowl glow", point.X, point.Y))
		{
			_bFjOLB3sqVGFgwwMENJRlZ5vouC.SetAlpha("Onions bowl glow", 0f);
		}
		else
		{
			_QMxAinggzISmU1LmkqSK0bfv9h5("OnionsGarlic highlight", EIngrediants.OnionsGarlic, _R1mDpxg72ZTKnMeOQ0sH8szndlG);
			if (base.Game.Controller.JustPressed(ControllerButtonType.LeftButton))
			{
				_7UQ7J6jOjw0vBiKHgcli5eXatrN();
			}
		}
		if (_HylCIZnie9TY7iCNyKurgxQFFji || !_bFjOLB3sqVGFgwwMENJRlZ5vouC.InAttachment("Ground beef bowl glow", point.X, point.Y))
		{
			_bFjOLB3sqVGFgwwMENJRlZ5vouC.SetAlpha("Ground beef bowl glow", 0f);
		}
		else
		{
			_QMxAinggzISmU1LmkqSK0bfv9h5("Ground beef highlight", EIngrediants.GroundBeef, _E5COS2Wew1BQS9CZNJcDAnV99Y);
			if (base.Game.Controller.JustPressed(ControllerButtonType.LeftButton))
			{
				_KS0Vtg4XWGmpAsqFy5tYlJXLKLA();
			}
		}
		if (_mOljPVTpQkVD6dwmmr9m28l6fc || !_bFjOLB3sqVGFgwwMENJRlZ5vouC.InAttachment("Carrot bowl gold", point.X, point.Y))
		{
			_bFjOLB3sqVGFgwwMENJRlZ5vouC.SetAlpha("Carrot bowl gold", 0f);
		}
		else
		{
			_QMxAinggzISmU1LmkqSK0bfv9h5("Carrot highlight", EIngrediants.Carrots, _NCyPsw4quyw64ZmYLMqlIaQaclA);
			if (base.Game.Controller.JustPressed(ControllerButtonType.LeftButton))
			{
				_VcZyHKzhoXLGNA1DIp006kBhiDN();
			}
		}
		if (!_g0GLDf9i20jtYweGI1DAr0f9WON && _bFjOLB3sqVGFgwwMENJRlZ5vouC.InAttachment("Tomatoe bowl gold", point.X, point.Y))
		{
			_QMxAinggzISmU1LmkqSK0bfv9h5("Tomatoe highlight", EIngrediants.TinnedTomatoes, _gDkX1mAt76eLA8P3gGXs2wM5wTE);
			if (base.Game.Controller.JustPressed(ControllerButtonType.LeftButton))
			{
				_FJRq83fBqGFaoHbsYpaAVoouvFQ();
			}
		}
		else
		{
			_bFjOLB3sqVGFgwwMENJRlZ5vouC.SetAlpha("Tomatoe bowl gold", 0f);
		}
		if (!_ylWBqGZTor7PB0HyMRwAuoV4hvH && _bFjOLB3sqVGFgwwMENJRlZ5vouC.InAttachment("Bayleaves bowl glow", point.X, point.Y))
		{
			_QMxAinggzISmU1LmkqSK0bfv9h5("Bay highlight", EIngrediants.Herbs, _7f8HjbO7kyXkAQLb2mIqPJKHcLb);
			if (base.Game.Controller.JustPressed(ControllerButtonType.LeftButton))
			{
				_hHMvLMSFiOFnDNkhUnBcQpsEN9T();
			}
		}
		else
		{
			_bFjOLB3sqVGFgwwMENJRlZ5vouC.SetAlpha("Bayleaves bowl glow", 0f);
		}
	}

	private void _QMxAinggzISmU1LmkqSK0bfv9h5(string string_0, EIngrediants eingrediants_0, RandomSoundEffect _hqmu3NsKXqziXGfVh3dt79G0fye_0)
	{
		if (_tJRouny7ZhgCxrAgyXFLsqSeAMT != eingrediants_0)
		{
			_hqmu3NsKXqziXGfVh3dt79G0fye_0.PlayNext();
			_bFjOLB3sqVGFgwwMENJRlZ5vouC.StartAnimation(string_0);
		}
		_tJRouny7ZhgCxrAgyXFLsqSeAMT = eingrediants_0;
	}

	public void _7UQ7J6jOjw0vBiKHgcli5eXatrN()
	{
		if (!_p28QNaoEJvHENbJjA4icWq92tkI && !_HXs79I5YAlnCxHxJS0JxD7jccyt)
		{
			_p28QNaoEJvHENbJjA4icWq92tkI = true;
			_Yl6cx6lo29nhZhAYCwYNXftaePb.PlayNext();
			_bFjOLB3sqVGFgwwMENJRlZ5vouC.StartAnimation("OnionsGarlic toss", delegate
			{
				_HXs79I5YAlnCxHxJS0JxD7jccyt = true;
				_n5dqiyQaiIqiC4wtWicCzzA8coG(EIngrediants.OnionsGarlic);
			});
		}
	}

	public void _KS0Vtg4XWGmpAsqFy5tYlJXLKLA()
	{
		if (!_p28QNaoEJvHENbJjA4icWq92tkI && !_HylCIZnie9TY7iCNyKurgxQFFji)
		{
			_p28QNaoEJvHENbJjA4icWq92tkI = true;
			_Yl6cx6lo29nhZhAYCwYNXftaePb.PlayNext();
			_bFjOLB3sqVGFgwwMENJRlZ5vouC.StartAnimation("Ground beef toss", delegate
			{
				_HylCIZnie9TY7iCNyKurgxQFFji = true;
				_n5dqiyQaiIqiC4wtWicCzzA8coG(EIngrediants.GroundBeef);
			});
		}
	}

	public void _VcZyHKzhoXLGNA1DIp006kBhiDN()
	{
		if (!_p28QNaoEJvHENbJjA4icWq92tkI && !_mOljPVTpQkVD6dwmmr9m28l6fc)
		{
			_p28QNaoEJvHENbJjA4icWq92tkI = true;
			_Yl6cx6lo29nhZhAYCwYNXftaePb.PlayNext();
			_bFjOLB3sqVGFgwwMENJRlZ5vouC.StartAnimation("Carrot toss", delegate
			{
				_mOljPVTpQkVD6dwmmr9m28l6fc = true;
				_n5dqiyQaiIqiC4wtWicCzzA8coG(EIngrediants.Carrots);
			});
		}
	}

	public void _FJRq83fBqGFaoHbsYpaAVoouvFQ()
	{
		if (!_p28QNaoEJvHENbJjA4icWq92tkI && !_g0GLDf9i20jtYweGI1DAr0f9WON)
		{
			_p28QNaoEJvHENbJjA4icWq92tkI = true;
			_Yl6cx6lo29nhZhAYCwYNXftaePb.PlayNext();
			_bFjOLB3sqVGFgwwMENJRlZ5vouC.StartAnimation("Tomatoe toss", delegate
			{
				_g0GLDf9i20jtYweGI1DAr0f9WON = true;
				_n5dqiyQaiIqiC4wtWicCzzA8coG(EIngrediants.TinnedTomatoes);
			});
		}
	}

	public void _hHMvLMSFiOFnDNkhUnBcQpsEN9T()
	{
		if (!_p28QNaoEJvHENbJjA4icWq92tkI && !_ylWBqGZTor7PB0HyMRwAuoV4hvH)
		{
			_p28QNaoEJvHENbJjA4icWq92tkI = true;
			_Yl6cx6lo29nhZhAYCwYNXftaePb.PlayNext();
			_bFjOLB3sqVGFgwwMENJRlZ5vouC.StartAnimation("Bay toss", delegate
			{
				_ylWBqGZTor7PB0HyMRwAuoV4hvH = true;
				_n5dqiyQaiIqiC4wtWicCzzA8coG(EIngrediants.Herbs);
			});
		}
	}

	private void _n5dqiyQaiIqiC4wtWicCzzA8coG(EIngrediants eingrediants_0)
	{
		_bFjOLB3sqVGFgwwMENJRlZ5vouC.RestartAnimation();
		if (eingrediants_0 == EIngrediants.Pasta)
		{
			_bFjOLB3sqVGFgwwMENJRlZ5vouC.StartAnimation("Ingrediant mixing", delegate
			{
				_MOR64YNiUTpJJkXDvGxkr2BYs4n();
				_bFjOLB3sqVGFgwwMENJRlZ5vouC.StartAnimation("Shits burning", _Ee9VcMQIfuD0ElqFdXVvMHxofkf);
			});
		}
		else
		{
			_NDwc6JiCbSmdqmQRU3taXzILgTBb.Add(eingrediants_0);
			_bFjOLB3sqVGFgwwMENJRlZ5vouC.StartAnimation("Ingrediant mixing", _N6dXvS7twg0NRk66JAgWjTvfMRC);
		}
	}

	private void _MOR64YNiUTpJJkXDvGxkr2BYs4n()
	{
		_vdz7lnEalvPxBPYYcR15bPICZOc.PlayNext();
		_oadA2EQp5TIkaydfB8B5lpw5Cmu = true;
		_2Kg9JelDMoLPl78Uv5Lb5ygQff = 0f;
		_overlay._k8HavJ0P5yWjzHBpsDOOGVNY8MM = true;
	}

	private void _Ee9VcMQIfuD0ElqFdXVvMHxofkf()
	{
		_oadA2EQp5TIkaydfB8B5lpw5Cmu = false;
		_overlay._k8HavJ0P5yWjzHBpsDOOGVNY8MM = false;
		_JuZlzgvacKG5z0tmPuFzmPPGDog = _2Kg9JelDMoLPl78Uv5Lb5ygQff;
		_bFjOLB3sqVGFgwwMENJRlZ5vouC.ResetAnimation();
		_N6dXvS7twg0NRk66JAgWjTvfMRC();
	}

	private void _N6dXvS7twg0NRk66JAgWjTvfMRC()
	{
		if (_h5v8MyOj54KK9SVZpYnagzRPLMP)
		{
			Completable = true;
		}
		else if (_NDwc6JiCbSmdqmQRU3taXzILgTBb.Count >= 5)
		{
			_LWHyrTq71jxy9B95UaU1a22AmHG();
		}
		else
		{
			_p28QNaoEJvHENbJjA4icWq92tkI = false;
		}
	}

	private void _LWHyrTq71jxy9B95UaU1a22AmHG()
	{
		_h5v8MyOj54KK9SVZpYnagzRPLMP = true;
		_Yl6cx6lo29nhZhAYCwYNXftaePb.PlayNext();
		_n5dqiyQaiIqiC4wtWicCzzA8coG(EIngrediants.Pasta);
	}

	public void _NvWWx67tvkIBmEn9fgXJ9ZzWJMS()
	{
		_T81AMuUIGw7sZkYmJkIpiDPosrD = false;
		FadingMediaPlayer.ApplyNow(0f);
		base.Game.Fading.FadeOut(delegate
		{
			_3h9I4xBs98PF8vAbLXJAdpmHA8dA.PlayNext();
			_Iqfa1mamDp2busajsE8iPWnCKbDA = true;
		});
	}

	private void _vXYwDfsbbgNVJzdeudgo8WR1maV()
	{
		int num = 0;
		int i = 0;
		int num2 = 0;
		for (; i < _NDwc6JiCbSmdqmQRU3taXzILgTBb.Count; i++)
		{
			EIngrediants eIngrediants = _NDwc6JiCbSmdqmQRU3taXzILgTBb[i];
			if (eIngrediants == (EIngrediants)num2)
			{
				num2++;
			}
			else
			{
				num++;
			}
		}
		bool _Y8SewnxQuAuHOtMeTeuRSJlpbGJ;
		bool _YVtICgpvRZU0ZRqniFuAVlkSOFM;
		if (!(_JuZlzgvacKG5z0tmPuFzmPPGDog < 2.5f) && _JuZlzgvacKG5z0tmPuFzmPPGDog <= 4.5f)
		{
			switch (num)
			{
			default:
				_Y8SewnxQuAuHOtMeTeuRSJlpbGJ = true;
				_YVtICgpvRZU0ZRqniFuAVlkSOFM = false;
				break;
			case 1:
			case 2:
				_Y8SewnxQuAuHOtMeTeuRSJlpbGJ = false;
				_YVtICgpvRZU0ZRqniFuAVlkSOFM = false;
				break;
			case 0:
				_Y8SewnxQuAuHOtMeTeuRSJlpbGJ = false;
				_YVtICgpvRZU0ZRqniFuAVlkSOFM = true;
				break;
			}
		}
		else
		{
			_Y8SewnxQuAuHOtMeTeuRSJlpbGJ = true;
			_YVtICgpvRZU0ZRqniFuAVlkSOFM = false;
		}
		PlayerPreferences.GetPlayerData().SetFlag("Pasta.Poor", _Y8SewnxQuAuHOtMeTeuRSJlpbGJ);
		PlayerPreferences.GetPlayerData().SetFlag("Pasta.Perfect", _YVtICgpvRZU0ZRqniFuAVlkSOFM);
		_urxVZoSWXCtbeM9oQmVXW0Fb7co.Visible = _Y8SewnxQuAuHOtMeTeuRSJlpbGJ;
		_RZsDgwVY7R44E6mMbUF7YWYyBjK.Visible = !_Y8SewnxQuAuHOtMeTeuRSJlpbGJ && !_YVtICgpvRZU0ZRqniFuAVlkSOFM;
		_9cxzh98qcLMOVst3Rlmc4AaYoBp.Visible = _YVtICgpvRZU0ZRqniFuAVlkSOFM;
		base.Game.Fading.FadeIn(delegate
		{
			if (_YVtICgpvRZU0ZRqniFuAVlkSOFM)
			{
				base.Game.Achievements.GainAchievement(Achievements.AchievementGeneric11);
				_MHlWAOoiEHfmdM0FqWO6WSRbC1hA.PlayNext();
			}
			else if (_Y8SewnxQuAuHOtMeTeuRSJlpbGJ)
			{
				_QQrPUpwIvHnFnZeHb0cfL7CPSHh.PlayNext();
			}
			else
			{
				_8CTAuE7kLwrQAWKi1EOgTa2AKEx.PlayNext();
			}
			_T81AMuUIGw7sZkYmJkIpiDPosrD = true;
		});
	}
}
