using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Amorous.Game.Scenes;

public class MakeoutPointScene : TimeOfDayScene
{
	private readonly _uqydQVaCmCvK7zzWs5W4gZFpKBu _4Hew2VldDt2hPLjc5fBPbqIVUEQ;

	private readonly _uqydQVaCmCvK7zzWs5W4gZFpKBu _bYgAJ7foDqpxOElDOYhOkQFMzrz;

	public MakeoutPointScene(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		while (true)
		{
			int num = 1059814176;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6CD9281Bu) % 4u)
				{
				case 3u:
					_4Hew2VldDt2hPLjc5fBPbqIVUEQ = MakeoutPointScene.smethod_18((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, _003CModule_003E.smethod_27<string>(3171999506u), _003CModule_003E.smethod_28<string>(2960614770u), 0, 0);
					num = ((int)num2 * -2144539568) ^ 0x3F2DEDD6;
					continue;
				case 1u:
					_bYgAJ7foDqpxOElDOYhOkQFMzrz = MakeoutPointScene.smethod_18((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, _003CModule_003E.smethod_24<string>(1416131465u), _003CModule_003E.smethod_28<string>(984394951u), 0, 0);
					MakeoutPointScene.smethod_19(_003CModule_003E.smethod_24<string>(1742644995u), 0.4f);
					num = ((int)num2 * -1100710363) ^ -114680260;
					continue;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	public override void _6hE3geqxrB1vCirtSWHxIJjlTQB(string string_0)
	{
		base._6hE3geqxrB1vCirtSWHxIJjlTQB(string_0);
		if (MakeoutPointScene.smethod_20(string_0, _003CModule_003E.smethod_24<string>(2271948710u)))
		{
			goto IL_0063;
		}
		goto IL_0091;
		IL_0091:
		((Color)(ref _bYgAJ7foDqpxOElDOYhOkQFMzrz._9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA)).set_A((byte)0);
		int num = 252582205;
		goto IL_0068;
		IL_0068:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x585EBBFEu) % 6u)
			{
			case 5u:
				((Color)(ref _4Hew2VldDt2hPLjc5fBPbqIVUEQ._9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA)).set_A(byte.MaxValue);
				num = (int)((num2 * 1279944586) ^ 0x219A6231);
				continue;
			case 4u:
				((Color)(ref _bYgAJ7foDqpxOElDOYhOkQFMzrz._9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA)).set_A(byte.MaxValue);
				num = ((int)num2 * -1235448350) ^ 0x70E17945;
				continue;
			case 0u:
				break;
			default:
				return;
			case 2u:
				goto IL_0091;
			case 1u:
				return;
			case 3u:
				((Color)(ref _4Hew2VldDt2hPLjc5fBPbqIVUEQ._9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA)).set_A((byte)0);
				return;
			}
			break;
		}
		goto IL_0063;
		IL_0063:
		num = 544577936;
		goto IL_0068;
	}

	public override void _Z70nK2EA1n5FNJxjWP0TzHQ0Lzb(SpriteBatch spriteBatch_0)
	{
		if (_5Anqe6GAAkzemoAXYpJmgMlk1yz._rf41M6fa6MhAPBvvUvQseEZTt9Q == _RRECH42isVc35MkZPyLEGkp0hjs.Night)
		{
			return;
		}
		while (true)
		{
			int num = 1453940841;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x21ABF684u) % 3u)
				{
				case 1u:
					goto IL_000a;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_000a:
				base._Z70nK2EA1n5FNJxjWP0TzHQ0Lzb(spriteBatch_0);
				num = (int)(num2 * 1527724374) ^ -218955014;
			}
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
