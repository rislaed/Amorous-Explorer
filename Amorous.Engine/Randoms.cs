using System;
using System.Security.Cryptography;
using System.Text;

public static class Utils
{ // _boyt8NIMtKsAGSTcjHeL0WMbFxs
	public static float Date;

	private static readonly Random _random = new Random();

	public static float RandomFloat(float min, float max)
	{
		return (float)_random.NextDouble() * (max - min) + min;
	}

	public static int Random()
	{
		return _random.Next();
	}

	public static int Random(int min, int max)
	{
		return _random.Next(min, max);
	}

	public static bool RandomBool()
	{
		return _random.Next(0, 100) <= 50;
	}

	public static string GetMD5(string source)
	{
		MD5 md5 = MD5.Create();
		byte[] bytes = Encoding.ASCII.GetBytes(source);
		byte[] hash = md5.ComputeHash(bytes);
		StringBuilder stringBuilder = new StringBuilder();
		foreach (byte b in hash)
		{
			stringBuilder.Append(b.ToString("X2"));
		}
		return stringBuilder.ToString().ToLower();
	}
}
