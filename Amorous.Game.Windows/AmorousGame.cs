using Microsoft.Xna.Framework;

public class AmorousGame : Game
{
	private readonly IAmorous Amorous;

	public AmorousGame(bool safemode)
	{
		base.Window.Title = string.Format("Amorous v{0} (Windows)", "1.0.4");
		Amorous = new AmorousSingleton(this, safemode);
	}

	protected override void Initialize()
	{
		Amorous.Initialize();
		base.Initialize();
	}

	protected override void LoadContent()
	{
		Amorous.LoadContent();
		base.LoadContent();
	}

	protected override void UnloadContent()
	{
		Amorous.UnloadContent();
		base.UnloadContent();
	}

	protected override void Update(GameTime gameTime)
	{
		if (base.IsActive)
		{
			Amorous.Update(gameTime);
		}
		base.Update(gameTime);
	}

	protected override void Draw(GameTime gameTime)
	{
		Amorous.Draw(gameTime);
		base.Draw(gameTime);
	}
}
