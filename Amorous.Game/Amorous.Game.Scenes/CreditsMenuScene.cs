using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Amorous.Game.Scenes;

public class CreditsMenuScene : AbstractScene
{
	private readonly SpriteFont _bold26;
	private readonly float _heightBold26;
	private readonly SpriteFont _bold20;
	private readonly float _heightBold20;
	private readonly SpriteFont _bold14;
	private readonly float _heightBold14;

	private const float ScrollingSpeed = 100f;
	private const float HoldingScrollingSpeed = 300f;

	private readonly string[] _credits;
	private Matrix _offsetMatrix;
	private float _offset;
	private float _length;
	private float _scrollingSpeed;

	protected Type PendingScene { get; set; }
	protected string ReturnToSceneText { get; set; }

	public CreditsMenuScene(IAmorous game)
		: base(game)
	{
		CreditsMenuScene self = this;
		base.Blending = BlendState.AlphaBlend;
		PendingScene = typeof(MainMenuScene);
		ReturnToSceneText = "Press Escape or Left-click here to return to the Main Menu.";
		AddSpriteLayer("Background", "Assets/Scenes/CreditsMenu/Background", 0, 0);
		AddForegroundSpriteLayer("Overlay", "Assets/Scenes/CreditsMenu/Overlay", 0, 0);
		_bold26 = Game.Content.Load<SpriteFont>("Assets/GUI/Fonts/Bold-26");
		_bold20 = Game.Content.Load<SpriteFont>("Assets/GUI/Fonts/Bold-20");
		_bold14 = Game.Content.Load<SpriteFont>("Assets/GUI/Fonts/Bold-14");
		_heightBold26 = _bold26.MeasureString("Test").Y;
		_heightBold20 = _bold20.MeasureString("Test").Y;
		_heightBold14 = _bold14.MeasureString("Test").Y;
		Vector2 bounds26 = new Vector2(50f, 1080f - _heightBold26 - 40f);
		FadingMediaPlayer.PlayOnRepeat(AmorousData.HappyJazzShitTrack, 0.4f);
		_credits = Compressions.ReadStreamAsText(Path.Combine(Game.Content.RootDirectory, "Data/credits.txt")).Replace("\r", string.Empty).Split(new char[1] { '\n' });
		DrawableLayer creditsLayer = new DrawableLayer(this, "Credits")
		{
			OnUpdate = UpdateCredits,
			OnDraw = DrawCredits
		};
		AddLayer(creditsLayer, 0);
		bool hovered = false;
		Vector2 bounds14 = _bold14.MeasureString(ReturnToSceneText);
		Point boundsOfBack = base.Game.Canvas.RelativeToContent(new Point((int)bounds14.X, (int)bounds14.Y));
		AddLayer(new DrawableLayer(this, "GoBackText")
		{
			OnUpdate = delegate
			{
				Point point = self.Game.Canvas.GlobalToContent(self.Game.Controller.Cursor);
				if ((float)point.X >= bounds26.X && (float)point.X <= bounds26.X + (float)boundsOfBack.X && (float)point.Y >= bounds26.Y && (float)point.Y <= bounds26.Y + (float)boundsOfBack.Y)
				{
					hovered = true;
					if (self.Game.Controller.IsPressed(ControllerButtonType.LeftButton))
					{
						self.Game.StartScene(self.PendingScene.Name);
					}
				}
				else
				{
					hovered = false;
				}
			},
			OnDraw = delegate(SpriteBatch spriteBatch)
			{
				spriteBatch.Begin();
				spriteBatch.DrawString(self._bold26, self.ReturnToSceneText, bounds26, hovered ? Color.Red : Color.White);
				spriteBatch.End();
			}
		}, 2);
		List<string> textures = new List<string>();
		for (int i = 1; i < 60; i++)
		{
			textures.Add($"Assets/Scenes/CreditsMenu/Skye/TYSkye{i:D2}");
		}
		int x;
		int y;
		float scale;
		if (!Censorship.Censored)
		{
			x = 1170;
			y = 105;
			scale = 1.5f;
		}
		else
		{
			x = 1000;
			y = 105;
			scale = 2f;
		}
		AnimatedLayer skyeLayer = AddForegroundAnimatedLayer("Skye", x, y, 16, textures.ToArray());
		skyeLayer.Scale = scale;
		_offset = 960f;
		_scrollingSpeed = ScrollingSpeed;
	}

	public void UpdateCredits(GameTime gameTime)
	{
		_offsetMatrix = Matrix.CreateTranslation(100f, _offset, 0f);
		if (_offset > _length)
		{
			_offset -= (float)gameTime.ElapsedGameTime.Milliseconds / 1000f * _scrollingSpeed;
		}
		else
		{
			_offset = 960f;
		}
	}

	public void DrawCredits(SpriteBatch spriteBatch)
	{
		Vector2 position = Vector2.Zero;
		float offset = 10f;
		float height = 0f;
		spriteBatch.Begin(SpriteSortMode.Deferred, null, null, null, null, null, _offsetMatrix);
		foreach (string text in _credits)
		{
			if (string.IsNullOrWhiteSpace(text))
			{
				height += offset;
			}
			else if (!text.StartsWith("##"))
			{
				if (text.StartsWith("#"))
				{
					spriteBatch.DrawString(_bold26, text.Substring(1), position, Color.SkyBlue);
					height += _heightBold26 + offset;
				}
				else
				{
					spriteBatch.DrawString(_bold14, text, position, Color.White);
					height += _heightBold14 + offset;
				}
			}
			else
			{
				spriteBatch.DrawString(_bold20, text.Substring(2), position, Color.Pink);
				height += _heightBold20 + offset;
			}
			position.Y = height;
		}
		_length = -height;
		spriteBatch.End();
	}

	public override void Update(GameTime gameTime)
	{
		if (!base.Game.Controller.IsPressed(Keys.Escape))
		{
			_scrollingSpeed = ((!base.Game.Controller.IsHolding(Keys.Space)) ? ScrollingSpeed : HoldingScrollingSpeed);
			base.Update(gameTime);
		}
		else
		{
			base.Game.StartScene(PendingScene.Name);
		}
	}
}
