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

	public override void Start()
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
				Clocks.Date = TimeOfDay.Sunset;
				break;
			case VariantDay:
				Clocks.InRealTime = false;
				Clocks.Date = TimeOfDay.Day;
				break;
			case VariantMorning:
				Clocks.InRealTime = false;
				Clocks.Date = TimeOfDay.Morning;
				break;
			case VariantNight:
				Clocks.InRealTime = false;
				Clocks.Date = TimeOfDay.Night;
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
		_fader.Draw(spriteBatch, base.Game.Canvas);
		base.DrawOverlay(spriteBatch);
	}
}
