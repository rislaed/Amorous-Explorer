using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Amorous.Game.Scenes;

public class PlayerSexScene : _7UlnfykmEmZDFt3BmCKZekI43Ih
{
	private bool _jOJQdqVUTXcPDmuOqViqC8pczW;

	private SpriteFont _xnYepZuegigJCU2jcbZsfVIakzF;

	public PlayerSexScene(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		_jOJQdqVUTXcPDmuOqViqC8pczW = true;
		_xnYepZuegigJCU2jcbZsfVIakzF = _JbeCmOie0phb2cbgG6DdGZrbs3pB_0._uwNDZuqdFb9tyQtlQMxiz1DQ7x8.Load<SpriteFont>("Assets/GUI/Fonts/Bold-26");
		_UmxbIbk7pgaod0bD7pS309P3Lns._h0KfaNiikKlJV2KkRPIdVDKVJnC();
	}

	public override void _tiBFUHPEkedkbgvuX3whdeyjhKo(GameTime gameTime_0)
	{
		base._tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime_0);
		if (base._ZzBuoSDMWwerejOO9Goyv2OCKgE._KVSwpLj0RvURRswHn7ogRy4BRfd == null)
		{
			return;
		}
		if (base._ZzBuoSDMWwerejOO9Goyv2OCKgE._RbWJ7YGnYHCSoD44MRW1h5X6E7E._fy5ebLnmRsRXv9v7RKTFU5CGMaH(Keys.Escape))
		{
			_poenyHBGUusBcnNcTFB9MQBV72R._Oewx0FJJ8VX41Prmv0htvGQZhUf();
		}
		if (base._ZzBuoSDMWwerejOO9Goyv2OCKgE._RbWJ7YGnYHCSoD44MRW1h5X6E7E._fy5ebLnmRsRXv9v7RKTFU5CGMaH(Keys.S))
		{
			string[] array = base._ZzBuoSDMWwerejOO9Goyv2OCKgE._KVSwpLj0RvURRswHn7ogRy4BRfd._tCw3HO9jqoEm2Ad1hqdKsA8vS7b();
			if (array.Length == 0)
			{
				return;
			}
			int num = Array.IndexOf(array, base._ZzBuoSDMWwerejOO9Goyv2OCKgE._KVSwpLj0RvURRswHn7ogRy4BRfd._jztzokSobPJKyleCHypP9HS4OhbA);
			num++;
			if (num >= array.Length)
			{
				num = 0;
			}
			base._ZzBuoSDMWwerejOO9Goyv2OCKgE._KVSwpLj0RvURRswHn7ogRy4BRfd._GGyEXu1JJKcG2X3txvtCwyZAylK(array[num]);
		}
		if (base._ZzBuoSDMWwerejOO9Goyv2OCKgE._RbWJ7YGnYHCSoD44MRW1h5X6E7E._fy5ebLnmRsRXv9v7RKTFU5CGMaH(Keys.Z))
		{
			_jOJQdqVUTXcPDmuOqViqC8pczW = !_jOJQdqVUTXcPDmuOqViqC8pczW;
		}
		if (!_iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF)
		{
			if (base._ZzBuoSDMWwerejOO9Goyv2OCKgE._RbWJ7YGnYHCSoD44MRW1h5X6E7E._fy5ebLnmRsRXv9v7RKTFU5CGMaH(Keys.Space))
			{
				base._ZzBuoSDMWwerejOO9Goyv2OCKgE._KVSwpLj0RvURRswHn7ogRy4BRfd._4XV5xPzQUH5ABIwpxH3yf5EIAyL(1);
			}
			if (base._ZzBuoSDMWwerejOO9Goyv2OCKgE._RbWJ7YGnYHCSoD44MRW1h5X6E7E._fy5ebLnmRsRXv9v7RKTFU5CGMaH(Keys.LeftControl))
			{
				base._ZzBuoSDMWwerejOO9Goyv2OCKgE._KVSwpLj0RvURRswHn7ogRy4BRfd._4XV5xPzQUH5ABIwpxH3yf5EIAyL(-1);
			}
			if (base._ZzBuoSDMWwerejOO9Goyv2OCKgE._KVSwpLj0RvURRswHn7ogRy4BRfd._p3lU5oxIaFTVHUNFxJRnaHkXdsA && base._ZzBuoSDMWwerejOO9Goyv2OCKgE._RbWJ7YGnYHCSoD44MRW1h5X6E7E._fy5ebLnmRsRXv9v7RKTFU5CGMaH(Keys.X))
			{
				base._ZzBuoSDMWwerejOO9Goyv2OCKgE._KVSwpLj0RvURRswHn7ogRy4BRfd._paoLItUYkFWaGSDnCAvBagJ1F5T();
			}
			else if (!base._ZzBuoSDMWwerejOO9Goyv2OCKgE._KVSwpLj0RvURRswHn7ogRy4BRfd._p3lU5oxIaFTVHUNFxJRnaHkXdsA && base._ZzBuoSDMWwerejOO9Goyv2OCKgE._RbWJ7YGnYHCSoD44MRW1h5X6E7E._fy5ebLnmRsRXv9v7RKTFU5CGMaH(Keys.C))
			{
				base._ZzBuoSDMWwerejOO9Goyv2OCKgE._KVSwpLj0RvURRswHn7ogRy4BRfd._JHfBnmyItvKJDQtdUPp2yLsm4yR();
			}
			else if (!base._ZzBuoSDMWwerejOO9Goyv2OCKgE._KVSwpLj0RvURRswHn7ogRy4BRfd._p3lU5oxIaFTVHUNFxJRnaHkXdsA && base._ZzBuoSDMWwerejOO9Goyv2OCKgE._RbWJ7YGnYHCSoD44MRW1h5X6E7E._fy5ebLnmRsRXv9v7RKTFU5CGMaH(Keys.V))
			{
				base._ZzBuoSDMWwerejOO9Goyv2OCKgE._KVSwpLj0RvURRswHn7ogRy4BRfd._oHE0dGUBNplXQia6K85vMaNc8jp();
			}
		}
	}

	public override void _Z70nK2EA1n5FNJxjWP0TzHQ0Lzb(SpriteBatch spriteBatch_0)
	{
		base._Z70nK2EA1n5FNJxjWP0TzHQ0Lzb(spriteBatch_0);
		if (!base._ZzBuoSDMWwerejOO9Goyv2OCKgE._ezjxb7tsh6Db1xblB74OYX4vVK)
		{
			return;
		}
		spriteBatch_0.Begin();
		if (_iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF)
		{
			int num = 10;
			if (base._ZzBuoSDMWwerejOO9Goyv2OCKgE._KVSwpLj0RvURRswHn7ogRy4BRfd != null && base._ZzBuoSDMWwerejOO9Goyv2OCKgE._KVSwpLj0RvURRswHn7ogRy4BRfd._tCw3HO9jqoEm2Ad1hqdKsA8vS7b().Length != 0)
			{
				spriteBatch_0._FY70IFLoBond3ORPe0ndCLvIeVcA(_xnYepZuegigJCU2jcbZsfVIakzF, "Cycle skin (S)", new Vector2(10f, num), Color.White);
				num += 40;
			}
			spriteBatch_0._FY70IFLoBond3ORPe0ndCLvIeVcA(_xnYepZuegigJCU2jcbZsfVIakzF, "Toggle phone (Escape or Shift)", new Vector2(10f, num), Color.White);
		}
		else if (!_jOJQdqVUTXcPDmuOqViqC8pczW)
		{
			spriteBatch_0._FY70IFLoBond3ORPe0ndCLvIeVcA(_xnYepZuegigJCU2jcbZsfVIakzF, "Show help (Z)", new Vector2(10f, 10f), Color.White);
		}
		else
		{
			spriteBatch_0._FY70IFLoBond3ORPe0ndCLvIeVcA(_xnYepZuegigJCU2jcbZsfVIakzF, "Speed up (Space)", new Vector2(10f, 10f), Color.White);
			spriteBatch_0._FY70IFLoBond3ORPe0ndCLvIeVcA(_xnYepZuegigJCU2jcbZsfVIakzF, "Slow down (Left Ctrl)", new Vector2(10f, 50f), Color.White);
			spriteBatch_0._FY70IFLoBond3ORPe0ndCLvIeVcA(_xnYepZuegigJCU2jcbZsfVIakzF, "Clean mess (X)", new Vector2(10f, 90f), Color.White);
			spriteBatch_0._FY70IFLoBond3ORPe0ndCLvIeVcA(_xnYepZuegigJCU2jcbZsfVIakzF, "Insta-mess (C)", new Vector2(10f, 130f), Color.White);
			spriteBatch_0._FY70IFLoBond3ORPe0ndCLvIeVcA(_xnYepZuegigJCU2jcbZsfVIakzF, "Finish it! (V)", new Vector2(10f, 170f), Color.White);
			if (base._ZzBuoSDMWwerejOO9Goyv2OCKgE._KVSwpLj0RvURRswHn7ogRy4BRfd != null && base._ZzBuoSDMWwerejOO9Goyv2OCKgE._KVSwpLj0RvURRswHn7ogRy4BRfd._tCw3HO9jqoEm2Ad1hqdKsA8vS7b().Length != 0)
			{
				spriteBatch_0._FY70IFLoBond3ORPe0ndCLvIeVcA(_xnYepZuegigJCU2jcbZsfVIakzF, "Cycle skin (S)", new Vector2(10f, 250f), Color.White);
			}
			spriteBatch_0._FY70IFLoBond3ORPe0ndCLvIeVcA(_xnYepZuegigJCU2jcbZsfVIakzF, "Toggle phone (Escape or Shift)", new Vector2(10f, 290f), Color.White);
			spriteBatch_0._FY70IFLoBond3ORPe0ndCLvIeVcA(_xnYepZuegigJCU2jcbZsfVIakzF, "Hide help (Z)", new Vector2(10f, 330f), Color.White);
		}
		spriteBatch_0.End();
	}

	static ContentManager smethod_14(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		return _JbeCmOie0phb2cbgG6DdGZrbs3pB_0._uwNDZuqdFb9tyQtlQMxiz1DQ7x8;
	}

	static void smethod_15()
	{
		_UmxbIbk7pgaod0bD7pS309P3Lns._h0KfaNiikKlJV2KkRPIdVDKVJnC();
	}

	void method_0(GameTime gameTime_0)
	{
		base._tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime_0);
	}

	static _JbeCmOie0phb2cbgG6DdGZrbs3pB smethod_16(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0)
	{
		return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._ZzBuoSDMWwerejOO9Goyv2OCKgE;
	}

	static _TwlwMC1hhdSzamwGWEBxuUkz1gH smethod_17(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		return _JbeCmOie0phb2cbgG6DdGZrbs3pB_0._KVSwpLj0RvURRswHn7ogRy4BRfd;
	}

	static _3FFZvGWTAe7rsviKkDPTXEVjxWf smethod_18(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		return _JbeCmOie0phb2cbgG6DdGZrbs3pB_0._RbWJ7YGnYHCSoD44MRW1h5X6E7E;
	}

	static bool smethod_19(_3FFZvGWTAe7rsviKkDPTXEVjxWf _3FFZvGWTAe7rsviKkDPTXEVjxWf_0, Keys keys_0)
	{
		return _3FFZvGWTAe7rsviKkDPTXEVjxWf_0._fy5ebLnmRsRXv9v7RKTFU5CGMaH(keys_0);
	}

	static string[] smethod_20(_TwlwMC1hhdSzamwGWEBxuUkz1gH _TwlwMC1hhdSzamwGWEBxuUkz1gH_0)
	{
		return _TwlwMC1hhdSzamwGWEBxuUkz1gH_0._tCw3HO9jqoEm2Ad1hqdKsA8vS7b();
	}

	static string smethod_21(_TwlwMC1hhdSzamwGWEBxuUkz1gH _TwlwMC1hhdSzamwGWEBxuUkz1gH_0)
	{
		return _TwlwMC1hhdSzamwGWEBxuUkz1gH_0._jztzokSobPJKyleCHypP9HS4OhbA;
	}

	static void smethod_22(_TwlwMC1hhdSzamwGWEBxuUkz1gH _TwlwMC1hhdSzamwGWEBxuUkz1gH_0, string string_0)
	{
		_TwlwMC1hhdSzamwGWEBxuUkz1gH_0._GGyEXu1JJKcG2X3txvtCwyZAylK(string_0);
	}

	static bool smethod_23()
	{
		return _iExD93IWLlzVfXsU9wyrEvWgJsg._4xsgdTzAotLBDxTjCbQBCY4YtpF;
	}

	static void smethod_24(_TwlwMC1hhdSzamwGWEBxuUkz1gH _TwlwMC1hhdSzamwGWEBxuUkz1gH_0, int int_0, bool bool_0)
	{
		_TwlwMC1hhdSzamwGWEBxuUkz1gH_0._4XV5xPzQUH5ABIwpxH3yf5EIAyL(int_0, bool_0);
	}

	static bool smethod_25(_TwlwMC1hhdSzamwGWEBxuUkz1gH _TwlwMC1hhdSzamwGWEBxuUkz1gH_0)
	{
		return _TwlwMC1hhdSzamwGWEBxuUkz1gH_0._p3lU5oxIaFTVHUNFxJRnaHkXdsA;
	}

	static void smethod_26(_TwlwMC1hhdSzamwGWEBxuUkz1gH _TwlwMC1hhdSzamwGWEBxuUkz1gH_0)
	{
		_TwlwMC1hhdSzamwGWEBxuUkz1gH_0._paoLItUYkFWaGSDnCAvBagJ1F5T();
	}

	static void smethod_27(_TwlwMC1hhdSzamwGWEBxuUkz1gH _TwlwMC1hhdSzamwGWEBxuUkz1gH_0)
	{
		_TwlwMC1hhdSzamwGWEBxuUkz1gH_0._JHfBnmyItvKJDQtdUPp2yLsm4yR();
	}

	static void smethod_28(_TwlwMC1hhdSzamwGWEBxuUkz1gH _TwlwMC1hhdSzamwGWEBxuUkz1gH_0)
	{
		_TwlwMC1hhdSzamwGWEBxuUkz1gH_0._oHE0dGUBNplXQia6K85vMaNc8jp();
	}

	void method_1(SpriteBatch spriteBatch_0)
	{
		base._Z70nK2EA1n5FNJxjWP0TzHQ0Lzb(spriteBatch_0);
	}

	static bool smethod_29(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		return _JbeCmOie0phb2cbgG6DdGZrbs3pB_0._ezjxb7tsh6Db1xblB74OYX4vVK;
	}

	static void smethod_30(SpriteBatch spriteBatch_0)
	{
		spriteBatch_0.Begin();
	}
}
