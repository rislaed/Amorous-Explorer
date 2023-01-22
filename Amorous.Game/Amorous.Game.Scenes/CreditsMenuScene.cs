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
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		CreditsMenuScene _KJWMaoRJ7oaDYXtF5MPjg5DcYwvA = this;
		base._XvcwmP1Eb6HFUF5pkiUVgpqNbWE = BlendState.AlphaBlend;
		_t76cjDKppsRdw5nUq3tnNw3ypAv = typeof(MainMenuScene);
		_ICAb9QUE8hnbl0uKD8fBpEB1kSV = "Press Escape or Left-click here to return to the Main Menu.";
		_0O8D0mBgmrh0sLOGcLVvGNOHKLCA("Background", "Assets/Scenes/CreditsMenu/Background", 0, 0);
		_NC5VT77x8y2iH2pW56TBN1eyomA("Overlay", "Assets/Scenes/CreditsMenu/Overlay", 0, 0);
		_nQK443boDHTZ4Jfc3W1VhQkMCcX = _JbeCmOie0phb2cbgG6DdGZrbs3pB_0._uwNDZuqdFb9tyQtlQMxiz1DQ7x8.Load<SpriteFont>("Assets/GUI/Fonts/Bold-26");
		_tYZIsh9jywDMNNUVaAxLdrUBPIS = _JbeCmOie0phb2cbgG6DdGZrbs3pB_0._uwNDZuqdFb9tyQtlQMxiz1DQ7x8.Load<SpriteFont>("Assets/GUI/Fonts/Bold-20");
		_6YCQhlMaqcDds8uGX1g8fjBKqV4A = _JbeCmOie0phb2cbgG6DdGZrbs3pB_0._uwNDZuqdFb9tyQtlQMxiz1DQ7x8.Load<SpriteFont>("Assets/GUI/Fonts/Bold-14");
		Vector2 val = _nQK443boDHTZ4Jfc3W1VhQkMCcX.MeasureString("Test");
		_2MfIKVtD2AO6rfNH8r9gBa9ABgc = val.Y;
		val = _tYZIsh9jywDMNNUVaAxLdrUBPIS.MeasureString("Test");
		_lHXUPUciX33biAqfQQ8Yx79nzNB = val.Y;
		val = _6YCQhlMaqcDds8uGX1g8fjBKqV4A.MeasureString("Test");
		_3STGOMMEQo4zHKNnz9z7ftUA5Df = val.Y;
		Vector2 _AjA452JzkbwnCTtbITN5kOEaNrR = new Vector2(50f, 1080f - _2MfIKVtD2AO6rfNH8r9gBa9ABgc - 40f);
		_UmxbIbk7pgaod0bD7pS309P3Lns._l94kUraQ13OohoVwwxKC37hG7Pc("Assets/Music/Father-of-Death - Happy Jazz Shit", 0.4f);
		_Otv0Xepue9AcysEmioBbEWTisDaA = _K2047A8SCJdaw0LZKStEHOiH110._GxOfTBefEUfWKWaWgxVRKsjugxE(Path.Combine(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0._uwNDZuqdFb9tyQtlQMxiz1DQ7x8.get_RootDirectory(), "Data/credits.txt")).Replace("\r", string.Empty).Split(new char[1] { '\n' });
		_fAUddQEKfZyemRb327NhM3GGlmzA gparam_ = new _fAUddQEKfZyemRb327NhM3GGlmzA(this, "Credits")
		{
			_NC5P3SKqKPpcAYG1mqquUEcUzTg = _y3e1BQlF0D44DVRCJQTcKxaeNOb,
			_B6VrMlmWofCGqEzjzgFJiAliCge = _R35LFMCpqnW2Zsm1xJon3qf0UAg
		};
		_7oYtfGpL7UyAQrZxew7Ahbvj6Sv(gparam_, 0);
		bool _vfz3itarR7RfYdT3BqrAmb1qElP = false;
		val = _6YCQhlMaqcDds8uGX1g8fjBKqV4A.MeasureString(_ICAb9QUE8hnbl0uKD8fBpEB1kSV);
		Point _LWpJMkbSZ0LnBJGJqKcICxgdLwq = base._ZzBuoSDMWwerejOO9Goyv2OCKgE._vsceSzSIjBy2nZrCxAzKZbUiwLq._2j5HjqIBNOwD2br7yBprKdzVhAK(new Point((int)val.X, (int)val.Y));
		_7oYtfGpL7UyAQrZxew7Ahbvj6Sv(new _fAUddQEKfZyemRb327NhM3GGlmzA(this, "GoBackText")
		{
			_NC5P3SKqKPpcAYG1mqquUEcUzTg = delegate
			{
				//IL_0020: Unknown result type (might be due to invalid IL or missing references)
				//IL_0025: Unknown result type (might be due to invalid IL or missing references)
				//IL_002a: Unknown result type (might be due to invalid IL or missing references)
				//IL_002b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0042: Unknown result type (might be due to invalid IL or missing references)
				//IL_0063: Unknown result type (might be due to invalid IL or missing references)
				//IL_0077: Unknown result type (might be due to invalid IL or missing references)
				Point val2 = _KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._ZzBuoSDMWwerejOO9Goyv2OCKgE._vsceSzSIjBy2nZrCxAzKZbUiwLq._u7uCdK9i8FnWhiaPn2bO2wIgUUuA(_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._ZzBuoSDMWwerejOO9Goyv2OCKgE._RbWJ7YGnYHCSoD44MRW1h5X6E7E._U7CeYBJ1v1SoUxpX8emsQ9mWl5b);
				if ((float)val2.X >= _AjA452JzkbwnCTtbITN5kOEaNrR.X && (float)val2.X <= _AjA452JzkbwnCTtbITN5kOEaNrR.X + (float)_LWpJMkbSZ0LnBJGJqKcICxgdLwq.X && (float)val2.Y >= _AjA452JzkbwnCTtbITN5kOEaNrR.Y && (float)val2.Y <= _AjA452JzkbwnCTtbITN5kOEaNrR.Y + (float)_LWpJMkbSZ0LnBJGJqKcICxgdLwq.Y)
				{
					_vfz3itarR7RfYdT3BqrAmb1qElP = true;
					if (_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._ZzBuoSDMWwerejOO9Goyv2OCKgE._RbWJ7YGnYHCSoD44MRW1h5X6E7E._fy5ebLnmRsRXv9v7RKTFU5CGMaH(_PMeRYZJaBCqgB9uADJFP3c14lxq.LeftButton))
					{
						_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._ZzBuoSDMWwerejOO9Goyv2OCKgE._k9wUPeU1Ga7cygiuGP8TT6aPLWF(_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._t76cjDKppsRdw5nUq3tnNw3ypAv.Name);
					}
				}
				else
				{
					_vfz3itarR7RfYdT3BqrAmb1qElP = false;
				}
			},
			_B6VrMlmWofCGqEzjzgFJiAliCge = delegate(SpriteBatch spriteBatch_0)
			{
				//IL_001e: Unknown result type (might be due to invalid IL or missing references)
				//IL_002b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0032: Unknown result type (might be due to invalid IL or missing references)
				spriteBatch_0.Begin();
				spriteBatch_0._FY70IFLoBond3ORPe0ndCLvIeVcA(_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._nQK443boDHTZ4Jfc3W1VhQkMCcX, _KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._ICAb9QUE8hnbl0uKD8fBpEB1kSV, _AjA452JzkbwnCTtbITN5kOEaNrR, _vfz3itarR7RfYdT3BqrAmb1qElP ? Color.get_Red() : Color.get_White());
				spriteBatch_0.End();
			}
		}, 2);
		List<string> list = new List<string>();
		for (int i = 1; i < 60; i++)
		{
			list.Add($"Assets/Scenes/CreditsMenu/Skye/TYSkye{i:D2}");
		}
		int int_;
		int int_2;
		float fO7gSlrDDNMoHR4FO5QXAq8fUyA;
		if (!_iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF)
		{
			int_ = 1170;
			int_2 = 105;
			fO7gSlrDDNMoHR4FO5QXAq8fUyA = 1.5f;
		}
		else
		{
			int_ = 1000;
			int_2 = 105;
			fO7gSlrDDNMoHR4FO5QXAq8fUyA = 2f;
		}
		_kxm3yIqio0baXT5t5vOHBAEdviB kxm3yIqio0baXT5t5vOHBAEdviB = _gqeDf50vdgfHqlAbH8UK4sXgtYAA("Skye", int_, int_2, 16, list.ToArray());
		kxm3yIqio0baXT5t5vOHBAEdviB._fO7gSlrDDNMoHR4FO5QXAq8fUyA = fO7gSlrDDNMoHR4FO5QXAq8fUyA;
		_D1Fi4WCGaRckYZ4B9s6CN7FyrsS = 960f;
		_lmBaEmzKj1Yvgl07XZnnBeMGYov = 100f;
	}

	public void _y3e1BQlF0D44DVRCJQTcKxaeNOb(GameTime gameTime_0)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		_5tVHyet2nKslcI2f5Yppk4hAIDA = Matrix.CreateTranslation(100f, _D1Fi4WCGaRckYZ4B9s6CN7FyrsS, 0f);
		if (_D1Fi4WCGaRckYZ4B9s6CN7FyrsS > _34TN98j3wyO7VbJ4niAsNCCgFuD)
		{
			_D1Fi4WCGaRckYZ4B9s6CN7FyrsS -= (float)gameTime_0.get_ElapsedGameTime().Milliseconds / 1000f * _lmBaEmzKj1Yvgl07XZnnBeMGYov;
		}
		else
		{
			_D1Fi4WCGaRckYZ4B9s6CN7FyrsS = 960f;
		}
	}

	public void _R35LFMCpqnW2Zsm1xJon3qf0UAg(SpriteBatch spriteBatch_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		Vector2 zero = Vector2.get_Zero();
		float num = 10f;
		float num2 = 0f;
		spriteBatch_0._g9Sx54kMPiHz5jrqWh4Kb1pTijH((SpriteSortMode)0, null, null, null, null, null, _5tVHyet2nKslcI2f5Yppk4hAIDA);
		string[] otv0Xepue9AcysEmioBbEWTisDaA = _Otv0Xepue9AcysEmioBbEWTisDaA;
		foreach (string text in otv0Xepue9AcysEmioBbEWTisDaA)
		{
			if (string.IsNullOrWhiteSpace(text))
			{
				num2 += num;
			}
			else if (!text.StartsWith("##"))
			{
				if (text.StartsWith("#"))
				{
					spriteBatch_0._FY70IFLoBond3ORPe0ndCLvIeVcA(_nQK443boDHTZ4Jfc3W1VhQkMCcX, text.Substring(1), zero, Color.get_SkyBlue());
					num2 += _2MfIKVtD2AO6rfNH8r9gBa9ABgc + num;
				}
				else
				{
					spriteBatch_0._FY70IFLoBond3ORPe0ndCLvIeVcA(_6YCQhlMaqcDds8uGX1g8fjBKqV4A, text, zero, Color.get_White());
					num2 += _3STGOMMEQo4zHKNnz9z7ftUA5Df + num;
				}
			}
			else
			{
				spriteBatch_0._FY70IFLoBond3ORPe0ndCLvIeVcA(_tYZIsh9jywDMNNUVaAxLdrUBPIS, text.Substring(2), zero, Color.get_Pink());
				num2 += _lHXUPUciX33biAqfQQ8Yx79nzNB + num;
			}
			zero.Y = num2;
		}
		_34TN98j3wyO7VbJ4niAsNCCgFuD = 0f - num2;
		spriteBatch_0.End();
	}

	public override void _tiBFUHPEkedkbgvuX3whdeyjhKo(GameTime gameTime_0)
	{
		if (!base._ZzBuoSDMWwerejOO9Goyv2OCKgE._RbWJ7YGnYHCSoD44MRW1h5X6E7E._fy5ebLnmRsRXv9v7RKTFU5CGMaH((Keys)27))
		{
			_lmBaEmzKj1Yvgl07XZnnBeMGYov = ((!base._ZzBuoSDMWwerejOO9Goyv2OCKgE._RbWJ7YGnYHCSoD44MRW1h5X6E7E._WZ4xYI5Q3hoCNX9QFzE3jfDwZBJ((Keys)32)) ? 100f : 300f);
			base._tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime_0);
		}
		else
		{
			base._ZzBuoSDMWwerejOO9Goyv2OCKgE._k9wUPeU1Ga7cygiuGP8TT6aPLWF(_t76cjDKppsRdw5nUq3tnNw3ypAv.Name);
		}
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
