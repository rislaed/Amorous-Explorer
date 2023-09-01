using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Amorous.Explorer.Reflection;

namespace Amorous.Explorer.Data;

public static class Convertions
{
	public static IDictionary<T, K> ToDictionary<T, K>(this IEnumerable<KeyValuePair<T, K>> enumerable)
	{
		return new LinkedDictionary<T, K>(enumerable);
	}

	public static IDictionary<string, IDictionary<string, Type>> ClassesToDictionary(IDictionary<Assembly, IEnumerable<Type>> classes)
	{
		return classes
			.Select((pair) => new KeyValuePair<string, IDictionary<string, Type>>(
				pair.Key.GetName().Name, pair.Value.ToDictionary((type) => type.Name)
			))
			.ToDictionary();
	}

	public static IDictionary<string, IDictionary<string, Type>> ClassesToGenericDictionary(IDictionary<Assembly, IEnumerable<Type>> classes)
	{
		return classes
			.Select((pair) => new KeyValuePair<string, IDictionary<string, Type>>(
				pair.Key.GetName().Name, pair.Value.ToDictionary((type) => type.BaseType?.GetGenericArguments().FirstOrDefault()?.Name ?? type.Name)
			))
			.ToDictionary();
	}

	public static IDictionary<string, IDictionary<string, Type>> ClassesToDialogueNPCsDictionary(IDictionary<Assembly, IEnumerable<Type>> classes)
	{
		return classes
			.Select((pair) => new KeyValuePair<string, IDictionary<string, Type>>(
				pair.Key.GetName().Name, pair.Value.ToDictionary((type) => (string)type.GetField("Name", BindingFlags.Static | BindingFlags.Public)?.GetValue(null) ?? type.Name)
			))
			.ToDictionary();
	}

	public static IDictionary<Assembly, IEnumerable<Type>> SkipNonDialogueNPCs(IDictionary<Assembly, IEnumerable<Type>> classes)
	{
		return classes
			.Select((pair) => new KeyValuePair<Assembly, IEnumerable<Type>>(
				pair.Key, pair.Value.Where((type) => type.GetField("Name", BindingFlags.Static | BindingFlags.Public) != null)
			))
			.Where((pair) => pair.Value.Count() > 0)
			.ToDictionary();
	}

	public static IDictionary<Assembly, IEnumerable<Type>> SkipAbstracts(IDictionary<Assembly, IEnumerable<Type>> classes)
	{
		return classes
			.Select((pair) => new KeyValuePair<Assembly, IEnumerable<Type>>(
				pair.Key, pair.Value.Where((type) => !type.IsAbstract)
			))
			.Where((pair) => pair.Value.Count() > 0)
			.ToDictionary();
	}

	public static IDictionary<Assembly, IEnumerable<Type>> SkipInterfaces(IDictionary<Assembly, IEnumerable<Type>> classes)
	{
		return classes
			.Select((pair) => new KeyValuePair<Assembly, IEnumerable<Type>>(
				pair.Key, pair.Value.Where((type) => !type.IsInterface)
			))
			.Where((pair) => pair.Value.Count() > 0)
			.ToDictionary();
	}

	public static IDictionary<Assembly, IEnumerable<Type>> SkipUnimplemented(IDictionary<Assembly, IEnumerable<Type>> classes)
	{
		return classes
			.Select((pair) => new KeyValuePair<Assembly, IEnumerable<Type>>(
				pair.Key, pair.Value.Where((type) => !(type.IsAbstract || type.IsInterface))
			))
			.Where((pair) => pair.Value.Count() > 0)
			.ToDictionary();
	}

	public static IDictionary<string, IDictionary<string, string>> FilesToDictionary(IEnumerable<string> files)
	{
		IDictionary<string, IDictionary<string, string>> subdictionary = files
			.GroupBy(
				(file) => Path.GetDirectoryName(file),
				(directory, pathes) => new KeyValuePair<string, IDictionary<string, string>>(
					directory, pathes.ToDictionary((path) => Path.GetFileNameWithoutExtension(path))
				)
			)
			.ToDictionary();
		IEnumerable<char[]> directories = subdictionary.Keys
			.Select((path) => path.ToCharArray());
		int separator = directories
			.OrderBy((chars) => chars.Length)
			.FirstOrDefault()?
			.TakeWhile((target, index) => directories.All(
				(chars) => chars[index] == target
			))
			.Count() ?? 0;
		return subdictionary
			.Select((pair) => new KeyValuePair<string, IDictionary<string, string>>(
				pair.Key.Substring(separator), pair.Value
			))
			.ToDictionary();
	}

	public static IDictionary<string, IDictionary<string, TValue>> OrderByKeys<TValue>(IDictionary<string, IDictionary<string, TValue>> dictionary)
	{
		return dictionary
			.Select((pair) => new KeyValuePair<string, IDictionary<string, TValue>>(
				pair.Key, pair.Value.OrderBy((pair) => pair.Key).ToDictionary()
			))
			.ToDictionary();
	}

	public static IDictionary<string, object> ToObjectDictionary<TValue>(IDictionary<string, TValue> dictionary)
	{
		LinkedDictionary<string, object> target = new LinkedDictionary<string, object>();
		foreach (KeyValuePair<string, TValue> group in dictionary)
		{
			target[group.Key] = group.Value;
		}
		return target;
	}

	public static IDictionary<string, IDictionary<string, object>> ToObjectDictionary<TValue>(IDictionary<string, IDictionary<string, TValue>> dictionary)
	{
		LinkedDictionary<string, IDictionary<string, object>> target = new LinkedDictionary<string, IDictionary<string, object>>();
		foreach (KeyValuePair<string, IDictionary<string, TValue>> group in dictionary)
		{
			LinkedDictionary<string, object> objective = new LinkedDictionary<string, object>();
			foreach (KeyValuePair<string, TValue> item in group.Value)
			{
				objective[item.Key] = item.Value;
			}
			target[group.Key] = objective;
		}
		return target;
	}
}
