using Microsoft.Xna.Framework;

public class _SkYjfUaaNhTySNgoGUeFZ46X4dM : Game
{
	private readonly _JbeCmOie0phb2cbgG6DdGZrbs3pB _4L7hfXrWoDdArQiscG4ukHCV46B;

	public _SkYjfUaaNhTySNgoGUeFZ46X4dM(bool bool_0)
	{
		((Game)this).get_Window().set_Title(string.Format("Amorous v{0} (Windows)", "1.0.4"));
		_4L7hfXrWoDdArQiscG4ukHCV46B = new _bj8iyyk84DtxcxcHgAHHFGgq8oN((Game)(object)this, bool_0);
	}

	protected override void _oD87G7SXjsTukw7IVWxVlVFEgvA()
	{
		_4L7hfXrWoDdArQiscG4ukHCV46B._oD87G7SXjsTukw7IVWxVlVFEgvA();
		((Game)this).Initialize();
	}

	protected override void _eW1Nkl8VqFHVExM8l3IqxgSbMBg()
	{
		_4L7hfXrWoDdArQiscG4ukHCV46B._eW1Nkl8VqFHVExM8l3IqxgSbMBg();
		((Game)this).LoadContent();
	}

	protected override void _wm1aB8mBRRffPWUAA0o5Xar2w5p()
	{
		_4L7hfXrWoDdArQiscG4ukHCV46B._wm1aB8mBRRffPWUAA0o5Xar2w5p();
		((Game)this).UnloadContent();
	}

	protected override void _tiBFUHPEkedkbgvuX3whdeyjhKo(GameTime gameTime)
	{
		if (((Game)this).get_IsActive())
		{
			_4L7hfXrWoDdArQiscG4ukHCV46B._tiBFUHPEkedkbgvuX3whdeyjhKo(gameTime);
		}
		((Game)this).Update(gameTime);
	}

	protected override void _f5ctqAmdNsZ889UjM4LxDm8WGxA(GameTime gameTime)
	{
		_4L7hfXrWoDdArQiscG4ukHCV46B._f5ctqAmdNsZ889UjM4LxDm8WGxA(gameTime);
		((Game)this).Draw(gameTime);
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
