namespace Amorous.Game.Scenes;

public class HikingTrailScene : AbstractScene
{
	public const string VariantNight = "Night";
	public const string VariantDay = "Day";

	private readonly SpriteLayer _4Hew2VldDt2hPLjc5fBPbqIVUEQ;
	private readonly SpriteLayer _bYgAJ7foDqpxOElDOYhOkQFMzrz;

	public HikingTrailScene(IAmorous game)
		: base(game)
	{
		_4Hew2VldDt2hPLjc5fBPbqIVUEQ = AddSpriteLayer("Background", "Assets/Scenes/HikingTrail/Background Day", 0, 0);
		_bYgAJ7foDqpxOElDOYhOkQFMzrz = AddSpriteLayer("Background", "Assets/Scenes/HikingTrail/Background Night", 0, 0);
		SwitchToSubscene(VariantDay);
		FadingMediaPlayer.PlayOnRepeat(AmorousData.SimulateTrack, 0.4f);
	}

	public override void SwitchToSubscene(string daytime)
	{
		base.SwitchToSubscene(daytime);
		if (!(daytime == VariantNight))
		{
			_bYgAJ7foDqpxOElDOYhOkQFMzrz.Color.A = 0;
			_4Hew2VldDt2hPLjc5fBPbqIVUEQ.Color.A = byte.MaxValue;
		}
		else
		{
			_bYgAJ7foDqpxOElDOYhOkQFMzrz.Color.A = byte.MaxValue;
			_4Hew2VldDt2hPLjc5fBPbqIVUEQ.Color.A = 0;
		}
	}
}
