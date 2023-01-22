#define TRACE
using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

public static class _ETHljYp3aQy9GQ1ZAzhfOYDI1sO
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _azEYZtng6V3TU9alhVjAMVEBSii
	{
		public static readonly _azEYZtng6V3TU9alhVjAMVEBSii _003C_003E9 = new _azEYZtng6V3TU9alhVjAMVEBSii();

		public static Func<string, string> _003C_003E9__1_0;

		internal string _8GCnnq5uoaiVAlNPe6wqwZjegyb(string string_0)
		{
			return string_0;
		}
	}

	private static Stopwatch _fW0XUSoDEDzTuYfvYXFC3oVcKvN;

	public static void _oD87G7SXjsTukw7IVWxVlVFEgvA()
	{
		_fW0XUSoDEDzTuYfvYXFC3oVcKvN = new Stopwatch();
		_fW0XUSoDEDzTuYfvYXFC3oVcKvN.Start();
		string text = Assembly.GetEntryAssembly()!.GetName().Name!.ToLower();
		string arg = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, text);
		Trace.Listeners.Clear();
		if (File.Exists($"{arg}-log.txt"))
		{
			File.Move($"{arg}-log.txt", $"{arg}-log-backup-{DateTime.Now:yyyy.MM.dd-HH.mm.ss}.txt");
		}
		string[] files = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory, $"{text}-log-backup-*.txt");
		foreach (string item in files.OrderByDescending((string string_0) => string_0).Skip(10))
		{
			File.Delete(item);
		}
		Trace.Listeners.Add(new TextWriterTraceListener($"{arg}-log.txt"));
		Trace.Listeners.Add(new ConsoleTraceListener(useErrorStream: false));
		Trace.AutoFlush = true;
	}

	public static void _8GJSgyb6FWRvKxxAcjyaU02i18E(ConsoleColor consoleColor_0, string string_0, string string_1, params object[] object_0)
	{
		if (object_0.Length != 0)
		{
			Trace.WriteLine($"[{(float)_fW0XUSoDEDzTuYfvYXFC3oVcKvN.ElapsedMilliseconds / 1000f:0000.00}] {string_0}: {string.Format(string_1, object_0)}");
		}
		else
		{
			Trace.WriteLine($"[{(float)_fW0XUSoDEDzTuYfvYXFC3oVcKvN.ElapsedMilliseconds / 1000f:0000.00}] {string_0}: {string_1}");
		}
	}

	public static void _8GJSgyb6FWRvKxxAcjyaU02i18E(string string_0, params object[] object_0)
	{
		_8GJSgyb6FWRvKxxAcjyaU02i18E(ConsoleColor.Gray, "Log", string_0, object_0);
	}

	public static void _IGmWy5uYuv50rXGtBNbMPGzJhWh(string string_0, params object[] object_0)
	{
		_8GJSgyb6FWRvKxxAcjyaU02i18E(ConsoleColor.Yellow, "Warning", string_0, object_0);
	}

	public static void _0rEYVY1cDKfLPVuLw54UlaIts2m(string string_0, params object[] object_0)
	{
		_8GJSgyb6FWRvKxxAcjyaU02i18E(ConsoleColor.Red, "Error", string_0, object_0);
	}

	public static void _JmIDYFXDf2wcAGArwRlNg4WYoUEA(string string_0, params object[] object_0)
	{
		_8GJSgyb6FWRvKxxAcjyaU02i18E(ConsoleColor.Green, "Success", string_0, object_0);
	}
}
