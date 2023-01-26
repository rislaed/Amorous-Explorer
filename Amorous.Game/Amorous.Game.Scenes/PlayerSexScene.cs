using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Amorous.Game.Scenes;

public class PlayerSexScene : AbstractScene
{
	private bool _jOJQdqVUTXcPDmuOqViqC8pczW;

	private SpriteFont _xnYepZuegigJCU2jcbZsfVIakzF;

	public PlayerSexScene(IAmorous game)
		: base(game)
	{
		_jOJQdqVUTXcPDmuOqViqC8pczW = true;
		_xnYepZuegigJCU2jcbZsfVIakzF = Game.Content.Load<SpriteFont>("Assets/GUI/Fonts/Bold-26");
		_UmxbIbk7pgaod0bD7pS309P3Lns._h0KfaNiikKlJV2KkRPIdVDKVJnC();
	}

	public override void Update(GameTime gameTime)
	{
		base.Update(gameTime);
		if (base.Game.Sexscene == null)
		{
			return;
		}
		if (base.Game._RbWJ7YGnYHCSoD44MRW1h5X6E7E._fy5ebLnmRsRXv9v7RKTFU5CGMaH(Keys.Escape))
		{
			_poenyHBGUusBcnNcTFB9MQBV72R._Oewx0FJJ8VX41Prmv0htvGQZhUf();
		}
		if (base.Game._RbWJ7YGnYHCSoD44MRW1h5X6E7E._fy5ebLnmRsRXv9v7RKTFU5CGMaH(Keys.S))
		{
			string[] array = base.Game.Sexscene.GetSkins();
			if (array.Length == 0)
			{
				return;
			}
			int num = Array.IndexOf(array, base.Game.Sexscene._jztzokSobPJKyleCHypP9HS4OhbA);
			num++;
			if (num >= array.Length)
			{
				num = 0;
			}
			base.Game.Sexscene.SetSkin(array[num]);
		}
		if (base.Game._RbWJ7YGnYHCSoD44MRW1h5X6E7E._fy5ebLnmRsRXv9v7RKTFU5CGMaH(Keys.Z))
		{
			_jOJQdqVUTXcPDmuOqViqC8pczW = !_jOJQdqVUTXcPDmuOqViqC8pczW;
		}
		if (!Censorship.Censored)
		{
			if (base.Game._RbWJ7YGnYHCSoD44MRW1h5X6E7E._fy5ebLnmRsRXv9v7RKTFU5CGMaH(Keys.Space))
			{
				base.Game.Sexscene._4XV5xPzQUH5ABIwpxH3yf5EIAyL(1);
			}
			if (base.Game._RbWJ7YGnYHCSoD44MRW1h5X6E7E._fy5ebLnmRsRXv9v7RKTFU5CGMaH(Keys.LeftControl))
			{
				base.Game.Sexscene._4XV5xPzQUH5ABIwpxH3yf5EIAyL(-1);
			}
			if (base.Game.Sexscene._p3lU5oxIaFTVHUNFxJRnaHkXdsA && base.Game._RbWJ7YGnYHCSoD44MRW1h5X6E7E._fy5ebLnmRsRXv9v7RKTFU5CGMaH(Keys.X))
			{
				base.Game.Sexscene._paoLItUYkFWaGSDnCAvBagJ1F5T();
			}
			else if (!base.Game.Sexscene._p3lU5oxIaFTVHUNFxJRnaHkXdsA && base.Game._RbWJ7YGnYHCSoD44MRW1h5X6E7E._fy5ebLnmRsRXv9v7RKTFU5CGMaH(Keys.C))
			{
				base.Game.Sexscene._JHfBnmyItvKJDQtdUPp2yLsm4yR();
			}
			else if (!base.Game.Sexscene._p3lU5oxIaFTVHUNFxJRnaHkXdsA && base.Game._RbWJ7YGnYHCSoD44MRW1h5X6E7E._fy5ebLnmRsRXv9v7RKTFU5CGMaH(Keys.V))
			{
				base.Game.Sexscene._oHE0dGUBNplXQia6K85vMaNc8jp();
			}
		}
	}

	public override void Render(SpriteBatch spriteBatch)
	{
		base.Render(spriteBatch);
		if (!base.Game._ezjxb7tsh6Db1xblB74OYX4vVK)
		{
			return;
		}
		spriteBatch.Begin();
		if (Censorship.Censored)
		{
			int num = 10;
			if (base.Game.Sexscene != null && base.Game.Sexscene.GetSkins().Length != 0)
			{
				spriteBatch.DrawString(_xnYepZuegigJCU2jcbZsfVIakzF, "Cycle skin (S)", new Vector2(10f, num), Color.White);
				num += 40;
			}
			spriteBatch.DrawString(_xnYepZuegigJCU2jcbZsfVIakzF, "Toggle phone (Escape or Shift)", new Vector2(10f, num), Color.White);
		}
		else if (!_jOJQdqVUTXcPDmuOqViqC8pczW)
		{
			spriteBatch.DrawString(_xnYepZuegigJCU2jcbZsfVIakzF, "Show help (Z)", new Vector2(10f, 10f), Color.White);
		}
		else
		{
			spriteBatch.DrawString(_xnYepZuegigJCU2jcbZsfVIakzF, "Speed up (Space)", new Vector2(10f, 10f), Color.White);
			spriteBatch.DrawString(_xnYepZuegigJCU2jcbZsfVIakzF, "Slow down (Left Ctrl)", new Vector2(10f, 50f), Color.White);
			spriteBatch.DrawString(_xnYepZuegigJCU2jcbZsfVIakzF, "Clean mess (X)", new Vector2(10f, 90f), Color.White);
			spriteBatch.DrawString(_xnYepZuegigJCU2jcbZsfVIakzF, "Insta-mess (C)", new Vector2(10f, 130f), Color.White);
			spriteBatch.DrawString(_xnYepZuegigJCU2jcbZsfVIakzF, "Finish it! (V)", new Vector2(10f, 170f), Color.White);
			if (base.Game.Sexscene != null && base.Game.Sexscene.GetSkins().Length != 0)
			{
				spriteBatch.DrawString(_xnYepZuegigJCU2jcbZsfVIakzF, "Cycle skin (S)", new Vector2(10f, 250f), Color.White);
			}
			spriteBatch.DrawString(_xnYepZuegigJCU2jcbZsfVIakzF, "Toggle phone (Escape or Shift)", new Vector2(10f, 290f), Color.White);
			spriteBatch.DrawString(_xnYepZuegigJCU2jcbZsfVIakzF, "Hide help (Z)", new Vector2(10f, 330f), Color.White);
		}
		spriteBatch.End();
	}
}
