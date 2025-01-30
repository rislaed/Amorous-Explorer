using System;
using System.Globalization;
using System.Linq;
using System.Threading;
using Microsoft.Xna.Framework;

namespace Amorous.Explorer.Windows;

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
		using AmorousXnaGame game = new (safemode);
		game.Run();
	}
}
