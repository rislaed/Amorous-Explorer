using System;
using System.Security.Cryptography;
using System.Text;

public static class _boyt8NIMtKsAGSTcjHeL0WMbFxs
{
	public static float _AmIUCcrmrrQiiirja7DoiZSjXuv;

	private static readonly Random _2tTGp4eVZLS8tf0Qr1cmyzXMVef = _boyt8NIMtKsAGSTcjHeL0WMbFxs.smethod_8();

	public static float _S7DdtNZASTkc9riB27h5Ktq5VjDA(float float_0, float float_1)
	{
		return (float)_boyt8NIMtKsAGSTcjHeL0WMbFxs.smethod_0(_2tTGp4eVZLS8tf0Qr1cmyzXMVef) * (float_1 - float_0) + float_0;
	}

	public static int _07xTWbIEgzxJYsYwFKDbbKNvu4G()
	{
		return _boyt8NIMtKsAGSTcjHeL0WMbFxs.smethod_1(_2tTGp4eVZLS8tf0Qr1cmyzXMVef);
	}

	public static int _07xTWbIEgzxJYsYwFKDbbKNvu4G(int int_0, int int_1)
	{
		return _boyt8NIMtKsAGSTcjHeL0WMbFxs.smethod_2(_2tTGp4eVZLS8tf0Qr1cmyzXMVef, int_0, int_1);
	}

	public static bool _gbHIDTfALwKhXkamYJbKsAUKL2E()
	{
		return _boyt8NIMtKsAGSTcjHeL0WMbFxs.smethod_2(_2tTGp4eVZLS8tf0Qr1cmyzXMVef, 0, 100) <= 50;
	}

	public static string _mCgIgZp06WD70u8PXcTcCcl6zfe(string string_0)
	{
		MD5 hashAlgorithm_ = _boyt8NIMtKsAGSTcjHeL0WMbFxs.smethod_3();
		byte[] byte_ = _boyt8NIMtKsAGSTcjHeL0WMbFxs.smethod_5(_boyt8NIMtKsAGSTcjHeL0WMbFxs.smethod_4(), string_0);
		byte[] array = _boyt8NIMtKsAGSTcjHeL0WMbFxs.smethod_6((HashAlgorithm)hashAlgorithm_, byte_);
		StringBuilder stringBuilder = _boyt8NIMtKsAGSTcjHeL0WMbFxs.smethod_7();
		byte[] array2 = array;
		foreach (byte b in array2)
		{
			stringBuilder.Append(b.ToString("X2"));
		}
		return stringBuilder.ToString().ToLower();
	}

	static double smethod_0(Random random_0)
	{
		return random_0.NextDouble();
	}

	static int smethod_1(Random random_0)
	{
		return random_0.Next();
	}

	static int smethod_2(Random random_0, int int_0, int int_1)
	{
		return random_0.Next(int_0, int_1);
	}

	static MD5 smethod_3()
	{
		return MD5.Create();
	}

	static Encoding smethod_4()
	{
		return Encoding.ASCII;
	}

	static byte[] smethod_5(Encoding encoding_0, string string_0)
	{
		return encoding_0.GetBytes(string_0);
	}

	static byte[] smethod_6(HashAlgorithm hashAlgorithm_0, byte[] byte_0)
	{
		return hashAlgorithm_0.ComputeHash(byte_0);
	}

	static StringBuilder smethod_7()
	{
		return new StringBuilder();
	}

	static Random smethod_8()
	{
		return new Random();
	}
}
