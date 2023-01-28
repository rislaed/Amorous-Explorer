using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Amorous.Game.Scenes;

public abstract class TimeOfDayScene : AbstractScene
{
	protected const string VariantNight = "Night";
	protected const string VariantMorning = "Morning";
	protected const string VariantDay = "Day";
	protected const string VariantSunset = "Sunset";

	private readonly _G2GbwTTqXkVDMUL6fDmljsAPB4s _TyX29AlEBF2URt0abU6bc2VBQvm;

	protected TimeOfDayScene(IAmorous game)
		: base(game)
	{
		_TyX29AlEBF2URt0abU6bc2VBQvm = new _G2GbwTTqXkVDMUL6fDmljsAPB4s(game);
	}

	public override void Begin()
	{
		SetVariant(VariantDay);
	}

	public override void SetVariant(string daytime)
	{
		base.SetVariant(daytime);
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
		_TyX29AlEBF2URt0abU6bc2VBQvm.Update(gameTime);
		base.Update(gameTime);
	}

	public override void DrawOverlay(SpriteBatch spriteBatch)
	{
		_TyX29AlEBF2URt0abU6bc2VBQvm.Draw(spriteBatch, base.Game.Mouse);
		base.DrawOverlay(spriteBatch);
	}
}
