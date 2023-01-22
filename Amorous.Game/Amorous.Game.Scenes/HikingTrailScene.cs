using Microsoft.Xna.Framework;

namespace Amorous.Game.Scenes;

public class HikingTrailScene : _7UlnfykmEmZDFt3BmCKZekI43Ih
{
	public const string _GVrFhyughFuZbNz1GllPUz8qFRC = "Night";

	public const string _3MHNjx9EVkIdQ2cErS7bp0bJSr8A = "Day";

	private readonly _uqydQVaCmCvK7zzWs5W4gZFpKBu _4Hew2VldDt2hPLjc5fBPbqIVUEQ;

	private readonly _uqydQVaCmCvK7zzWs5W4gZFpKBu _bYgAJ7foDqpxOElDOYhOkQFMzrz;

	public HikingTrailScene(_JbeCmOie0phb2cbgG6DdGZrbs3pB _JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
		: base(_JbeCmOie0phb2cbgG6DdGZrbs3pB_0)
	{
		while (true)
		{
			int num = -374025305;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC76D89F7u) % 6u)
				{
				case 4u:
					_4Hew2VldDt2hPLjc5fBPbqIVUEQ = HikingTrailScene.smethod_14((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Background", "Assets/Scenes/HikingTrail/Background Day", 0, 0);
					num = (int)(num2 * 905666896) ^ -392209372;
					continue;
				case 2u:
					HikingTrailScene.smethod_16("Assets/Music/DJ-ZEK - Simulate", 0.4f);
					num = (int)(num2 * 257362888) ^ -1979066064;
					continue;
				case 1u:
					_bYgAJ7foDqpxOElDOYhOkQFMzrz = HikingTrailScene.smethod_14((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Background", "Assets/Scenes/HikingTrail/Background Night", 0, 0);
					num = (int)((num2 * 1202077244) ^ 0x7CB3CDB7);
					continue;
				case 0u:
					HikingTrailScene.smethod_15((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Day");
					num = (int)(num2 * 1088807789) ^ -1725884999;
					continue;
				default:
					return;
				case 5u:
					break;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	public override void _6hE3geqxrB1vCirtSWHxIJjlTQB(string string_0)
	{
		this.method_0(string_0);
		while (true)
		{
			int num = 232579337;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF637A4Au) % 6u)
				{
				case 5u:
					((Color)(ref _bYgAJ7foDqpxOElDOYhOkQFMzrz._9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA)).set_A((byte)0);
					num = 1765514062;
					continue;
				case 4u:
					((Color)(ref _bYgAJ7foDqpxOElDOYhOkQFMzrz._9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA)).set_A(byte.MaxValue);
					num = (int)((num2 * 203699930) ^ 0x1D9A4F27);
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (!HikingTrailScene.smethod_17(string_0, "Night"))
					{
						num3 = 599511709;
						num4 = 599511709;
					}
					else
					{
						num3 = 607851072;
						num4 = 607851072;
					}
					num = num3 ^ (int)(num2 * 1517527596);
					continue;
				}
				case 0u:
					break;
				default:
					((Color)(ref _4Hew2VldDt2hPLjc5fBPbqIVUEQ._9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA)).set_A(byte.MaxValue);
					return;
				case 3u:
					((Color)(ref _4Hew2VldDt2hPLjc5fBPbqIVUEQ._9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA)).set_A((byte)0);
					return;
				}
				break;
			}
		}
	}

	static _uqydQVaCmCvK7zzWs5W4gZFpKBu smethod_14(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0, string string_0, string string_1, int int_0, int int_1)
	{
		return _7UlnfykmEmZDFt3BmCKZekI43Ih_0._0O8D0mBgmrh0sLOGcLVvGNOHKLCA(string_0, string_1, int_0, int_1);
	}

	static void smethod_15(_7UlnfykmEmZDFt3BmCKZekI43Ih _7UlnfykmEmZDFt3BmCKZekI43Ih_0, string string_0)
	{
		_7UlnfykmEmZDFt3BmCKZekI43Ih_0._6hE3geqxrB1vCirtSWHxIJjlTQB(string_0);
	}

	static void smethod_16(string string_0, float float_0)
	{
		_UmxbIbk7pgaod0bD7pS309P3Lns._l94kUraQ13OohoVwwxKC37hG7Pc(string_0, float_0);
	}

	void method_0(string string_0)
	{
		base._6hE3geqxrB1vCirtSWHxIJjlTQB(string_0);
	}

	static bool smethod_17(string string_0, string string_1)
	{
		return string_0 == string_1;
	}
}
