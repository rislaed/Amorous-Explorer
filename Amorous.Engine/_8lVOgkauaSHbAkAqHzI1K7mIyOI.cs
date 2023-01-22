using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Squid;

public class _8lVOgkauaSHbAkAqHzI1K7mIyOI
{
	public _JbeCmOie0phb2cbgG6DdGZrbs3pB _ZzBuoSDMWwerejOO9Goyv2OCKgE { get; private set; }

	public List<_1dTaaW9MQWoHm2Pqblg0u9bPhpe> _6qfro4buoEQEXNMVAj08xANyjWf { get; private set; }

	public bool _nJKYvZJ57vjjlQwmoeBmKihtS0b { get; set; }

	public _8lVOgkauaSHbAkAqHzI1K7mIyOI(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		_ZzBuoSDMWwerejOO9Goyv2OCKgE = _JbeCmOie0phb2cbgG6DdGZrbs3pB_0;
		_6qfro4buoEQEXNMVAj08xANyjWf = new List<_1dTaaW9MQWoHm2Pqblg0u9bPhpe>();
		_nJKYvZJ57vjjlQwmoeBmKihtS0b = true;
	}

	public _d4ad1i8rcZMvfN9iaxggA1KtVgx _aiunwWjasFcF9afjl2FnUxWXB0M(string string_0, string string_1, int int_0, int int_1, Rectangle rectangle_0, Action action_0)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		Texture2D texture2D_ = _ZzBuoSDMWwerejOO9Goyv2OCKgE._uwNDZuqdFb9tyQtlQMxiz1DQ7x8.Load<Texture2D>(string_0);
		Texture2D texture2D_2 = null;
		if (!_8lVOgkauaSHbAkAqHzI1K7mIyOI.smethod_0(string_1))
		{
			texture2D_2 = _ZzBuoSDMWwerejOO9Goyv2OCKgE._uwNDZuqdFb9tyQtlQMxiz1DQ7x8.Load<Texture2D>(string_1);
		}
		return _aiunwWjasFcF9afjl2FnUxWXB0M(texture2D_, texture2D_2, int_0, int_1, rectangle_0, action_0);
	}

	public _d4ad1i8rcZMvfN9iaxggA1KtVgx _aiunwWjasFcF9afjl2FnUxWXB0M(Texture2D texture2D_0, Texture2D texture2D_1, int int_0, int int_1, Rectangle rectangle_0, Action action_0)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		_d4ad1i8rcZMvfN9iaxggA1KtVgx d4ad1i8rcZMvfN9iaxggA1KtVgx = new _d4ad1i8rcZMvfN9iaxggA1KtVgx(texture2D_0, texture2D_1, action_0)
		{
			_7Xn1C5tjYnmIif1iZKV8AWsEEbL = int_0,
			_bCjZ3VSXGKyhmykd2zCnQBiSpDf = int_1,
			_2psWLw4AI8EIjQzaXnhGg8M1FnaA = rectangle_0
		};
		_6qfro4buoEQEXNMVAj08xANyjWf.Add(d4ad1i8rcZMvfN9iaxggA1KtVgx);
		return d4ad1i8rcZMvfN9iaxggA1KtVgx;
	}

	public _iHJrndJdM1jj9TEnuU3BvgdDuvf _QVqIVxBeF2SAQh6HDFwwp2RFmXB(string string_0, string string_1, string string_2, string string_3, Color color_0, int int_0, int int_1, Rectangle rectangle_0, Action action_0)
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		Texture2D texture2D_ = _ZzBuoSDMWwerejOO9Goyv2OCKgE._uwNDZuqdFb9tyQtlQMxiz1DQ7x8.Load<Texture2D>(string_0);
		Texture2D texture2D_2 = null;
		if (!_8lVOgkauaSHbAkAqHzI1K7mIyOI.smethod_0(string_1))
		{
			texture2D_2 = _ZzBuoSDMWwerejOO9Goyv2OCKgE._uwNDZuqdFb9tyQtlQMxiz1DQ7x8.Load<Texture2D>(string_1);
		}
		SpriteFont spriteFont_ = _ZzBuoSDMWwerejOO9Goyv2OCKgE._uwNDZuqdFb9tyQtlQMxiz1DQ7x8.Load<SpriteFont>(string_2);
		return _QVqIVxBeF2SAQh6HDFwwp2RFmXB(texture2D_, texture2D_2, spriteFont_, string_3, color_0, int_0, int_1, rectangle_0, action_0);
	}

	public _iHJrndJdM1jj9TEnuU3BvgdDuvf _QVqIVxBeF2SAQh6HDFwwp2RFmXB(Texture2D texture2D_0, Texture2D texture2D_1, SpriteFont spriteFont_0, string string_0, Color color_0, int int_0, int int_1, Rectangle rectangle_0, Action action_0)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		_iHJrndJdM1jj9TEnuU3BvgdDuvf iHJrndJdM1jj9TEnuU3BvgdDuvf = new _iHJrndJdM1jj9TEnuU3BvgdDuvf(texture2D_0, texture2D_1, spriteFont_0, string_0, color_0, action_0)
		{
			_7Xn1C5tjYnmIif1iZKV8AWsEEbL = int_0,
			_bCjZ3VSXGKyhmykd2zCnQBiSpDf = int_1,
			_2psWLw4AI8EIjQzaXnhGg8M1FnaA = rectangle_0
		};
		_6qfro4buoEQEXNMVAj08xANyjWf.Add(iHJrndJdM1jj9TEnuU3BvgdDuvf);
		return iHJrndJdM1jj9TEnuU3BvgdDuvf;
	}

	public _abqs0UynzjUEhuA3VpR4t6Uuk0E _83EecuYIFalvL6Gd1s9MoTLHdgq(string string_0, string string_1, Alignment alignment_0, Color color_0, int int_0, int int_1)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		SpriteFont spriteFont_ = _ZzBuoSDMWwerejOO9Goyv2OCKgE._uwNDZuqdFb9tyQtlQMxiz1DQ7x8.Load<SpriteFont>(string_0);
		_abqs0UynzjUEhuA3VpR4t6Uuk0E abqs0UynzjUEhuA3VpR4t6Uuk0E = new _abqs0UynzjUEhuA3VpR4t6Uuk0E(spriteFont_, string_1, color_0)
		{
			_7Xn1C5tjYnmIif1iZKV8AWsEEbL = int_0,
			_bCjZ3VSXGKyhmykd2zCnQBiSpDf = int_1,
			_Jqhiw18E7t7bvnwwzxO89bHpPnL = alignment_0
		};
		_6qfro4buoEQEXNMVAj08xANyjWf.Add(abqs0UynzjUEhuA3VpR4t6Uuk0E);
		return abqs0UynzjUEhuA3VpR4t6Uuk0E;
	}

	public void _tiBFUHPEkedkbgvuX3whdeyjhKo(GameTime gameTime_0)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		if (!_nJKYvZJ57vjjlQwmoeBmKihtS0b)
		{
			return;
		}
		Point val = _ZzBuoSDMWwerejOO9Goyv2OCKgE._vsceSzSIjBy2nZrCxAzKZbUiwLq._u7uCdK9i8FnWhiaPn2bO2wIgUUuA(_ZzBuoSDMWwerejOO9Goyv2OCKgE._RbWJ7YGnYHCSoD44MRW1h5X6E7E._U7CeYBJ1v1SoUxpX8emsQ9mWl5b);
		foreach (_1dTaaW9MQWoHm2Pqblg0u9bPhpe item in _6qfro4buoEQEXNMVAj08xANyjWf)
		{
			if (item._Fxy2SlgceW90FloFw6a1AEJODYA)
			{
				bool flag = ((Rectangle)(ref item._2psWLw4AI8EIjQzaXnhGg8M1FnaA)).Contains(val);
				if (!item._NUP8Fs8I7oMuI6vfg25DFKFlQqE && flag)
				{
					item._4xz3iE0ff4Zjl6ybnWxczeMPKyB();
				}
				else if (item._NUP8Fs8I7oMuI6vfg25DFKFlQqE && !flag)
				{
					item._TVKS7kokuGdoU8kMxQQPKABgo4c();
				}
			}
		}
		if (!_ZzBuoSDMWwerejOO9Goyv2OCKgE._RbWJ7YGnYHCSoD44MRW1h5X6E7E._fy5ebLnmRsRXv9v7RKTFU5CGMaH(_PMeRYZJaBCqgB9uADJFP3c14lxq.LeftButton))
		{
			return;
		}
		foreach (_1dTaaW9MQWoHm2Pqblg0u9bPhpe item2 in _6qfro4buoEQEXNMVAj08xANyjWf)
		{
			if (item2._Fxy2SlgceW90FloFw6a1AEJODYA && ((Rectangle)(ref item2._2psWLw4AI8EIjQzaXnhGg8M1FnaA)).Contains(val))
			{
				item2._eJedLbGgSejIX7Xyx6RoIYD1soJA();
			}
		}
	}

	public void _f5ctqAmdNsZ889UjM4LxDm8WGxA(SpriteBatch spriteBatch_0)
	{
		_8lVOgkauaSHbAkAqHzI1K7mIyOI.smethod_1(spriteBatch_0);
		foreach (_1dTaaW9MQWoHm2Pqblg0u9bPhpe item in _6qfro4buoEQEXNMVAj08xANyjWf)
		{
			if (item._Fxy2SlgceW90FloFw6a1AEJODYA)
			{
				item._f5ctqAmdNsZ889UjM4LxDm8WGxA(spriteBatch_0);
			}
		}
		_8lVOgkauaSHbAkAqHzI1K7mIyOI.smethod_2(spriteBatch_0);
	}

	static bool smethod_0(string string_0)
	{
		return string.IsNullOrEmpty(string_0);
	}

	static void smethod_1(SpriteBatch spriteBatch_0)
	{
		spriteBatch_0.Begin();
	}

	static void smethod_2(SpriteBatch spriteBatch_0)
	{
		spriteBatch_0.End();
	}
}
