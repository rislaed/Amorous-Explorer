using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Amorous.Game.Scenes;

public class PlayerSexScene : AbstractScene
{
	private bool showHelp;
	private SpriteFont font;

	public PlayerSexScene(IAmorous game) : base(game)
	{
		showHelp = true;
		font = Game.Content.Load<SpriteFont>("Assets/GUI/Fonts/Bold-26");
		FadingMediaPlayer.Complete();
	}

	public override void Update(GameTime gameTime)
	{
		base.Update(gameTime);
		if (base.Game.Sexscene == null)
		{
			return;
		}
		if (base.Game.Controller.IsPressed(Keys.Escape))
		{
			PhoneOverlay.Rise();
		}
		if (base.Game.Controller.IsPressed(Keys.S))
		{
			string[] subscenes = base.Game.Sexscene.GetSubscenes();
			if (subscenes.Length == 0)
			{
				return;
			}
			int index = Array.IndexOf(subscenes, base.Game.Sexscene.Subscene);
			index++;
			if (index >= subscenes.Length)
			{
				index = 0;
			}
			base.Game.Sexscene.SwitchToSubscene(subscenes[index]);
		}
		if (base.Game.Controller.IsPressed(Keys.Z))
		{
			showHelp = !showHelp;
		}
		if (!Censorship.Censored)
		{
			if (base.Game.Controller.IsPressed(Keys.Space))
			{
				base.Game.Sexscene.PhaseTo(1);
			}
			if (base.Game.Controller.IsPressed(Keys.LeftControl))
			{
				base.Game.Sexscene.PhaseTo(-1);
			}
			if (base.Game.Sexscene.Exploded && base.Game.Controller.IsPressed(Keys.X))
			{
				base.Game.Sexscene.Clean();
			}
			else if (!base.Game.Sexscene.Exploded && base.Game.Controller.IsPressed(Keys.C))
			{
				base.Game.Sexscene.ExplodeWithoutFading();
			}
			else if (!base.Game.Sexscene.Exploded && base.Game.Controller.IsPressed(Keys.V))
			{
				base.Game.Sexscene.Explode();
			}
		}
	}

	public override void DrawOverlay(SpriteBatch spriteBatch)
	{
		base.DrawOverlay(spriteBatch);
		if (!base.Game.IsShowingControls)
		{
			return;
		}
		spriteBatch.Begin();
		if (Censorship.Censored)
		{
			int offset = 10;
			if (base.Game.Sexscene != null && base.Game.Sexscene.GetSubscenes().Length != 0)
			{
				spriteBatch.DrawString(font, "Cycle skin (S)", new Vector2(10f, offset), Color.White);
				offset += 40;
			}
			spriteBatch.DrawString(font, "Toggle phone (Escape or Shift)", new Vector2(10f, offset), Color.White);
		}
		else if (!showHelp)
		{
			spriteBatch.DrawString(font, "Show help (Z)", new Vector2(10f, 10f), Color.White);
		}
		else
		{
			spriteBatch.DrawString(font, "Speed up (Space)", new Vector2(10f, 10f), Color.White);
			spriteBatch.DrawString(font, "Slow down (Left Ctrl)", new Vector2(10f, 50f), Color.White);
			spriteBatch.DrawString(font, "Clean mess (X)", new Vector2(10f, 90f), Color.White);
			spriteBatch.DrawString(font, "Insta-mess (C)", new Vector2(10f, 130f), Color.White);
			spriteBatch.DrawString(font, "Finish it! (V)", new Vector2(10f, 170f), Color.White);
			if (base.Game.Sexscene != null && base.Game.Sexscene.GetSubscenes().Length != 0)
			{
				spriteBatch.DrawString(font, "Cycle skin (S)", new Vector2(10f, 250f), Color.White);
			}
			spriteBatch.DrawString(font, "Toggle phone (Escape or Shift)", new Vector2(10f, 290f), Color.White);
			spriteBatch.DrawString(font, "Hide help (Z)", new Vector2(10f, 330f), Color.White);
		}
		spriteBatch.End();
	}
}
