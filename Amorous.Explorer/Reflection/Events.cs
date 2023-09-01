using System;
using System.Collections.Generic;

namespace Amorous.Explorer.Reflection;

public static class Events
{
	public static void AddEvent<T>(this IEnumerable<T> enumerable, string name, Delegate handler)
	{
		foreach (T entry in enumerable)
		{
			entry?.GetType().GetEvent(name)?.AddEventHandler(entry, handler);
		}
	}

	public static void RemoveEvent<T>(this IEnumerable<T> enumerable, string name, Delegate handler)
	{
		foreach (T entry in enumerable)
		{
			entry?.GetType().GetEvent(name)?.RemoveEventHandler(entry, handler);
		}
	}
}
