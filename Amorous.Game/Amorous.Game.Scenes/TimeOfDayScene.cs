using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Amorous.Game.Scenes;

public abstract class TimeOfDayScene : _7UlnfykmEmZDFt3BmCKZekI43Ih
{
	protected const string _GVrFhyughFuZbNz1GllPUz8qFRC = "Night";

	protected const string _CKUkfACCW7C1UVsHBKFoeiulzIh = "Morning";

	protected const string _3MHNjx9EVkIdQ2cErS7bp0bJSr8A = "Day";

	protected const string _RS0gzIMaA8RvbsLb5OBhWAI8orc = "Sunset";

	private readonly _G2GbwTTqXkVDMUL6fDmljsAPB4s _TyX29AlEBF2URt0abU6bc2VBQvm;

	protected TimeOfDayScene(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		_TyX29AlEBF2URt0abU6bc2VBQvm = new _G2GbwTTqXkVDMUL6fDmljsAPB4s(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0);
	}

	public override void _4hlxzMzKSbVTbZUrEsP3dfw4x0h()
	{
		TimeOfDayScene.smethod_14((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Day");
	}

	public override void _6hE3geqxrB1vCirtSWHxIJjlTQB(string string_0)
	{
		this.method_0(string_0);
		if (!TimeOfDayScene.smethod_15(string_0, "Night"))
		{
			if (!TimeOfDayScene.smethod_15(string_0, "Morning"))
			{
				if (!TimeOfDayScene.smethod_15(string_0, "Day"))
				{
					if (TimeOfDayScene.smethod_15(string_0, "Sunset"))
					{
						_5Anqe6GAAkzemoAXYpJmgMlk1yz._3DInasj5B11bCcV5BIRvLE1Ay7w = false;
						_5Anqe6GAAkzemoAXYpJmgMlk1yz._rf41M6fa6MhAPBvvUvQseEZTt9Q = _RRECH42isVc35MkZPyLEGkp0hjs.Sunset;
					}
				}
				else
				{
					_5Anqe6GAAkzemoAXYpJmgMlk1yz._3DInasj5B11bCcV5BIRvLE1Ay7w = false;
					_5Anqe6GAAkzemoAXYpJmgMlk1yz._rf41M6fa6MhAPBvvUvQseEZTt9Q = _RRECH42isVc35MkZPyLEGkp0hjs.Day;
				}
			}
			else
			{
				_5Anqe6GAAkzemoAXYpJmgMlk1yz._3DInasj5B11bCcV5BIRvLE1Ay7w = false;
				_5Anqe6GAAkzemoAXYpJmgMlk1yz._rf41M6fa6MhAPBvvUvQseEZTt9Q = _RRECH42isVc35MkZPyLEGkp0hjs.Morning;
			}
		}
		else
		{
			_5Anqe6GAAkzemoAXYpJmgMlk1yz._3DInasj5B11bCcV5BIRvLE1Ay7w = false;
			_5Anqe6GAAkzemoAXYpJmgMlk1yz._rf41M6fa6MhAPBvvUvQseEZTt9Q = _RRECH42isVc35MkZPyLEGkp0hjs.Night;
		}
	}

	public override void _tiBFUHPEkedkbgvuX3whdeyjhKo(GameTime gameTime_0)
	{
		_TyX29AlEBF2URt0abU6bc2VBQvm._tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime_0);
		this.method_1(gameTime_0);
	}

	public override void _Z70nK2EA1n5FNJxjWP0TzHQ0Lzb(SpriteBatch spriteBatch_0)
	{
		_TyX29AlEBF2URt0abU6bc2VBQvm._f5ctqAmdNsZ889UjM4LxDm8WGxA(spriteBatch_0, TimeOfDayScene.smethod_17(TimeOfDayScene.smethod_16((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)));
		this.method_2(spriteBatch_0);
	}

	static void smethod_14(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0, string string_0)
	{
		_7UlnfykmEmZDFt3BmCKZekI43Ih_0._6hE3geqxrB1vCirtSWHxIJjlTQB(string_0);
	}

	void method_0(string string_0)
	{
		base._6hE3geqxrB1vCirtSWHxIJjlTQB(string_0);
	}

	static bool smethod_15(string string_0, string string_1)
	{
		return string_0 == string_1;
	}

	void method_1(GameTime gameTime_0)
	{
		base._tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime_0);
	}

	static _JbeCmOie0phb2cbgG6DdGZrbs3pB smethod_16(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0)
	{
		return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._ZzBuoSDMWwerejOO9Goyv2OCKgE;
	}

	static _wRd4nHuQQlAPEwrHOGkBfut6Uip smethod_17(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		return _JbeCmOie0phb2cbgG6DdGZrbs3pB_0._vsceSzSIjBy2nZrCxAzKZbUiwLq;
	}

	void method_2(SpriteBatch spriteBatch_0)
	{
		base._Z70nK2EA1n5FNJxjWP0TzHQ0Lzb(spriteBatch_0);
	}
}
