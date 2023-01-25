using Microsoft.Xna.Framework.Graphics;

namespace Amorous.Game.Scenes;

public class MakeoutPointScene : TimeOfDayScene
{
	private readonly _uqydQVaCmCvK7zzWs5W4gZFpKBu _4Hew2VldDt2hPLjc5fBPbqIVUEQ;

	private readonly _uqydQVaCmCvK7zzWs5W4gZFpKBu _bYgAJ7foDqpxOElDOYhOkQFMzrz;

	public MakeoutPointScene(IAmorous game)
		: base(Game)
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
			_bYgAJ7foDqpxOElDOYhOkQFMzrz.Color.A = byte.MaxValue;
			_4Hew2VldDt2hPLjc5fBPbqIVUEQ.Color.A = 0;
		}
		else
		{
			_bYgAJ7foDqpxOElDOYhOkQFMzrz.Color.A = 0;
			_4Hew2VldDt2hPLjc5fBPbqIVUEQ.Color.A = byte.MaxValue;
		}
	}

	public override void Render(SpriteBatch spriteBatch_0)
	{
		if (_5Anqe6GAAkzemoAXYpJmgMlk1yz.time != TimeOfDay.Night)
		{
			base.Render(spriteBatch_0);
		}
	}
}
