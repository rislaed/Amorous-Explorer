using System.Collections.Generic;
using System.Linq;

namespace Amorous.Explorer.Data;

public static class Readables
{
	public static string ToPersonReadable(this string source)
	{
		if (string.IsNullOrEmpty(source))
		{
			return source;
		}
		bool previousCharacterIsDigit = false;
		bool previousCharacterIsUpper = false;
		return string.Join("", source.SelectMany((character, index) => {
			if (char.IsWhiteSpace(character))
			{
				previousCharacterIsDigit = previousCharacterIsUpper = true;
				return new char[] { character };
			}
			if ((!previousCharacterIsDigit && char.IsDigit(character)) || (!previousCharacterIsUpper && char.IsUpper(character)))
			{
				previousCharacterIsDigit = char.IsDigit(character);
				previousCharacterIsUpper = char.IsUpper(character);
				if (index == 0)
				{
					return new char[] { character };
				}
				return new char[] { ' ', character };
			}
			if (previousCharacterIsDigit)
			{
				previousCharacterIsDigit = char.IsDigit(character);
				if (!(previousCharacterIsDigit || previousCharacterIsUpper))
				{
					return new char[] { ' ', character };
				}
			}
			if (previousCharacterIsUpper)
			{
				previousCharacterIsUpper = char.IsUpper(character);
			}
			return new char[] { character };
		}));
	}

	public static string TrimSuffix(this string source, params string[] suffixes)
	{
		if (string.IsNullOrEmpty(source) || suffixes == null)
		{
			return source;
		}
		foreach (string suffix in suffixes)
		{
			if (source.EndsWith(suffix))
			{
				return source.Substring(0, source.Length - suffix.Length);
			}
		}
		return source;
	}

	public static string TrimPrefix(this string source, params string[] prefixes)
	{
		if (string.IsNullOrEmpty(source) || prefixes == null)
		{
			return source;
		}
		foreach (string prefix in prefixes)
		{
			if (source.StartsWith(prefix))
			{
				return source.Substring(prefix.Length);
			}
		}
		return source;
	}

	public static IDictionary<string, string> ToPersonReadableDictionary(IEnumerable<string> enumerable)
	{
		return enumerable
			.Select((stroke) => new KeyValuePair<string, string>(
				stroke.ToPersonReadable(), stroke
			))
			.ToDictionary();
	}

	public static IDictionary<string, IDictionary<string, TValue>> ToPersonReadableDictionary<TValue>(IDictionary<string, IDictionary<string, TValue>> dictionary)
	{
		return dictionary
			.Select((pair) => new KeyValuePair<string, IDictionary<string, TValue>>(
				pair.Key, pair.Value
					.Select((pair) => new KeyValuePair<string, TValue>(
						pair.Key.ToPersonReadable(), pair.Value
					))
					.ToDictionary()
			))
			.ToDictionary();
	}

	public static IDictionary<string, IDictionary<string, string>> ToPersonReadableDictionary(IDictionary<string, IEnumerable<string>> dictionary)
	{
		return dictionary
			.Select((pair) => new KeyValuePair<string, IDictionary<string, string>>(
				pair.Key, pair.Value
					.Select((stroke) => new KeyValuePair<string, string>(
						stroke.ToPersonReadable(), stroke
					))
					.ToDictionary()
			))
			.ToDictionary();
	}

	public static IDictionary<string, TValue> ToPersonReadableKeysDictionary<TValue>(IDictionary<string, TValue> dictionary)
	{
		return dictionary
			.Select((pair) => new KeyValuePair<string, TValue>(
				pair.Key.ToPersonReadable(), pair.Value
			))
			.ToDictionary();
	}

	public static IDictionary<string, IDictionary<string, TValue>> ToTrimmedSuffixDictionary<TValue>(IDictionary<string, IDictionary<string, TValue>> dictionary, params string[] suffixes)
	{
		return dictionary
			.Select((pair) => new KeyValuePair<string, IDictionary<string, TValue>>(
				pair.Key, pair.Value
					.Select((pair) => new KeyValuePair<string, TValue>(
						pair.Key.TrimSuffix(suffixes), pair.Value
					))
					.ToDictionary()
			))
			.ToDictionary();
	}

	public static IDictionary<string, TValue> ToTrimmedSuffixKeysDictionary<TValue>(IDictionary<string, TValue> dictionary, params string[] suffixes)
	{
		return dictionary
			.Select((pair) => new KeyValuePair<string, TValue>(
				pair.Key.TrimSuffix(suffixes), pair.Value
			))
			.ToDictionary();
	}

	public static IDictionary<string, IDictionary<string, TValue>> ToTrimmedPrefixDictionary<TValue>(IDictionary<string, IDictionary<string, TValue>> dictionary, params string[] prefixes)
	{
		return dictionary
			.Select((pair) => new KeyValuePair<string, IDictionary<string, TValue>>(
				pair.Key, pair.Value
					.Select((pair) => new KeyValuePair<string, TValue>(
						pair.Key.TrimPrefix(prefixes), pair.Value
					))
					.ToDictionary()
			))
			.ToDictionary();
	}

	public static IDictionary<string, TValue> ToTrimmedPrefixKeysDictionary<TValue>(IDictionary<string, TValue> dictionary, params string[] suffixes)
	{
		return dictionary
			.Select((pair) => new KeyValuePair<string, TValue>(
				pair.Key.TrimPrefix(suffixes), pair.Value
			))
			.ToDictionary();
	}
}
