using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class TimeOfDayFader
{ // _G2GbwTTqXkVDMUL6fDmljsAPB4s
	private static readonly Color MorningColor = new Color(50, 45, 0, 50);
	private static readonly Color DayColor = new Color(0, 0, 0, 0);
	private static readonly Color SunsetColor = new Color(65, 15, 0, 50);
	private static readonly Color NightColor = new Color(20, 0, 90, 50);

	private readonly ScreenFader _fader;
	private TimeOfDay? _time;

	public TimeOfDayFader(IAmorous game)
	{
		_fader = new ScreenFader(game.GLES);
	}

	public void Update(GameTime gameTime)
	{
		_fader.Update(gameTime);
		UpdateTime();
	}

	public void Draw(SpriteBatch spriteBatch, CanvasObserver mouse)
	{
		_fader.Draw(spriteBatch, mouse);
	}

	private void UpdateTime()
	{
		if (_time != Clocks.Date)
		{
			_time = Clocks.Date;
			switch (Clocks.Date)
			{
				default:
					_fader.Apply(NightColor);
					break;
				case TimeOfDay.Morning:
					_fader.Apply(MorningColor);
					break;
				case TimeOfDay.Day:
					_fader.Apply(DayColor);
					break;
				case TimeOfDay.Sunset:
					_fader.Apply(SunsetColor);
					break;
			}
		}
	}
}
