using Microsoft.Xna.Framework.Graphics;

namespace Amorous.Game.Scenes;

public class MakeoutPointScene : TimeOfDayScene
{
	private readonly SpriteLayer _4Hew2VldDt2hPLjc5fBPbqIVUEQ;

	private readonly SpriteLayer _bYgAJ7foDqpxOElDOYhOkQFMzrz;

	public MakeoutPointScene(IAmorous game)
		: base(game)
	{
		_4Hew2VldDt2hPLjc5fBPbqIVUEQ = AddSpriteLayer("Background", "Assets/Scenes/MakeoutPoint/Makeout Point (Day)", 0, 0);
		_bYgAJ7foDqpxOElDOYhOkQFMzrz = AddSpriteLayer("Background", "Assets/Scenes/MakeoutPoint/Makeout Point (Night)", 0, 0);
		FadingMediaPlayer.PlayOnRepeat(AmorousData.SimulateTrack, 0.4f);
	}

	public override void SwitchToSubscene(string daytime)
	{
		base.SwitchToSubscene(daytime);
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

	public override void DrawOverlay(SpriteBatch spriteBatch)
	{
		if (Clocks.Date != TimeOfDay.Night)
		{
			base.DrawOverlay(spriteBatch);
		}
	}
}
