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
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			while (true)
			{
				int num = -1556749410;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x9D02D6A5u) % 3u)
					{
					case 1u:
						goto IL_000c;
					case 2u:
						break;
					default:
						_wmL1cFR5CsMqZS9jOXyCnmqveCG._Fxy2SlgceW90FloFw6a1AEJODYA = false;
						return;
					}
					break;
					IL_000c:
					_wmL1cFR5CsMqZS9jOXyCnmqveCG = _QVqIVxBeF2SAQh6HDFwwp2RFmXB("Assets/Scenes/Cooking/Button", "Assets/Scenes/Cooking/Button hover", "Assets/Gui/Fonts/Bold-26", "Stop cooking!", Color.get_White(), 832, 970, new Rectangle(832, 970, 256, 102), action_0);
					num = (int)(num2 * 1035233199) ^ -1053371884;
				}
			}
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
		_WBXNT6eIVGk6ZKExRBJ6JxXE6zb wBXNT6eIVGk6ZKExRBJ6JxXE6zb = default(_WBXNT6eIVGk6ZKExRBJ6JxXE6zb);
		while (true)
		{
			int num = 391277890;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x28AD307Bu) % 29u)
				{
				case 28u:
					CookingMiniGameScene.smethod_17(_9cxzh98qcLMOVst3Rlmc4AaYoBp, bool_0: false);
					num = (int)((num2 * 1736374734) ^ 0x1F5FEDDD);
					continue;
				case 27u:
					CookingMiniGameScene.smethod_24(_WwmWk5kaVSyVGOqHYV9xCL01Mmq, new string[1] { "Assets/Sounds/MiniGames/Cooking/Pan spawn" });
					num = (int)((num2 * 1945802107) ^ 0x40D908D5);
					continue;
				case 26u:
					wBXNT6eIVGk6ZKExRBJ6JxXE6zb = CookingMiniGameScene.smethod_18((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Cooking");
					num = (int)(num2 * 740771401) ^ -1815843401;
					continue;
				case 25u:
					CookingMiniGameScene.smethod_24(_7f8HjbO7kyXkAQLb2mIqPJKHcLb, new string[1] { "Assets/Sounds/MiniGames/Cooking/Bay leaves" });
					_vdz7lnEalvPxBPYYcR15bPICZOc = CookingMiniGameScene.smethod_23(CookingMiniGameScene.smethod_19(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0));
					num = (int)(num2 * 1161466801) ^ -650616712;
					continue;
				case 23u:
					_RZsDgwVY7R44E6mMbUF7YWYyBjK = CookingMiniGameScene.smethod_16((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Background", "Assets/Scenes/Cooking/Okay", 0, 0);
					CookingMiniGameScene.smethod_17(_RZsDgwVY7R44E6mMbUF7YWYyBjK, bool_0: false);
					num = ((int)num2 * -484892327) ^ 0x75BE3539;
					continue;
				case 22u:
					CookingMiniGameScene.smethod_27("Assets/Music/Warhector - Free Floating", 0.1f);
					num = (int)(num2 * 242832744) ^ -644382898;
					continue;
				case 21u:
					CookingMiniGameScene.smethod_24(_vdz7lnEalvPxBPYYcR15bPICZOc, new string[1] { "Assets/Sounds/MiniGames/Cooking/Burning" });
					_3h9I4xBs98PF8vAbLXJAdpmHA8dA = CookingMiniGameScene.smethod_23(CookingMiniGameScene.smethod_19(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0));
					CookingMiniGameScene.smethod_24(_3h9I4xBs98PF8vAbLXJAdpmHA8dA, new string[1] { "Assets/Sounds/MiniGames/Cooking/Drum roll" });
					_QQrPUpwIvHnFnZeHb0cfL7CPSHh = CookingMiniGameScene.smethod_23(CookingMiniGameScene.smethod_19(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0));
					num = (int)((num2 * 1971855476) ^ 0x5A86FE92);
					continue;
				case 20u:
					_NCyPsw4quyw64ZmYLMqlIaQaclA = CookingMiniGameScene.smethod_23(CookingMiniGameScene.smethod_19(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0));
					num = ((int)num2 * -542822304) ^ -1036806406;
					continue;
				case 19u:
					_Yl6cx6lo29nhZhAYCwYNXftaePb = CookingMiniGameScene.smethod_23(CookingMiniGameScene.smethod_19(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0));
					CookingMiniGameScene.smethod_24(_Yl6cx6lo29nhZhAYCwYNXftaePb, new string[1] { "Assets/Sounds/MiniGames/Cooking/Add ingrediant" });
					num = (int)((num2 * 1468355135) ^ 0x102B0B46);
					continue;
				case 18u:
					_bFjOLB3sqVGFgwwMENJRlZ5vouC = CookingMiniGameScene.smethod_20(CookingMiniGameScene.smethod_19(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0), "Assets/Scenes/Cooking/Cooking", 1f, bool_0: true, (List<SpineEvent>)null);
					CookingMiniGameScene.smethod_21(_bFjOLB3sqVGFgwwMENJRlZ5vouC, 960f);
					num = (int)((num2 * 1273765122) ^ 0x2A5E01C9);
					continue;
				case 17u:
					CookingMiniGameScene.smethod_26(wBXNT6eIVGk6ZKExRBJ6JxXE6zb, (Action<SpriteBatch, SkeletonMeshRenderer>)delegate(SpriteBatch spriteBatch_0, SkeletonMeshRenderer skeletonMeshRenderer_0)
					{
						CookingMiniGameScene.smethod_42(_bFjOLB3sqVGFgwwMENJRlZ5vouC, skeletonMeshRenderer_0, (Texture2D)null, (Func<int, string, bool>)_YwAdHC5A5VB16lereNxJLkAP3Z9A, (Color?)null, 1f);
					});
					_7oYtfGpL7UyAQrZxew7Ahbvj6Sv(wBXNT6eIVGk6ZKExRBJ6JxXE6zb, 0);
					num = ((int)num2 * -1000847619) ^ 0x3BDA0651;
					continue;
				case 16u:
					CookingMiniGameScene.smethod_25((_fAUddQEKfZyemRb327NhM3GGlmzA)wBXNT6eIVGk6ZKExRBJ6JxXE6zb, (Action<GameTime>)delegate(GameTime gameTime_0)
					{
						CookingMiniGameScene.smethod_41(_bFjOLB3sqVGFgwwMENJRlZ5vouC, gameTime_0, 1000f);
					});
					num = ((int)num2 * -544540853) ^ 0x164EF60C;
					continue;
				case 15u:
					CookingMiniGameScene.smethod_24(_QQrPUpwIvHnFnZeHb0cfL7CPSHh, new string[1] { "Assets/Sounds/MiniGames/Cooking/Bad food" });
					num = ((int)num2 * -1012891788) ^ -2085661610;
					continue;
				case 14u:
					_7f8HjbO7kyXkAQLb2mIqPJKHcLb = CookingMiniGameScene.smethod_23(CookingMiniGameScene.smethod_19(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0));
					num = ((int)num2 * -47290959) ^ 0x75A247B7;
					continue;
				case 13u:
					_WwmWk5kaVSyVGOqHYV9xCL01Mmq = CookingMiniGameScene.smethod_23(CookingMiniGameScene.smethod_19(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0));
					num = ((int)num2 * -2051160052) ^ 0x528EE35A;
					continue;
				case 12u:
					CookingMiniGameScene.smethod_22(_bFjOLB3sqVGFgwwMENJRlZ5vouC, 540f);
					num = ((int)num2 * -1895030199) ^ 0x6F0033C;
					continue;
				case 11u:
					_E5COS2Wew1BQS9CZNJcDAnV99Y = CookingMiniGameScene.smethod_23(CookingMiniGameScene.smethod_19(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0));
					num = ((int)num2 * -408123302) ^ 0x6C297D6A;
					continue;
				case 10u:
					CookingMiniGameScene.smethod_15((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Background", "Assets/Scenes/Cooking/Background", 0, 0);
					_urxVZoSWXCtbeM9oQmVXW0Fb7co = CookingMiniGameScene.smethod_16((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Background", "Assets/Scenes/Cooking/Bad", 0, 0);
					num = ((int)num2 * -1641638006) ^ -1575881377;
					continue;
				case 9u:
					CookingMiniGameScene.smethod_24(_E5COS2Wew1BQS9CZNJcDAnV99Y, new string[1] { "Assets/Sounds/MiniGames/Cooking/Beef" });
					num = (int)(num2 * 159661265) ^ -132518377;
					continue;
				case 8u:
					_R1mDpxg72ZTKnMeOQ0sH8szndlG = CookingMiniGameScene.smethod_23(CookingMiniGameScene.smethod_19(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0));
					CookingMiniGameScene.smethod_24(_R1mDpxg72ZTKnMeOQ0sH8szndlG, new string[1] { "Assets/Sounds/MiniGames/Cooking/Onion" });
					num = ((int)num2 * -991630973) ^ 0x5ABAF658;
					continue;
				case 7u:
					_MHlWAOoiEHfmdM0FqWO6WSRbC1hA = CookingMiniGameScene.smethod_23(CookingMiniGameScene.smethod_19(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0));
					CookingMiniGameScene.smethod_24(_MHlWAOoiEHfmdM0FqWO6WSRbC1hA, new string[1] { "Assets/Sounds/MiniGames/Cooking/Great food" });
					_coudx6g9HL4THj8r5aYCDxaHH0I();
					num = ((int)num2 * -1745607208) ^ 0x6D609A78;
					continue;
				case 6u:
					_fp8jsuSnELXqf2yy2JQDaXDCBVQ = new GUI(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0, _Ee9VcMQIfuD0ElqFdXVvMHxofkf);
					num = (int)(num2 * 831021063) ^ -2051224337;
					continue;
				case 4u:
					CookingMiniGameScene.smethod_17(_urxVZoSWXCtbeM9oQmVXW0Fb7co, bool_0: false);
					num = (int)((num2 * 750572503) ^ 0x30BE11AB);
					continue;
				case 3u:
					CookingMiniGameScene.smethod_24(_NCyPsw4quyw64ZmYLMqlIaQaclA, new string[1] { "Assets/Sounds/MiniGames/Cooking/Carrots" });
					_gDkX1mAt76eLA8P3gGXs2wM5wTE = CookingMiniGameScene.smethod_23(CookingMiniGameScene.smethod_19(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0));
					CookingMiniGameScene.smethod_24(_gDkX1mAt76eLA8P3gGXs2wM5wTE, new string[1] { "Assets/Sounds/MiniGames/Cooking/Tomatoe" });
					num = (int)((num2 * 1723788613) ^ 0x722B723B);
					continue;
				case 2u:
					_9cxzh98qcLMOVst3Rlmc4AaYoBp = CookingMiniGameScene.smethod_16((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Background", "Assets/Scenes/Cooking/Excellent", 0, 0);
					num = ((int)num2 * -1423303710) ^ 0x1A33B7D4;
					continue;
				case 1u:
					CookingMiniGameScene.smethod_14((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._lXEQJcXKxsjtZp00Y9aPe0ymGue(_fp8jsuSnELXqf2yy2JQDaXDCBVQ);
					num = ((int)num2 * -583088204) ^ 0x5E09B28E;
					continue;
				case 0u:
					_8CTAuE7kLwrQAWKi1EOgTa2AKEx = CookingMiniGameScene.smethod_23(CookingMiniGameScene.smethod_19(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0));
					CookingMiniGameScene.smethod_24(_8CTAuE7kLwrQAWKi1EOgTa2AKEx, new string[1] { "Assets/Sounds/MiniGames/Cooking/Ok food" });
					num = ((int)num2 * -1696261613) ^ 0x5D655A9F;
					continue;
				default:
					return;
				case 5u:
					break;
				case 24u:
					return;
				}
				break;
			}
		}
	}

	private bool _YwAdHC5A5VB16lereNxJLkAP3Z9A(int int_0, string string_0)
	{
		if (CookingMiniGameScene.smethod_28(string_0, "Pasta"))
		{
			goto IL_02b2;
		}
		goto IL_0546;
		IL_0546:
		int num;
		int num2;
		if (!CookingMiniGameScene.smethod_28(string_0, "Onions bowl shadow"))
		{
			num = -275779329;
			num2 = -275779329;
		}
		else
		{
			num = -1397539609;
			num2 = -1397539609;
		}
		goto IL_048d;
		IL_048d:
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num ^ 0xD77B3615u) % 38u)
			{
			case 37u:
			{
				int num30;
				int num31;
				if (!CookingMiniGameScene.smethod_28(string_0, "Carrot bowl"))
				{
					num30 = -269409124;
					num31 = -269409124;
				}
				else
				{
					num30 = -2121838910;
					num31 = -2121838910;
				}
				num = num30 ^ (int)(num3 * 848685434);
				continue;
			}
			case 36u:
				break;
			case 34u:
			{
				int num18;
				int num19;
				if (CookingMiniGameScene.smethod_28(string_0, "Ground Beef 2"))
				{
					num18 = -1841657020;
					num19 = -1841657020;
				}
				else
				{
					num18 = -1061872884;
					num19 = -1061872884;
				}
				num = num18 ^ ((int)num3 * -926913851);
				continue;
			}
			case 33u:
				goto IL_00b4;
			case 32u:
				goto IL_00de;
			case 25u:
			{
				int num32;
				int num33;
				if (!CookingMiniGameScene.smethod_28(string_0, "BayThyme 2"))
				{
					num32 = -1671844231;
					num33 = -1671844231;
				}
				else
				{
					num32 = -1256258102;
					num33 = -1256258102;
				}
				num = num32 ^ (int)(num3 * 1591164595);
				continue;
			}
			case 24u:
			{
				int num24;
				int num25;
				if (!CookingMiniGameScene.smethod_28(string_0, "OnionsGarlic 2"))
				{
					num24 = 1404888853;
					num25 = 1404888853;
				}
				else
				{
					num24 = 973638249;
					num25 = 973638249;
				}
				num = num24 ^ ((int)num3 * -839334093);
				continue;
			}
			case 23u:
			{
				int num14;
				int num15;
				if (!CookingMiniGameScene.smethod_28(string_0, "Ground beef bowl"))
				{
					num14 = 1214605651;
					num15 = 1214605651;
				}
				else
				{
					num14 = 599924225;
					num15 = 599924225;
				}
				num = num14 ^ ((int)num3 * -1333289370);
				continue;
			}
			case 22u:
				goto IL_019e;
			case 21u:
			{
				int num26;
				int num27;
				if (!CookingMiniGameScene.smethod_28(string_0, "Sauce 2"))
				{
					num26 = -189166374;
					num27 = -189166374;
				}
				else
				{
					num26 = -231773380;
					num27 = -231773380;
				}
				num = num26 ^ ((int)num3 * -410830185);
				continue;
			}
			case 20u:
				goto IL_01fa;
			case 19u:
			{
				int num22;
				int num23;
				if (!CookingMiniGameScene.smethod_28(string_0, "Tomatoe bowl glow"))
				{
					num22 = 1895146097;
					num23 = 1895146097;
				}
				else
				{
					num22 = 1775850965;
					num23 = 1775850965;
				}
				num = num22 ^ (int)(num3 * 221248903);
				continue;
			}
			case 18u:
			{
				int num8;
				int num9;
				if (CookingMiniGameScene.smethod_28(string_0, "Onions bowl glow"))
				{
					num8 = 1796632719;
					num9 = 1796632719;
				}
				else
				{
					num8 = 820203184;
					num9 = 820203184;
				}
				num = num8 ^ ((int)num3 * -1967027484);
				continue;
			}
			case 17u:
				goto IL_0288;
			case 15u:
				goto end_IL_048d;
			case 14u:
			{
				int num10;
				int num11;
				if (!CookingMiniGameScene.smethod_28(string_0, "Carrots 2"))
				{
					num10 = -1591767380;
					num11 = -1591767380;
				}
				else
				{
					num10 = -631959533;
					num11 = -631959533;
				}
				num = num10 ^ (int)(num3 * 480924555);
				continue;
			}
			case 13u:
			{
				int num16;
				int num17;
				if (CookingMiniGameScene.smethod_28(string_0, "Bayleaves bowl glow"))
				{
					num16 = -301434641;
					num17 = -301434641;
				}
				else
				{
					num16 = -1242892064;
					num17 = -1242892064;
				}
				num = num16 ^ (int)(num3 * 1402993859);
				continue;
			}
			case 9u:
				goto IL_0320;
			case 6u:
			{
				int num6;
				int num7;
				if (CookingMiniGameScene.smethod_28(string_0, "Carrot bowl glow"))
				{
					num6 = -1313813562;
					num7 = -1313813562;
				}
				else
				{
					num6 = -587588612;
					num7 = -587588612;
				}
				num = num6 ^ (int)(num3 * 1650059665);
				continue;
			}
			case 5u:
			{
				int num28;
				int num29;
				if (CookingMiniGameScene.smethod_28(string_0, "Onions bowl"))
				{
					num28 = 796902843;
					num29 = 796902843;
				}
				else
				{
					num28 = 1837807971;
					num29 = 1837807971;
				}
				num = num28 ^ ((int)num3 * -281903412);
				continue;
			}
			case 4u:
			{
				int num20;
				int num21;
				if (!CookingMiniGameScene.smethod_28(string_0, "Ground beef bowl glow"))
				{
					num20 = -206112834;
					num21 = -206112834;
				}
				else
				{
					num20 = -858843637;
					num21 = -858843637;
				}
				num = num20 ^ (int)(num3 * 231608153);
				continue;
			}
			case 3u:
			{
				int num12;
				int num13;
				if (CookingMiniGameScene.smethod_28(string_0, "Tomatoe bowl"))
				{
					num12 = 1897795197;
					num13 = 1897795197;
				}
				else
				{
					num12 = 161075350;
					num13 = 161075350;
				}
				num = num12 ^ (int)(num3 * 2110569029);
				continue;
			}
			case 2u:
			{
				int num4;
				int num5;
				if (CookingMiniGameScene.smethod_28(string_0, "Bayleaves bowl"))
				{
					num4 = 217861402;
					num5 = 217861402;
				}
				else
				{
					num4 = 1478456924;
					num5 = 1478456924;
				}
				num = num4 ^ ((int)num3 * -379847103);
				continue;
			}
			case 1u:
				goto IL_0441;
			case 0u:
				goto IL_0468;
			case 29u:
				goto IL_0546;
			case 7u:
				return !_mOljPVTpQkVD6dwmmr9m28l6fc;
			case 8u:
				return !_HXs79I5YAlnCxHxJS0JxD7jccyt;
			case 10u:
				return !_HylCIZnie9TY7iCNyKurgxQFFji;
			default:
				return true;
			case 12u:
				return _g0GLDf9i20jtYweGI1DAr0f9WON;
			case 16u:
				return _mOljPVTpQkVD6dwmmr9m28l6fc;
			case 26u:
				return _h5v8MyOj54KK9SVZpYnagzRPLMP;
			case 27u:
				return _HylCIZnie9TY7iCNyKurgxQFFji;
			case 28u:
				return _HXs79I5YAlnCxHxJS0JxD7jccyt;
			case 30u:
				return _ylWBqGZTor7PB0HyMRwAuoV4hvH;
			case 31u:
				return !_ylWBqGZTor7PB0HyMRwAuoV4hvH;
			case 35u:
				return !_g0GLDf9i20jtYweGI1DAr0f9WON;
			}
			int num34;
			if (!CookingMiniGameScene.smethod_28(string_0, "Sauce 1"))
			{
				num = -1475238426;
				num34 = -1475238426;
			}
			else
			{
				num = -1248577175;
				num34 = -1248577175;
			}
			continue;
			IL_0468:
			int num35;
			if (!CookingMiniGameScene.smethod_28(string_0, "Ground Beef 1"))
			{
				num = -1469485903;
				num35 = -1469485903;
			}
			else
			{
				num = -274914448;
				num35 = -274914448;
			}
			continue;
			IL_00de:
			int num36;
			if (!CookingMiniGameScene.smethod_28(string_0, "Bayleaves bowl shadow"))
			{
				num = -1822670738;
				num36 = -1822670738;
			}
			else
			{
				num = -736285858;
				num36 = -736285858;
			}
			continue;
			IL_01fa:
			int num37;
			if (!CookingMiniGameScene.smethod_28(string_0, "Ground beef bowl shadow"))
			{
				num = -1043639923;
				num37 = -1043639923;
			}
			else
			{
				num = -2122646061;
				num37 = -2122646061;
			}
			continue;
			IL_0441:
			int num38;
			if (!CookingMiniGameScene.smethod_28(string_0, "Carrot bowl shadow"))
			{
				num = -829921057;
				num38 = -829921057;
			}
			else
			{
				num = -840416852;
				num38 = -840416852;
			}
			continue;
			IL_0288:
			int num39;
			if (!CookingMiniGameScene.smethod_28(string_0, "Carrots 1"))
			{
				num = -1189546479;
				num39 = -1189546479;
			}
			else
			{
				num = -532177345;
				num39 = -532177345;
			}
			continue;
			IL_00b4:
			int num40;
			if (CookingMiniGameScene.smethod_28(string_0, "BayThyme 1"))
			{
				num = -856166931;
				num40 = -856166931;
			}
			else
			{
				num = -1662264152;
				num40 = -1662264152;
			}
			continue;
			IL_0320:
			int num41;
			if (CookingMiniGameScene.smethod_28(string_0, "Tomatoe bowl shadow"))
			{
				num = -480557230;
				num41 = -480557230;
			}
			else
			{
				num = -985549548;
				num41 = -985549548;
			}
			continue;
			IL_019e:
			int num42;
			if (CookingMiniGameScene.smethod_28(string_0, "OnionsGarlic 1"))
			{
				num = -740696043;
				num42 = -740696043;
			}
			else
			{
				num = -1762685567;
				num42 = -1762685567;
			}
			continue;
			end_IL_048d:
			break;
		}
		goto IL_02b2;
		IL_02b2:
		num = -1645390749;
		goto IL_048d;
	}

	private void _coudx6g9HL4THj8r5aYCDxaHH0I()
	{
		_K8aZsmpWRImwc2JedT7KcW3wdYQ = true;
		while (true)
		{
			int num = 260272349;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x113DE21u) % 7u)
				{
				case 6u:
					CookingMiniGameScene.smethod_30(_WwmWk5kaVSyVGOqHYV9xCL01Mmq, 1f);
					CookingMiniGameScene.smethod_31(_bFjOLB3sqVGFgwwMENJRlZ5vouC, "Pan spawn", (Action)delegate
					{
						_K8aZsmpWRImwc2JedT7KcW3wdYQ = false;
					});
					_tJRouny7ZhgCxrAgyXFLsqSeAMT = EIngrediants.None;
					num = (int)(num2 * 807550883) ^ -142157980;
					continue;
				case 5u:
					CookingMiniGameScene.smethod_29(_bFjOLB3sqVGFgwwMENJRlZ5vouC, 0f);
					num = ((int)num2 * -352153698) ^ 0x44133EB8;
					continue;
				case 4u:
					_h5v8MyOj54KK9SVZpYnagzRPLMP = false;
					num = (int)(num2 * 1194962301) ^ -1094965853;
					continue;
				case 2u:
					_HXs79I5YAlnCxHxJS0JxD7jccyt = false;
					_HylCIZnie9TY7iCNyKurgxQFFji = false;
					num = ((int)num2 * -1587283861) ^ -2051663736;
					continue;
				case 0u:
					_mOljPVTpQkVD6dwmmr9m28l6fc = false;
					_g0GLDf9i20jtYweGI1DAr0f9WON = false;
					_ylWBqGZTor7PB0HyMRwAuoV4hvH = false;
					_NDwc6JiCbSmdqmQRU3taXzILgTBb = new List<EIngrediants>();
					num = (int)(num2 * 1700972991) ^ -1058946984;
					continue;
				default:
					return;
				case 3u:
					break;
				case 1u:
					return;
				}
				break;
			}
		}
	}

	public override void _tiBFUHPEkedkbgvuX3whdeyjhKo(GameTime gameTime_0)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_0498: Unknown result type (might be due to invalid IL or missing references)
		//IL_049f: Unknown result type (might be due to invalid IL or missing references)
		this.method_0(gameTime_0);
		Point val = default(Point);
		while (true)
		{
			int num = 1215159834;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x24808607u) % 44u)
				{
				case 43u:
					_Iqfa1mamDp2busajsE8iPWnCKbDA = false;
					num = (int)((num2 * 646185346) ^ 0xAF88376);
					continue;
				case 42u:
				{
					int num5;
					int num6;
					if (_bFjOLB3sqVGFgwwMENJRlZ5vouC._3nKd9Dk3YeX87QB5dROwYUzczsN("Tomatoe bowl gold", val.X, val.Y))
					{
						num5 = -1784211478;
						num6 = -1784211478;
					}
					else
					{
						num5 = -203051842;
						num6 = -203051842;
					}
					num = num5 ^ ((int)num2 * -1389371215);
					continue;
				}
				case 41u:
					_bFjOLB3sqVGFgwwMENJRlZ5vouC._aAoZaDNczeScsMfLlGSfAzey9SQ("Bayleaves bowl glow", 0f);
					num = 641564420;
					continue;
				case 40u:
				{
					int num25;
					if (_g0GLDf9i20jtYweGI1DAr0f9WON)
					{
						num = 845079340;
						num25 = 845079340;
					}
					else
					{
						num = 1872493365;
						num25 = 1872493365;
					}
					continue;
				}
				case 39u:
				{
					int num39;
					int num40;
					if (!_bFjOLB3sqVGFgwwMENJRlZ5vouC._3nKd9Dk3YeX87QB5dROwYUzczsN("Ground beef bowl glow", val.X, val.Y))
					{
						num39 = 835641556;
						num40 = 835641556;
					}
					else
					{
						num39 = 1827958081;
						num40 = 1827958081;
					}
					num = num39 ^ (int)(num2 * 566526912);
					continue;
				}
				case 38u:
				{
					int num11;
					int num12;
					if (!_bFjOLB3sqVGFgwwMENJRlZ5vouC._3nKd9Dk3YeX87QB5dROwYUzczsN("Carrot bowl gold", val.X, val.Y))
					{
						num11 = 686372669;
						num12 = 686372669;
					}
					else
					{
						num11 = 689027042;
						num12 = 689027042;
					}
					num = num11 ^ (int)(num2 * 897814578);
					continue;
				}
				case 37u:
				{
					int num14;
					int num15;
					if (!_bFjOLB3sqVGFgwwMENJRlZ5vouC._3nKd9Dk3YeX87QB5dROwYUzczsN("Bayleaves bowl glow", val.X, val.Y))
					{
						num14 = 1174000945;
						num15 = 1174000945;
					}
					else
					{
						num14 = 192017134;
						num15 = 192017134;
					}
					num = num14 ^ ((int)num2 * -2127015089);
					continue;
				}
				case 36u:
				{
					int num37;
					int num38;
					if (_c9i4Rbj8ENw5b6aqNq271voBctc)
					{
						num37 = 1388903199;
						num38 = 1388903199;
					}
					else
					{
						num37 = 2101269183;
						num38 = 2101269183;
					}
					num = num37 ^ ((int)num2 * -967995424);
					continue;
				}
				case 35u:
					_VcZyHKzhoXLGNA1DIp006kBhiDN();
					num = (int)(num2 * 2144593055) ^ -2079458294;
					continue;
				case 34u:
					_KS0Vtg4XWGmpAsqFy5tYlJXLKLA();
					num = ((int)num2 * -1093123578) ^ -351140847;
					continue;
				case 33u:
				{
					_QMxAinggzISmU1LmkqSK0bfv9h5("Carrot highlight", EIngrediants.Carrots, _NCyPsw4quyw64ZmYLMqlIaQaclA);
					int num23;
					int num24;
					if (!base._ZzBuoSDMWwerejOO9Goyv2OCKgE._RbWJ7YGnYHCSoD44MRW1h5X6E7E._fy5ebLnmRsRXv9v7RKTFU5CGMaH(_PMeRYZJaBCqgB9uADJFP3c14lxq.LeftButton))
					{
						num23 = 829172588;
						num24 = 829172588;
					}
					else
					{
						num23 = 2116654911;
						num24 = 2116654911;
					}
					num = num23 ^ ((int)num2 * -587587129);
					continue;
				}
				case 32u:
				{
					int num16;
					int num17;
					if (_p28QNaoEJvHENbJjA4icWq92tkI)
					{
						num16 = 123020918;
						num17 = 123020918;
					}
					else
					{
						num16 = 1445612599;
						num17 = 1445612599;
					}
					num = num16 ^ ((int)num2 * -80768775);
					continue;
				}
				case 31u:
					_7UQ7J6jOjw0vBiKHgcli5eXatrN();
					num = (int)((num2 * 1908417346) ^ 0x751E0748);
					continue;
				case 30u:
				{
					val = base._ZzBuoSDMWwerejOO9Goyv2OCKgE._vsceSzSIjBy2nZrCxAzKZbUiwLq._u7uCdK9i8FnWhiaPn2bO2wIgUUuA(base._ZzBuoSDMWwerejOO9Goyv2OCKgE._RbWJ7YGnYHCSoD44MRW1h5X6E7E._U7CeYBJ1v1SoUxpX8emsQ9mWl5b);
					int num36;
					if (_HXs79I5YAlnCxHxJS0JxD7jccyt)
					{
						num = 1622287578;
						num36 = 1622287578;
					}
					else
					{
						num = 1885882042;
						num36 = 1885882042;
					}
					continue;
				}
				case 29u:
				{
					int num32;
					int num33;
					if (!_Iqfa1mamDp2busajsE8iPWnCKbDA)
					{
						num32 = -556251741;
						num33 = -556251741;
					}
					else
					{
						num32 = -1383683238;
						num33 = -1383683238;
					}
					num = num32 ^ (int)(num2 * 1317274313);
					continue;
				}
				case 28u:
					_eRokloBwt8FsjBWpKBDmNKscCLH += (float)CookingMiniGameScene.smethod_32(gameTime_0).Milliseconds / 1000f;
					num = ((int)num2 * -1280116366) ^ 0x79E2A38E;
					continue;
				case 27u:
					_2Kg9JelDMoLPl78Uv5Lb5ygQff += (float)gameTime_0.get_ElapsedGameTime().Milliseconds / 1000f;
					num = ((int)num2 * -1249792015) ^ -1676889304;
					continue;
				case 26u:
				{
					int num27;
					if (_ylWBqGZTor7PB0HyMRwAuoV4hvH)
					{
						num = 254830174;
						num27 = 254830174;
					}
					else
					{
						num = 2048758758;
						num27 = 2048758758;
					}
					continue;
				}
				case 25u:
					_QMxAinggzISmU1LmkqSK0bfv9h5("OnionsGarlic highlight", EIngrediants.OnionsGarlic, _R1mDpxg72ZTKnMeOQ0sH8szndlG);
					num = ((int)num2 * -958290835) ^ 0x682940B2;
					continue;
				case 24u:
				{
					int num20;
					if (_mOljPVTpQkVD6dwmmr9m28l6fc)
					{
						num = 2050719057;
						num20 = 2050719057;
					}
					else
					{
						num = 1985850273;
						num20 = 1985850273;
					}
					continue;
				}
				case 23u:
					_bFjOLB3sqVGFgwwMENJRlZ5vouC._aAoZaDNczeScsMfLlGSfAzey9SQ("Tomatoe bowl gold", 0f);
					num = 1596824657;
					continue;
				case 22u:
					_bFjOLB3sqVGFgwwMENJRlZ5vouC._aAoZaDNczeScsMfLlGSfAzey9SQ("Carrot bowl gold", 0f);
					num = 289905427;
					continue;
				case 21u:
				{
					int num9;
					int num10;
					if (_eRokloBwt8FsjBWpKBDmNKscCLH <= 3f)
					{
						num9 = -125337745;
						num10 = -125337745;
					}
					else
					{
						num9 = -1319872975;
						num10 = -1319872975;
					}
					num = num9 ^ (int)(num2 * 467325009);
					continue;
				}
				case 20u:
				{
					int num4;
					if (_K8aZsmpWRImwc2JedT7KcW3wdYQ)
					{
						num = 1236961578;
						num4 = 1236961578;
					}
					else
					{
						num = 1219042107;
						num4 = 1219042107;
					}
					continue;
				}
				case 18u:
				{
					_QMxAinggzISmU1LmkqSK0bfv9h5("Ground beef highlight", EIngrediants.GroundBeef, _E5COS2Wew1BQS9CZNJcDAnV99Y);
					int num34;
					int num35;
					if (!base._ZzBuoSDMWwerejOO9Goyv2OCKgE._RbWJ7YGnYHCSoD44MRW1h5X6E7E._fy5ebLnmRsRXv9v7RKTFU5CGMaH(_PMeRYZJaBCqgB9uADJFP3c14lxq.LeftButton))
					{
						num34 = -395412933;
						num35 = -395412933;
					}
					else
					{
						num34 = -1323820875;
						num35 = -1323820875;
					}
					num = num34 ^ ((int)num2 * -849884026);
					continue;
				}
				case 17u:
				{
					int num30;
					int num31;
					if (!_bFjOLB3sqVGFgwwMENJRlZ5vouC._3nKd9Dk3YeX87QB5dROwYUzczsN("Onions bowl glow", val.X, val.Y))
					{
						num30 = 1697269769;
						num31 = 1697269769;
					}
					else
					{
						num30 = 2117218449;
						num31 = 2117218449;
					}
					num = num30 ^ (int)(num2 * 957490383);
					continue;
				}
				case 15u:
					_FJRq83fBqGFaoHbsYpaAVoouvFQ();
					num = ((int)num2 * -1139677993) ^ -1527170856;
					continue;
				case 12u:
				{
					int num28;
					int num29;
					if (_h5v8MyOj54KK9SVZpYnagzRPLMP)
					{
						num28 = 753463002;
						num29 = 753463002;
					}
					else
					{
						num28 = 1195411433;
						num29 = 1195411433;
					}
					num = num28 ^ ((int)num2 * -93703500);
					continue;
				}
				case 11u:
					_bFjOLB3sqVGFgwwMENJRlZ5vouC._aAoZaDNczeScsMfLlGSfAzey9SQ("Ground beef bowl glow", 0f);
					num = 263149343;
					continue;
				case 10u:
					num = (int)((num2 * 40491200) ^ 0x35808A9F);
					continue;
				case 9u:
				{
					int num26;
					if (!_HylCIZnie9TY7iCNyKurgxQFFji)
					{
						num = 5035176;
						num26 = 5035176;
					}
					else
					{
						num = 893874324;
						num26 = 893874324;
					}
					continue;
				}
				case 8u:
				{
					int num21;
					int num22;
					if (base._ZzBuoSDMWwerejOO9Goyv2OCKgE._RbWJ7YGnYHCSoD44MRW1h5X6E7E._fy5ebLnmRsRXv9v7RKTFU5CGMaH(_PMeRYZJaBCqgB9uADJFP3c14lxq.LeftButton))
					{
						num21 = -793529852;
						num22 = -793529852;
					}
					else
					{
						num21 = -1484284214;
						num22 = -1484284214;
					}
					num = num21 ^ (int)(num2 * 1340758483);
					continue;
				}
				case 7u:
				{
					_QMxAinggzISmU1LmkqSK0bfv9h5("Tomatoe highlight", EIngrediants.TinnedTomatoes, _gDkX1mAt76eLA8P3gGXs2wM5wTE);
					int num18;
					int num19;
					if (!base._ZzBuoSDMWwerejOO9Goyv2OCKgE._RbWJ7YGnYHCSoD44MRW1h5X6E7E._fy5ebLnmRsRXv9v7RKTFU5CGMaH(_PMeRYZJaBCqgB9uADJFP3c14lxq.LeftButton))
					{
						num18 = 172617783;
						num19 = 172617783;
					}
					else
					{
						num18 = 1768284158;
						num19 = 1768284158;
					}
					num = num18 ^ (int)(num2 * 878144666);
					continue;
				}
				case 5u:
				{
					int num13;
					if (!_xJZUPxDatEzfPQc0nRHR2D1Vwke)
					{
						num = 1150009919;
						num13 = 1150009919;
					}
					else
					{
						num = 1425025983;
						num13 = 1425025983;
					}
					continue;
				}
				case 4u:
				{
					int num7;
					int num8;
					if (!base._ZzBuoSDMWwerejOO9Goyv2OCKgE._RbWJ7YGnYHCSoD44MRW1h5X6E7E._fy5ebLnmRsRXv9v7RKTFU5CGMaH(_PMeRYZJaBCqgB9uADJFP3c14lxq.LeftButton))
					{
						num7 = -946307532;
						num8 = -946307532;
					}
					else
					{
						num7 = -550624223;
						num8 = -550624223;
					}
					num = num7 ^ ((int)num2 * -98179377);
					continue;
				}
				case 3u:
					_vXYwDfsbbgNVJzdeudgo8WR1maV();
					num = ((int)num2 * -1692743153) ^ -1313420793;
					continue;
				case 2u:
					_QMxAinggzISmU1LmkqSK0bfv9h5("Bay highlight", EIngrediants.Herbs, _7f8HjbO7kyXkAQLb2mIqPJKHcLb);
					num = (int)(num2 * 1907297213) ^ -589971911;
					continue;
				case 1u:
					_bFjOLB3sqVGFgwwMENJRlZ5vouC._aAoZaDNczeScsMfLlGSfAzey9SQ("Onions bowl glow", 0f);
					num = 501792630;
					continue;
				case 0u:
				{
					int num3;
					if (!_oadA2EQp5TIkaydfB8B5lpw5Cmu)
					{
						num = 1847164771;
						num3 = 1847164771;
					}
					else
					{
						num = 1287486972;
						num3 = 1287486972;
					}
					continue;
				}
				default:
					return;
				case 6u:
					break;
				case 13u:
					return;
				case 14u:
					_hHMvLMSFiOFnDNkhUnBcQpsEN9T();
					return;
				case 16u:
					return;
				case 19u:
					return;
				}
				break;
			}
		}
	}

	private void _QMxAinggzISmU1LmkqSK0bfv9h5(string string_0, EIngrediants eingrediants_0, _hqmu3NsKXqziXGfVh3dt79G0fye _hqmu3NsKXqziXGfVh3dt79G0fye_0)
	{
		if (_tJRouny7ZhgCxrAgyXFLsqSeAMT != eingrediants_0)
		{
			while (true)
			{
				int num = -1708780406;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x9BCE60E7u) % 3u)
					{
					case 2u:
						CookingMiniGameScene.smethod_30(_hqmu3NsKXqziXGfVh3dt79G0fye_0, 1f);
						CookingMiniGameScene.smethod_31(_bFjOLB3sqVGFgwwMENJRlZ5vouC, string_0, (Action)null);
						num = ((int)num2 * -1115829152) ^ -1699419105;
						continue;
					case 0u:
						break;
					default:
						goto end_IL_004d;
					}
					break;
				}
				continue;
				end_IL_004d:
				break;
			}
		}
		_tJRouny7ZhgCxrAgyXFLsqSeAMT = eingrediants_0;
	}

	public void _7UQ7J6jOjw0vBiKHgcli5eXatrN()
	{
		if (_p28QNaoEJvHENbJjA4icWq92tkI)
		{
			return;
		}
		while (true)
		{
			int num = 2002399654;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x35243AAEu) % 7u)
				{
				case 6u:
				{
					int num3;
					int num4;
					if (_HXs79I5YAlnCxHxJS0JxD7jccyt)
					{
						num3 = -1374123774;
						num4 = -1374123774;
					}
					else
					{
						num3 = -72840090;
						num4 = -72840090;
					}
					num = num3 ^ (int)(num2 * 1525117370);
					continue;
				}
				case 4u:
					CookingMiniGameScene.smethod_31(_bFjOLB3sqVGFgwwMENJRlZ5vouC, "OnionsGarlic toss", (Action)delegate
					{
						_HXs79I5YAlnCxHxJS0JxD7jccyt = true;
						_n5dqiyQaiIqiC4wtWicCzzA8coG(EIngrediants.OnionsGarlic);
					});
					num = ((int)num2 * -1479977303) ^ 0x519DE424;
					continue;
				case 3u:
					CookingMiniGameScene.smethod_30(_Yl6cx6lo29nhZhAYCwYNXftaePb, 1f);
					num = ((int)num2 * -785424058) ^ 0x52796B4D;
					continue;
				case 2u:
					_p28QNaoEJvHENbJjA4icWq92tkI = true;
					num = 1020254924;
					continue;
				default:
					return;
				case 5u:
					break;
				case 1u:
					return;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	public void _KS0Vtg4XWGmpAsqFy5tYlJXLKLA()
	{
		if (_p28QNaoEJvHENbJjA4icWq92tkI)
		{
			return;
		}
		while (true)
		{
			int num = 534503140;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x38A317BFu) % 7u)
				{
				case 5u:
				{
					int num3;
					int num4;
					if (_HylCIZnie9TY7iCNyKurgxQFFji)
					{
						num3 = -1482885442;
						num4 = -1482885442;
					}
					else
					{
						num3 = -1478771865;
						num4 = -1478771865;
					}
					num = num3 ^ ((int)num2 * -1343928199);
					continue;
				}
				case 3u:
					_p28QNaoEJvHENbJjA4icWq92tkI = true;
					num = 684179367;
					continue;
				case 2u:
					CookingMiniGameScene.smethod_30(_Yl6cx6lo29nhZhAYCwYNXftaePb, 1f);
					num = ((int)num2 * -1971736335) ^ 0x7AD0190A;
					continue;
				case 1u:
					CookingMiniGameScene.smethod_31(_bFjOLB3sqVGFgwwMENJRlZ5vouC, "Ground beef toss", (Action)delegate
					{
						_HylCIZnie9TY7iCNyKurgxQFFji = true;
						while (true)
						{
							int num5 = 1037572164;
							while (true)
							{
								uint num6;
								switch ((num6 = (uint)num5 ^ 0x3D59E2D8u) % 3u)
								{
								case 1u:
									goto IL_0009;
								default:
									return;
								case 2u:
									break;
								case 0u:
									return;
								}
								break;
								IL_0009:
								_n5dqiyQaiIqiC4wtWicCzzA8coG(EIngrediants.GroundBeef);
								num5 = (int)((num6 * 425499910) ^ 0x4530EAA8);
							}
						}
					});
					num = ((int)num2 * -430990341) ^ 0x2074D5A5;
					continue;
				default:
					return;
				case 4u:
					break;
				case 0u:
					return;
				case 6u:
					return;
				}
				break;
			}
		}
	}

	public void _VcZyHKzhoXLGNA1DIp006kBhiDN()
	{
		if (_p28QNaoEJvHENbJjA4icWq92tkI)
		{
			return;
		}
		while (true)
		{
			int num = 1369085602;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7299600Eu) % 5u)
				{
				case 4u:
					_p28QNaoEJvHENbJjA4icWq92tkI = true;
					num = 1867019181;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (_mOljPVTpQkVD6dwmmr9m28l6fc)
					{
						num3 = 1509432203;
						num4 = 1509432203;
					}
					else
					{
						num3 = 1001501212;
						num4 = 1001501212;
					}
					num = num3 ^ ((int)num2 * -163748230);
					continue;
				}
				case 2u:
					break;
				default:
					CookingMiniGameScene.smethod_30(_Yl6cx6lo29nhZhAYCwYNXftaePb, 1f);
					CookingMiniGameScene.smethod_31(_bFjOLB3sqVGFgwwMENJRlZ5vouC, "Carrot toss", (Action)delegate
					{
						_mOljPVTpQkVD6dwmmr9m28l6fc = true;
						while (true)
						{
							int num5 = 1046269306;
							while (true)
							{
								uint num6;
								switch ((num6 = (uint)num5 ^ 0x12C6BEE6u) % 3u)
								{
								case 1u:
									goto IL_0009;
								default:
									return;
								case 2u:
									break;
								case 0u:
									return;
								}
								break;
								IL_0009:
								_n5dqiyQaiIqiC4wtWicCzzA8coG(EIngrediants.Carrots);
								num5 = (int)(num6 * 163539812) ^ -977764804;
							}
						}
					});
					return;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	public void _FJRq83fBqGFaoHbsYpaAVoouvFQ()
	{
		if (_p28QNaoEJvHENbJjA4icWq92tkI)
		{
			return;
		}
		while (true)
		{
			int num = -1864923963;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x80C76E88u) % 5u)
				{
				case 3u:
				{
					int num3;
					int num4;
					if (_g0GLDf9i20jtYweGI1DAr0f9WON)
					{
						num3 = 409672396;
						num4 = 409672396;
					}
					else
					{
						num3 = 377345648;
						num4 = 377345648;
					}
					num = num3 ^ ((int)num2 * -1445283852);
					continue;
				}
				case 1u:
					_p28QNaoEJvHENbJjA4icWq92tkI = true;
					CookingMiniGameScene.smethod_30(_Yl6cx6lo29nhZhAYCwYNXftaePb, 1f);
					CookingMiniGameScene.smethod_31(_bFjOLB3sqVGFgwwMENJRlZ5vouC, "Tomatoe toss", (Action)delegate
					{
						_g0GLDf9i20jtYweGI1DAr0f9WON = true;
						while (true)
						{
							int num5 = -1568009612;
							while (true)
							{
								uint num6;
								switch ((num6 = (uint)num5 ^ 0x8B4F1D13u) % 3u)
								{
								case 2u:
									goto IL_0009;
								default:
									return;
								case 0u:
									break;
								case 1u:
									return;
								}
								break;
								IL_0009:
								_n5dqiyQaiIqiC4wtWicCzzA8coG(EIngrediants.TinnedTomatoes);
								num5 = (int)((num6 * 70404817) ^ 0x211AC123);
							}
						}
					});
					num = -1777868977;
					continue;
				default:
					return;
				case 4u:
					break;
				case 0u:
					return;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	public void _hHMvLMSFiOFnDNkhUnBcQpsEN9T()
	{
		if (_p28QNaoEJvHENbJjA4icWq92tkI)
		{
			return;
		}
		while (true)
		{
			int num = -426076432;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0xDCB251E1u) % 4u)
				{
				case 1u:
				{
					int num4;
					if (_ylWBqGZTor7PB0HyMRwAuoV4hvH)
					{
						num3 = -311887035;
						num4 = -311887035;
					}
					else
					{
						num3 = -1172407097;
						num4 = -1172407097;
					}
					goto IL_002b;
				}
				case 3u:
					break;
				default:
					_p28QNaoEJvHENbJjA4icWq92tkI = true;
					CookingMiniGameScene.smethod_30(_Yl6cx6lo29nhZhAYCwYNXftaePb, 1f);
					CookingMiniGameScene.smethod_31(_bFjOLB3sqVGFgwwMENJRlZ5vouC, "Bay toss", (Action)delegate
					{
						_ylWBqGZTor7PB0HyMRwAuoV4hvH = true;
						_n5dqiyQaiIqiC4wtWicCzzA8coG(EIngrediants.Herbs);
					});
					return;
				case 2u:
					return;
				}
				break;
				IL_002b:
				num = num3 ^ (int)(num2 * 1919123158);
			}
		}
	}

	private void _n5dqiyQaiIqiC4wtWicCzzA8coG(EIngrediants eingrediants_0)
	{
		CookingMiniGameScene.smethod_33(_bFjOLB3sqVGFgwwMENJRlZ5vouC);
		while (true)
		{
			int num = 1870857799;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x460CE604u) % 7u)
				{
				case 5u:
					_NDwc6JiCbSmdqmQRU3taXzILgTBb.Add(eingrediants_0);
					num = 1765385858;
					continue;
				case 4u:
					CookingMiniGameScene.smethod_31(_bFjOLB3sqVGFgwwMENJRlZ5vouC, "Ingrediant mixing", (Action)_N6dXvS7twg0NRk66JAgWjTvfMRC);
					num = ((int)num2 * -1381719231) ^ -692176506;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (eingrediants_0 == EIngrediants.Pasta)
					{
						num3 = -1611931866;
						num4 = -1611931866;
					}
					else
					{
						num3 = -1143272189;
						num4 = -1143272189;
					}
					num = num3 ^ (int)(num2 * 1977853471);
					continue;
				}
				case 1u:
					CookingMiniGameScene.smethod_31(_bFjOLB3sqVGFgwwMENJRlZ5vouC, "Ingrediant mixing", (Action)delegate
					{
						_MOR64YNiUTpJJkXDvGxkr2BYs4n();
						CookingMiniGameScene.smethod_31(_bFjOLB3sqVGFgwwMENJRlZ5vouC, "Shits burning", (Action)_Ee9VcMQIfuD0ElqFdXVvMHxofkf);
					});
					num = ((int)num2 * -112763101) ^ -5752499;
					continue;
				default:
					return;
				case 6u:
					break;
				case 0u:
					return;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	private void _MOR64YNiUTpJJkXDvGxkr2BYs4n()
	{
		CookingMiniGameScene.smethod_30(_vdz7lnEalvPxBPYYcR15bPICZOc, 1f);
		_oadA2EQp5TIkaydfB8B5lpw5Cmu = true;
		while (true)
		{
			int num = 158815756;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3E096DF2u) % 3u)
				{
				case 2u:
					goto IL_0019;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_0019:
				_2Kg9JelDMoLPl78Uv5Lb5ygQff = 0f;
				_fp8jsuSnELXqf2yy2JQDaXDCBVQ._k8HavJ0P5yWjzHBpsDOOGVNY8MM = true;
				num = ((int)num2 * -228441704) ^ 0x319BB1ED;
			}
		}
	}

	private void _Ee9VcMQIfuD0ElqFdXVvMHxofkf()
	{
		_oadA2EQp5TIkaydfB8B5lpw5Cmu = false;
		while (true)
		{
			int num = -285041825;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD4A2D3E1u) % 4u)
				{
				case 2u:
					_fp8jsuSnELXqf2yy2JQDaXDCBVQ._k8HavJ0P5yWjzHBpsDOOGVNY8MM = false;
					_JuZlzgvacKG5z0tmPuFzmPPGDog = _2Kg9JelDMoLPl78Uv5Lb5ygQff;
					num = (int)((num2 * 1210985544) ^ 0x6D5DBC00);
					continue;
				case 1u:
					CookingMiniGameScene.smethod_34(_bFjOLB3sqVGFgwwMENJRlZ5vouC);
					num = ((int)num2 * -1701987418) ^ 0x5523AAF0;
					continue;
				case 0u:
					break;
				default:
					_N6dXvS7twg0NRk66JAgWjTvfMRC();
					return;
				}
				break;
			}
		}
	}

	private void _N6dXvS7twg0NRk66JAgWjTvfMRC()
	{
		if (_h5v8MyOj54KK9SVZpYnagzRPLMP)
		{
			goto IL_002d;
		}
		goto IL_0079;
		IL_0079:
		int num;
		int num2;
		if (_NDwc6JiCbSmdqmQRU3taXzILgTBb.Count < 5)
		{
			num = 561841017;
			num2 = 561841017;
		}
		else
		{
			num = 1276936332;
			num2 = 1276936332;
		}
		goto IL_0040;
		IL_0040:
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num ^ 0x3D9759E0u) % 7u)
			{
			case 5u:
				_xJZUPxDatEzfPQc0nRHR2D1Vwke = true;
				num = ((int)num3 * -849980220) ^ -552792089;
				continue;
			case 4u:
				break;
			case 1u:
				_p28QNaoEJvHENbJjA4icWq92tkI = false;
				num = 463512996;
				continue;
			default:
				return;
			case 0u:
				goto IL_0079;
			case 2u:
				_LWHyrTq71jxy9B95UaU1a22AmHG();
				return;
			case 3u:
				return;
			case 6u:
				return;
			}
			break;
		}
		goto IL_002d;
		IL_002d:
		num = 455239922;
		goto IL_0040;
	}

	private void _LWHyrTq71jxy9B95UaU1a22AmHG()
	{
		_h5v8MyOj54KK9SVZpYnagzRPLMP = true;
		while (true)
		{
			int num = -1983203416;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB9247FA9u) % 4u)
				{
				case 3u:
					_n5dqiyQaiIqiC4wtWicCzzA8coG(EIngrediants.Pasta);
					num = ((int)num2 * -241289644) ^ -885266673;
					continue;
				case 1u:
					CookingMiniGameScene.smethod_30(_Yl6cx6lo29nhZhAYCwYNXftaePb, 1f);
					num = ((int)num2 * -2133034950) ^ -2053340720;
					continue;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	public void _NvWWx67tvkIBmEn9fgXJ9ZzWJMS()
	{
		_T81AMuUIGw7sZkYmJkIpiDPosrD = false;
		CookingMiniGameScene.smethod_35(0f);
		CookingMiniGameScene.smethod_37(CookingMiniGameScene.smethod_36(CookingMiniGameScene.smethod_14((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)), (Action)delegate
		{
			CookingMiniGameScene.smethod_30(_3h9I4xBs98PF8vAbLXJAdpmHA8dA, 1f);
			while (true)
			{
				int num = -310725807;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA893776Au) % 3u)
					{
					case 2u:
						goto IL_0012;
					default:
						return;
					case 0u:
						break;
					case 1u:
						return;
					}
					break;
					IL_0012:
					_Iqfa1mamDp2busajsE8iPWnCKbDA = true;
					num = (int)(num2 * 1562647569) ^ -1142924591;
				}
			}
		});
	}

	private void _vXYwDfsbbgNVJzdeudgo8WR1maV()
	{
		int num7 = default(int);
		int num5 = default(int);
		bool _Y8SewnxQuAuHOtMeTeuRSJlpbGJ = default(bool);
		bool _YVtICgpvRZU0ZRqniFuAVlkSOFM = default(bool);
		int num11 = default(int);
		CookingMiniGameScene _KJWMaoRJ7oaDYXtF5MPjg5DcYwvA = default(CookingMiniGameScene);
		while (true)
		{
			int num = -316252115;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEEE12C5Cu) % 26u)
				{
				case 25u:
					num7++;
					num = -1701482239;
					continue;
				case 24u:
					num7 = 0;
					num = (int)((num2 * 1081367209) ^ 0x7244F3CC);
					continue;
				case 23u:
				{
					int num13;
					int num14;
					if (num5 >= 3)
					{
						num13 = 1967321541;
						num14 = 1967321541;
					}
					else
					{
						num13 = 1494998981;
						num14 = 1494998981;
					}
					num = num13 ^ ((int)num2 * -1997854974);
					continue;
				}
				case 22u:
				{
					int num6;
					if (num5 <= 0)
					{
						num = -1713707177;
						num6 = -1713707177;
					}
					else
					{
						num = -1344432235;
						num6 = -1344432235;
					}
					continue;
				}
				case 21u:
					CookingMiniGameScene.smethod_17(_RZsDgwVY7R44E6mMbUF7YWYyBjK, !_Y8SewnxQuAuHOtMeTeuRSJlpbGJ && !_YVtICgpvRZU0ZRqniFuAVlkSOFM);
					num = -858512651;
					continue;
				case 20u:
					num11++;
					num = ((int)num2 * -161010221) ^ 0x2FF163CB;
					continue;
				case 19u:
					_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA = this;
					num5 = 0;
					num = ((int)num2 * -1050653535) ^ -583157939;
					continue;
				case 18u:
					_Y8SewnxQuAuHOtMeTeuRSJlpbGJ = false;
					num = (int)((num2 * 2105138438) ^ 0x245E2F30);
					continue;
				case 16u:
					_Y8SewnxQuAuHOtMeTeuRSJlpbGJ = true;
					_YVtICgpvRZU0ZRqniFuAVlkSOFM = false;
					num = -910977984;
					continue;
				case 15u:
					_Y8SewnxQuAuHOtMeTeuRSJlpbGJ = true;
					num = -1514599943;
					continue;
				case 14u:
				{
					int num15;
					if (num5 != 0)
					{
						num = -1250936974;
						num15 = -1250936974;
					}
					else
					{
						num = -1347867776;
						num15 = -1347867776;
					}
					continue;
				}
				case 13u:
					_Y8SewnxQuAuHOtMeTeuRSJlpbGJ = false;
					_YVtICgpvRZU0ZRqniFuAVlkSOFM = false;
					num = (int)((num2 * 628277083) ^ 0x13430BA9);
					continue;
				case 12u:
					_YVtICgpvRZU0ZRqniFuAVlkSOFM = true;
					num = (int)(num2 * 2065674431) ^ -1727967492;
					continue;
				case 11u:
					CookingMiniGameScene.smethod_17(_urxVZoSWXCtbeM9oQmVXW0Fb7co, _Y8SewnxQuAuHOtMeTeuRSJlpbGJ);
					num = ((int)num2 * -2022307027) ^ -2086873272;
					continue;
				case 10u:
					num11 = 0;
					num = (int)(num2 * 1948141834) ^ -1682206047;
					continue;
				case 9u:
				{
					EIngrediants eIngrediants = _NDwc6JiCbSmdqmQRU3taXzILgTBb[num7];
					int num12;
					if (eIngrediants == (EIngrediants)num11)
					{
						num = -946961538;
						num12 = -946961538;
					}
					else
					{
						num = -1370137222;
						num12 = -1370137222;
					}
					continue;
				}
				case 8u:
					num5++;
					num = -998952755;
					continue;
				case 7u:
					CookingMiniGameScene.smethod_17(_9cxzh98qcLMOVst3Rlmc4AaYoBp, _YVtICgpvRZU0ZRqniFuAVlkSOFM);
					num = (int)(num2 * 228902393) ^ -154226560;
					continue;
				case 6u:
					CookingMiniGameScene.smethod_39(CookingMiniGameScene.smethod_38(), "Pasta.Poor", _Y8SewnxQuAuHOtMeTeuRSJlpbGJ);
					num = -130663768;
					continue;
				case 5u:
					_YVtICgpvRZU0ZRqniFuAVlkSOFM = false;
					num = (int)(num2 * 831876374) ^ -1240405650;
					continue;
				case 4u:
					CookingMiniGameScene.smethod_39(CookingMiniGameScene.smethod_38(), "Pasta.Perfect", _YVtICgpvRZU0ZRqniFuAVlkSOFM);
					num = ((int)num2 * -2130633442) ^ -499772679;
					continue;
				case 3u:
				{
					int num10;
					if (num7 < _NDwc6JiCbSmdqmQRU3taXzILgTBb.Count)
					{
						num = -1802678659;
						num10 = -1802678659;
					}
					else
					{
						num = -1759867834;
						num10 = -1759867834;
					}
					continue;
				}
				case 1u:
				{
					int num8;
					int num9;
					if (_JuZlzgvacKG5z0tmPuFzmPPGDog <= 4.5f)
					{
						num8 = -799837837;
						num9 = -799837837;
					}
					else
					{
						num8 = -1185991765;
						num9 = -1185991765;
					}
					num = num8 ^ ((int)num2 * -810456445);
					continue;
				}
				case 0u:
				{
					int num3;
					int num4;
					if (!(_JuZlzgvacKG5z0tmPuFzmPPGDog >= 2.5f))
					{
						num3 = 1816552312;
						num4 = 1816552312;
					}
					else
					{
						num3 = 1758242397;
						num4 = 1758242397;
					}
					num = num3 ^ ((int)num2 * -2388188);
					continue;
				}
				case 2u:
					break;
				default:
					CookingMiniGameScene.smethod_40(CookingMiniGameScene.smethod_36(CookingMiniGameScene.smethod_14((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)), (Action)delegate
					{
						if (_YVtICgpvRZU0ZRqniFuAVlkSOFM)
						{
							goto IL_0065;
						}
						goto IL_00ec;
						IL_00ec:
						int num16;
						int num17;
						if (!_Y8SewnxQuAuHOtMeTeuRSJlpbGJ)
						{
							num16 = -36277460;
							num17 = -36277460;
						}
						else
						{
							num16 = -1150107580;
							num17 = -1150107580;
						}
						goto IL_00b0;
						IL_00b0:
						while (true)
						{
							uint num18;
							switch ((num18 = (uint)num16 ^ 0x8120D4C7u) % 7u)
							{
							case 6u:
								_003C_003Ec__DisplayClass65_0.smethod_3(_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._QQrPUpwIvHnFnZeHb0cfL7CPSHh, 1f);
								num16 = ((int)num18 * -2016422622) ^ 0x78BAFE96;
								continue;
							case 5u:
								_003C_003Ec__DisplayClass65_0.smethod_3(_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._MHlWAOoiEHfmdM0FqWO6WSRbC1hA, 1f);
								num16 = (int)(num18 * 1267297539) ^ -1430389477;
								continue;
							case 4u:
								break;
							case 3u:
								_003C_003Ec__DisplayClass65_0.smethod_2(_003C_003Ec__DisplayClass65_0.smethod_1(_003C_003Ec__DisplayClass65_0.smethod_0((_7UlnfykmEmZDFt3BmCKZekI43Ih)_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA)), "AchievementGeneric11");
								num16 = ((int)num18 * -1929270516) ^ -1328326970;
								continue;
							case 0u:
								_003C_003Ec__DisplayClass65_0.smethod_3(_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._8CTAuE7kLwrQAWKi1EOgTa2AKEx, 1f);
								num16 = -866236688;
								continue;
							case 1u:
								goto IL_00ec;
							default:
								_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._T81AMuUIGw7sZkYmJkIpiDPosrD = true;
								return;
							}
							break;
						}
						goto IL_0065;
						IL_0065:
						num16 = -740983379;
						goto IL_00b0;
					});
					return;
				}
				break;
			}
		}
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
		while (true)
		{
			int num = 1037572164;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3D59E2D8u) % 3u)
				{
				case 1u:
					goto IL_0009;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_0009:
				_n5dqiyQaiIqiC4wtWicCzzA8coG(EIngrediants.GroundBeef);
				num = (int)((num2 * 425499910) ^ 0x4530EAA8);
			}
		}
	}

	[CompilerGenerated]
	private void _WtG9pBnQz1VMaCkOOLs8yDzfQ3G()
	{
		_mOljPVTpQkVD6dwmmr9m28l6fc = true;
		while (true)
		{
			int num = 1046269306;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x12C6BEE6u) % 3u)
				{
				case 1u:
					goto IL_0009;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_0009:
				_n5dqiyQaiIqiC4wtWicCzzA8coG(EIngrediants.Carrots);
				num = (int)(num2 * 163539812) ^ -977764804;
			}
		}
	}

	[CompilerGenerated]
	private void _mXM4ENlz9PvfKHf9jFBpDxs3vEB()
	{
		_g0GLDf9i20jtYweGI1DAr0f9WON = true;
		while (true)
		{
			int num = -1568009612;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8B4F1D13u) % 3u)
				{
				case 2u:
					goto IL_0009;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_0009:
				_n5dqiyQaiIqiC4wtWicCzzA8coG(EIngrediants.TinnedTomatoes);
				num = (int)((num2 * 70404817) ^ 0x211AC123);
			}
		}
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
		while (true)
		{
			int num = -310725807;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA893776Au) % 3u)
				{
				case 2u:
					goto IL_0012;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_0012:
				_Iqfa1mamDp2busajsE8iPWnCKbDA = true;
				num = (int)(num2 * 1562647569) ^ -1142924591;
			}
		}
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
