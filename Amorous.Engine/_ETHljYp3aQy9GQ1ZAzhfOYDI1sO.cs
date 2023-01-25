#define TRACE
using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

public static class Logger
{
	private static Stopwatch Timer;

	public static void Initialize()
	{
		Timer = new Stopwatch();
		Timer.Start();
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

	public static void Log(ConsoleColor consoleColor_0, string string_0, string string_1, params object[] object_0)
	{
		if (object_0.Length != 0)
		{
			Trace.WriteLine($"[{(float)Timer.ElapsedMilliseconds / 1000f:0000.00}] {string_0}: {string.Format(string_1, object_0)}");
		}
		else
		{
			Trace.WriteLine($"[{(float)Timer.ElapsedMilliseconds / 1000f:0000.00}] {string_0}: {string_1}");
		}
	}

	public static void Log(string string_0, params object[] object_0)
	{
		Log(ConsoleColor.Gray, "Log", string_0, object_0);
	}

	public static void Warning(string string_0, params object[] object_0)
	{
		Log(ConsoleColor.Yellow, "Warning", string_0, object_0);
	}

	public static void Error(string string_0, params object[] object_0)
	{
		Log(ConsoleColor.Red, "Error", string_0, object_0);
	}

	public static void Success(string string_0, params object[] object_0)
	{
		Log(ConsoleColor.Green, "Success", string_0, object_0);
	}
}
