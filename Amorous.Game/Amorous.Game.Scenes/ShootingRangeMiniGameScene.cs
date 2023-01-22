using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Spine;

namespace Amorous.Game.Scenes;

public abstract class ShootingRangeMiniGameScene : _7UlnfykmEmZDFt3BmCKZekI43Ih
{
	private enum GameState
	{
		None,
		NotStarted,
		Started,
		GameOver
	}

	private class FrameAnimation : IDrawable
	{
		private readonly Texture2D _uZYA4qnOfbVDFtZ6Ih3HawZgErP;

		private Rectangle _NbYrjABARmnikNXQHmmbM8k62UE;

		private Rectangle _jqsWTJ89RIZpjBr65dNZzmpJJKE;

		private readonly Vector2 _QBwNjQE21bfJ9yRo7CynjeYaHRg;

		private readonly float _q2YaOk0V93J3GMeWTOtcGdh9kEA;

		private readonly int _hUTZltYwRfIdEri4M059hyQus5H;

		private int _Lb7cMVSwXw3dYaQEnyADfQZoUedb;

		private float _MZBGPP8CHYYeh1lAhvANLxmu8KVA;

		private float _Q7Kx7ErHf3u1QIUDKfFCKSXbznG;

		public bool _aeQckZZROopp0BqagEZE32fzkyr { get; private set; }

		public FrameAnimation(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0, string string_0, float float_0, int int_0, int int_1, int int_2, float float_1)
		{
			//IL_0083: Unknown result type (might be due to invalid IL or missing references)
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
			while (true)
			{
				int num = -1028525302;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x88A01588u) % 7u)
					{
					case 5u:
						_hUTZltYwRfIdEri4M059hyQus5H = int_0;
						_Lb7cMVSwXw3dYaQEnyADfQZoUedb = 0;
						num = ((int)num2 * -382947560) ^ -920374095;
						continue;
					case 3u:
						_uZYA4qnOfbVDFtZ6Ih3HawZgErP = FrameAnimation.smethod_1(FrameAnimation.smethod_0(_7UlnfykmEmZDFt3BmCKZekI43Ih_0)).Load<Texture2D>(string_0);
						_q2YaOk0V93J3GMeWTOtcGdh9kEA = float_0 / (float)int_0;
						num = (int)(num2 * 121554844) ^ -1962073144;
						continue;
					case 2u:
						_NbYrjABARmnikNXQHmmbM8k62UE = new Rectangle(0, 0, (int)((float)_jqsWTJ89RIZpjBr65dNZzmpJJKE.Width * float_1), (int)((float)_jqsWTJ89RIZpjBr65dNZzmpJJKE.Height * float_1));
						num = (int)((num2 * 2061137837) ^ 0x6057462B);
						continue;
					case 1u:
						_jqsWTJ89RIZpjBr65dNZzmpJJKE = new Rectangle(0, 0, (int)((float)FrameAnimation.smethod_2(_uZYA4qnOfbVDFtZ6Ih3HawZgErP) / 12f), FrameAnimation.smethod_3(_uZYA4qnOfbVDFtZ6Ih3HawZgErP));
						num = ((int)num2 * -2012638) ^ 0x36FA9069;
						continue;
					case 0u:
						_QBwNjQE21bfJ9yRo7CynjeYaHRg = new Vector2((float)int_1, (float)int_2);
						num = ((int)num2 * -1936905535) ^ 0x1F9B4563;
						continue;
					default:
						return;
					case 4u:
						break;
					case 6u:
						return;
					}
					break;
				}
			}
		}

		public void _QrgbXEg7MMeD9Ybz12fFVsbmAd9(int int_0, int int_1, float float_0)
		{
			_NbYrjABARmnikNXQHmmbM8k62UE.X = int_0;
			while (true)
			{
				int num = 255357201;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x248D61F7u) % 4u)
					{
					case 3u:
						_MZBGPP8CHYYeh1lAhvANLxmu8KVA = FrameAnimation.smethod_4(float_0);
						num = (int)(num2 * 128178028) ^ -675307090;
						continue;
					case 2u:
						_NbYrjABARmnikNXQHmmbM8k62UE.Y = int_1;
						num = (int)((num2 * 726680513) ^ 0x1255CDFA);
						continue;
					default:
						return;
					case 0u:
						break;
					case 1u:
						return;
					}
					break;
				}
			}
		}

		public void _tiBFUHPEkedkbgvuX3whdeyjhKo(float float_0)
		{
			if (_Lb7cMVSwXw3dYaQEnyADfQZoUedb < 0)
			{
				goto IL_0050;
			}
			goto IL_0120;
			IL_0120:
			_Q7Kx7ErHf3u1QIUDKfFCKSXbznG += float_0;
			int num = 1127079211;
			goto IL_00e2;
			IL_00e2:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x717514F2u) % 11u)
				{
				case 9u:
					break;
				case 8u:
					_ymyneWF6dfrtfUI08wyb3KExq0D();
					num = (int)((num2 * 1625068244) ^ 0x4223CFF2);
					continue;
				case 7u:
					goto end_IL_00e2;
				case 4u:
				{
					int num3;
					int num4;
					if (_Lb7cMVSwXw3dYaQEnyADfQZoUedb < _hUTZltYwRfIdEri4M059hyQus5H)
					{
						num3 = -533615704;
						num4 = -533615704;
					}
					else
					{
						num3 = -174662896;
						num4 = -174662896;
					}
					num = num3 ^ ((int)num2 * -979839849);
					continue;
				}
				case 3u:
					num = (int)(num2 * 1421144296) ^ -266508392;
					continue;
				case 1u:
					_Q7Kx7ErHf3u1QIUDKfFCKSXbznG -= _q2YaOk0V93J3GMeWTOtcGdh9kEA;
					_Lb7cMVSwXw3dYaQEnyADfQZoUedb++;
					num = 240859952;
					continue;
				case 0u:
					_jqsWTJ89RIZpjBr65dNZzmpJJKE.X = _Lb7cMVSwXw3dYaQEnyADfQZoUedb * _jqsWTJ89RIZpjBr65dNZzmpJJKE.Width;
					num = 1093119834;
					continue;
				default:
					return;
				case 5u:
					goto IL_0120;
				case 2u:
					return;
				case 6u:
					return;
				case 10u:
					return;
				}
				int num5;
				if (!(_Q7Kx7ErHf3u1QIUDKfFCKSXbznG > _q2YaOk0V93J3GMeWTOtcGdh9kEA))
				{
					num = 765927263;
					num5 = 765927263;
				}
				else
				{
					num = 325507995;
					num5 = 325507995;
				}
				continue;
				end_IL_00e2:
				break;
			}
			goto IL_0050;
			IL_0050:
			num = 1564030980;
			goto IL_00e2;
		}

		public void _f5ctqAmdNsZ889UjM4LxDm8WGxA(SpriteBatch spriteBatch_0)
		{
			//IL_0035: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_0051: Unknown result type (might be due to invalid IL or missing references)
			if (_Lb7cMVSwXw3dYaQEnyADfQZoUedb < 0)
			{
				goto IL_0009;
			}
			goto IL_002d;
			IL_002d:
			FrameAnimation.smethod_5(spriteBatch_0, _uZYA4qnOfbVDFtZ6Ih3HawZgErP, _NbYrjABARmnikNXQHmmbM8k62UE, (Rectangle?)_jqsWTJ89RIZpjBr65dNZzmpJJKE, Color.get_White(), _MZBGPP8CHYYeh1lAhvANLxmu8KVA, _QBwNjQE21bfJ9yRo7CynjeYaHRg, (SpriteEffects)0, 0f);
			int num = 1814471768;
			goto IL_000e;
			IL_000e:
			switch ((uint)(num ^ 0x44A60E52) % 4u)
			{
			case 3u:
				break;
			default:
				return;
			case 0u:
				goto IL_002d;
			case 1u:
				return;
			case 2u:
				return;
			}
			goto IL_0009;
			IL_0009:
			num = 1592876675;
			goto IL_000e;
		}

		public void _ymyneWF6dfrtfUI08wyb3KExq0D()
		{
			_Lb7cMVSwXw3dYaQEnyADfQZoUedb = -1;
			_aeQckZZROopp0BqagEZE32fzkyr = true;
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

		static void smethod_5(SpriteBatch spriteBatch_0, Texture2D texture2D_0, Rectangle rectangle_0, Rectangle? nullable_0, Color color_0, float float_0, Vector2 vector2_0, SpriteEffects spriteEffects_0, float float_1)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0004: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			spriteBatch_0.Draw(texture2D_0, rectangle_0, nullable_0, color_0, float_0, vector2_0, spriteEffects_0, float_1);
		}
	}

	private class TargetModel : _WBXNT6eIVGk6ZKExRBJ6JxXE6zb
	{
		public enum CollisionType
		{
			None,
			Headshot,
			Bodyshot
		}

		private static Point _4mLyheZBE5398noM999P10uPXyj = new Point(257, 503);

		private static Point _I906IAlfLiodaJFNAL8BXp1P47T = new Point(128, 100);

		private static int _lhuXZkj0cs1oFnjnnY7TNYVWPXe = 64;

		private float _i8C0PwO83NRzGvNoyMhHwLV9HeC;

		private float _JZPZVzDxWQJJNyrQBsinax9LDSh;

		private float _gQiTjWdk9KSBoYLFXR1ELHlQDTk;

		private Point _F61ut0AEUAE7JfCltwE9RXP3TK;

		private Point _OVCuLPSRFKMV6JuYrGeZ5uMUJTC;

		private int _XD9uURBVAJTsK2DKyuCockNh07A;

		private readonly _nHdiyIURlAiaNZ8u6MKzxjcwnyL _pO4d7wyWlp6cYLHahUVYplpUWxw;

		public bool _kf3EbE0B70xGe1szklqAZyCqoLj { get; set; }

		public new float _fO7gSlrDDNMoHR4FO5QXAq8fUyA => _i8C0PwO83NRzGvNoyMhHwLV9HeC;

		public TargetModel(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0, int int_0, int int_1, float float_0 = 1f)
			: base(_7UlnfykmEmZDFt3BmCKZekI43Ih_0, "Target")
		{
			while (true)
			{
				int num = 888543260;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7CBFE81Fu) % 5u)
					{
					case 4u:
						TargetModel.smethod_1((_WBXNT6eIVGk6ZKExRBJ6JxXE6zb)this, (Action<SpriteBatch, SkeletonMeshRenderer>)delegate(SpriteBatch spriteBatch_0, SkeletonMeshRenderer skeletonMeshRenderer_0)
						{
							TargetModel.smethod_10(_pO4d7wyWlp6cYLHahUVYplpUWxw, skeletonMeshRenderer_0, (Texture2D)null, (Func<int, string, bool>)null, (Color?)null, _i8C0PwO83NRzGvNoyMhHwLV9HeC);
						});
						_pO4d7wyWlp6cYLHahUVYplpUWxw = TargetModel.smethod_4(TargetModel.smethod_3(TargetModel.smethod_2(_7UlnfykmEmZDFt3BmCKZekI43Ih_0)), "Assets/Scenes/ShootingRange/Target", 1f, bool_0: true, (List<SpineEvent>)null);
						num = (int)(num2 * 1462814697) ^ -783381816;
						continue;
					case 3u:
						TargetModel.smethod_0((_fAUddQEKfZyemRb327NhM3GGlmzA)this, (Action<GameTime>)delegate(GameTime gameTime_0)
						{
							TargetModel.smethod_9(_pO4d7wyWlp6cYLHahUVYplpUWxw, gameTime_0, 1000f);
						});
						num = ((int)num2 * -1995028456) ^ -1395921794;
						continue;
					case 1u:
						_q83Vj1dGmn3NFhPIkk7tO7tyxb(int_0, int_1, float_0);
						num = (int)(num2 * 1214090956) ^ -133819555;
						continue;
					default:
						return;
					case 2u:
						break;
					case 0u:
						return;
					}
					break;
				}
			}
		}

		private void _q83Vj1dGmn3NFhPIkk7tO7tyxb(int int_0, int int_1, float? nullable_0)
		{
			//IL_0085: Unknown result type (might be due to invalid IL or missing references)
			//IL_008a: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
			TargetModel.smethod_5(_pO4d7wyWlp6cYLHahUVYplpUWxw, (float)int_0);
			while (true)
			{
				int num = 768680175;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5E113303u) % 7u)
					{
					case 6u:
						TargetModel.smethod_6(_pO4d7wyWlp6cYLHahUVYplpUWxw, (float)int_1);
						num = ((int)num2 * -1477778289) ^ -1791656844;
						continue;
					case 5u:
						_gQiTjWdk9KSBoYLFXR1ELHlQDTk = (float)int_1 - (float)_4mLyheZBE5398noM999P10uPXyj.Y * _i8C0PwO83NRzGvNoyMhHwLV9HeC;
						num = ((int)num2 * -281725994) ^ -1702007485;
						continue;
					case 2u:
						_F61ut0AEUAE7JfCltwE9RXP3TK = new Point((int)((float)_4mLyheZBE5398noM999P10uPXyj.X * _i8C0PwO83NRzGvNoyMhHwLV9HeC), (int)((float)_4mLyheZBE5398noM999P10uPXyj.Y * _i8C0PwO83NRzGvNoyMhHwLV9HeC));
						_OVCuLPSRFKMV6JuYrGeZ5uMUJTC = new Point((int)((float)_I906IAlfLiodaJFNAL8BXp1P47T.X * _i8C0PwO83NRzGvNoyMhHwLV9HeC), (int)((float)_I906IAlfLiodaJFNAL8BXp1P47T.Y * _i8C0PwO83NRzGvNoyMhHwLV9HeC));
						num = (int)(num2 * 1854606892) ^ -17935760;
						continue;
					case 1u:
						_i8C0PwO83NRzGvNoyMhHwLV9HeC = nullable_0 ?? _i8C0PwO83NRzGvNoyMhHwLV9HeC;
						_JZPZVzDxWQJJNyrQBsinax9LDSh = (float)int_0 - (float)_4mLyheZBE5398noM999P10uPXyj.X / 2f * _i8C0PwO83NRzGvNoyMhHwLV9HeC;
						num = 1812682989;
						continue;
					case 0u:
						_XD9uURBVAJTsK2DKyuCockNh07A = (int)((float)_lhuXZkj0cs1oFnjnnY7TNYVWPXe * _i8C0PwO83NRzGvNoyMhHwLV9HeC);
						num = ((int)num2 * -1530028808) ^ 0x2F603E22;
						continue;
					default:
						return;
					case 3u:
						break;
					case 4u:
						return;
					}
					break;
				}
			}
		}

		public void _edcakvTOp2fd2J9ZHAu9GKjDaN7(Action action_0 = null)
		{
			TargetModel.smethod_7(_pO4d7wyWlp6cYLHahUVYplpUWxw, "Rise", action_0);
		}

		public void _DcBCpcEfsjl4zP1zbrOrd1bwNReb(Action action_0 = null)
		{
			TargetModel.smethod_7(_pO4d7wyWlp6cYLHahUVYplpUWxw, "Headshot", action_0);
		}

		public void _u1yq8F9lG8oMcA9vZO9c7Qbh8vj(Action action_0 = null)
		{
			TargetModel.smethod_7(_pO4d7wyWlp6cYLHahUVYplpUWxw, "Bodyshot", action_0);
		}

		public bool _ZCfNJ0nxXx3YppgLl5SvS2LkQ5B(Point point_0, out CollisionType collisionType_0)
		{
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_0095: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_015a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0197: Unknown result type (might be due to invalid IL or missing references)
			//IL_021e: Unknown result type (might be due to invalid IL or missing references)
			collisionType_0 = CollisionType.None;
			if (!_kf3EbE0B70xGe1szklqAZyCqoLj)
			{
				goto IL_0125;
			}
			goto IL_021e;
			IL_021e:
			int num;
			int num2;
			if (!((float)point_0.X < _JZPZVzDxWQJJNyrQBsinax9LDSh))
			{
				num = 1931300215;
				num2 = 1931300215;
			}
			else
			{
				num = 1697716045;
				num2 = 1697716045;
			}
			goto IL_01c5;
			IL_01c5:
			double num6 = default(double);
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num ^ 0x7E440EDCu) % 14u)
				{
				case 13u:
					collisionType_0 = CollisionType.Headshot;
					num = ((int)num3 * -1539872810) ^ -365455929;
					continue;
				case 12u:
				{
					int num15;
					int num16;
					if ((float)point_0.Y >= _gQiTjWdk9KSBoYLFXR1ELHlQDTk + (float)_OVCuLPSRFKMV6JuYrGeZ5uMUJTC.Y + (float)_XD9uURBVAJTsK2DKyuCockNh07A)
					{
						num15 = -1341300032;
						num16 = -1341300032;
					}
					else
					{
						num15 = -1662801814;
						num16 = -1662801814;
					}
					num = num15 ^ ((int)num3 * -1576423797);
					continue;
				}
				case 10u:
					collisionType_0 = CollisionType.Bodyshot;
					num = ((int)num3 * -33527298) ^ -1790628492;
					continue;
				case 7u:
				{
					int num13;
					int num14;
					if ((float)point_0.X <= _JZPZVzDxWQJJNyrQBsinax9LDSh + (float)_F61ut0AEUAE7JfCltwE9RXP3TK.X)
					{
						num13 = 1434815629;
						num14 = 1434815629;
					}
					else
					{
						num13 = 634223068;
						num14 = 634223068;
					}
					num = num13 ^ ((int)num3 * -715629901);
					continue;
				}
				case 4u:
				{
					float num11 = (float)point_0.X - (_JZPZVzDxWQJJNyrQBsinax9LDSh + (float)_OVCuLPSRFKMV6JuYrGeZ5uMUJTC.X);
					float num12 = (float)point_0.Y - (_gQiTjWdk9KSBoYLFXR1ELHlQDTk + (float)_OVCuLPSRFKMV6JuYrGeZ5uMUJTC.Y);
					num6 = TargetModel.smethod_8((double)(num11 * num11 + num12 * num12));
					num = 1597345322;
					continue;
				}
				case 3u:
					break;
				case 2u:
				{
					int num7;
					int num8;
					if (num6 <= (double)_XD9uURBVAJTsK2DKyuCockNh07A)
					{
						num7 = -882183417;
						num8 = -882183417;
					}
					else
					{
						num7 = -1244740527;
						num8 = -1244740527;
					}
					num = num7 ^ (int)(num3 * 137163338);
					continue;
				}
				case 1u:
				{
					int num9;
					int num10;
					if ((float)point_0.Y > _gQiTjWdk9KSBoYLFXR1ELHlQDTk + (float)_F61ut0AEUAE7JfCltwE9RXP3TK.Y)
					{
						num9 = -125035823;
						num10 = -125035823;
					}
					else
					{
						num9 = -885976422;
						num10 = -885976422;
					}
					num = num9 ^ ((int)num3 * -1775870524);
					continue;
				}
				case 0u:
				{
					int num4;
					int num5;
					if ((float)point_0.Y >= _gQiTjWdk9KSBoYLFXR1ELHlQDTk)
					{
						num4 = -970129845;
						num5 = -970129845;
					}
					else
					{
						num4 = -397251699;
						num5 = -397251699;
					}
					num = num4 ^ (int)(num3 * 864940225);
					continue;
				}
				case 11u:
					goto IL_021e;
				case 5u:
					return true;
				case 6u:
					return true;
				case 8u:
					return false;
				default:
					return false;
				}
				break;
			}
			goto IL_0125;
			IL_0125:
			num = 484598444;
			goto IL_01c5;
		}

		[CompilerGenerated]
		private void _ADJjrAI33HndiXqXJrA3qKsIyrF(GameTime gameTime_0)
		{
			TargetModel.smethod_9(_pO4d7wyWlp6cYLHahUVYplpUWxw, gameTime_0, 1000f);
		}

		[CompilerGenerated]
		private void _AmJLsnuDUqeR9shOixvB2LU01QD(SpriteBatch spriteBatch_0, SkeletonMeshRenderer skeletonMeshRenderer_0)
		{
			TargetModel.smethod_10(_pO4d7wyWlp6cYLHahUVYplpUWxw, skeletonMeshRenderer_0, (Texture2D)null, (Func<int, string, bool>)null, (Color?)null, _i8C0PwO83NRzGvNoyMhHwLV9HeC);
		}

		static void smethod_0(_fAUddQEKfZyemRb327NhM3GGlmzA _fAUddQEKfZyemRb327NhM3GGlmzA_0, Action<GameTime> action_0)
		{
			_fAUddQEKfZyemRb327NhM3GGlmzA_0._NC5P3SKqKPpcAYG1mqquUEcUzTg = action_0;
		}

		static void smethod_1(_WBXNT6eIVGk6ZKExRBJ6JxXE6zb _WBXNT6eIVGk6ZKExRBJ6JxXE6zb_0, Action<SpriteBatch, SkeletonMeshRenderer> action_0)
		{
			_WBXNT6eIVGk6ZKExRBJ6JxXE6zb_0._Wb2e00OWt8kBwGWEXtOGMVScRPm = action_0;
		}

		static _JbeCmOie0phb2cbgG6DdGZrbs3pB smethod_2(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0)
		{
			return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._ZzBuoSDMWwerejOO9Goyv2OCKgE;
		}

		static ContentManager smethod_3(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		{
			return _JbeCmOie0phb2cbgG6DdGZrbs3pB_0._uwNDZuqdFb9tyQtlQMxiz1DQ7x8;
		}

		static _nHdiyIURlAiaNZ8u6MKzxjcwnyL smethod_4(ContentManager contentManager_0, string string_0, float float_0, bool bool_0, List<SpineEvent> list_0)
		{
			return contentManager_0._7BVREQXEcBCieHb0qgaVDpUj1ni(string_0, float_0, bool_0, list_0);
		}

		static void smethod_5(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0, float float_0)
		{
			_nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._7Xn1C5tjYnmIif1iZKV8AWsEEbL = float_0;
		}

		static void smethod_6(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0, float float_0)
		{
			_nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._bCjZ3VSXGKyhmykd2zCnQBiSpDf = float_0;
		}

		static void smethod_7(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0, string string_0, Action action_0)
		{
			_nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._SPUoP3ABwpgQinJfKUM5qBbYSvr(string_0, action_0);
		}

		static double smethod_8(double double_0)
		{
			return Math.Sqrt(double_0);
		}

		static void smethod_9(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0, GameTime gameTime_0, float float_0)
		{
			_nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime_0, float_0);
		}

		static void smethod_10(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0, SkeletonMeshRenderer skeletonMeshRenderer_0, Texture2D texture2D_0, Func<int, string, bool> func_0, Color? nullable_0, float float_0)
		{
			_nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._f5ctqAmdNsZ889UjM4LxDm8WGxA(skeletonMeshRenderer_0, texture2D_0, func_0, nullable_0, float_0);
		}
	}

	private class GunModel : _WBXNT6eIVGk6ZKExRBJ6JxXE6zb
	{
		private readonly _nHdiyIURlAiaNZ8u6MKzxjcwnyL _XcQKV7iP9Sk10poAFYuakLJaltL;

		public new float _7Xn1C5tjYnmIif1iZKV8AWsEEbL
		{
			set
			{
				GunModel.smethod_0(_XcQKV7iP9Sk10poAFYuakLJaltL, value);
			}
		}

		public new float _bCjZ3VSXGKyhmykd2zCnQBiSpDf
		{
			set
			{
				GunModel.smethod_1(_XcQKV7iP9Sk10poAFYuakLJaltL, value);
			}
		}

		public bool _PXBbI2AED2MyzkuXicgwalICf26
		{
			set
			{
				GunModel.smethod_2(_XcQKV7iP9Sk10poAFYuakLJaltL, value);
			}
		}

		public GunModel(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0)
			: base(_7UlnfykmEmZDFt3BmCKZekI43Ih_0, "GunModel")
		{
			//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_0124: Unknown result type (might be due to invalid IL or missing references)
			//IL_0155: Unknown result type (might be due to invalid IL or missing references)
			//IL_0196: Unknown result type (might be due to invalid IL or missing references)
			//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0209: Unknown result type (might be due to invalid IL or missing references)
			//IL_023a: Unknown result type (might be due to invalid IL or missing references)
			//IL_027c: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_031c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0362: Unknown result type (might be due to invalid IL or missing references)
			//IL_038f: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0402: Unknown result type (might be due to invalid IL or missing references)
			//IL_0448: Unknown result type (might be due to invalid IL or missing references)
			//IL_0475: Unknown result type (might be due to invalid IL or missing references)
			//IL_04bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_04f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0525: Unknown result type (might be due to invalid IL or missing references)
			//IL_055a: Unknown result type (might be due to invalid IL or missing references)
			//IL_058f: Unknown result type (might be due to invalid IL or missing references)
			//IL_05c4: Unknown result type (might be due to invalid IL or missing references)
			GunModel.smethod_3((_fAUddQEKfZyemRb327NhM3GGlmzA)this, (Action<GameTime>)delegate(GameTime gameTime_0)
			{
				GunModel.smethod_24(_XcQKV7iP9Sk10poAFYuakLJaltL, gameTime_0, 1000f);
			});
			GunModel.smethod_4((_WBXNT6eIVGk6ZKExRBJ6JxXE6zb)this, (Action<SpriteBatch, SkeletonMeshRenderer>)delegate(SpriteBatch spriteBatch_0, SkeletonMeshRenderer skeletonMeshRenderer_0)
			{
				GunModel.smethod_25(_XcQKV7iP9Sk10poAFYuakLJaltL, skeletonMeshRenderer_0, (Texture2D)null, (Func<int, string, bool>)null, (Color?)null, _fO7gSlrDDNMoHR4FO5QXAq8fUyA);
			});
			_XcQKV7iP9Sk10poAFYuakLJaltL = GunModel.smethod_7(GunModel.smethod_6(GunModel.smethod_5(_7UlnfykmEmZDFt3BmCKZekI43Ih_0)), "Assets/GUI/Phone/Phone", 1f, bool_0: true, (List<SpineEvent>)null);
			GunModel.smethod_8(_XcQKV7iP9Sk10poAFYuakLJaltL, "Arm rise", 0f);
			GunModel.smethod_9(_XcQKV7iP9Sk10poAFYuakLJaltL, 0f);
			GunModel.smethod_0(_XcQKV7iP9Sk10poAFYuakLJaltL, 0f);
			GunModel.smethod_1(_XcQKV7iP9Sk10poAFYuakLJaltL, 1080f);
			_opIJo2jLUqdOL5yAFP4yzXce0DG opIJo2jLUqdOL5yAFP4yzXce0DG_ = GunModel.smethod_10();
			bool flag = GunModel.smethod_12((Enum)GunModel.smethod_11(opIJo2jLUqdOL5yAFP4yzXce0DG_), (Enum)_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.LongForearm);
			bool flag2;
			Color color_ = ((flag2 = GunModel.smethod_12((Enum)GunModel.smethod_11(opIJo2jLUqdOL5yAFP4yzXce0DG_), (Enum)_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.ShortForearm)) ? GunModel.smethod_14(opIJo2jLUqdOL5yAFP4yzXce0DG_) : (flag ? GunModel.smethod_13(opIJo2jLUqdOL5yAFP4yzXce0DG_) : Color.get_White()));
			GunModel.smethod_15(_XcQKV7iP9Sk10poAFYuakLJaltL, "Hoody Sleeve", 0f);
			GunModel.smethod_15(_XcQKV7iP9Sk10poAFYuakLJaltL, "Default Forearm", 1f);
			GunModel.smethod_17(_XcQKV7iP9Sk10poAFYuakLJaltL, "Default Forearm", GunModel.smethod_16(opIJo2jLUqdOL5yAFP4yzXce0DG_));
			GunModel.smethod_15(_XcQKV7iP9Sk10poAFYuakLJaltL, "Marking Forearm", (float)((flag2 || flag) ? 1 : 0));
			GunModel.smethod_17(_XcQKV7iP9Sk10poAFYuakLJaltL, "Marking Forearm", color_);
			GunModel.smethod_15(_XcQKV7iP9Sk10poAFYuakLJaltL, "Striped forearm", (float)(GunModel.smethod_12((Enum)GunModel.smethod_11(opIJo2jLUqdOL5yAFP4yzXce0DG_), (Enum)_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.Stripes) ? 1 : 0));
			GunModel.smethod_17(_XcQKV7iP9Sk10poAFYuakLJaltL, "Striped forearm", GunModel.smethod_18(opIJo2jLUqdOL5yAFP4yzXce0DG_));
			GunModel.smethod_15(_XcQKV7iP9Sk10poAFYuakLJaltL, "Avian Forearm", (float)(GunModel.smethod_12((Enum)GunModel.smethod_11(opIJo2jLUqdOL5yAFP4yzXce0DG_), (Enum)_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.AvianForearm) ? 1 : 0));
			GunModel.smethod_17(_XcQKV7iP9Sk10poAFYuakLJaltL, "Avian Forearm", GunModel.smethod_19(opIJo2jLUqdOL5yAFP4yzXce0DG_));
			GunModel.smethod_15(_XcQKV7iP9Sk10poAFYuakLJaltL, "Hand", 1f);
			GunModel.smethod_17(_XcQKV7iP9Sk10poAFYuakLJaltL, "Hand", GunModel.smethod_16(opIJo2jLUqdOL5yAFP4yzXce0DG_));
			GunModel.smethod_15(_XcQKV7iP9Sk10poAFYuakLJaltL, "Marking Hand", (float)((flag2 || flag) ? 1 : 0));
			GunModel.smethod_17(_XcQKV7iP9Sk10poAFYuakLJaltL, "Marking Hand", color_);
			GunModel.smethod_15(_XcQKV7iP9Sk10poAFYuakLJaltL, "Avian Hand", (float)(GunModel.smethod_12((Enum)GunModel.smethod_11(opIJo2jLUqdOL5yAFP4yzXce0DG_), (Enum)_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.AvianForearm) ? 1 : 0));
			GunModel.smethod_17(_XcQKV7iP9Sk10poAFYuakLJaltL, "Avian Hand", GunModel.smethod_19(opIJo2jLUqdOL5yAFP4yzXce0DG_));
			GunModel.smethod_15(_XcQKV7iP9Sk10poAFYuakLJaltL, "Index", 1f);
			GunModel.smethod_17(_XcQKV7iP9Sk10poAFYuakLJaltL, "Index", GunModel.smethod_16(opIJo2jLUqdOL5yAFP4yzXce0DG_));
			GunModel.smethod_15(_XcQKV7iP9Sk10poAFYuakLJaltL, "Avian index", (float)(GunModel.smethod_12((Enum)GunModel.smethod_11(opIJo2jLUqdOL5yAFP4yzXce0DG_), (Enum)_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.AvianForearm) ? 1 : 0));
			GunModel.smethod_17(_XcQKV7iP9Sk10poAFYuakLJaltL, "Avian index", GunModel.smethod_19(opIJo2jLUqdOL5yAFP4yzXce0DG_));
			GunModel.smethod_15(_XcQKV7iP9Sk10poAFYuakLJaltL, "Pinky", 1f);
			GunModel.smethod_17(_XcQKV7iP9Sk10poAFYuakLJaltL, "Pinky", GunModel.smethod_16(opIJo2jLUqdOL5yAFP4yzXce0DG_));
			GunModel.smethod_15(_XcQKV7iP9Sk10poAFYuakLJaltL, "Avian Pinky", (float)(GunModel.smethod_12((Enum)GunModel.smethod_11(opIJo2jLUqdOL5yAFP4yzXce0DG_), (Enum)_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.AvianForearm) ? 1 : 0));
			GunModel.smethod_17(_XcQKV7iP9Sk10poAFYuakLJaltL, "Avian Pinky", GunModel.smethod_19(opIJo2jLUqdOL5yAFP4yzXce0DG_));
			GunModel.smethod_15(_XcQKV7iP9Sk10poAFYuakLJaltL, "Ring", 1f);
			GunModel.smethod_17(_XcQKV7iP9Sk10poAFYuakLJaltL, "Ring", GunModel.smethod_16(opIJo2jLUqdOL5yAFP4yzXce0DG_));
			GunModel.smethod_15(_XcQKV7iP9Sk10poAFYuakLJaltL, "Avian ring", (float)(GunModel.smethod_12((Enum)GunModel.smethod_11(opIJo2jLUqdOL5yAFP4yzXce0DG_), (Enum)_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.AvianForearm) ? 1 : 0));
			GunModel.smethod_17(_XcQKV7iP9Sk10poAFYuakLJaltL, "Avian ring", GunModel.smethod_19(opIJo2jLUqdOL5yAFP4yzXce0DG_));
			GunModel.smethod_15(_XcQKV7iP9Sk10poAFYuakLJaltL, "Rude", 1f);
			GunModel.smethod_17(_XcQKV7iP9Sk10poAFYuakLJaltL, "Rude", GunModel.smethod_16(opIJo2jLUqdOL5yAFP4yzXce0DG_));
			GunModel.smethod_15(_XcQKV7iP9Sk10poAFYuakLJaltL, "Avian Rude", (float)(GunModel.smethod_12((Enum)GunModel.smethod_11(opIJo2jLUqdOL5yAFP4yzXce0DG_), (Enum)_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.AvianForearm) ? 1 : 0));
			GunModel.smethod_17(_XcQKV7iP9Sk10poAFYuakLJaltL, "Avian Rude", GunModel.smethod_19(opIJo2jLUqdOL5yAFP4yzXce0DG_));
			GunModel.smethod_15(_XcQKV7iP9Sk10poAFYuakLJaltL, "Thumb", 1f);
			GunModel.smethod_17(_XcQKV7iP9Sk10poAFYuakLJaltL, "Thumb", GunModel.smethod_16(opIJo2jLUqdOL5yAFP4yzXce0DG_));
			GunModel.smethod_15(_XcQKV7iP9Sk10poAFYuakLJaltL, "Avian Thumb", (float)(GunModel.smethod_12((Enum)GunModel.smethod_11(opIJo2jLUqdOL5yAFP4yzXce0DG_), (Enum)_opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U.AvianForearm) ? 1 : 0));
			GunModel.smethod_17(_XcQKV7iP9Sk10poAFYuakLJaltL, "Avian Thumb", GunModel.smethod_19(opIJo2jLUqdOL5yAFP4yzXce0DG_));
			GunModel.smethod_15(_XcQKV7iP9Sk10poAFYuakLJaltL, "Pinky Nail", (float)(GunModel.smethod_20(opIJo2jLUqdOL5yAFP4yzXce0DG_) ? 1 : 0));
			GunModel.smethod_17(_XcQKV7iP9Sk10poAFYuakLJaltL, "Pinky Nail", GunModel.smethod_21(opIJo2jLUqdOL5yAFP4yzXce0DG_));
			GunModel.smethod_15(_XcQKV7iP9Sk10poAFYuakLJaltL, "Ring Nail", (float)(GunModel.smethod_20(opIJo2jLUqdOL5yAFP4yzXce0DG_) ? 1 : 0));
			GunModel.smethod_17(_XcQKV7iP9Sk10poAFYuakLJaltL, "Ring Nail", GunModel.smethod_21(opIJo2jLUqdOL5yAFP4yzXce0DG_));
			GunModel.smethod_15(_XcQKV7iP9Sk10poAFYuakLJaltL, "Rude Nail", (float)(GunModel.smethod_20(opIJo2jLUqdOL5yAFP4yzXce0DG_) ? 1 : 0));
			GunModel.smethod_17(_XcQKV7iP9Sk10poAFYuakLJaltL, "Rude Nail", GunModel.smethod_21(opIJo2jLUqdOL5yAFP4yzXce0DG_));
			GunModel.smethod_15(_XcQKV7iP9Sk10poAFYuakLJaltL, "Index Nail", (float)(GunModel.smethod_20(opIJo2jLUqdOL5yAFP4yzXce0DG_) ? 1 : 0));
			GunModel.smethod_17(_XcQKV7iP9Sk10poAFYuakLJaltL, "Index Nail", GunModel.smethod_21(opIJo2jLUqdOL5yAFP4yzXce0DG_));
			GunModel.smethod_15(_XcQKV7iP9Sk10poAFYuakLJaltL, "Thumb Nail", (float)(GunModel.smethod_20(opIJo2jLUqdOL5yAFP4yzXce0DG_) ? 1 : 0));
			GunModel.smethod_17(_XcQKV7iP9Sk10poAFYuakLJaltL, "Thumb Nail", GunModel.smethod_21(opIJo2jLUqdOL5yAFP4yzXce0DG_));
			GunModel.smethod_15(_XcQKV7iP9Sk10poAFYuakLJaltL, "Muzzle flash", 1f);
			GunModel.smethod_15(_XcQKV7iP9Sk10poAFYuakLJaltL, "Gun casing", 1f);
			GunModel.smethod_15(_XcQKV7iP9Sk10poAFYuakLJaltL, "Gun", 1f);
			GunModel.smethod_15(_XcQKV7iP9Sk10poAFYuakLJaltL, "Gun Slide", 1f);
		}

		public void _edcakvTOp2fd2J9ZHAu9GKjDaN7(Action action_0 = null)
		{
			GunModel _KJWMaoRJ7oaDYXtF5MPjg5DcYwvA = default(GunModel);
			Action _qhAM4Wrvf8c5jzKBQqLfosAE9D = default(Action);
			while (true)
			{
				int num = -428090752;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x9B66719Au) % 4u)
					{
					case 2u:
						_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA = this;
						num = ((int)num2 * -1891752430) ^ -1619985037;
						continue;
					case 1u:
						_qhAM4Wrvf8c5jzKBQqLfosAE9D = action_0;
						num = (int)(num2 * 754464530) ^ -1753042669;
						continue;
					case 0u:
						break;
					default:
						GunModel.smethod_22(_XcQKV7iP9Sk10poAFYuakLJaltL, "Gun rise", (Action)delegate
						{
							_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._3AjdlsblH9b6FNnDEW7N5sQ8iHs();
							_qhAM4Wrvf8c5jzKBQqLfosAE9D?.Invoke();
						});
						return;
					}
					break;
				}
			}
		}

		private void _3AjdlsblH9b6FNnDEW7N5sQ8iHs()
		{
			GunModel.smethod_23(_XcQKV7iP9Sk10poAFYuakLJaltL, "Gun Idle", (Action<int>)null);
		}

		public void _e2DHCcfpFNWn5NTzMOw3FBUkwzA()
		{
			GunModel.smethod_22(_XcQKV7iP9Sk10poAFYuakLJaltL, "Gun Shoot", (Action)_3AjdlsblH9b6FNnDEW7N5sQ8iHs);
		}

		public void _hAt3H7isKECkVrQjY4L0hESiqLF(Action action_0 = null)
		{
			GunModel _KJWMaoRJ7oaDYXtF5MPjg5DcYwvA;
			Action _qhAM4Wrvf8c5jzKBQqLfosAE9D;
			while (true)
			{
				int num = 2076685971;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x18A6E978u) % 3u)
					{
					case 1u:
						goto IL_0008;
					default:
						return;
					case 0u:
						break;
					case 2u:
						return;
					}
					break;
					IL_0008:
					_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA = this;
					_qhAM4Wrvf8c5jzKBQqLfosAE9D = action_0;
					GunModel.smethod_22(_XcQKV7iP9Sk10poAFYuakLJaltL, "Gun reload", (Action)delegate
					{
						_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._3AjdlsblH9b6FNnDEW7N5sQ8iHs();
						_qhAM4Wrvf8c5jzKBQqLfosAE9D?.Invoke();
					});
					num = (int)(num2 * 1073801404) ^ -472014653;
				}
			}
		}

		[CompilerGenerated]
		private void _YuaJOFbc3gfp6WZmpnuifHMF9Dh(GameTime gameTime_0)
		{
			GunModel.smethod_24(_XcQKV7iP9Sk10poAFYuakLJaltL, gameTime_0, 1000f);
		}

		[CompilerGenerated]
		private void _0nszBRri8HVNLjGllZgWohYuaOP(SpriteBatch spriteBatch_0, SkeletonMeshRenderer skeletonMeshRenderer_0)
		{
			GunModel.smethod_25(_XcQKV7iP9Sk10poAFYuakLJaltL, skeletonMeshRenderer_0, (Texture2D)null, (Func<int, string, bool>)null, (Color?)null, _fO7gSlrDDNMoHR4FO5QXAq8fUyA);
		}

		static void smethod_0(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0, float float_0)
		{
			_nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._7Xn1C5tjYnmIif1iZKV8AWsEEbL = float_0;
		}

		static void smethod_1(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0, float float_0)
		{
			_nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._bCjZ3VSXGKyhmykd2zCnQBiSpDf = float_0;
		}

		static void smethod_2(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0, bool bool_0)
		{
			_nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._Hwt6L2NJfXmAfG6UOH8NVlNfGCR = bool_0;
		}

		static void smethod_3(_fAUddQEKfZyemRb327NhM3GGlmzA _fAUddQEKfZyemRb327NhM3GGlmzA_0, Action<GameTime> action_0)
		{
			_fAUddQEKfZyemRb327NhM3GGlmzA_0._NC5P3SKqKPpcAYG1mqquUEcUzTg = action_0;
		}

		static void smethod_4(_WBXNT6eIVGk6ZKExRBJ6JxXE6zb _WBXNT6eIVGk6ZKExRBJ6JxXE6zb_0, Action<SpriteBatch, SkeletonMeshRenderer> action_0)
		{
			_WBXNT6eIVGk6ZKExRBJ6JxXE6zb_0._Wb2e00OWt8kBwGWEXtOGMVScRPm = action_0;
		}

		static _JbeCmOie0phb2cbgG6DdGZrbs3pB smethod_5(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0)
		{
			return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._ZzBuoSDMWwerejOO9Goyv2OCKgE;
		}

		static ContentManager smethod_6(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		{
			return _JbeCmOie0phb2cbgG6DdGZrbs3pB_0._uwNDZuqdFb9tyQtlQMxiz1DQ7x8;
		}

		static _nHdiyIURlAiaNZ8u6MKzxjcwnyL smethod_7(ContentManager contentManager_0, string string_0, float float_0, bool bool_0, List<SpineEvent> list_0)
		{
			return contentManager_0._7BVREQXEcBCieHb0qgaVDpUj1ni(string_0, float_0, bool_0, list_0);
		}

		static void smethod_8(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0, string string_0, float float_0)
		{
			_nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._WPy6ICx3LVoejBaexyOoKGnX9jD(string_0, float_0);
		}

		static void smethod_9(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0, float float_0)
		{
			_nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._c4iC7y9v6xg7LpvjKIeUkOdZ3UF(float_0);
		}

		static _opIJo2jLUqdOL5yAFP4yzXce0DG smethod_10()
		{
			return _Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t();
		}

		static _opIJo2jLUqdOL5yAFP4yzXce0DG._VzIdKOJ1Gq1YccwwHcwhrVV5V4U smethod_11(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
		{
			return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._Mz7LwHZqoGBscApFXmff1kEQnGY;
		}

		static bool smethod_12(Enum enum_0, Enum enum_1)
		{
			return enum_0.HasFlag(enum_1);
		}

		static Color smethod_13(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._1ZKGQXLRAHEJR8v7jhlDsyOVLcz;
		}

		static Color smethod_14(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._8rDSn6e9Ip9WdOogjhIn8YlL1oM;
		}

		static void smethod_15(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0, string string_0, float float_0)
		{
			_nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._aAoZaDNczeScsMfLlGSfAzey9SQ(string_0, float_0);
		}

		static Color smethod_16(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._6f1rvTENt5XWmHTE22zxBIwbH9G;
		}

		static void smethod_17(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0, string string_0, Color color_0)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			_nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._VoeevpFh2kLKfHtpPDXWt0TFbuH(string_0, color_0);
		}

		static Color smethod_18(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._TxfCqloeyiHpsXka6B46iqCZNsZ;
		}

		static Color smethod_19(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._FrsyMDX7TebzFk8nSLTyRDPi1QH;
		}

		static bool smethod_20(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
		{
			return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._VmNLhqrIwSnE6JnCYiBcxnSqnEV;
		}

		static Color smethod_21(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._in5HHYmrdLTFpkgc8aimJpXqAXB;
		}

		static void smethod_22(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0, string string_0, Action action_0)
		{
			_nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._SPUoP3ABwpgQinJfKUM5qBbYSvr(string_0, action_0);
		}

		static void smethod_23(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0, string string_0, Action<int> action_0)
		{
			_nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._C5vPbZ72rpVMDWGuHxZuR5FNpAH(string_0, action_0);
		}

		static void smethod_24(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0, GameTime gameTime_0, float float_0)
		{
			_nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime_0, float_0);
		}

		static void smethod_25(_nHdiyIURlAiaNZ8u6MKzxjcwnyL _nHdiyIURlAiaNZ8u6MKzxjcwnyL_0, SkeletonMeshRenderer skeletonMeshRenderer_0, Texture2D texture2D_0, Func<int, string, bool> func_0, Color? nullable_0, float float_0)
		{
			_nHdiyIURlAiaNZ8u6MKzxjcwnyL_0._f5ctqAmdNsZ889UjM4LxDm8WGxA(skeletonMeshRenderer_0, texture2D_0, func_0, nullable_0, float_0);
		}
	}

	private interface IDrawable
	{
		bool _aeQckZZROopp0BqagEZE32fzkyr { get; }

		void _tiBFUHPEkedkbgvuX3whdeyjhKo(float float_0);

		void _f5ctqAmdNsZ889UjM4LxDm8WGxA(SpriteBatch spriteBatch_0);

		void _ymyneWF6dfrtfUI08wyb3KExq0D();
	}

	private class FloatingFeedbackDrawable : IDrawable
	{
		private const float _HS0I0EgJMjmRXhZ0KDhLBBA2VkE = 0.8f;

		private const float _YBMjlnwxHIEUKERmDSGIKOlw2aM = 100f;

		private readonly SpriteFont _xnYepZuegigJCU2jcbZsfVIakzF;

		private readonly float _nD28BmrDaEzCHelTAa14TKyuSyG;

		private float _LkckKdvuh9GaAwn7XojfbJBd91r;

		private readonly string _eNqfeKhXj4x1FkHQitvzRQ1JLSE;

		private readonly Color _JbGNnZhaeWyNm0aWm7TtSamww4C;

		private float _AQwQu1ldCtpbkD5F9oEByJdCnWaA;

		public bool _aeQckZZROopp0BqagEZE32fzkyr { get; private set; }

		public FloatingFeedbackDrawable(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0, int int_0, int int_1, string string_0, Color color_0)
		{
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			while (true)
			{
				int num = 115838022;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x5B7CB051u) % 7u)
					{
					case 6u:
						_LkckKdvuh9GaAwn7XojfbJBd91r = int_1;
						_eNqfeKhXj4x1FkHQitvzRQ1JLSE = string_0;
						num = (int)(num2 * 1753548352) ^ -1468092970;
						continue;
					case 4u:
						_AQwQu1ldCtpbkD5F9oEByJdCnWaA = 1f;
						num = ((int)num2 * -482119889) ^ 0x13E09B39;
						continue;
					case 3u:
						_nD28BmrDaEzCHelTAa14TKyuSyG = int_0;
						num = (int)(num2 * 1403707275) ^ -140816311;
						continue;
					case 2u:
						_JbGNnZhaeWyNm0aWm7TtSamww4C = color_0;
						num = ((int)num2 * -1408565178) ^ 0x12B9854F;
						continue;
					case 1u:
						_xnYepZuegigJCU2jcbZsfVIakzF = FloatingFeedbackDrawable.smethod_1(FloatingFeedbackDrawable.smethod_0(_7UlnfykmEmZDFt3BmCKZekI43Ih_0)).Load<SpriteFont>("Assets/GUI/Fonts/Bold-26");
						num = (int)(num2 * 917400066) ^ -431957950;
						continue;
					default:
						return;
					case 5u:
						break;
					case 0u:
						return;
					}
					break;
				}
			}
		}

		public void _tiBFUHPEkedkbgvuX3whdeyjhKo(float float_0)
		{
			if (_aeQckZZROopp0BqagEZE32fzkyr)
			{
				goto IL_0017;
			}
			goto IL_004b;
			IL_004b:
			_AQwQu1ldCtpbkD5F9oEByJdCnWaA -= 0.8f * float_0;
			int num;
			int num2;
			if (!(_AQwQu1ldCtpbkD5F9oEByJdCnWaA <= 0f))
			{
				num = 552670181;
				num2 = 552670181;
			}
			else
			{
				num = 1912744453;
				num2 = 1912744453;
			}
			goto IL_001c;
			IL_001c:
			switch ((uint)(num ^ 0x50309196) % 5u)
			{
			case 2u:
				break;
			case 4u:
				goto IL_004b;
			case 0u:
				_LkckKdvuh9GaAwn7XojfbJBd91r -= 100f * float_0;
				return;
			case 1u:
				return;
			default:
				_aeQckZZROopp0BqagEZE32fzkyr = true;
				return;
			}
			goto IL_0017;
			IL_0017:
			num = 1519357171;
			goto IL_001c;
		}

		public void _f5ctqAmdNsZ889UjM4LxDm8WGxA(SpriteBatch spriteBatch_0)
		{
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			spriteBatch_0.DrawString(_xnYepZuegigJCU2jcbZsfVIakzF, _eNqfeKhXj4x1FkHQitvzRQ1JLSE, new Vector2(_nD28BmrDaEzCHelTAa14TKyuSyG, _LkckKdvuh9GaAwn7XojfbJBd91r), _JbGNnZhaeWyNm0aWm7TtSamww4C * _AQwQu1ldCtpbkD5F9oEByJdCnWaA);
		}

		public void _ymyneWF6dfrtfUI08wyb3KExq0D()
		{
		}

		static _JbeCmOie0phb2cbgG6DdGZrbs3pB smethod_0(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0)
		{
			return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._ZzBuoSDMWwerejOO9Goyv2OCKgE;
		}

		static ContentManager smethod_1(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		{
			return _JbeCmOie0phb2cbgG6DdGZrbs3pB_0._uwNDZuqdFb9tyQtlQMxiz1DQ7x8;
		}
	}

	private class TimedDrawable : IDrawable
	{
		private float _3wk7bXUbhNqSQ9kMD9hieEubOhG;

		private readonly float _x2m0UxhUAD6cdIEszjrShiRmPfx;

		private readonly Action _jokchmUtu5NAXtJsjLfIUXz2XXP;

		public bool _aeQckZZROopp0BqagEZE32fzkyr { get; private set; }

		public TimedDrawable(float float_0, Action action_0)
		{
			while (true)
			{
				int num = -508874511;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xDE5D55AEu) % 4u)
					{
					case 3u:
						_x2m0UxhUAD6cdIEszjrShiRmPfx = float_0;
						num = (int)(num2 * 1000359510) ^ -2097512304;
						continue;
					case 0u:
						_jokchmUtu5NAXtJsjLfIUXz2XXP = action_0;
						num = (int)((num2 * 130632027) ^ 0x46B8EC13);
						continue;
					default:
						return;
					case 2u:
						break;
					case 1u:
						return;
					}
					break;
				}
			}
		}

		public void _tiBFUHPEkedkbgvuX3whdeyjhKo(float float_0)
		{
			if (_aeQckZZROopp0BqagEZE32fzkyr)
			{
				goto IL_001f;
			}
			goto IL_007c;
			IL_007c:
			_3wk7bXUbhNqSQ9kMD9hieEubOhG += float_0;
			int num = 469896824;
			goto IL_0053;
			IL_0053:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x134D17ECu) % 6u)
				{
				case 4u:
					_ymyneWF6dfrtfUI08wyb3KExq0D();
					num = ((int)num2 * -1441420086) ^ 0x55EB8BF7;
					continue;
				case 3u:
					break;
				case 0u:
				{
					int num3;
					int num4;
					if (_3wk7bXUbhNqSQ9kMD9hieEubOhG <= _x2m0UxhUAD6cdIEszjrShiRmPfx)
					{
						num3 = 914817143;
						num4 = 914817143;
					}
					else
					{
						num3 = 1997619042;
						num4 = 1997619042;
					}
					num = num3 ^ ((int)num2 * -2061689355);
					continue;
				}
				default:
					return;
				case 2u:
					goto IL_007c;
				case 1u:
					return;
				case 5u:
					return;
				}
				break;
			}
			goto IL_001f;
			IL_001f:
			num = 1510688003;
			goto IL_0053;
		}

		public void _f5ctqAmdNsZ889UjM4LxDm8WGxA(SpriteBatch spriteBatch_0)
		{
		}

		public void _ymyneWF6dfrtfUI08wyb3KExq0D()
		{
			_aeQckZZROopp0BqagEZE32fzkyr = true;
			_jokchmUtu5NAXtJsjLfIUXz2XXP?.Invoke();
		}
	}

	private class RailInfo
	{
		public readonly int _SjhHztt8d5kOtb7Z2BJKnZZxEKh;

		public readonly int _nVnyJkkce6HsdRrKSpRrzUDElg0;

		public readonly int _bCjZ3VSXGKyhmykd2zCnQBiSpDf;

		public readonly float _fO7gSlrDDNMoHR4FO5QXAq8fUyA;

		public readonly int _dPmC8tBC0iph2YBAFmztEsmwUdSA;

		public RailInfo(int int_0, int int_1, int int_2, float float_0, int int_3)
		{
			while (true)
			{
				int num = -1069247818;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD915F2D3u) % 4u)
					{
					case 3u:
						_fO7gSlrDDNMoHR4FO5QXAq8fUyA = float_0;
						num = ((int)num2 * -341248501) ^ 0x3A48F256;
						continue;
					case 1u:
						_SjhHztt8d5kOtb7Z2BJKnZZxEKh = int_0;
						_nVnyJkkce6HsdRrKSpRrzUDElg0 = int_1;
						_bCjZ3VSXGKyhmykd2zCnQBiSpDf = int_2;
						num = (int)(num2 * 804169005) ^ -1928578815;
						continue;
					case 2u:
						break;
					default:
						_dPmC8tBC0iph2YBAFmztEsmwUdSA = int_3;
						return;
					}
					break;
				}
			}
		}
	}

	private const int _WXnSCubyydx0vtwfr6EBSBJQ4NH = 0;

	private const int _eZgzZTxD4KGw9TAJWF36UIIrcJE = 1;

	private const int _Dh7DkqYx7ZsfJMMmwN9z46uqQUC = 2;

	private const int _kzJGd7GwiPrw5jq1fce3gSPDlid = 3;

	private const int _MF0mjT8MsvlaCSmH86jNrwPb8Qc = 4;

	private const int _ovABgEeBrYyMKzNKN45fWnoaNJw = 5;

	private const int _wzfl8zBPhdOVuG8akbisiVvuf3A = 6;

	private const int _nIbsE9m4hgh2WAJ3yKmgh39dDjc = 7;

	private const int _fa1AXPP2Dgoofe6mc2z35ZLjDEx = 8;

	private readonly RailInfo[] _HYME5rEMzi5Cag9e7DCXk5lrXwX = new RailInfo[4]
	{
		new RailInfo(710, 1210, 410, 0.3f, 1),
		new RailInfo(650, 1270, 575, 0.4f, 3),
		new RailInfo(270, 1650, 625, 0.6f, 4),
		new RailInfo(330, 1600, 770, 1f, 5)
	};

	private const float _rpuZ6CyEUKzAxwn4okIB41MYvfh = 90f;

	private const float _kaoNHt1lIV2yYLBYfdpVkoSJPXf = 3.5f;

	private const int _1pcAANk13CvJrSXUOZ3qhxtMDku = 6;

	private const string _9RACjV4WJk4KFrnXLYxI9sViikj = "Press <Space/R/Mouse-R> to Reload and begin.";

	private const string _U1HaVdhFZJNSjA4zQOBoTSRBtMl = "Time up, game over! Press <Enter> to retry or <Escape> to continue.";

	private readonly List<IDrawable> _xEG3axnWkco0Erk0PdjakXDULcA;

	private readonly List<IDrawable> _d9mstkVrU6KGDJyOtHGgrr2ZciA;

	private readonly _hqmu3NsKXqziXGfVh3dt79G0fye _vCjkdRWXT5mvEu0c22Hgh93luLg;

	private readonly _hqmu3NsKXqziXGfVh3dt79G0fye _ykeARom1bl7r01BeRXMOSqoJU6o;

	private readonly _hqmu3NsKXqziXGfVh3dt79G0fye _RiMZpLLSGIesSXF8vhSlVQ8SrDg;

	private readonly _hqmu3NsKXqziXGfVh3dt79G0fye _gabFSY9HcJdPu830plKx8W936qG;

	private readonly _hqmu3NsKXqziXGfVh3dt79G0fye _Hsn6Qz2oeKaTkin9XGwBJUJqy1C;

	private readonly _hqmu3NsKXqziXGfVh3dt79G0fye _Oeqego17TDqmByfLbOEB1isMXzJ;

	private readonly bool _WD4Plg5m1AwZ5mVyjQCADcW1ZTk;

	private readonly bool _U8eNAZVBW15ZflhG4fel0hK3Juu;

	private readonly GunModel _85WqOX8OcxbI6g74CaBZtHiHK2m;

	private List<TargetModel> _u8GaIYUzQ65BoFU3NzXBzyvujjbA;

	private readonly _uqydQVaCmCvK7zzWs5W4gZFpKBu _tvM0bxD4ITME03hjc6seyYclzxf;

	private Point _TcTPQp3KE5mO2mYA6sSQDbHnhAw;

	private readonly Color _AWLddj1Rm2sqiBwYcJDngG0QaQI;

	private readonly Texture2D _m1dNhD2jwJ6iTVUgUzMJUvnQFS;

	private readonly SpriteFont _6YCQhlMaqcDds8uGX1g8fjBKqV4A;

	private readonly SpriteFont _MnMUFBDfrGZBHvrJ30IAQilqivI;

	private bool _nHs33RHZMuYhYev0dQ6ic0aHmvO;

	private bool _eMnDHRem25x38ZqmbzZLc1CLkwlA;

	private int _JvgphfrWtBncPfgb6ERRVKKtlQG;

	private int _dH7hlTzeJboGa5rfpgerBfCmyKO;

	private int _C6cjmtLovCejw2N3OZYswcoYxsd;

	private int _pL6aoe4HLq4X3yQACLFyUH3xwBp;

	private TargetModel.CollisionType _0U2R42Dbf2ddmyfQBv0z7zBWwJm;

	private int _YFr89aAV3UzO9kf7kPKQJilRWED;

	private readonly float _YhybMVqCJnFekEXVbF1huXupDmh;

	private readonly float _MZh3nVRuDktDpIu8X149SF90ZjO;

	private int _M8VVMN3GHWWmFmORCACqNTXVh6b;

	private float _0zKXRrSXqoTAuTYQNrJIgtt7Emq;

	private int _G0GwJ5OWQOA4BjacW3XmFsyMFjz;

	private GameState _dxhbACq6BB89IAMy6ZOALWJgv7L;

	protected bool _F2ao1gdMb4UciyKC7Zly4by95Mn { get; set; }

	protected ShootingRangeMiniGameScene(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_055e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0563: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			int num = -891750590;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x87083E8Bu) % 30u)
				{
				case 29u:
					_7oYtfGpL7UyAQrZxew7Ahbvj6Sv(_Iz47swAAB7d2iX6PQ1xTIJIv8MJ("Background", "Assets/Scenes/ShootingRange/Background", 0, 0), 2);
					num = (int)(num2 * 1490616270) ^ -871608577;
					continue;
				case 28u:
					_M8VVMN3GHWWmFmORCACqNTXVh6b = 1;
					ShootingRangeMiniGameScene.smethod_24("Assets/Music/Mittsies - Mech", 0.4f);
					num = (int)(num2 * 2023830856) ^ -1679982380;
					continue;
				case 27u:
					_WD4Plg5m1AwZ5mVyjQCADcW1ZTk = ShootingRangeMiniGameScene.smethod_14(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0);
					num = (int)(num2 * 743269163) ^ -5253012;
					continue;
				case 26u:
					_6YCQhlMaqcDds8uGX1g8fjBKqV4A = ShootingRangeMiniGameScene.smethod_17(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0).Load<SpriteFont>("Assets/GUI/Fonts/Bold-14");
					_MnMUFBDfrGZBHvrJ30IAQilqivI = ShootingRangeMiniGameScene.smethod_17(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0).Load<SpriteFont>("Assets/GUI/Fonts/Bold-26");
					_AWLddj1Rm2sqiBwYcJDngG0QaQI = ShootingRangeMiniGameScene.smethod_22(ShootingRangeMiniGameScene.smethod_21());
					num = (int)(num2 * 1181526060) ^ -1013252267;
					continue;
				case 25u:
					_YhybMVqCJnFekEXVbF1huXupDmh = ShootingRangeMiniGameScene.smethod_23(_MnMUFBDfrGZBHvrJ30IAQilqivI, "Press <Space/R/Mouse-R> to Reload and begin.").X;
					_MZh3nVRuDktDpIu8X149SF90ZjO = ShootingRangeMiniGameScene.smethod_23(_MnMUFBDfrGZBHvrJ30IAQilqivI, "Time up, game over! Press <Enter> to retry or <Escape> to continue.").X;
					_0zKXRrSXqoTAuTYQNrJIgtt7Emq = 90f;
					num = (int)(num2 * 1157710023) ^ -616209616;
					continue;
				case 24u:
					_7oYtfGpL7UyAQrZxew7Ahbvj6Sv(_Iz47swAAB7d2iX6PQ1xTIJIv8MJ("Countertop", "Assets/Scenes/ShootingRange/Countertop", 0, 0), 6);
					num = (int)((num2 * 694760565) ^ 0x52F1F611);
					continue;
				case 23u:
					_gabFSY9HcJdPu830plKx8W936qG = ShootingRangeMiniGameScene.smethod_18(ShootingRangeMiniGameScene.smethod_17(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0));
					num = ((int)num2 * -682631635) ^ -653660097;
					continue;
				case 22u:
					_ykeARom1bl7r01BeRXMOSqoJU6o = ShootingRangeMiniGameScene.smethod_18(ShootingRangeMiniGameScene.smethod_17(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0));
					ShootingRangeMiniGameScene.smethod_19(_ykeARom1bl7r01BeRXMOSqoJU6o, new string[1] { "Assets/Sounds/MiniGames/ShootingRange/Reload" });
					num = ((int)num2 * -1307085432) ^ 0x6C8AA686;
					continue;
				case 21u:
					_Hsn6Qz2oeKaTkin9XGwBJUJqy1C = ShootingRangeMiniGameScene.smethod_18(ShootingRangeMiniGameScene.smethod_17(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0));
					num = (int)((num2 * 573909147) ^ 0x22B534EA);
					continue;
				case 20u:
					ShootingRangeMiniGameScene.smethod_19(_vCjkdRWXT5mvEu0c22Hgh93luLg, new string[1] { "Assets/Sounds/MiniGames/ShootingRange/Fire" });
					num = (int)((num2 * 2078035888) ^ 0x6FE9D4D1);
					continue;
				case 19u:
					ShootingRangeMiniGameScene.smethod_19(_gabFSY9HcJdPu830plKx8W936qG, new string[2] { "Assets/Sounds/MiniGames/ShootingRange/Headshot 1", "Assets/Sounds/MiniGames/ShootingRange/Headshot 2" });
					num = ((int)num2 * -1429946232) ^ 0xD0809A4;
					continue;
				case 18u:
					ShootingRangeMiniGameScene.smethod_16();
					num = (int)(num2 * 2123220387) ^ -1020747689;
					continue;
				case 17u:
					_d9mstkVrU6KGDJyOtHGgrr2ZciA = new List<IDrawable>();
					num = ((int)num2 * -1915329421) ^ 0x3EC03A5B;
					continue;
				case 16u:
					_tvM0bxD4ITME03hjc6seyYclzxf = _Iz47swAAB7d2iX6PQ1xTIJIv8MJ("Crosshair", "Assets/Scenes/ShootingRange/Crosshair", 0, 0);
					num = ((int)num2 * -114934410) ^ 0x3B653422;
					continue;
				case 15u:
					_m1dNhD2jwJ6iTVUgUzMJUvnQFS = ShootingRangeMiniGameScene.smethod_17(ShootingRangeMiniGameScene.smethod_20((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)).Load<Texture2D>("Assets/Scenes/ShootingRange/Bullet");
					_7oYtfGpL7UyAQrZxew7Ahbvj6Sv(_Iz47swAAB7d2iX6PQ1xTIJIv8MJ("Backdrop", "Assets/Scenes/ShootingRange/Backdrop", 600, 180), 0);
					num = (int)((num2 * 1280408943) ^ 0xCA6A9EB);
					continue;
				case 14u:
					ShootingRangeMiniGameScene.smethod_15(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0, bool_0: false);
					_U8eNAZVBW15ZflhG4fel0hK3Juu = _poenyHBGUusBcnNcTFB9MQBV72R._kf3EbE0B70xGe1szklqAZyCqoLj;
					_poenyHBGUusBcnNcTFB9MQBV72R._kf3EbE0B70xGe1szklqAZyCqoLj = false;
					num = (int)(num2 * 780133259) ^ -1929281979;
					continue;
				case 12u:
					_7oYtfGpL7UyAQrZxew7Ahbvj6Sv(_tvM0bxD4ITME03hjc6seyYclzxf, 7);
					num = (int)((num2 * 616632738) ^ 0x67C61A34);
					continue;
				case 11u:
					_7oYtfGpL7UyAQrZxew7Ahbvj6Sv(_85WqOX8OcxbI6g74CaBZtHiHK2m, 8);
					num = (int)(num2 * 1127607739) ^ -630127839;
					continue;
				case 10u:
					_Oeqego17TDqmByfLbOEB1isMXzJ = ShootingRangeMiniGameScene.smethod_18(ShootingRangeMiniGameScene.smethod_17(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0));
					num = ((int)num2 * -735265429) ^ 0x71C3EC4B;
					continue;
				case 9u:
					_u8GaIYUzQ65BoFU3NzXBzyvujjbA = new List<TargetModel>();
					_xEG3axnWkco0Erk0PdjakXDULcA = new List<IDrawable>();
					num = ((int)num2 * -845061480) ^ -819553172;
					continue;
				case 7u:
					_85WqOX8OcxbI6g74CaBZtHiHK2m = new GunModel(this)
					{
						_7Xn1C5tjYnmIif1iZKV8AWsEEbL = 1820f,
						_bCjZ3VSXGKyhmykd2zCnQBiSpDf = 1080f,
						_fO7gSlrDDNMoHR4FO5QXAq8fUyA = 0.5f,
						_PXBbI2AED2MyzkuXicgwalICf26 = true
					};
					num = (int)(num2 * 1503741046) ^ -616150786;
					continue;
				case 6u:
					_RiMZpLLSGIesSXF8vhSlVQ8SrDg = ShootingRangeMiniGameScene.smethod_18(ShootingRangeMiniGameScene.smethod_17(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0));
					ShootingRangeMiniGameScene.smethod_19(_RiMZpLLSGIesSXF8vhSlVQ8SrDg, new string[1] { "Assets/Sounds/MiniGames/ShootingRange/Dry" });
					num = (int)(num2 * 344802142) ^ -871702937;
					continue;
				case 5u:
					_dxhbACq6BB89IAMy6ZOALWJgv7L = GameState.NotStarted;
					num = (int)(num2 * 1527074788) ^ -1245872427;
					continue;
				case 4u:
					ShootingRangeMiniGameScene.smethod_19(_Oeqego17TDqmByfLbOEB1isMXzJ, new string[3] { "Assets/Sounds/MiniGames/ShootingRange/Ricochete 1", "Assets/Sounds/MiniGames/ShootingRange/Ricochete 2", "Assets/Sounds/MiniGames/ShootingRange/Ricochete 3" });
					num = (int)(num2 * 486070731) ^ -1385638840;
					continue;
				case 3u:
					_85WqOX8OcxbI6g74CaBZtHiHK2m._edcakvTOp2fd2J9ZHAu9GKjDaN7();
					num = ((int)num2 * -1584532091) ^ -662095143;
					continue;
				case 2u:
					ShootingRangeMiniGameScene.smethod_19(_Hsn6Qz2oeKaTkin9XGwBJUJqy1C, new string[3] { "Assets/Sounds/MiniGames/ShootingRange/Impact 1", "Assets/Sounds/MiniGames/ShootingRange/Impact 2", "Assets/Sounds/MiniGames/ShootingRange/Impact 3" });
					num = (int)(num2 * 500529810) ^ -220716765;
					continue;
				case 1u:
					_tvM0bxD4ITME03hjc6seyYclzxf._9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA = _AWLddj1Rm2sqiBwYcJDngG0QaQI;
					num = ((int)num2 * -519065191) ^ -241489226;
					continue;
				case 0u:
					_vCjkdRWXT5mvEu0c22Hgh93luLg = ShootingRangeMiniGameScene.smethod_18(ShootingRangeMiniGameScene.smethod_17(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0));
					num = ((int)num2 * -1726009213) ^ -385845283;
					continue;
				default:
					return;
				case 13u:
					break;
				case 8u:
					return;
				}
				break;
			}
		}
	}

	public override void _tiBFUHPEkedkbgvuX3whdeyjhKo(GameTime gameTime_0)
	{
		//IL_0306: Unknown result type (might be due to invalid IL or missing references)
		//IL_030b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Unknown result type (might be due to invalid IL or missing references)
		float float_ = (float)ShootingRangeMiniGameScene.smethod_25(gameTime_0).Milliseconds / 1000f;
		if (_F2ao1gdMb4UciyKC7Zly4by95Mn)
		{
			goto IL_0165;
		}
		goto IL_039b;
		IL_039b:
		int num;
		int num2;
		if (!(_0zKXRrSXqoTAuTYQNrJIgtt7Emq <= 60f))
		{
			num = -165826242;
			num2 = -165826242;
		}
		else
		{
			num = -446647900;
			num2 = -446647900;
		}
		goto IL_031a;
		IL_031a:
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num ^ 0x8D4338F7u) % 24u)
			{
			case 23u:
				_tvM0bxD4ITME03hjc6seyYclzxf._bCjZ3VSXGKyhmykd2zCnQBiSpDf = _TcTPQp3KE5mO2mYA6sSQDbHnhAw.Y - 32;
				_85WqOX8OcxbI6g74CaBZtHiHK2m._7Xn1C5tjYnmIif1iZKV8AWsEEbL = 780f + Math.Min(1f, (float)_TcTPQp3KE5mO2mYA6sSQDbHnhAw.X / 1730f) * 1570f;
				num = (int)((num3 * 754150800) ^ 0x686F8DCB);
				continue;
			case 22u:
				_dxhbACq6BB89IAMy6ZOALWJgv7L = GameState.GameOver;
				num = ((int)num3 * -111404714) ^ 0x47F576F9;
				continue;
			case 21u:
				_8GHK7o3vLmG6sThZNN5JsWHoKkE(float_);
				num = -191946673;
				continue;
			case 20u:
				_85WqOX8OcxbI6g74CaBZtHiHK2m._bCjZ3VSXGKyhmykd2zCnQBiSpDf = 1080f + Math.Min(1f, (float)_TcTPQp3KE5mO2mYA6sSQDbHnhAw.Y / 950f) * 370f;
				num = (int)((num3 * 757032369) ^ 0x1415EDFE);
				continue;
			case 19u:
				break;
			case 17u:
				_M8VVMN3GHWWmFmORCACqNTXVh6b = 4;
				num = (int)((num3 * 537480455) ^ 0x21B59A6E);
				continue;
			case 16u:
				_dxhbACq6BB89IAMy6ZOALWJgv7L = GameState.None;
				_5Z9jaXDcRYm0wNlEm1aTutL9kSH();
				num = ((int)num3 * -994698891) ^ -989843288;
				continue;
			case 15u:
				goto end_IL_031a;
			case 14u:
			{
				int num4;
				int num5;
				if (base._ZzBuoSDMWwerejOO9Goyv2OCKgE._RbWJ7YGnYHCSoD44MRW1h5X6E7E._fy5ebLnmRsRXv9v7RKTFU5CGMaH((Keys)27))
				{
					num4 = -1877582063;
					num5 = -1877582063;
				}
				else
				{
					num4 = -561269298;
					num5 = -561269298;
				}
				num = num4 ^ (int)(num3 * 1324991977);
				continue;
			}
			case 13u:
				switch (_dxhbACq6BB89IAMy6ZOALWJgv7L)
				{
				case GameState.Started:
					break;
				default:
					goto IL_01c2;
				case GameState.NotStarted:
					goto IL_01d4;
				case GameState.GameOver:
					goto IL_01e5;
				}
				goto case 21u;
			case 2u:
				goto IL_01d4;
			case 12u:
				goto IL_01e5;
			case 11u:
				goto IL_01f6;
			case 10u:
				_jj3EwaVU5VqWdkXGZXsxWtQcYOv();
				num = ((int)num3 * -1064811969) ^ -523490479;
				continue;
			case 9u:
				_M8VVMN3GHWWmFmORCACqNTXVh6b = 1;
				num = ((int)num3 * -1261385671) ^ 0x7DA11040;
				continue;
			case 8u:
				num = (int)((num3 * 1915343964) ^ 0x39822BE5);
				continue;
			case 6u:
				goto IL_0262;
			case 5u:
				_FCyUaxF0GIE1r2fyuYC4b4tGqpJ(float_);
				num = (int)((num3 * 1003397237) ^ 0xE1A61DB);
				continue;
			case 4u:
				num = (int)((num3 * 728620873) ^ 0x1EE0FF79);
				continue;
			case 3u:
				_tvM0bxD4ITME03hjc6seyYclzxf._7Xn1C5tjYnmIif1iZKV8AWsEEbL = _TcTPQp3KE5mO2mYA6sSQDbHnhAw.X - 32;
				num = (int)(num3 * 1211536018) ^ -1250202450;
				continue;
			case 1u:
				_M8VVMN3GHWWmFmORCACqNTXVh6b = 2;
				num = (int)(num3 * 748774951) ^ -656195090;
				continue;
			case 0u:
				_TcTPQp3KE5mO2mYA6sSQDbHnhAw = base._ZzBuoSDMWwerejOO9Goyv2OCKgE._vsceSzSIjBy2nZrCxAzKZbUiwLq._2j5HjqIBNOwD2br7yBprKdzVhAK(base._ZzBuoSDMWwerejOO9Goyv2OCKgE._RbWJ7YGnYHCSoD44MRW1h5X6E7E._U7CeYBJ1v1SoUxpX8emsQ9mWl5b);
				num = -1036904372;
				continue;
			case 7u:
				goto IL_039b;
			default:
				{
					base._tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime_0);
					return;
				}
				IL_01e5:
				_g0eYquQ8BcifsIs5UMyAIkXM5paA(float_);
				num = -1765054011;
				continue;
				IL_01d4:
				_fFSom2DrN3XLCdgmD5vZaJmWP7G(float_);
				num = -1765054011;
				continue;
				IL_01c2:
				num = ((int)num3 * -759492730) ^ 0x46CB30F5;
				continue;
			}
			int num6;
			if (_0zKXRrSXqoTAuTYQNrJIgtt7Emq > 0f)
			{
				num = -998368466;
				num6 = -998368466;
			}
			else
			{
				num = -425679487;
				num6 = -425679487;
			}
			continue;
			IL_0262:
			int num7;
			if (_0zKXRrSXqoTAuTYQNrJIgtt7Emq > 0f)
			{
				num = -278980777;
				num7 = -278980777;
			}
			else
			{
				num = -1679251367;
				num7 = -1679251367;
			}
			continue;
			IL_01f6:
			int num8;
			if (_0zKXRrSXqoTAuTYQNrJIgtt7Emq > 30f)
			{
				num = -963822450;
				num8 = -963822450;
			}
			else
			{
				num = -1719278644;
				num8 = -1719278644;
			}
			continue;
			end_IL_031a:
			break;
		}
		goto IL_0165;
		IL_0165:
		num = -1853903327;
		goto IL_031a;
	}

	private void _fFSom2DrN3XLCdgmD5vZaJmWP7G(float float_0)
	{
		if (_eMnDHRem25x38ZqmbzZLc1CLkwlA)
		{
			return;
		}
		while (true)
		{
			int num = 2126087139;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3AA30DAu) % 8u)
				{
				case 6u:
				{
					int num5;
					int num6;
					if (ShootingRangeMiniGameScene.smethod_28(ShootingRangeMiniGameScene.smethod_26(ShootingRangeMiniGameScene.smethod_20((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)), (Keys)82))
					{
						num5 = 1526662430;
						num6 = 1526662430;
					}
					else
					{
						num5 = 220937314;
						num6 = 220937314;
					}
					num = num5 ^ (int)(num2 * 998034304);
					continue;
				}
				case 5u:
					_nHs33RHZMuYhYev0dQ6ic0aHmvO = true;
					ShootingRangeMiniGameScene.smethod_29(_ykeARom1bl7r01BeRXMOSqoJU6o, 1f);
					num = ((int)num2 * -113935016) ^ -798676824;
					continue;
				case 4u:
					_eMnDHRem25x38ZqmbzZLc1CLkwlA = true;
					num = 1077271471;
					continue;
				case 2u:
					_85WqOX8OcxbI6g74CaBZtHiHK2m._hAt3H7isKECkVrQjY4L0hESiqLF(delegate
					{
						_YFr89aAV3UzO9kf7kPKQJilRWED = 6;
						_eMnDHRem25x38ZqmbzZLc1CLkwlA = false;
						while (true)
						{
							int num9 = -1077768501;
							while (true)
							{
								uint num10;
								switch ((num10 = (uint)num9 ^ 0xEFC769F3u) % 5u)
								{
								case 2u:
									_nHs33RHZMuYhYev0dQ6ic0aHmvO = false;
									num9 = ((int)num10 * -1839734008) ^ -1620874817;
									continue;
								case 1u:
									_dxhbACq6BB89IAMy6ZOALWJgv7L = GameState.Started;
									num9 = ((int)num10 * -1110907345) ^ 0x734AE607;
									continue;
								case 0u:
									_5b1aUCG2FfD5yQCBUDAoLZYMu7A(0f, _SeJVPxt5mkxE2oaiV4gLg7Iiar);
									num9 = (int)(num10 * 1298741162) ^ -1424284092;
									continue;
								default:
									return;
								case 4u:
									break;
								case 3u:
									return;
								}
								break;
							}
						}
					});
					num = (int)(num2 * 1663336294) ^ -365844631;
					continue;
				case 1u:
				{
					int num7;
					int num8;
					if (!ShootingRangeMiniGameScene.smethod_27(ShootingRangeMiniGameScene.smethod_26(ShootingRangeMiniGameScene.smethod_20((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)), _PMeRYZJaBCqgB9uADJFP3c14lxq.RightButton))
					{
						num7 = -703412545;
						num8 = -703412545;
					}
					else
					{
						num7 = -1760390603;
						num8 = -1760390603;
					}
					num = num7 ^ ((int)num2 * -1761746813);
					continue;
				}
				case 0u:
				{
					int num3;
					int num4;
					if (ShootingRangeMiniGameScene.smethod_28(ShootingRangeMiniGameScene.smethod_26(ShootingRangeMiniGameScene.smethod_20((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)), (Keys)32))
					{
						num3 = 569860966;
						num4 = 569860966;
					}
					else
					{
						num3 = 1286252909;
						num4 = 1286252909;
					}
					num = num3 ^ (int)(num2 * 1073155721);
					continue;
				}
				default:
					return;
				case 3u:
					break;
				case 7u:
					return;
				}
				break;
			}
		}
	}

	private void _8GHK7o3vLmG6sThZNN5JsWHoKkE(float float_0)
	{
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0330: Unknown result type (might be due to invalid IL or missing references)
		_0zKXRrSXqoTAuTYQNrJIgtt7Emq -= float_0;
		bool flag = default(bool);
		_003C_003Ec__DisplayClass55_0 _003C_003Ec__DisplayClass55_ = default(_003C_003Ec__DisplayClass55_0);
		RailInfo railInfo = default(RailInfo);
		while (true)
		{
			int num = 1237053603;
			while (true)
			{
				int num10;
				int num11;
				uint num2;
				switch ((num2 = (uint)num ^ 0x6F5DC808u) % 10u)
				{
				case 9u:
					ShootingRangeMiniGameScene.smethod_29(_vCjkdRWXT5mvEu0c22Hgh93luLg, 1f);
					num = (int)((num2 * 1681262812) ^ 0x386F5186);
					continue;
				case 8u:
					flag = false;
					num = (int)(num2 * 2136477842) ^ -1795002104;
					continue;
				case 7u:
					_YFr89aAV3UzO9kf7kPKQJilRWED--;
					_nHs33RHZMuYhYev0dQ6ic0aHmvO = true;
					_5b1aUCG2FfD5yQCBUDAoLZYMu7A(0.5f, delegate
					{
						_nHs33RHZMuYhYev0dQ6ic0aHmvO = false;
					});
					_85WqOX8OcxbI6g74CaBZtHiHK2m._e2DHCcfpFNWn5NTzMOw3FBUkwzA();
					num = 1388942457;
					continue;
				case 5u:
					if (!_eMnDHRem25x38ZqmbzZLc1CLkwlA)
					{
						num = ((int)num2 * -940838382) ^ 0xB7E9791;
						continue;
					}
					goto IL_06cb;
				case 3u:
					if (!_nHs33RHZMuYhYev0dQ6ic0aHmvO)
					{
						num = (int)((num2 * 613831625) ^ 0x6084F7FD);
						continue;
					}
					goto IL_06cb;
				case 1u:
				{
					int num12;
					int num13;
					if (_YFr89aAV3UzO9kf7kPKQJilRWED != 0)
					{
						num12 = 1016569341;
						num13 = 1016569341;
					}
					else
					{
						num12 = 1691831600;
						num13 = 1691831600;
					}
					num = num12 ^ ((int)num2 * -73628204);
					continue;
				}
				case 0u:
					if (ShootingRangeMiniGameScene.smethod_27(ShootingRangeMiniGameScene.smethod_26(ShootingRangeMiniGameScene.smethod_20((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)), _PMeRYZJaBCqgB9uADJFP3c14lxq.LeftButton))
					{
						num = ((int)num2 * -868019215) ^ -1457248459;
						continue;
					}
					goto IL_06cb;
				case 6u:
					break;
				default:
				{
					using (List<TargetModel>.Enumerator enumerator = _u8GaIYUzQ65BoFU3NzXBzyvujjbA.GetEnumerator())
					{
						while (true)
						{
							IL_0472:
							int num3;
							int num4;
							if (enumerator.MoveNext())
							{
								num3 = 1894232234;
								num4 = 1894232234;
							}
							else
							{
								num3 = 2082162771;
								num4 = 2082162771;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x6F5DC808u) % 17u)
								{
								case 15u:
								{
									_003C_003Ec__DisplayClass55_._KJWMaoRJ7oaDYXtF5MPjg5DcYwvA = this;
									_003C_003Ec__DisplayClass55_._OJbyketBmeLlVtChfay03TIx5KM = enumerator.Current;
									int num7;
									int num8;
									if (_003C_003Ec__DisplayClass55_._OJbyketBmeLlVtChfay03TIx5KM._ZCfNJ0nxXx3YppgLl5SvS2LkQ5B(_TcTPQp3KE5mO2mYA6sSQDbHnhAw, out _0U2R42Dbf2ddmyfQBv0z7zBWwJm))
									{
										num7 = -1487535705;
										num8 = -1487535705;
									}
									else
									{
										num7 = -1622322390;
										num8 = -1622322390;
									}
									num3 = num7 ^ ((int)num2 * -1491335152);
									continue;
								}
								case 13u:
									_G0GwJ5OWQOA4BjacW3XmFsyMFjz += 10;
									_xaBDiofMkYNdWQ4me0hnZ4NsCnk(_TcTPQp3KE5mO2mYA6sSQDbHnhAw.X, _TcTPQp3KE5mO2mYA6sSQDbHnhAw.Y, "10!", Color.get_Red());
									num3 = ((int)num2 * -2072399446) ^ -1337038236;
									continue;
								case 12u:
								{
									int num9;
									if (_0U2R42Dbf2ddmyfQBv0z7zBWwJm != TargetModel.CollisionType.Bodyshot)
									{
										num3 = 1639353452;
										num9 = 1639353452;
									}
									else
									{
										num3 = 255899726;
										num9 = 255899726;
									}
									continue;
								}
								case 11u:
									_5b1aUCG2FfD5yQCBUDAoLZYMu7A(0f, _SeJVPxt5mkxE2oaiV4gLg7Iiar);
									num3 = (int)((num2 * 1710384669) ^ 0x7134DA25);
									continue;
								case 10u:
									_003C_003Ec__DisplayClass55_._OJbyketBmeLlVtChfay03TIx5KM._kf3EbE0B70xGe1szklqAZyCqoLj = false;
									_003C_003Ec__DisplayClass55_._OJbyketBmeLlVtChfay03TIx5KM._u1yq8F9lG8oMcA9vZO9c7Qbh8vj(_003C_003Ec__DisplayClass55_._RTMgQbRJ6kbTD57eNoEFTTberOT);
									num3 = (int)(num2 * 2079094015) ^ -841564623;
									continue;
								case 9u:
									flag = true;
									num3 = 577544563;
									continue;
								case 8u:
									num3 = ((int)num2 * -1272636163) ^ -989315131;
									continue;
								case 7u:
									ShootingRangeMiniGameScene.smethod_29(_Hsn6Qz2oeKaTkin9XGwBJUJqy1C, 1f);
									num3 = (int)(num2 * 512536726) ^ -876016289;
									continue;
								case 6u:
									_003C_003Ec__DisplayClass55_ = new _003C_003Ec__DisplayClass55_0();
									num3 = 1671516839;
									continue;
								case 5u:
									_C6cjmtLovCejw2N3OZYswcoYxsd++;
									ShootingRangeMiniGameScene.smethod_29(_gabFSY9HcJdPu830plKx8W936qG, 1f);
									_G0GwJ5OWQOA4BjacW3XmFsyMFjz += 30;
									_xaBDiofMkYNdWQ4me0hnZ4NsCnk(_TcTPQp3KE5mO2mYA6sSQDbHnhAw.X, _TcTPQp3KE5mO2mYA6sSQDbHnhAw.Y, "30!", Color.get_Yellow());
									_003C_003Ec__DisplayClass55_._OJbyketBmeLlVtChfay03TIx5KM._kf3EbE0B70xGe1szklqAZyCqoLj = false;
									_003C_003Ec__DisplayClass55_._OJbyketBmeLlVtChfay03TIx5KM._DcBCpcEfsjl4zP1zbrOrd1bwNReb(_003C_003Ec__DisplayClass55_._hrhEHg1BbdqZCbfzTU8MqnmfrKn);
									num3 = (int)((num2 * 261672218) ^ 0x1CF37BAC);
									continue;
								case 4u:
									_5b1aUCG2FfD5yQCBUDAoLZYMu7A(0f, _SeJVPxt5mkxE2oaiV4gLg7Iiar);
									num3 = ((int)num2 * -606283342) ^ 0x4141FF6A;
									continue;
								case 3u:
								{
									_Vu9iV57zUVa3p8WMfOsDaoqv7wL(_TcTPQp3KE5mO2mYA6sSQDbHnhAw.X, _TcTPQp3KE5mO2mYA6sSQDbHnhAw.Y, _003C_003Ec__DisplayClass55_._OJbyketBmeLlVtChfay03TIx5KM._fO7gSlrDDNMoHR4FO5QXAq8fUyA);
									int num5;
									int num6;
									if (_0U2R42Dbf2ddmyfQBv0z7zBWwJm == TargetModel.CollisionType.Headshot)
									{
										num5 = 226808778;
										num6 = 226808778;
									}
									else
									{
										num5 = 1860760170;
										num6 = 1860760170;
									}
									num3 = num5 ^ ((int)num2 * -1828768784);
									continue;
								}
								case 1u:
									_pL6aoe4HLq4X3yQACLFyUH3xwBp++;
									num3 = (int)((num2 * 1358827954) ^ 0x43170B0F);
									continue;
								case 0u:
									num3 = 1894232234;
									continue;
								default:
									goto end_IL_040c;
								case 16u:
									break;
								case 2u:
									goto end_IL_040c;
								case 14u:
									goto end_IL_040c;
								}
								goto IL_0472;
								continue;
								end_IL_040c:
								break;
							}
							break;
						}
					}
					if (!flag)
					{
						goto IL_05b9;
					}
					goto IL_06cb;
				}
				case 4u:
					{
						ShootingRangeMiniGameScene.smethod_29(_RiMZpLLSGIesSXF8vhSlVQ8SrDg, 1f);
						goto IL_06cb;
					}
					IL_06cb:
					if (_eMnDHRem25x38ZqmbzZLc1CLkwlA)
					{
						num10 = 1313193272;
						num11 = 1313193272;
					}
					else
					{
						num10 = 894138368;
						num11 = 894138368;
					}
					goto IL_0675;
					IL_0675:
					while (true)
					{
						switch ((num2 = (uint)num10 ^ 0x6F5DC808u) % 13u)
						{
						case 12u:
							railInfo = _HYME5rEMzi5Cag9e7DCXk5lrXwX.FirstOrDefault((RailInfo railInfo_0) => _TcTPQp3KE5mO2mYA6sSQDbHnhAw.Y < railInfo_0._bCjZ3VSXGKyhmykd2zCnQBiSpDf);
							num10 = ((int)num2 * -2077403424) ^ 0xD23DF59;
							continue;
						case 11u:
							_eMnDHRem25x38ZqmbzZLc1CLkwlA = true;
							num10 = 609219670;
							continue;
						case 9u:
							_nHs33RHZMuYhYev0dQ6ic0aHmvO = true;
							ShootingRangeMiniGameScene.smethod_29(_ykeARom1bl7r01BeRXMOSqoJU6o, 1f);
							num10 = (int)((num2 * 1468510194) ^ 0x57C77470);
							continue;
						case 8u:
							_Kp1esj4V82aePkZwvlresNSkHsC(_TcTPQp3KE5mO2mYA6sSQDbHnhAw.X, _TcTPQp3KE5mO2mYA6sSQDbHnhAw.Y, railInfo?._fO7gSlrDDNMoHR4FO5QXAq8fUyA ?? 1f);
							num10 = 1757010549;
							continue;
						case 6u:
						{
							int num16;
							int num17;
							if (ShootingRangeMiniGameScene.smethod_27(ShootingRangeMiniGameScene.smethod_26(ShootingRangeMiniGameScene.smethod_20((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)), _PMeRYZJaBCqgB9uADJFP3c14lxq.RightButton))
							{
								num16 = 1157180895;
								num17 = 1157180895;
							}
							else
							{
								num16 = 1190337456;
								num17 = 1190337456;
							}
							num10 = num16 ^ (int)(num2 * 1381235957);
							continue;
						}
						case 5u:
							ShootingRangeMiniGameScene.smethod_29(_Oeqego17TDqmByfLbOEB1isMXzJ, 1f);
							num10 = (int)(num2 * 376125630) ^ -1872221337;
							continue;
						case 4u:
							break;
						case 3u:
							_dH7hlTzeJboGa5rfpgerBfCmyKO++;
							num10 = (int)((num2 * 904420892) ^ 0x4003CA45);
							continue;
						case 2u:
						{
							int num18;
							int num19;
							if (!ShootingRangeMiniGameScene.smethod_28(ShootingRangeMiniGameScene.smethod_26(ShootingRangeMiniGameScene.smethod_20((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)), (Keys)32))
							{
								num18 = 87713520;
								num19 = 87713520;
							}
							else
							{
								num18 = 537960895;
								num19 = 537960895;
							}
							num10 = num18 ^ (int)(num2 * 1832656762);
							continue;
						}
						case 1u:
							_85WqOX8OcxbI6g74CaBZtHiHK2m._hAt3H7isKECkVrQjY4L0hESiqLF(delegate
							{
								_YFr89aAV3UzO9kf7kPKQJilRWED = 6;
								while (true)
								{
									int num20 = -603792966;
									while (true)
									{
										uint num21;
										switch ((num21 = (uint)num20 ^ 0x86A28899u) % 4u)
										{
										case 3u:
											_eMnDHRem25x38ZqmbzZLc1CLkwlA = false;
											num20 = (int)((num21 * 2078410792) ^ 0x62D2AEB7);
											continue;
										case 2u:
											_nHs33RHZMuYhYev0dQ6ic0aHmvO = false;
											num20 = ((int)num21 * -295697507) ^ 0x706E909A;
											continue;
										default:
											return;
										case 0u:
											break;
										case 1u:
											return;
										}
										break;
									}
								}
							});
							num10 = ((int)num2 * -647583061) ^ 0x29B6F2B4;
							continue;
						case 0u:
						{
							int num14;
							int num15;
							if (ShootingRangeMiniGameScene.smethod_28(ShootingRangeMiniGameScene.smethod_26(ShootingRangeMiniGameScene.smethod_20((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)), (Keys)82))
							{
								num14 = -1558943209;
								num15 = -1558943209;
							}
							else
							{
								num14 = -626689572;
								num15 = -626689572;
							}
							num10 = num14 ^ (int)(num2 * 1934532486);
							continue;
						}
						default:
							return;
						case 7u:
							goto IL_06cb;
						case 10u:
							return;
						}
						break;
					}
					goto IL_05b9;
					IL_05b9:
					num10 = 1627807915;
					goto IL_0675;
				}
				break;
			}
		}
	}

	private void _SeJVPxt5mkxE2oaiV4gLg7Iiar()
	{
		if (_dxhbACq6BB89IAMy6ZOALWJgv7L == GameState.Started)
		{
			goto IL_000b;
		}
		goto IL_003c;
		IL_000b:
		int num = _u8GaIYUzQ65BoFU3NzXBzyvujjbA.Count((TargetModel targetModel_0) => targetModel_0._kf3EbE0B70xGe1szklqAZyCqoLj);
		int num2 = -1118877618;
		goto IL_0081;
		IL_003c:
		num2 = -1911504660;
		goto IL_0081;
		IL_0081:
		int num4 = default(int);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0x8B4201DFu) % 8u)
			{
			case 2u:
				break;
			case 6u:
				num4++;
				num2 = (int)((num3 * 22910919) ^ 0x4A56E2B1);
				continue;
			case 5u:
				goto IL_003c;
			case 4u:
				goto IL_0043;
			case 1u:
				num4 = num;
				num2 = ((int)num3 * -755151477) ^ 0x234A2B08;
				continue;
			case 0u:
				_OLpKeyCIa9e3g4oTFOGxKKmVbHJ();
				num2 = -1478789839;
				continue;
			default:
				return;
			case 3u:
				return;
			case 7u:
				return;
			}
			break;
			IL_0043:
			int num5;
			if (num4 < _M8VVMN3GHWWmFmORCACqNTXVh6b)
			{
				num2 = -432023553;
				num5 = -432023553;
			}
			else
			{
				num2 = -532938592;
				num5 = -532938592;
			}
		}
		goto IL_000b;
	}

	private void _OLpKeyCIa9e3g4oTFOGxKKmVbHJ()
	{
		TargetModel _OJbyketBmeLlVtChfay03TIx5KM = default(TargetModel);
		ShootingRangeMiniGameScene _KJWMaoRJ7oaDYXtF5MPjg5DcYwvA = default(ShootingRangeMiniGameScene);
		RailInfo railInfo = default(RailInfo);
		while (true)
		{
			int num = 974179251;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x74348551u) % 6u)
				{
				case 5u:
					_u8GaIYUzQ65BoFU3NzXBzyvujjbA = _u8GaIYUzQ65BoFU3NzXBzyvujjbA.OrderByDescending((TargetModel targetModel_0) => targetModel_0._ac2H6kMdrgPhXXxabsikjji4SiT).ToList();
					_5b1aUCG2FfD5yQCBUDAoLZYMu7A(3.5f, delegate
					{
						if (_OJbyketBmeLlVtChfay03TIx5KM._kf3EbE0B70xGe1szklqAZyCqoLj)
						{
							while (true)
							{
								int num3 = -810458849;
								while (true)
								{
									uint num4;
									switch ((num4 = (uint)num3 ^ 0xD6A1C6C6u) % 7u)
									{
									case 6u:
										_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._JvgphfrWtBncPfgb6ERRVKKtlQG++;
										num3 = -414805271;
										continue;
									case 5u:
										_OJbyketBmeLlVtChfay03TIx5KM._kf3EbE0B70xGe1szklqAZyCqoLj = false;
										num3 = ((int)num4 * -598490878) ^ -1200048786;
										continue;
									case 4u:
									{
										int num5;
										int num6;
										if (_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._dxhbACq6BB89IAMy6ZOALWJgv7L != GameState.GameOver)
										{
											num5 = -1486339206;
											num6 = -1486339206;
										}
										else
										{
											num5 = -1443175717;
											num6 = -1443175717;
										}
										num3 = num5 ^ (int)(num4 * 816594347);
										continue;
									}
									case 2u:
										_OJbyketBmeLlVtChfay03TIx5KM._u1yq8F9lG8oMcA9vZO9c7Qbh8vj(delegate
										{
											_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._5b1aUCG2FfD5yQCBUDAoLZYMu7A(0f, delegate
											{
												_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._PFrgvj2zYkmkbPmVfpiUnTvLsoC(_OJbyketBmeLlVtChfay03TIx5KM);
											});
										});
										_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._5b1aUCG2FfD5yQCBUDAoLZYMu7A(0f, _KJWMaoRJ7oaDYXtF5MPjg5DcYwvA._SeJVPxt5mkxE2oaiV4gLg7Iiar);
										num3 = -1552786114;
										continue;
									default:
										return;
									case 3u:
										break;
									case 0u:
										return;
									case 1u:
										return;
									}
									break;
								}
							}
						}
					});
					num = 2037573582;
					continue;
				case 4u:
					_KJWMaoRJ7oaDYXtF5MPjg5DcYwvA = this;
					num = ((int)num2 * -1293913052) ^ -449906389;
					continue;
				case 2u:
					railInfo = _HYME5rEMzi5Cag9e7DCXk5lrXwX[ShootingRangeMiniGameScene.smethod_30(0, _HYME5rEMzi5Cag9e7DCXk5lrXwX.Length)];
					num = ((int)num2 * -1011471720) ^ -969432427;
					continue;
				case 0u:
				{
					int int_ = ShootingRangeMiniGameScene.smethod_30(railInfo._SjhHztt8d5kOtb7Z2BJKnZZxEKh, railInfo._nVnyJkkce6HsdRrKSpRrzUDElg0);
					_OJbyketBmeLlVtChfay03TIx5KM = new TargetModel(this, int_, railInfo._bCjZ3VSXGKyhmykd2zCnQBiSpDf, railInfo._fO7gSlrDDNMoHR4FO5QXAq8fUyA)
					{
						_kf3EbE0B70xGe1szklqAZyCqoLj = true
					};
					_OJbyketBmeLlVtChfay03TIx5KM._edcakvTOp2fd2J9ZHAu9GKjDaN7();
					_u8GaIYUzQ65BoFU3NzXBzyvujjbA.Add(_OJbyketBmeLlVtChfay03TIx5KM);
					_7oYtfGpL7UyAQrZxew7Ahbvj6Sv(_OJbyketBmeLlVtChfay03TIx5KM, railInfo._dPmC8tBC0iph2YBAFmztEsmwUdSA);
					num = ((int)num2 * -941274026) ^ -1656026356;
					continue;
				}
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

	private void _PFrgvj2zYkmkbPmVfpiUnTvLsoC(TargetModel targetModel_0)
	{
		_u8GaIYUzQ65BoFU3NzXBzyvujjbA.Remove(targetModel_0);
		ShootingRangeMiniGameScene.smethod_31((_7UlnfykmEmZDFt3BmCKZekI43Ih)this).Remove(targetModel_0);
	}

	private void _g0eYquQ8BcifsIs5UMyAIkXM5paA(float float_0)
	{
		if (ShootingRangeMiniGameScene.smethod_28(ShootingRangeMiniGameScene.smethod_26(ShootingRangeMiniGameScene.smethod_20((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)), (Keys)13))
		{
			goto IL_0026;
		}
		goto IL_00a7;
		IL_00a7:
		int num;
		int num2;
		if (ShootingRangeMiniGameScene.smethod_28(ShootingRangeMiniGameScene.smethod_26(ShootingRangeMiniGameScene.smethod_20((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)), (Keys)27))
		{
			num = 2048198400;
			num2 = 2048198400;
		}
		else
		{
			num = 151570397;
			num2 = 151570397;
		}
		goto IL_006b;
		IL_006b:
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num ^ 0x7D514735u) % 7u)
			{
			case 6u:
				break;
			case 4u:
				_dxhbACq6BB89IAMy6ZOALWJgv7L = GameState.None;
				num = ((int)num3 * -1699987960) ^ -1777015951;
				continue;
			case 1u:
				_haICL4qkfkOLhPhofWQH1GmjZx5();
				num = (int)(num3 * 555179259) ^ -1099272575;
				continue;
			case 0u:
				_5Z9jaXDcRYm0wNlEm1aTutL9kSH();
				num = (int)(num3 * 2114586818) ^ -2021261563;
				continue;
			default:
				return;
			case 3u:
				goto IL_00a7;
			case 2u:
				return;
			case 5u:
				return;
			}
			break;
		}
		goto IL_0026;
		IL_0026:
		num = 927046127;
		goto IL_006b;
	}

	protected abstract void _5Z9jaXDcRYm0wNlEm1aTutL9kSH();

	private void _haICL4qkfkOLhPhofWQH1GmjZx5()
	{
		_0zKXRrSXqoTAuTYQNrJIgtt7Emq = 90f;
		_G0GwJ5OWQOA4BjacW3XmFsyMFjz = 0;
		TargetModel current = default(TargetModel);
		while (true)
		{
			int num = -290080841;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEAD72CC0u) % 7u)
				{
				case 5u:
					_xEG3axnWkco0Erk0PdjakXDULcA.Clear();
					num = (int)(num2 * 989954852) ^ -732331639;
					continue;
				case 4u:
					_pL6aoe4HLq4X3yQACLFyUH3xwBp = 0;
					_YFr89aAV3UzO9kf7kPKQJilRWED = 0;
					num = (int)((num2 * 1176194637) ^ 0x7CC8E5FB);
					continue;
				case 3u:
					_d9mstkVrU6KGDJyOtHGgrr2ZciA.Clear();
					num = ((int)num2 * -1250598540) ^ 0x245F2C6;
					continue;
				case 2u:
					_dH7hlTzeJboGa5rfpgerBfCmyKO = 0;
					_C6cjmtLovCejw2N3OZYswcoYxsd = 0;
					num = ((int)num2 * -2097021659) ^ -2034552623;
					continue;
				case 1u:
					_JvgphfrWtBncPfgb6ERRVKKtlQG = 0;
					num = ((int)num2 * -1134872096) ^ -1305706849;
					continue;
				case 0u:
					break;
				default:
				{
					using (List<TargetModel>.Enumerator enumerator = _u8GaIYUzQ65BoFU3NzXBzyvujjbA.GetEnumerator())
					{
						while (true)
						{
							IL_014a:
							int num3;
							int num4;
							if (!enumerator.MoveNext())
							{
								num3 = -634752928;
								num4 = -634752928;
							}
							else
							{
								num3 = -1404962019;
								num4 = -1404962019;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xEAD72CC0u) % 5u)
								{
								case 2u:
									ShootingRangeMiniGameScene.smethod_31((_7UlnfykmEmZDFt3BmCKZekI43Ih)this).Remove(current);
									num3 = (int)(num2 * 555779618) ^ -995572484;
									continue;
								case 1u:
									current = enumerator.Current;
									num3 = -1029348104;
									continue;
								case 0u:
									num3 = -1404962019;
									continue;
								default:
									goto end_IL_0119;
								case 4u:
									break;
								case 3u:
									goto end_IL_0119;
								}
								goto IL_014a;
								continue;
								end_IL_0119:
								break;
							}
							break;
						}
					}
					_u8GaIYUzQ65BoFU3NzXBzyvujjbA.Clear();
					while (true)
					{
						int num5 = -280376025;
						while (true)
						{
							switch ((num2 = (uint)num5 ^ 0xEAD72CC0u) % 3u)
							{
							case 1u:
								goto IL_0172;
							default:
								return;
							case 2u:
								break;
							case 0u:
								return;
							}
							break;
							IL_0172:
							_dxhbACq6BB89IAMy6ZOALWJgv7L = GameState.NotStarted;
							num5 = ((int)num2 * -1714776228) ^ -1870991018;
						}
					}
				}
				}
				break;
			}
		}
	}

	public override void _f5ctqAmdNsZ889UjM4LxDm8WGxA(SpriteBatch spriteBatch_0, SkeletonMeshRenderer skeletonMeshRenderer_0, Matrix matrix_0)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Unknown result type (might be due to invalid IL or missing references)
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		//IL_0367: Unknown result type (might be due to invalid IL or missing references)
		//IL_036c: Unknown result type (might be due to invalid IL or missing references)
		//IL_039d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0417: Unknown result type (might be due to invalid IL or missing references)
		//IL_0426: Unknown result type (might be due to invalid IL or missing references)
		//IL_0430: Unknown result type (might be due to invalid IL or missing references)
		//IL_0438: Unknown result type (might be due to invalid IL or missing references)
		this.method_0(spriteBatch_0, skeletonMeshRenderer_0, matrix_0);
		ShootingRangeMiniGameScene.smethod_32(spriteBatch_0);
		_LSweOA3cIPq1IjLzplF4mDludQf(spriteBatch_0);
		int num3 = default(int);
		int num4 = default(int);
		GameState dxhbACq6BB89IAMy6ZOALWJgv7L = default(GameState);
		while (true)
		{
			int num = 1239255257;
			while (true)
			{
				uint num2;
				int num5;
				switch ((num2 = (uint)num ^ 0x4D252229u) % 25u)
				{
				case 24u:
				{
					int num8;
					int num9;
					if (_0zKXRrSXqoTAuTYQNrJIgtt7Emq > 10f)
					{
						num8 = -1103010665;
						num9 = -1103010665;
					}
					else
					{
						num8 = -332167384;
						num9 = -332167384;
					}
					num = num8 ^ (int)(num2 * 1032432190);
					continue;
				}
				case 23u:
					num = ((int)num2 * -1128812040) ^ 0x276CCCE8;
					continue;
				case 22u:
					spriteBatch_0.End();
					num = 304725206;
					continue;
				case 21u:
					num = (int)((num2 * 556529440) ^ 0x5031E841);
					continue;
				case 19u:
					spriteBatch_0.DrawString(_MnMUFBDfrGZBHvrJ30IAQilqivI, "Press <Space/R/Mouse-R> to Reload and begin.", new Vector2((1920f - _YhybMVqCJnFekEXVbF1huXupDmh) / 2f, 10f), Color.get_Red());
					num = 1578771551;
					continue;
				case 18u:
					num = ((int)num2 * -1389303595) ^ 0x69FE4CC5;
					continue;
				case 17u:
					goto IL_00cf;
				case 16u:
					num3 = 5;
					num4 = 0;
					num = (int)((num2 * 757732161) ^ 0x1CDDF811);
					continue;
				case 15u:
				{
					int num10;
					if (num3 >= 0)
					{
						num = 1162219703;
						num10 = 1162219703;
					}
					else
					{
						num = 725970021;
						num10 = 725970021;
					}
					continue;
				}
				case 14u:
					spriteBatch_0.DrawString(_6YCQhlMaqcDds8uGX1g8fjBKqV4A, "Headshots: " + _C6cjmtLovCejw2N3OZYswcoYxsd, new Vector2(10f, 120f), Color.get_White());
					num = (int)((num2 * 409492433) ^ 0x170601CA);
					continue;
				case 13u:
					spriteBatch_0.DrawString(_MnMUFBDfrGZBHvrJ30IAQilqivI, _0zKXRrSXqoTAuTYQNrJIgtt7Emq.ToString("F1"), new Vector2(960f, 10f), Color.get_Red());
					num = (int)((num2 * 460806256) ^ 0x38634031);
					continue;
				case 12u:
					spriteBatch_0.DrawString(_MnMUFBDfrGZBHvrJ30IAQilqivI, "Reload!", new Vector2(1750f, 70f), Color.get_Red());
					num = ((int)num2 * -44432714) ^ 0x3BA4F100;
					continue;
				case 11u:
					switch (dxhbACq6BB89IAMy6ZOALWJgv7L)
					{
					case GameState.NotStarted:
						break;
					case GameState.Started:
						goto IL_00cf;
					default:
						goto IL_0205;
					case GameState.GameOver:
						goto IL_0217;
					}
					goto case 19u;
				case 9u:
					goto IL_0217;
				case 10u:
					spriteBatch_0.DrawString(_6YCQhlMaqcDds8uGX1g8fjBKqV4A, "Bodyshots: " + _pL6aoe4HLq4X3yQACLFyUH3xwBp, new Vector2(10f, 100f), Color.get_White());
					num = ((int)num2 * -1587234983) ^ 0x6A804116;
					continue;
				case 8u:
					num3--;
					num = ((int)num2 * -1930910592) ^ 0x43442D4C;
					continue;
				case 7u:
				{
					int num6;
					int num7;
					if (_YFr89aAV3UzO9kf7kPKQJilRWED != 0)
					{
						num6 = -200492216;
						num7 = -200492216;
					}
					else
					{
						num6 = -1832750761;
						num7 = -1832750761;
					}
					num = num6 ^ (int)(num2 * 1813437383);
					continue;
				}
				case 6u:
					spriteBatch_0.DrawString(_MnMUFBDfrGZBHvrJ30IAQilqivI, _0zKXRrSXqoTAuTYQNrJIgtt7Emq.ToString("F0"), new Vector2(960f, 10f), Color.get_White());
					num = 359117373;
					continue;
				case 4u:
					num4++;
					num = ((int)num2 * -1393310727) ^ -1082454219;
					continue;
				case 3u:
					dxhbACq6BB89IAMy6ZOALWJgv7L = _dxhbACq6BB89IAMy6ZOALWJgv7L;
					num = 1328760285;
					continue;
				case 2u:
					spriteBatch_0.DrawString(_MnMUFBDfrGZBHvrJ30IAQilqivI, "Score: " + _G0GwJ5OWQOA4BjacW3XmFsyMFjz, new Vector2(10f, 10f), Color.get_White());
					spriteBatch_0.DrawString(_6YCQhlMaqcDds8uGX1g8fjBKqV4A, "Targets missed: " + _JvgphfrWtBncPfgb6ERRVKKtlQG, new Vector2(10f, 60f), Color.get_White());
					spriteBatch_0.DrawString(_6YCQhlMaqcDds8uGX1g8fjBKqV4A, "Shots missed: " + _dH7hlTzeJboGa5rfpgerBfCmyKO, new Vector2(10f, 80f), Color.get_White());
					num = ((int)num2 * -805003029) ^ -1361015719;
					continue;
				case 1u:
					num = ((int)num2 * -1019237192) ^ -2031640399;
					continue;
				case 0u:
					spriteBatch_0.Draw(_m1dNhD2jwJ6iTVUgUzMJUvnQFS, new Rectangle(1875 - 35 * num3, 10, 30, 55), (num4 < _YFr89aAV3UzO9kf7kPKQJilRWED) ? _AWLddj1Rm2sqiBwYcJDngG0QaQI : (_AWLddj1Rm2sqiBwYcJDngG0QaQI * 0.5f));
					num = 971993800;
					continue;
				default:
					return;
				case 20u:
					break;
				case 5u:
					return;
					IL_00cf:
					if (_0zKXRrSXqoTAuTYQNrJIgtt7Emq >= 0f)
					{
						num = 1984145438;
						num5 = 1984145438;
					}
					else
					{
						num = 541740129;
						num5 = 541740129;
					}
					continue;
					IL_0217:
					spriteBatch_0.DrawString(_MnMUFBDfrGZBHvrJ30IAQilqivI, "Time up, game over! Press <Enter> to retry or <Escape> to continue.", new Vector2((1920f - _MZh3nVRuDktDpIu8X149SF90ZjO) / 2f, 10f), Color.get_Red());
					num = 541740129;
					continue;
					IL_0205:
					num = ((int)num2 * -1487906456) ^ 0x2E5421A0;
					continue;
				}
				break;
			}
		}
	}

	public override void _tO46aYSBLFIuhFNlhbrAeWbFDSf()
	{
		this.method_1();
		while (true)
		{
			int num = 333146285;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x51D393B4u) % 4u)
				{
				case 1u:
					ShootingRangeMiniGameScene.smethod_15(ShootingRangeMiniGameScene.smethod_20((_7UlnfykmEmZDFt3BmCKZekI43Ih)this), _WD4Plg5m1AwZ5mVyjQCADcW1ZTk);
					num = ((int)num2 * -161076517) ^ 0x2E0D69A7;
					continue;
				case 0u:
					_poenyHBGUusBcnNcTFB9MQBV72R._kf3EbE0B70xGe1szklqAZyCqoLj = _U8eNAZVBW15ZflhG4fel0hK3Juu;
					num = (int)((num2 * 848738329) ^ 0x4DA2F75B);
					continue;
				default:
					return;
				case 2u:
					break;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	private void _FCyUaxF0GIE1r2fyuYC4b4tGqpJ(float float_0)
	{
		if (_d9mstkVrU6KGDJyOtHGgrr2ZciA.Any())
		{
			using (List<IDrawable>.Enumerator enumerator = _d9mstkVrU6KGDJyOtHGgrr2ZciA.GetEnumerator())
			{
				while (true)
				{
					IL_007b:
					int num;
					int num2;
					if (!enumerator.MoveNext())
					{
						num = 1808111412;
						num2 = 1808111412;
					}
					else
					{
						num = 2102871921;
						num2 = 2102871921;
					}
					while (true)
					{
						uint num3;
						switch ((num3 = (uint)num ^ 0x5A6C9D53u) % 4u)
						{
						case 2u:
						{
							IDrawable current = enumerator.Current;
							_xEG3axnWkco0Erk0PdjakXDULcA.Remove(current);
							num = 1779370594;
							continue;
						}
						case 0u:
							num = 2102871921;
							continue;
						default:
							goto end_IL_004d;
						case 1u:
							break;
						case 3u:
							goto end_IL_004d;
						}
						goto IL_007b;
						continue;
						end_IL_004d:
						break;
					}
					break;
				}
			}
			_d9mstkVrU6KGDJyOtHGgrr2ZciA.Clear();
		}
		using List<IDrawable>.Enumerator enumerator2 = _xEG3axnWkco0Erk0PdjakXDULcA.ToList().GetEnumerator();
		IDrawable current2 = default(IDrawable);
		while (true)
		{
			int num4;
			int num5;
			if (!enumerator2.MoveNext())
			{
				num4 = 198479609;
				num5 = 198479609;
			}
			else
			{
				num4 = 899814000;
				num5 = 899814000;
			}
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num4 ^ 0x5A6C9D53u) % 6u)
				{
				case 5u:
					current2._tiBFUHPEkedkbgvuX3whdeyjhKo(float_0);
					num4 = 1131318532;
					continue;
				case 3u:
				{
					current2 = enumerator2.Current;
					int num6;
					if (current2._aeQckZZROopp0BqagEZE32fzkyr)
					{
						num4 = 386028677;
						num6 = 386028677;
					}
					else
					{
						num4 = 1790300980;
						num6 = 1790300980;
					}
					continue;
				}
				case 2u:
					_d9mstkVrU6KGDJyOtHGgrr2ZciA.Add(current2);
					num4 = ((int)num3 * -1111165590) ^ -544215656;
					continue;
				case 0u:
					num4 = 899814000;
					continue;
				default:
					return;
				case 1u:
					break;
				case 4u:
					return;
				}
				break;
			}
		}
	}

	private void _LSweOA3cIPq1IjLzplF4mDludQf(SpriteBatch spriteBatch_0)
	{
		using List<IDrawable>.Enumerator enumerator = _xEG3axnWkco0Erk0PdjakXDULcA.GetEnumerator();
		while (true)
		{
			int num;
			int num2;
			if (!enumerator.MoveNext())
			{
				num = 406332870;
				num2 = 406332870;
			}
			else
			{
				num = 957914195;
				num2 = 957914195;
			}
			while (true)
			{
				switch ((uint)(num ^ 0x3087076A) % 4u)
				{
				case 3u:
					num = 957914195;
					continue;
				case 1u:
				{
					IDrawable current = enumerator.Current;
					current._f5ctqAmdNsZ889UjM4LxDm8WGxA(spriteBatch_0);
					num = 1367750364;
					continue;
				}
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	private void _Vu9iV57zUVa3p8WMfOsDaoqv7wL(int int_0, int int_1, float float_0)
	{
		FrameAnimation frameAnimation = new FrameAnimation(this, "Assets/Scenes/ShootingRange/Explosion_12x1", 0.5f, 12, 125, 111, float_0);
		frameAnimation._QrgbXEg7MMeD9Ybz12fFVsbmAd9(int_0, int_1, ShootingRangeMiniGameScene.smethod_33(0f, 360f));
		while (true)
		{
			int num = -1035594255;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFBEE9F5Du) % 3u)
				{
				case 1u:
					goto IL_0032;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_0032:
				_xEG3axnWkco0Erk0PdjakXDULcA.Add(frameAnimation);
				num = (int)((num2 * 1320198444) ^ 0x3D2B27D8);
			}
		}
	}

	private void _Kp1esj4V82aePkZwvlresNSkHsC(int int_0, int int_1, float float_0)
	{
		FrameAnimation frameAnimation = new FrameAnimation(this, "Assets/Scenes/ShootingRange/Smoke_12x1", 0.5f, 12, 122, 129, float_0);
		frameAnimation._QrgbXEg7MMeD9Ybz12fFVsbmAd9(int_0, int_1, 0f);
		while (true)
		{
			int num = 710974829;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF698B8Au) % 3u)
				{
				case 2u:
					goto IL_002b;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_002b:
				_xEG3axnWkco0Erk0PdjakXDULcA.Add(frameAnimation);
				num = ((int)num2 * -1746689839) ^ 0x12B895E5;
			}
		}
	}

	private void _xaBDiofMkYNdWQ4me0hnZ4NsCnk(int int_0, int int_1, string string_0, Color color_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		FloatingFeedbackDrawable item = new FloatingFeedbackDrawable(this, int_0, int_1, string_0, color_0);
		while (true)
		{
			int num = -1604522608;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9FCF5F8Bu) % 3u)
				{
				case 1u:
					goto IL_000e;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_000e:
				_xEG3axnWkco0Erk0PdjakXDULcA.Add(item);
				num = ((int)num2 * -1622165292) ^ 0x61242C4A;
			}
		}
	}

	private void _5b1aUCG2FfD5yQCBUDAoLZYMu7A(float float_0, Action action_0 = null)
	{
		TimedDrawable item = new TimedDrawable(float_0, action_0);
		_xEG3axnWkco0Erk0PdjakXDULcA.Add(item);
	}

	private void _jj3EwaVU5VqWdkXGZXsxWtQcYOv()
	{
		if (_G0GwJ5OWQOA4BjacW3XmFsyMFjz > 2500)
		{
			goto IL_004a;
		}
		goto IL_014d;
		IL_014d:
		int num;
		int num2;
		if (_C6cjmtLovCejw2N3OZYswcoYxsd > 60)
		{
			num = 1743226788;
			num2 = 1743226788;
		}
		else
		{
			num = 1179166581;
			num2 = 1179166581;
		}
		goto IL_0108;
		IL_0108:
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num ^ 0x5DE77678u) % 9u)
			{
			case 7u:
				ShootingRangeMiniGameScene.smethod_35(ShootingRangeMiniGameScene.smethod_34(ShootingRangeMiniGameScene.smethod_20((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)), "AchievementGeneric10");
				num = (int)(num3 * 801326306) ^ -1181297310;
				continue;
			case 5u:
				break;
			case 4u:
				goto IL_0054;
			case 3u:
				goto IL_0078;
			case 2u:
				ShootingRangeMiniGameScene.smethod_35(ShootingRangeMiniGameScene.smethod_34(ShootingRangeMiniGameScene.smethod_20((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)), "AchievementGeneric9");
				num = ((int)num3 * -1919105674) ^ 0xF4FE4F3;
				continue;
			case 1u:
				ShootingRangeMiniGameScene.smethod_35(ShootingRangeMiniGameScene.smethod_34(ShootingRangeMiniGameScene.smethod_20((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)), "AchievementGeneric7");
				num = (int)(num3 * 1817726114) ^ -972106761;
				continue;
			case 0u:
				ShootingRangeMiniGameScene.smethod_35(ShootingRangeMiniGameScene.smethod_34(ShootingRangeMiniGameScene.smethod_20((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)), "AchievementGeneric8");
				num = ((int)num3 * -254701329) ^ 0x25C12B11;
				continue;
			default:
				return;
			case 6u:
				goto IL_014d;
			case 8u:
				return;
			}
			break;
			IL_0078:
			int num4;
			if (_JvgphfrWtBncPfgb6ERRVKKtlQG < 30)
			{
				num = 35074270;
				num4 = 35074270;
			}
			else
			{
				num = 1992467438;
				num4 = 1992467438;
			}
			continue;
			IL_0054:
			int num5;
			if (_dH7hlTzeJboGa5rfpgerBfCmyKO == 0)
			{
				num = 281024809;
				num5 = 281024809;
			}
			else
			{
				num = 1417494693;
				num5 = 1417494693;
			}
		}
		goto IL_004a;
		IL_004a:
		num = 2114315116;
		goto IL_0108;
	}

	[CompilerGenerated]
	private void _CLBmDtQD8GSfHJi3Lio90WX7I5b()
	{
		_YFr89aAV3UzO9kf7kPKQJilRWED = 6;
		_eMnDHRem25x38ZqmbzZLc1CLkwlA = false;
		while (true)
		{
			int num = -1077768501;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xEFC769F3u) % 5u)
				{
				case 2u:
					_nHs33RHZMuYhYev0dQ6ic0aHmvO = false;
					num = ((int)num2 * -1839734008) ^ -1620874817;
					continue;
				case 1u:
					_dxhbACq6BB89IAMy6ZOALWJgv7L = GameState.Started;
					num = ((int)num2 * -1110907345) ^ 0x734AE607;
					continue;
				case 0u:
					_5b1aUCG2FfD5yQCBUDAoLZYMu7A(0f, _SeJVPxt5mkxE2oaiV4gLg7Iiar);
					num = (int)(num2 * 1298741162) ^ -1424284092;
					continue;
				default:
					return;
				case 4u:
					break;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	[CompilerGenerated]
	private void _EW26J2sSnsOIUpghByCO8pofvme()
	{
		_nHs33RHZMuYhYev0dQ6ic0aHmvO = false;
	}

	[CompilerGenerated]
	private bool _p7I8EFIr5LBXdItOeFhgKxXbz7H(RailInfo railInfo_0)
	{
		return _TcTPQp3KE5mO2mYA6sSQDbHnhAw.Y < railInfo_0._bCjZ3VSXGKyhmykd2zCnQBiSpDf;
	}

	[CompilerGenerated]
	private void _Jo8vcg7RV32DgHkCCWnHeDFNMgV()
	{
		_YFr89aAV3UzO9kf7kPKQJilRWED = 6;
		while (true)
		{
			int num = -603792966;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x86A28899u) % 4u)
				{
				case 3u:
					_eMnDHRem25x38ZqmbzZLc1CLkwlA = false;
					num = (int)((num2 * 2078410792) ^ 0x62D2AEB7);
					continue;
				case 2u:
					_nHs33RHZMuYhYev0dQ6ic0aHmvO = false;
					num = ((int)num2 * -295697507) ^ 0x706E909A;
					continue;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
			}
		}
	}

	static bool smethod_14(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		return _JbeCmOie0phb2cbgG6DdGZrbs3pB_0._LWcoDwIWvf8DT3nQmNe5z8fkUvI;
	}

	static void smethod_15(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0, bool bool_0)
	{
		_JbeCmOie0phb2cbgG6DdGZrbs3pB_0._LWcoDwIWvf8DT3nQmNe5z8fkUvI = bool_0;
	}

	static void smethod_16()
	{
		_UmxbIbk7pgaod0bD7pS309P3Lns._h0KfaNiikKlJV2KkRPIdVDKVJnC();
	}

	static ContentManager smethod_17(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		return _JbeCmOie0phb2cbgG6DdGZrbs3pB_0._uwNDZuqdFb9tyQtlQMxiz1DQ7x8;
	}

	static _hqmu3NsKXqziXGfVh3dt79G0fye smethod_18(ContentManager contentManager_0)
	{
		return new _hqmu3NsKXqziXGfVh3dt79G0fye(contentManager_0);
	}

	static void smethod_19(_hqmu3NsKXqziXGfVh3dt79G0fye _hqmu3NsKXqziXGfVh3dt79G0fye_0, string[] string_0)
	{
		_hqmu3NsKXqziXGfVh3dt79G0fye_0._cHRhcv3PTfJmYNZAZdcHvbfbkpj(string_0);
	}

	static _JbeCmOie0phb2cbgG6DdGZrbs3pB smethod_20(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0)
	{
		return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._ZzBuoSDMWwerejOO9Goyv2OCKgE;
	}

	static _opIJo2jLUqdOL5yAFP4yzXce0DG smethod_21()
	{
		return _Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t();
	}

	static Color smethod_22(_opIJo2jLUqdOL5yAFP4yzXce0DG _opIJo2jLUqdOL5yAFP4yzXce0DG_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return _opIJo2jLUqdOL5yAFP4yzXce0DG_0._uOkbmfW26QVAvyEMQakki9kTMDbA;
	}

	static Vector2 smethod_23(SpriteFont spriteFont_0, string string_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return spriteFont_0.MeasureString(string_0);
	}

	static void smethod_24(string string_0, float float_0)
	{
		_UmxbIbk7pgaod0bD7pS309P3Lns._l94kUraQ13OohoVwwxKC37hG7Pc(string_0, float_0);
	}

	static TimeSpan smethod_25(GameTime gameTime_0)
	{
		return gameTime_0.get_ElapsedGameTime();
	}

	static _3FFZvGWTAe7rsviKkDPTXEVjxWf smethod_26(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		return _JbeCmOie0phb2cbgG6DdGZrbs3pB_0._RbWJ7YGnYHCSoD44MRW1h5X6E7E;
	}

	static bool smethod_27(_3FFZvGWTAe7rsviKkDPTXEVjxWf _3FFZvGWTAe7rsviKkDPTXEVjxWf_0, _PMeRYZJaBCqgB9uADJFP3c14lxq _PMeRYZJaBCqgB9uADJFP3c14lxq_0)
	{
		return _3FFZvGWTAe7rsviKkDPTXEVjxWf_0._fy5ebLnmRsRXv9v7RKTFU5CGMaH(_PMeRYZJaBCqgB9uADJFP3c14lxq_0);
	}

	static bool smethod_28(_3FFZvGWTAe7rsviKkDPTXEVjxWf _3FFZvGWTAe7rsviKkDPTXEVjxWf_0, Keys keys_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return _3FFZvGWTAe7rsviKkDPTXEVjxWf_0._fy5ebLnmRsRXv9v7RKTFU5CGMaH(keys_0);
	}

	static void smethod_29(_hqmu3NsKXqziXGfVh3dt79G0fye _hqmu3NsKXqziXGfVh3dt79G0fye_0, float float_0)
	{
		_hqmu3NsKXqziXGfVh3dt79G0fye_0._xDFlaclLtJxSUU63JEJALvRLdfe(float_0);
	}

	static int smethod_30(int int_0, int int_1)
	{
		return _boyt8NIMtKsAGSTcjHeL0WMbFxs._07xTWbIEgzxJYsYwFKDbbKNvu4G(int_0, int_1);
	}

	static List<_ujAkjlfN5TywwbLAUDzPvtab6uJ> smethod_31(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0)
	{
		return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._lstlI8qzZ4KErYKnufdOlj1xVZF;
	}

	void method_0(SpriteBatch spriteBatch_0, SkeletonMeshRenderer skeletonMeshRenderer_0, Matrix matrix_0)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		base._f5ctqAmdNsZ889UjM4LxDm8WGxA(spriteBatch_0, skeletonMeshRenderer_0, matrix_0);
	}

	static void smethod_32(SpriteBatch spriteBatch_0)
	{
		spriteBatch_0.Begin();
	}

	void method_1()
	{
		base._tO46aYSBLFIuhFNlhbrAeWbFDSf();
	}

	static float smethod_33(float float_0, float float_1)
	{
		return _boyt8NIMtKsAGSTcjHeL0WMbFxs._S7DdtNZASTkc9riB27h5Ktq5VjDA(float_0, float_1);
	}

	static _691ooXdgg17CWFkMkjedKBBBfYw smethod_34(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		return _JbeCmOie0phb2cbgG6DdGZrbs3pB_0._aJh9CibG5YKhkExxgRyVopdfSeJ;
	}

	static void smethod_35(_691ooXdgg17CWFkMkjedKBBBfYw _691ooXdgg17CWFkMkjedKBBBfYw_0, string string_0)
	{
		_691ooXdgg17CWFkMkjedKBBBfYw_0._vVZVLriSGPExpn1KeobglMabsoi(string_0);
	}
}
