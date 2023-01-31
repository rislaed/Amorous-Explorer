using Microsoft.Xna.Framework;

public class AmorousGame : Game
{ // _SkYjfUaaNhTySNgoGUeFZ46X4dM
	private readonly IAmorous _game;

	public AmorousGame(bool safemode)
	{
		base.Window.Title = string.Format("Amorous v{0} (Windows)", AmorousData.Version);
		_game = new AmorousSingleton(this, safemode);
	}

	protected override void Initialize()
	{
		_game.Initialize();
		base.Initialize();
	}

	protected override void LoadContent()
	{
		_game.LoadContent();
		base.LoadContent();
	}

	protected override void UnloadContent()
	{
		_game.UnloadContent();
		base.UnloadContent();
	}

	protected override void Update(GameTime gameTime)
	{
		if (base.IsActive)
		{
			_game.Update(gameTime);
		}
		base.Update(gameTime);
	}

	protected override void Draw(GameTime gameTime)
	{
		_game.Draw(gameTime);
		base.Draw(gameTime);
	}
}
