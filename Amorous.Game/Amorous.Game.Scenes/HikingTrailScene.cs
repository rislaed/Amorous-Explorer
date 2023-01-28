namespace Amorous.Game.Scenes;

public class HikingTrailScene : AbstractScene
{
	public const string VariantNight = "Night";
	public const string VariantDay = "Day";

	private readonly TexturedLayer _4Hew2VldDt2hPLjc5fBPbqIVUEQ;
	private readonly TexturedLayer _bYgAJ7foDqpxOElDOYhOkQFMzrz;

	public HikingTrailScene(IAmorous game)
		: base(game)
	{
		_4Hew2VldDt2hPLjc5fBPbqIVUEQ = AddTexturedLayer("Background", "Assets/Scenes/HikingTrail/Background Day", 0, 0);
		_bYgAJ7foDqpxOElDOYhOkQFMzrz = AddTexturedLayer("Background", "Assets/Scenes/HikingTrail/Background Night", 0, 0);
		SetVariant(VariantDay);
		FadingMediaPlayer._l94kUraQ13OohoVwwxKC37hG7Pc("Assets/Music/DJ-ZEK - Simulate", 0.4f);
	}

	public override void SetVariant(string daytime)
	{
		base.SetVariant(daytime);
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
