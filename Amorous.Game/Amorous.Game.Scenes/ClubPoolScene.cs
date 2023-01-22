using System;
using System.Collections.Generic;
using System.Linq;
using Amorous.Game.NPC;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Amorous.Game.Scenes;

public class ClubPoolScene : _7UlnfykmEmZDFt3BmCKZekI43Ih
{
	private class FrameAnimationLayer : _fAUddQEKfZyemRb327NhM3GGlmzA
	{
		private readonly Texture2D _animationTexture;

		private Rectangle _destinationRectangle;

		private Rectangle _sourceRectangle;

		private readonly Vector2 _origin;

		private readonly float _timePerFrame;

		private readonly int _numberOfFrames;

		private int _currentFrame;

		private float _angle;

		private float _time;

		public FrameAnimationLayer(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0, string string_0, float float_0, int int_0, int int_1, int int_2, float float_1)
			: base(_7UlnfykmEmZDFt3BmCKZekI43Ih_0, "FrameAnimationLayer")
		{
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Unknown result type (might be due to invalid IL or missing references)
			//IL_008e: Unknown result type (might be due to invalid IL or missing references)
			//IL_009a: Unknown result type (might be due to invalid IL or missing references)
			//IL_009f: Unknown result type (might be due to invalid IL or missing references)
			_animationTexture = FrameAnimationLayer.smethod_1(FrameAnimationLayer.smethod_0(_7UlnfykmEmZDFt3BmCKZekI43Ih_0)).Load<Texture2D>(string_0);
			_timePerFrame = float_0 / (float)int_0;
			_numberOfFrames = int_0;
			_currentFrame = 0;
			_sourceRectangle = new Rectangle(0, 0, (int)((float)FrameAnimationLayer.smethod_2(_animationTexture) / (float)int_0), FrameAnimationLayer.smethod_3(_animationTexture));
			_destinationRectangle = new Rectangle(0, 0, (int)((float)_sourceRectangle.Width * float_1), (int)((float)_sourceRectangle.Height * float_1));
			_origin = new Vector2((float)int_1, (float)int_2);
			base._NC5P3SKqKPpcAYG1mqquUEcUzTg = delegate(GameTime time)
			{
				MyUpdate((float)FrameAnimationLayer.smethod_9(time).Milliseconds / 1000f);
			};
			base._B6VrMlmWofCGqEzjzgFJiAliCge = MyDraw;
		}

		public void Play(int x, int y, int startFrame, float angle)
		{
			_destinationRectangle.X = x;
			_destinationRectangle.Y = y;
			_currentFrame = startFrame;
			_angle = FrameAnimationLayer.smethod_4(angle);
		}

		private void MyUpdate(float deltaTime)
		{
			if (_currentFrame >= 0)
			{
				_time += deltaTime;
				while (_time > _timePerFrame)
				{
					_time -= _timePerFrame;
					_currentFrame++;
				}
				if (_currentFrame < _numberOfFrames)
				{
					_sourceRectangle.X = _currentFrame * _sourceRectangle.Width;
				}
				else
				{
					_currentFrame = 0;
				}
			}
		}

		private void MyDraw(SpriteBatch spriteBatch)
		{
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			if (_currentFrame >= 0)
			{
				FrameAnimationLayer.smethod_6(spriteBatch, (SpriteSortMode)0, (BlendState)null, (SamplerState)null, (DepthStencilState)null, (RasterizerState)null, (Effect)null, (Matrix?)FrameAnimationLayer.smethod_5((_fAUddQEKfZyemRb327NhM3GGlmzA)this));
				FrameAnimationLayer.smethod_7(spriteBatch, _animationTexture, _destinationRectangle, (Rectangle?)_sourceRectangle, Color.get_White(), _angle, _origin, (SpriteEffects)0, 0f);
				FrameAnimationLayer.smethod_8(spriteBatch);
			}
		}

		static _JbeCmOie0phb2cbgG6DdGZrbs3pB smethod_0(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0)
		{
			return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._ZzBuoSDMWwerejOO9Goyv2OCKgE;
		}

		static ContentManager smethod_1(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		{
			return _JbeCmOie0phb2cbgG6DdGZrbs3pB_0._uwNDZuqdFb9tyQtlQMxiz1DQ7x8;
		}

		static int smethod_2(Texture2D texture2D_0)
		{
			return texture2D_0.get_Width();
		}

		static int smethod_3(Texture2D texture2D_0)
		{
			return texture2D_0.get_Height();
		}

		static float smethod_4(float float_0)
		{
			return MathHelper.ToRadians(float_0);
		}

		static Matrix smethod_5(_fAUddQEKfZyemRb327NhM3GGlmzA _fAUddQEKfZyemRb327NhM3GGlmzA_0)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return _fAUddQEKfZyemRb327NhM3GGlmzA_0._3TrGrUra7cqeIXkbZOrfaoQaD5F;
		}

		static void smethod_6(SpriteBatch spriteBatch_0, SpriteSortMode spriteSortMode_0, BlendState blendState_0, SamplerState samplerState_0, DepthStencilState depthStencilState_0, RasterizerState rasterizerState_0, Effect effect_0, Matrix? nullable_0)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			spriteBatch_0._g9Sx54kMPiHz5jrqWh4Kb1pTijH(spriteSortMode_0, blendState_0, samplerState_0, depthStencilState_0, rasterizerState_0, effect_0, nullable_0);
		}

		static void smethod_7(SpriteBatch spriteBatch_0, Texture2D texture2D_0, Rectangle rectangle_0, Rectangle? nullable_0, Color color_0, float float_0, Vector2 vector2_0, SpriteEffects spriteEffects_0, float float_1)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0004: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			spriteBatch_0.Draw(texture2D_0, rectangle_0, nullable_0, color_0, float_0, vector2_0, spriteEffects_0, float_1);
		}

		static void smethod_8(SpriteBatch spriteBatch_0)
		{
			spriteBatch_0.End();
		}

		static TimeSpan smethod_9(GameTime gameTime_0)
		{
			return gameTime_0.get_ElapsedGameTime();
		}
	}

	private ClubStaticRemyNPC _remy;

	private readonly bool _showRemy;

	public ClubPoolScene(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		ClubPoolScene.smethod_14((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Background", "Assets/Scenes/ClubPool/Club Pool main", -1677, 0);
		ClubPoolScene.smethod_15((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Door", "Assets/Scenes/ClubPool/Pool door selectable", -691, 0, (Action)OnDoorClick);
		_lnXs1JfCeIBNCpFYs8XVRorc0h4 lnXs1JfCeIBNCpFYs8XVRorc0h = new _lnXs1JfCeIBNCpFYs8XVRorc0h4(this);
		ClubPoolScene.smethod_16((_WBXNT6eIVGk6ZKExRBJ6JxXE6zb)lnXs1JfCeIBNCpFYs8XVRorc0h, 1525f);
		ClubPoolScene.smethod_17((_WBXNT6eIVGk6ZKExRBJ6JxXE6zb)lnXs1JfCeIBNCpFYs8XVRorc0h, 890f);
		_lnXs1JfCeIBNCpFYs8XVRorc0h4 gparam_ = lnXs1JfCeIBNCpFYs8XVRorc0h;
		_7oYtfGpL7UyAQrZxew7Ahbvj6Sv(gparam_, 2);
		FrameAnimationLayer frameAnimationLayer = new FrameAnimationLayer(this, "Assets/Scenes/ClubPool/ShowerParticle", 0.5f, 5, 200, 30, 1.5f);
		frameAnimationLayer.Play(-1420, 200, 0, 10f);
		FrameAnimationLayer frameAnimationLayer2 = new FrameAnimationLayer(this, "Assets/Scenes/ClubPool/ShowerParticle", 0.5f, 5, 200, 30, 1.5f);
		frameAnimationLayer2.Play(-1170, 200, 2, 10f);
		_7oYtfGpL7UyAQrZxew7Ahbvj6Sv(frameAnimationLayer, 2);
		_7oYtfGpL7UyAQrZxew7Ahbvj6Sv(frameAnimationLayer2, 2);
		ClubPoolScene.smethod_18((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Foreground", "Assets/Scenes/ClubPool/Club Pool top", -1677, 0);
		ClubPoolScene.smethod_18((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Foreground", "Assets/Scenes/ClubPool/Club Pool railing", 2041, 351);
		ClubPoolScene.smethod_20(ClubPoolScene.smethod_19(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0), -1677, 1677, 0, 0);
		ClubPoolScene.smethod_21(_KZ7hNP1K5E99Xfup1lTZ9UDrxPE._oCy13KHJxLHriH7TwMiQ1qKJ8Uc, 0.4f, bool_0: true, bool_1: true);
		_opIJo2jLUqdOL5yAFP4yzXce0DG opIJo2jLUqdOL5yAFP4yzXce0DG_ = ClubPoolScene.smethod_22();
		_showRemy = !ClubPoolScene.smethod_23(opIJo2jLUqdOL5yAFP4yzXce0DG_, "RemyLeftClub");
		if (_showRemy)
		{
			ClubPoolScene.smethod_14((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Shadow", "Assets/Scenes/ClubPool/ShadowRemy", 995, 517);
		}
	}

	public override void Start()
	{
		this.method_0();
		ClubPoolStaticANPC qGGOTxZ8aNWGh0hc26wcmx8wmwT_ = ClubPoolScene.smethod_24((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubPoolStaticANPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Background);
		ClubPoolScene.smethod_25((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)qGGOTxZ8aNWGh0hc26wcmx8wmwT_, -1400f);
		ClubPoolScene.smethod_26((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)qGGOTxZ8aNWGh0hc26wcmx8wmwT_, 910f);
		ClubPoolStaticBNPC qGGOTxZ8aNWGh0hc26wcmx8wmwT_2 = ClubPoolScene.smethod_24((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubPoolStaticBNPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Background);
		ClubPoolScene.smethod_25((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)qGGOTxZ8aNWGh0hc26wcmx8wmwT_2, -1401f);
		ClubPoolScene.smethod_26((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)qGGOTxZ8aNWGh0hc26wcmx8wmwT_2, 230f);
		ClubPoolStaticENPC qGGOTxZ8aNWGh0hc26wcmx8wmwT_3 = ClubPoolScene.smethod_24((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubPoolStaticENPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Background);
		ClubPoolScene.smethod_25((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)qGGOTxZ8aNWGh0hc26wcmx8wmwT_3, 106f);
		ClubPoolScene.smethod_26((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)qGGOTxZ8aNWGh0hc26wcmx8wmwT_3, 397f);
		ClubPoolStaticCNPC clubPoolStaticCNPC = ClubPoolScene.smethod_24((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubPoolStaticCNPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Foreground);
		ClubPoolScene.smethod_25((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubPoolStaticCNPC, -180f);
		ClubPoolScene.smethod_26((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubPoolStaticCNPC, 450f);
		ClubPoolStaticCNPC2 clubPoolStaticCNPC2 = ClubPoolScene.smethod_24((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubPoolStaticCNPC2>(_a2qVgWDIm3fBp49WubttSTPsx8K.Background);
		clubPoolStaticCNPC2._qFVIvzuvIuKKG5vOrovLtn4NplA = clubPoolStaticCNPC._qFVIvzuvIuKKG5vOrovLtn4NplA;
		ClubPoolScene.smethod_25((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubPoolStaticCNPC2, ClubPoolScene.smethod_27((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubPoolStaticCNPC));
		ClubPoolScene.smethod_26((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubPoolStaticCNPC2, ClubPoolScene.smethod_28((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubPoolStaticCNPC));
		ClubPoolStaticFNPC qGGOTxZ8aNWGh0hc26wcmx8wmwT_4 = ClubPoolScene.smethod_24((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubPoolStaticFNPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Foreground);
		ClubPoolScene.smethod_25((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)qGGOTxZ8aNWGh0hc26wcmx8wmwT_4, 500f);
		ClubPoolScene.smethod_26((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)qGGOTxZ8aNWGh0hc26wcmx8wmwT_4, 180f);
		ClubPoolStaticGHINPC clubPoolStaticGHINPC = ClubPoolScene.smethod_24((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubPoolStaticGHINPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Foreground);
		ClubPoolScene.smethod_25((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubPoolStaticGHINPC, 370f);
		ClubPoolScene.smethod_26((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubPoolStaticGHINPC, 450f);
		ClubPoolStaticGHINPC2 clubPoolStaticGHINPC2 = ClubPoolScene.smethod_24((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubPoolStaticGHINPC2>(_a2qVgWDIm3fBp49WubttSTPsx8K.Background);
		clubPoolStaticGHINPC2._qFVIvzuvIuKKG5vOrovLtn4NplA = clubPoolStaticGHINPC._qFVIvzuvIuKKG5vOrovLtn4NplA;
		ClubPoolScene.smethod_25((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubPoolStaticGHINPC2, ClubPoolScene.smethod_27((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubPoolStaticGHINPC));
		ClubPoolScene.smethod_26((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubPoolStaticGHINPC2, ClubPoolScene.smethod_28((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubPoolStaticGHINPC));
		ClubPoolStaticDNPC clubPoolStaticDNPC = ClubPoolScene.smethod_24((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubPoolStaticDNPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Foreground);
		ClubPoolScene.smethod_25((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubPoolStaticDNPC, 50f);
		ClubPoolScene.smethod_26((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubPoolStaticDNPC, 690f);
		ClubPoolStaticDNPC2 clubPoolStaticDNPC2 = ClubPoolScene.smethod_24((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubPoolStaticDNPC2>(_a2qVgWDIm3fBp49WubttSTPsx8K.Background);
		clubPoolStaticDNPC2._qFVIvzuvIuKKG5vOrovLtn4NplA = clubPoolStaticDNPC._qFVIvzuvIuKKG5vOrovLtn4NplA;
		ClubPoolScene.smethod_25((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubPoolStaticDNPC2, ClubPoolScene.smethod_27((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubPoolStaticDNPC));
		ClubPoolScene.smethod_26((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubPoolStaticDNPC2, ClubPoolScene.smethod_28((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubPoolStaticDNPC));
		if (_showRemy)
		{
			_remy = ClubPoolScene.smethod_24((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubStaticRemyNPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Foreground);
			ClubPoolScene.smethod_25((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)_remy, 1010f);
			ClubPoolScene.smethod_26((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)_remy, 150f);
			ClubPoolScene.smethod_29((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)_remy, (Action)OnRemyClick);
		}
		ClubPoolStaticJKNPC clubPoolStaticJKNPC = ClubPoolScene.smethod_24((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubPoolStaticJKNPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Foreground);
		ClubPoolScene.smethod_25((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubPoolStaticJKNPC, 1269f);
		ClubPoolScene.smethod_26((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubPoolStaticJKNPC, 383f);
		ClubPoolStaticJKNPC2 clubPoolStaticJKNPC2 = ClubPoolScene.smethod_24((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubPoolStaticJKNPC2>(_a2qVgWDIm3fBp49WubttSTPsx8K.Background);
		clubPoolStaticJKNPC2._qFVIvzuvIuKKG5vOrovLtn4NplA = clubPoolStaticJKNPC._qFVIvzuvIuKKG5vOrovLtn4NplA;
		ClubPoolScene.smethod_25((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubPoolStaticJKNPC2, ClubPoolScene.smethod_27((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubPoolStaticJKNPC));
		ClubPoolScene.smethod_26((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubPoolStaticJKNPC2, ClubPoolScene.smethod_28((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubPoolStaticJKNPC));
		ClubPoolStaticLNPC qGGOTxZ8aNWGh0hc26wcmx8wmwT_5 = ClubPoolScene.smethod_24((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubPoolStaticLNPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Background);
		ClubPoolScene.smethod_25((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)qGGOTxZ8aNWGh0hc26wcmx8wmwT_5, 1630f);
		ClubPoolScene.smethod_26((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)qGGOTxZ8aNWGh0hc26wcmx8wmwT_5, 106f);
		ClubPoolStaticMNPC qGGOTxZ8aNWGh0hc26wcmx8wmwT_6 = ClubPoolScene.smethod_24((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubPoolStaticMNPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Background);
		ClubPoolScene.smethod_25((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)qGGOTxZ8aNWGh0hc26wcmx8wmwT_6, 1879f);
		ClubPoolScene.smethod_26((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)qGGOTxZ8aNWGh0hc26wcmx8wmwT_6, 106f);
		ClubPoolStaticNNPC qGGOTxZ8aNWGh0hc26wcmx8wmwT_7 = ClubPoolScene.smethod_24((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubPoolStaticNNPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Background);
		ClubPoolScene.smethod_25((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)qGGOTxZ8aNWGh0hc26wcmx8wmwT_7, 2039f);
		ClubPoolScene.smethod_26((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)qGGOTxZ8aNWGh0hc26wcmx8wmwT_7, 106f);
		ClubPoolStaticOPNPC clubPoolStaticOPNPC = ClubPoolScene.smethod_24((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubPoolStaticOPNPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Foreground);
		ClubPoolScene.smethod_25((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubPoolStaticOPNPC, 2223f);
		ClubPoolScene.smethod_26((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubPoolStaticOPNPC, 442f);
		ClubPoolStaticOPNPC2 clubPoolStaticOPNPC2 = ClubPoolScene.smethod_24((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubPoolStaticOPNPC2>(_a2qVgWDIm3fBp49WubttSTPsx8K.Background);
		clubPoolStaticOPNPC2._qFVIvzuvIuKKG5vOrovLtn4NplA = clubPoolStaticOPNPC._qFVIvzuvIuKKG5vOrovLtn4NplA;
		ClubPoolScene.smethod_25((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubPoolStaticOPNPC2, ClubPoolScene.smethod_27((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubPoolStaticOPNPC));
		ClubPoolScene.smethod_26((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubPoolStaticOPNPC2, ClubPoolScene.smethod_28((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubPoolStaticOPNPC));
		ClubPoolStaticQRNPC qGGOTxZ8aNWGh0hc26wcmx8wmwT_8 = ClubPoolScene.smethod_24((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubPoolStaticQRNPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Foreground);
		ClubPoolScene.smethod_25((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)qGGOTxZ8aNWGh0hc26wcmx8wmwT_8, 2694f);
		ClubPoolScene.smethod_26((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)qGGOTxZ8aNWGh0hc26wcmx8wmwT_8, 97f);
	}

	public override void Update(GameTime gameTime)
	{
		if (_Bj3jScuqBJCFV58AWBDg8HofpqY)
		{
			List<_ujAkjlfN5TywwbLAUDzPvtab6uJ> list = (from x in ClubPoolScene.smethod_30((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)
				where x is _3IHp43rpkJgOBcY9lrIrwMuwWve _3IHp43rpkJgOBcY9lrIrwMuwWve && (!(_3IHp43rpkJgOBcY9lrIrwMuwWve._4QLHHCk23T1BjK7acKxASbkCefG is ClubStaticNPC) || !(_3IHp43rpkJgOBcY9lrIrwMuwWve._4QLHHCk23T1BjK7acKxASbkCefG is ClubStaticSpineNPC))
				select x).ToList();
			list.ForEach(delegate(_ujAkjlfN5TywwbLAUDzPvtab6uJ x)
			{
				x._ac2H6kMdrgPhXXxabsikjji4SiT = 3;
			});
		}
		this.method_1(gameTime);
	}

	private void OnDoorClick()
	{
		ClubPoolScene.smethod_24((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._k9wUPeU1Ga7cygiuGP8TT6aPLWF<ClubUpstairsScene>();
	}

	private void OnRemyClick()
	{
		ClubPoolScene.smethod_31(ClubPoolScene.smethod_24((_7UlnfykmEmZDFt3BmCKZekI43Ih)this), "RemyPreDate");
	}

	static _uqydQVaCmCvK7zzWs5W4gZFpKBu smethod_14(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0, string string_0, string string_1, int int_0, int int_1)
	{
		return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._0O8D0mBgmrh0sLOGcLVvGNOHKLCA(string_0, string_1, int_0, int_1);
	}

	static _z20t8IpBINiJtljSeTIkNoKUOkx smethod_15(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0, string string_0, string string_1, int int_0, int int_1, Action action_0)
	{
		return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._2CHUZ5vSi5NbJYJ4gGtr3C2VVEo(string_0, string_1, int_0, int_1, action_0);
	}

	static void smethod_16(_WBXNT6eIVGk6ZKExRBJ6JxXE6zb _WBXNT6eIVGk6ZKExRBJ6JxXE6zb_0, float float_0)
	{
		_WBXNT6eIVGk6ZKExRBJ6JxXE6zb_0._WBXNT6eIVGk6ZKExRBJ6JxXE6zb_002E_GDeKFFD8Rxnpsjzy36lUBxAEopc = float_0;
	}

	static void smethod_17(_WBXNT6eIVGk6ZKExRBJ6JxXE6zb _WBXNT6eIVGk6ZKExRBJ6JxXE6zb_0, float float_0)
	{
		_WBXNT6eIVGk6ZKExRBJ6JxXE6zb_0._WBXNT6eIVGk6ZKExRBJ6JxXE6zb_002E_JpSvHH1W0gFCpaNEH5zB1qsDJXY = float_0;
	}

	static _uqydQVaCmCvK7zzWs5W4gZFpKBu smethod_18(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0, string string_0, string string_1, int int_0, int int_1)
	{
		return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._NC5VT77x8y2iH2pW56TBN1eyomA(string_0, string_1, int_0, int_1);
	}

	static _wRd4nHuQQlAPEwrHOGkBfut6Uip smethod_19(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		return _JbeCmOie0phb2cbgG6DdGZrbs3pB_0._vsceSzSIjBy2nZrCxAzKZbUiwLq;
	}

	static void smethod_20(_wRd4nHuQQlAPEwrHOGkBfut6Uip _wRd4nHuQQlAPEwrHOGkBfut6Uip_0, int int_0, int int_1, int int_2, int int_3)
	{
		_wRd4nHuQQlAPEwrHOGkBfut6Uip_0._wFfc7xL7eKxed7i9gWtao7pgsnm(int_0, int_1, int_2, int_3);
	}

	static void smethod_21(string[] string_0, float float_0, bool bool_0, bool bool_1)
	{
		_UmxbIbk7pgaod0bD7pS309P3Lns._QrgbXEg7MMeD9Ybz12fFVsbmAd9(string_0, float_0, bool_0, bool_1);
	}

	static _opIJo2jLUqdOL5yAFP4yzXce0DG smethod_22()
	{
		return _Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t();
	}

	static bool smethod_23(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0, string string_0)
	{
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._Oms9lumBodLGrGZ09YJaEuzmlAf(string_0);
	}

	void method_0()
	{
		base._4hlxzMzKSbVTbZUrEsP3dfw4x0h();
	}

	static _JbeCmOie0phb2cbgG6DdGZrbs3pB smethod_24(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0)
	{
		return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._ZzBuoSDMWwerejOO9Goyv2OCKgE;
	}

	static void smethod_25(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, float float_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_7Xn1C5tjYnmIif1iZKV8AWsEEbL = float_0;
	}

	static void smethod_26(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, float float_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_bCjZ3VSXGKyhmykd2zCnQBiSpDf = float_0;
	}

	static float smethod_27(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0)
	{
		return _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_7Xn1C5tjYnmIif1iZKV8AWsEEbL;
	}

	static float smethod_28(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0)
	{
		return _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._QGGOTxZ8aNWGh0hc26wcmx8wmwT_002E_bCjZ3VSXGKyhmykd2zCnQBiSpDf;
	}

	static void smethod_29(_QGGOTxZ8aNWGh0hc26wcmx8wmwT _QGGOTxZ8aNWGh0hc26wcmx8wmwT_0, Action action_0)
	{
		_QGGOTxZ8aNWGh0hc26wcmx8wmwT_0._ZVpZ5Oing5kbbVhbmbOHyrofGH7 = action_0;
	}

	static List<_ujAkjlfN5TywwbLAUDzPvtab6uJ> smethod_30(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0)
	{
		return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._lstlI8qzZ4KErYKnufdOlj1xVZF;
	}

	void method_1(GameTime gameTime_0)
	{
		base._tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime_0);
	}

	static void smethod_31(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0, string string_0)
	{
		_JbeCmOie0phb2cbgG6DdGZrbs3pB_0._xyl3Tv5KdR5eezDgagxbBcS3cwt(string_0);
	}
}
