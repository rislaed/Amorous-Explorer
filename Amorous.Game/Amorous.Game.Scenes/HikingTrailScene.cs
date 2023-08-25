namespace Amorous.Game.Scenes;

public class HikingTrailScene : AbstractScene
{
	public const string VARIANT_NIGHT = "Night";
	public const string VARIANT_DAY = "Day";

	private readonly SpriteLayer backgroundOnDay;
	private readonly SpriteLayer backgroundOnNight;

	public HikingTrailScene(IAmorous game) : base(game)
	{
		backgroundOnDay = AddSpriteLayer("Background", "Assets/Scenes/HikingTrail/Background Day", 0, 0);
		backgroundOnNight = AddSpriteLayer("Background", "Assets/Scenes/HikingTrail/Background Night", 0, 0);
		SwitchToSubscene(VARIANT_DAY);
		FadingMediaPlayer.PlayOnRepeat(AmorousData.SimulateTrack, 0.4f);
	}

	public override void SwitchToSubscene(string daytime)
	{
		base.SwitchToSubscene(daytime);
		if (!(daytime == VARIANT_NIGHT))
		{
			backgroundOnNight.Color.A = 0;
			backgroundOnDay.Color.A = byte.MaxValue;
		}
		else
		{
			backgroundOnNight.Color.A = byte.MaxValue;
			backgroundOnDay.Color.A = 0;
		}
	}
}
