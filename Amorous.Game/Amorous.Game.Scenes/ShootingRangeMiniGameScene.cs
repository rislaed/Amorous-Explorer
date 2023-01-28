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

		private readonly Vector2 Center;

		private readonly float _q2YaOk0V93J3GMeWTOtcGdh9kEA;

		private readonly int _hUTZltYwRfIdEri4M059hyQus5H;

		private int _Lb7cMVSwXw3dYaQEnyADfQZoUedb;

		private float _MZBGPP8CHYYeh1lAhvANLxmu8KVA;

		private float Stopwatch;

		public bool _aeQckZZROopp0BqagEZE32fzkyr { get; private set; }

		public FrameAnimation(AbstractScene scene, string string_0, float float_0, int int_0, int int_1, int int_2, float float_1)
		{
			_uZYA4qnOfbVDFtZ6Ih3HawZgErP = scene.Game.Content.Load<Texture2D>(string_0);
			_q2YaOk0V93J3GMeWTOtcGdh9kEA = float_0 / (float)int_0;
			_hUTZltYwRfIdEri4M059hyQus5H = int_0;
			_Lb7cMVSwXw3dYaQEnyADfQZoUedb = 0;
			_jqsWTJ89RIZpjBr65dNZzmpJJKE = new Rectangle(0, 0, (int)((float)_uZYA4qnOfbVDFtZ6Ih3HawZgErP.Width / 12f), _uZYA4qnOfbVDFtZ6Ih3HawZgErP.Height);
			_NbYrjABARmnikNXQHmmbM8k62UE = new Rectangle(0, 0, (int)((float)_jqsWTJ89RIZpjBr65dNZzmpJJKE.Width * float_1), (int)((float)_jqsWTJ89RIZpjBr65dNZzmpJJKE.Height * float_1));
			Center = new Vector2(int_1, int_2);
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
				Stopwatch += float_0;
				while (Stopwatch > _q2YaOk0V93J3GMeWTOtcGdh9kEA)
				{
					Stopwatch -= _q2YaOk0V93J3GMeWTOtcGdh9kEA;
					_Lb7cMVSwXw3dYaQEnyADfQZoUedb++;
				}
				if (_Lb7cMVSwXw3dYaQEnyADfQZoUedb < _hUTZltYwRfIdEri4M059hyQus5H)
				{
					_jqsWTJ89RIZpjBr65dNZzmpJJKE.X = _Lb7cMVSwXw3dYaQEnyADfQZoUedb * _jqsWTJ89RIZpjBr65dNZzmpJJKE.Width;
				}
				else
				{
					Remove();
				}
			}
		}

		public void Draw(SpriteBatch spriteBatch)
		{
			if (_Lb7cMVSwXw3dYaQEnyADfQZoUedb >= 0)
			{
				spriteBatch.Draw(_uZYA4qnOfbVDFtZ6Ih3HawZgErP, _NbYrjABARmnikNXQHmmbM8k62UE, _jqsWTJ89RIZpjBr65dNZzmpJJKE, Color.White, _MZBGPP8CHYYeh1lAhvANLxmu8KVA, Center, SpriteEffects.None, 0f);
			}
		}

		public void Remove()
		{
			_Lb7cMVSwXw3dYaQEnyADfQZoUedb = -1;
			_aeQckZZROopp0BqagEZE32fzkyr = true;
		}
	}

	private class TargetModel : SpineDrawableLayer
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

		private readonly SpineRenderer _pO4d7wyWlp6cYLHahUVYplpUWxw;

		public bool _kf3EbE0B70xGe1szklqAZyCqoLj { get; set; }

		public new float Scale => _i8C0PwO83NRzGvNoyMhHwLV9HeC;

		public TargetModel(AbstractScene scene, int int_0, int int_1, float float_0 = 1f)
			: base(scene, "Target")
		{
			base.OnUpdate = delegate(GameTime gameTime)
			{
				_pO4d7wyWlp6cYLHahUVYplpUWxw.Update(gameTime);
			};
			base.OnSpineDraw = delegate(SpriteBatch spriteBatch, SkeletonMeshRenderer skeletonMeshRenderer)
			{
				_pO4d7wyWlp6cYLHahUVYplpUWxw.Draw(skeletonMeshRenderer, null, null, null, _i8C0PwO83NRzGvNoyMhHwLV9HeC);
			};
			_pO4d7wyWlp6cYLHahUVYplpUWxw = scene.Game.Content.LoadSkeleton("Assets/Scenes/ShootingRange/Target");
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
			_pO4d7wyWlp6cYLHahUVYplpUWxw.StartAnimation("Rise", action_0);
		}

		public void _DcBCpcEfsjl4zP1zbrOrd1bwNReb(Action action_0 = null)
		{
			_pO4d7wyWlp6cYLHahUVYplpUWxw.StartAnimation("Headshot", action_0);
		}

		public void _u1yq8F9lG8oMcA9vZO9c7Qbh8vj(Action action_0 = null)
		{
			_pO4d7wyWlp6cYLHahUVYplpUWxw.StartAnimation("Bodyshot", action_0);
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

	private class GunModel : SpineDrawableLayer
	{
		private readonly SpineRenderer _XcQKV7iP9Sk10poAFYuakLJaltL;

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

		public bool Flip
		{
			set
			{
				_XcQKV7iP9Sk10poAFYuakLJaltL.FlipX = value;
			}
		}

		public GunModel(AbstractScene scene)
			: base(scene, "GunModel")
		{
			base.OnUpdate = delegate(GameTime gameTime)
			{
				_XcQKV7iP9Sk10poAFYuakLJaltL.Update(gameTime);
			};
			base.OnSpineDraw = delegate(SpriteBatch spriteBatch, SkeletonMeshRenderer skeletonMeshRenderer)
			{
				_XcQKV7iP9Sk10poAFYuakLJaltL.Draw(skeletonMeshRenderer, null, null, null, Scale);
			};
			_XcQKV7iP9Sk10poAFYuakLJaltL = scene.Game.Content.LoadSkeleton("Assets/GUI/Phone/Phone");
			_XcQKV7iP9Sk10poAFYuakLJaltL.ApplyFrame("Arm rise", 0f);
			_XcQKV7iP9Sk10poAFYuakLJaltL.SetVisibility(0f);
			_XcQKV7iP9Sk10poAFYuakLJaltL.X = 0f;
			_XcQKV7iP9Sk10poAFYuakLJaltL.Y = 1080f;
			PlayerData data = PlayerPreferences.GetPlayerData();
			bool flag = data.MarkingsType.HasFlag(PlayerData.EMarkingsType.LongForearm);
			bool flag2;
			Color color_ = ((flag2 = data.MarkingsType.HasFlag(PlayerData.EMarkingsType.ShortForearm)) ? data.ShortForearmColor : (flag ? data.LongForearmColor : Color.White));
			_XcQKV7iP9Sk10poAFYuakLJaltL.SetAlpha("Hoody Sleeve", 0f);
			_XcQKV7iP9Sk10poAFYuakLJaltL.SetAlpha("Default Forearm", 1f);
			_XcQKV7iP9Sk10poAFYuakLJaltL.SetColor("Default Forearm", data.BodyColor);
			_XcQKV7iP9Sk10poAFYuakLJaltL.SetAlpha("Marking Forearm", (flag2 || flag) ? 1 : 0);
			_XcQKV7iP9Sk10poAFYuakLJaltL.SetColor("Marking Forearm", color_);
			_XcQKV7iP9Sk10poAFYuakLJaltL.SetAlpha("Striped forearm", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Stripes) ? 1 : 0);
			_XcQKV7iP9Sk10poAFYuakLJaltL.SetColor("Striped forearm", data.StripesColor);
			_XcQKV7iP9Sk10poAFYuakLJaltL.SetAlpha("Avian Forearm", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.AvianForearm) ? 1 : 0);
			_XcQKV7iP9Sk10poAFYuakLJaltL.SetColor("Avian Forearm", data.AvianForearmColor);
			_XcQKV7iP9Sk10poAFYuakLJaltL.SetAlpha("Hand", 1f);
			_XcQKV7iP9Sk10poAFYuakLJaltL.SetColor("Hand", data.BodyColor);
			_XcQKV7iP9Sk10poAFYuakLJaltL.SetAlpha("Marking Hand", (flag2 || flag) ? 1 : 0);
			_XcQKV7iP9Sk10poAFYuakLJaltL.SetColor("Marking Hand", color_);
			_XcQKV7iP9Sk10poAFYuakLJaltL.SetAlpha("Avian Hand", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.AvianForearm) ? 1 : 0);
			_XcQKV7iP9Sk10poAFYuakLJaltL.SetColor("Avian Hand", data.AvianForearmColor);
			_XcQKV7iP9Sk10poAFYuakLJaltL.SetAlpha("Index", 1f);
			_XcQKV7iP9Sk10poAFYuakLJaltL.SetColor("Index", data.BodyColor);
			_XcQKV7iP9Sk10poAFYuakLJaltL.SetAlpha("Avian index", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.AvianForearm) ? 1 : 0);
			_XcQKV7iP9Sk10poAFYuakLJaltL.SetColor("Avian index", data.AvianForearmColor);
			_XcQKV7iP9Sk10poAFYuakLJaltL.SetAlpha("Pinky", 1f);
			_XcQKV7iP9Sk10poAFYuakLJaltL.SetColor("Pinky", data.BodyColor);
			_XcQKV7iP9Sk10poAFYuakLJaltL.SetAlpha("Avian Pinky", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.AvianForearm) ? 1 : 0);
			_XcQKV7iP9Sk10poAFYuakLJaltL.SetColor("Avian Pinky", data.AvianForearmColor);
			_XcQKV7iP9Sk10poAFYuakLJaltL.SetAlpha("Ring", 1f);
			_XcQKV7iP9Sk10poAFYuakLJaltL.SetColor("Ring", data.BodyColor);
			_XcQKV7iP9Sk10poAFYuakLJaltL.SetAlpha("Avian ring", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.AvianForearm) ? 1 : 0);
			_XcQKV7iP9Sk10poAFYuakLJaltL.SetColor("Avian ring", data.AvianForearmColor);
			_XcQKV7iP9Sk10poAFYuakLJaltL.SetAlpha("Rude", 1f);
			_XcQKV7iP9Sk10poAFYuakLJaltL.SetColor("Rude", data.BodyColor);
			_XcQKV7iP9Sk10poAFYuakLJaltL.SetAlpha("Avian Rude", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.AvianForearm) ? 1 : 0);
			_XcQKV7iP9Sk10poAFYuakLJaltL.SetColor("Avian Rude", data.AvianForearmColor);
			_XcQKV7iP9Sk10poAFYuakLJaltL.SetAlpha("Thumb", 1f);
			_XcQKV7iP9Sk10poAFYuakLJaltL.SetColor("Thumb", data.BodyColor);
			_XcQKV7iP9Sk10poAFYuakLJaltL.SetAlpha("Avian Thumb", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.AvianForearm) ? 1 : 0);
			_XcQKV7iP9Sk10poAFYuakLJaltL.SetColor("Avian Thumb", data.AvianForearmColor);
			_XcQKV7iP9Sk10poAFYuakLJaltL.SetAlpha("Pinky Nail", data.ShowNails ? 1 : 0);
			_XcQKV7iP9Sk10poAFYuakLJaltL.SetColor("Pinky Nail", data.NailColor);
			_XcQKV7iP9Sk10poAFYuakLJaltL.SetAlpha("Ring Nail", data.ShowNails ? 1 : 0);
			_XcQKV7iP9Sk10poAFYuakLJaltL.SetColor("Ring Nail", data.NailColor);
			_XcQKV7iP9Sk10poAFYuakLJaltL.SetAlpha("Rude Nail", data.ShowNails ? 1 : 0);
			_XcQKV7iP9Sk10poAFYuakLJaltL.SetColor("Rude Nail", data.NailColor);
			_XcQKV7iP9Sk10poAFYuakLJaltL.SetAlpha("Index Nail", data.ShowNails ? 1 : 0);
			_XcQKV7iP9Sk10poAFYuakLJaltL.SetColor("Index Nail", data.NailColor);
			_XcQKV7iP9Sk10poAFYuakLJaltL.SetAlpha("Thumb Nail", data.ShowNails ? 1 : 0);
			_XcQKV7iP9Sk10poAFYuakLJaltL.SetColor("Thumb Nail", data.NailColor);
			_XcQKV7iP9Sk10poAFYuakLJaltL.SetAlpha("Muzzle flash", 1f);
			_XcQKV7iP9Sk10poAFYuakLJaltL.SetAlpha("Gun casing", 1f);
			_XcQKV7iP9Sk10poAFYuakLJaltL.SetAlpha("Gun", 1f);
			_XcQKV7iP9Sk10poAFYuakLJaltL.SetAlpha("Gun Slide", 1f);
		}

		public void _edcakvTOp2fd2J9ZHAu9GKjDaN7(Action action_0 = null)
		{
			_XcQKV7iP9Sk10poAFYuakLJaltL.StartAnimation("Gun rise", delegate
			{
				_3AjdlsblH9b6FNnDEW7N5sQ8iHs();
				action_0?.Invoke();
			});
		}

		private void _3AjdlsblH9b6FNnDEW7N5sQ8iHs()
		{
			_XcQKV7iP9Sk10poAFYuakLJaltL.StartAnimationWithLooping("Gun Idle");
		}

		public void _e2DHCcfpFNWn5NTzMOw3FBUkwzA()
		{
			_XcQKV7iP9Sk10poAFYuakLJaltL.StartAnimation("Gun Shoot", _3AjdlsblH9b6FNnDEW7N5sQ8iHs);
		}

		public void _hAt3H7isKECkVrQjY4L0hESiqLF(Action action_0 = null)
		{
			_XcQKV7iP9Sk10poAFYuakLJaltL.StartAnimation("Gun reload", delegate
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

		void Draw(SpriteBatch spriteBatch);

		void Remove();
	}

	private class FloatingFeedbackDrawable : IDrawable
	{
		private const float _HS0I0EgJMjmRXhZ0KDhLBBA2VkE = 0.8f;

		private const float _YBMjlnwxHIEUKERmDSGIKOlw2aM = 100f;

		private readonly SpriteFont _font;

		private readonly float _nD28BmrDaEzCHelTAa14TKyuSyG;

		private float _LkckKdvuh9GaAwn7XojfbJBd91r;

		private readonly string Text;

		private readonly Color _JbGNnZhaeWyNm0aWm7TtSamww4C;

		private float _AQwQu1ldCtpbkD5F9oEByJdCnWaA;

		public bool _aeQckZZROopp0BqagEZE32fzkyr { get; private set; }

		public FloatingFeedbackDrawable(AbstractScene scene, int int_0, int int_1, string string_0, Color color_0)
		{
			_font = scene.Game.Content.Load<SpriteFont>("Assets/GUI/Fonts/Bold-26");
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

		public void Draw(SpriteBatch spriteBatch)
		{
			spriteBatch.DrawString(_font, Text, new Vector2(_nD28BmrDaEzCHelTAa14TKyuSyG, _LkckKdvuh9GaAwn7XojfbJBd91r), _JbGNnZhaeWyNm0aWm7TtSamww4C * _AQwQu1ldCtpbkD5F9oEByJdCnWaA);
		}

		public void Remove()
		{
		}
	}

	private class TimedDrawable : IDrawable
	{
		private float Value;

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
				Value += float_0;
				if (Value > _x2m0UxhUAD6cdIEszjrShiRmPfx)
				{
					Remove();
				}
			}
		}

		public void Draw(SpriteBatch spriteBatch)
		{
		}

		public void Remove()
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

		public readonly float Scale;

		public readonly int Layer;

		public RailInfo(int int_0, int int_1, int int_2, float float_0, int int_3)
		{
			_SjhHztt8d5kOtb7Z2BJKnZZxEKh = int_0;
			_nVnyJkkce6HsdRrKSpRrzUDElg0 = int_1;
			Y = int_2;
			Scale = float_0;
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

	private readonly TexturedLayer _tvM0bxD4ITME03hjc6seyYclzxf;

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
		: base(game)
	{
		_WD4Plg5m1AwZ5mVyjQCADcW1ZTk = Game.IsRenderingCursor;
		Game.IsRenderingCursor = false;
		_U8eNAZVBW15ZflhG4fel0hK3Juu = PhoneOverlay._kf3EbE0B70xGe1szklqAZyCqoLj;
		PhoneOverlay._kf3EbE0B70xGe1szklqAZyCqoLj = false;
		FadingMediaPlayer.BeginCutscene();
		_vCjkdRWXT5mvEu0c22Hgh93luLg = new _hqmu3NsKXqziXGfVh3dt79G0fye(Game.Content);
		_vCjkdRWXT5mvEu0c22Hgh93luLg._cHRhcv3PTfJmYNZAZdcHvbfbkpj("Assets/Sounds/MiniGames/ShootingRange/Fire");
		_RiMZpLLSGIesSXF8vhSlVQ8SrDg = new _hqmu3NsKXqziXGfVh3dt79G0fye(Game.Content);
		_RiMZpLLSGIesSXF8vhSlVQ8SrDg._cHRhcv3PTfJmYNZAZdcHvbfbkpj("Assets/Sounds/MiniGames/ShootingRange/Dry");
		_ykeARom1bl7r01BeRXMOSqoJU6o = new _hqmu3NsKXqziXGfVh3dt79G0fye(Game.Content);
		_ykeARom1bl7r01BeRXMOSqoJU6o._cHRhcv3PTfJmYNZAZdcHvbfbkpj("Assets/Sounds/MiniGames/ShootingRange/Reload");
		_gabFSY9HcJdPu830plKx8W936qG = new _hqmu3NsKXqziXGfVh3dt79G0fye(Game.Content);
		_gabFSY9HcJdPu830plKx8W936qG._cHRhcv3PTfJmYNZAZdcHvbfbkpj("Assets/Sounds/MiniGames/ShootingRange/Headshot 1", "Assets/Sounds/MiniGames/ShootingRange/Headshot 2");
		_Hsn6Qz2oeKaTkin9XGwBJUJqy1C = new _hqmu3NsKXqziXGfVh3dt79G0fye(Game.Content);
		_Hsn6Qz2oeKaTkin9XGwBJUJqy1C._cHRhcv3PTfJmYNZAZdcHvbfbkpj("Assets/Sounds/MiniGames/ShootingRange/Impact 1", "Assets/Sounds/MiniGames/ShootingRange/Impact 2", "Assets/Sounds/MiniGames/ShootingRange/Impact 3");
		_Oeqego17TDqmByfLbOEB1isMXzJ = new _hqmu3NsKXqziXGfVh3dt79G0fye(Game.Content);
		_Oeqego17TDqmByfLbOEB1isMXzJ._cHRhcv3PTfJmYNZAZdcHvbfbkpj("Assets/Sounds/MiniGames/ShootingRange/Ricochete 1", "Assets/Sounds/MiniGames/ShootingRange/Ricochete 2", "Assets/Sounds/MiniGames/ShootingRange/Ricochete 3");
		_m1dNhD2jwJ6iTVUgUzMJUvnQFS = base.Game.Content.Load<Texture2D>("Assets/Scenes/ShootingRange/Bullet");
		AddLayer(NewTexturedLayer("Backdrop", "Assets/Scenes/ShootingRange/Backdrop", 600, 180), 0);
		AddLayer(NewTexturedLayer("Background", "Assets/Scenes/ShootingRange/Background", 0, 0), 2);
		AddLayer(NewTexturedLayer("Countertop", "Assets/Scenes/ShootingRange/Countertop", 0, 0), 6);
		_6YCQhlMaqcDds8uGX1g8fjBKqV4A = Game.Content.Load<SpriteFont>("Assets/GUI/Fonts/Bold-14");
		_MnMUFBDfrGZBHvrJ30IAQilqivI = Game.Content.Load<SpriteFont>("Assets/GUI/Fonts/Bold-26");
		_AWLddj1Rm2sqiBwYcJDngG0QaQI = PlayerPreferences.GetPlayerData().PhoneColor;
		_tvM0bxD4ITME03hjc6seyYclzxf = NewTexturedLayer("Crosshair", "Assets/Scenes/ShootingRange/Crosshair", 0, 0);
		_tvM0bxD4ITME03hjc6seyYclzxf.Color = _AWLddj1Rm2sqiBwYcJDngG0QaQI;
		AddLayer(_tvM0bxD4ITME03hjc6seyYclzxf, 7);
		_85WqOX8OcxbI6g74CaBZtHiHK2m = new GunModel(this)
		{
			X = 1820f,
			Y = 1080f,
			Scale = 0.5f,
			Flip = true
		};
		AddLayer(_85WqOX8OcxbI6g74CaBZtHiHK2m, 8);
		_85WqOX8OcxbI6g74CaBZtHiHK2m._edcakvTOp2fd2J9ZHAu9GKjDaN7();
		_u8GaIYUzQ65BoFU3NzXBzyvujjbA = new List<TargetModel>();
		_xEG3axnWkco0Erk0PdjakXDULcA = new List<IDrawable>();
		_d9mstkVrU6KGDJyOtHGgrr2ZciA = new List<IDrawable>();
		_YhybMVqCJnFekEXVbF1huXupDmh = _MnMUFBDfrGZBHvrJ30IAQilqivI.MeasureString("Press <Space/R/Mouse-R> to Reload and begin.").X;
		_MZh3nVRuDktDpIu8X149SF90ZjO = _MnMUFBDfrGZBHvrJ30IAQilqivI.MeasureString("Time up, Game over! Press <Enter> to retry or <Escape> to continue.").X;
		_0zKXRrSXqoTAuTYQNrJIgtt7Emq = 90f;
		_M8VVMN3GHWWmFmORCACqNTXVh6b = 1;
		FadingMediaPlayer._l94kUraQ13OohoVwwxKC37hG7Pc("Assets/Music/Mittsies - Mech", 0.4f);
		_dxhbACq6BB89IAMy6ZOALWJgv7L = GameState.NotStarted;
	}

	public override void Update(GameTime gameTime)
	{
		float float_ = (float)gameTime.ElapsedGameTime.Milliseconds / 1000f;
		if (_F2ao1gdMb4UciyKC7Zly4by95Mn && base.Game.Controller.JustPressed(Keys.Escape))
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
		_TcTPQp3KE5mO2mYA6sSQDbHnhAw = base.Game.Mouse._2j5HjqIBNOwD2br7yBprKdzVhAK(base.Game.Controller.Cursor);
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
		base.Update(gameTime);
	}

	private void _fFSom2DrN3XLCdgmD5vZaJmWP7G(float float_0)
	{
		if (!_eMnDHRem25x38ZqmbzZLc1CLkwlA && (base.Game.Controller.JustPressed(ControllerButtonType.RightButton) || base.Game.Controller.JustPressed(Keys.R) || base.Game.Controller.JustPressed(Keys.Space)))
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
		if (!_eMnDHRem25x38ZqmbzZLc1CLkwlA && !_nHs33RHZMuYhYev0dQ6ic0aHmvO && base.Game.Controller.JustPressed(ControllerButtonType.LeftButton))
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
					_Vu9iV57zUVa3p8WMfOsDaoqv7wL(_TcTPQp3KE5mO2mYA6sSQDbHnhAw.X, _TcTPQp3KE5mO2mYA6sSQDbHnhAw.Y, _OJbyketBmeLlVtChfay03TIx5KM.Scale);
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
					_Kp1esj4V82aePkZwvlresNSkHsC(_TcTPQp3KE5mO2mYA6sSQDbHnhAw.X, _TcTPQp3KE5mO2mYA6sSQDbHnhAw.Y, railInfo?.Scale ?? 1f);
					_dH7hlTzeJboGa5rfpgerBfCmyKO++;
					_Oeqego17TDqmByfLbOEB1isMXzJ._xDFlaclLtJxSUU63JEJALvRLdfe();
				}
			}
			else
			{
				_RiMZpLLSGIesSXF8vhSlVQ8SrDg._xDFlaclLtJxSUU63JEJALvRLdfe();
			}
		}
		if (!_eMnDHRem25x38ZqmbzZLc1CLkwlA && (base.Game.Controller.JustPressed(ControllerButtonType.RightButton) || base.Game.Controller.JustPressed(Keys.R) || base.Game.Controller.JustPressed(Keys.Space)))
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
		RailInfo railInfo = _HYME5rEMzi5Cag9e7DCXk5lrXwX[Randoms.Next(0, _HYME5rEMzi5Cag9e7DCXk5lrXwX.Length)];
		int int_ = Randoms.Next(railInfo._SjhHztt8d5kOtb7Z2BJKnZZxEKh, railInfo._nVnyJkkce6HsdRrKSpRrzUDElg0);
		TargetModel _OJbyketBmeLlVtChfay03TIx5KM = new TargetModel(this, int_, railInfo.Y, railInfo.Scale)
		{
			_kf3EbE0B70xGe1szklqAZyCqoLj = true
		};
		_OJbyketBmeLlVtChfay03TIx5KM._edcakvTOp2fd2J9ZHAu9GKjDaN7();
		_u8GaIYUzQ65BoFU3NzXBzyvujjbA.Add(_OJbyketBmeLlVtChfay03TIx5KM);
		AddLayer(_OJbyketBmeLlVtChfay03TIx5KM, railInfo.Layer);
		_u8GaIYUzQ65BoFU3NzXBzyvujjbA = _u8GaIYUzQ65BoFU3NzXBzyvujjbA.OrderByDescending((TargetModel targetModel_0) => targetModel_0.ZOrder).ToList();
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
		if (base.Game.Controller.JustPressed(Keys.Enter))
		{
			ResetProgression();
		}
		else if (base.Game.Controller.JustPressed(Keys.Escape))
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

	public override void Draw(SpriteBatch spriteBatch, SkeletonMeshRenderer skeletonMeshRenderer, Matrix matrix_0)
	{
		base.Draw(spriteBatch, skeletonMeshRenderer, matrix_0);
		spriteBatch.Begin();
		_LSweOA3cIPq1IjLzplF4mDludQf(spriteBatch);
		spriteBatch.DrawString(_MnMUFBDfrGZBHvrJ30IAQilqivI, "Score: " + _G0GwJ5OWQOA4BjacW3XmFsyMFjz, new Vector2(10f, 10f), Color.White);
		spriteBatch.DrawString(_6YCQhlMaqcDds8uGX1g8fjBKqV4A, "Targets missed: " + _JvgphfrWtBncPfgb6ERRVKKtlQG, new Vector2(10f, 60f), Color.White);
		spriteBatch.DrawString(_6YCQhlMaqcDds8uGX1g8fjBKqV4A, "Shots missed: " + _dH7hlTzeJboGa5rfpgerBfCmyKO, new Vector2(10f, 80f), Color.White);
		spriteBatch.DrawString(_6YCQhlMaqcDds8uGX1g8fjBKqV4A, "Bodyshots: " + _pL6aoe4HLq4X3yQACLFyUH3xwBp, new Vector2(10f, 100f), Color.White);
		spriteBatch.DrawString(_6YCQhlMaqcDds8uGX1g8fjBKqV4A, "Headshots: " + _C6cjmtLovCejw2N3OZYswcoYxsd, new Vector2(10f, 120f), Color.White);
		int num = 5;
		int num2 = 0;
		while (num >= 0)
		{
			spriteBatch.Draw(_m1dNhD2jwJ6iTVUgUzMJUvnQFS, new Rectangle(1875 - 35 * num, 10, 30, 55), (num2 < _YFr89aAV3UzO9kf7kPKQJilRWED) ? _AWLddj1Rm2sqiBwYcJDngG0QaQI : (_AWLddj1Rm2sqiBwYcJDngG0QaQI * 0.5f));
			num--;
			num2++;
		}
		if (_YFr89aAV3UzO9kf7kPKQJilRWED == 0)
		{
			spriteBatch.DrawString(_MnMUFBDfrGZBHvrJ30IAQilqivI, "Reload!", new Vector2(1750f, 70f), Color.Red);
		}
		switch (_dxhbACq6BB89IAMy6ZOALWJgv7L)
		{
			case GameState.NotStarted:
				spriteBatch.DrawString(_MnMUFBDfrGZBHvrJ30IAQilqivI, "Press <Space/R/Mouse-R> to Reload and begin.", new Vector2((1920f - _YhybMVqCJnFekEXVbF1huXupDmh) / 2f, 10f), Color.Red);
				break;
			case GameState.Started:
				if (_0zKXRrSXqoTAuTYQNrJIgtt7Emq >= 0f)
				{
					if (_0zKXRrSXqoTAuTYQNrJIgtt7Emq > 10f)
					{
						spriteBatch.DrawString(_MnMUFBDfrGZBHvrJ30IAQilqivI, _0zKXRrSXqoTAuTYQNrJIgtt7Emq.ToString("F0"), new Vector2(960f, 10f), Color.White);
					}
					else
					{
						spriteBatch.DrawString(_MnMUFBDfrGZBHvrJ30IAQilqivI, _0zKXRrSXqoTAuTYQNrJIgtt7Emq.ToString("F1"), new Vector2(960f, 10f), Color.Red);
					}
				}
				break;
			case GameState.GameOver:
				spriteBatch.DrawString(_MnMUFBDfrGZBHvrJ30IAQilqivI, "Time up, Game over! Press <Enter> to retry or <Escape> to continue.", new Vector2((1920f - _MZh3nVRuDktDpIu8X149SF90ZjO) / 2f, 10f), Color.Red);
				break;
		}
		spriteBatch.End();
	}

	public override void End()
	{
		base.End();
		base.Game.IsRenderingCursor = _WD4Plg5m1AwZ5mVyjQCADcW1ZTk;
		PhoneOverlay._kf3EbE0B70xGe1szklqAZyCqoLj = _U8eNAZVBW15ZflhG4fel0hK3Juu;
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

	private void _LSweOA3cIPq1IjLzplF4mDludQf(SpriteBatch spriteBatch)
	{
		using List<IDrawable>.Enumerator enumerator = _xEG3axnWkco0Erk0PdjakXDULcA.GetEnumerator();
		if (enumerator.MoveNext())
		{
			IDrawable current = enumerator.Current;
			current.Draw(spriteBatch);
		}
	}

	private void _Vu9iV57zUVa3p8WMfOsDaoqv7wL(int int_0, int int_1, float float_0)
	{
		FrameAnimation frameAnimation = new FrameAnimation(this, "Assets/Scenes/ShootingRange/Explosion_12x1", 0.5f, 12, 125, 111, float_0);
		frameAnimation._QrgbXEg7MMeD9Ybz12fFVsbmAd9(int_0, int_1, Randoms.NextDouble(0f, 360f));
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
			base.Game.Achievements.GainAchievement(Achievements.AchievementGeneric7);
		}
		if (_C6cjmtLovCejw2N3OZYswcoYxsd > 60)
		{
			base.Game.Achievements.GainAchievement(Achievements.AchievementGeneric8);
		}
		if (_dH7hlTzeJboGa5rfpgerBfCmyKO == 0)
		{
			base.Game.Achievements.GainAchievement(Achievements.AchievementGeneric9);
		}
		if (_JvgphfrWtBncPfgb6ERRVKKtlQG < 30)
		{
			base.Game.Achievements.GainAchievement(Achievements.AchievementGeneric10);
		}
	}
}
