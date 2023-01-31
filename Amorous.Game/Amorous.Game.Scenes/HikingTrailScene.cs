namespace Amorous.Game.Scenes;

public class HikingTrailScene : AbstractScene
{
	public const string VariantNight = "Night";
	public const string VariantDay = "Day";

	private readonly SpriteLayer _backgroundDay;
	private readonly SpriteLayer _backgroundNight;

	public HikingTrailScene(IAmorous game)
		: base(game)
	{
		_backgroundDay = AddSpriteLayer("Background", "Assets/Scenes/HikingTrail/Background Day", 0, 0);
		_backgroundNight = AddSpriteLayer("Background", "Assets/Scenes/HikingTrail/Background Night", 0, 0);
		SwitchToSubscene(VariantDay);
		FadingMediaPlayer.PlayOnRepeat(AmorousData.SimulateTrack, 0.4f);
	}

	public override void SwitchToSubscene(string daytime)
	{
		base.SwitchToSubscene(daytime);
		if (!(daytime == VariantNight))
		{
			_backgroundNight.Color.A = 0;
			_backgroundDay.Color.A = byte.MaxValue;
		}
		else
		{
			_backgroundNight.Color.A = byte.MaxValue;
			_backgroundDay.Color.A = 0;
		}
	}
}
