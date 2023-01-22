using Microsoft.Xna.Framework.Graphics;

namespace Amorous.Game.Scenes;

public class MakeoutPointScene : TimeOfDayScene
{
	private readonly _uqydQVaCmCvK7zzWs5W4gZFpKBu _4Hew2VldDt2hPLjc5fBPbqIVUEQ;

	private readonly _uqydQVaCmCvK7zzWs5W4gZFpKBu _bYgAJ7foDqpxOElDOYhOkQFMzrz;

	public MakeoutPointScene(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		_4Hew2VldDt2hPLjc5fBPbqIVUEQ = _0O8D0mBgmrh0sLOGcLVvGNOHKLCA("Background", "Assets/Scenes/MakeoutPoint/Makeout Point (Day)", 0, 0);
		_bYgAJ7foDqpxOElDOYhOkQFMzrz = _0O8D0mBgmrh0sLOGcLVvGNOHKLCA("Background", "Assets/Scenes/MakeoutPoint/Makeout Point (Night)", 0, 0);
		_UmxbIbk7pgaod0bD7pS309P3Lns._l94kUraQ13OohoVwwxKC37hG7Pc("Assets/Music/DJ-ZEK - Simulate", 0.4f);
	}

	public override void _6hE3geqxrB1vCirtSWHxIJjlTQB(string string_0)
	{
		base._6hE3geqxrB1vCirtSWHxIJjlTQB(string_0);
		if (string_0 == "Night")
		{
			_bYgAJ7foDqpxOElDOYhOkQFMzrz._9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA.A = byte.MaxValue;
			_4Hew2VldDt2hPLjc5fBPbqIVUEQ._9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA.A = 0;
		}
		else
		{
			_bYgAJ7foDqpxOElDOYhOkQFMzrz._9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA.A = 0;
			_4Hew2VldDt2hPLjc5fBPbqIVUEQ._9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA.A = byte.MaxValue;
		}
	}

	public override void _Z70nK2EA1n5FNJxjWP0TzHQ0Lzb(SpriteBatch spriteBatch_0)
	{
		if (_5Anqe6GAAkzemoAXYpJmgMlk1yz._rf41M6fa6MhAPBvvUvQseEZTt9Q != _RRECH42isVc35MkZPyLEGkp0hjs.Night)
		{
			base._Z70nK2EA1n5FNJxjWP0TzHQ0Lzb(spriteBatch_0);
		}
	}

	static _uqydQVaCmCvK7zzWs5W4gZFpKBu smethod_18(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0, string string_0, string string_1, int int_0, int int_1)
	{
		return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._0O8D0mBgmrh0sLOGcLVvGNOHKLCA(string_0, string_1, int_0, int_1);
	}

	static void smethod_19(string string_0, float float_0)
	{
		_UmxbIbk7pgaod0bD7pS309P3Lns._l94kUraQ13OohoVwwxKC37hG7Pc(string_0, float_0);
	}

	static bool smethod_20(string string_0, string string_1)
	{
		return string_0 == string_1;
	}
}
