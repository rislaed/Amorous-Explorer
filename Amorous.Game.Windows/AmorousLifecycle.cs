using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.Xna.Framework;

public static class AmorousLifecycle
{
	private const int AppDomainLibraries = 4096;

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool SetDefaultDllDirectories(int mode);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	private static extern void AddDllDirectory(string path);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool SetDllDirectory(string path);

	public static bool IsUnix => (int) Environment.OSVersion.Platform is 4 or 6 or 128;

	[STAThread]
	public static void Main(string[] args)
	{
		AppDomain.CurrentDomain.UnhandledException += delegate(object sender, UnhandledExceptionEventArgs e)
		{
			Crash(e.ExceptionObject as Exception);
			Environment.Exit(0);
		};
		Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
		Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
		Logger.Initialize();
		if (!IsUnix) {
			try
			{
				SetDefaultDllDirectories(AppDomainLibraries);
				AddDllDirectory(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, Environment.Is64BitProcess ? "x64" : "x86"));
			}
			catch
			{
				SetDllDirectory(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, Environment.Is64BitProcess ? "x64" : "x86"));
			}
		}
		FNALoggerEXT.LogInfo = delegate(string string_0)
		{
			Logger.Log(string_0);
		};
		FNALoggerEXT.LogWarn = delegate(string string_0)
		{
			Logger.Warning(string_0);
		};
		FNALoggerEXT.LogError = delegate(string string_0)
		{
			Logger.Error(string_0);
		};
		Environment.SetEnvironmentVariable("FNA_OPENGL_DISABLE_LATESWAPTEAR", "1");
		try
		{
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
			using AmorousGame game = new AmorousGame(safemode);
			game.Run();
		}
		catch (Exception exception)
		{
			Crash(exception);
		}
	}

	private static void Crash(Exception exception)
	{
		Logger.Error("Unhandled exception: {0}", exception);
	}
}
