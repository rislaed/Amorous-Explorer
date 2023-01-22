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
		byte[] array2 = default(byte[]);
		int num3 = default(int);
		while (true)
		{
			int num = -2053750986;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB0D9E99Du) % 8u)
				{
				case 7u:
				{
					byte b = array2[num3];
					stringBuilder.Append(b.ToString("X2"));
					num = -45308932;
					continue;
				}
				case 6u:
					num = ((int)num2 * -1616442664) ^ -1285377144;
					continue;
				case 5u:
				{
					int num4;
					if (num3 >= array2.Length)
					{
						num = -138954803;
						num4 = -138954803;
					}
					else
					{
						num = -454864558;
						num4 = -454864558;
					}
					continue;
				}
				case 4u:
					num3 = 0;
					num = (int)((num2 * 915591477) ^ 0x248ABA5F);
					continue;
				case 3u:
					array2 = array;
					num = ((int)num2 * -208122556) ^ 0x1243F41D;
					continue;
				case 1u:
					num3++;
					num = ((int)num2 * -1654724354) ^ -551111962;
					continue;
				case 2u:
					break;
				default:
					return stringBuilder.ToString().ToLower();
				}
				break;
			}
		}
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
