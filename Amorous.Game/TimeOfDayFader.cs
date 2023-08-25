using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class TimeOfDayFader
{ // _G2GbwTTqXkVDMUL6fDmljsAPB4s
	private static readonly Color MORNING_COLOR = new Color(50, 45, 0, 50);
	private static readonly Color DAY_COLOR = new Color(0, 0, 0, 0);
	private static readonly Color SUNSET_COLOR = new Color(65, 15, 0, 50);
	private static readonly Color NIGHT_COLOR = new Color(20, 0, 90, 50);

	private readonly ScreenFader screenFader;
	private TimeOfDay? timeOfDay;

	public TimeOfDayFader(IAmorous game)
	{
		screenFader = new ScreenFader(game.Graphics);
	}

	public void Update(GameTime gameTime)
	{
		screenFader.Update(gameTime);
		UpdateInternal();
	}

	public void Draw(SpriteBatch spriteBatch, CanvasObserver canvas)
	{
		screenFader.Draw(spriteBatch, canvas);
	}

	private void UpdateInternal()
	{
		if (timeOfDay != Clocks.Date)
		{
			timeOfDay = Clocks.Date;
			switch (Clocks.Date)
			{
				default:
					screenFader.Apply(NIGHT_COLOR);
					break;
				case TimeOfDay.Morning:
					screenFader.Apply(MORNING_COLOR);
					break;
				case TimeOfDay.Day:
					screenFader.Apply(DAY_COLOR);
					break;
				case TimeOfDay.Sunset:
					screenFader.Apply(SUNSET_COLOR);
					break;
			}
		}
	}
}
