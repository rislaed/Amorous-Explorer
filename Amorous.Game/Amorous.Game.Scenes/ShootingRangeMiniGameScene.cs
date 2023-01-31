using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
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
		private readonly Texture2D _texture;
		private Rectangle _destination;
		private Rectangle _source;
		private readonly Vector2 _origin;
		private readonly float _delay;
		private readonly int _range;
		private int _offset;
		private float _rotation;
		private float _ticks;

		public bool Destructed { get; private set; }

		public FrameAnimation(AbstractScene scene, string sprite, float time, int range, int dx, int dy, float scale)
		{
			_texture = scene.Game.Content.Load<Texture2D>(sprite);
			_delay = time / (float)range;
			_range = range;
			_offset = 0;
			_source = new Rectangle(0, 0, (int)((float)_texture.Width / 12f), _texture.Height);
			_destination = new Rectangle(0, 0, (int)((float)_source.Width * scale), (int)((float)_source.Height * scale));
			_origin = new Vector2(dx, dy);
		}

		public void Play(int x, int y, float degrees)
		{
			_destination.X = x;
			_destination.Y = y;
			_rotation = MathHelper.ToRadians(degrees);
		}

		public void Update(float ticks)
		{
			if (_offset >= 0)
			{
				_ticks += ticks;
				while (_ticks > _delay)
				{
					_ticks -= _delay;
					_offset++;
				}
				if (_offset < _range)
				{
					_source.X = _offset * _source.Width;
				}
				else
				{
					Remove();
				}
			}
		}

		public void Draw(SpriteBatch spriteBatch)
		{
			if (_offset >= 0)
			{
				spriteBatch.Draw(_texture, _destination, _source, Color.White, _rotation, _origin, SpriteEffects.None, 0f);
			}
		}

		public void Remove()
		{
			_offset = -1;
			Destructed = true;
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

		private static Point ModelBounds = new Point(257, 503);
		private static Point TargetBounds = new Point(128, 100);
		private static int CenterSize = 64;
	
		private float _scale;
		private float _x;
		private float _y;
		private Point _modelBounds;
		private Point _targetBounds;
		private int _center;
		private readonly SpineRenderer _spine;

		public bool Enabled { get; set; }
		public new float Scale => _scale;

		public TargetModel(AbstractScene scene, int x, int y, float scale = 1f)
			: base(scene, "Target")
		{
			base.OnUpdate = delegate(GameTime gameTime)
			{
				_spine.Update(gameTime);
			};
			base.OnSpineDraw = delegate(SpriteBatch spriteBatch, SkeletonMeshRenderer skeletonMeshRenderer)
			{
				_spine.Draw(skeletonMeshRenderer, null, null, null, _scale);
			};
			_spine = scene.Game.Content.LoadSkeleton("Assets/Scenes/ShootingRange/Target");
			Refresh(x, y, scale);
		}

		private void Refresh(int x, int y, float? scale)
		{
			_spine.X = x;
			_spine.Y = y;
			_scale = scale ?? _scale;
			_x = (float)x - (float)ModelBounds.X / 2f * _scale;
			_y = (float)y - (float)ModelBounds.Y * _scale;
			_modelBounds = new Point((int)((float)ModelBounds.X * _scale), (int)((float)ModelBounds.Y * _scale));
			_targetBounds = new Point((int)((float)TargetBounds.X * _scale), (int)((float)TargetBounds.Y * _scale));
			_center = (int)((float)CenterSize * _scale);
		}

		public void StartRise(Action then = null)
		{
			_spine.StartAnimation("Rise", then);
		}

		public void StartHeadshot(Action then = null)
		{
			_spine.StartAnimation("Headshot", then);
		}

		public void StartBodyshot(Action then = null)
		{
			_spine.StartAnimation("Bodyshot", then);
		}

		public bool Clip(Point cursor, out CollisionType collision)
		{
			collision = CollisionType.None;
			if (!Enabled)
			{
				return false;
			}
			if ((float)cursor.X >= _x && (float)cursor.X <= _x + (float)_modelBounds.X && (float)cursor.Y >= _y && (float)cursor.Y <= _y + (float)_modelBounds.Y)
			{
				if ((float)cursor.Y >= _y + (float)_targetBounds.Y + (float)_center)
				{
					collision = CollisionType.Bodyshot;
					return true;
				}
				float dx = (float)cursor.X - (_x + (float)_targetBounds.X);
				float dy = (float)cursor.Y - (_y + (float)_targetBounds.Y);
				double distance = Math.Sqrt(dx * dx + dy * dy);
				if (distance <= (double)_center)
				{
					collision = CollisionType.Headshot;
					return true;
				}
			}
			return false;
		}
	}

	private class GunModel : SpineDrawableLayer
	{
		private readonly SpineRenderer _spine;

		public new float X
		{
			set
			{
				_spine.X = value;
			}
		}

		public new float Y
		{
			set
			{
				_spine.Y = value;
			}
		}

		public bool Flip
		{
			set
			{
				_spine.FlipX = value;
			}
		}

		public GunModel(AbstractScene scene)
			: base(scene, "GunModel")
		{
			base.OnUpdate = delegate(GameTime gameTime)
			{
				_spine.Update(gameTime);
			};
			base.OnSpineDraw = delegate(SpriteBatch spriteBatch, SkeletonMeshRenderer skeletonMeshRenderer)
			{
				_spine.Draw(skeletonMeshRenderer, null, null, null, Scale);
			};
			_spine = scene.Game.Content.LoadSkeleton("Assets/GUI/Phone/Phone");
			_spine.ApplyFrame("Arm rise", 0f);
			_spine.SetVisibility(0f);
			_spine.X = 0f;
			_spine.Y = 1080f;
			PlayerData data = PlayerPreferences.GetPlayerData();
			bool hasLongMarkings = data.MarkingsType.HasFlag(PlayerData.EMarkingsType.LongForearm);
			bool hasShortMarkings = data.MarkingsType.HasFlag(PlayerData.EMarkingsType.ShortForearm);
			Color color = (hasShortMarkings ? data.ShortForearmColor : (hasLongMarkings ? data.LongForearmColor : Color.White));
			_spine.SetAlpha("Hoody Sleeve", 0f);
			_spine.SetAlpha("Default Forearm", 1f);
			_spine.SetColor("Default Forearm", data.BodyColor);
			_spine.SetAlpha("Marking Forearm", (hasShortMarkings || hasLongMarkings) ? 1 : 0);
			_spine.SetColor("Marking Forearm", color);
			_spine.SetAlpha("Striped forearm", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Stripes) ? 1 : 0);
			_spine.SetColor("Striped forearm", data.StripesColor);
			_spine.SetAlpha("Avian Forearm", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.AvianForearm) ? 1 : 0);
			_spine.SetColor("Avian Forearm", data.AvianForearmColor);
			_spine.SetAlpha("Hand", 1f);
			_spine.SetColor("Hand", data.BodyColor);
			_spine.SetAlpha("Marking Hand", (hasShortMarkings || hasLongMarkings) ? 1 : 0);
			_spine.SetColor("Marking Hand", color);
			_spine.SetAlpha("Avian Hand", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.AvianForearm) ? 1 : 0);
			_spine.SetColor("Avian Hand", data.AvianForearmColor);
			_spine.SetAlpha("Index", 1f);
			_spine.SetColor("Index", data.BodyColor);
			_spine.SetAlpha("Avian index", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.AvianForearm) ? 1 : 0);
			_spine.SetColor("Avian index", data.AvianForearmColor);
			_spine.SetAlpha("Pinky", 1f);
			_spine.SetColor("Pinky", data.BodyColor);
			_spine.SetAlpha("Avian Pinky", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.AvianForearm) ? 1 : 0);
			_spine.SetColor("Avian Pinky", data.AvianForearmColor);
			_spine.SetAlpha("Ring", 1f);
			_spine.SetColor("Ring", data.BodyColor);
			_spine.SetAlpha("Avian ring", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.AvianForearm) ? 1 : 0);
			_spine.SetColor("Avian ring", data.AvianForearmColor);
			_spine.SetAlpha("Rude", 1f);
			_spine.SetColor("Rude", data.BodyColor);
			_spine.SetAlpha("Avian Rude", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.AvianForearm) ? 1 : 0);
			_spine.SetColor("Avian Rude", data.AvianForearmColor);
			_spine.SetAlpha("Thumb", 1f);
			_spine.SetColor("Thumb", data.BodyColor);
			_spine.SetAlpha("Avian Thumb", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.AvianForearm) ? 1 : 0);
			_spine.SetColor("Avian Thumb", data.AvianForearmColor);
			_spine.SetAlpha("Pinky Nail", data.ShowNails ? 1 : 0);
			_spine.SetColor("Pinky Nail", data.NailColor);
			_spine.SetAlpha("Ring Nail", data.ShowNails ? 1 : 0);
			_spine.SetColor("Ring Nail", data.NailColor);
			_spine.SetAlpha("Rude Nail", data.ShowNails ? 1 : 0);
			_spine.SetColor("Rude Nail", data.NailColor);
			_spine.SetAlpha("Index Nail", data.ShowNails ? 1 : 0);
			_spine.SetColor("Index Nail", data.NailColor);
			_spine.SetAlpha("Thumb Nail", data.ShowNails ? 1 : 0);
			_spine.SetColor("Thumb Nail", data.NailColor);
			_spine.SetAlpha("Muzzle flash", 1f);
			_spine.SetAlpha("Gun casing", 1f);
			_spine.SetAlpha("Gun", 1f);
			_spine.SetAlpha("Gun Slide", 1f);
		}

		public void StartRise(Action then = null)
		{
			_spine.StartAnimation("Gun rise", delegate
			{
				StartIdle();
				then?.Invoke();
			});
		}

		private void StartIdle()
		{
			_spine.StartAnimationWithLooping("Gun Idle");
		}

		public void StartShoot()
		{
			_spine.StartAnimation("Gun Shoot", StartIdle);
		}

		public void StartReload(Action then = null)
		{
			_spine.StartAnimation("Gun reload", delegate
			{
				StartIdle();
				then?.Invoke();
			});
		}
	}

	private interface IDrawable
	{
		bool Destructed { get; }
		void Update(float ticks);
		void Draw(SpriteBatch spriteBatch);
		void Remove();
	}

	private class FloatingFeedbackDrawable : IDrawable
	{
		private const float FadingOutModifier = 0.8f;
		private const float VerticalOffset = 100f;

		private readonly SpriteFont _font;
		private readonly float _x;
		private float _y;
		private readonly string _text;
		private readonly Color _color;
		private float _alpha;

		public bool Destructed { get; private set; }

		public FloatingFeedbackDrawable(AbstractScene scene, int x, int y, string text, Color color)
		{
			_font = scene.Game.Content.Load<SpriteFont>("Assets/GUI/Fonts/Bold-26");
			_x = x;
			_y = y;
			_text = text;
			_color = color;
			_alpha = 1f;
		}

		public void Update(float ticks)
		{
			if (!Destructed)
			{
				_alpha -= FadingOutModifier * ticks;
				if (_alpha <= 0f)
				{
					Destructed = true;
				}
				else
				{
					_y -= VerticalOffset * ticks;
				}
			}
		}

		public void Draw(SpriteBatch spriteBatch)
		{
			spriteBatch.DrawString(_font, _text, new Vector2(_x, _y), _color * _alpha);
		}

		public void Remove() {}
	}

	private class TimedDrawable : IDrawable
	{
		private float _ticks;
		private readonly float _delay;
		private readonly Action _then;

		public bool Destructed { get; private set; }

		public TimedDrawable(float time, Action then)
		{
			_delay = time;
			_then = then;
		}

		public void Update(float ticks)
		{
			if (!Destructed)
			{
				_ticks += ticks;
				if (_ticks > _delay)
				{
					Remove();
				}
			}
		}

		public void Draw(SpriteBatch spriteBatch) {}

		public void Remove()
		{
			Destructed = true;
			_then?.Invoke();
		}
	}

	private class RailInfo
	{
		public readonly int X1;
		public readonly int X2;
		public readonly int Y;
		public readonly float Scale;
		public readonly int Layer;

		public RailInfo(int x1, int x2, int y, float scale, int layer)
		{
			X1 = x1;
			X2 = x2;
			Y = y;
			Scale = scale;
			Layer = layer;
		}
	}

	private const int BackdropLayer = 0;
	private const int RailFirstLayer = 1;
	private const int BackgroundLayer = 2;
	private const int RailSecondLayer = 3;
	private const int RailThirdLayer = 4;
	private const int RailForthLayer = 5;
	private const int CountertopLayer = 6;
	private const int CrosshairLayer = 7;
	private const int GunLayer = 8;

	private readonly RailInfo[] _rails = new RailInfo[4]
	{
		new RailInfo(710, 1210, 410, 0.3f, RailFirstLayer),
		new RailInfo(650, 1270, 575, 0.4f, RailSecondLayer),
		new RailInfo(270, 1650, 625, 0.6f, RailThirdLayer),
		new RailInfo(330, 1600, 770, 1f, RailForthLayer)
	};

	private const float RoundTime = 90f;
	private const float TargetDelay = 3.5f;
	private const int BulletCount = 6;
	private const string PressToReloadText = "Press <Space/R/Canvas-R> to Reload and begin.";
	private const string PressToContinueText = "Time up, Game over! Press <Enter> to retry or <Escape> to continue.";

	private readonly List<IDrawable> _overlays;
	private readonly List<IDrawable> _destructedOverlays;
	private readonly RandomSoundEffect _soundsOfFire;
	private readonly RandomSoundEffect _soundsOfReload;
	private readonly RandomSoundEffect _soundsOfDry;
	private readonly RandomSoundEffect _soundsOfHeadshot;
	private readonly RandomSoundEffect _soundsOfImpact;
	private readonly RandomSoundEffect _soundsOfRicochete;
	private readonly bool _pendingRenderingCursor;
	private readonly bool _pendingPhoneEnabled;
	private readonly GunModel _gun;
	private List<TargetModel> _targets;
	private readonly SpriteLayer _crosshair;
	private Point _cursor;
	private readonly Color _crosshairColor;
	private readonly Texture2D _bulletSprite;
	private readonly SpriteFont _scoreboardFont;
	private readonly SpriteFont _actionFont;
	private bool _occupied, _reloading;
	private int _missedTargets;
	private int _missedShots;
	private int _headshots;
	private int _bodyshots;
	private TargetModel.CollisionType _collision;
	private int _bullets;
	private readonly float _reloadActionWidth;
	private readonly float _finishedActionWidth;
	private int _targetCount;
	private float _time;
	private int _score;
	private GameState _state;

	protected bool ExitWhenEscape { get; set; }

	protected ShootingRangeMiniGameScene(IAmorous game)
		: base(game)
	{
		_pendingRenderingCursor = Game.IsRenderingCursor;
		Game.IsRenderingCursor = false;
		_pendingPhoneEnabled = PhoneOverlay.Enabled;
		PhoneOverlay.Enabled = false;
		FadingMediaPlayer.Complete();
		_soundsOfFire = new RandomSoundEffect(Game.Content);
		_soundsOfFire.Append("Assets/Sounds/MiniGames/ShootingRange/Fire");
		_soundsOfDry = new RandomSoundEffect(Game.Content);
		_soundsOfDry.Append("Assets/Sounds/MiniGames/ShootingRange/Dry");
		_soundsOfReload = new RandomSoundEffect(Game.Content);
		_soundsOfReload.Append("Assets/Sounds/MiniGames/ShootingRange/Reload");
		_soundsOfHeadshot = new RandomSoundEffect(Game.Content);
		_soundsOfHeadshot.Append("Assets/Sounds/MiniGames/ShootingRange/Headshot 1", "Assets/Sounds/MiniGames/ShootingRange/Headshot 2");
		_soundsOfImpact = new RandomSoundEffect(Game.Content);
		_soundsOfImpact.Append("Assets/Sounds/MiniGames/ShootingRange/Impact 1", "Assets/Sounds/MiniGames/ShootingRange/Impact 2", "Assets/Sounds/MiniGames/ShootingRange/Impact 3");
		_soundsOfRicochete = new RandomSoundEffect(Game.Content);
		_soundsOfRicochete.Append("Assets/Sounds/MiniGames/ShootingRange/Ricochete 1", "Assets/Sounds/MiniGames/ShootingRange/Ricochete 2", "Assets/Sounds/MiniGames/ShootingRange/Ricochete 3");
		_bulletSprite = base.Game.Content.Load<Texture2D>("Assets/Scenes/ShootingRange/Bullet");
		AddLayer(NewSpriteLayer("Backdrop", "Assets/Scenes/ShootingRange/Backdrop", 600, 180), BackdropLayer);
		AddLayer(NewSpriteLayer("Background", "Assets/Scenes/ShootingRange/Background", 0, 0), BackgroundLayer);
		AddLayer(NewSpriteLayer("Countertop", "Assets/Scenes/ShootingRange/Countertop", 0, 0), CountertopLayer);
		_scoreboardFont = Game.Content.Load<SpriteFont>("Assets/GUI/Fonts/Bold-14");
		_actionFont = Game.Content.Load<SpriteFont>("Assets/GUI/Fonts/Bold-26");
		_crosshairColor = PlayerPreferences.GetPlayerData().PhoneColor;
		_crosshair = NewSpriteLayer("Crosshair", "Assets/Scenes/ShootingRange/Crosshair", 0, 0);
		_crosshair.Color = _crosshairColor;
		AddLayer(_crosshair, CrosshairLayer);
		_gun = new GunModel(this)
		{
			X = 1820f,
			Y = 1080f,
			Scale = 0.5f,
			Flip = true
		};
		AddLayer(_gun, GunLayer);
		_gun.StartRise();
		_targets = new List<TargetModel>();
		_overlays = new List<IDrawable>();
		_destructedOverlays = new List<IDrawable>();
		_reloadActionWidth = _actionFont.MeasureString(PressToReloadText).X;
		_finishedActionWidth = _actionFont.MeasureString(PressToContinueText).X;
		_time = RoundTime;
		_targetCount = 1;
		FadingMediaPlayer.PlayOnRepeat(AmorousData.MechTrack, 0.4f);
		_state = GameState.NotStarted;
	}

	public override void Update(GameTime gameTime)
	{
		float ticks = (float)gameTime.ElapsedGameTime.Milliseconds / 1000f;
		if (ExitWhenEscape && base.Game.Controller.IsPressed(Keys.Escape))
		{
			_state = GameState.None;
			Exit();
		}
		if (_time <= 60f)
		{
			if (_time > 30f)
			{
				_targetCount = 2;
			}
			else if (_time > 0f)
			{
				_targetCount = 4;
			}
		}
		else
		{
			_targetCount = 1;
		}
		if (_time <= 0f)
		{
			_state = GameState.GameOver;
			TriggerAchievements();
		}
		_cursor = base.Game.Canvas.RelativeToContent(base.Game.Controller.Cursor);
		_crosshair.X = _cursor.X - 32;
		_crosshair.Y = _cursor.Y - 32;
		_gun.X = 780f + Math.Min(1f, (float)_cursor.X / 1730f) * 1570f;
		_gun.Y = 1080f + Math.Min(1f, (float)_cursor.Y / 950f) * 370f;
		UpdateLayers(ticks);
		switch (_state)
		{
			case GameState.NotStarted:
				TouchOnNotStarted(ticks);
				break;
			case GameState.Started:
				TouchOnStarted(ticks);
				break;
			case GameState.GameOver:
				TouchOnGameOver(ticks);
				break;
		}
		base.Update(gameTime);
	}

	private void TouchOnNotStarted(float ticks)
	{
		if (!_reloading && (base.Game.Controller.IsPressed(ControllerButtonType.RightButton) || base.Game.Controller.IsPressed(Keys.R) || base.Game.Controller.IsPressed(Keys.Space)))
		{
			_reloading = true;
			_occupied = true;
			_soundsOfReload.PlayNext();
			_gun.StartReload(delegate
			{
				_bullets = BulletCount;
				_reloading = false;
				_occupied = false;
				_state = GameState.Started;
				AddTimedDrawable(0f, EmitTargets);
			});
		}
	}

	private void TouchOnStarted(float ticks)
	{
		_time -= ticks;
		if (!_reloading && !_occupied && base.Game.Controller.IsPressed(ControllerButtonType.LeftButton))
		{
			if (_bullets != 0)
			{
				_bullets--;
				_occupied = true;
				AddTimedDrawable(0.5f, delegate
				{
					_occupied = false;
				});
				_gun.StartShoot();
				_soundsOfFire.PlayNext();
				bool ricochete = false;
				foreach (TargetModel model in _targets)
				{
					if (!model.Clip(_cursor, out _collision))
					{
						continue;
					}
					AddExplosionAnimation(_cursor.X, _cursor.Y, model.Scale);
					if (_collision == TargetModel.CollisionType.Headshot)
					{
						_headshots++;
						_soundsOfHeadshot.PlayNext();
						_score += 30;
						AddFloatingFeedbackDrawable(_cursor.X, _cursor.Y, "30!", Color.Yellow);
						model.Enabled = false;
						model.StartHeadshot(delegate
						{
							AddTimedDrawable(0f, delegate
							{
								RemoveTarget(model);
							});
						});
						AddTimedDrawable(0f, EmitTargets);
					}
					else if (_collision == TargetModel.CollisionType.Bodyshot)
					{
						_bodyshots++;
						_soundsOfImpact.PlayNext();
						_score += 10;
						AddFloatingFeedbackDrawable(_cursor.X, _cursor.Y, "10!", Color.Red);
						model.Enabled = false;
						model.StartBodyshot(delegate
						{
							AddTimedDrawable(0f, delegate
							{
								RemoveTarget(model);
							});
						});
						AddTimedDrawable(0f, EmitTargets);
					}
					ricochete = true;
					break;
				}
				if (!ricochete)
				{
					RailInfo rail = _rails.FirstOrDefault((RailInfo rail) => _cursor.Y < rail.Y);
					AddSmokeAnimation(_cursor.X, _cursor.Y, rail?.Scale ?? 1f);
					_missedShots++;
					_soundsOfRicochete.PlayNext();
				}
			}
			else
			{
				_soundsOfDry.PlayNext();
			}
		}
		if (!_reloading && (base.Game.Controller.IsPressed(ControllerButtonType.RightButton) || base.Game.Controller.IsPressed(Keys.R) || base.Game.Controller.IsPressed(Keys.Space)))
		{
			_reloading = true;
			_occupied = true;
			_soundsOfReload.PlayNext();
			_gun.StartReload(delegate
			{
				_bullets = BulletCount;
				_reloading = false;
				_occupied = false;
			});
		}
	}

	private void EmitTargets()
	{
		if (_state == GameState.Started)
		{
			int count = _targets.Count((TargetModel model) => model.Enabled);
			for (int i = count; i < _targetCount; i++)
			{
				EmitTarget();
			}
		}
	}

	private void EmitTarget()
	{
		RailInfo rail = _rails[Utils.Random(0, _rails.Length)];
		TargetModel model = new TargetModel(this, Utils.Random(rail.X1, rail.X2), rail.Y, rail.Scale)
		{
			Enabled = true
		};
		model.StartRise();
		_targets.Add(model);
		AddLayer(model, rail.Layer);
		_targets = _targets.OrderByDescending((TargetModel model) => model.ZOrder).ToList();
		AddTimedDrawable(TargetDelay, delegate
		{
			if (model.Enabled && _state != GameState.GameOver)
			{
				_missedTargets++;
				model.Enabled = false;
				model.StartBodyshot(delegate
				{
					AddTimedDrawable(0f, delegate
					{
						RemoveTarget(model);
					});
				});
				AddTimedDrawable(0f, EmitTargets);
			}
		});
	}

	private void RemoveTarget(TargetModel model)
	{
		_targets.Remove(model);
		base.Layers.Remove(model);
	}

	private void TouchOnGameOver(float ticks)
	{
		if (base.Game.Controller.IsPressed(Keys.Enter))
		{
			Reset();
		}
		else if (base.Game.Controller.IsPressed(Keys.Escape))
		{
			_state = GameState.None;
			Exit();
		}
	}

	protected abstract void Exit();

	private void Reset()
	{
		_time = RoundTime;
		_score = 0;
		_missedTargets = _missedShots = _headshots = _bodyshots = 0;
		_bullets = 0;
		_overlays.Clear();
		_destructedOverlays.Clear();
		foreach (TargetModel model in _targets)
		{
			base.Layers.Remove(model);
		}
		_targets.Clear();
		_state = GameState.NotStarted;
	}

	public override void Draw(SpriteBatch spriteBatch, SkeletonMeshRenderer skeletonMeshRenderer, Matrix matrix)
	{
		base.Draw(spriteBatch, skeletonMeshRenderer, matrix);
		spriteBatch.Begin();
		DrawLayers(spriteBatch);
		spriteBatch.DrawString(_actionFont, "Score: " + _score, new Vector2(10f, 10f), Color.White);
		spriteBatch.DrawString(_scoreboardFont, "Targets missed: " + _missedTargets, new Vector2(10f, 60f), Color.White);
		spriteBatch.DrawString(_scoreboardFont, "Shots missed: " + _missedShots, new Vector2(10f, 80f), Color.White);
		spriteBatch.DrawString(_scoreboardFont, "Bodyshots: " + _bodyshots, new Vector2(10f, 100f), Color.White);
		spriteBatch.DrawString(_scoreboardFont, "Headshots: " + _headshots, new Vector2(10f, 120f), Color.White);
		int bullet = BulletCount - 1;
		int index = 0;
		while (bullet >= 0)
		{
			spriteBatch.Draw(_bulletSprite, new Rectangle(1875 - 35 * bullet, 10, 30, 55), (index < _bullets) ? _crosshairColor : (_crosshairColor * 0.5f));
			bullet--;
			index++;
		}
		if (_bullets == 0)
		{
			spriteBatch.DrawString(_actionFont, "Reload!", new Vector2(1750f, 70f), Color.Red);
		}
		switch (_state)
		{
			case GameState.NotStarted:
				spriteBatch.DrawString(_actionFont, PressToReloadText, new Vector2((1920f - _reloadActionWidth) / 2f, 10f), Color.Red);
				break;
			case GameState.Started:
				if (_time >= 0f)
				{
					if (_time > 10f)
					{
						spriteBatch.DrawString(_actionFont, _time.ToString("F0"), new Vector2(960f, 10f), Color.White);
					}
					else
					{
						spriteBatch.DrawString(_actionFont, _time.ToString("F1"), new Vector2(960f, 10f), Color.Red);
					}
				}
				break;
			case GameState.GameOver:
				spriteBatch.DrawString(_actionFont, PressToContinueText, new Vector2((1920f - _finishedActionWidth) / 2f, 10f), Color.Red);
				break;
		}
		spriteBatch.End();
	}

	public override void End()
	{
		base.End();
		base.Game.IsRenderingCursor = _pendingRenderingCursor;
		PhoneOverlay.Enabled = _pendingPhoneEnabled;
	}

	private void UpdateLayers(float ticks)
	{
		if (_destructedOverlays.Any())
		{
			foreach (IDrawable drawable in _destructedOverlays)
			{
				_overlays.Remove(drawable);
			}
			_destructedOverlays.Clear();
		}
		foreach (IDrawable drawable in _overlays.ToList())
		{
			if (!drawable.Destructed)
			{
				drawable.Update(ticks);
			}
			else
			{
				_destructedOverlays.Add(drawable);
			}
		}
	}

	private void DrawLayers(SpriteBatch spriteBatch)
	{
		using List<IDrawable>.Enumerator enumerator = _overlays.GetEnumerator();
		while (enumerator.MoveNext())
		{
			enumerator.Current.Draw(spriteBatch);
		}
	}

	private void AddExplosionAnimation(int x, int y, float scale)
	{
		FrameAnimation animation = new FrameAnimation(this, "Assets/Scenes/ShootingRange/Explosion_12x1", 0.5f, 12, 125, 111, scale);
		animation.Play(x, y, Utils.RandomFloat(0f, 360f));
		_overlays.Add(animation);
	}

	private void AddSmokeAnimation(int x, int y, float scale)
	{
		FrameAnimation animation = new FrameAnimation(this, "Assets/Scenes/ShootingRange/Smoke_12x1", 0.5f, 12, 122, 129, scale);
		animation.Play(x, y, 0f);
		_overlays.Add(animation);
	}

	private void AddFloatingFeedbackDrawable(int x, int y, string text, Color color)
	{
		FloatingFeedbackDrawable drawable = new FloatingFeedbackDrawable(this, x, y, text, color);
		_overlays.Add(drawable);
	}

	private void AddTimedDrawable(float time, Action then = null)
	{
		TimedDrawable item = new TimedDrawable(time, then);
		_overlays.Add(item);
	}

	private void TriggerAchievements()
	{
		if (_score > 2500)
		{
			base.Game.Achievements.TriggerAchievement(Achievements.AchievementGeneric7);
		}
		if (_headshots > 60)
		{
			base.Game.Achievements.TriggerAchievement(Achievements.AchievementGeneric8);
		}
		if (_missedShots == 0)
		{
			base.Game.Achievements.TriggerAchievement(Achievements.AchievementGeneric9);
		}
		if (_missedTargets < 30)
		{
			base.Game.Achievements.TriggerAchievement(Achievements.AchievementGeneric10);
		}
	}
}
