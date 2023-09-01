using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using Microsoft.Xna.Framework.Content;

public static class Storages
{
	public static string[] GetFilesInDirectory(this ContentManager content, string pattern, params string[] subpaths)
	{
		string directory = Path.Combine(new string[] { content.RootDirectory }.Concat(subpaths).ToArray());
		return Directory.GetFiles(directory, pattern, SearchOption.TopDirectoryOnly);
	}

	public static string[] GetFiles(this ContentManager content, string pattern, params string[] subpaths)
	{
		string directory = Path.Combine(new string[] { content.RootDirectory }.Concat(subpaths).ToArray());
		return Directory.GetFiles(directory, pattern, SearchOption.AllDirectories);
	}

	public static string[] MatchFilesInDirectory(this ContentManager content, string pattern, params string[] subpaths)
	{
		Regex regex = new Regex(pattern, RegexOptions.CultureInvariant);
		return content.GetFilesInDirectory("*", subpaths).Where((path) => regex.IsMatch(path)).ToArray();
	}

	public static string[] MatchFiles(this ContentManager content, string pattern, params string[] subpaths)
	{
		Regex regex = new Regex(pattern, RegexOptions.CultureInvariant);
		return content.GetFiles("*", subpaths).Where((path) => regex.IsMatch(path)).ToArray();
	}

	public static IEnumerable<string> GetInheritsOf(Type type, params Type[] skip)
	{
		Stack<string> inherits = new Stack<string>();
		Type inherit = type;
		while ((inherit = inherit.BaseType) != null)
		{
			if (skip.Contains(inherit)) break;
			int index = inherit.Name.IndexOf('`');
			inherits.Push(index == -1 ? inherit.Name : inherit.Name.Substring(0, index));
		}
		return inherits;
	}

	public static bool EnsureGZipHeader(string path)
	{
		using (FileStream stream = File.OpenRead(path))
		{
			return stream.ReadByte() == 0x1f && stream.ReadByte() == 0x8b;
		}
	}
}
