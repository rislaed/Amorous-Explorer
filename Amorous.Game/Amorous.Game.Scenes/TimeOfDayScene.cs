using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Amorous.Game.Scenes;

public abstract class TimeOfDayScene : AbstractScene
{
	protected const string VariantNight = "Night";
	protected const string VariantMorning = "Morning";
	protected const string VariantDay = "Day";
	protected const string VariantSunset = "Sunset";

	private readonly TimeOfDayFader _fader;

	protected TimeOfDayScene(IAmorous game)
		: base(game)
	{
		_fader = new TimeOfDayFader(game);
	}

	public override void Begin()
	{
		SwitchToSubscene(VariantDay);
	}

	public override void SwitchToSubscene(string daytime)
	{
		base.SwitchToSubscene(daytime);
		switch (daytime)
		{
			case VariantSunset:
				Clocks.InRealTime = false;
				Clocks.Time = TimeOfDay.Sunset;
				break;
			case VariantDay:
				Clocks.InRealTime = false;
				Clocks.Time = TimeOfDay.Day;
				break;
			case VariantMorning:
				Clocks.InRealTime = false;
				Clocks.Time = TimeOfDay.Morning;
				break;
			case VariantNight:
				Clocks.InRealTime = false;
				Clocks.Time = TimeOfDay.Night;
				break;
		}
	}

	public override void Update(GameTime gameTime)
	{
		_fader.Update(gameTime);
		base.Update(gameTime);
	}

	public override void DrawOverlay(SpriteBatch spriteBatch)
	{
		_fader.Draw(spriteBatch, base.Game.Mouse);
		base.DrawOverlay(spriteBatch);
	}
}
