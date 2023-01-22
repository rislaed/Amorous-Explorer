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
				GUI.smethod_3((_1dTaaW9MQWoHm2Pqblg0u9bPhpe)_wmL1cFR5CsMqZS9jOXyCnmqveCG, value);
			}
		}

		public GUI(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0, Action action_0)
			: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		{
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			_wmL1cFR5CsMqZS9jOXyCnmqveCG = _QVqIVxBeF2SAQh6HDFwwp2RFmXB("Assets/Scenes/Cooking/Button", "Assets/Scenes/Cooking/Button hover", "Assets/Gui/Fonts/Bold-26", "Stop cooking!", Color.get_White(), 832, 970, new Rectangle(832, 970, 256, 102), action_0);
			_wmL1cFR5CsMqZS9jOXyCnmqveCG._Fxy2SlgceW90FloFw6a1AEJODYA = false;
		}

		static void smethod_3(_1dTaaW9MQWoHm2Pqblg0u9bPhpe _1dTaaW9MQWoHm2Pqblg0u9bPhpe_0, bool bool_0)
		{
			_1dTaaW9MQWoHm2Pqblg0u9bPhpe_0._Fxy2SlgceW90FloFw6a1AEJODYA = bool_0;
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
		CookingMiniGameScene.smethod_14((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._lXEQJcXKxsjtZp00Y9aPe0ymGue(_fp8jsuSnELXqf2yy2JQDaXDCBVQ);
		CookingMiniGameScene.smethod_15((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Background", "Assets/Scenes/Cooking/Background", 0, 0);
		_urxVZoSWXCtbeM9oQmVXW0Fb7co = CookingMiniGameScene.smethod_16((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Background", "Assets/Scenes/Cooking/Bad", 0, 0);
		CookingMiniGameScene.smethod_17(_urxVZoSWXCtbeM9oQmVXW0Fb7co, bool_0: false);
		_RZsDgwVY7R44E6mMbUF7YWYyBjK = CookingMiniGameScene.smethod_16((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Background", "Assets/Scenes/Cooking/Okay", 0, 0);
		CookingMiniGameScene.smethod_17(_RZsDgwVY7R44E6mMbUF7YWYyBjK, bool_0: false);
		_9cxzh98qcLMOVst3Rlmc4AaYoBp = CookingMiniGameScene.smethod_16((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Background", "Assets/Scenes/Cooking/Excellent", 0, 0);
		CookingMiniGameScene.smethod_17(_9cxzh98qcLMOVst3Rlmc4AaYoBp, bool_0: false);
		_WBXNT6eIVGk6ZKExRBJ6JxXE6zb wBXNT6eIVGk6ZKExRBJ6JxXE6zb = CookingMiniGameScene.smethod_18((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Cooking");
		_bFjOLB3sqVGFgwwMENJRlZ5vouC = CookingMiniGameScene.smethod_20(CookingMiniGameScene.smethod_19(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0), "Assets/Scenes/Cooking/Cooking", 1f, bool_0: true, (List<SpineEvent>)null);
		CookingMiniGameScene.smethod_21(_bFjOLB3sqVGFgwwMENJRlZ5vouC, 960f);
		CookingMiniGameScene.smethod_22(_bFjOLB3sqVGFgwwMENJRlZ5vouC, 540f);
		_WwmWk5kaVSyVGOqHYV9xCL01Mmq = CookingMiniGameScene.smethod_23(CookingMiniGameScene.smethod_19(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0));
		CookingMiniGameScene.smethod_24(_WwmWk5kaVSyVGOqHYV9xCL01Mmq, new string[1] { "Assets/Sounds/MiniGames/Cooking/Pan spawn" });
		_Yl6cx6lo29nhZhAYCwYNXftaePb = CookingMiniGameScene.smethod_23(CookingMiniGameScene.smethod_19(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0));
		CookingMiniGameScene.smethod_24(_Yl6cx6lo29nhZhAYCwYNXftaePb, new string[1] { "Assets/Sounds/MiniGames/Cooking/Add ingrediant" });
		_R1mDpxg72ZTKnMeOQ0sH8szndlG = CookingMiniGameScene.smethod_23(CookingMiniGameScene.smethod_19(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0));
		CookingMiniGameScene.smethod_24(_R1mDpxg72ZTKnMeOQ0sH8szndlG, new string[1] { "Assets/Sounds/MiniGames/Cooking/Onion" });
		_E5COS2Wew1BQS9CZNJcDAnV99Y = CookingMiniGameScene.smethod_23(CookingMiniGameScene.smethod_19(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0));
		CookingMiniGameScene.smethod_24(_E5COS2Wew1BQS9CZNJcDAnV99Y, new string[1] { "Assets/Sounds/MiniGames/Cooking/Beef" });
		_NCyPsw4quyw64ZmYLMqlIaQaclA = CookingMiniGameScene.smethod_23(CookingMiniGameScene.smethod_19(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0));
		CookingMiniGameScene.smethod_24(_NCyPsw4quyw64ZmYLMqlIaQaclA, new string[1] { "Assets/Sounds/MiniGames/Cooking/Carrots" });
		_gDkX1mAt76eLA8P3gGXs2wM5wTE = CookingMiniGameScene.smethod_23(CookingMiniGameScene.smethod_19(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0));
		CookingMiniGameScene.smethod_24(_gDkX1mAt76eLA8P3gGXs2wM5wTE, new string[1] { "Assets/Sounds/MiniGames/Cooking/Tomatoe" });
		_7f8HjbO7kyXkAQLb2mIqPJKHcLb = CookingMiniGameScene.smethod_23(CookingMiniGameScene.smethod_19(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0));
		CookingMiniGameScene.smethod_24(_7f8HjbO7kyXkAQLb2mIqPJKHcLb, new string[1] { "Assets/Sounds/MiniGames/Cooking/Bay leaves" });
		_vdz7lnEalvPxBPYYcR15bPICZOc = CookingMiniGameScene.smethod_23(CookingMiniGameScene.smethod_19(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0));
		CookingMiniGameScene.smethod_24(_vdz7lnEalvPxBPYYcR15bPICZOc, new string[1] { "Assets/Sounds/MiniGames/Cooking/Burning" });
		_3h9I4xBs98PF8vAbLXJAdpmHA8dA = CookingMiniGameScene.smethod_23(CookingMiniGameScene.smethod_19(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0));
		CookingMiniGameScene.smethod_24(_3h9I4xBs98PF8vAbLXJAdpmHA8dA, new string[1] { "Assets/Sounds/MiniGames/Cooking/Drum roll" });
		_QQrPUpwIvHnFnZeHb0cfL7CPSHh = CookingMiniGameScene.smethod_23(CookingMiniGameScene.smethod_19(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0));
		CookingMiniGameScene.smethod_24(_QQrPUpwIvHnFnZeHb0cfL7CPSHh, new string[1] { "Assets/Sounds/MiniGames/Cooking/Bad food" });
		_8CTAuE7kLwrQAWKi1EOgTa2AKEx = CookingMiniGameScene.smethod_23(CookingMiniGameScene.smethod_19(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0));
		CookingMiniGameScene.smethod_24(_8CTAuE7kLwrQAWKi1EOgTa2AKEx, new string[1] { "Assets/Sounds/MiniGames/Cooking/Ok food" });
		_MHlWAOoiEHfmdM0FqWO6WSRbC1hA = CookingMiniGameScene.smethod_23(CookingMiniGameScene.smethod_19(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0));
		CookingMiniGameScene.smethod_24(_MHlWAOoiEHfmdM0FqWO6WSRbC1hA, new string[1] { "Assets/Sounds/MiniGames/Cooking/Great food" });
		_coudx6g9HL4THj8r5aYCDxaHH0I();
		CookingMiniGameScene.smethod_25((_fAUddQEKfZyemRb327NhM3GGlmzA)wBXNT6eIVGk6ZKExRBJ6JxXE6zb, (Action<GameTime>)delegate(GameTime gameTime_0)
		{
			CookingMiniGameScene.smethod_41(_bFjOLB3sqVGFgwwMENJRlZ5vouC, gameTime_0, 1000f);
		});
		CookingMiniGameScene.smethod_26(wBXNT6eIVGk6ZKExRBJ6JxXE6zb, (Action<SpriteBatch, SkeletonMeshRenderer>)delegate(SpriteBatch spriteBatch_0, SkeletonMeshRenderer skeletonMeshRenderer_0)
		{
			CookingMiniGameScene.smethod_42(_bFjOLB3sqVGFgwwMENJRlZ5vouC, skeletonMeshRenderer_0, (Texture2D)null, (Func<int, string, bool>)_YwAdHC5A5VB16lereNxJLkAP3Z9A, (Color?)null, 1f);
		});
		_7oYtfGpL7UyAQrZxew7Ahbvj6Sv(wBXNT6eIVGk6ZKExRBJ6JxXE6zb, 0);
		CookingMiniGameScene.smethod_27("Assets/Music/Warhector - Free Floating", 0.1f);
	}

	private bool _YwAdHC5A5VB16lereNxJLkAP3Z9A(int int_0, string string_0)
	{
		if (CookingMiniGameScene.smethod_28(string_0, "Pasta"))
		{
			return _h5v8MyOj54KK9SVZpYnagzRPLMP;
		}
		if (CookingMiniGameScene.smethod_28(string_0, "Onions bowl shadow") || CookingMiniGameScene.smethod_28(string_0, "Onions bowl glow") || CookingMiniGameScene.smethod_28(string_0, "Onions bowl"))
		{
			return !_HXs79I5YAlnCxHxJS0JxD7jccyt;
		}
		if (!CookingMiniGameScene.smethod_28(string_0, "OnionsGarlic 1") && !CookingMiniGameScene.smethod_28(string_0, "OnionsGarlic 2"))
		{
			if (!CookingMiniGameScene.smethod_28(string_0, "Ground beef bowl shadow") && !CookingMiniGameScene.smethod_28(string_0, "Ground beef bowl glow") && !CookingMiniGameScene.smethod_28(string_0, "Ground beef bowl"))
			{
				if (!CookingMiniGameScene.smethod_28(string_0, "Ground Beef 1") && !CookingMiniGameScene.smethod_28(string_0, "Ground Beef 2"))
				{
					if (!CookingMiniGameScene.smethod_28(string_0, "Carrot bowl shadow") && !CookingMiniGameScene.smethod_28(string_0, "Carrot bowl glow") && !CookingMiniGameScene.smethod_28(string_0, "Carrot bowl"))
					{
						if (!CookingMiniGameScene.smethod_28(string_0, "Carrots 1") && !CookingMiniGameScene.smethod_28(string_0, "Carrots 2"))
						{
							if (!CookingMiniGameScene.smethod_28(string_0, "Tomatoe bowl shadow") && !CookingMiniGameScene.smethod_28(string_0, "Tomatoe bowl glow") && !CookingMiniGameScene.smethod_28(string_0, "Tomatoe bowl"))
							{
								if (!CookingMiniGameScene.smethod_28(string_0, "Sauce 1") && !CookingMiniGameScene.smethod_28(string_0, "Sauce 2"))
								{
									if (!CookingMiniGameScene.smethod_28(string_0, "Bayleaves bowl shadow") && !CookingMiniGameScene.smethod_28(string_0, "Bayleaves bowl glow") && !CookingMiniGameScene.smethod_28(string_0, "Bayleaves bowl"))
									{
										if (!CookingMiniGameScene.smethod_28(string_0, "BayThyme 1") && !CookingMiniGameScene.smethod_28(string_0, "BayThyme 2"))
										{
											return true;
										}
										return _ylWBqGZTor7PB0HyMRwAuoV4hvH;
									}
									return !_ylWBqGZTor7PB0HyMRwAuoV4hvH;
								}
								return _g0GLDf9i20jtYweGI1DAr0f9WON;
							}
							return !_g0GLDf9i20jtYweGI1DAr0f9WON;
						}
						return _mOljPVTpQkVD6dwmmr9m28l6fc;
					}
					return !_mOljPVTpQkVD6dwmmr9m28l6fc;
				}
				return _HylCIZnie9TY7iCNyKurgxQFFji;
			}
			return !_HylCIZnie9TY7iCNyKurgxQFFji;
		}
		return _HXs79I5YAlnCxHxJS0JxD7jccyt;
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
		CookingMiniGameScene.smethod_29(_bFjOLB3sqVGFgwwMENJRlZ5vouC, 0f);
		CookingMiniGameScene.smethod_30(_WwmWk5kaVSyVGOqHYV9xCL01Mmq, 1f);
		CookingMiniGameScene.smethod_31(_bFjOLB3sqVGFgwwMENJRlZ5vouC, "Pan spawn", (Action)delegate
		{
			_K8aZsmpWRImwc2JedT7KcW3wdYQ = false;
		});
		_tJRouny7ZhgCxrAgyXFLsqSeAMT = EIngrediants.None;
	}

	public override void _tiBFUHPEkedkbgvuX3whdeyjhKo(GameTime gameTime_0)
	{
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		this.method_0(gameTime_0);
		if (_Iqfa1mamDp2busajsE8iPWnCKbDA)
		{
			_eRokloBwt8FsjBWpKBDmNKscCLH += (float)CookingMiniGameScene.smethod_32(gameTime_0).Milliseconds / 1000f;
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
			_2Kg9JelDMoLPl78Uv5Lb5ygQff += (float)gameTime_0.get_ElapsedGameTime().Milliseconds / 1000f;
		}
		if (_K8aZsmpWRImwc2JedT7KcW3wdYQ || _p28QNaoEJvHENbJjA4icWq92tkI || _h5v8MyOj54KK9SVZpYnagzRPLMP)
		{
			return;
		}
		Point val = base._ZzBuoSDMWwerejOO9Goyv2OCKgE._vsceSzSIjBy2nZrCxAzKZbUiwLq._u7uCdK9i8FnWhiaPn2bO2wIgUUuA(base._ZzBuoSDMWwerejOO9Goyv2OCKgE._RbWJ7YGnYHCSoD44MRW1h5X6E7E._U7CeYBJ1v1SoUxpX8emsQ9mWl5b);
		if (_HXs79I5YAlnCxHxJS0JxD7jccyt || !_bFjOLB3sqVGFgwwMENJRlZ5vouC._3nKd9Dk3YeX87QB5dROwYUzczsN("Onions bowl glow", val.X, val.Y))
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
		if (_HylCIZnie9TY7iCNyKurgxQFFji || !_bFjOLB3sqVGFgwwMENJRlZ5vouC._3nKd9Dk3YeX87QB5dROwYUzczsN("Ground beef bowl glow", val.X, val.Y))
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
		if (_mOljPVTpQkVD6dwmmr9m28l6fc || !_bFjOLB3sqVGFgwwMENJRlZ5vouC._3nKd9Dk3YeX87QB5dROwYUzczsN("Carrot bowl gold", val.X, val.Y))
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
		if (!_g0GLDf9i20jtYweGI1DAr0f9WON && _bFjOLB3sqVGFgwwMENJRlZ5vouC._3nKd9Dk3YeX87QB5dROwYUzczsN("Tomatoe bowl gold", val.X, val.Y))
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
		if (!_ylWBqGZTor7PB0HyMRwAuoV4hvH && _bFjOLB3sqVGFgwwMENJRlZ5vouC._3nKd9Dk3YeX87QB5dROwYUzczsN("Bayleaves bowl glow", val.X, val.Y))
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
			CookingMiniGameScene.smethod_30(_hqmu3NsKXqziXGfVh3dt79G0fye_0, 1f);
			CookingMiniGameScene.smethod_31(_bFjOLB3sqVGFgwwMENJRlZ5vouC, string_0, (Action)null);
		}
		_tJRouny7ZhgCxrAgyXFLsqSeAMT = eingrediants_0;
	}

	public void _7UQ7J6jOjw0vBiKHgcli5eXatrN()
	{
		if (!_p28QNaoEJvHENbJjA4icWq92tkI && !_HXs79I5YAlnCxHxJS0JxD7jccyt)
		{
			_p28QNaoEJvHENbJjA4icWq92tkI = true;
			CookingMiniGameScene.smethod_30(_Yl6cx6lo29nhZhAYCwYNXftaePb, 1f);
			CookingMiniGameScene.smethod_31(_bFjOLB3sqVGFgwwMENJRlZ5vouC, "OnionsGarlic toss", (Action)delegate
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
			CookingMiniGameScene.smethod_30(_Yl6cx6lo29nhZhAYCwYNXftaePb, 1f);
			CookingMiniGameScene.smethod_31(_bFjOLB3sqVGFgwwMENJRlZ5vouC, "Ground beef toss", (Action)delegate
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
			CookingMiniGameScene.smethod_30(_Yl6cx6lo29nhZhAYCwYNXftaePb, 1f);
			CookingMiniGameScene.smethod_31(_bFjOLB3sqVGFgwwMENJRlZ5vouC, "Carrot toss", (Action)delegate
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
			CookingMiniGameScene.smethod_30(_Yl6cx6lo29nhZhAYCwYNXftaePb, 1f);
			CookingMiniGameScene.smethod_31(_bFjOLB3sqVGFgwwMENJRlZ5vouC, "Tomatoe toss", (Action)delegate
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
			CookingMiniGameScene.smethod_30(_Yl6cx6lo29nhZhAYCwYNXftaePb, 1f);
			CookingMiniGameScene.smethod_31(_bFjOLB3sqVGFgwwMENJRlZ5vouC, "Bay toss", (Action)delegate
			{
				_ylWBqGZTor7PB0HyMRwAuoV4hvH = true;
				_n5dqiyQaiIqiC4wtWicCzzA8coG(EIngrediants.Herbs);
			});
		}
	}

	private void _n5dqiyQaiIqiC4wtWicCzzA8coG(EIngrediants eingrediants_0)
	{
		CookingMiniGameScene.smethod_33(_bFjOLB3sqVGFgwwMENJRlZ5vouC);
		if (eingrediants_0 == EIngrediants.Pasta)
		{
			CookingMiniGameScene.smethod_31(_bFjOLB3sqVGFgwwMENJRlZ5vouC, "Ingrediant mixing", (Action)delegate
			{
				_MOR64YNiUTpJJkXDvGxkr2BYs4n();
				CookingMiniGameScene.smethod_31(_bFjOLB3sqVGFgwwMENJRlZ5vouC, "Shits burning", (Action)_Ee9VcMQIfuD0ElqFdXVvMHxofkf);
			});
		}
		else
		{
			_NDwc6JiCbSmdqmQRU3taXzILgTBb.Add(eingrediants_0);
			CookingMiniGameScene.smethod_31(_bFjOLB3sqVGFgwwMENJRlZ5vouC, "Ingrediant mixing", (Action)_N6dXvS7twg0NRk66JAgWjTvfMRC);
		}
	}

	private void _MOR64YNiUTpJJkXDvGxkr2BYs4n()
	{
		CookingMiniGameScene.smethod_30(_vdz7lnEalvPxBPYYcR15bPICZOc, 1f);
		_oadA2EQp5TIkaydfB8B5lpw5Cmu = true;
		_2Kg9JelDMoLPl78Uv5Lb5ygQff = 0f;
		_fp8jsuSnELXqf2yy2JQDaXDCBVQ._k8HavJ0P5yWjzHBpsDOOGVNY8MM = true;
	}

	private void _Ee9VcMQIfuD0ElqFdXVvMHxofkf()
	{
		_oadA2EQp5TIkaydfB8B5lpw5Cmu = false;
		_fp8jsuSnELXqf2yy2JQDaXDCBVQ._k8HavJ0P5yWjzHBpsDOOGVNY8MM = false;
		_JuZlzgvacKG5z0tmPuFzmPPGDog = _2Kg9JelDMoLPl78Uv5Lb5ygQff;
		CookingMiniGameScene.smethod_34(_bFjOLB3sqVGFgwwMENJRlZ5vouC);
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
		CookingMiniGameScene.smethod_30(_Yl6cx6lo29nhZhAYCwYNXftaePb, 1f);
		_n5dqiyQaiIqiC4wtWicCzzA8coG(EIngrediants.Pasta);
	}

	public void _NvWWx67tvkIBmEn9fgXJ9ZzWJMS()
	{
		_T81AMuUIGw7sZkYmJkIpiDPosrD = false;
		CookingMiniGameScene.smethod_35(0f);
		CookingMiniGameScene.smethod_37(CookingMiniGameScene.smethod_36(CookingMiniGameScene.smethod_14((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)), (Action)delegate
		{
			CookingMiniGameScene.smethod_30(_3h9I4xBs98PF8vAbLXJAdpmHA8dA, 1f);
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
		CookingMiniGameScene.smethod_39(CookingMiniGameScene.smethod_38(), "Pasta.Poor", _Y8SewnxQuAuHOtMeTeuRSJlpbGJ);
		CookingMiniGameScene.smethod_39(CookingMiniGameScene.smethod_38(), "Pasta.Perfect", _YVtICgpvRZU0ZRqniFuAVlkSOFM);
		CookingMiniGameScene.smethod_17(_urxVZoSWXCtbeM9oQmVXW0Fb7co, _Y8SewnxQuAuHOtMeTeuRSJlpbGJ);
		CookingMiniGameScene.smethod_17(_RZsDgwVY7R44E6mMbUF7YWYyBjK, !_Y8SewnxQuAuHOtMeTeuRSJlpbGJ && !_YVtICgpvRZU0ZRqniFuAVlkSOFM);
		CookingMiniGameScene.smethod_17(_9cxzh98qcLMOVst3Rlmc4AaYoBp, _YVtICgpvRZU0ZRqniFuAVlkSOFM);
		CookingMiniGameScene.smethod_40(CookingMiniGameScene.smethod_36(CookingMiniGameScene.smethod_14((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)), (Action)delegate
		{
			if (_YVtICgpvRZU0ZRqniFuAVlkSOFM)
			{
				_003C_003Ec__DisplayClass65_0.smethod_2(_003C_003Ec__DisplayClass65_0.smethod_1(_003C_003Ec__DisplayClass65_0.smethod_0((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)), "AchievementGeneric11");
				_003C_003Ec__DisplayClass65_0.smethod_3(_MHlWAOoiEHfmdM0FqWO6WSRbC1hA, 1f);
			}
			else if (_Y8SewnxQuAuHOtMeTeuRSJlpbGJ)
			{
				_003C_003Ec__DisplayClass65_0.smethod_3(_QQrPUpwIvHnFnZeHb0cfL7CPSHh, 1f);
			}
			else
			{
				_003C_003Ec__DisplayClass65_0.smethod_3(_8CTAuE7kLwrQAWKi1EOgTa2AKEx, 1f);
			}
			_T81AMuUIGw7sZkYmJkIpiDPosrD = true;
		});
	}

	[CompilerGenerated]
	private void _NmaekdAD1gSPP5yCLnbnL1WAeD0A(GameTime gameTime_0)
	{
		CookingMiniGameScene.smethod_41(_bFjOLB3sqVGFgwwMENJRlZ5vouC, gameTime_0, 1000f);
	}

	[CompilerGenerated]
	private void _fWa6DjrbaEPK1WLNZk8EF0EhF4k(SpriteBatch spriteBatch_0, SkeletonMeshRenderer skeletonMeshRenderer_0)
	{
		CookingMiniGameScene.smethod_42(_bFjOLB3sqVGFgwwMENJRlZ5vouC, skeletonMeshRenderer_0, (Texture2D)null, (Func<int, string, bool>)_YwAdHC5A5VB16lereNxJLkAP3Z9A, (Color?)null, 1f);
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
		CookingMiniGameScene.smethod_31(_bFjOLB3sqVGFgwwMENJRlZ5vouC, "Shits burning", (Action)_Ee9VcMQIfuD0ElqFdXVvMHxofkf);
	}

	[CompilerGenerated]
	private void _XB6neda1fTKa21CjFeAGR8iHx7Y()
	{
		CookingMiniGameScene.smethod_30(_3h9I4xBs98PF8vAbLXJAdpmHA8dA, 1f);
		_Iqfa1mamDp2busajsE8iPWnCKbDA = true;
	}

	static _JbeCmOie0phb2cbgG6DdGZrbs3pB smethod_14(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0)
	{
		return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._ZzBuoSDMWwerejOO9Goyv2OCKgE;
	}

	static _uqydQVaCmCvK7zzWs5W4gZFpKBu smethod_15(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0, string string_0, string string_1, int int_0, int int_1)
	{
		return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._0O8D0mBgmrh0sLOGcLVvGNOHKLCA(string_0, string_1, int_0, int_1);
	}

	static _uqydQVaCmCvK7zzWs5W4gZFpKBu smethod_16(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0, string string_0, string string_1, int int_0, int int_1)
	{
		return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._NC5VT77x8y2iH2pW56TBN1eyomA(string_0, string_1, int_0, int_1);
	}

	static void smethod_17(_ujAkjlfN5TywwbLAUDzPvtab6uJ _ujAkjlfN5TywwbLAUDzPvtab6uJ_0, bool bool_0)
	{
		_ujAkjlfN5TywwbLAUDzPvtab6uJ_0._Fxy2SlgceW90FloFw6a1AEJODYA = bool_0;
	}

	static _WBXNT6eIVGk6ZKExRBJ6JxXE6zb smethod_18(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0, string string_0)
	{
		return new _WBXNT6eIVGk6ZKExRBJ6JxXE6zb(_7UlnfykmEmZDFt3BmCKZekI43Ih_0, string_0);
	}

	static ContentManager smethod_19(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		return _JbeCmOie0phb2cbgG6DdGZrbs3pB_0._uwNDZuqdFb9tyQtlQMxiz1DQ7x8;
	}

	static _nHdiyIURlAiaNZ8u6MKzxjcwnyL smethod_20(ContentManager contentManager_0, string string_0, float float_0, bool bool_0, List<SpineEvent> list_0)
	{
		return contentManager_0._7BVREQXEcBCieHb0qgaVDpUj1ni(string_0, float_0, bool_0, list_0);
	}

	static void smethod_21(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0, float float_0)
	{
		_nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._7Xn1C5tjYnmIif1iZKV8AWsEEbL = float_0;
	}

	static void smethod_22(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0, float float_0)
	{
		_nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._bCjZ3VSXGKyhmykd2zCnQBiSpDf = float_0;
	}

	static _hqmu3NsKXqziXGfVh3dt79G0fye smethod_23(ContentManager contentManager_0)
	{
		return new _hqmu3NsKXqziXGfVh3dt79G0fye(contentManager_0);
	}

	static void smethod_24(_hqmu3NsKXqziXGfVh3dt79G0fye _hqmu3NsKXqziXGfVh3dt79G0fye_0, string[] string_0)
	{
		_hqmu3NsKXqziXGfVh3dt79G0fye_0._cHRhcv3PTfJmYNZAZdcHvbfbkpj(string_0);
	}

	static void smethod_25(_fAUddQEKfZyemRb327NhM3GGlmzA _fAUddQEKfZyemRb327NhM3GGlmzA_0, Action<GameTime> action_0)
	{
		_fAUddQEKfZyemRb327NhM3GGlmzA_0._NC5P3SKqKPpcAYG1mqquUEcUzTg = action_0;
	}

	static void smethod_26(_WBXNT6eIVGk6ZKExRBJ6JxXE6zb _WBXNT6eIVGk6ZKExRBJ6JxXE6zb_0, Action<SpriteBatch, SkeletonMeshRenderer> action_0)
	{
		_WBXNT6eIVGk6ZKExRBJ6JxXE6zb_0._Wb2e00OWt8kBwGWEXtOGMVScRPm = action_0;
	}

	static void smethod_27(string string_0, float float_0)
	{
		_UmxbIbk7pgaod0bD7pS309P3Lns._l94kUraQ13OohoVwwxKC37hG7Pc(string_0, float_0);
	}

	static bool smethod_28(string string_0, string string_1)
	{
		return string_0 == string_1;
	}

	static void smethod_29(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0, float float_0)
	{
		_nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._c4iC7y9v6xg7LpvjKIeUkOdZ3UF(float_0);
	}

	static void smethod_30(_hqmu3NsKXqziXGfVh3dt79G0fye _hqmu3NsKXqziXGfVh3dt79G0fye_0, float float_0)
	{
		_hqmu3NsKXqziXGfVh3dt79G0fye_0._xDFlaclLtJxSUU63JEJALvRLdfe(float_0);
	}

	static void smethod_31(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0, string string_0, Action action_0)
	{
		_nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._SPUoP3ABwpgQinJfKUM5qBbYSvr(string_0, action_0);
	}

	void method_0(GameTime gameTime_0)
	{
		base._tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime_0);
	}

	static TimeSpan smethod_32(GameTime gameTime_0)
	{
		return gameTime_0.get_ElapsedGameTime();
	}

	static void smethod_33(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0)
	{
		_nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._lkaN4ygxDlKvzKEBuD7dRjrU20F();
	}

	static void smethod_34(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0)
	{
		_nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._d6HoyBFhu6xkBRCX00ZzeFUnWwF();
	}

	static void smethod_35(float float_0)
	{
		_UmxbIbk7pgaod0bD7pS309P3Lns._E7yBM68AWt7OGHJ5D6xYA8RK8tAA(float_0);
	}

	static _gJR4g7ak0hsZAUWX1vJbMqG2P5I smethod_36(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		return _JbeCmOie0phb2cbgG6DdGZrbs3pB_0._Qj2G6fpAF4mGsATgkV8DPBF3aA1A;
	}

	static void smethod_37(_gJR4g7ak0hsZAUWX1vJbMqG2P5I _gJR4g7ak0hsZAUWX1vJbMqG2P5I_0, Action action_0)
	{
		_gJR4g7ak0hsZAUWX1vJbMqG2P5I_0._PYAXEqRAOkDRRNqm1k71R7GJTJK(action_0);
	}

	static _opIJo2jLUqdOL5yAFP4yzXce0DG smethod_38()
	{
		return _Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t();
	}

	static void smethod_39(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0, string string_0, bool bool_0)
	{
		_opIJo2jLUqdOL5yAFP4yzXce0DG_0._4Fscz8ryB3hm0NmL5xw39HHiPd1(string_0, bool_0);
	}

	static void smethod_40(_gJR4g7ak0hsZAUWX1vJbMqG2P5I _gJR4g7ak0hsZAUWX1vJbMqG2P5I_0, Action action_0)
	{
		_gJR4g7ak0hsZAUWX1vJbMqG2P5I_0._FegL010tc92iskjjyD0T33dDwNE(action_0);
	}

	static void smethod_41(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0, GameTime gameTime_0, float float_0)
	{
		_nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime_0, float_0);
	}

	static void smethod_42(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0, SkeletonMeshRenderer skeletonMeshRenderer_0, Texture2D texture2D_0, Func<int, string, bool> func_0, Color? nullable_0, float float_0)
	{
		_nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._f5ctqAmdNsZ889UjM4LxDm8WGxA(skeletonMeshRenderer_0, texture2D_0, func_0, nullable_0, float_0);
	}
}
