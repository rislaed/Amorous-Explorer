using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Amorous.Game.Scenes;

public class CreditsMenuScene : AbstractScene
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

	public CreditsMenuScene(IAmorous game)
		: base(Game)
	{
		CreditsMenuScene _KJWMaoRJ7oaDYXtF5MPjg5DcYwvA = this;
		base._XvcwmP1Eb6HFUF5pkiUVgpqNbWE = BlendState.AlphaBlend;
		_t76cjDKppsRdw5nUq3tnNw3ypAv = typeof(MainMenuScene);
		_ICAb9QUE8hnbl0uKD8fBpEB1kSV = "Press Escape or Left-click here to return to the Main Menu.";
		_0O8D0mBgmrh0sLOGcLVvGNOHKLCA("Background", "Assets/Scenes/CreditsMenu/Background", 0, 0);
		_NC5VT77x8y2iH2pW56TBN1eyomA("Overlay", "Assets/Scenes/CreditsMenu/Overlay", 0, 0);
		_nQK443boDHTZ4Jfc3W1VhQkMCcX = Game._uwNDZuqdFb9tyQtlQMxiz1DQ7x8.Load<SpriteFont>("Assets/GUI/Fonts/Bold-26");
		_tYZIsh9jywDMNNUVaAxLdrUBPIS = Game._uwNDZuqdFb9tyQtlQMxiz1DQ7x8.Load<SpriteFont>("Assets/GUI/Fonts/Bold-20");
		_6YCQhlMaqcDds8uGX1g8fjBKqV4A = Game._uwNDZuqdFb9tyQtlQMxiz1DQ7x8.Load<SpriteFont>("Assets/GUI/Fonts/Bold-14");
		_2MfIKVtD2AO6rfNH8r9gBa9ABgc = _nQK443boDHTZ4Jfc3W1VhQkMCcX.MeasureString("Test").Y;
		_lHXUPUciX33biAqfQQ8Yx79nzNB = _tYZIsh9jywDMNNUVaAxLdrUBPIS.MeasureString("Test").Y;
		_3STGOMMEQo4zHKNnz9z7ftUA5Df = _6YCQhlMaqcDds8uGX1g8fjBKqV4A.MeasureString("Test").Y;
		Vector2 _AjA452JzkbwnCTtbITN5kOEaNrR = new Vector2(50f, 1080f - _2MfIKVtD2AO6rfNH8r9gBa9ABgc - 40f);
		_UmxbIbk7pgaod0bD7pS309P3Lns._l94kUraQ13OohoVwwxKC37hG7Pc("Assets/Music/Father-of-Death - Happy Jazz Shit", 0.4f);
		_Otv0Xepue9AcysEmioBbEWTisDaA = _K2047A8SCJdaw0LZKStEHOiH110._GxOfTBefEUfWKWaWgxVRKsjugxE(Path.Combine(Game._uwNDZuqdFb9tyQtlQMxiz1DQ7x8.RootDirectory, "Data/credits.txt")).Replace("\r", string.Empty).Split(new char[1] { '\n' });
		_fAUddQEKfZyemRb327NhM3GGlmzA gparam_ = new _fAUddQEKfZyemRb327NhM3GGlmzA(this, "Credits")
		{
			_NC5P3SKqKPpcAYG1mqquUEcUzTg = _y3e1BQlF0D44DVRCJQTcKxaeNOb,
			_B6VrMlmWofCGqEzjzgFJiAliCge = _R35LFMCpqnW2Zsm1xJon3qf0UAg
		};
		_7oYtfGpL7UyAQrZxew7Ahbvj6Sv(gparam_, 0);
		bool _vfz3itarR7RfYdT3BqrAmb1qElP = false;
		Vector2 vector = _6YCQhlMaqcDds8uGX1g8fjBKqV4A.MeasureString(_ICAb9QUE8hnbl0uKD8fBpEB1kSV);
		Point _LWpJMkbSZ0LnBJGJqKcICxgdLwq = base.Game._vsceSzSIjBy2nZrCxAzKZbUiwLq._2j5HjqIBNOwD2br7yBprKdzVhAK(new Point((int)vector.X, (int)vector.Y));
		_7oYtfGpL7UyAQrZxew7Ahbvj6Sv(new _fAUddQEKfZyemRb327NhM3GGlmzA(this, "GoBackText")
		{
			_NC5P3SKqKPpcAYG1mqquUEcUzTg = delegate
			{
				Point point = _KJWMaoRJ7oaDYXtF5MPjg5DcYwvA.Game._vsceSzSIjBy2nZrCxAzKZbUiwLq._u7uCdK9i8FnWhiaPn2bO2wIgUUuA(_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA.Game._RbWJ7YGnYHCSoD44MRW1h5X6E7E._U7CeYBJ1v1SoUxpX8emsQ9mWl5b);
				if ((float)point.X >= _AjA452JzkbwnCTtbITN5kOEaNrR.X && (float)point.X <= _AjA452JzkbwnCTtbITN5kOEaNrR.X + (float)_LWpJMkbSZ0LnBJGJqKcICxgdLwq.X && (float)point.Y >= _AjA452JzkbwnCTtbITN5kOEaNrR.Y && (float)point.Y <= _AjA452JzkbwnCTtbITN5kOEaNrR.Y + (float)_LWpJMkbSZ0LnBJGJqKcICxgdLwq.Y)
				{
					_vfz3itarR7RfYdT3BqrAmb1qElP = true;
					if (_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA.Game._RbWJ7YGnYHCSoD44MRW1h5X6E7E._fy5ebLnmRsRXv9v7RKTFU5CGMaH(_PMeRYZJaBCqgB9uADJFP3c14lxq.LeftButton))
					{
						_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA.Game.StartScene(_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._t76cjDKppsRdw5nUq3tnNw3ypAv.Name);
					}
				}
				else
				{
					_vfz3itarR7RfYdT3BqrAmb1qElP = false;
				}
			},
			_B6VrMlmWofCGqEzjzgFJiAliCge = delegate(SpriteBatch spriteBatch_0)
			{
				spriteBatch_0.Begin();
				spriteBatch_0.DrawString(_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._nQK443boDHTZ4Jfc3W1VhQkMCcX, _KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._ICAb9QUE8hnbl0uKD8fBpEB1kSV, _AjA452JzkbwnCTtbITN5kOEaNrR, _vfz3itarR7RfYdT3BqrAmb1qElP ? Color.Red : Color.White);
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
		_5tVHyet2nKslcI2f5Yppk4hAIDA = Matrix.CreateTranslation(100f, _D1Fi4WCGaRckYZ4B9s6CN7FyrsS, 0f);
		if (_D1Fi4WCGaRckYZ4B9s6CN7FyrsS > _34TN98j3wyO7VbJ4niAsNCCgFuD)
		{
			_D1Fi4WCGaRckYZ4B9s6CN7FyrsS -= (float)gameTime_0.ElapsedGameTime.Milliseconds / 1000f * _lmBaEmzKj1Yvgl07XZnnBeMGYov;
		}
		else
		{
			_D1Fi4WCGaRckYZ4B9s6CN7FyrsS = 960f;
		}
	}

	public void _R35LFMCpqnW2Zsm1xJon3qf0UAg(SpriteBatch spriteBatch_0)
	{
		Vector2 zero = Vector2.Zero;
		float num = 10f;
		float num2 = 0f;
		spriteBatch_0.Begin(SpriteSortMode.Deferred, null, null, null, null, null, _5tVHyet2nKslcI2f5Yppk4hAIDA);
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
					spriteBatch_0.DrawString(_nQK443boDHTZ4Jfc3W1VhQkMCcX, text.Substring(1), zero, Color.SkyBlue);
					num2 += _2MfIKVtD2AO6rfNH8r9gBa9ABgc + num;
				}
				else
				{
					spriteBatch_0.DrawString(_6YCQhlMaqcDds8uGX1g8fjBKqV4A, text, zero, Color.White);
					num2 += _3STGOMMEQo4zHKNnz9z7ftUA5Df + num;
				}
			}
			else
			{
				spriteBatch_0.DrawString(_tYZIsh9jywDMNNUVaAxLdrUBPIS, text.Substring(2), zero, Color.Pink);
				num2 += _lHXUPUciX33biAqfQQ8Yx79nzNB + num;
			}
			zero.Y = num2;
		}
		_34TN98j3wyO7VbJ4niAsNCCgFuD = 0f - num2;
		spriteBatch_0.End();
	}

	public override void Update(GameTime gameTime_0)
	{
		if (!base.Game._RbWJ7YGnYHCSoD44MRW1h5X6E7E._fy5ebLnmRsRXv9v7RKTFU5CGMaH(Keys.Escape))
		{
			_lmBaEmzKj1Yvgl07XZnnBeMGYov = ((!base.Game._RbWJ7YGnYHCSoD44MRW1h5X6E7E._WZ4xYI5Q3hoCNX9QFzE3jfDwZBJ(Keys.Space)) ? 100f : 300f);
			base.Update(gameTime_0);
		}
		else
		{
			base.Game.StartScene(_t76cjDKppsRdw5nUq3tnNw3ypAv.Name);
		}
	}
}
