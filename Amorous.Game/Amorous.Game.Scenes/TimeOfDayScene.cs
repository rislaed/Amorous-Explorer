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

	public override void StopCutscene()
	{
		SetVariant(VariantDay);
	}

	public override void SetVariant(string daytime)
	{
		base.SetVariant(daytime);
		switch (daytime)
		{
			case VariantSunset:
				_5Anqe6GAAkzemoAXYpJmgMlk1yz._3DInasj5B11bCcV5BIRvLE1Ay7w = false;
				_5Anqe6GAAkzemoAXYpJmgMlk1yz.time = TimeOfDay.Sunset;
				break;
			case VariantDay:
				_5Anqe6GAAkzemoAXYpJmgMlk1yz._3DInasj5B11bCcV5BIRvLE1Ay7w = false;
				_5Anqe6GAAkzemoAXYpJmgMlk1yz.time = TimeOfDay.Day;
				break;
			case VariantMorning:
				_5Anqe6GAAkzemoAXYpJmgMlk1yz._3DInasj5B11bCcV5BIRvLE1Ay7w = false;
				_5Anqe6GAAkzemoAXYpJmgMlk1yz.time = TimeOfDay.Morning;
				break;
			case VariantNight:
				_5Anqe6GAAkzemoAXYpJmgMlk1yz._3DInasj5B11bCcV5BIRvLE1Ay7w = false;
				_5Anqe6GAAkzemoAXYpJmgMlk1yz.time = TimeOfDay.Night;
				break;
		}
	}

	public override void Update(GameTime gameTime)
	{
		_TyX29AlEBF2URt0abU6bc2VBQvm.Update(gameTime);
		base.Update(gameTime);
	}

	public override void Render(SpriteBatch spriteBatch)
	{
		_TyX29AlEBF2URt0abU6bc2VBQvm.Draw(spriteBatch, base.Game._vsceSzSIjBy2nZrCxAzKZbUiwLq);
		base.Render(spriteBatch);
	}
}
