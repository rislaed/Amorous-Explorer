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
		_4Hew2VldDt2hPLjc5fBPbqIVUEQ = _0O8D0mBgmrh0sLOGcLVvGNOHKLCA("Background", "Assets/Scenes/HikingTrail/Background Day", 0, 0);
		_bYgAJ7foDqpxOElDOYhOkQFMzrz = _0O8D0mBgmrh0sLOGcLVvGNOHKLCA("Background", "Assets/Scenes/HikingTrail/Background Night", 0, 0);
		_6hE3geqxrB1vCirtSWHxIJjlTQB("Day");
		_UmxbIbk7pgaod0bD7pS309P3Lns._l94kUraQ13OohoVwwxKC37hG7Pc("Assets/Music/DJ-ZEK - Simulate", 0.4f);
	}

	public override void _6hE3geqxrB1vCirtSWHxIJjlTQB(string string_0)
	{
		base._6hE3geqxrB1vCirtSWHxIJjlTQB(string_0);
		if (!(string_0 == "Night"))
		{
			_bYgAJ7foDqpxOElDOYhOkQFMzrz._9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA.A = 0;
			_4Hew2VldDt2hPLjc5fBPbqIVUEQ._9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA.A = byte.MaxValue;
		}
		else
		{
			_bYgAJ7foDqpxOElDOYhOkQFMzrz._9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA.A = byte.MaxValue;
			_4Hew2VldDt2hPLjc5fBPbqIVUEQ._9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA.A = 0;
		}
	}
}
