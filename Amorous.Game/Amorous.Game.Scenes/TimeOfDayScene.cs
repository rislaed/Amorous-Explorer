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
		while (true)
		{
			int num = -1983866824;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x80037A9Eu) % 13u)
				{
				case 12u:
				{
					int num5;
					int num6;
					if (!TimeOfDayScene.smethod_15(string_0, "Night"))
					{
						num5 = 1180018066;
						num6 = 1180018066;
					}
					else
					{
						num5 = 1770987131;
						num6 = 1770987131;
					}
					num = num5 ^ ((int)num2 * -1115202707);
					continue;
				}
				case 11u:
				{
					int num4;
					if (TimeOfDayScene.smethod_15(string_0, "Morning"))
					{
						num = -515184065;
						num4 = -515184065;
					}
					else
					{
						num = -1601548662;
						num4 = -1601548662;
					}
					continue;
				}
				case 8u:
				{
					int num7;
					if (!TimeOfDayScene.smethod_15(string_0, "Day"))
					{
						num = -625386128;
						num7 = -625386128;
					}
					else
					{
						num = -630065639;
						num7 = -630065639;
					}
					continue;
				}
				case 7u:
					_5Anqe6GAAkzemoAXYpJmgMlk1yz._3DInasj5B11bCcV5BIRvLE1Ay7w = false;
					num = (int)(num2 * 1333602179) ^ -1524280716;
					continue;
				case 3u:
					_5Anqe6GAAkzemoAXYpJmgMlk1yz._3DInasj5B11bCcV5BIRvLE1Ay7w = false;
					num = (int)(num2 * 1784021743) ^ -63293475;
					continue;
				case 2u:
				{
					int num3;
					if (TimeOfDayScene.smethod_15(string_0, "Sunset"))
					{
						num = -1948812120;
						num3 = -1948812120;
					}
					else
					{
						num = -538129954;
						num3 = -538129954;
					}
					continue;
				}
				case 1u:
					_5Anqe6GAAkzemoAXYpJmgMlk1yz._3DInasj5B11bCcV5BIRvLE1Ay7w = false;
					_5Anqe6GAAkzemoAXYpJmgMlk1yz._rf41M6fa6MhAPBvvUvQseEZTt9Q = _RRECH42isVc35MkZPyLEGkp0hjs.Sunset;
					num = (int)(num2 * 1197245195) ^ -379768948;
					continue;
				case 0u:
					_5Anqe6GAAkzemoAXYpJmgMlk1yz._rf41M6fa6MhAPBvvUvQseEZTt9Q = _RRECH42isVc35MkZPyLEGkp0hjs.Day;
					num = ((int)num2 * -1434665463) ^ 0xD0666BF;
					continue;
				default:
					return;
				case 9u:
					break;
				case 4u:
					return;
				case 5u:
					_5Anqe6GAAkzemoAXYpJmgMlk1yz._3DInasj5B11bCcV5BIRvLE1Ay7w = false;
					_5Anqe6GAAkzemoAXYpJmgMlk1yz._rf41M6fa6MhAPBvvUvQseEZTt9Q = _RRECH42isVc35MkZPyLEGkp0hjs.Morning;
					return;
				case 6u:
					_5Anqe6GAAkzemoAXYpJmgMlk1yz._rf41M6fa6MhAPBvvUvQseEZTt9Q = _RRECH42isVc35MkZPyLEGkp0hjs.Night;
					return;
				case 10u:
					return;
				}
				break;
			}
		}
	}

	public override void _tiBFUHPEkedkbgvuX3whdeyjhKo(GameTime gameTime_0)
	{
		_TyX29AlEBF2URt0abU6bc2VBQvm._tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime_0);
		while (true)
		{
			int num = 501653209;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5BCB2D0Fu) % 3u)
				{
				case 1u:
					goto IL_000e;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_000e:
				this.method_1(gameTime_0);
				num = ((int)num2 * -1010395452) ^ -1780127466;
			}
		}
	}

	public override void _Z70nK2EA1n5FNJxjWP0TzHQ0Lzb(SpriteBatch spriteBatch_0)
	{
		_TyX29AlEBF2URt0abU6bc2VBQvm._f5ctqAmdNsZ889UjM4LxDm8WGxA(spriteBatch_0, TimeOfDayScene.smethod_17(TimeOfDayScene.smethod_16((_7UlnfykmEmZDFt3BmCKZekI43Ih)this)));
		while (true)
		{
			int num = -2132736163;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x93BB8E8Du) % 3u)
				{
				case 1u:
					goto IL_0019;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_0019:
				this.method_2(spriteBatch_0);
				num = ((int)num2 * -347624117) ^ -1799141665;
			}
		}
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
