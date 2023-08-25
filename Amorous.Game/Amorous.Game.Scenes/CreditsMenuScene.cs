using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Amorous.Game.Scenes;

public class CreditsMenuScene : AbstractScene
{
	private readonly SpriteFont largeFont;
	private readonly float largeFontHeight;
	private readonly SpriteFont mediumFont;
	private readonly float mediumFontHeight;
	private readonly SpriteFont smallFont;
	private readonly float smallFontHeight;

	private const float SCROLLING_SPEED = 100f;
	private const float HOLDING_SCROLLING_SPEED = 300f;

	private readonly string[] credits;
	private Matrix transformationMatrix;
	private float offset;
	private float length;
	private float scrollingSpeed;

	protected Type PendingScene { get; set; }
	protected string ReturnToSceneText { get; set; }

	public CreditsMenuScene(IAmorous game) : base(game)
	{
		base.Blending = BlendState.AlphaBlend;
		PendingScene = typeof(MainMenuScene);
		ReturnToSceneText = "Press Escape or Left-click here to return to the Main Menu.";
		AddSpriteLayer("Background", "Assets/Scenes/CreditsMenu/Background", 0, 0);
		AddSpriteLayerAbove("Overlay", "Assets/Scenes/CreditsMenu/Overlay", 0, 0);
		largeFont = Game.Content.Load<SpriteFont>("Assets/GUI/Fonts/Bold-26");
		mediumFont = Game.Content.Load<SpriteFont>("Assets/GUI/Fonts/Bold-20");
		smallFont = Game.Content.Load<SpriteFont>("Assets/GUI/Fonts/Bold-14");
		largeFontHeight = largeFont.MeasureString("Test").Y;
		mediumFontHeight = mediumFont.MeasureString("Test").Y;
		smallFontHeight = smallFont.MeasureString("Test").Y;
		Vector2 largeFontOffset = new Vector2(50f, 1080f - largeFontHeight - 40f);
		FadingMediaPlayer.PlayOnRepeat(AmorousData.HappyJazzShitTrack, 0.4f);
		credits = Compressions.ReadStreamAsText(Path.Combine(Game.Content.RootDirectory, "Data/credits.txt")).Replace("\r", string.Empty).Split(new char[1] { '\n' });
		DrawableLayer creditsLayer = new DrawableLayer(this, "Credits")
		{
			OnUpdate = UpdateInternal,
			OnDraw = DrawInternal
		};
		AddLayer(creditsLayer, 0);
		bool hovered = false;
		Vector2 bounds14 = smallFont.MeasureString(ReturnToSceneText);
		Point boundsOfBack = base.Game.Canvas.RelativeToContent(new Point((int)bounds14.X, (int)bounds14.Y));
		AddLayer(new DrawableLayer(this, "GoBackText")
		{
			OnUpdate = delegate
			{
				Point cursor = this.Game.Canvas.GlobalToContent(this.Game.Controller.Cursor);
				if ((float)cursor.X >= largeFontOffset.X && (float)cursor.X <= largeFontOffset.X + (float)boundsOfBack.X && (float)cursor.Y >= largeFontOffset.Y && (float)cursor.Y <= largeFontOffset.Y + (float)boundsOfBack.Y)
				{
					hovered = true;
					if (this.Game.Controller.IsPressed(ControllerButtonType.LeftButton))
					{
						this.Game.StartScene(this.PendingScene.Name);
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
				spriteBatch.DrawString(this.largeFont, this.ReturnToSceneText, largeFontOffset, hovered ? Color.Red : Color.White);
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
		AnimatedLayer skyeLayer = AddAnimatedLayerAbove("Skye", x, y, 16, textures.ToArray());
		skyeLayer.Scale = scale;
		offset = 960f;
		scrollingSpeed = SCROLLING_SPEED;
	}

	public void UpdateInternal(GameTime gameTime)
	{
		transformationMatrix = Matrix.CreateTranslation(100f, offset, 0f);
		if (offset > length)
		{
			offset -= (float)gameTime.ElapsedGameTime.Milliseconds / 1000f * scrollingSpeed;
		}
		else
		{
			offset = 960f;
		}
	}

	public void DrawInternal(SpriteBatch spriteBatch)
	{
		Vector2 position = Vector2.Zero;
		float offset = 10f;
		float height = 0f;
		spriteBatch.Begin(SpriteSortMode.Deferred, null, null, null, null, null, transformationMatrix);
		foreach (string text in credits)
		{
			if (string.IsNullOrWhiteSpace(text))
			{
				height += offset;
			}
			else if (!text.StartsWith("##"))
			{
				if (text.StartsWith("#"))
				{
					spriteBatch.DrawString(largeFont, text.Substring(1), position, Color.SkyBlue);
					height += largeFontHeight + offset;
				}
				else
				{
					spriteBatch.DrawString(smallFont, text, position, Color.White);
					height += smallFontHeight + offset;
				}
			}
			else
			{
				spriteBatch.DrawString(mediumFont, text.Substring(2), position, Color.Pink);
				height += mediumFontHeight + offset;
			}
			position.Y = height;
		}
		length = -height;
		spriteBatch.End();
	}

	public override void Update(GameTime gameTime)
	{
		if (!base.Game.Controller.IsPressed(Keys.Escape))
		{
			scrollingSpeed = ((!base.Game.Controller.IsHolding(Keys.Space)) ? SCROLLING_SPEED : HOLDING_SCROLLING_SPEED);
			base.Update(gameTime);
		}
		else
		{
			base.Game.StartScene(PendingScene.Name);
		}
	}
}
