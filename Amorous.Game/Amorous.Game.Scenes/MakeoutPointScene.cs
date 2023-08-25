using Microsoft.Xna.Framework.Graphics;

namespace Amorous.Game.Scenes;

public class MakeoutPointScene : TimeOfDayScene
{
	private readonly SpriteLayer backgroundOfDay;
	private readonly SpriteLayer backgroundOfNight;

	public MakeoutPointScene(IAmorous game) : base(game)
	{
		backgroundOfDay = AddSpriteLayer("Background", "Assets/Scenes/MakeoutPoint/Makeout Point (Day)", 0, 0);
		backgroundOfNight = AddSpriteLayer("Background", "Assets/Scenes/MakeoutPoint/Makeout Point (Night)", 0, 0);
		FadingMediaPlayer.PlayOnRepeat(AmorousData.SimulateTrack, 0.4f);
	}

	public override void SwitchToSubscene(string daytime)
	{
		base.SwitchToSubscene(daytime);
		if (daytime == VARIANT_NIGHT)
		{
			backgroundOfNight.Color.A = byte.MaxValue;
			backgroundOfDay.Color.A = 0;
		}
		else
		{
			backgroundOfNight.Color.A = 0;
			backgroundOfDay.Color.A = byte.MaxValue;
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
