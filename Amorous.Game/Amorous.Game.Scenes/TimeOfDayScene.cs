using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Amorous.Game.Scenes;

public abstract class TimeOfDayScene : AbstractScene
{
	protected const string _GVrFhyughFuZbNz1GllPUz8qFRC = "Night";

	protected const string _CKUkfACCW7C1UVsHBKFoeiulzIh = "Morning";

	protected const string _3MHNjx9EVkIdQ2cErS7bp0bJSr8A = "Day";

	protected const string _RS0gzIMaA8RvbsLb5OBhWAI8orc = "Sunset";

	private readonly _G2GbwTTqXkVDMUL6fDmljsAPB4s _TyX29AlEBF2URt0abU6bc2VBQvm;

	protected TimeOfDayScene(IAmorous game)
		: base(Game)
	{
		_TyX29AlEBF2URt0abU6bc2VBQvm = new _G2GbwTTqXkVDMUL6fDmljsAPB4s(Game);
	}

	public override void _4hlxzMzKSbVTbZUrEsP3dfw4x0h()
	{
		_6hE3geqxrB1vCirtSWHxIJjlTQB("Day");
	}

	public override void _6hE3geqxrB1vCirtSWHxIJjlTQB(string string_0)
	{
		base._6hE3geqxrB1vCirtSWHxIJjlTQB(string_0);
		switch (string_0)
		{
		case "Sunset":
			_5Anqe6GAAkzemoAXYpJmgMlk1yz._3DInasj5B11bCcV5BIRvLE1Ay7w = false;
			_5Anqe6GAAkzemoAXYpJmgMlk1yz.time = TimeOfDay.Sunset;
			break;
		case "Day":
			_5Anqe6GAAkzemoAXYpJmgMlk1yz._3DInasj5B11bCcV5BIRvLE1Ay7w = false;
			_5Anqe6GAAkzemoAXYpJmgMlk1yz.time = TimeOfDay.Day;
			break;
		case "Morning":
			_5Anqe6GAAkzemoAXYpJmgMlk1yz._3DInasj5B11bCcV5BIRvLE1Ay7w = false;
			_5Anqe6GAAkzemoAXYpJmgMlk1yz.time = TimeOfDay.Morning;
			break;
		case "Night":
			_5Anqe6GAAkzemoAXYpJmgMlk1yz._3DInasj5B11bCcV5BIRvLE1Ay7w = false;
			_5Anqe6GAAkzemoAXYpJmgMlk1yz.time = TimeOfDay.Night;
			break;
		}
	}

	public override void Update(GameTime gameTime_0)
	{
		_TyX29AlEBF2URt0abU6bc2VBQvm.Update(gameTime_0);
		base.Update(gameTime_0);
	}

	public override void Render(SpriteBatch spriteBatch_0)
	{
		_TyX29AlEBF2URt0abU6bc2VBQvm.Draw(spriteBatch_0, base.Game._vsceSzSIjBy2nZrCxAzKZbUiwLq);
		base.Render(spriteBatch_0);
	}
}
