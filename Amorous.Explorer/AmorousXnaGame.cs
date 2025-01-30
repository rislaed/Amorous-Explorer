using System;
using Microsoft.Xna.Framework;

namespace Amorous.Explorer;

public class AmorousXnaGame : Microsoft.Xna.Framework.Game
{
	private readonly IExplorer explorer;

	public AmorousXnaGame(bool safemode)
	{
		base.Window.Title = string.Format("Amorous Explorer v{0}", AmorousData.Version);
		explorer = new AmorousExplorer(this, safemode);
	}

	protected override void Initialize()
	{
		explorer.Initialize();
		base.Initialize();
	}

	protected override void LoadContent()
	{
		explorer.LoadContent();
		base.LoadContent();
	}

	protected override void UnloadContent()
	{
		explorer.UnloadContent();
		base.UnloadContent();
	}

	protected override void Update(GameTime gameTime)
	{
		try
		{
			if (base.IsActive)
			{
				explorer.Update(gameTime);
			}
		}
		catch (Exception exception)
		{
			Logger.Error(exception.ToString());
			explorer.Catch(exception, () => Refresh(gameTime));
		}
		base.Update(gameTime);
	}

	protected override void Draw(GameTime gameTime)
	{
		try
		{
			explorer.Draw(gameTime);
		}
		catch (Exception exception)
		{
			Logger.Error(exception.ToString());
			explorer.Catch(exception, () => Refresh(gameTime));
		}
		base.Draw(gameTime);
	}

	protected virtual void Refresh(GameTime gameTime)
	{
		if (base.IsActive)
		{
			explorer.Update(gameTime);
		}
		explorer.Draw(gameTime);
	}
}
