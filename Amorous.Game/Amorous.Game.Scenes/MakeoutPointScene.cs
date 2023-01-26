using Microsoft.Xna.Framework.Graphics;

namespace Amorous.Game.Scenes;

public class MakeoutPointScene : TimeOfDayScene
{
	private readonly TexturedLayer _4Hew2VldDt2hPLjc5fBPbqIVUEQ;

	private readonly TexturedLayer _bYgAJ7foDqpxOElDOYhOkQFMzrz;

	public MakeoutPointScene(IAmorous game)
		: base(game)
	{
		_4Hew2VldDt2hPLjc5fBPbqIVUEQ = AddTexturedLayer("Background", "Assets/Scenes/MakeoutPoint/Makeout Point (Day)", 0, 0);
		_bYgAJ7foDqpxOElDOYhOkQFMzrz = AddTexturedLayer("Background", "Assets/Scenes/MakeoutPoint/Makeout Point (Night)", 0, 0);
		_UmxbIbk7pgaod0bD7pS309P3Lns._l94kUraQ13OohoVwwxKC37hG7Pc("Assets/Music/DJ-ZEK - Simulate", 0.4f);
	}

	public override void SetVariant(string daytime)
	{
		base.SetVariant(daytime);
		if (daytime == VariantNight)
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

	public override void Render(SpriteBatch spriteBatch)
	{
		if (_5Anqe6GAAkzemoAXYpJmgMlk1yz.time != TimeOfDay.Night)
		{
			base.Render(spriteBatch);
		}
	}
}
