#define TRACE
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;

public static class Logger
{ // _ETHljYp3aQy9GQ1ZAzhfOYDI1sO
	private static Stopwatch _stopwatch;

	public static void Initialize()
	{
		_stopwatch = new Stopwatch();
		_stopwatch.Start();
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

	public static void Log(ConsoleColor color, string tag, string message, params object[] formatting)
	{
		if (formatting.Length != 0)
		{
			Trace.WriteLine($"[{(float)_stopwatch.ElapsedMilliseconds / 1000f:0000.00}] {tag}: {string.Format(message, formatting)}");
		}
		else
		{
			Trace.WriteLine($"[{(float)_stopwatch.ElapsedMilliseconds / 1000f:0000.00}] {tag}: {message}");
		}
	}

	public static void Log(string message, params object[] formatting)
	{
		Log(ConsoleColor.Gray, "Log", message, formatting);
	}

	public static void Warning(string message, params object[] formatting)
	{
		Log(ConsoleColor.Yellow, "Warning", message, formatting);
	}

	public static void Error(string message, params object[] formatting)
	{
		Log(ConsoleColor.Red, "Error", message, formatting);
	}

	public static void Success(string message, params object[] formatting)
	{
		Log(ConsoleColor.Green, "Success", message, formatting);
	}
}
