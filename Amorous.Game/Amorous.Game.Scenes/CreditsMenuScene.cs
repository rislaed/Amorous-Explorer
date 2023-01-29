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
		: base(game)
	{
		CreditsMenuScene self = this;
		base.Blending = BlendState.AlphaBlend;
		_t76cjDKppsRdw5nUq3tnNw3ypAv = typeof(MainMenuScene);
		_ICAb9QUE8hnbl0uKD8fBpEB1kSV = "Press Escape or Left-click here to return to the Main Menu.";
		AddSpriteLayer("Background", "Assets/Scenes/CreditsMenu/Background", 0, 0);
		AddForegroundSpriteLayer("Overlay", "Assets/Scenes/CreditsMenu/Overlay", 0, 0);
		_nQK443boDHTZ4Jfc3W1VhQkMCcX = Game.Content.Load<SpriteFont>("Assets/GUI/Fonts/Bold-26");
		_tYZIsh9jywDMNNUVaAxLdrUBPIS = Game.Content.Load<SpriteFont>("Assets/GUI/Fonts/Bold-20");
		_6YCQhlMaqcDds8uGX1g8fjBKqV4A = Game.Content.Load<SpriteFont>("Assets/GUI/Fonts/Bold-14");
		_2MfIKVtD2AO6rfNH8r9gBa9ABgc = _nQK443boDHTZ4Jfc3W1VhQkMCcX.MeasureString("Test").Y;
		_lHXUPUciX33biAqfQQ8Yx79nzNB = _tYZIsh9jywDMNNUVaAxLdrUBPIS.MeasureString("Test").Y;
		_3STGOMMEQo4zHKNnz9z7ftUA5Df = _6YCQhlMaqcDds8uGX1g8fjBKqV4A.MeasureString("Test").Y;
		Vector2 _AjA452JzkbwnCTtbITN5kOEaNrR = new Vector2(50f, 1080f - _2MfIKVtD2AO6rfNH8r9gBa9ABgc - 40f);
		FadingMediaPlayer.PlayOnRepeat(AmorousData.HappyJazzShitTrack, 0.4f);
		_Otv0Xepue9AcysEmioBbEWTisDaA = Compressions.ReadStreamAsText(Path.Combine(Game.Content.RootDirectory, "Data/credits.txt")).Replace("\r", string.Empty).Split(new char[1] { '\n' });
		DrawableLayer gparam_ = new DrawableLayer(this, "Credits")
		{
			OnUpdate = _y3e1BQlF0D44DVRCJQTcKxaeNOb,
			OnDraw = _R35LFMCpqnW2Zsm1xJon3qf0UAg
		};
		AddLayer(gparam_, 0);
		bool _vfz3itarR7RfYdT3BqrAmb1qElP = false;
		Vector2 vector = _6YCQhlMaqcDds8uGX1g8fjBKqV4A.MeasureString(_ICAb9QUE8hnbl0uKD8fBpEB1kSV);
		Point _LWpJMkbSZ0LnBJGJqKcICxgdLwq = base.Game.Canvas.RelativeToContent(new Point((int)vector.X, (int)vector.Y));
		AddLayer(new DrawableLayer(this, "GoBackText")
		{
			OnUpdate = delegate
			{
				Point point = self.Game.Canvas.GlobalToContent(self.Game.Controller.Cursor);
				if ((float)point.X >= _AjA452JzkbwnCTtbITN5kOEaNrR.X && (float)point.X <= _AjA452JzkbwnCTtbITN5kOEaNrR.X + (float)_LWpJMkbSZ0LnBJGJqKcICxgdLwq.X && (float)point.Y >= _AjA452JzkbwnCTtbITN5kOEaNrR.Y && (float)point.Y <= _AjA452JzkbwnCTtbITN5kOEaNrR.Y + (float)_LWpJMkbSZ0LnBJGJqKcICxgdLwq.Y)
				{
					_vfz3itarR7RfYdT3BqrAmb1qElP = true;
					if (self.Game.Controller.IsPressed(ControllerButtonType.LeftButton))
					{
						self.Game.StartScene(self._t76cjDKppsRdw5nUq3tnNw3ypAv.Name);
					}
				}
				else
				{
					_vfz3itarR7RfYdT3BqrAmb1qElP = false;
				}
			},
			OnDraw = delegate(SpriteBatch spriteBatch)
			{
				spriteBatch.Begin();
				spriteBatch.DrawString(self._nQK443boDHTZ4Jfc3W1VhQkMCcX, self._ICAb9QUE8hnbl0uKD8fBpEB1kSV, _AjA452JzkbwnCTtbITN5kOEaNrR, _vfz3itarR7RfYdT3BqrAmb1qElP ? Color.Red : Color.White);
				spriteBatch.End();
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
		if (!Censorship.Censored)
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
		AnimatedLayer kxm3yIqio0baXT5t5vOHBAEdviB = AddForegroundAnimatedLayer("Skye", int_, int_2, 16, list.ToArray());
		kxm3yIqio0baXT5t5vOHBAEdviB.Scale = fO7gSlrDDNMoHR4FO5QXAq8fUyA;
		_D1Fi4WCGaRckYZ4B9s6CN7FyrsS = 960f;
		_lmBaEmzKj1Yvgl07XZnnBeMGYov = 100f;
	}

	public void _y3e1BQlF0D44DVRCJQTcKxaeNOb(GameTime gameTime)
	{
		_5tVHyet2nKslcI2f5Yppk4hAIDA = Matrix.CreateTranslation(100f, _D1Fi4WCGaRckYZ4B9s6CN7FyrsS, 0f);
		if (_D1Fi4WCGaRckYZ4B9s6CN7FyrsS > _34TN98j3wyO7VbJ4niAsNCCgFuD)
		{
			_D1Fi4WCGaRckYZ4B9s6CN7FyrsS -= (float)gameTime.ElapsedGameTime.Milliseconds / 1000f * _lmBaEmzKj1Yvgl07XZnnBeMGYov;
		}
		else
		{
			_D1Fi4WCGaRckYZ4B9s6CN7FyrsS = 960f;
		}
	}

	public void _R35LFMCpqnW2Zsm1xJon3qf0UAg(SpriteBatch spriteBatch)
	{
		Vector2 zero = Vector2.Zero;
		float num = 10f;
		float num2 = 0f;
		spriteBatch.Begin(SpriteSortMode.Deferred, null, null, null, null, null, _5tVHyet2nKslcI2f5Yppk4hAIDA);
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
					spriteBatch.DrawString(_nQK443boDHTZ4Jfc3W1VhQkMCcX, text.Substring(1), zero, Color.SkyBlue);
					num2 += _2MfIKVtD2AO6rfNH8r9gBa9ABgc + num;
				}
				else
				{
					spriteBatch.DrawString(_6YCQhlMaqcDds8uGX1g8fjBKqV4A, text, zero, Color.White);
					num2 += _3STGOMMEQo4zHKNnz9z7ftUA5Df + num;
				}
			}
			else
			{
				spriteBatch.DrawString(_tYZIsh9jywDMNNUVaAxLdrUBPIS, text.Substring(2), zero, Color.Pink);
				num2 += _lHXUPUciX33biAqfQQ8Yx79nzNB + num;
			}
			zero.Y = num2;
		}
		_34TN98j3wyO7VbJ4niAsNCCgFuD = 0f - num2;
		spriteBatch.End();
	}

	public override void Update(GameTime gameTime)
	{
		if (!base.Game.Controller.IsPressed(Keys.Escape))
		{
			_lmBaEmzKj1Yvgl07XZnnBeMGYov = ((!base.Game.Controller.IsHolding(Keys.Space)) ? 100f : 300f);
			base.Update(gameTime);
		}
		else
		{
			base.Game.StartScene(_t76cjDKppsRdw5nUq3tnNw3ypAv.Name);
		}
	}
}
