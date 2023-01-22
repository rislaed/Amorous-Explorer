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
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
			while (true)
			{
				int num = -394294418;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA7528129u) % 6u)
					{
					case 5u:
						base._NC5P3SKqKPpcAYG1mqquUEcUzTg = delegate(GameTime time)
						{
							MyUpdate((float)FrameAnimationLayer.smethod_9(time).Milliseconds / 1000f);
						};
						base._B6VrMlmWofCGqEzjzgFJiAliCge = MyDraw;
						num = ((int)num2 * -966892724) ^ 0x2939BCF7;
						continue;
					case 3u:
						_currentFrame = 0;
						_sourceRectangle = new Rectangle(0, 0, (int)((float)FrameAnimationLayer.smethod_2(_animationTexture) / (float)int_0), FrameAnimationLayer.smethod_3(_animationTexture));
						_destinationRectangle = new Rectangle(0, 0, (int)((float)_sourceRectangle.Width * float_1), (int)((float)_sourceRectangle.Height * float_1));
						_origin = new Vector2((float)int_1, (float)int_2);
						num = ((int)num2 * -188304956) ^ 0x160C2E98;
						continue;
					case 1u:
						_animationTexture = FrameAnimationLayer.smethod_1(FrameAnimationLayer.smethod_0(_7UlnfykmEmZDFt3BmCKZekI43Ih_0)).Load<Texture2D>(string_0);
						_timePerFrame = float_0 / (float)int_0;
						num = (int)((num2 * 897694781) ^ 0xB01D76);
						continue;
					case 0u:
						_numberOfFrames = int_0;
						num = (int)(num2 * 416486307) ^ -1827423376;
						continue;
					default:
						return;
					case 4u:
						break;
					case 2u:
						return;
					}
					break;
				}
			}
		}

		public void Play(int x, int y, int startFrame, float angle)
		{
			_destinationRectangle.X = x;
			_destinationRectangle.Y = y;
			while (true)
			{
				int num = 857711303;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x74A834B0u) % 3u)
					{
					case 1u:
						goto IL_001a;
					case 2u:
						break;
					default:
						_angle = FrameAnimationLayer.smethod_4(angle);
						return;
					}
					break;
					IL_001a:
					_currentFrame = startFrame;
					num = ((int)num2 * -1055463645) ^ 0x11943D3;
				}
			}
		}

		private void MyUpdate(float deltaTime)
		{
			if (_currentFrame < 0)
			{
				goto IL_0084;
			}
			goto IL_0101;
			IL_0101:
			_time += deltaTime;
			int num = 1682114882;
			goto IL_00c7;
			IL_00c7:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6F6CEAB6u) % 10u)
				{
				case 9u:
					_time -= _timePerFrame;
					_currentFrame++;
					num = 759553877;
					continue;
				case 7u:
					break;
				case 6u:
					_sourceRectangle.X = _currentFrame * _sourceRectangle.Width;
					num = 345150992;
					continue;
				case 5u:
					goto end_IL_00c7;
				case 4u:
					num = ((int)num2 * -1279316238) ^ -268268547;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (_currentFrame < _numberOfFrames)
					{
						num3 = 1900414154;
						num4 = 1900414154;
					}
					else
					{
						num3 = 415976630;
						num4 = 415976630;
					}
					num = num3 ^ ((int)num2 * -137036105);
					continue;
				}
				default:
					return;
				case 3u:
					goto IL_0101;
				case 1u:
					return;
				case 2u:
					return;
				case 8u:
					_currentFrame = 0;
					return;
				}
				int num5;
				if (!(_time <= _timePerFrame))
				{
					num = 1660245577;
					num5 = 1660245577;
				}
				else
				{
					num = 968276006;
					num5 = 968276006;
				}
				continue;
				end_IL_00c7:
				break;
			}
			goto IL_0084;
			IL_0084:
			num = 1426995957;
			goto IL_00c7;
		}

		private void MyDraw(SpriteBatch spriteBatch)
		{
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_009c: Unknown result type (might be due to invalid IL or missing references)
			if (_currentFrame < 0)
			{
				goto IL_0066;
			}
			goto IL_0094;
			IL_0094:
			FrameAnimationLayer.smethod_6(spriteBatch, (SpriteSortMode)0, (BlendState)null, (SamplerState)null, (DepthStencilState)null, (RasterizerState)null, (Effect)null, (Matrix?)FrameAnimationLayer.smethod_5((_fAUddQEKfZyemRb327NhM3GGlmzA)this));
			int num = -1720762027;
			goto IL_006b;
			IL_006b:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x85004368u) % 6u)
				{
				case 3u:
					FrameAnimationLayer.smethod_8(spriteBatch);
					num = ((int)num2 * -897735691) ^ 0x7349949B;
					continue;
				case 1u:
					FrameAnimationLayer.smethod_7(spriteBatch, _animationTexture, _destinationRectangle, (Rectangle?)_sourceRectangle, Color.get_White(), _angle, _origin, (SpriteEffects)0, 0f);
					num = ((int)num2 * -1358630786) ^ 0x6BA610F1;
					continue;
				case 0u:
					break;
				default:
					return;
				case 5u:
					goto IL_0094;
				case 2u:
					return;
				case 4u:
					return;
				}
				break;
			}
			goto IL_0066;
			IL_0066:
			num = -595600180;
			goto IL_006b;
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
		ClubPoolStaticGHINPC clubPoolStaticGHINPC2 = default(ClubPoolStaticGHINPC);
		ClubPoolStaticJKNPC clubPoolStaticJKNPC2 = default(ClubPoolStaticJKNPC);
		ClubPoolStaticCNPC clubPoolStaticCNPC = default(ClubPoolStaticCNPC);
		ClubPoolStaticCNPC2 clubPoolStaticCNPC2 = default(ClubPoolStaticCNPC2);
		ClubPoolStaticDNPC2 clubPoolStaticDNPC2 = default(ClubPoolStaticDNPC2);
		ClubPoolStaticDNPC clubPoolStaticDNPC = default(ClubPoolStaticDNPC);
		ClubPoolStaticMNPC qGGOTxZ8aNWGh0hc26wcmx8wmwT_2 = default(ClubPoolStaticMNPC);
		ClubPoolStaticGHINPC2 clubPoolStaticGHINPC = default(ClubPoolStaticGHINPC2);
		ClubPoolStaticJKNPC2 clubPoolStaticJKNPC = default(ClubPoolStaticJKNPC2);
		ClubPoolStaticANPC qGGOTxZ8aNWGh0hc26wcmx8wmwT_7 = default(ClubPoolStaticANPC);
		ClubPoolStaticNNPC qGGOTxZ8aNWGh0hc26wcmx8wmwT_4 = default(ClubPoolStaticNNPC);
		ClubPoolStaticOPNPC clubPoolStaticOPNPC2 = default(ClubPoolStaticOPNPC);
		ClubPoolStaticOPNPC2 clubPoolStaticOPNPC = default(ClubPoolStaticOPNPC2);
		while (true)
		{
			int num = -849694252;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDAACFC62u) % 31u)
				{
				case 30u:
					ClubPoolScene.smethod_26((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubPoolStaticGHINPC2, 450f);
					num = (int)((num2 * 213031639) ^ 0x7E823C26);
					continue;
				case 29u:
					clubPoolStaticJKNPC2 = ClubPoolScene.smethod_24((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubPoolStaticJKNPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Foreground);
					num = -599646474;
					continue;
				case 28u:
					ClubPoolScene.smethod_26((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubPoolStaticCNPC, 450f);
					clubPoolStaticCNPC2 = ClubPoolScene.smethod_24((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubPoolStaticCNPC2>(_a2qVgWDIm3fBp49WubttSTPsx8K.Background);
					num = (int)(num2 * 683544111) ^ -1374563880;
					continue;
				case 27u:
					ClubPoolScene.smethod_25((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubPoolStaticCNPC, -180f);
					num = ((int)num2 * -1980323773) ^ -159446121;
					continue;
				case 26u:
				{
					ClubPoolStaticFNPC qGGOTxZ8aNWGh0hc26wcmx8wmwT_8 = ClubPoolScene.smethod_24((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubPoolStaticFNPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Foreground);
					ClubPoolScene.smethod_25((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)qGGOTxZ8aNWGh0hc26wcmx8wmwT_8, 500f);
					ClubPoolScene.smethod_26((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)qGGOTxZ8aNWGh0hc26wcmx8wmwT_8, 180f);
					num = (int)(num2 * 492586341) ^ -115800533;
					continue;
				}
				case 25u:
					ClubPoolScene.smethod_25((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubPoolStaticDNPC2, ClubPoolScene.smethod_27((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubPoolStaticDNPC));
					num = ((int)num2 * -795474363) ^ 0x3CFDC5E0;
					continue;
				case 24u:
					clubPoolStaticCNPC2._qFVIvzuvIuKKG5vOrovLtn4NplA = clubPoolStaticCNPC._qFVIvzuvIuKKG5vOrovLtn4NplA;
					ClubPoolScene.smethod_25((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubPoolStaticCNPC2, ClubPoolScene.smethod_27((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubPoolStaticCNPC));
					ClubPoolScene.smethod_26((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubPoolStaticCNPC2, ClubPoolScene.smethod_28((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubPoolStaticCNPC));
					num = ((int)num2 * -1518523120) ^ -1467177452;
					continue;
				case 23u:
					ClubPoolScene.smethod_26((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubPoolStaticDNPC, 690f);
					clubPoolStaticDNPC2 = ClubPoolScene.smethod_24((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubPoolStaticDNPC2>(_a2qVgWDIm3fBp49WubttSTPsx8K.Background);
					num = (int)(num2 * 17859633) ^ -1008921678;
					continue;
				case 22u:
					ClubPoolScene.smethod_25((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)qGGOTxZ8aNWGh0hc26wcmx8wmwT_2, 1879f);
					num = (int)(num2 * 2063991849) ^ -689012140;
					continue;
				case 21u:
					clubPoolStaticGHINPC = ClubPoolScene.smethod_24((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubPoolStaticGHINPC2>(_a2qVgWDIm3fBp49WubttSTPsx8K.Background);
					num = (int)(num2 * 198105442) ^ -1320787367;
					continue;
				case 20u:
					ClubPoolScene.smethod_26((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)_remy, 150f);
					ClubPoolScene.smethod_29((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)_remy, (Action)OnRemyClick);
					num = (int)(num2 * 850531904) ^ -1076411890;
					continue;
				case 19u:
					clubPoolStaticDNPC2._qFVIvzuvIuKKG5vOrovLtn4NplA = clubPoolStaticDNPC._qFVIvzuvIuKKG5vOrovLtn4NplA;
					num = (int)(num2 * 11900237) ^ -325469046;
					continue;
				case 18u:
					clubPoolStaticJKNPC = ClubPoolScene.smethod_24((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubPoolStaticJKNPC2>(_a2qVgWDIm3fBp49WubttSTPsx8K.Background);
					clubPoolStaticJKNPC._qFVIvzuvIuKKG5vOrovLtn4NplA = clubPoolStaticJKNPC2._qFVIvzuvIuKKG5vOrovLtn4NplA;
					ClubPoolScene.smethod_25((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubPoolStaticJKNPC, ClubPoolScene.smethod_27((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubPoolStaticJKNPC2));
					num = (int)((num2 * 1018564336) ^ 0x5D84DE7E);
					continue;
				case 17u:
					ClubPoolScene.smethod_25((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubPoolStaticJKNPC2, 1269f);
					num = (int)(num2 * 895245480) ^ -2099627873;
					continue;
				case 16u:
					_remy = ClubPoolScene.smethod_24((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubStaticRemyNPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Foreground);
					ClubPoolScene.smethod_25((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)_remy, 1010f);
					num = (int)(num2 * 1552579201) ^ -72235970;
					continue;
				case 15u:
					qGGOTxZ8aNWGh0hc26wcmx8wmwT_7 = ClubPoolScene.smethod_24((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubPoolStaticANPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Background);
					num = (int)(num2 * 1627727695) ^ -596356059;
					continue;
				case 14u:
					ClubPoolScene.smethod_25((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubPoolStaticGHINPC2, 370f);
					num = (int)((num2 * 1567641972) ^ 0x2C719C60);
					continue;
				case 13u:
					ClubPoolScene.smethod_26((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubPoolStaticJKNPC2, 383f);
					num = ((int)num2 * -336060421) ^ 0x268F1C36;
					continue;
				case 12u:
					ClubPoolScene.smethod_26((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)qGGOTxZ8aNWGh0hc26wcmx8wmwT_4, 106f);
					clubPoolStaticOPNPC2 = ClubPoolScene.smethod_24((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubPoolStaticOPNPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Foreground);
					ClubPoolScene.smethod_25((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubPoolStaticOPNPC2, 2223f);
					ClubPoolScene.smethod_26((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubPoolStaticOPNPC2, 442f);
					num = (int)((num2 * 859421961) ^ 0x4F8ED53);
					continue;
				case 11u:
					ClubPoolScene.smethod_25((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)qGGOTxZ8aNWGh0hc26wcmx8wmwT_7, -1400f);
					ClubPoolScene.smethod_26((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)qGGOTxZ8aNWGh0hc26wcmx8wmwT_7, 910f);
					num = (int)((num2 * 1670846470) ^ 0x61B42ACE);
					continue;
				case 10u:
				{
					ClubPoolScene.smethod_26((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubPoolStaticDNPC2, ClubPoolScene.smethod_28((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubPoolStaticDNPC));
					int num3;
					int num4;
					if (_showRemy)
					{
						num3 = -166608524;
						num4 = -166608524;
					}
					else
					{
						num3 = -499149193;
						num4 = -499149193;
					}
					num = num3 ^ (int)(num2 * 1012251925);
					continue;
				}
				case 9u:
					clubPoolStaticOPNPC = ClubPoolScene.smethod_24((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubPoolStaticOPNPC2>(_a2qVgWDIm3fBp49WubttSTPsx8K.Background);
					clubPoolStaticOPNPC._qFVIvzuvIuKKG5vOrovLtn4NplA = clubPoolStaticOPNPC2._qFVIvzuvIuKKG5vOrovLtn4NplA;
					num = ((int)num2 * -464967005) ^ -68737174;
					continue;
				case 8u:
					ClubPoolScene.smethod_25((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubPoolStaticDNPC, 50f);
					num = ((int)num2 * -1454979047) ^ -397509967;
					continue;
				case 7u:
				{
					ClubPoolStaticBNPC qGGOTxZ8aNWGh0hc26wcmx8wmwT_5 = ClubPoolScene.smethod_24((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubPoolStaticBNPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Background);
					ClubPoolScene.smethod_25((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)qGGOTxZ8aNWGh0hc26wcmx8wmwT_5, -1401f);
					ClubPoolScene.smethod_26((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)qGGOTxZ8aNWGh0hc26wcmx8wmwT_5, 230f);
					ClubPoolStaticENPC qGGOTxZ8aNWGh0hc26wcmx8wmwT_6 = ClubPoolScene.smethod_24((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubPoolStaticENPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Background);
					ClubPoolScene.smethod_25((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)qGGOTxZ8aNWGh0hc26wcmx8wmwT_6, 106f);
					ClubPoolScene.smethod_26((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)qGGOTxZ8aNWGh0hc26wcmx8wmwT_6, 397f);
					clubPoolStaticCNPC = ClubPoolScene.smethod_24((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubPoolStaticCNPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Foreground);
					num = ((int)num2 * -299658423) ^ 0x36DE736B;
					continue;
				}
				case 6u:
					clubPoolStaticGHINPC2 = ClubPoolScene.smethod_24((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubPoolStaticGHINPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Foreground);
					num = ((int)num2 * -1304101851) ^ -1001113445;
					continue;
				case 4u:
					clubPoolStaticGHINPC._qFVIvzuvIuKKG5vOrovLtn4NplA = clubPoolStaticGHINPC2._qFVIvzuvIuKKG5vOrovLtn4NplA;
					ClubPoolScene.smethod_25((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubPoolStaticGHINPC, ClubPoolScene.smethod_27((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubPoolStaticGHINPC2));
					ClubPoolScene.smethod_26((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubPoolStaticGHINPC, ClubPoolScene.smethod_28((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubPoolStaticGHINPC2));
					clubPoolStaticDNPC = ClubPoolScene.smethod_24((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubPoolStaticDNPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Foreground);
					num = (int)(num2 * 186609916) ^ -534495206;
					continue;
				case 3u:
					qGGOTxZ8aNWGh0hc26wcmx8wmwT_4 = ClubPoolScene.smethod_24((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubPoolStaticNNPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Background);
					ClubPoolScene.smethod_25((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)qGGOTxZ8aNWGh0hc26wcmx8wmwT_4, 2039f);
					num = (int)((num2 * 1615221052) ^ 0x755866EC);
					continue;
				case 2u:
				{
					ClubPoolScene.smethod_26((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubPoolStaticJKNPC, ClubPoolScene.smethod_28((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubPoolStaticJKNPC2));
					ClubPoolStaticLNPC qGGOTxZ8aNWGh0hc26wcmx8wmwT_3 = ClubPoolScene.smethod_24((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubPoolStaticLNPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Background);
					ClubPoolScene.smethod_25((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)qGGOTxZ8aNWGh0hc26wcmx8wmwT_3, 1630f);
					ClubPoolScene.smethod_26((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)qGGOTxZ8aNWGh0hc26wcmx8wmwT_3, 106f);
					qGGOTxZ8aNWGh0hc26wcmx8wmwT_2 = ClubPoolScene.smethod_24((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubPoolStaticMNPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Background);
					num = (int)(num2 * 274151110) ^ -715657279;
					continue;
				}
				case 0u:
					ClubPoolScene.smethod_26((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)qGGOTxZ8aNWGh0hc26wcmx8wmwT_2, 106f);
					num = (int)((num2 * 1450165441) ^ 0x331D6517);
					continue;
				case 5u:
					break;
				default:
				{
					ClubPoolScene.smethod_25((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubPoolStaticOPNPC, ClubPoolScene.smethod_27((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubPoolStaticOPNPC2));
					ClubPoolScene.smethod_26((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubPoolStaticOPNPC, ClubPoolScene.smethod_28((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)clubPoolStaticOPNPC2));
					ClubPoolStaticQRNPC qGGOTxZ8aNWGh0hc26wcmx8wmwT_ = ClubPoolScene.smethod_24((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)._TwQHHdbdRFRy2ctTZabNfz1Htrg<ClubPoolStaticQRNPC>(_a2qVgWDIm3fBp49WubttSTPsx8K.Foreground);
					ClubPoolScene.smethod_25((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)qGGOTxZ8aNWGh0hc26wcmx8wmwT_, 2694f);
					ClubPoolScene.smethod_26((_QGGOTxZ8aNWGh0hc26wcmx8wmwT)qGGOTxZ8aNWGh0hc26wcmx8wmwT_, 97f);
					return;
				}
				}
				break;
			}
		}
	}

	public override void Update(GameTime gameTime)
	{
		if (_Bj3jScuqBJCFV58AWBDg8HofpqY)
		{
			while (true)
			{
				int num = -531908628;
				while (true)
				{
					switch ((uint)(num ^ -42112052) % 3u)
					{
					case 2u:
					{
						List<_ujAkjlfN5TywwbLAUDzPvtab6uJ> list = ClubPoolScene.smethod_30((_7UlnfykmEmZDFt3BmCKZekI43Ih)this).Where(delegate(_ujAkjlfN5TywwbLAUDzPvtab6uJ x)
						{
							_3IHp43rpkJgOBcY9lrIrwMuwWve _3IHp43rpkJgOBcY9lrIrwMuwWve = x as _3IHp43rpkJgOBcY9lrIrwMuwWve;
							while (true)
							{
								int num2 = 2139648054;
								while (true)
								{
									uint num3;
									switch ((num3 = (uint)num2 ^ 0x2E4AB0ECu) % 6u)
									{
									case 5u:
									{
										int num6;
										int num7;
										if (!(_3IHp43rpkJgOBcY9lrIrwMuwWve._4QLHHCk23T1BjK7acKxASbkCefG is ClubStaticNPC))
										{
											num6 = 2085972234;
											num7 = 2085972234;
										}
										else
										{
											num6 = 751692615;
											num7 = 751692615;
										}
										num2 = num6 ^ (int)(num3 * 724862403);
										continue;
									}
									case 4u:
									{
										int num4;
										int num5;
										if (_3IHp43rpkJgOBcY9lrIrwMuwWve != null)
										{
											num4 = -629927197;
											num5 = -629927197;
										}
										else
										{
											num4 = -803395575;
											num5 = -803395575;
										}
										num2 = num4 ^ (int)(num3 * 1698782013);
										continue;
									}
									case 0u:
										break;
									default:
										return false;
									case 2u:
										return !(_3IHp43rpkJgOBcY9lrIrwMuwWve._4QLHHCk23T1BjK7acKxASbkCefG is ClubStaticSpineNPC);
									case 3u:
										return true;
									}
									break;
								}
							}
						}).ToList();
						list.ForEach(delegate(_ujAkjlfN5TywwbLAUDzPvtab6uJ x)
						{
							x._ac2H6kMdrgPhXXxabsikjji4SiT = 3;
						});
						num = -2144597947;
						continue;
					}
					case 0u:
						break;
					default:
						goto end_IL_007f;
					}
					break;
				}
				continue;
				end_IL_007f:
				break;
			}
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
