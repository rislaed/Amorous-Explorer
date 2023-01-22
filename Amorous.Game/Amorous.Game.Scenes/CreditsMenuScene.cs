using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Amorous.Game.Scenes;

public class CreditsMenuScene : _7UlnfykmEmZDFt3BmCKZekI43Ih
{
	private readonly SpriteFont _nQK443boDHTZ4Jfc3W1VhQkMCcX;

	private readonly float _2MfIKVtD2AO6rfNH8r9gBa9ABgc;

	private readonly SpriteFont _tYZIsh9jywDMNNUVaAxLdrUBPIS;

	private readonly float _lHXUPUciX33biAqfQQ8Yx79nzNB;

	private readonly SpriteFont _6YCQhlMaqcDds8uGX1g8fjBKqV4A;

	private readonly float _3STGOMMEQo4zHKNnz9z7ftUA5Df;

	private const float _SYCUujPcgcLNT43d8U31LaDAs2Bb = 100f;

	private const float _eFVIk59FLQAd5rciw22CSTJMEIG = 300f;

	private readonly string[] _Otv0Xepue9AcysEmioBbEWTisDaA;

	private Matrix _5tVHyet2nKslcI2f5Yppk4hAIDA;

	private float _D1Fi4WCGaRckYZ4B9s6CN7FyrsS;

	private float _34TN98j3wyO7VbJ4niAsNCCgFuD;

	private float _lmBaEmzKj1Yvgl07XZnnBeMGYov;

	protected Type _t76cjDKppsRdw5nUq3tnNw3ypAv { get; set; }

	protected string _ICAb9QUE8hnbl0uKD8fBpEB1kSV { get; set; }

	public CreditsMenuScene(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_041b: Unknown result type (might be due to invalid IL or missing references)
		//IL_044c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0451: Unknown result type (might be due to invalid IL or missing references)
		int int_2 = default(int);
		Vector2 val = default(Vector2);
		bool _vfz3itarR7RfYdT3BqrAmb1qElP = default(bool);
		_fAUddQEKfZyemRb327NhM3GGlmzA gparam_ = default(_fAUddQEKfZyemRb327NhM3GGlmzA);
		int int_ = default(int);
		List<string> list = default(List<string>);
		int num5 = default(int);
		_kxm3yIqio0baXT5t5vOHBAEdviB kxm3yIqio0baXT5t5vOHBAEdviB = default(_kxm3yIqio0baXT5t5vOHBAEdviB);
		float fO7gSlrDDNMoHR4FO5QXAq8fUyA = default(float);
		Point _LWpJMkbSZ0LnBJGJqKcICxgdLwq = default(Point);
		CreditsMenuScene _KJWMaoRJ7oaDYXtF5MPjg5DcYwvA = default(CreditsMenuScene);
		Vector2 _AjA452JzkbwnCTtbITN5kOEaNrR = default(Vector2);
		while (true)
		{
			int num = -476600754;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x83253983u) % 28u)
				{
				case 27u:
					CreditsMenuScene.smethod_15((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Background", "Assets/Scenes/CreditsMenu/Background", 0, 0);
					CreditsMenuScene.smethod_16((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Overlay", "Assets/Scenes/CreditsMenu/Overlay", 0, 0);
					num = ((int)num2 * -1523030824) ^ 0x3981DE61;
					continue;
				case 25u:
					int_2 = 105;
					num = (int)(num2 * 253855162) ^ -1797904680;
					continue;
				case 24u:
					num = (int)((num2 * 2047881710) ^ 0x7D401493);
					continue;
				case 23u:
					val = CreditsMenuScene.smethod_18(_nQK443boDHTZ4Jfc3W1VhQkMCcX, "Test");
					num = (int)((num2 * 821303657) ^ 0x4A56CA44);
					continue;
				case 22u:
					_vfz3itarR7RfYdT3BqrAmb1qElP = false;
					val = _6YCQhlMaqcDds8uGX1g8fjBKqV4A.MeasureString(_ICAb9QUE8hnbl0uKD8fBpEB1kSV);
					num = ((int)num2 * -622207207) ^ 0x619B1C2A;
					continue;
				case 21u:
					_Otv0Xepue9AcysEmioBbEWTisDaA = _K2047A8SCJdaw0LZKStEHOiH110._GxOfTBefEUfWKWaWgxVRKsjugxE(Path.Combine(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0._uwNDZuqdFb9tyQtlQMxiz1DQ7x8.get_RootDirectory(), "Data/credits.txt")).Replace("\r", string.Empty).Split(new char[1] { '\n' });
					gparam_ = new _fAUddQEKfZyemRb327NhM3GGlmzA(this, "Credits")
					{
						_NC5P3SKqKPpcAYG1mqquUEcUzTg = _y3e1BQlF0D44DVRCJQTcKxaeNOb,
						_B6VrMlmWofCGqEzjzgFJiAliCge = _R35LFMCpqnW2Zsm1xJon3qf0UAg
					};
					num = ((int)num2 * -47729821) ^ 0x111C3B06;
					continue;
				case 20u:
					int_ = 1000;
					num = ((int)num2 * -1620836249) ^ 0x2F738BDE;
					continue;
				case 19u:
					list.Add($"Assets/Scenes/CreditsMenu/Skye/TYSkye{num5:D2}");
					num5++;
					num = -1297609773;
					continue;
				case 18u:
					int_ = 1170;
					num = -372816750;
					continue;
				case 17u:
					kxm3yIqio0baXT5t5vOHBAEdviB._fO7gSlrDDNMoHR4FO5QXAq8fUyA = fO7gSlrDDNMoHR4FO5QXAq8fUyA;
					_D1Fi4WCGaRckYZ4B9s6CN7FyrsS = 960f;
					num = ((int)num2 * -1143840372) ^ -1236159745;
					continue;
				case 16u:
				{
					int num6;
					if (num5 < 60)
					{
						num = -771531324;
						num6 = -771531324;
					}
					else
					{
						num = -1231747829;
						num6 = -1231747829;
					}
					continue;
				}
				case 15u:
					_LWpJMkbSZ0LnBJGJqKcICxgdLwq = base._ZzBuoSDMWwerejOO9Goyv2OCKgE._vsceSzSIjBy2nZrCxAzKZbUiwLq._2j5HjqIBNOwD2br7yBprKdzVhAK(new Point((int)val.X, (int)val.Y));
					num = (int)((num2 * 2094512856) ^ 0x31419FBC);
					continue;
				case 14u:
					_ICAb9QUE8hnbl0uKD8fBpEB1kSV = "Press Escape or Left-click here to return to the Main Menu.";
					num = ((int)num2 * -1047571109) ^ -2068731690;
					continue;
				case 13u:
					int_2 = 105;
					fO7gSlrDDNMoHR4FO5QXAq8fUyA = 2f;
					num = ((int)num2 * -1487217746) ^ -766182127;
					continue;
				case 12u:
					_2MfIKVtD2AO6rfNH8r9gBa9ABgc = val.Y;
					num = (int)(num2 * 932083944) ^ -1085556307;
					continue;
				case 11u:
					base._XvcwmP1Eb6HFUF5pkiUVgpqNbWE = BlendState.AlphaBlend;
					_t76cjDKppsRdw5nUq3tnNw3ypAv = CreditsMenuScene.smethod_14(typeof(MainMenuScene).TypeHandle);
					num = (int)((num2 * 48118031) ^ 0x45F9639C);
					continue;
				case 10u:
					_nQK443boDHTZ4Jfc3W1VhQkMCcX = CreditsMenuScene.smethod_17(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0).Load<SpriteFont>("Assets/GUI/Fonts/Bold-26");
					_tYZIsh9jywDMNNUVaAxLdrUBPIS = CreditsMenuScene.smethod_17(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0).Load<SpriteFont>("Assets/GUI/Fonts/Bold-20");
					_6YCQhlMaqcDds8uGX1g8fjBKqV4A = CreditsMenuScene.smethod_17(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0).Load<SpriteFont>("Assets/GUI/Fonts/Bold-14");
					num = ((int)num2 * -1713457203) ^ 0x756A813E;
					continue;
				case 9u:
					list = new List<string>();
					num5 = 1;
					num = ((int)num2 * -1517932693) ^ 0x20E45898;
					continue;
				case 7u:
					_7oYtfGpL7UyAQrZxew7Ahbvj6Sv(new _fAUddQEKfZyemRb327NhM3GGlmzA(this, "GoBackText")
					{
						_NC5P3SKqKPpcAYG1mqquUEcUzTg = delegate
						{
							//IL_0020: Unknown result type (might be due to invalid IL or missing references)
							//IL_0025: Unknown result type (might be due to invalid IL or missing references)
							//IL_002a: Unknown result type (might be due to invalid IL or missing references)
							//IL_0073: Unknown result type (might be due to invalid IL or missing references)
							//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
							//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
							//IL_0125: Unknown result type (might be due to invalid IL or missing references)
							Point val2 = _003C_003Ec__DisplayClass21_0.smethod_4(_003C_003Ec__DisplayClass21_0.smethod_1(_003C_003Ec__DisplayClass21_0.smethod_0((_7UlnfykmEmZDFt3BmCKZekI43Ih)_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA)), _003C_003Ec__DisplayClass21_0.smethod_3(_003C_003Ec__DisplayClass21_0.smethod_2(_003C_003Ec__DisplayClass21_0.smethod_0((_7UlnfykmEmZDFt3BmCKZekI43Ih)_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA))));
							while (true)
							{
								int num9 = -1540744041;
								while (true)
								{
									uint num10;
									switch ((num10 = (uint)num9 ^ 0xDB5464B1u) % 9u)
									{
									case 8u:
									{
										_vfz3itarR7RfYdT3BqrAmb1qElP = true;
										int num13;
										int num14;
										if (_003C_003Ec__DisplayClass21_0.smethod_5(_003C_003Ec__DisplayClass21_0.smethod_2(_003C_003Ec__DisplayClass21_0.smethod_0((_7UlnfykmEmZDFt3BmCKZekI43Ih)_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA)), _PMeRYZJaBCqgB9uADJFP3c14lxq.LeftButton))
										{
											num13 = 599256167;
											num14 = 599256167;
										}
										else
										{
											num13 = 55274095;
											num14 = 55274095;
										}
										num9 = num13 ^ ((int)num10 * -214726555);
										continue;
									}
									case 7u:
									{
										int num17;
										int num18;
										if ((float)val2.Y > _AjA452JzkbwnCTtbITN5kOEaNrR.Y + (float)_LWpJMkbSZ0LnBJGJqKcICxgdLwq.Y)
										{
											num17 = 1475912582;
											num18 = 1475912582;
										}
										else
										{
											num17 = 1379885272;
											num18 = 1379885272;
										}
										num9 = num17 ^ (int)(num10 * 911993526);
										continue;
									}
									case 6u:
									{
										int num15;
										int num16;
										if ((float)val2.X >= _AjA452JzkbwnCTtbITN5kOEaNrR.X)
										{
											num15 = -1716954153;
											num16 = -1716954153;
										}
										else
										{
											num15 = -750231226;
											num16 = -750231226;
										}
										num9 = num15 ^ (int)(num10 * 52679495);
										continue;
									}
									case 3u:
									{
										int num19;
										int num20;
										if ((float)val2.Y >= _AjA452JzkbwnCTtbITN5kOEaNrR.Y)
										{
											num19 = 2077507136;
											num20 = 2077507136;
										}
										else
										{
											num19 = 1053490754;
											num20 = 1053490754;
										}
										num9 = num19 ^ ((int)num10 * -1759685995);
										continue;
									}
									case 2u:
									{
										int num11;
										int num12;
										if ((float)val2.X <= _AjA452JzkbwnCTtbITN5kOEaNrR.X + (float)_LWpJMkbSZ0LnBJGJqKcICxgdLwq.X)
										{
											num11 = 1211034995;
											num12 = 1211034995;
										}
										else
										{
											num11 = 1908599768;
											num12 = 1908599768;
										}
										num9 = num11 ^ ((int)num10 * -256290945);
										continue;
									}
									case 1u:
										_vfz3itarR7RfYdT3BqrAmb1qElP = false;
										num9 = -1784797792;
										continue;
									default:
										return;
									case 0u:
										break;
									case 4u:
										_003C_003Ec__DisplayClass21_0.smethod_7(_003C_003Ec__DisplayClass21_0.smethod_0((_7UlnfykmEmZDFt3BmCKZekI43Ih)_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA), _003C_003Ec__DisplayClass21_0.smethod_6((MemberInfo)_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._t76cjDKppsRdw5nUq3tnNw3ypAv));
										return;
									case 5u:
										return;
									}
									break;
								}
							}
						},
						_B6VrMlmWofCGqEzjzgFJiAliCge = delegate(SpriteBatch spriteBatch_0)
						{
							//IL_0035: Unknown result type (might be due to invalid IL or missing references)
							//IL_0042: Unknown result type (might be due to invalid IL or missing references)
							//IL_0049: Unknown result type (might be due to invalid IL or missing references)
							_003C_003Ec__DisplayClass21_0.smethod_8(spriteBatch_0);
							while (true)
							{
								int num7 = -677088923;
								while (true)
								{
									uint num8;
									switch ((num8 = (uint)num7 ^ 0xED5FE044u) % 4u)
									{
									case 3u:
										_003C_003Ec__DisplayClass21_0.smethod_10(spriteBatch_0);
										num7 = ((int)num8 * -44359463) ^ -394000619;
										continue;
									case 1u:
										_003C_003Ec__DisplayClass21_0.smethod_9(spriteBatch_0, _KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._nQK443boDHTZ4Jfc3W1VhQkMCcX, _KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._ICAb9QUE8hnbl0uKD8fBpEB1kSV, _AjA452JzkbwnCTtbITN5kOEaNrR, _vfz3itarR7RfYdT3BqrAmb1qElP ? Color.get_Red() : Color.get_White());
										num7 = -1514977805;
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
					}, 2);
					num = (int)(num2 * 1931302161) ^ -259860027;
					continue;
				case 6u:
					_7oYtfGpL7UyAQrZxew7Ahbvj6Sv(gparam_, 0);
					num = (int)(num2 * 946718980) ^ -1924266407;
					continue;
				case 5u:
					_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA = this;
					num = (int)(num2 * 1081749643) ^ -1096059421;
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (!_iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF)
					{
						num3 = 1827203669;
						num4 = 1827203669;
					}
					else
					{
						num3 = 857204603;
						num4 = 857204603;
					}
					num = num3 ^ ((int)num2 * -342286281);
					continue;
				}
				case 3u:
					_lHXUPUciX33biAqfQQ8Yx79nzNB = val.Y;
					val = CreditsMenuScene.smethod_18(_6YCQhlMaqcDds8uGX1g8fjBKqV4A, "Test");
					_3STGOMMEQo4zHKNnz9z7ftUA5Df = val.Y;
					_AjA452JzkbwnCTtbITN5kOEaNrR = new Vector2(50f, 1080f - _2MfIKVtD2AO6rfNH8r9gBa9ABgc - 40f);
					_UmxbIbk7pgaod0bD7pS309P3Lns._l94kUraQ13OohoVwwxKC37hG7Pc("Assets/Music/Father-of-Death - Happy Jazz Shit", 0.4f);
					num = (int)((num2 * 1239156916) ^ 0x724EEEAA);
					continue;
				case 2u:
					val = CreditsMenuScene.smethod_18(_tYZIsh9jywDMNNUVaAxLdrUBPIS, "Test");
					num = (int)((num2 * 1685717605) ^ 0x64CE40FA);
					continue;
				case 1u:
					fO7gSlrDDNMoHR4FO5QXAq8fUyA = 1.5f;
					num = ((int)num2 * -758367372) ^ -772335969;
					continue;
				case 0u:
					kxm3yIqio0baXT5t5vOHBAEdviB = _gqeDf50vdgfHqlAbH8UK4sXgtYAA("Skye", int_, int_2, 16, list.ToArray());
					num = -1591065230;
					continue;
				case 26u:
					break;
				default:
					_lmBaEmzKj1Yvgl07XZnnBeMGYov = 100f;
					return;
				}
				break;
			}
		}
	}

	public void _y3e1BQlF0D44DVRCJQTcKxaeNOb(GameTime gameTime_0)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		_5tVHyet2nKslcI2f5Yppk4hAIDA = Matrix.CreateTranslation(100f, _D1Fi4WCGaRckYZ4B9s6CN7FyrsS, 0f);
		if (_D1Fi4WCGaRckYZ4B9s6CN7FyrsS > _34TN98j3wyO7VbJ4niAsNCCgFuD)
		{
			goto IL_0029;
		}
		goto IL_004d;
		IL_004d:
		_D1Fi4WCGaRckYZ4B9s6CN7FyrsS = 960f;
		int num = 1844017314;
		goto IL_002e;
		IL_002e:
		switch ((uint)(num ^ 0x4BE5C462) % 4u)
		{
		case 2u:
			break;
		default:
			return;
		case 3u:
			goto IL_004d;
		case 0u:
			return;
		case 1u:
			_D1Fi4WCGaRckYZ4B9s6CN7FyrsS -= (float)CreditsMenuScene.smethod_19(gameTime_0).Milliseconds / 1000f * _lmBaEmzKj1Yvgl07XZnnBeMGYov;
			return;
		}
		goto IL_0029;
		IL_0029:
		num = 2119974151;
		goto IL_002e;
	}

	public void _R35LFMCpqnW2Zsm1xJon3qf0UAg(SpriteBatch spriteBatch_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		Vector2 zero = Vector2.get_Zero();
		float num3 = default(float);
		float num6 = default(float);
		string string_ = default(string);
		string[] otv0Xepue9AcysEmioBbEWTisDaA = default(string[]);
		int num7 = default(int);
		while (true)
		{
			int num = 908565088;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x24F72DC3u) % 19u)
				{
				case 18u:
					num3 += num6;
					num = (int)((num2 * 554667633) ^ 0x2E6B24CF);
					continue;
				case 17u:
					num3 += _lHXUPUciX33biAqfQQ8Yx79nzNB + num6;
					num = (int)((num2 * 1212618087) ^ 0x48AC550C);
					continue;
				case 16u:
					string_ = otv0Xepue9AcysEmioBbEWTisDaA[num7];
					num = 588796406;
					continue;
				case 15u:
					num = (int)((num2 * 754850392) ^ 0x3C6B9BDF);
					continue;
				case 14u:
					num = ((int)num2 * -1834042524) ^ 0x3EAD8DF3;
					continue;
				case 13u:
					num = ((int)num2 * -911549631) ^ -1209308042;
					continue;
				case 12u:
					num6 = 10f;
					num = (int)(num2 * 350983924) ^ -1080652253;
					continue;
				case 9u:
					CreditsMenuScene.smethod_24(spriteBatch_0, _tYZIsh9jywDMNNUVaAxLdrUBPIS, CreditsMenuScene.smethod_23(string_, 2), zero, Color.get_Pink());
					num = ((int)num2 * -123521630) ^ -1854866453;
					continue;
				case 8u:
				{
					int num10;
					if (!CreditsMenuScene.smethod_22(string_, "##"))
					{
						num = 443568990;
						num10 = 443568990;
					}
					else
					{
						num = 1979769097;
						num10 = 1979769097;
					}
					continue;
				}
				case 7u:
					num3 = 0f;
					CreditsMenuScene.smethod_20(spriteBatch_0, (SpriteSortMode)0, (BlendState)null, (SamplerState)null, (DepthStencilState)null, (RasterizerState)null, (Effect)null, (Matrix?)_5tVHyet2nKslcI2f5Yppk4hAIDA);
					otv0Xepue9AcysEmioBbEWTisDaA = _Otv0Xepue9AcysEmioBbEWTisDaA;
					num7 = 0;
					num = ((int)num2 * -1951933946) ^ -2056378936;
					continue;
				case 6u:
				{
					int num9;
					if (CreditsMenuScene.smethod_22(string_, "#"))
					{
						num = 2044608425;
						num9 = 2044608425;
					}
					else
					{
						num = 1166773152;
						num9 = 1166773152;
					}
					continue;
				}
				case 5u:
					zero.Y = num3;
					num7++;
					num = 2075054377;
					continue;
				case 4u:
					CreditsMenuScene.smethod_24(spriteBatch_0, _6YCQhlMaqcDds8uGX1g8fjBKqV4A, string_, zero, Color.get_White());
					num3 += _3STGOMMEQo4zHKNnz9z7ftUA5Df + num6;
					num = 1115668031;
					continue;
				case 3u:
					CreditsMenuScene.smethod_24(spriteBatch_0, _nQK443boDHTZ4Jfc3W1VhQkMCcX, CreditsMenuScene.smethod_23(string_, 1), zero, Color.get_SkyBlue());
					num3 += _2MfIKVtD2AO6rfNH8r9gBa9ABgc + num6;
					num = ((int)num2 * -444051470) ^ 0x49B62F43;
					continue;
				case 2u:
				{
					int num8;
					if (num7 < otv0Xepue9AcysEmioBbEWTisDaA.Length)
					{
						num = 376943182;
						num8 = 376943182;
					}
					else
					{
						num = 1154839096;
						num8 = 1154839096;
					}
					continue;
				}
				case 1u:
					num = ((int)num2 * -383668019) ^ -602210706;
					continue;
				case 0u:
				{
					int num4;
					int num5;
					if (CreditsMenuScene.smethod_21(string_))
					{
						num4 = 474885929;
						num5 = 474885929;
					}
					else
					{
						num4 = 1082333356;
						num5 = 1082333356;
					}
					num = num4 ^ ((int)num2 * -1647387869);
					continue;
				}
				case 11u:
					break;
				default:
					_34TN98j3wyO7VbJ4niAsNCCgFuD = 0f - num3;
					CreditsMenuScene.smethod_25(spriteBatch_0);
					return;
				}
				break;
			}
		}
	}

	public override void _tiBFUHPEkedkbgvuX3whdeyjhKo(GameTime gameTime_0)
	{
		if (!CreditsMenuScene.smethod_28(CreditsMenuScene.smethod_27(CreditsMenuScene.smethod_26((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)), (Keys)27))
		{
			goto IL_0014;
		}
		goto IL_0041;
		IL_0041:
		int num = -1895899436;
		goto IL_0046;
		IL_0046:
		switch ((uint)(num ^ -537531971) % 4u)
		{
		case 0u:
			break;
		case 2u:
			goto IL_0041;
		default:
			return;
		case 1u:
			CreditsMenuScene.smethod_30(CreditsMenuScene.smethod_26((_7UlnfykmEmZDFt3BmCKZekI43Ih)this), CreditsMenuScene.smethod_29((MemberInfo)_t76cjDKppsRdw5nUq3tnNw3ypAv));
			return;
		case 3u:
			return;
		}
		goto IL_0014;
		IL_0014:
		_lmBaEmzKj1Yvgl07XZnnBeMGYov = ((!CreditsMenuScene.smethod_31(CreditsMenuScene.smethod_27(CreditsMenuScene.smethod_26((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)), (Keys)32)) ? 100f : 300f);
		this.method_0(gameTime_0);
		num = -65782226;
		goto IL_0046;
	}

	static Type smethod_14(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	static _uqydQVaCmCvK7zzWs5W4gZFpKBu smethod_15(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0, string string_0, string string_1, int int_0, int int_1)
	{
		return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._0O8D0mBgmrh0sLOGcLVvGNOHKLCA(string_0, string_1, int_0, int_1);
	}

	static _uqydQVaCmCvK7zzWs5W4gZFpKBu smethod_16(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0, string string_0, string string_1, int int_0, int int_1)
	{
		return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._NC5VT77x8y2iH2pW56TBN1eyomA(string_0, string_1, int_0, int_1);
	}

	static ContentManager smethod_17(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		return _JbeCmOie0phb2cbgG6DdGZrbs3pB_0._uwNDZuqdFb9tyQtlQMxiz1DQ7x8;
	}

	static Vector2 smethod_18(SpriteFont spriteFont_0, string string_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return spriteFont_0.MeasureString(string_0);
	}

	static TimeSpan smethod_19(GameTime gameTime_0)
	{
		return gameTime_0.get_ElapsedGameTime();
	}

	static void smethod_20(SpriteBatch spriteBatch_0, SpriteSortMode spriteSortMode_0, BlendState blendState_0, SamplerState samplerState_0, DepthStencilState depthStencilState_0, RasterizerState rasterizerState_0, Effect effect_0, Matrix? nullable_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		spriteBatch_0._g9Sx54kMPiHz5jrqWh4Kb1pTijH(spriteSortMode_0, blendState_0, samplerState_0, depthStencilState_0, rasterizerState_0, effect_0, nullable_0);
	}

	static bool smethod_21(string string_0)
	{
		return string.IsNullOrWhiteSpace(string_0);
	}

	static bool smethod_22(string string_0, string string_1)
	{
		return string_0.StartsWith(string_1);
	}

	static string smethod_23(string string_0, int int_0)
	{
		return string_0.Substring(int_0);
	}

	static void smethod_24(SpriteBatch spriteBatch_0, SpriteFont spriteFont_0, string string_0, Vector2 vector2_0, Color color_0)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		spriteBatch_0._FY70IFLoBond3ORPe0ndCLvIeVcA(spriteFont_0, string_0, vector2_0, color_0);
	}

	static void smethod_25(SpriteBatch spriteBatch_0)
	{
		spriteBatch_0.End();
	}

	static _JbeCmOie0phb2cbgG6DdGZrbs3pB smethod_26(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0)
	{
		return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._ZzBuoSDMWwerejOO9Goyv2OCKgE;
	}

	static _3FFZvGWTAe7rsviKkDPTXEVjxWf smethod_27(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		return _JbeCmOie0phb2cbgG6DdGZrbs3pB_0._RbWJ7YGnYHCSoD44MRW1h5X6E7E;
	}

	static bool smethod_28(_3FFZvGWTAe7rsviKkDPTXEVjxWf _3FFZvGWTAe7rsviKkDPTXEVjxWf_0, Keys keys_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return _3FFZvGWTAe7rsviKkDPTXEVjxWf_0._fy5ebLnmRsRXv9v7RKTFU5CGMaH(keys_0);
	}

	static string smethod_29(MemberInfo memberInfo_0)
	{
		return memberInfo_0.Name;
	}

	static void smethod_30(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0, string string_0)
	{
		_JbeCmOie0phb2cbgG6DdGZrbs3pB_0._k9wUPeU1Ga7cygiuGP8TT6aPLWF(string_0);
	}

	static bool smethod_31(_3FFZvGWTAe7rsviKkDPTXEVjxWf _3FFZvGWTAe7rsviKkDPTXEVjxWf_0, Keys keys_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return _3FFZvGWTAe7rsviKkDPTXEVjxWf_0._WZ4xYI5Q3hoCNX9QFzE3jfDwZBJ(keys_0);
	}

	void method_0(GameTime gameTime_0)
	{
		base._tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime_0);
	}
}
