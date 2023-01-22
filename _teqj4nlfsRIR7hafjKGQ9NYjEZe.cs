using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.Xna.Framework;

public static class _teqj4nlfsRIR7hafjKGQ9NYjEZe
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _vz0zJ2bWCWnCTFEeLdbjjSHoFxp
	{
		public static readonly _vz0zJ2bWCWnCTFEeLdbjjSHoFxp _003C_003E9 = new _vz0zJ2bWCWnCTFEeLdbjjSHoFxp();

		public static UnhandledExceptionEventHandler _003C_003E9__4_0;

		public static Action<string> _003C_003E9__4_1;

		public static Action<string> _003C_003E9__4_2;

		public static Action<string> _003C_003E9__4_3;

		internal void _eFwbCsKAq0jbRW4acFJl7FvMQ4m(object sender, UnhandledExceptionEventArgs e)
		{
			_mxSbmCQQPRHc7t2A2pm8HsbyvqfA(e.ExceptionObject as Exception);
			Environment.Exit(0);
		}

		internal void _gqYR9xa7V4e781jQlVlzfzKa8fF(string string_0)
		{
			_ETHljYp3aQy9GQ1ZAzhfOYDI1sO._8GJSgyb6FWRvKxxAcjyaU02i18E(string_0);
		}

		internal void _9BmGPkOa9v7c4Lr9VwjSw8OgAYe(string string_0)
		{
			_ETHljYp3aQy9GQ1ZAzhfOYDI1sO._IGmWy5uYuv50rXGtBNbMPGzJhWh(string_0);
		}

		internal void _gswlJMFbjPEv8F4fulNOdPkvvum(string string_0)
		{
			_ETHljYp3aQy9GQ1ZAzhfOYDI1sO._0rEYVY1cDKfLPVuLw54UlaIts2m(string_0);
		}
	}

	private const int _e2Ucgs0TphHTAenda7BAmHbfNPD = 4096;

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool SetDefaultDllDirectories(int int_0);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	private static extern void AddDllDirectory(string string_0);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool SetDllDirectory(string string_0);

	[STAThread]
	public static void _PijxDMohBfV8yAM5NbVyQM599kM(string[] args)
	{
		AppDomain.CurrentDomain.UnhandledException += delegate(object sender, UnhandledExceptionEventArgs e)
		{
			_mxSbmCQQPRHc7t2A2pm8HsbyvqfA(e.ExceptionObject as Exception);
			Environment.Exit(0);
		};
		Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
		Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
		_ETHljYp3aQy9GQ1ZAzhfOYDI1sO._oD87G7SXjsTukw7IVWxVlVFEgvA();
		try
		{
			SetDefaultDllDirectories(_e2Ucgs0TphHTAenda7BAmHbfNPD);
			AddDllDirectory(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, Environment.Is64BitProcess ? "x64" : "x86"));
		}
		catch
		{
			SetDllDirectory(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, Environment.Is64BitProcess ? "x64" : "x86"));
		}
		FNALoggerEXT.LogInfo = delegate(string string_0)
		{
			_ETHljYp3aQy9GQ1ZAzhfOYDI1sO._8GJSgyb6FWRvKxxAcjyaU02i18E(string_0);
		};
		FNALoggerEXT.LogWarn = delegate(string string_0)
		{
			_ETHljYp3aQy9GQ1ZAzhfOYDI1sO._IGmWy5uYuv50rXGtBNbMPGzJhWh(string_0);
		};
		FNALoggerEXT.LogError = delegate(string string_0)
		{
			_ETHljYp3aQy9GQ1ZAzhfOYDI1sO._0rEYVY1cDKfLPVuLw54UlaIts2m(string_0);
		};
		Environment.SetEnvironmentVariable("FNA_OPENGL_DISABLE_LATESWAPTEAR", "1");
		try
		{
			bool safemode = Array.Exists(args, (self) => self == "-safemode");
			if (Array.Exists(args, (self) => self == "-disablesound"))
			{
				Environment.SetEnvironmentVariable("FNA_AUDIO_DISABLE_SOUND", "1");
			}
			if (Array.Exists(args, (self) => self == "-d3d11"))
			{
				Environment.SetEnvironmentVariable("FNA_OPENGL_FORCE_ES3", "1");
				Environment.SetEnvironmentVariable("SDL_OPENGL_ES_DRIVER", "1");
			}
			using _SkYjfUaaNhTySNgoGUeFZ46X4dM skYjfUaaNhTySNgoGUeFZ46X4dM = new _SkYjfUaaNhTySNgoGUeFZ46X4dM(safemode);
			skYjfUaaNhTySNgoGUeFZ46X4dM.Run();
		}
		catch (Exception exception_)
		{
			_mxSbmCQQPRHc7t2A2pm8HsbyvqfA(exception_);
		}
	}

	private static void _mxSbmCQQPRHc7t2A2pm8HsbyvqfA(Exception exception_0)
	{
		_ETHljYp3aQy9GQ1ZAzhfOYDI1sO._0rEYVY1cDKfLPVuLw54UlaIts2m("Unhandled exception: {0}", exception_0);
	}
}
