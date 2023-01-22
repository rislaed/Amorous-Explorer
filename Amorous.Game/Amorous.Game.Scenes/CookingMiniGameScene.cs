using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Spine;

namespace Amorous.Game.Scenes;

public class CookingMiniGameScene : _7UlnfykmEmZDFt3BmCKZekI43Ih
{
	private class GUI : _8lVOgkauaSHbAkAqHzI1K7mIyOI
	{
		private readonly _iHJrndJdM1jj9TEnuU3BvgdDuvf _wmL1cFR5CsMqZS9jOXyCnmqveCG;

		public bool _k8HavJ0P5yWjzHBpsDOOGVNY8MM
		{
			set
			{
				_wmL1cFR5CsMqZS9jOXyCnmqveCG._Fxy2SlgceW90FloFw6a1AEJODYA = value;
			}
		}

		public GUI(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0, Action action_0)
			: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		{
			_wmL1cFR5CsMqZS9jOXyCnmqveCG = _QVqIVxBeF2SAQh6HDFwwp2RFmXB("Assets/Scenes/Cooking/Button", "Assets/Scenes/Cooking/Button hover", "Assets/Gui/Fonts/Bold-26", "Stop cooking!", Color.White, 832, 970, new Rectangle(832, 970, 256, 102), action_0);
			_wmL1cFR5CsMqZS9jOXyCnmqveCG._Fxy2SlgceW90FloFw6a1AEJODYA = false;
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

	private readonly GUI _fp8jsuSnELXqf2yy2JQDaXDCBVQ;

	private readonly _nHdiyIURlAiaNZ8u6MKzxjcwnyL _bFjOLB3sqVGFgwwMENJRlZ5vouC;

	private readonly _hqmu3NsKXqziXGfVh3dt79G0fye _WwmWk5kaVSyVGOqHYV9xCL01Mmq;

	private readonly _hqmu3NsKXqziXGfVh3dt79G0fye _Yl6cx6lo29nhZhAYCwYNXftaePb;

	private readonly _hqmu3NsKXqziXGfVh3dt79G0fye _R1mDpxg72ZTKnMeOQ0sH8szndlG;

	private readonly _hqmu3NsKXqziXGfVh3dt79G0fye _E5COS2Wew1BQS9CZNJcDAnV99Y;

	private readonly _hqmu3NsKXqziXGfVh3dt79G0fye _NCyPsw4quyw64ZmYLMqlIaQaclA;

	private readonly _hqmu3NsKXqziXGfVh3dt79G0fye _gDkX1mAt76eLA8P3gGXs2wM5wTE;

	private readonly _hqmu3NsKXqziXGfVh3dt79G0fye _7f8HjbO7kyXkAQLb2mIqPJKHcLb;

	private readonly _hqmu3NsKXqziXGfVh3dt79G0fye _vdz7lnEalvPxBPYYcR15bPICZOc;

	private readonly _hqmu3NsKXqziXGfVh3dt79G0fye _3h9I4xBs98PF8vAbLXJAdpmHA8dA;

	private readonly _hqmu3NsKXqziXGfVh3dt79G0fye _QQrPUpwIvHnFnZeHb0cfL7CPSHh;

	private readonly _hqmu3NsKXqziXGfVh3dt79G0fye _8CTAuE7kLwrQAWKi1EOgTa2AKEx;

	private readonly _hqmu3NsKXqziXGfVh3dt79G0fye _MHlWAOoiEHfmdM0FqWO6WSRbC1hA;

	private readonly _ujAkjlfN5TywwbLAUDzPvtab6uJ _urxVZoSWXCtbeM9oQmVXW0Fb7co;

	private readonly _ujAkjlfN5TywwbLAUDzPvtab6uJ _RZsDgwVY7R44E6mMbUF7YWYyBjK;

	private readonly _ujAkjlfN5TywwbLAUDzPvtab6uJ _9cxzh98qcLMOVst3Rlmc4AaYoBp;

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

	public bool _xJZUPxDatEzfPQc0nRHR2D1Vwke { get; set; }

	public bool _T81AMuUIGw7sZkYmJkIpiDPosrD { get; set; }

	public CookingMiniGameScene(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		_fp8jsuSnELXqf2yy2JQDaXDCBVQ = new GUI(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0, _Ee9VcMQIfuD0ElqFdXVvMHxofkf);
		base._ZzBuoSDMWwerejOO9Goyv2OCKgE._lXEQJcXKxsjtZp00Y9aPe0ymGue(_fp8jsuSnELXqf2yy2JQDaXDCBVQ);
		_0O8D0mBgmrh0sLOGcLVvGNOHKLCA("Background", "Assets/Scenes/Cooking/Background", 0, 0);
		_urxVZoSWXCtbeM9oQmVXW0Fb7co = _NC5VT77x8y2iH2pW56TBN1eyomA("Background", "Assets/Scenes/Cooking/Bad", 0, 0);
		_urxVZoSWXCtbeM9oQmVXW0Fb7co._Fxy2SlgceW90FloFw6a1AEJODYA = false;
		_RZsDgwVY7R44E6mMbUF7YWYyBjK = _NC5VT77x8y2iH2pW56TBN1eyomA("Background", "Assets/Scenes/Cooking/Okay", 0, 0);
		_RZsDgwVY7R44E6mMbUF7YWYyBjK._Fxy2SlgceW90FloFw6a1AEJODYA = false;
		_9cxzh98qcLMOVst3Rlmc4AaYoBp = _NC5VT77x8y2iH2pW56TBN1eyomA("Background", "Assets/Scenes/Cooking/Excellent", 0, 0);
		_9cxzh98qcLMOVst3Rlmc4AaYoBp._Fxy2SlgceW90FloFw6a1AEJODYA = false;
		_WBXNT6eIVGk6ZKExRBJ6JxXE6zb wBXNT6eIVGk6ZKExRBJ6JxXE6zb = new _WBXNT6eIVGk6ZKExRBJ6JxXE6zb(this, "Cooking");
		_bFjOLB3sqVGFgwwMENJRlZ5vouC = _JbeCmOie0phb2cbgG6DdGZrbs3pB_0._uwNDZuqdFb9tyQtlQMxiz1DQ7x8._7BVREQXEcBCieHb0qgaVDpUj1ni("Assets/Scenes/Cooking/Cooking");
		_bFjOLB3sqVGFgwwMENJRlZ5vouC._7Xn1C5tjYnmIif1iZKV8AWsEEbL = 960f;
		_bFjOLB3sqVGFgwwMENJRlZ5vouC._bCjZ3VSXGKyhmykd2zCnQBiSpDf = 540f;
		_WwmWk5kaVSyVGOqHYV9xCL01Mmq = new _hqmu3NsKXqziXGfVh3dt79G0fye(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0._uwNDZuqdFb9tyQtlQMxiz1DQ7x8);
		_WwmWk5kaVSyVGOqHYV9xCL01Mmq._cHRhcv3PTfJmYNZAZdcHvbfbkpj("Assets/Sounds/MiniGames/Cooking/Pan spawn");
		_Yl6cx6lo29nhZhAYCwYNXftaePb = new _hqmu3NsKXqziXGfVh3dt79G0fye(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0._uwNDZuqdFb9tyQtlQMxiz1DQ7x8);
		_Yl6cx6lo29nhZhAYCwYNXftaePb._cHRhcv3PTfJmYNZAZdcHvbfbkpj("Assets/Sounds/MiniGames/Cooking/Add ingrediant");
		_R1mDpxg72ZTKnMeOQ0sH8szndlG = new _hqmu3NsKXqziXGfVh3dt79G0fye(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0._uwNDZuqdFb9tyQtlQMxiz1DQ7x8);
		_R1mDpxg72ZTKnMeOQ0sH8szndlG._cHRhcv3PTfJmYNZAZdcHvbfbkpj("Assets/Sounds/MiniGames/Cooking/Onion");
		_E5COS2Wew1BQS9CZNJcDAnV99Y = new _hqmu3NsKXqziXGfVh3dt79G0fye(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0._uwNDZuqdFb9tyQtlQMxiz1DQ7x8);
		_E5COS2Wew1BQS9CZNJcDAnV99Y._cHRhcv3PTfJmYNZAZdcHvbfbkpj("Assets/Sounds/MiniGames/Cooking/Beef");
		_NCyPsw4quyw64ZmYLMqlIaQaclA = new _hqmu3NsKXqziXGfVh3dt79G0fye(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0._uwNDZuqdFb9tyQtlQMxiz1DQ7x8);
		_NCyPsw4quyw64ZmYLMqlIaQaclA._cHRhcv3PTfJmYNZAZdcHvbfbkpj("Assets/Sounds/MiniGames/Cooking/Carrots");
		_gDkX1mAt76eLA8P3gGXs2wM5wTE = new _hqmu3NsKXqziXGfVh3dt79G0fye(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0._uwNDZuqdFb9tyQtlQMxiz1DQ7x8);
		_gDkX1mAt76eLA8P3gGXs2wM5wTE._cHRhcv3PTfJmYNZAZdcHvbfbkpj("Assets/Sounds/MiniGames/Cooking/Tomatoe");
		_7f8HjbO7kyXkAQLb2mIqPJKHcLb = new _hqmu3NsKXqziXGfVh3dt79G0fye(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0._uwNDZuqdFb9tyQtlQMxiz1DQ7x8);
		_7f8HjbO7kyXkAQLb2mIqPJKHcLb._cHRhcv3PTfJmYNZAZdcHvbfbkpj("Assets/Sounds/MiniGames/Cooking/Bay leaves");
		_vdz7lnEalvPxBPYYcR15bPICZOc = new _hqmu3NsKXqziXGfVh3dt79G0fye(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0._uwNDZuqdFb9tyQtlQMxiz1DQ7x8);
		_vdz7lnEalvPxBPYYcR15bPICZOc._cHRhcv3PTfJmYNZAZdcHvbfbkpj("Assets/Sounds/MiniGames/Cooking/Burning");
		_3h9I4xBs98PF8vAbLXJAdpmHA8dA = new _hqmu3NsKXqziXGfVh3dt79G0fye(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0._uwNDZuqdFb9tyQtlQMxiz1DQ7x8);
		_3h9I4xBs98PF8vAbLXJAdpmHA8dA._cHRhcv3PTfJmYNZAZdcHvbfbkpj("Assets/Sounds/MiniGames/Cooking/Drum roll");
		_QQrPUpwIvHnFnZeHb0cfL7CPSHh = new _hqmu3NsKXqziXGfVh3dt79G0fye(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0._uwNDZuqdFb9tyQtlQMxiz1DQ7x8);
		_QQrPUpwIvHnFnZeHb0cfL7CPSHh._cHRhcv3PTfJmYNZAZdcHvbfbkpj("Assets/Sounds/MiniGames/Cooking/Bad food");
		_8CTAuE7kLwrQAWKi1EOgTa2AKEx = new _hqmu3NsKXqziXGfVh3dt79G0fye(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0._uwNDZuqdFb9tyQtlQMxiz1DQ7x8);
		_8CTAuE7kLwrQAWKi1EOgTa2AKEx._cHRhcv3PTfJmYNZAZdcHvbfbkpj("Assets/Sounds/MiniGames/Cooking/Ok food");
		_MHlWAOoiEHfmdM0FqWO6WSRbC1hA = new _hqmu3NsKXqziXGfVh3dt79G0fye(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0._uwNDZuqdFb9tyQtlQMxiz1DQ7x8);
		_MHlWAOoiEHfmdM0FqWO6WSRbC1hA._cHRhcv3PTfJmYNZAZdcHvbfbkpj("Assets/Sounds/MiniGames/Cooking/Great food");
		_coudx6g9HL4THj8r5aYCDxaHH0I();
		wBXNT6eIVGk6ZKExRBJ6JxXE6zb._NC5P3SKqKPpcAYG1mqquUEcUzTg = delegate(GameTime gameTime_0)
		{
			_bFjOLB3sqVGFgwwMENJRlZ5vouC._tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime_0);
		};
		wBXNT6eIVGk6ZKExRBJ6JxXE6zb._Wb2e00OWt8kBwGWEXtOGMVScRPm = delegate(SpriteBatch spriteBatch_0, SkeletonMeshRenderer skeletonMeshRenderer_0)
		{
			_bFjOLB3sqVGFgwwMENJRlZ5vouC._f5ctqAmdNsZ889UjM4LxDm8WGxA(skeletonMeshRenderer_0, null, _YwAdHC5A5VB16lereNxJLkAP3Z9A);
		};
		_7oYtfGpL7UyAQrZxew7Ahbvj6Sv(wBXNT6eIVGk6ZKExRBJ6JxXE6zb, 0);
		_UmxbIbk7pgaod0bD7pS309P3Lns._l94kUraQ13OohoVwwxKC37hG7Pc("Assets/Music/Warhector - Free Floating", 0.1f);
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

	private void _coudx6g9HL4THj8r5aYCDxaHH0I()
	{
		_K8aZsmpWRImwc2JedT7KcW3wdYQ = true;
		_h5v8MyOj54KK9SVZpYnagzRPLMP = false;
		_HXs79I5YAlnCxHxJS0JxD7jccyt = false;
		_HylCIZnie9TY7iCNyKurgxQFFji = false;
		_mOljPVTpQkVD6dwmmr9m28l6fc = false;
		_g0GLDf9i20jtYweGI1DAr0f9WON = false;
		_ylWBqGZTor7PB0HyMRwAuoV4hvH = false;
		_NDwc6JiCbSmdqmQRU3taXzILgTBb = new List<EIngrediants>();
		_bFjOLB3sqVGFgwwMENJRlZ5vouC._c4iC7y9v6xg7LpvjKIeUkOdZ3UF(0f);
		_WwmWk5kaVSyVGOqHYV9xCL01Mmq._xDFlaclLtJxSUU63JEJALvRLdfe();
		_bFjOLB3sqVGFgwwMENJRlZ5vouC._SPUoP3ABwpgQinJfKUM5qBbYSvr("Pan spawn", delegate
		{
			_K8aZsmpWRImwc2JedT7KcW3wdYQ = false;
		});
		_tJRouny7ZhgCxrAgyXFLsqSeAMT = EIngrediants.None;
	}

	public override void _tiBFUHPEkedkbgvuX3whdeyjhKo(GameTime gameTime_0)
	{
		base._tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime_0);
		if (_Iqfa1mamDp2busajsE8iPWnCKbDA)
		{
			_eRokloBwt8FsjBWpKBDmNKscCLH += (float)gameTime_0.ElapsedGameTime.Milliseconds / 1000f;
			if (_eRokloBwt8FsjBWpKBDmNKscCLH > 3f)
			{
				_Iqfa1mamDp2busajsE8iPWnCKbDA = false;
				_vXYwDfsbbgNVJzdeudgo8WR1maV();
			}
		}
		if (_xJZUPxDatEzfPQc0nRHR2D1Vwke || !_c9i4Rbj8ENw5b6aqNq271voBctc)
		{
			return;
		}
		if (_oadA2EQp5TIkaydfB8B5lpw5Cmu)
		{
			_2Kg9JelDMoLPl78Uv5Lb5ygQff += (float)gameTime_0.ElapsedGameTime.Milliseconds / 1000f;
		}
		if (_K8aZsmpWRImwc2JedT7KcW3wdYQ || _p28QNaoEJvHENbJjA4icWq92tkI || _h5v8MyOj54KK9SVZpYnagzRPLMP)
		{
			return;
		}
		Point point = base._ZzBuoSDMWwerejOO9Goyv2OCKgE._vsceSzSIjBy2nZrCxAzKZbUiwLq._u7uCdK9i8FnWhiaPn2bO2wIgUUuA(base._ZzBuoSDMWwerejOO9Goyv2OCKgE._RbWJ7YGnYHCSoD44MRW1h5X6E7E._U7CeYBJ1v1SoUxpX8emsQ9mWl5b);
		if (_HXs79I5YAlnCxHxJS0JxD7jccyt || !_bFjOLB3sqVGFgwwMENJRlZ5vouC._3nKd9Dk3YeX87QB5dROwYUzczsN("Onions bowl glow", point.X, point.Y))
		{
			_bFjOLB3sqVGFgwwMENJRlZ5vouC._aAoZaDNczeScsMfLlGSfAzey9SQ("Onions bowl glow", 0f);
		}
		else
		{
			_QMxAinggzISmU1LmkqSK0bfv9h5("OnionsGarlic highlight", EIngrediants.OnionsGarlic, _R1mDpxg72ZTKnMeOQ0sH8szndlG);
			if (base._ZzBuoSDMWwerejOO9Goyv2OCKgE._RbWJ7YGnYHCSoD44MRW1h5X6E7E._fy5ebLnmRsRXv9v7RKTFU5CGMaH(_PMeRYZJaBCqgB9uADJFP3c14lxq.LeftButton))
			{
				_7UQ7J6jOjw0vBiKHgcli5eXatrN();
			}
		}
		if (_HylCIZnie9TY7iCNyKurgxQFFji || !_bFjOLB3sqVGFgwwMENJRlZ5vouC._3nKd9Dk3YeX87QB5dROwYUzczsN("Ground beef bowl glow", point.X, point.Y))
		{
			_bFjOLB3sqVGFgwwMENJRlZ5vouC._aAoZaDNczeScsMfLlGSfAzey9SQ("Ground beef bowl glow", 0f);
		}
		else
		{
			_QMxAinggzISmU1LmkqSK0bfv9h5("Ground beef highlight", EIngrediants.GroundBeef, _E5COS2Wew1BQS9CZNJcDAnV99Y);
			if (base._ZzBuoSDMWwerejOO9Goyv2OCKgE._RbWJ7YGnYHCSoD44MRW1h5X6E7E._fy5ebLnmRsRXv9v7RKTFU5CGMaH(_PMeRYZJaBCqgB9uADJFP3c14lxq.LeftButton))
			{
				_KS0Vtg4XWGmpAsqFy5tYlJXLKLA();
			}
		}
		if (_mOljPVTpQkVD6dwmmr9m28l6fc || !_bFjOLB3sqVGFgwwMENJRlZ5vouC._3nKd9Dk3YeX87QB5dROwYUzczsN("Carrot bowl gold", point.X, point.Y))
		{
			_bFjOLB3sqVGFgwwMENJRlZ5vouC._aAoZaDNczeScsMfLlGSfAzey9SQ("Carrot bowl gold", 0f);
		}
		else
		{
			_QMxAinggzISmU1LmkqSK0bfv9h5("Carrot highlight", EIngrediants.Carrots, _NCyPsw4quyw64ZmYLMqlIaQaclA);
			if (base._ZzBuoSDMWwerejOO9Goyv2OCKgE._RbWJ7YGnYHCSoD44MRW1h5X6E7E._fy5ebLnmRsRXv9v7RKTFU5CGMaH(_PMeRYZJaBCqgB9uADJFP3c14lxq.LeftButton))
			{
				_VcZyHKzhoXLGNA1DIp006kBhiDN();
			}
		}
		if (!_g0GLDf9i20jtYweGI1DAr0f9WON && _bFjOLB3sqVGFgwwMENJRlZ5vouC._3nKd9Dk3YeX87QB5dROwYUzczsN("Tomatoe bowl gold", point.X, point.Y))
		{
			_QMxAinggzISmU1LmkqSK0bfv9h5("Tomatoe highlight", EIngrediants.TinnedTomatoes, _gDkX1mAt76eLA8P3gGXs2wM5wTE);
			if (base._ZzBuoSDMWwerejOO9Goyv2OCKgE._RbWJ7YGnYHCSoD44MRW1h5X6E7E._fy5ebLnmRsRXv9v7RKTFU5CGMaH(_PMeRYZJaBCqgB9uADJFP3c14lxq.LeftButton))
			{
				_FJRq83fBqGFaoHbsYpaAVoouvFQ();
			}
		}
		else
		{
			_bFjOLB3sqVGFgwwMENJRlZ5vouC._aAoZaDNczeScsMfLlGSfAzey9SQ("Tomatoe bowl gold", 0f);
		}
		if (!_ylWBqGZTor7PB0HyMRwAuoV4hvH && _bFjOLB3sqVGFgwwMENJRlZ5vouC._3nKd9Dk3YeX87QB5dROwYUzczsN("Bayleaves bowl glow", point.X, point.Y))
		{
			_QMxAinggzISmU1LmkqSK0bfv9h5("Bay highlight", EIngrediants.Herbs, _7f8HjbO7kyXkAQLb2mIqPJKHcLb);
			if (base._ZzBuoSDMWwerejOO9Goyv2OCKgE._RbWJ7YGnYHCSoD44MRW1h5X6E7E._fy5ebLnmRsRXv9v7RKTFU5CGMaH(_PMeRYZJaBCqgB9uADJFP3c14lxq.LeftButton))
			{
				_hHMvLMSFiOFnDNkhUnBcQpsEN9T();
			}
		}
		else
		{
			_bFjOLB3sqVGFgwwMENJRlZ5vouC._aAoZaDNczeScsMfLlGSfAzey9SQ("Bayleaves bowl glow", 0f);
		}
	}

	private void _QMxAinggzISmU1LmkqSK0bfv9h5(string string_0, EIngrediants eingrediants_0, _hqmu3NsKXqziXGfVh3dt79G0fye _hqmu3NsKXqziXGfVh3dt79G0fye_0)
	{
		if (_tJRouny7ZhgCxrAgyXFLsqSeAMT != eingrediants_0)
		{
			_hqmu3NsKXqziXGfVh3dt79G0fye_0._xDFlaclLtJxSUU63JEJALvRLdfe();
			_bFjOLB3sqVGFgwwMENJRlZ5vouC._SPUoP3ABwpgQinJfKUM5qBbYSvr(string_0);
		}
		_tJRouny7ZhgCxrAgyXFLsqSeAMT = eingrediants_0;
	}

	public void _7UQ7J6jOjw0vBiKHgcli5eXatrN()
	{
		if (!_p28QNaoEJvHENbJjA4icWq92tkI && !_HXs79I5YAlnCxHxJS0JxD7jccyt)
		{
			_p28QNaoEJvHENbJjA4icWq92tkI = true;
			_Yl6cx6lo29nhZhAYCwYNXftaePb._xDFlaclLtJxSUU63JEJALvRLdfe();
			_bFjOLB3sqVGFgwwMENJRlZ5vouC._SPUoP3ABwpgQinJfKUM5qBbYSvr("OnionsGarlic toss", delegate
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
			_Yl6cx6lo29nhZhAYCwYNXftaePb._xDFlaclLtJxSUU63JEJALvRLdfe();
			_bFjOLB3sqVGFgwwMENJRlZ5vouC._SPUoP3ABwpgQinJfKUM5qBbYSvr("Ground beef toss", delegate
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
			_Yl6cx6lo29nhZhAYCwYNXftaePb._xDFlaclLtJxSUU63JEJALvRLdfe();
			_bFjOLB3sqVGFgwwMENJRlZ5vouC._SPUoP3ABwpgQinJfKUM5qBbYSvr("Carrot toss", delegate
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
			_Yl6cx6lo29nhZhAYCwYNXftaePb._xDFlaclLtJxSUU63JEJALvRLdfe();
			_bFjOLB3sqVGFgwwMENJRlZ5vouC._SPUoP3ABwpgQinJfKUM5qBbYSvr("Tomatoe toss", delegate
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
			_Yl6cx6lo29nhZhAYCwYNXftaePb._xDFlaclLtJxSUU63JEJALvRLdfe();
			_bFjOLB3sqVGFgwwMENJRlZ5vouC._SPUoP3ABwpgQinJfKUM5qBbYSvr("Bay toss", delegate
			{
				_ylWBqGZTor7PB0HyMRwAuoV4hvH = true;
				_n5dqiyQaiIqiC4wtWicCzzA8coG(EIngrediants.Herbs);
			});
		}
	}

	private void _n5dqiyQaiIqiC4wtWicCzzA8coG(EIngrediants eingrediants_0)
	{
		_bFjOLB3sqVGFgwwMENJRlZ5vouC._lkaN4ygxDlKvzKEBuD7dRjrU20F();
		if (eingrediants_0 == EIngrediants.Pasta)
		{
			_bFjOLB3sqVGFgwwMENJRlZ5vouC._SPUoP3ABwpgQinJfKUM5qBbYSvr("Ingrediant mixing", delegate
			{
				_MOR64YNiUTpJJkXDvGxkr2BYs4n();
				_bFjOLB3sqVGFgwwMENJRlZ5vouC._SPUoP3ABwpgQinJfKUM5qBbYSvr("Shits burning", _Ee9VcMQIfuD0ElqFdXVvMHxofkf);
			});
		}
		else
		{
			_NDwc6JiCbSmdqmQRU3taXzILgTBb.Add(eingrediants_0);
			_bFjOLB3sqVGFgwwMENJRlZ5vouC._SPUoP3ABwpgQinJfKUM5qBbYSvr("Ingrediant mixing", _N6dXvS7twg0NRk66JAgWjTvfMRC);
		}
	}

	private void _MOR64YNiUTpJJkXDvGxkr2BYs4n()
	{
		_vdz7lnEalvPxBPYYcR15bPICZOc._xDFlaclLtJxSUU63JEJALvRLdfe();
		_oadA2EQp5TIkaydfB8B5lpw5Cmu = true;
		_2Kg9JelDMoLPl78Uv5Lb5ygQff = 0f;
		_fp8jsuSnELXqf2yy2JQDaXDCBVQ._k8HavJ0P5yWjzHBpsDOOGVNY8MM = true;
	}

	private void _Ee9VcMQIfuD0ElqFdXVvMHxofkf()
	{
		_oadA2EQp5TIkaydfB8B5lpw5Cmu = false;
		_fp8jsuSnELXqf2yy2JQDaXDCBVQ._k8HavJ0P5yWjzHBpsDOOGVNY8MM = false;
		_JuZlzgvacKG5z0tmPuFzmPPGDog = _2Kg9JelDMoLPl78Uv5Lb5ygQff;
		_bFjOLB3sqVGFgwwMENJRlZ5vouC._d6HoyBFhu6xkBRCX00ZzeFUnWwF();
		_N6dXvS7twg0NRk66JAgWjTvfMRC();
	}

	private void _N6dXvS7twg0NRk66JAgWjTvfMRC()
	{
		if (_h5v8MyOj54KK9SVZpYnagzRPLMP)
		{
			_xJZUPxDatEzfPQc0nRHR2D1Vwke = true;
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
		_Yl6cx6lo29nhZhAYCwYNXftaePb._xDFlaclLtJxSUU63JEJALvRLdfe();
		_n5dqiyQaiIqiC4wtWicCzzA8coG(EIngrediants.Pasta);
	}

	public void _NvWWx67tvkIBmEn9fgXJ9ZzWJMS()
	{
		_T81AMuUIGw7sZkYmJkIpiDPosrD = false;
		_UmxbIbk7pgaod0bD7pS309P3Lns._E7yBM68AWt7OGHJ5D6xYA8RK8tAA(0f);
		base._ZzBuoSDMWwerejOO9Goyv2OCKgE._Qj2G6fpAF4mGsATgkV8DPBF3aA1A._PYAXEqRAOkDRRNqm1k71R7GJTJK(delegate
		{
			_3h9I4xBs98PF8vAbLXJAdpmHA8dA._xDFlaclLtJxSUU63JEJALvRLdfe();
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
		_Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t()._4Fscz8ryB3hm0NmL5xw39HHiPd1("Pasta.Poor", _Y8SewnxQuAuHOtMeTeuRSJlpbGJ);
		_Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t()._4Fscz8ryB3hm0NmL5xw39HHiPd1("Pasta.Perfect", _YVtICgpvRZU0ZRqniFuAVlkSOFM);
		_urxVZoSWXCtbeM9oQmVXW0Fb7co._Fxy2SlgceW90FloFw6a1AEJODYA = _Y8SewnxQuAuHOtMeTeuRSJlpbGJ;
		_RZsDgwVY7R44E6mMbUF7YWYyBjK._Fxy2SlgceW90FloFw6a1AEJODYA = !_Y8SewnxQuAuHOtMeTeuRSJlpbGJ && !_YVtICgpvRZU0ZRqniFuAVlkSOFM;
		_9cxzh98qcLMOVst3Rlmc4AaYoBp._Fxy2SlgceW90FloFw6a1AEJODYA = _YVtICgpvRZU0ZRqniFuAVlkSOFM;
		base._ZzBuoSDMWwerejOO9Goyv2OCKgE._Qj2G6fpAF4mGsATgkV8DPBF3aA1A._FegL010tc92iskjjyD0T33dDwNE(delegate
		{
			if (_YVtICgpvRZU0ZRqniFuAVlkSOFM)
			{
				base._ZzBuoSDMWwerejOO9Goyv2OCKgE._aJh9CibG5YKhkExxgRyVopdfSeJ._vVZVLriSGPExpn1KeobglMabsoi("AchievementGeneric11");
				_MHlWAOoiEHfmdM0FqWO6WSRbC1hA._xDFlaclLtJxSUU63JEJALvRLdfe();
			}
			else if (_Y8SewnxQuAuHOtMeTeuRSJlpbGJ)
			{
				_QQrPUpwIvHnFnZeHb0cfL7CPSHh._xDFlaclLtJxSUU63JEJALvRLdfe();
			}
			else
			{
				_8CTAuE7kLwrQAWKi1EOgTa2AKEx._xDFlaclLtJxSUU63JEJALvRLdfe();
			}
			_T81AMuUIGw7sZkYmJkIpiDPosrD = true;
		});
	}

	[CompilerGenerated]
	private void _NmaekdAD1gSPP5yCLnbnL1WAeD0A(GameTime gameTime_0)
	{
		_bFjOLB3sqVGFgwwMENJRlZ5vouC._tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime_0);
	}

	[CompilerGenerated]
	private void _fWa6DjrbaEPK1WLNZk8EF0EhF4k(SpriteBatch spriteBatch_0, SkeletonMeshRenderer skeletonMeshRenderer_0)
	{
		_bFjOLB3sqVGFgwwMENJRlZ5vouC._f5ctqAmdNsZ889UjM4LxDm8WGxA(skeletonMeshRenderer_0, null, _YwAdHC5A5VB16lereNxJLkAP3Z9A);
	}

	[CompilerGenerated]
	private void _C56Cr5G9WfXcGImyT8QeFsD2Uxj()
	{
		_K8aZsmpWRImwc2JedT7KcW3wdYQ = false;
	}

	[CompilerGenerated]
	private void _jsScVfnvxUDbq9nDCErcPAgZDRCA()
	{
		_HXs79I5YAlnCxHxJS0JxD7jccyt = true;
		_n5dqiyQaiIqiC4wtWicCzzA8coG(EIngrediants.OnionsGarlic);
	}

	[CompilerGenerated]
	private void _u1A8tlH4Pva4lsBCuCBgmdztTXG()
	{
		_HylCIZnie9TY7iCNyKurgxQFFji = true;
		_n5dqiyQaiIqiC4wtWicCzzA8coG(EIngrediants.GroundBeef);
	}

	[CompilerGenerated]
	private void _WtG9pBnQz1VMaCkOOLs8yDzfQ3G()
	{
		_mOljPVTpQkVD6dwmmr9m28l6fc = true;
		_n5dqiyQaiIqiC4wtWicCzzA8coG(EIngrediants.Carrots);
	}

	[CompilerGenerated]
	private void _mXM4ENlz9PvfKHf9jFBpDxs3vEB()
	{
		_g0GLDf9i20jtYweGI1DAr0f9WON = true;
		_n5dqiyQaiIqiC4wtWicCzzA8coG(EIngrediants.TinnedTomatoes);
	}

	[CompilerGenerated]
	private void _QBP2TNnNrr1iMrHFFGqet7ABSO()
	{
		_ylWBqGZTor7PB0HyMRwAuoV4hvH = true;
		_n5dqiyQaiIqiC4wtWicCzzA8coG(EIngrediants.Herbs);
	}

	[CompilerGenerated]
	private void _9NAQTxnipbPGv6LRIkqhUgKuPRh()
	{
		_MOR64YNiUTpJJkXDvGxkr2BYs4n();
		_bFjOLB3sqVGFgwwMENJRlZ5vouC._SPUoP3ABwpgQinJfKUM5qBbYSvr("Shits burning", _Ee9VcMQIfuD0ElqFdXVvMHxofkf);
	}

	[CompilerGenerated]
	private void _XB6neda1fTKa21CjFeAGR8iHx7Y()
	{
		_3h9I4xBs98PF8vAbLXJAdpmHA8dA._xDFlaclLtJxSUU63JEJALvRLdfe();
		_Iqfa1mamDp2busajsE8iPWnCKbDA = true;
	}
}
