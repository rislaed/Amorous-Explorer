using Microsoft.Xna.Framework.Graphics;

namespace Amorous.Game.Scenes;

public class MakeoutPointScene : TimeOfDayScene
{
	private readonly SpriteLayer _backgroundDay;
	private readonly SpriteLayer _backgroundNight;

	public MakeoutPointScene(IAmorous game)
		: base(game)
	{
		_backgroundDay = AddSpriteLayer("Background", "Assets/Scenes/MakeoutPoint/Makeout Point (Day)", 0, 0);
		_backgroundNight = AddSpriteLayer("Background", "Assets/Scenes/MakeoutPoint/Makeout Point (Night)", 0, 0);
		FadingMediaPlayer.PlayOnRepeat(AmorousData.SimulateTrack, 0.4f);
	}

	public override void SwitchToSubscene(string daytime)
	{
		base.SwitchToSubscene(daytime);
		if (daytime == VariantNight)
		{
			_backgroundNight.Color.A = byte.MaxValue;
			_backgroundDay.Color.A = 0;
		}
		else
		{
			_backgroundNight.Color.A = 0;
			_backgroundDay.Color.A = byte.MaxValue;
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
