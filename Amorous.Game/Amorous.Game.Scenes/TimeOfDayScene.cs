using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Amorous.Game.Scenes;

public abstract class TimeOfDayScene : AbstractScene
{
	protected const string VARIANT_NIGHT = "Night";
	protected const string VARIANT_MORNING = "Morning";
	protected const string VARIANT_DAY = "Day";
	protected const string VARIANT_SUNSET = "Sunset";

	private readonly TimeOfDayFader fader;

	protected TimeOfDayScene(IAmorous game) : base(game)
	{
		fader = new TimeOfDayFader(game);
	}

	public override void Start()
	{
		SwitchToSubscene(VARIANT_DAY);
	}

	public override void SwitchToSubscene(string daytime)
	{
		base.SwitchToSubscene(daytime);
		switch (daytime)
		{
			case VARIANT_SUNSET:
				Clocks.InRealTime = false;
				Clocks.Date = TimeOfDay.Sunset;
				break;
			case VARIANT_DAY:
				Clocks.InRealTime = false;
				Clocks.Date = TimeOfDay.Day;
				break;
			case VARIANT_MORNING:
				Clocks.InRealTime = false;
				Clocks.Date = TimeOfDay.Morning;
				break;
			case VARIANT_NIGHT:
				Clocks.InRealTime = false;
				Clocks.Date = TimeOfDay.Night;
				break;
		}
	}

	public override void Update(GameTime gameTime)
	{
		fader.Update(gameTime);
		base.Update(gameTime);
	}

	public override void DrawOverlay(SpriteBatch spriteBatch)
	{
		fader.Draw(spriteBatch, base.Game.Canvas);
		base.DrawOverlay(spriteBatch);
	}
}
