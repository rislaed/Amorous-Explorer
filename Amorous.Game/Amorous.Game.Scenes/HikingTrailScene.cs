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
		_4Hew2VldDt2hPLjc5fBPbqIVUEQ = HikingTrailScene.smethod_14((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Background", "Assets/Scenes/HikingTrail/Background Day", 0, 0);
		_bYgAJ7foDqpxOElDOYhOkQFMzrz = HikingTrailScene.smethod_14((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Background", "Assets/Scenes/HikingTrail/Background Night", 0, 0);
		HikingTrailScene.smethod_15((_7UlnfykmEmZDFt3BmCKZekI43Ih)this, "Day");
		HikingTrailScene.smethod_16("Assets/Music/DJ-ZEK - Simulate", 0.4f);
	}

	public override void _6hE3geqxrB1vCirtSWHxIJjlTQB(string string_0)
	{
		this.method_0(string_0);
		if (!HikingTrailScene.smethod_17(string_0, "Night"))
		{
			((Color)(ref _bYgAJ7foDqpxOElDOYhOkQFMzrz._9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA)).set_A((byte)0);
			((Color)(ref _4Hew2VldDt2hPLjc5fBPbqIVUEQ._9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA)).set_A(byte.MaxValue);
		}
		else
		{
			((Color)(ref _bYgAJ7foDqpxOElDOYhOkQFMzrz._9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA)).set_A(byte.MaxValue);
			((Color)(ref _4Hew2VldDt2hPLjc5fBPbqIVUEQ._9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA)).set_A((byte)0);
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
