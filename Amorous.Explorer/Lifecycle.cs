using System;
using System.Globalization;
using System.Linq;
using System.Threading;
using Microsoft.Xna.Framework;

namespace Amorous.Explorer;

public static class Lifecycle
{
	[STAThread]
	public static void Main(string[] args)
	{
		AppDomain.CurrentDomain.UnhandledException += delegate(object sender, UnhandledExceptionEventArgs e)
		{
			Logger.Error((e.ExceptionObject as Exception).ToString());
			Environment.Exit(1);
		};
		Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
		Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
		Logger.Initialize();
		DllMap.Initialize();
		FNALoggerEXT.LogInfo = delegate(string message)
		{
			Logger.Log(message);
		};
		FNALoggerEXT.LogWarn = delegate(string message)
		{
			Logger.Warning(message);
		};
		FNALoggerEXT.LogError = delegate(string message)
		{
			Logger.Error(message);
		};
		Environment.SetEnvironmentVariable("FNA_OPENGL_DISABLE_LATESWAPTEAR", "1");
		bool safemode = args.Contains("-safemode");
		if (args.Contains("-disablesound"))
		{
			Environment.SetEnvironmentVariable("FNA_AUDIO_DISABLE_SOUND", "1");
		}
		if (args.Contains("-d3d11"))
		{
			Environment.SetEnvironmentVariable("FNA_OPENGL_FORCE_ES3", "1");
			Environment.SetEnvironmentVariable("SDL_OPENGL_ES_DRIVER", "1");
		}
		using XnaGame game = new XnaGame(safemode);
		game.Run();
	}
}

internal class XnaGame : Microsoft.Xna.Framework.Game
{
	private readonly IExplorer explorer;

	public XnaGame(bool safemode)
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
