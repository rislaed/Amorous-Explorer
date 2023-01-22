using System;
using System.Security.Cryptography;
using System.Text;

public static class _boyt8NIMtKsAGSTcjHeL0WMbFxs
{
	public static float _AmIUCcrmrrQiiirja7DoiZSjXuv;

	private static readonly Random _2tTGp4eVZLS8tf0Qr1cmyzXMVef = new Random();

	public static float _S7DdtNZASTkc9riB27h5Ktq5VjDA(float float_0, float float_1)
	{
		return (float)_2tTGp4eVZLS8tf0Qr1cmyzXMVef.NextDouble() * (float_1 - float_0) + float_0;
	}

	public static int _07xTWbIEgzxJYsYwFKDbbKNvu4G()
	{
		return _2tTGp4eVZLS8tf0Qr1cmyzXMVef.Next();
	}

	public static int _07xTWbIEgzxJYsYwFKDbbKNvu4G(int int_0, int int_1)
	{
		return _2tTGp4eVZLS8tf0Qr1cmyzXMVef.Next(int_0, int_1);
	}

	public static bool _gbHIDTfALwKhXkamYJbKsAUKL2E()
	{
		return _2tTGp4eVZLS8tf0Qr1cmyzXMVef.Next(0, 100) <= 50;
	}

	public static string _mCgIgZp06WD70u8PXcTcCcl6zfe(string string_0)
	{
		MD5 mD = MD5.Create();
		byte[] bytes = Encoding.ASCII.GetBytes(string_0);
		byte[] array = mD.ComputeHash(bytes);
		StringBuilder stringBuilder = new StringBuilder();
		byte[] array2 = array;
		foreach (byte b in array2)
		{
			stringBuilder.Append(b.ToString("X2"));
		}
		return stringBuilder.ToString().ToLower();
	}
}
