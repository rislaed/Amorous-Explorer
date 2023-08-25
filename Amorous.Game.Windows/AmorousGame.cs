using Microsoft.Xna.Framework;

public class AmorousGame : Game
{ // _SkYjfUaaNhTySNgoGUeFZ46X4dM
	private readonly IAmorous singleton;

	public AmorousGame(bool safemode)
	{
		base.Window.Title = string.Format("Amorous v{0} (Windows)", AmorousData.Version);
		singleton = new AmorousSingleton(this, safemode);
	}

	protected override void Initialize()
	{
		singleton.Initialize();
		base.Initialize();
	}

	protected override void LoadContent()
	{
		singleton.LoadContent();
		base.LoadContent();
	}

	protected override void UnloadContent()
	{
		singleton.UnloadContent();
		base.UnloadContent();
	}

	protected override void Update(GameTime gameTime)
	{
		if (base.IsActive)
		{
			singleton.Update(gameTime);
		}
		base.Update(gameTime);
	}

	protected override void Draw(GameTime gameTime)
	{
		singleton.Draw(gameTime);
		base.Draw(gameTime);
	}
}
