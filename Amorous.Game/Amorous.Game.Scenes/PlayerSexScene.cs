using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Amorous.Game.Scenes;

public class PlayerSexScene : AbstractScene
{
	private bool _jOJQdqVUTXcPDmuOqViqC8pczW;

	private SpriteFont _font;

	public PlayerSexScene(IAmorous game)
		: base(game)
	{
		_jOJQdqVUTXcPDmuOqViqC8pczW = true;
		_font = Game.Content.Load<SpriteFont>("Assets/GUI/Fonts/Bold-26");
		FadingMediaPlayer.BeginCutscene();
	}

	public override void Update(GameTime gameTime)
	{
		base.Update(gameTime);
		if (base.Game.Sexscene == null)
		{
			return;
		}
		if (base.Game.Controller.JustPressed(Keys.Escape))
		{
			PhoneOverlay.Rise();
		}
		if (base.Game.Controller.JustPressed(Keys.S))
		{
			string[] array = base.Game.Sexscene.GetSubscenes();
			if (array.Length == 0)
			{
				return;
			}
			int num = Array.IndexOf(array, base.Game.Sexscene.Subscene);
			num++;
			if (num >= array.Length)
			{
				num = 0;
			}
			base.Game.Sexscene.SwitchToSubscene(array[num]);
		}
		if (base.Game.Controller.JustPressed(Keys.Z))
		{
			_jOJQdqVUTXcPDmuOqViqC8pczW = !_jOJQdqVUTXcPDmuOqViqC8pczW;
		}
		if (!Censorship.Censored)
		{
			if (base.Game.Controller.JustPressed(Keys.Space))
			{
				base.Game.Sexscene.ToPhase(1);
			}
			if (base.Game.Controller.JustPressed(Keys.LeftControl))
			{
				base.Game.Sexscene.ToPhase(-1);
			}
			if (base.Game.Sexscene.Exploded && base.Game.Controller.JustPressed(Keys.X))
			{
				base.Game.Sexscene.Clean();
			}
			else if (!base.Game.Sexscene.Exploded && base.Game.Controller.JustPressed(Keys.C))
			{
				base.Game.Sexscene.ExplodeNow();
			}
			else if (!base.Game.Sexscene.Exploded && base.Game.Controller.JustPressed(Keys.V))
			{
				base.Game.Sexscene.Explode();
			}
		}
	}

	public override void DrawOverlay(SpriteBatch spriteBatch)
	{
		base.DrawOverlay(spriteBatch);
		if (!base.Game.IsControlsOnScreen)
		{
			return;
		}
		spriteBatch.Begin();
		if (Censorship.Censored)
		{
			int num = 10;
			if (base.Game.Sexscene != null && base.Game.Sexscene.GetSubscenes().Length != 0)
			{
				spriteBatch.DrawString(_font, "Cycle skin (S)", new Vector2(10f, num), Color.White);
				num += 40;
			}
			spriteBatch.DrawString(_font, "Toggle phone (Escape or Shift)", new Vector2(10f, num), Color.White);
		}
		else if (!_jOJQdqVUTXcPDmuOqViqC8pczW)
		{
			spriteBatch.DrawString(_font, "Show help (Z)", new Vector2(10f, 10f), Color.White);
		}
		else
		{
			spriteBatch.DrawString(_font, "Speed up (Space)", new Vector2(10f, 10f), Color.White);
			spriteBatch.DrawString(_font, "Slow down (Left Ctrl)", new Vector2(10f, 50f), Color.White);
			spriteBatch.DrawString(_font, "Clean mess (X)", new Vector2(10f, 90f), Color.White);
			spriteBatch.DrawString(_font, "Insta-mess (C)", new Vector2(10f, 130f), Color.White);
			spriteBatch.DrawString(_font, "Finish it! (V)", new Vector2(10f, 170f), Color.White);
			if (base.Game.Sexscene != null && base.Game.Sexscene.GetSubscenes().Length != 0)
			{
				spriteBatch.DrawString(_font, "Cycle skin (S)", new Vector2(10f, 250f), Color.White);
			}
			spriteBatch.DrawString(_font, "Toggle phone (Escape or Shift)", new Vector2(10f, 290f), Color.White);
			spriteBatch.DrawString(_font, "Hide help (Z)", new Vector2(10f, 330f), Color.White);
		}
		spriteBatch.End();
	}
}
