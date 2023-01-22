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

	static Stopwatch smethod_0()
	{
		return new Stopwatch();
	}

	static void smethod_1(Stopwatch stopwatch_0)
	{
		stopwatch_0.Start();
	}

	static Assembly smethod_2()
	{
		return Assembly.GetEntryAssembly();
	}

	static AssemblyName smethod_3(Assembly assembly_0)
	{
		return assembly_0.GetName();
	}

	static string smethod_4(AssemblyName assemblyName_0)
	{
		return assemblyName_0.Name;
	}

	static string smethod_5(string string_0)
	{
		return string_0.ToLower();
	}

	static AppDomain smethod_6()
	{
		return AppDomain.CurrentDomain;
	}

	static string smethod_7(AppDomain appDomain_0)
	{
		return appDomain_0.BaseDirectory;
	}

	static string smethod_8(string string_0, string string_1)
	{
		return Path.Combine(string_0, string_1);
	}

	static TraceListenerCollection smethod_9()
	{
		return Trace.Listeners;
	}

	static void smethod_10(TraceListenerCollection traceListenerCollection_0)
	{
		traceListenerCollection_0.Clear();
	}

	static string smethod_11(string string_0, object object_0)
	{
		return string.Format(string_0, object_0);
	}

	static bool smethod_12(string string_0)
	{
		return File.Exists(string_0);
	}

	static string smethod_13(string string_0, object object_0, object object_1)
	{
		return string.Format(string_0, object_0, object_1);
	}

	static void smethod_14(string string_0, string string_1)
	{
		File.Move(string_0, string_1);
	}

	static string[] smethod_15(string string_0, string string_1)
	{
		return Directory.GetFiles(string_0, string_1);
	}

	static void smethod_16(string string_0)
	{
		File.Delete(string_0);
	}

	static bool smethod_17(IEnumerator ienumerator_0)
	{
		return ienumerator_0.MoveNext();
	}

	static void smethod_18(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static TextWriterTraceListener smethod_19(string string_0)
	{
		return new TextWriterTraceListener(string_0);
	}

	static int smethod_20(TraceListenerCollection traceListenerCollection_0, TraceListener traceListener_0)
	{
		return traceListenerCollection_0.Add(traceListener_0);
	}

	static ConsoleTraceListener smethod_21(bool bool_0)
	{
		return new ConsoleTraceListener(bool_0);
	}

	static void smethod_22(bool bool_0)
	{
		Trace.AutoFlush = bool_0;
	}

	static long smethod_23(Stopwatch stopwatch_0)
	{
		return stopwatch_0.ElapsedMilliseconds;
	}

	static string smethod_24(string string_0, object[] object_0)
	{
		return string.Format(string_0, object_0);
	}

	static string smethod_25(string string_0, object object_0, object object_1, object object_2)
	{
		return string.Format(string_0, object_0, object_1, object_2);
	}

	static void smethod_26(string string_0)
	{
		Trace.WriteLine(string_0);
	}
}
