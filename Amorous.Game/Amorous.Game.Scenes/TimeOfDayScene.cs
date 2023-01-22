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
		_6hE3geqxrB1vCirtSWHxIJjlTQB("Day");
	}

	public override void _6hE3geqxrB1vCirtSWHxIJjlTQB(string string_0)
	{
		base._6hE3geqxrB1vCirtSWHxIJjlTQB(string_0);
		switch (string_0)
		{
		case "Sunset":
			_5Anqe6GAAkzemoAXYpJmgMlk1yz._3DInasj5B11bCcV5BIRvLE1Ay7w = false;
			_5Anqe6GAAkzemoAXYpJmgMlk1yz._rf41M6fa6MhAPBvvUvQseEZTt9Q = _RRECH42isVc35MkZPyLEGkp0hjs.Sunset;
			break;
		case "Day":
			_5Anqe6GAAkzemoAXYpJmgMlk1yz._3DInasj5B11bCcV5BIRvLE1Ay7w = false;
			_5Anqe6GAAkzemoAXYpJmgMlk1yz._rf41M6fa6MhAPBvvUvQseEZTt9Q = _RRECH42isVc35MkZPyLEGkp0hjs.Day;
			break;
		case "Morning":
			_5Anqe6GAAkzemoAXYpJmgMlk1yz._3DInasj5B11bCcV5BIRvLE1Ay7w = false;
			_5Anqe6GAAkzemoAXYpJmgMlk1yz._rf41M6fa6MhAPBvvUvQseEZTt9Q = _RRECH42isVc35MkZPyLEGkp0hjs.Morning;
			break;
		case "Night":
			_5Anqe6GAAkzemoAXYpJmgMlk1yz._3DInasj5B11bCcV5BIRvLE1Ay7w = false;
			_5Anqe6GAAkzemoAXYpJmgMlk1yz._rf41M6fa6MhAPBvvUvQseEZTt9Q = _RRECH42isVc35MkZPyLEGkp0hjs.Night;
			break;
		}
	}

	public override void _tiBFUHPEkedkbgvuX3whdeyjhKo(GameTime gameTime_0)
	{
		_TyX29AlEBF2URt0abU6bc2VBQvm._tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime_0);
		base._tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime_0);
	}

	public override void _Z70nK2EA1n5FNJxjWP0TzHQ0Lzb(SpriteBatch spriteBatch_0)
	{
		_TyX29AlEBF2URt0abU6bc2VBQvm._f5ctqAmdNsZ889UjM4LxDm8WGxA(spriteBatch_0, base._ZzBuoSDMWwerejOO9Goyv2OCKgE._vsceSzSIjBy2nZrCxAzKZbUiwLq);
		base._Z70nK2EA1n5FNJxjWP0TzHQ0Lzb(spriteBatch_0);
	}
}
