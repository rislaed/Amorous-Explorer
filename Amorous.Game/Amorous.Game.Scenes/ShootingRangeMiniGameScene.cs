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

public abstract class ShootingRangeMiniGameScene : AbstractScene
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

		public FrameAnimation(AbstractScene AbstractScene_0, string string_0, float float_0, int int_0, int int_1, int int_2, float float_1)
		{
			_uZYA4qnOfbVDFtZ6Ih3HawZgErP = AbstractScene_0.Game._uwNDZuqdFb9tyQtlQMxiz1DQ7x8.Load<Texture2D>(string_0);
			_q2YaOk0V93J3GMeWTOtcGdh9kEA = float_0 / (float)int_0;
			_hUTZltYwRfIdEri4M059hyQus5H = int_0;
			_Lb7cMVSwXw3dYaQEnyADfQZoUedb = 0;
			_jqsWTJ89RIZpjBr65dNZzmpJJKE = new Rectangle(0, 0, (int)((float)_uZYA4qnOfbVDFtZ6Ih3HawZgErP.Width / 12f), _uZYA4qnOfbVDFtZ6Ih3HawZgErP.Height);
			_NbYrjABARmnikNXQHmmbM8k62UE = new Rectangle(0, 0, (int)((float)_jqsWTJ89RIZpjBr65dNZzmpJJKE.Width * float_1), (int)((float)_jqsWTJ89RIZpjBr65dNZzmpJJKE.Height * float_1));
			_QBwNjQE21bfJ9yRo7CynjeYaHRg = new Vector2(int_1, int_2);
		}

		public void _QrgbXEg7MMeD9Ybz12fFVsbmAd9(int int_0, int int_1, float float_0)
		{
			_NbYrjABARmnikNXQHmmbM8k62UE.X = int_0;
			_NbYrjABARmnikNXQHmmbM8k62UE.Y = int_1;
			_MZBGPP8CHYYeh1lAhvANLxmu8KVA = MathHelper.ToRadians(float_0);
		}

		public void Update(float float_0)
		{
			if (_Lb7cMVSwXw3dYaQEnyADfQZoUedb >= 0)
			{
				_Q7Kx7ErHf3u1QIUDKfFCKSXbznG += float_0;
				while (_Q7Kx7ErHf3u1QIUDKfFCKSXbznG > _q2YaOk0V93J3GMeWTOtcGdh9kEA)
				{
					_Q7Kx7ErHf3u1QIUDKfFCKSXbznG -= _q2YaOk0V93J3GMeWTOtcGdh9kEA;
					_Lb7cMVSwXw3dYaQEnyADfQZoUedb++;
				}
				if (_Lb7cMVSwXw3dYaQEnyADfQZoUedb < _hUTZltYwRfIdEri4M059hyQus5H)
				{
					_jqsWTJ89RIZpjBr65dNZzmpJJKE.X = _Lb7cMVSwXw3dYaQEnyADfQZoUedb * _jqsWTJ89RIZpjBr65dNZzmpJJKE.Width;
				}
				else
				{
					_ymyneWF6dfrtfUI08wyb3KExq0D();
				}
			}
		}

		public void Draw(SpriteBatch spriteBatch_0)
		{
			if (_Lb7cMVSwXw3dYaQEnyADfQZoUedb >= 0)
			{
				spriteBatch_0.Draw(_uZYA4qnOfbVDFtZ6Ih3HawZgErP, _NbYrjABARmnikNXQHmmbM8k62UE, _jqsWTJ89RIZpjBr65dNZzmpJJKE, Color.White, _MZBGPP8CHYYeh1lAhvANLxmu8KVA, _QBwNjQE21bfJ9yRo7CynjeYaHRg, SpriteEffects.None, 0f);
			}
		}

		public void _ymyneWF6dfrtfUI08wyb3KExq0D()
		{
			_Lb7cMVSwXw3dYaQEnyADfQZoUedb = -1;
			_aeQckZZROopp0BqagEZE32fzkyr = true;
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

		public TargetModel(AbstractScene AbstractScene_0, int int_0, int int_1, float float_0 = 1f)
			: base(AbstractScene_0, "Target")
		{
			base._NC5P3SKqKPpcAYG1mqquUEcUzTg = delegate(GameTime gameTime_0)
			{
				_pO4d7wyWlp6cYLHahUVYplpUWxw.Update(gameTime_0);
			};
			base._Wb2e00OWt8kBwGWEXtOGMVScRPm = delegate(SpriteBatch spriteBatch_0, SkeletonMeshRenderer skeletonMeshRenderer_0)
			{
				_pO4d7wyWlp6cYLHahUVYplpUWxw.Draw(skeletonMeshRenderer_0, null, null, null, _i8C0PwO83NRzGvNoyMhHwLV9HeC);
			};
			_pO4d7wyWlp6cYLHahUVYplpUWxw = AbstractScene_0.Game._uwNDZuqdFb9tyQtlQMxiz1DQ7x8._7BVREQXEcBCieHb0qgaVDpUj1ni("Assets/Scenes/ShootingRange/Target");
			_q83Vj1dGmn3NFhPIkk7tO7tyxb(int_0, int_1, float_0);
		}

		private void _q83Vj1dGmn3NFhPIkk7tO7tyxb(int int_0, int int_1, float? nullable_0)
		{
			_pO4d7wyWlp6cYLHahUVYplpUWxw.X = int_0;
			_pO4d7wyWlp6cYLHahUVYplpUWxw.Y = int_1;
			_i8C0PwO83NRzGvNoyMhHwLV9HeC = nullable_0 ?? _i8C0PwO83NRzGvNoyMhHwLV9HeC;
			_JZPZVzDxWQJJNyrQBsinax9LDSh = (float)int_0 - (float)_4mLyheZBE5398noM999P10uPXyj.X / 2f * _i8C0PwO83NRzGvNoyMhHwLV9HeC;
			_gQiTjWdk9KSBoYLFXR1ELHlQDTk = (float)int_1 - (float)_4mLyheZBE5398noM999P10uPXyj.Y * _i8C0PwO83NRzGvNoyMhHwLV9HeC;
			_F61ut0AEUAE7JfCltwE9RXP3TK = new Point((int)((float)_4mLyheZBE5398noM999P10uPXyj.X * _i8C0PwO83NRzGvNoyMhHwLV9HeC), (int)((float)_4mLyheZBE5398noM999P10uPXyj.Y * _i8C0PwO83NRzGvNoyMhHwLV9HeC));
			_OVCuLPSRFKMV6JuYrGeZ5uMUJTC = new Point((int)((float)_I906IAlfLiodaJFNAL8BXp1P47T.X * _i8C0PwO83NRzGvNoyMhHwLV9HeC), (int)((float)_I906IAlfLiodaJFNAL8BXp1P47T.Y * _i8C0PwO83NRzGvNoyMhHwLV9HeC));
			_XD9uURBVAJTsK2DKyuCockNh07A = (int)((float)_lhuXZkj0cs1oFnjnnY7TNYVWPXe * _i8C0PwO83NRzGvNoyMhHwLV9HeC);
		}

		public void _edcakvTOp2fd2J9ZHAu9GKjDaN7(Action action_0 = null)
		{
			_pO4d7wyWlp6cYLHahUVYplpUWxw._SPUoP3ABwpgQinJfKUM5qBbYSvr("Rise", action_0);
		}

		public void _DcBCpcEfsjl4zP1zbrOrd1bwNReb(Action action_0 = null)
		{
			_pO4d7wyWlp6cYLHahUVYplpUWxw._SPUoP3ABwpgQinJfKUM5qBbYSvr("Headshot", action_0);
		}

		public void _u1yq8F9lG8oMcA9vZO9c7Qbh8vj(Action action_0 = null)
		{
			_pO4d7wyWlp6cYLHahUVYplpUWxw._SPUoP3ABwpgQinJfKUM5qBbYSvr("Bodyshot", action_0);
		}

		public bool _ZCfNJ0nxXx3YppgLl5SvS2LkQ5B(Point point_0, out CollisionType collisionType_0)
		{
			collisionType_0 = CollisionType.None;
			if (!_kf3EbE0B70xGe1szklqAZyCqoLj)
			{
				return false;
			}
			if ((float)point_0.X >= _JZPZVzDxWQJJNyrQBsinax9LDSh && (float)point_0.X <= _JZPZVzDxWQJJNyrQBsinax9LDSh + (float)_F61ut0AEUAE7JfCltwE9RXP3TK.X && (float)point_0.Y >= _gQiTjWdk9KSBoYLFXR1ELHlQDTk && (float)point_0.Y <= _gQiTjWdk9KSBoYLFXR1ELHlQDTk + (float)_F61ut0AEUAE7JfCltwE9RXP3TK.Y)
			{
				if ((float)point_0.Y >= _gQiTjWdk9KSBoYLFXR1ELHlQDTk + (float)_OVCuLPSRFKMV6JuYrGeZ5uMUJTC.Y + (float)_XD9uURBVAJTsK2DKyuCockNh07A)
				{
					collisionType_0 = CollisionType.Bodyshot;
					return true;
				}
				float num = (float)point_0.X - (_JZPZVzDxWQJJNyrQBsinax9LDSh + (float)_OVCuLPSRFKMV6JuYrGeZ5uMUJTC.X);
				float num2 = (float)point_0.Y - (_gQiTjWdk9KSBoYLFXR1ELHlQDTk + (float)_OVCuLPSRFKMV6JuYrGeZ5uMUJTC.Y);
				double num3 = Math.Sqrt(num * num + num2 * num2);
				if (num3 <= (double)_XD9uURBVAJTsK2DKyuCockNh07A)
				{
					collisionType_0 = CollisionType.Headshot;
					return true;
				}
			}
			return false;
		}
	}

	private class GunModel : _WBXNT6eIVGk6ZKExRBJ6JxXE6zb
	{
		private readonly _nHdiyIURlAiaNZ8u6MKzxjcwnyL _XcQKV7iP9Sk10poAFYuakLJaltL;

		public new float X
		{
			set
			{
				_XcQKV7iP9Sk10poAFYuakLJaltL.X = value;
			}
		}

		public new float Y
		{
			set
			{
				_XcQKV7iP9Sk10poAFYuakLJaltL.Y = value;
			}
		}

		public bool _PXBbI2AED2MyzkuXicgwalICf26
		{
			set
			{
				_XcQKV7iP9Sk10poAFYuakLJaltL._Hwt6L2NJfXmAfG6UOH8NVlNfGCR = value;
			}
		}

		public GunModel(AbstractScene AbstractScene_0)
			: base(AbstractScene_0, "GunModel")
		{
			base._NC5P3SKqKPpcAYG1mqquUEcUzTg = delegate(GameTime gameTime_0)
			{
				_XcQKV7iP9Sk10poAFYuakLJaltL.Update(gameTime_0);
			};
			base._Wb2e00OWt8kBwGWEXtOGMVScRPm = delegate(SpriteBatch spriteBatch_0, SkeletonMeshRenderer skeletonMeshRenderer_0)
			{
				_XcQKV7iP9Sk10poAFYuakLJaltL.Draw(skeletonMeshRenderer_0, null, null, null, _fO7gSlrDDNMoHR4FO5QXAq8fUyA);
			};
			_XcQKV7iP9Sk10poAFYuakLJaltL = AbstractScene_0.Game._uwNDZuqdFb9tyQtlQMxiz1DQ7x8._7BVREQXEcBCieHb0qgaVDpUj1ni("Assets/GUI/Phone/Phone");
			_XcQKV7iP9Sk10poAFYuakLJaltL._WPy6ICx3LVoejBaexyOoKGnX9jD("Arm rise", 0f);
			_XcQKV7iP9Sk10poAFYuakLJaltL._c4iC7y9v6xg7LpvjKIeUkOdZ3UF(0f);
			_XcQKV7iP9Sk10poAFYuakLJaltL.X = 0f;
			_XcQKV7iP9Sk10poAFYuakLJaltL.Y = 1080f;
			PlayerData opIJo2jLUqdOL5yAFP4yzXce0DG = _Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t();
			bool flag = opIJo2jLUqdOL5yAFP4yzXce0DG.MarkingsType.HasFlag(PlayerData.EMarkingsType.LongForearm);
			bool flag2;
			Color color_ = ((flag2 = opIJo2jLUqdOL5yAFP4yzXce0DG.MarkingsType.HasFlag(PlayerData.EMarkingsType.ShortForearm)) ? opIJo2jLUqdOL5yAFP4yzXce0DG.ShortForearmColor : (flag ? opIJo2jLUqdOL5yAFP4yzXce0DG.LongForearmColor : Color.White));
			_XcQKV7iP9Sk10poAFYuakLJaltL._aAoZaDNczeScsMfLlGSfAzey9SQ("Hoody Sleeve", 0f);
			_XcQKV7iP9Sk10poAFYuakLJaltL._aAoZaDNczeScsMfLlGSfAzey9SQ("Default Forearm", 1f);
			_XcQKV7iP9Sk10poAFYuakLJaltL._VoeevpFh2kLKfHtpPDXWt0TFbuH("Default Forearm", opIJo2jLUqdOL5yAFP4yzXce0DG.BodyColor);
			_XcQKV7iP9Sk10poAFYuakLJaltL._aAoZaDNczeScsMfLlGSfAzey9SQ("Marking Forearm", (flag2 || flag) ? 1 : 0);
			_XcQKV7iP9Sk10poAFYuakLJaltL._VoeevpFh2kLKfHtpPDXWt0TFbuH("Marking Forearm", color_);
			_XcQKV7iP9Sk10poAFYuakLJaltL._aAoZaDNczeScsMfLlGSfAzey9SQ("Striped forearm", opIJo2jLUqdOL5yAFP4yzXce0DG.MarkingsType.HasFlag(PlayerData.EMarkingsType.Stripes) ? 1 : 0);
			_XcQKV7iP9Sk10poAFYuakLJaltL._VoeevpFh2kLKfHtpPDXWt0TFbuH("Striped forearm", opIJo2jLUqdOL5yAFP4yzXce0DG.StripesColor);
			_XcQKV7iP9Sk10poAFYuakLJaltL._aAoZaDNczeScsMfLlGSfAzey9SQ("Avian Forearm", opIJo2jLUqdOL5yAFP4yzXce0DG.MarkingsType.HasFlag(PlayerData.EMarkingsType.AvianForearm) ? 1 : 0);
			_XcQKV7iP9Sk10poAFYuakLJaltL._VoeevpFh2kLKfHtpPDXWt0TFbuH("Avian Forearm", opIJo2jLUqdOL5yAFP4yzXce0DG.AvianForearmColor);
			_XcQKV7iP9Sk10poAFYuakLJaltL._aAoZaDNczeScsMfLlGSfAzey9SQ("Hand", 1f);
			_XcQKV7iP9Sk10poAFYuakLJaltL._VoeevpFh2kLKfHtpPDXWt0TFbuH("Hand", opIJo2jLUqdOL5yAFP4yzXce0DG.BodyColor);
			_XcQKV7iP9Sk10poAFYuakLJaltL._aAoZaDNczeScsMfLlGSfAzey9SQ("Marking Hand", (flag2 || flag) ? 1 : 0);
			_XcQKV7iP9Sk10poAFYuakLJaltL._VoeevpFh2kLKfHtpPDXWt0TFbuH("Marking Hand", color_);
			_XcQKV7iP9Sk10poAFYuakLJaltL._aAoZaDNczeScsMfLlGSfAzey9SQ("Avian Hand", opIJo2jLUqdOL5yAFP4yzXce0DG.MarkingsType.HasFlag(PlayerData.EMarkingsType.AvianForearm) ? 1 : 0);
			_XcQKV7iP9Sk10poAFYuakLJaltL._VoeevpFh2kLKfHtpPDXWt0TFbuH("Avian Hand", opIJo2jLUqdOL5yAFP4yzXce0DG.AvianForearmColor);
			_XcQKV7iP9Sk10poAFYuakLJaltL._aAoZaDNczeScsMfLlGSfAzey9SQ("Index", 1f);
			_XcQKV7iP9Sk10poAFYuakLJaltL._VoeevpFh2kLKfHtpPDXWt0TFbuH("Index", opIJo2jLUqdOL5yAFP4yzXce0DG.BodyColor);
			_XcQKV7iP9Sk10poAFYuakLJaltL._aAoZaDNczeScsMfLlGSfAzey9SQ("Avian index", opIJo2jLUqdOL5yAFP4yzXce0DG.MarkingsType.HasFlag(PlayerData.EMarkingsType.AvianForearm) ? 1 : 0);
			_XcQKV7iP9Sk10poAFYuakLJaltL._VoeevpFh2kLKfHtpPDXWt0TFbuH("Avian index", opIJo2jLUqdOL5yAFP4yzXce0DG.AvianForearmColor);
			_XcQKV7iP9Sk10poAFYuakLJaltL._aAoZaDNczeScsMfLlGSfAzey9SQ("Pinky", 1f);
			_XcQKV7iP9Sk10poAFYuakLJaltL._VoeevpFh2kLKfHtpPDXWt0TFbuH("Pinky", opIJo2jLUqdOL5yAFP4yzXce0DG.BodyColor);
			_XcQKV7iP9Sk10poAFYuakLJaltL._aAoZaDNczeScsMfLlGSfAzey9SQ("Avian Pinky", opIJo2jLUqdOL5yAFP4yzXce0DG.MarkingsType.HasFlag(PlayerData.EMarkingsType.AvianForearm) ? 1 : 0);
			_XcQKV7iP9Sk10poAFYuakLJaltL._VoeevpFh2kLKfHtpPDXWt0TFbuH("Avian Pinky", opIJo2jLUqdOL5yAFP4yzXce0DG.AvianForearmColor);
			_XcQKV7iP9Sk10poAFYuakLJaltL._aAoZaDNczeScsMfLlGSfAzey9SQ("Ring", 1f);
			_XcQKV7iP9Sk10poAFYuakLJaltL._VoeevpFh2kLKfHtpPDXWt0TFbuH("Ring", opIJo2jLUqdOL5yAFP4yzXce0DG.BodyColor);
			_XcQKV7iP9Sk10poAFYuakLJaltL._aAoZaDNczeScsMfLlGSfAzey9SQ("Avian ring", opIJo2jLUqdOL5yAFP4yzXce0DG.MarkingsType.HasFlag(PlayerData.EMarkingsType.AvianForearm) ? 1 : 0);
			_XcQKV7iP9Sk10poAFYuakLJaltL._VoeevpFh2kLKfHtpPDXWt0TFbuH("Avian ring", opIJo2jLUqdOL5yAFP4yzXce0DG.AvianForearmColor);
			_XcQKV7iP9Sk10poAFYuakLJaltL._aAoZaDNczeScsMfLlGSfAzey9SQ("Rude", 1f);
			_XcQKV7iP9Sk10poAFYuakLJaltL._VoeevpFh2kLKfHtpPDXWt0TFbuH("Rude", opIJo2jLUqdOL5yAFP4yzXce0DG.BodyColor);
			_XcQKV7iP9Sk10poAFYuakLJaltL._aAoZaDNczeScsMfLlGSfAzey9SQ("Avian Rude", opIJo2jLUqdOL5yAFP4yzXce0DG.MarkingsType.HasFlag(PlayerData.EMarkingsType.AvianForearm) ? 1 : 0);
			_XcQKV7iP9Sk10poAFYuakLJaltL._VoeevpFh2kLKfHtpPDXWt0TFbuH("Avian Rude", opIJo2jLUqdOL5yAFP4yzXce0DG.AvianForearmColor);
			_XcQKV7iP9Sk10poAFYuakLJaltL._aAoZaDNczeScsMfLlGSfAzey9SQ("Thumb", 1f);
			_XcQKV7iP9Sk10poAFYuakLJaltL._VoeevpFh2kLKfHtpPDXWt0TFbuH("Thumb", opIJo2jLUqdOL5yAFP4yzXce0DG.BodyColor);
			_XcQKV7iP9Sk10poAFYuakLJaltL._aAoZaDNczeScsMfLlGSfAzey9SQ("Avian Thumb", opIJo2jLUqdOL5yAFP4yzXce0DG.MarkingsType.HasFlag(PlayerData.EMarkingsType.AvianForearm) ? 1 : 0);
			_XcQKV7iP9Sk10poAFYuakLJaltL._VoeevpFh2kLKfHtpPDXWt0TFbuH("Avian Thumb", opIJo2jLUqdOL5yAFP4yzXce0DG.AvianForearmColor);
			_XcQKV7iP9Sk10poAFYuakLJaltL._aAoZaDNczeScsMfLlGSfAzey9SQ("Pinky Nail", opIJo2jLUqdOL5yAFP4yzXce0DG.ShowNails ? 1 : 0);
			_XcQKV7iP9Sk10poAFYuakLJaltL._VoeevpFh2kLKfHtpPDXWt0TFbuH("Pinky Nail", opIJo2jLUqdOL5yAFP4yzXce0DG.NailColor);
			_XcQKV7iP9Sk10poAFYuakLJaltL._aAoZaDNczeScsMfLlGSfAzey9SQ("Ring Nail", opIJo2jLUqdOL5yAFP4yzXce0DG.ShowNails ? 1 : 0);
			_XcQKV7iP9Sk10poAFYuakLJaltL._VoeevpFh2kLKfHtpPDXWt0TFbuH("Ring Nail", opIJo2jLUqdOL5yAFP4yzXce0DG.NailColor);
			_XcQKV7iP9Sk10poAFYuakLJaltL._aAoZaDNczeScsMfLlGSfAzey9SQ("Rude Nail", opIJo2jLUqdOL5yAFP4yzXce0DG.ShowNails ? 1 : 0);
			_XcQKV7iP9Sk10poAFYuakLJaltL._VoeevpFh2kLKfHtpPDXWt0TFbuH("Rude Nail", opIJo2jLUqdOL5yAFP4yzXce0DG.NailColor);
			_XcQKV7iP9Sk10poAFYuakLJaltL._aAoZaDNczeScsMfLlGSfAzey9SQ("Index Nail", opIJo2jLUqdOL5yAFP4yzXce0DG.ShowNails ? 1 : 0);
			_XcQKV7iP9Sk10poAFYuakLJaltL._VoeevpFh2kLKfHtpPDXWt0TFbuH("Index Nail", opIJo2jLUqdOL5yAFP4yzXce0DG.NailColor);
			_XcQKV7iP9Sk10poAFYuakLJaltL._aAoZaDNczeScsMfLlGSfAzey9SQ("Thumb Nail", opIJo2jLUqdOL5yAFP4yzXce0DG.ShowNails ? 1 : 0);
			_XcQKV7iP9Sk10poAFYuakLJaltL._VoeevpFh2kLKfHtpPDXWt0TFbuH("Thumb Nail", opIJo2jLUqdOL5yAFP4yzXce0DG.NailColor);
			_XcQKV7iP9Sk10poAFYuakLJaltL._aAoZaDNczeScsMfLlGSfAzey9SQ("Muzzle flash", 1f);
			_XcQKV7iP9Sk10poAFYuakLJaltL._aAoZaDNczeScsMfLlGSfAzey9SQ("Gun casing", 1f);
			_XcQKV7iP9Sk10poAFYuakLJaltL._aAoZaDNczeScsMfLlGSfAzey9SQ("Gun", 1f);
			_XcQKV7iP9Sk10poAFYuakLJaltL._aAoZaDNczeScsMfLlGSfAzey9SQ("Gun Slide", 1f);
		}

		public void _edcakvTOp2fd2J9ZHAu9GKjDaN7(Action action_0 = null)
		{
			_XcQKV7iP9Sk10poAFYuakLJaltL._SPUoP3ABwpgQinJfKUM5qBbYSvr("Gun rise", delegate
			{
				_3AjdlsblH9b6FNnDEW7N5sQ8iHs();
				action_0?.Invoke();
			});
		}

		private void _3AjdlsblH9b6FNnDEW7N5sQ8iHs()
		{
			_XcQKV7iP9Sk10poAFYuakLJaltL._C5vPbZ72rpVMDWGuHxZuR5FNpAH("Gun Idle");
		}

		public void _e2DHCcfpFNWn5NTzMOw3FBUkwzA()
		{
			_XcQKV7iP9Sk10poAFYuakLJaltL._SPUoP3ABwpgQinJfKUM5qBbYSvr("Gun Shoot", _3AjdlsblH9b6FNnDEW7N5sQ8iHs);
		}

		public void _hAt3H7isKECkVrQjY4L0hESiqLF(Action action_0 = null)
		{
			_XcQKV7iP9Sk10poAFYuakLJaltL._SPUoP3ABwpgQinJfKUM5qBbYSvr("Gun reload", delegate
			{
				_3AjdlsblH9b6FNnDEW7N5sQ8iHs();
				action_0?.Invoke();
			});
		}
	}

	private interface IDrawable
	{
		bool _aeQckZZROopp0BqagEZE32fzkyr { get; }

		void Update(float float_0);

		void Draw(SpriteBatch spriteBatch_0);

		void _ymyneWF6dfrtfUI08wyb3KExq0D();
	}

	private class FloatingFeedbackDrawable : IDrawable
	{
		private const float _HS0I0EgJMjmRXhZ0KDhLBBA2VkE = 0.8f;

		private const float _YBMjlnwxHIEUKERmDSGIKOlw2aM = 100f;

		private readonly SpriteFont _xnYepZuegigJCU2jcbZsfVIakzF;

		private readonly float _nD28BmrDaEzCHelTAa14TKyuSyG;

		private float _LkckKdvuh9GaAwn7XojfbJBd91r;

		private readonly string Text;

		private readonly Color _JbGNnZhaeWyNm0aWm7TtSamww4C;

		private float _AQwQu1ldCtpbkD5F9oEByJdCnWaA;

		public bool _aeQckZZROopp0BqagEZE32fzkyr { get; private set; }

		public FloatingFeedbackDrawable(AbstractScene AbstractScene_0, int int_0, int int_1, string string_0, Color color_0)
		{
			_xnYepZuegigJCU2jcbZsfVIakzF = AbstractScene_0.Game._uwNDZuqdFb9tyQtlQMxiz1DQ7x8.Load<SpriteFont>("Assets/GUI/Fonts/Bold-26");
			_nD28BmrDaEzCHelTAa14TKyuSyG = int_0;
			_LkckKdvuh9GaAwn7XojfbJBd91r = int_1;
			Text = string_0;
			_JbGNnZhaeWyNm0aWm7TtSamww4C = color_0;
			_AQwQu1ldCtpbkD5F9oEByJdCnWaA = 1f;
		}

		public void Update(float float_0)
		{
			if (!_aeQckZZROopp0BqagEZE32fzkyr)
			{
				_AQwQu1ldCtpbkD5F9oEByJdCnWaA -= 0.8f * float_0;
				if (_AQwQu1ldCtpbkD5F9oEByJdCnWaA <= 0f)
				{
					_aeQckZZROopp0BqagEZE32fzkyr = true;
				}
				else
				{
					_LkckKdvuh9GaAwn7XojfbJBd91r -= 100f * float_0;
				}
			}
		}

		public void Draw(SpriteBatch spriteBatch_0)
		{
			spriteBatch_0.DrawString(_xnYepZuegigJCU2jcbZsfVIakzF, Text, new Vector2(_nD28BmrDaEzCHelTAa14TKyuSyG, _LkckKdvuh9GaAwn7XojfbJBd91r), _JbGNnZhaeWyNm0aWm7TtSamww4C * _AQwQu1ldCtpbkD5F9oEByJdCnWaA);
		}

		public void _ymyneWF6dfrtfUI08wyb3KExq0D()
		{
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
			_x2m0UxhUAD6cdIEszjrShiRmPfx = float_0;
			_jokchmUtu5NAXtJsjLfIUXz2XXP = action_0;
		}

		public void Update(float float_0)
		{
			if (!_aeQckZZROopp0BqagEZE32fzkyr)
			{
				_3wk7bXUbhNqSQ9kMD9hieEubOhG += float_0;
				if (_3wk7bXUbhNqSQ9kMD9hieEubOhG > _x2m0UxhUAD6cdIEszjrShiRmPfx)
				{
					_ymyneWF6dfrtfUI08wyb3KExq0D();
				}
			}
		}

		public void Draw(SpriteBatch spriteBatch_0)
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

		public readonly int Y;

		public readonly float _fO7gSlrDDNMoHR4FO5QXAq8fUyA;

		public readonly int Layer;

		public RailInfo(int int_0, int int_1, int int_2, float float_0, int int_3)
		{
			_SjhHztt8d5kOtb7Z2BJKnZZxEKh = int_0;
			_nVnyJkkce6HsdRrKSpRrzUDElg0 = int_1;
			Y = int_2;
			_fO7gSlrDDNMoHR4FO5QXAq8fUyA = float_0;
			Layer = int_3;
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

	private const string _U1HaVdhFZJNSjA4zQOBoTSRBtMl = "Time up, Game over! Press <Enter> to retry or <Escape> to continue.";

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

	protected ShootingRangeMiniGameScene(IAmorous game)
		: base(Game)
	{
		_WD4Plg5m1AwZ5mVyjQCADcW1ZTk = Game._LWcoDwIWvf8DT3nQmNe5z8fkUvI;
		Game._LWcoDwIWvf8DT3nQmNe5z8fkUvI = false;
		_U8eNAZVBW15ZflhG4fel0hK3Juu = _poenyHBGUusBcnNcTFB9MQBV72R._kf3EbE0B70xGe1szklqAZyCqoLj;
		_poenyHBGUusBcnNcTFB9MQBV72R._kf3EbE0B70xGe1szklqAZyCqoLj = false;
		_UmxbIbk7pgaod0bD7pS309P3Lns._h0KfaNiikKlJV2KkRPIdVDKVJnC();
		_vCjkdRWXT5mvEu0c22Hgh93luLg = new _hqmu3NsKXqziXGfVh3dt79G0fye(Game._uwNDZuqdFb9tyQtlQMxiz1DQ7x8);
		_vCjkdRWXT5mvEu0c22Hgh93luLg._cHRhcv3PTfJmYNZAZdcHvbfbkpj("Assets/Sounds/MiniGames/ShootingRange/Fire");
		_RiMZpLLSGIesSXF8vhSlVQ8SrDg = new _hqmu3NsKXqziXGfVh3dt79G0fye(Game._uwNDZuqdFb9tyQtlQMxiz1DQ7x8);
		_RiMZpLLSGIesSXF8vhSlVQ8SrDg._cHRhcv3PTfJmYNZAZdcHvbfbkpj("Assets/Sounds/MiniGames/ShootingRange/Dry");
		_ykeARom1bl7r01BeRXMOSqoJU6o = new _hqmu3NsKXqziXGfVh3dt79G0fye(Game._uwNDZuqdFb9tyQtlQMxiz1DQ7x8);
		_ykeARom1bl7r01BeRXMOSqoJU6o._cHRhcv3PTfJmYNZAZdcHvbfbkpj("Assets/Sounds/MiniGames/ShootingRange/Reload");
		_gabFSY9HcJdPu830plKx8W936qG = new _hqmu3NsKXqziXGfVh3dt79G0fye(Game._uwNDZuqdFb9tyQtlQMxiz1DQ7x8);
		_gabFSY9HcJdPu830plKx8W936qG._cHRhcv3PTfJmYNZAZdcHvbfbkpj("Assets/Sounds/MiniGames/ShootingRange/Headshot 1", "Assets/Sounds/MiniGames/ShootingRange/Headshot 2");
		_Hsn6Qz2oeKaTkin9XGwBJUJqy1C = new _hqmu3NsKXqziXGfVh3dt79G0fye(Game._uwNDZuqdFb9tyQtlQMxiz1DQ7x8);
		_Hsn6Qz2oeKaTkin9XGwBJUJqy1C._cHRhcv3PTfJmYNZAZdcHvbfbkpj("Assets/Sounds/MiniGames/ShootingRange/Impact 1", "Assets/Sounds/MiniGames/ShootingRange/Impact 2", "Assets/Sounds/MiniGames/ShootingRange/Impact 3");
		_Oeqego17TDqmByfLbOEB1isMXzJ = new _hqmu3NsKXqziXGfVh3dt79G0fye(Game._uwNDZuqdFb9tyQtlQMxiz1DQ7x8);
		_Oeqego17TDqmByfLbOEB1isMXzJ._cHRhcv3PTfJmYNZAZdcHvbfbkpj("Assets/Sounds/MiniGames/ShootingRange/Ricochete 1", "Assets/Sounds/MiniGames/ShootingRange/Ricochete 2", "Assets/Sounds/MiniGames/ShootingRange/Ricochete 3");
		_m1dNhD2jwJ6iTVUgUzMJUvnQFS = base.Game._uwNDZuqdFb9tyQtlQMxiz1DQ7x8.Load<Texture2D>("Assets/Scenes/ShootingRange/Bullet");
		_7oYtfGpL7UyAQrZxew7Ahbvj6Sv(_Iz47swAAB7d2iX6PQ1xTIJIv8MJ("Backdrop", "Assets/Scenes/ShootingRange/Backdrop", 600, 180), 0);
		_7oYtfGpL7UyAQrZxew7Ahbvj6Sv(_Iz47swAAB7d2iX6PQ1xTIJIv8MJ("Background", "Assets/Scenes/ShootingRange/Background", 0, 0), 2);
		_7oYtfGpL7UyAQrZxew7Ahbvj6Sv(_Iz47swAAB7d2iX6PQ1xTIJIv8MJ("Countertop", "Assets/Scenes/ShootingRange/Countertop", 0, 0), 6);
		_6YCQhlMaqcDds8uGX1g8fjBKqV4A = Game._uwNDZuqdFb9tyQtlQMxiz1DQ7x8.Load<SpriteFont>("Assets/GUI/Fonts/Bold-14");
		_MnMUFBDfrGZBHvrJ30IAQilqivI = Game._uwNDZuqdFb9tyQtlQMxiz1DQ7x8.Load<SpriteFont>("Assets/GUI/Fonts/Bold-26");
		_AWLddj1Rm2sqiBwYcJDngG0QaQI = _Z6EKIW3ycAwV2npYuxbFLcnCTrJ._dxo6sBOpjEUiw2JBMikbutXK44t().PhoneColor;
		_tvM0bxD4ITME03hjc6seyYclzxf = _Iz47swAAB7d2iX6PQ1xTIJIv8MJ("Crosshair", "Assets/Scenes/ShootingRange/Crosshair", 0, 0);
		_tvM0bxD4ITME03hjc6seyYclzxf.Color = _AWLddj1Rm2sqiBwYcJDngG0QaQI;
		_7oYtfGpL7UyAQrZxew7Ahbvj6Sv(_tvM0bxD4ITME03hjc6seyYclzxf, 7);
		_85WqOX8OcxbI6g74CaBZtHiHK2m = new GunModel(this)
		{
			X = 1820f,
			Y = 1080f,
			_fO7gSlrDDNMoHR4FO5QXAq8fUyA = 0.5f,
			_PXBbI2AED2MyzkuXicgwalICf26 = true
		};
		_7oYtfGpL7UyAQrZxew7Ahbvj6Sv(_85WqOX8OcxbI6g74CaBZtHiHK2m, 8);
		_85WqOX8OcxbI6g74CaBZtHiHK2m._edcakvTOp2fd2J9ZHAu9GKjDaN7();
		_u8GaIYUzQ65BoFU3NzXBzyvujjbA = new List<TargetModel>();
		_xEG3axnWkco0Erk0PdjakXDULcA = new List<IDrawable>();
		_d9mstkVrU6KGDJyOtHGgrr2ZciA = new List<IDrawable>();
		_YhybMVqCJnFekEXVbF1huXupDmh = _MnMUFBDfrGZBHvrJ30IAQilqivI.MeasureString("Press <Space/R/Mouse-R> to Reload and begin.").X;
		_MZh3nVRuDktDpIu8X149SF90ZjO = _MnMUFBDfrGZBHvrJ30IAQilqivI.MeasureString("Time up, Game over! Press <Enter> to retry or <Escape> to continue.").X;
		_0zKXRrSXqoTAuTYQNrJIgtt7Emq = 90f;
		_M8VVMN3GHWWmFmORCACqNTXVh6b = 1;
		_UmxbIbk7pgaod0bD7pS309P3Lns._l94kUraQ13OohoVwwxKC37hG7Pc("Assets/Music/Mittsies - Mech", 0.4f);
		_dxhbACq6BB89IAMy6ZOALWJgv7L = GameState.NotStarted;
	}

	public override void Update(GameTime gameTime_0)
	{
		float float_ = (float)gameTime_0.ElapsedGameTime.Milliseconds / 1000f;
		if (_F2ao1gdMb4UciyKC7Zly4by95Mn && base.Game._RbWJ7YGnYHCSoD44MRW1h5X6E7E._fy5ebLnmRsRXv9v7RKTFU5CGMaH(Keys.Escape))
		{
			_dxhbACq6BB89IAMy6ZOALWJgv7L = GameState.None;
			_5Z9jaXDcRYm0wNlEm1aTutL9kSH();
		}
		if (_0zKXRrSXqoTAuTYQNrJIgtt7Emq <= 60f)
		{
			if (_0zKXRrSXqoTAuTYQNrJIgtt7Emq > 30f)
			{
				_M8VVMN3GHWWmFmORCACqNTXVh6b = 2;
			}
			else if (_0zKXRrSXqoTAuTYQNrJIgtt7Emq > 0f)
			{
				_M8VVMN3GHWWmFmORCACqNTXVh6b = 4;
			}
		}
		else
		{
			_M8VVMN3GHWWmFmORCACqNTXVh6b = 1;
		}
		if (_0zKXRrSXqoTAuTYQNrJIgtt7Emq <= 0f)
		{
			_dxhbACq6BB89IAMy6ZOALWJgv7L = GameState.GameOver;
			_jj3EwaVU5VqWdkXGZXsxWtQcYOv();
		}
		_TcTPQp3KE5mO2mYA6sSQDbHnhAw = base.Game._vsceSzSIjBy2nZrCxAzKZbUiwLq._2j5HjqIBNOwD2br7yBprKdzVhAK(base.Game._RbWJ7YGnYHCSoD44MRW1h5X6E7E._U7CeYBJ1v1SoUxpX8emsQ9mWl5b);
		_tvM0bxD4ITME03hjc6seyYclzxf.X = _TcTPQp3KE5mO2mYA6sSQDbHnhAw.X - 32;
		_tvM0bxD4ITME03hjc6seyYclzxf.Y = _TcTPQp3KE5mO2mYA6sSQDbHnhAw.Y - 32;
		_85WqOX8OcxbI6g74CaBZtHiHK2m.X = 780f + Math.Min(1f, (float)_TcTPQp3KE5mO2mYA6sSQDbHnhAw.X / 1730f) * 1570f;
		_85WqOX8OcxbI6g74CaBZtHiHK2m.Y = 1080f + Math.Min(1f, (float)_TcTPQp3KE5mO2mYA6sSQDbHnhAw.Y / 950f) * 370f;
		_FCyUaxF0GIE1r2fyuYC4b4tGqpJ(float_);
		switch (_dxhbACq6BB89IAMy6ZOALWJgv7L)
		{
		case GameState.NotStarted:
			_fFSom2DrN3XLCdgmD5vZaJmWP7G(float_);
			break;
		case GameState.Started:
			_8GHK7o3vLmG6sThZNN5JsWHoKkE(float_);
			break;
		case GameState.GameOver:
			_g0eYquQ8BcifsIs5UMyAIkXM5paA(float_);
			break;
		}
		base.Update(gameTime_0);
	}

	private void _fFSom2DrN3XLCdgmD5vZaJmWP7G(float float_0)
	{
		if (!_eMnDHRem25x38ZqmbzZLc1CLkwlA && (base.Game._RbWJ7YGnYHCSoD44MRW1h5X6E7E._fy5ebLnmRsRXv9v7RKTFU5CGMaH(_PMeRYZJaBCqgB9uADJFP3c14lxq.RightButton) || base.Game._RbWJ7YGnYHCSoD44MRW1h5X6E7E._fy5ebLnmRsRXv9v7RKTFU5CGMaH(Keys.R) || base.Game._RbWJ7YGnYHCSoD44MRW1h5X6E7E._fy5ebLnmRsRXv9v7RKTFU5CGMaH(Keys.Space)))
		{
			_eMnDHRem25x38ZqmbzZLc1CLkwlA = true;
			_nHs33RHZMuYhYev0dQ6ic0aHmvO = true;
			_ykeARom1bl7r01BeRXMOSqoJU6o._xDFlaclLtJxSUU63JEJALvRLdfe();
			_85WqOX8OcxbI6g74CaBZtHiHK2m._hAt3H7isKECkVrQjY4L0hESiqLF(delegate
			{
				_YFr89aAV3UzO9kf7kPKQJilRWED = 6;
				_eMnDHRem25x38ZqmbzZLc1CLkwlA = false;
				_nHs33RHZMuYhYev0dQ6ic0aHmvO = false;
				_dxhbACq6BB89IAMy6ZOALWJgv7L = GameState.Started;
				_5b1aUCG2FfD5yQCBUDAoLZYMu7A(0f, _SeJVPxt5mkxE2oaiV4gLg7Iiar);
			});
		}
	}

	private void _8GHK7o3vLmG6sThZNN5JsWHoKkE(float float_0)
	{
		_0zKXRrSXqoTAuTYQNrJIgtt7Emq -= float_0;
		if (!_eMnDHRem25x38ZqmbzZLc1CLkwlA && !_nHs33RHZMuYhYev0dQ6ic0aHmvO && base.Game._RbWJ7YGnYHCSoD44MRW1h5X6E7E._fy5ebLnmRsRXv9v7RKTFU5CGMaH(_PMeRYZJaBCqgB9uADJFP3c14lxq.LeftButton))
		{
			if (_YFr89aAV3UzO9kf7kPKQJilRWED != 0)
			{
				_YFr89aAV3UzO9kf7kPKQJilRWED--;
				_nHs33RHZMuYhYev0dQ6ic0aHmvO = true;
				_5b1aUCG2FfD5yQCBUDAoLZYMu7A(0.5f, delegate
				{
					_nHs33RHZMuYhYev0dQ6ic0aHmvO = false;
				});
				_85WqOX8OcxbI6g74CaBZtHiHK2m._e2DHCcfpFNWn5NTzMOw3FBUkwzA();
				_vCjkdRWXT5mvEu0c22Hgh93luLg._xDFlaclLtJxSUU63JEJALvRLdfe();
				bool flag = false;
				foreach (TargetModel _OJbyketBmeLlVtChfay03TIx5KM in _u8GaIYUzQ65BoFU3NzXBzyvujjbA)
				{
					if (!_OJbyketBmeLlVtChfay03TIx5KM._ZCfNJ0nxXx3YppgLl5SvS2LkQ5B(_TcTPQp3KE5mO2mYA6sSQDbHnhAw, out _0U2R42Dbf2ddmyfQBv0z7zBWwJm))
					{
						continue;
					}
					_Vu9iV57zUVa3p8WMfOsDaoqv7wL(_TcTPQp3KE5mO2mYA6sSQDbHnhAw.X, _TcTPQp3KE5mO2mYA6sSQDbHnhAw.Y, _OJbyketBmeLlVtChfay03TIx5KM._fO7gSlrDDNMoHR4FO5QXAq8fUyA);
					if (_0U2R42Dbf2ddmyfQBv0z7zBWwJm == TargetModel.CollisionType.Headshot)
					{
						_C6cjmtLovCejw2N3OZYswcoYxsd++;
						_gabFSY9HcJdPu830plKx8W936qG._xDFlaclLtJxSUU63JEJALvRLdfe();
						_G0GwJ5OWQOA4BjacW3XmFsyMFjz += 30;
						_xaBDiofMkYNdWQ4me0hnZ4NsCnk(_TcTPQp3KE5mO2mYA6sSQDbHnhAw.X, _TcTPQp3KE5mO2mYA6sSQDbHnhAw.Y, "30!", Color.Yellow);
						_OJbyketBmeLlVtChfay03TIx5KM._kf3EbE0B70xGe1szklqAZyCqoLj = false;
						_OJbyketBmeLlVtChfay03TIx5KM._DcBCpcEfsjl4zP1zbrOrd1bwNReb(delegate
						{
							_5b1aUCG2FfD5yQCBUDAoLZYMu7A(0f, delegate
							{
								_PFrgvj2zYkmkbPmVfpiUnTvLsoC(_OJbyketBmeLlVtChfay03TIx5KM);
							});
						});
						_5b1aUCG2FfD5yQCBUDAoLZYMu7A(0f, _SeJVPxt5mkxE2oaiV4gLg7Iiar);
					}
					else if (_0U2R42Dbf2ddmyfQBv0z7zBWwJm == TargetModel.CollisionType.Bodyshot)
					{
						_pL6aoe4HLq4X3yQACLFyUH3xwBp++;
						_Hsn6Qz2oeKaTkin9XGwBJUJqy1C._xDFlaclLtJxSUU63JEJALvRLdfe();
						_G0GwJ5OWQOA4BjacW3XmFsyMFjz += 10;
						_xaBDiofMkYNdWQ4me0hnZ4NsCnk(_TcTPQp3KE5mO2mYA6sSQDbHnhAw.X, _TcTPQp3KE5mO2mYA6sSQDbHnhAw.Y, "10!", Color.Red);
						_OJbyketBmeLlVtChfay03TIx5KM._kf3EbE0B70xGe1szklqAZyCqoLj = false;
						_OJbyketBmeLlVtChfay03TIx5KM._u1yq8F9lG8oMcA9vZO9c7Qbh8vj(delegate
						{
							_5b1aUCG2FfD5yQCBUDAoLZYMu7A(0f, delegate
							{
								_PFrgvj2zYkmkbPmVfpiUnTvLsoC(_OJbyketBmeLlVtChfay03TIx5KM);
							});
						});
						_5b1aUCG2FfD5yQCBUDAoLZYMu7A(0f, _SeJVPxt5mkxE2oaiV4gLg7Iiar);
					}
					flag = true;
					break;
				}
				if (!flag)
				{
					RailInfo railInfo = _HYME5rEMzi5Cag9e7DCXk5lrXwX.FirstOrDefault((RailInfo railInfo_0) => _TcTPQp3KE5mO2mYA6sSQDbHnhAw.Y < railInfo_0.Y);
					_Kp1esj4V82aePkZwvlresNSkHsC(_TcTPQp3KE5mO2mYA6sSQDbHnhAw.X, _TcTPQp3KE5mO2mYA6sSQDbHnhAw.Y, railInfo?._fO7gSlrDDNMoHR4FO5QXAq8fUyA ?? 1f);
					_dH7hlTzeJboGa5rfpgerBfCmyKO++;
					_Oeqego17TDqmByfLbOEB1isMXzJ._xDFlaclLtJxSUU63JEJALvRLdfe();
				}
			}
			else
			{
				_RiMZpLLSGIesSXF8vhSlVQ8SrDg._xDFlaclLtJxSUU63JEJALvRLdfe();
			}
		}
		if (!_eMnDHRem25x38ZqmbzZLc1CLkwlA && (base.Game._RbWJ7YGnYHCSoD44MRW1h5X6E7E._fy5ebLnmRsRXv9v7RKTFU5CGMaH(_PMeRYZJaBCqgB9uADJFP3c14lxq.RightButton) || base.Game._RbWJ7YGnYHCSoD44MRW1h5X6E7E._fy5ebLnmRsRXv9v7RKTFU5CGMaH(Keys.R) || base.Game._RbWJ7YGnYHCSoD44MRW1h5X6E7E._fy5ebLnmRsRXv9v7RKTFU5CGMaH(Keys.Space)))
		{
			_eMnDHRem25x38ZqmbzZLc1CLkwlA = true;
			_nHs33RHZMuYhYev0dQ6ic0aHmvO = true;
			_ykeARom1bl7r01BeRXMOSqoJU6o._xDFlaclLtJxSUU63JEJALvRLdfe();
			_85WqOX8OcxbI6g74CaBZtHiHK2m._hAt3H7isKECkVrQjY4L0hESiqLF(delegate
			{
				_YFr89aAV3UzO9kf7kPKQJilRWED = 6;
				_eMnDHRem25x38ZqmbzZLc1CLkwlA = false;
				_nHs33RHZMuYhYev0dQ6ic0aHmvO = false;
			});
		}
	}

	private void _SeJVPxt5mkxE2oaiV4gLg7Iiar()
	{
		if (_dxhbACq6BB89IAMy6ZOALWJgv7L == GameState.Started)
		{
			int num = _u8GaIYUzQ65BoFU3NzXBzyvujjbA.Count((TargetModel targetModel_0) => targetModel_0._kf3EbE0B70xGe1szklqAZyCqoLj);
			for (int i = num; i < _M8VVMN3GHWWmFmORCACqNTXVh6b; i++)
			{
				_OLpKeyCIa9e3g4oTFOGxKKmVbHJ();
			}
		}
	}

	private void _OLpKeyCIa9e3g4oTFOGxKKmVbHJ()
	{
		RailInfo railInfo = _HYME5rEMzi5Cag9e7DCXk5lrXwX[_boyt8NIMtKsAGSTcjHeL0WMbFxs._07xTWbIEgzxJYsYwFKDbbKNvu4G(0, _HYME5rEMzi5Cag9e7DCXk5lrXwX.Length)];
		int int_ = _boyt8NIMtKsAGSTcjHeL0WMbFxs._07xTWbIEgzxJYsYwFKDbbKNvu4G(railInfo._SjhHztt8d5kOtb7Z2BJKnZZxEKh, railInfo._nVnyJkkce6HsdRrKSpRrzUDElg0);
		TargetModel _OJbyketBmeLlVtChfay03TIx5KM = new TargetModel(this, int_, railInfo.Y, railInfo._fO7gSlrDDNMoHR4FO5QXAq8fUyA)
		{
			_kf3EbE0B70xGe1szklqAZyCqoLj = true
		};
		_OJbyketBmeLlVtChfay03TIx5KM._edcakvTOp2fd2J9ZHAu9GKjDaN7();
		_u8GaIYUzQ65BoFU3NzXBzyvujjbA.Add(_OJbyketBmeLlVtChfay03TIx5KM);
		_7oYtfGpL7UyAQrZxew7Ahbvj6Sv(_OJbyketBmeLlVtChfay03TIx5KM, railInfo.Layer);
		_u8GaIYUzQ65BoFU3NzXBzyvujjbA = _u8GaIYUzQ65BoFU3NzXBzyvujjbA.OrderByDescending((TargetModel targetModel_0) => targetModel_0._ac2H6kMdrgPhXXxabsikjji4SiT).ToList();
		_5b1aUCG2FfD5yQCBUDAoLZYMu7A(3.5f, delegate
		{
			if (_OJbyketBmeLlVtChfay03TIx5KM._kf3EbE0B70xGe1szklqAZyCqoLj && _dxhbACq6BB89IAMy6ZOALWJgv7L != GameState.GameOver)
			{
				_JvgphfrWtBncPfgb6ERRVKKtlQG++;
				_OJbyketBmeLlVtChfay03TIx5KM._kf3EbE0B70xGe1szklqAZyCqoLj = false;
				_OJbyketBmeLlVtChfay03TIx5KM._u1yq8F9lG8oMcA9vZO9c7Qbh8vj(delegate
				{
					_5b1aUCG2FfD5yQCBUDAoLZYMu7A(0f, delegate
					{
						_PFrgvj2zYkmkbPmVfpiUnTvLsoC(_OJbyketBmeLlVtChfay03TIx5KM);
					});
				});
				_5b1aUCG2FfD5yQCBUDAoLZYMu7A(0f, _SeJVPxt5mkxE2oaiV4gLg7Iiar);
			}
		});
	}

	private void _PFrgvj2zYkmkbPmVfpiUnTvLsoC(TargetModel targetModel_0)
	{
		_u8GaIYUzQ65BoFU3NzXBzyvujjbA.Remove(targetModel_0);
		base.Layers.Remove(targetModel_0);
	}

	private void _g0eYquQ8BcifsIs5UMyAIkXM5paA(float float_0)
	{
		if (base.Game._RbWJ7YGnYHCSoD44MRW1h5X6E7E._fy5ebLnmRsRXv9v7RKTFU5CGMaH(Keys.Enter))
		{
			ResetProgression();
		}
		else if (base.Game._RbWJ7YGnYHCSoD44MRW1h5X6E7E._fy5ebLnmRsRXv9v7RKTFU5CGMaH(Keys.Escape))
		{
			_dxhbACq6BB89IAMy6ZOALWJgv7L = GameState.None;
			_5Z9jaXDcRYm0wNlEm1aTutL9kSH();
		}
	}

	protected abstract void _5Z9jaXDcRYm0wNlEm1aTutL9kSH();

	private void ResetProgression()
	{
		_0zKXRrSXqoTAuTYQNrJIgtt7Emq = 90f;
		_G0GwJ5OWQOA4BjacW3XmFsyMFjz = 0;
		_JvgphfrWtBncPfgb6ERRVKKtlQG = 0;
		_dH7hlTzeJboGa5rfpgerBfCmyKO = 0;
		_C6cjmtLovCejw2N3OZYswcoYxsd = 0;
		_pL6aoe4HLq4X3yQACLFyUH3xwBp = 0;
		_YFr89aAV3UzO9kf7kPKQJilRWED = 0;
		_xEG3axnWkco0Erk0PdjakXDULcA.Clear();
		_d9mstkVrU6KGDJyOtHGgrr2ZciA.Clear();
		foreach (TargetModel item in _u8GaIYUzQ65BoFU3NzXBzyvujjbA)
		{
			base.Layers.Remove(item);
		}
		_u8GaIYUzQ65BoFU3NzXBzyvujjbA.Clear();
		_dxhbACq6BB89IAMy6ZOALWJgv7L = GameState.NotStarted;
	}

	public override void Draw(SpriteBatch spriteBatch_0, SkeletonMeshRenderer skeletonMeshRenderer_0, Matrix matrix_0)
	{
		base.Draw(spriteBatch_0, skeletonMeshRenderer_0, matrix_0);
		spriteBatch_0.Begin();
		_LSweOA3cIPq1IjLzplF4mDludQf(spriteBatch_0);
		spriteBatch_0.DrawString(_MnMUFBDfrGZBHvrJ30IAQilqivI, "Score: " + _G0GwJ5OWQOA4BjacW3XmFsyMFjz, new Vector2(10f, 10f), Color.White);
		spriteBatch_0.DrawString(_6YCQhlMaqcDds8uGX1g8fjBKqV4A, "Targets missed: " + _JvgphfrWtBncPfgb6ERRVKKtlQG, new Vector2(10f, 60f), Color.White);
		spriteBatch_0.DrawString(_6YCQhlMaqcDds8uGX1g8fjBKqV4A, "Shots missed: " + _dH7hlTzeJboGa5rfpgerBfCmyKO, new Vector2(10f, 80f), Color.White);
		spriteBatch_0.DrawString(_6YCQhlMaqcDds8uGX1g8fjBKqV4A, "Bodyshots: " + _pL6aoe4HLq4X3yQACLFyUH3xwBp, new Vector2(10f, 100f), Color.White);
		spriteBatch_0.DrawString(_6YCQhlMaqcDds8uGX1g8fjBKqV4A, "Headshots: " + _C6cjmtLovCejw2N3OZYswcoYxsd, new Vector2(10f, 120f), Color.White);
		int num = 5;
		int num2 = 0;
		while (num >= 0)
		{
			spriteBatch_0.Draw(_m1dNhD2jwJ6iTVUgUzMJUvnQFS, new Rectangle(1875 - 35 * num, 10, 30, 55), (num2 < _YFr89aAV3UzO9kf7kPKQJilRWED) ? _AWLddj1Rm2sqiBwYcJDngG0QaQI : (_AWLddj1Rm2sqiBwYcJDngG0QaQI * 0.5f));
			num--;
			num2++;
		}
		if (_YFr89aAV3UzO9kf7kPKQJilRWED == 0)
		{
			spriteBatch_0.DrawString(_MnMUFBDfrGZBHvrJ30IAQilqivI, "Reload!", new Vector2(1750f, 70f), Color.Red);
		}
		switch (_dxhbACq6BB89IAMy6ZOALWJgv7L)
		{
		case GameState.NotStarted:
			spriteBatch_0.DrawString(_MnMUFBDfrGZBHvrJ30IAQilqivI, "Press <Space/R/Mouse-R> to Reload and begin.", new Vector2((1920f - _YhybMVqCJnFekEXVbF1huXupDmh) / 2f, 10f), Color.Red);
			break;
		case GameState.Started:
			if (_0zKXRrSXqoTAuTYQNrJIgtt7Emq >= 0f)
			{
				if (_0zKXRrSXqoTAuTYQNrJIgtt7Emq > 10f)
				{
					spriteBatch_0.DrawString(_MnMUFBDfrGZBHvrJ30IAQilqivI, _0zKXRrSXqoTAuTYQNrJIgtt7Emq.ToString("F0"), new Vector2(960f, 10f), Color.White);
				}
				else
				{
					spriteBatch_0.DrawString(_MnMUFBDfrGZBHvrJ30IAQilqivI, _0zKXRrSXqoTAuTYQNrJIgtt7Emq.ToString("F1"), new Vector2(960f, 10f), Color.Red);
				}
			}
			break;
		case GameState.GameOver:
			spriteBatch_0.DrawString(_MnMUFBDfrGZBHvrJ30IAQilqivI, "Time up, Game over! Press <Enter> to retry or <Escape> to continue.", new Vector2((1920f - _MZh3nVRuDktDpIu8X149SF90ZjO) / 2f, 10f), Color.Red);
			break;
		}
		spriteBatch_0.End();
	}

	public override void End()
	{
		base.End();
		base.Game._LWcoDwIWvf8DT3nQmNe5z8fkUvI = _WD4Plg5m1AwZ5mVyjQCADcW1ZTk;
		_poenyHBGUusBcnNcTFB9MQBV72R._kf3EbE0B70xGe1szklqAZyCqoLj = _U8eNAZVBW15ZflhG4fel0hK3Juu;
	}

	private void _FCyUaxF0GIE1r2fyuYC4b4tGqpJ(float float_0)
	{
		if (_d9mstkVrU6KGDJyOtHGgrr2ZciA.Any())
		{
			foreach (IDrawable d9mstkVrU6KGDJyOtHGgrr2Zcium in _d9mstkVrU6KGDJyOtHGgrr2ZciA)
			{
				_xEG3axnWkco0Erk0PdjakXDULcA.Remove(d9mstkVrU6KGDJyOtHGgrr2Zcium);
			}
			_d9mstkVrU6KGDJyOtHGgrr2ZciA.Clear();
		}
		foreach (IDrawable item in _xEG3axnWkco0Erk0PdjakXDULcA.ToList())
		{
			if (!item._aeQckZZROopp0BqagEZE32fzkyr)
			{
				item.Update(float_0);
			}
			else
			{
				_d9mstkVrU6KGDJyOtHGgrr2ZciA.Add(item);
			}
		}
	}

	private void _LSweOA3cIPq1IjLzplF4mDludQf(SpriteBatch spriteBatch_0)
	{
		using List<IDrawable>.Enumerator enumerator = _xEG3axnWkco0Erk0PdjakXDULcA.GetEnumerator();
		if (enumerator.MoveNext())
		{
			IDrawable current = enumerator.Current;
			current.Draw(spriteBatch_0);
		}
	}

	private void _Vu9iV57zUVa3p8WMfOsDaoqv7wL(int int_0, int int_1, float float_0)
	{
		FrameAnimation frameAnimation = new FrameAnimation(this, "Assets/Scenes/ShootingRange/Explosion_12x1", 0.5f, 12, 125, 111, float_0);
		frameAnimation._QrgbXEg7MMeD9Ybz12fFVsbmAd9(int_0, int_1, _boyt8NIMtKsAGSTcjHeL0WMbFxs._S7DdtNZASTkc9riB27h5Ktq5VjDA(0f, 360f));
		_xEG3axnWkco0Erk0PdjakXDULcA.Add(frameAnimation);
	}

	private void _Kp1esj4V82aePkZwvlresNSkHsC(int int_0, int int_1, float float_0)
	{
		FrameAnimation frameAnimation = new FrameAnimation(this, "Assets/Scenes/ShootingRange/Smoke_12x1", 0.5f, 12, 122, 129, float_0);
		frameAnimation._QrgbXEg7MMeD9Ybz12fFVsbmAd9(int_0, int_1, 0f);
		_xEG3axnWkco0Erk0PdjakXDULcA.Add(frameAnimation);
	}

	private void _xaBDiofMkYNdWQ4me0hnZ4NsCnk(int int_0, int int_1, string string_0, Color color_0)
	{
		FloatingFeedbackDrawable item = new FloatingFeedbackDrawable(this, int_0, int_1, string_0, color_0);
		_xEG3axnWkco0Erk0PdjakXDULcA.Add(item);
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
			base.Game._aJh9CibG5YKhkExxgRyVopdfSeJ._vVZVLriSGPExpn1KeobglMabsoi("AchievementGeneric7");
		}
		if (_C6cjmtLovCejw2N3OZYswcoYxsd > 60)
		{
			base.Game._aJh9CibG5YKhkExxgRyVopdfSeJ._vVZVLriSGPExpn1KeobglMabsoi("AchievementGeneric8");
		}
		if (_dH7hlTzeJboGa5rfpgerBfCmyKO == 0)
		{
			base.Game._aJh9CibG5YKhkExxgRyVopdfSeJ._vVZVLriSGPExpn1KeobglMabsoi("AchievementGeneric9");
		}
		if (_JvgphfrWtBncPfgb6ERRVKKtlQG < 30)
		{
			base.Game._aJh9CibG5YKhkExxgRyVopdfSeJ._vVZVLriSGPExpn1KeobglMabsoi("AchievementGeneric10");
		}
	}
}
