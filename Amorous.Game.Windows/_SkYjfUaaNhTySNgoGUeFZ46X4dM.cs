using Microsoft.Xna.Framework;

public class _SkYjfUaaNhTySNgoGUeFZ46X4dM : Game
{
	private readonly _JbeCmOie0phb2cbgG6DdGZrbs3pB _4L7hfXrWoDdArQiscG4ukHCV46B;

	public _SkYjfUaaNhTySNgoGUeFZ46X4dM(bool bool_0)
	{
		_SkYjfUaaNhTySNgoGUeFZ46X4dM.smethod_2(_SkYjfUaaNhTySNgoGUeFZ46X4dM.smethod_0((Game)(object)this), _SkYjfUaaNhTySNgoGUeFZ46X4dM.smethod_1("Amorous v{0} (Windows)", (object)"1.0.4"));
		_4L7hfXrWoDdArQiscG4ukHCV46B = _SkYjfUaaNhTySNgoGUeFZ46X4dM.smethod_3((Game)(object)this, bool_0);
	}

	protected override void _oD87G7SXjsTukw7IVWxVlVFEgvA()
	{
		_SkYjfUaaNhTySNgoGUeFZ46X4dM.smethod_4(_4L7hfXrWoDdArQiscG4ukHCV46B);
		((Game)this).Initialize();
	}

	protected override void _eW1Nkl8VqFHVExM8l3IqxgSbMBg()
	{
		_SkYjfUaaNhTySNgoGUeFZ46X4dM.smethod_5(_4L7hfXrWoDdArQiscG4ukHCV46B);
		((Game)this).LoadContent();
	}

	protected override void _wm1aB8mBRRffPWUAA0o5Xar2w5p()
	{
		_SkYjfUaaNhTySNgoGUeFZ46X4dM.smethod_6(_4L7hfXrWoDdArQiscG4ukHCV46B);
		((Game)this).UnloadContent();
	}

	protected override void _tiBFUHPEkedkbgvuX3whdeyjhKo(GameTime gameTime)
	{
		if (_SkYjfUaaNhTySNgoGUeFZ46X4dM.smethod_7((Game)(object)this))
		{
			goto IL_0025;
		}
		goto IL_004b;
		IL_004b:
		((Game)this).Update(gameTime);
		int num = 316602297;
		goto IL_002a;
		IL_002a:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x1546E317u) % 4u)
			{
			case 3u:
				_SkYjfUaaNhTySNgoGUeFZ46X4dM.smethod_8(_4L7hfXrWoDdArQiscG4ukHCV46B, gameTime);
				num = ((int)num2 * -760663183) ^ -381018719;
				continue;
			case 0u:
				break;
			default:
				return;
			case 1u:
				goto IL_004b;
			case 2u:
				return;
			}
			break;
		}
		goto IL_0025;
		IL_0025:
		num = 1540256912;
		goto IL_002a;
	}

	protected override void _f5ctqAmdNsZ889UjM4LxDm8WGxA(GameTime gameTime)
	{
		_SkYjfUaaNhTySNgoGUeFZ46X4dM.smethod_9(_4L7hfXrWoDdArQiscG4ukHCV46B, gameTime);
		while (true)
		{
			int num = -804524134;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBA1FDAC3u) % 3u)
				{
				case 1u:
					goto IL_000e;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_000e:
				((Game)this).Draw(gameTime);
				num = (int)((num2 * 1651025806) ^ 0x488863A6);
			}
		}
	}

	static GameWindow smethod_0(Game game_0)
	{
		return game_0.get_Window();
	}

	static string smethod_1(string string_0, object object_0)
	{
		return string.Format(string_0, object_0);
	}

	static void smethod_2(GameWindow gameWindow_0, string string_0)
	{
		gameWindow_0.set_Title(string_0);
	}

	static _bj8iyyk84DtxcxcHgAHHFGgq8oN smethod_3(Game game_0, bool bool_0)
	{
		return new _bj8iyyk84DtxcxcHgAHHFGgq8oN(game_0, bool_0);
	}

	static void smethod_4(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		_JbeCmOie0phb2cbgG6DdGZrbs3pB_0._oD87G7SXjsTukw7IVWxVlVFEgvA();
	}

	static void smethod_5(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		_JbeCmOie0phb2cbgG6DdGZrbs3pB_0._eW1Nkl8VqFHVExM8l3IqxgSbMBg();
	}

	static void smethod_6(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		_JbeCmOie0phb2cbgG6DdGZrbs3pB_0._wm1aB8mBRRffPWUAA0o5Xar2w5p();
	}

	static bool smethod_7(Game game_0)
	{
		return game_0.get_IsActive();
	}

	static void smethod_8(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0, GameTime gameTime_0)
	{
		_JbeCmOie0phb2cbgG6DdGZrbs3pB_0._tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime_0);
	}

	static void smethod_9(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0, GameTime gameTime_0)
	{
		_JbeCmOie0phb2cbgG6DdGZrbs3pB_0._f5ctqAmdNsZ889UjM4LxDm8WGxA(gameTime_0);
	}
}
