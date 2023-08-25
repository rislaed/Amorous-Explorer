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
		private readonly Texture2D texture;
		private Rectangle destinationRectangle;
		private Rectangle sourceRectangle;
		private readonly Vector2 origin;
		private readonly float delay;
		private readonly int lifetime;
		private int offset;
		private float rotation;
		private float ticks;

		public bool IsRemoved { get; private set; }

		public FrameAnimation(AbstractScene scene, string sprite, float time, int lifetime, int dx, int dy, float scale)
		{
			texture = scene.Game.Content.Load<Texture2D>(sprite);
			delay = time / (float)lifetime;
			this.lifetime = lifetime;
			offset = 0;
			sourceRectangle = new Rectangle(0, 0, (int)((float)texture.Width / 12f), texture.Height);
			destinationRectangle = new Rectangle(0, 0, (int)((float)sourceRectangle.Width * scale), (int)((float)sourceRectangle.Height * scale));
			origin = new Vector2(dx, dy);
		}

		public void Play(int x, int y, float degrees)
		{
			destinationRectangle.X = x;
			destinationRectangle.Y = y;
			rotation = MathHelper.ToRadians(degrees);
		}

		public void Update(float ticks)
		{
			if (offset >= 0)
			{
				this.ticks += ticks;
				while (this.ticks > delay)
				{
					this.ticks -= delay;
                    offset++;
				}
				if (offset < lifetime)
				{
					sourceRectangle.X = offset * sourceRectangle.Width;
				}
				else
				{
					Remove();
				}
			}
		}

		public void Draw(SpriteBatch spriteBatch)
		{
			if (offset >= 0)
			{
				spriteBatch.Draw(texture, destinationRectangle, sourceRectangle, Color.White, rotation, origin, SpriteEffects.None, 0f);
			}
		}

		public void Remove()
		{
			offset = -1;
			IsRemoved = true;
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
		private static int CenterRadius = 64;
	
		private float scale;
		private float offsetX;
		private float offsetY;
		private Point modelBounds;
		private Point targetBounds;
		private int centerRadius;
		private readonly SkeletonRenderer skeleton;

		public bool IsShooted { get; set; }
		public new float Scale => scale;

		public TargetModel(AbstractScene scene, int x, int y, float scale = 1f) : base(scene, "Target")
		{
			base.OnUpdate = delegate(GameTime gameTime)
			{
				skeleton.Update(gameTime);
			};
			base.OnSpineDraw = delegate(SpriteBatch spriteBatch, SkeletonMeshRenderer skeletonMeshRenderer)
			{
                skeleton.Draw(skeletonMeshRenderer, null, null, null, this.scale);
			};
			skeleton = scene.Game.Content.LoadSkeleton("Assets/Scenes/ShootingRange/Target");
			Refresh(x, y, scale);
		}

		private void Refresh(int x, int y, float? scale)
		{
			skeleton.X = x;
			skeleton.Y = y;
			this.scale = scale ?? this.scale;
            offsetX = (float)x - (float)ModelBounds.X / 2f * this.scale;
            offsetY = (float)y - (float)ModelBounds.Y * this.scale;
            modelBounds = new Point((int)((float)ModelBounds.X * this.scale), (int)((float)ModelBounds.Y * this.scale));
            targetBounds = new Point((int)((float)TargetBounds.X * this.scale), (int)((float)TargetBounds.Y * this.scale));
            centerRadius = (int)((float)CenterRadius * this.scale);
		}

		public void StartRise(Action then = null)
		{
			skeleton.StartAnimation("Rise", then);
		}

		public void StartHeadshot(Action then = null)
		{
			skeleton.StartAnimation("Headshot", then);
		}

		public void StartBodyshot(Action then = null)
		{
			skeleton.StartAnimation("Bodyshot", then);
		}

		public bool Clip(Point cursor, out CollisionType collision)
		{
			collision = CollisionType.None;
			if (!IsShooted)
			{
				return false;
			}
			if ((float)cursor.X >= offsetX && (float)cursor.X <= offsetX + (float)modelBounds.X && (float)cursor.Y >= offsetY && (float)cursor.Y <= offsetY + (float)modelBounds.Y)
			{
				if ((float)cursor.Y >= offsetY + (float)targetBounds.Y + (float)centerRadius)
				{
					collision = CollisionType.Bodyshot;
					return true;
				}
				float dx = (float)cursor.X - (offsetX + (float)targetBounds.X);
				float dy = (float)cursor.Y - (offsetY + (float)targetBounds.Y);
				double distance = Math.Sqrt(dx * dx + dy * dy);
				if (distance <= (double)centerRadius)
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
		private readonly SkeletonRenderer skeleton;

		public new float X
		{
			set
			{
				skeleton.X = value;
			}
		}

		public new float Y
		{
			set
			{
				skeleton.Y = value;
			}
		}

		public bool Flip
		{
			set
			{
				skeleton.FlipX = value;
			}
		}

		public GunModel(AbstractScene scene) : base(scene, "GunModel")
		{
			base.OnUpdate = delegate(GameTime gameTime)
			{
				skeleton.Update(gameTime);
			};
			base.OnSpineDraw = delegate(SpriteBatch spriteBatch, SkeletonMeshRenderer skeletonMeshRenderer)
			{
				skeleton.Draw(skeletonMeshRenderer, null, null, null, Scale);
			};
			skeleton = scene.Game.Content.LoadSkeleton("Assets/GUI/Phone/Phone");
			skeleton.ApplyTime("Arm rise", 0f);
			skeleton.SetVisibility(0f);
			skeleton.X = 0f;
			skeleton.Y = 1080f;
			PlayerData data = PlayerPreferences.GetPlayerData();
			bool hasLongMarkings = data.MarkingsType.HasFlag(PlayerData.EMarkingsType.LongForearm);
			bool hasShortMarkings = data.MarkingsType.HasFlag(PlayerData.EMarkingsType.ShortForearm);
			Color color = (hasShortMarkings ? data.ShortForearmColor : (hasLongMarkings ? data.LongForearmColor : Color.White));
			skeleton.SetAlpha("Hoody Sleeve", 0f);
			skeleton.SetAlpha("Default Forearm", 1f);
			skeleton.SetColor("Default Forearm", data.BodyColor);
			skeleton.SetAlpha("Marking Forearm", (hasShortMarkings || hasLongMarkings) ? 1 : 0);
			skeleton.SetColor("Marking Forearm", color);
			skeleton.SetAlpha("Striped forearm", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.Stripes) ? 1 : 0);
			skeleton.SetColor("Striped forearm", data.StripesColor);
			skeleton.SetAlpha("Avian Forearm", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.AvianForearm) ? 1 : 0);
			skeleton.SetColor("Avian Forearm", data.AvianForearmColor);
			skeleton.SetAlpha("Hand", 1f);
			skeleton.SetColor("Hand", data.BodyColor);
			skeleton.SetAlpha("Marking Hand", (hasShortMarkings || hasLongMarkings) ? 1 : 0);
			skeleton.SetColor("Marking Hand", color);
			skeleton.SetAlpha("Avian Hand", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.AvianForearm) ? 1 : 0);
			skeleton.SetColor("Avian Hand", data.AvianForearmColor);
			skeleton.SetAlpha("Index", 1f);
			skeleton.SetColor("Index", data.BodyColor);
			skeleton.SetAlpha("Avian index", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.AvianForearm) ? 1 : 0);
			skeleton.SetColor("Avian index", data.AvianForearmColor);
			skeleton.SetAlpha("Pinky", 1f);
			skeleton.SetColor("Pinky", data.BodyColor);
			skeleton.SetAlpha("Avian Pinky", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.AvianForearm) ? 1 : 0);
			skeleton.SetColor("Avian Pinky", data.AvianForearmColor);
			skeleton.SetAlpha("Ring", 1f);
			skeleton.SetColor("Ring", data.BodyColor);
			skeleton.SetAlpha("Avian ring", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.AvianForearm) ? 1 : 0);
			skeleton.SetColor("Avian ring", data.AvianForearmColor);
			skeleton.SetAlpha("Rude", 1f);
			skeleton.SetColor("Rude", data.BodyColor);
			skeleton.SetAlpha("Avian Rude", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.AvianForearm) ? 1 : 0);
			skeleton.SetColor("Avian Rude", data.AvianForearmColor);
			skeleton.SetAlpha("Thumb", 1f);
			skeleton.SetColor("Thumb", data.BodyColor);
			skeleton.SetAlpha("Avian Thumb", data.MarkingsType.HasFlag(PlayerData.EMarkingsType.AvianForearm) ? 1 : 0);
			skeleton.SetColor("Avian Thumb", data.AvianForearmColor);
			skeleton.SetAlpha("Pinky Nail", data.ShowNails ? 1 : 0);
			skeleton.SetColor("Pinky Nail", data.NailColor);
			skeleton.SetAlpha("Ring Nail", data.ShowNails ? 1 : 0);
			skeleton.SetColor("Ring Nail", data.NailColor);
			skeleton.SetAlpha("Rude Nail", data.ShowNails ? 1 : 0);
			skeleton.SetColor("Rude Nail", data.NailColor);
			skeleton.SetAlpha("Index Nail", data.ShowNails ? 1 : 0);
			skeleton.SetColor("Index Nail", data.NailColor);
			skeleton.SetAlpha("Thumb Nail", data.ShowNails ? 1 : 0);
			skeleton.SetColor("Thumb Nail", data.NailColor);
			skeleton.SetAlpha("Muzzle flash", 1f);
			skeleton.SetAlpha("Gun casing", 1f);
			skeleton.SetAlpha("Gun", 1f);
			skeleton.SetAlpha("Gun Slide", 1f);
		}

		public void StartRise(Action then = null)
		{
			skeleton.StartAnimation("Gun rise", delegate
			{
				StartIdle();
				then?.Invoke();
			});
		}

		private void StartIdle()
		{
			skeleton.StartAnimationWithLooping("Gun Idle");
		}

		public void StartShoot()
		{
			skeleton.StartAnimation("Gun Shoot", StartIdle);
		}

		public void StartReload(Action then = null)
		{
			skeleton.StartAnimation("Gun reload", delegate
			{
				StartIdle();
				then?.Invoke();
			});
		}
	}

	private interface IDrawable
	{
		bool IsRemoved { get; }
		void Update(float ticks);
		void Draw(SpriteBatch spriteBatch);
		void Remove();
	}

	private class FloatingFeedbackDrawable : IDrawable
	{
		private const float FadingOutModifier = 0.8f;
		private const float VerticalOffset = 100f;

		private readonly SpriteFont font;
		private readonly float positionX;
		private float positionY;
		private readonly string text;
		private readonly Color color;
		private float alpha;

		public bool IsRemoved { get; private set; }

		public FloatingFeedbackDrawable(AbstractScene scene, int x, int y, string text, Color color)
		{
			font = scene.Game.Content.Load<SpriteFont>("Assets/GUI/Fonts/Bold-26");
			positionX = x;
			positionY = y;
			this.text = text;
			this.color = color;
			alpha = 1f;
		}

		public void Update(float ticks)
		{
			if (!IsRemoved)
			{
				alpha -= FadingOutModifier * ticks;
				if (alpha <= 0f)
				{
					IsRemoved = true;
				}
				else
				{
					positionY -= VerticalOffset * ticks;
				}
			}
		}

		public void Draw(SpriteBatch spriteBatch)
		{
			spriteBatch.DrawString(font, text, new Vector2(positionX, positionY), color * alpha);
		}

		public void Remove() {}
	}

	private class TimedDrawable : IDrawable
	{
		private float ticks;
		private readonly float delay;
		private readonly Action then;

		public bool IsRemoved { get; private set; }

		public TimedDrawable(float time, Action then)
		{
			delay = time;
			this.then = then;
		}

		public void Update(float ticks)
		{
			if (!IsRemoved)
			{
				this.ticks += ticks;
				if (this.ticks > delay)
				{
                    Remove();
				}
			}
		}

		public void Draw(SpriteBatch spriteBatch) {}

		public void Remove()
		{
			IsRemoved = true;
			then?.Invoke();
		}
	}

	private class RailInfo
	{
		public readonly int Left;
		public readonly int Right;
		public readonly int Height;
		public readonly float Scale;
		public readonly int Layer;

		public RailInfo(int x1, int x2, int y, float scale, int layer)
		{
			Left = x1;
			Right = x2;
			Height = y;
			Scale = scale;
			Layer = layer;
		}
	}

	private const int BACKDROP_LAYER = 0;
	private const int RAIL_FIRST_LAYER = 1;
	private const int BACKGROUND_LAYER = 2;
	private const int RAIL_SECOND_LAYER = 3;
	private const int RAIL_THIRD_LAYER = 4;
	private const int RAIL_FOURTH_LAYER = 5;
	private const int COUNTERTOP_LAYER = 6;
	private const int CROSSHAIR_LAYER = 7;
	private const int GUN_LAYER = 8;

	private readonly RailInfo[] rails = new RailInfo[4]
	{
		new RailInfo(710, 1210, 410, 0.3f, RAIL_FIRST_LAYER),
		new RailInfo(650, 1270, 575, 0.4f, RAIL_SECOND_LAYER),
		new RailInfo(270, 1650, 625, 0.6f, RAIL_THIRD_LAYER),
		new RailInfo(330, 1600, 770, 1f, RAIL_FOURTH_LAYER)
	};

	private const float ROUND_TIME = 90f;
	private const float TARGET_DELAY = 3.5f;
	private const int BULLETS = 6;
	private const string PRESS_TO_RELOAD = "Press <Space/R/Canvas-R> to Reload and begin.";
	private const string PRESS_TO_CONTINUE = "Time up, Game over! Press <Enter> to retry or <Escape> to continue.";

	private readonly List<IDrawable> overlays;
	private readonly List<IDrawable> removedOverlays;
	private readonly RandomSoundEffect soundsOfFire;
	private readonly RandomSoundEffect soundsOfReload;
	private readonly RandomSoundEffect soundsOfDry;
	private readonly RandomSoundEffect soundsOfHeadshot;
	private readonly RandomSoundEffect soundsOfImpact;
	private readonly RandomSoundEffect soundsOfRicochete;
	private readonly bool pendingRenderingCursor;
	private readonly bool pendingPhoneEnabled;
	private readonly GunModel gunModel;
	private List<TargetModel> targets;
	private readonly SpriteLayer crosshairLayer;
	private Point cursor;
	private readonly Color crosshairColor;
	private readonly Texture2D bulletSprite;
	private readonly SpriteFont smallFont;
	private readonly SpriteFont largeFont;
	private bool shooting, reloading;
	private int missedTargets;
	private int missedShots;
	private int headshots;
	private int bodyshots;
	private TargetModel.CollisionType collision;
	private int bullets;
	private readonly float reloadActionWidth;
	private readonly float finishedActionWidth;
	private int targetCount;
	private float seconds;
	private int score;
	private GameState state;

	protected bool ExitWhenEscape { get; set; }

	protected ShootingRangeMiniGameScene(IAmorous game) : base(game)
	{
		pendingRenderingCursor = Game.IsRenderingCursor;
		Game.IsRenderingCursor = false;
		pendingPhoneEnabled = PhoneOverlay.Enabled;
		PhoneOverlay.Enabled = false;
		FadingMediaPlayer.Complete();
		soundsOfFire = new RandomSoundEffect(Game.Content);
		soundsOfFire.Append("Assets/Sounds/MiniGames/ShootingRange/Fire");
		soundsOfDry = new RandomSoundEffect(Game.Content);
		soundsOfDry.Append("Assets/Sounds/MiniGames/ShootingRange/Dry");
		soundsOfReload = new RandomSoundEffect(Game.Content);
		soundsOfReload.Append("Assets/Sounds/MiniGames/ShootingRange/Reload");
		soundsOfHeadshot = new RandomSoundEffect(Game.Content);
		soundsOfHeadshot.Append("Assets/Sounds/MiniGames/ShootingRange/Headshot 1", "Assets/Sounds/MiniGames/ShootingRange/Headshot 2");
		soundsOfImpact = new RandomSoundEffect(Game.Content);
		soundsOfImpact.Append("Assets/Sounds/MiniGames/ShootingRange/Impact 1", "Assets/Sounds/MiniGames/ShootingRange/Impact 2", "Assets/Sounds/MiniGames/ShootingRange/Impact 3");
		soundsOfRicochete = new RandomSoundEffect(Game.Content);
		soundsOfRicochete.Append("Assets/Sounds/MiniGames/ShootingRange/Ricochete 1", "Assets/Sounds/MiniGames/ShootingRange/Ricochete 2", "Assets/Sounds/MiniGames/ShootingRange/Ricochete 3");
		bulletSprite = base.Game.Content.Load<Texture2D>("Assets/Scenes/ShootingRange/Bullet");
		AddLayer(CreateSpriteLayer("Backdrop", "Assets/Scenes/ShootingRange/Backdrop", 600, 180), BACKDROP_LAYER);
		AddLayer(CreateSpriteLayer("Background", "Assets/Scenes/ShootingRange/Background", 0, 0), BACKGROUND_LAYER);
		AddLayer(CreateSpriteLayer("Countertop", "Assets/Scenes/ShootingRange/Countertop", 0, 0), COUNTERTOP_LAYER);
		smallFont = Game.Content.Load<SpriteFont>("Assets/GUI/Fonts/Bold-14");
		largeFont = Game.Content.Load<SpriteFont>("Assets/GUI/Fonts/Bold-26");
		crosshairColor = PlayerPreferences.GetPlayerData().PhoneColor;
		crosshairLayer = CreateSpriteLayer("Crosshair", "Assets/Scenes/ShootingRange/Crosshair", 0, 0);
		crosshairLayer.Color = crosshairColor;
		AddLayer(crosshairLayer, CROSSHAIR_LAYER);
		gunModel = new GunModel(this)
		{
			X = 1820f,
			Y = 1080f,
			Scale = 0.5f,
			Flip = true
		};
		AddLayer(gunModel, GUN_LAYER);
		gunModel.StartRise();
		targets = new List<TargetModel>();
		overlays = new List<IDrawable>();
		removedOverlays = new List<IDrawable>();
		reloadActionWidth = largeFont.MeasureString(PRESS_TO_RELOAD).X;
		finishedActionWidth = largeFont.MeasureString(PRESS_TO_CONTINUE).X;
		seconds = ROUND_TIME;
		targetCount = 1;
		FadingMediaPlayer.PlayOnRepeat(AmorousData.MechTrack, 0.4f);
		state = GameState.NotStarted;
	}

	public override void Update(GameTime gameTime)
	{
		float ticks = (float)gameTime.ElapsedGameTime.Milliseconds / 1000f;
		if (ExitWhenEscape && base.Game.Controller.IsPressed(Keys.Escape))
		{
			state = GameState.None;
			Exit();
		}
		if (seconds <= 60f)
		{
			if (seconds > 30f)
			{
				targetCount = 2;
			}
			else if (seconds > 0f)
			{
				targetCount = 4;
			}
		}
		else
		{
			targetCount = 1;
		}
		if (seconds <= 0f)
		{
			state = GameState.GameOver;
			TriggerAchievements();
		}
		cursor = base.Game.Canvas.RelativeToContent(base.Game.Controller.Cursor);
		crosshairLayer.X = cursor.X - 32;
		crosshairLayer.Y = cursor.Y - 32;
		gunModel.X = 780f + Math.Min(1f, (float)cursor.X / 1730f) * 1570f;
		gunModel.Y = 1080f + Math.Min(1f, (float)cursor.Y / 950f) * 370f;
		UpdateLayers(ticks);
		switch (state)
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
		if (!reloading && (base.Game.Controller.IsPressed(ControllerButtonType.RightButton) || base.Game.Controller.IsPressed(Keys.R) || base.Game.Controller.IsPressed(Keys.Space)))
		{
			reloading = true;
			shooting = true;
			soundsOfReload.PlayNext();
			gunModel.StartReload(delegate
			{
				bullets = BULLETS;
				reloading = false;
				shooting = false;
				state = GameState.Started;
				AddTimedDrawable(0f, EmitTargets);
			});
		}
	}

	private void TouchOnStarted(float ticks)
	{
		seconds -= ticks;
		if (!reloading && !shooting && base.Game.Controller.IsPressed(ControllerButtonType.LeftButton))
		{
			if (bullets != 0)
			{
				bullets--;
				shooting = true;
				AddTimedDrawable(0.5f, delegate
				{
					shooting = false;
				});
				gunModel.StartShoot();
				soundsOfFire.PlayNext();
				bool ricochete = false;
				foreach (TargetModel model in targets)
				{
					if (!model.Clip(cursor, out collision))
					{
						continue;
					}
					AddExplosionAnimation(cursor.X, cursor.Y, model.Scale);
					if (collision == TargetModel.CollisionType.Headshot)
					{
						headshots++;
						soundsOfHeadshot.PlayNext();
						score += 30;
						AddFloatingFeedbackDrawable(cursor.X, cursor.Y, "30!", Color.Yellow);
						model.IsShooted = false;
						model.StartHeadshot(delegate
						{
							AddTimedDrawable(0f, delegate
							{
								RemoveTarget(model);
							});
						});
						AddTimedDrawable(0f, EmitTargets);
					}
					else if (collision == TargetModel.CollisionType.Bodyshot)
					{
						bodyshots++;
						soundsOfImpact.PlayNext();
						score += 10;
						AddFloatingFeedbackDrawable(cursor.X, cursor.Y, "10!", Color.Red);
						model.IsShooted = false;
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
					RailInfo rail = rails.FirstOrDefault((RailInfo rail) => cursor.Y < rail.Height);
					AddSmokeAnimation(cursor.X, cursor.Y, rail?.Scale ?? 1f);
					missedShots++;
					soundsOfRicochete.PlayNext();
				}
			}
			else
			{
				soundsOfDry.PlayNext();
			}
		}
		if (!reloading && (base.Game.Controller.IsPressed(ControllerButtonType.RightButton) || base.Game.Controller.IsPressed(Keys.R) || base.Game.Controller.IsPressed(Keys.Space)))
		{
			reloading = true;
			shooting = true;
			soundsOfReload.PlayNext();
			gunModel.StartReload(delegate
			{
				bullets = BULLETS;
				reloading = false;
				shooting = false;
			});
		}
	}

	private void EmitTargets()
	{
		if (state == GameState.Started)
		{
			int count = targets.Count((TargetModel model) => model.IsShooted);
			for (int i = count; i < targetCount; i++)
			{
				EmitTarget();
			}
		}
	}

	private void EmitTarget()
	{
		RailInfo rail = rails[Utils.Random(0, rails.Length)];
		TargetModel model = new TargetModel(this, Utils.Random(rail.Left, rail.Right), rail.Height, rail.Scale)
		{
			IsShooted = true
		};
		model.StartRise();
		targets.Add(model);
		AddLayer(model, rail.Layer);
		targets = targets.OrderByDescending((TargetModel model) => model.ZOrder).ToList();
		AddTimedDrawable(TARGET_DELAY, delegate
		{
			if (model.IsShooted && state != GameState.GameOver)
			{
				missedTargets++;
				model.IsShooted = false;
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
		targets.Remove(model);
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
			state = GameState.None;
			Exit();
		}
	}

	protected abstract void Exit();

	private void Reset()
	{
		seconds = ROUND_TIME;
		score = 0;
		missedTargets = missedShots = headshots = bodyshots = 0;
		bullets = 0;
		overlays.Clear();
		removedOverlays.Clear();
		foreach (TargetModel model in targets)
		{
			base.Layers.Remove(model);
		}
		targets.Clear();
		state = GameState.NotStarted;
	}

	public override void Draw(SpriteBatch spriteBatch, SkeletonMeshRenderer skeletonMeshRenderer, Matrix matrix)
	{
		base.Draw(spriteBatch, skeletonMeshRenderer, matrix);
		spriteBatch.Begin();
		DrawLayers(spriteBatch);
		spriteBatch.DrawString(largeFont, "Score: " + score, new Vector2(10f, 10f), Color.White);
		spriteBatch.DrawString(smallFont, "Targets missed: " + missedTargets, new Vector2(10f, 60f), Color.White);
		spriteBatch.DrawString(smallFont, "Shots missed: " + missedShots, new Vector2(10f, 80f), Color.White);
		spriteBatch.DrawString(smallFont, "Bodyshots: " + bodyshots, new Vector2(10f, 100f), Color.White);
		spriteBatch.DrawString(smallFont, "Headshots: " + headshots, new Vector2(10f, 120f), Color.White);
		int bullet = BULLETS - 1;
		int index = 0;
		while (bullet >= 0)
		{
			spriteBatch.Draw(bulletSprite, new Rectangle(1875 - 35 * bullet, 10, 30, 55), (index < bullets) ? crosshairColor : (crosshairColor * 0.5f));
			bullet--;
			index++;
		}
		if (bullets == 0)
		{
			spriteBatch.DrawString(largeFont, "Reload!", new Vector2(1750f, 70f), Color.Red);
		}
		switch (state)
		{
			case GameState.NotStarted:
				spriteBatch.DrawString(largeFont, PRESS_TO_RELOAD, new Vector2((1920f - reloadActionWidth) / 2f, 10f), Color.Red);
				break;
			case GameState.Started:
				if (seconds >= 0f)
				{
					if (seconds > 10f)
					{
						spriteBatch.DrawString(largeFont, seconds.ToString("F0"), new Vector2(960f, 10f), Color.White);
					}
					else
					{
						spriteBatch.DrawString(largeFont, seconds.ToString("F1"), new Vector2(960f, 10f), Color.Red);
					}
				}
				break;
			case GameState.GameOver:
				spriteBatch.DrawString(largeFont, PRESS_TO_CONTINUE, new Vector2((1920f - finishedActionWidth) / 2f, 10f), Color.Red);
				break;
		}
		spriteBatch.End();
	}

	public override void End()
	{
		base.End();
		base.Game.IsRenderingCursor = pendingRenderingCursor;
		PhoneOverlay.Enabled = pendingPhoneEnabled;
	}

	private void UpdateLayers(float ticks)
	{
		if (removedOverlays.Any())
		{
			foreach (IDrawable drawable in removedOverlays)
			{
				overlays.Remove(drawable);
			}
			removedOverlays.Clear();
		}
		foreach (IDrawable drawable in overlays.ToList())
		{
			if (!drawable.IsRemoved)
			{
				drawable.Update(ticks);
			}
			else
			{
				removedOverlays.Add(drawable);
			}
		}
	}

	private void DrawLayers(SpriteBatch spriteBatch)
	{
		using List<IDrawable>.Enumerator enumerator = overlays.GetEnumerator();
		while (enumerator.MoveNext())
		{
			enumerator.Current.Draw(spriteBatch);
		}
	}

	private void AddExplosionAnimation(int x, int y, float scale)
	{
		FrameAnimation animation = new FrameAnimation(this, "Assets/Scenes/ShootingRange/Explosion_12x1", 0.5f, 12, 125, 111, scale);
		animation.Play(x, y, Utils.RandomFloat(0f, 360f));
		overlays.Add(animation);
	}

	private void AddSmokeAnimation(int x, int y, float scale)
	{
		FrameAnimation animation = new FrameAnimation(this, "Assets/Scenes/ShootingRange/Smoke_12x1", 0.5f, 12, 122, 129, scale);
		animation.Play(x, y, 0f);
		overlays.Add(animation);
	}

	private void AddFloatingFeedbackDrawable(int x, int y, string text, Color color)
	{
		FloatingFeedbackDrawable drawable = new FloatingFeedbackDrawable(this, x, y, text, color);
		overlays.Add(drawable);
	}

	private void AddTimedDrawable(float time, Action then = null)
	{
		TimedDrawable item = new TimedDrawable(time, then);
		overlays.Add(item);
	}

	private void TriggerAchievements()
	{
		if (score > 2500)
		{
			base.Game.Achievements.TriggerAchievement(Achievements.AchievementGeneric7);
		}
		if (headshots > 60)
		{
			base.Game.Achievements.TriggerAchievement(Achievements.AchievementGeneric8);
		}
		if (missedShots == 0)
		{
			base.Game.Achievements.TriggerAchievement(Achievements.AchievementGeneric9);
		}
		if (missedTargets < 30)
		{
			base.Game.Achievements.TriggerAchievement(Achievements.AchievementGeneric10);
		}
	}
}
