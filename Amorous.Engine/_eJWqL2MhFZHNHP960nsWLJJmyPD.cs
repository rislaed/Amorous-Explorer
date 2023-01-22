using System;
using System.IO;
using Newtonsoft.Json;

public class _eJWqL2MhFZHNHP960nsWLJJmyPD
{
	private static readonly string _wvD7pijDcO3KNAgJ4go8LykDZAv = _eJWqL2MhFZHNHP960nsWLJJmyPD.smethod_6(_eJWqL2MhFZHNHP960nsWLJJmyPD.smethod_5(_eJWqL2MhFZHNHP960nsWLJJmyPD.smethod_4()), "options.json");

	public static _eNOTHZZiu5nx6PrADzfLyng3Igc _Hnb6mPvrZFgOMCIApIeMW88jSsF { get; private set; }

	public static bool _5shlzNYVaJPuzrQfwyRBEphDX6p()
	{
		if (_Hnb6mPvrZFgOMCIApIeMW88jSsF != null)
		{
			while (true)
			{
				int num = -963242201;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x8DB8D1CEu) % 4u)
					{
					case 1u:
					{
						int num3;
						int num4;
						if (_Hnb6mPvrZFgOMCIApIeMW88jSsF._84wHcdDxJz5ElyDPXXlgRgsiW8g <= 0)
						{
							num3 = -203595746;
							num4 = -203595746;
						}
						else
						{
							num3 = -1912763089;
							num4 = -1912763089;
						}
						num = num3 ^ ((int)num2 * -1591557690);
						continue;
					}
					case 0u:
						break;
					case 3u:
						return _Hnb6mPvrZFgOMCIApIeMW88jSsF._Iv7AHXGOFR9WoLBFx6PjEgEHmYI > 0;
					default:
						goto end_IL_0056;
					}
					break;
				}
				continue;
				end_IL_0056:
				break;
			}
		}
		return false;
	}

	public static void _sabDA8yXNR8DIRSbHjOcXx1e1Ax()
	{
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected I4, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected I4, but got Unknown
		//IL_00b7: Incompatible stack heights: 0 vs 1
		//IL_00be: Incompatible stack heights: 0 vs 1
		if (!_eJWqL2MhFZHNHP960nsWLJJmyPD.smethod_0(_wvD7pijDcO3KNAgJ4go8LykDZAv))
		{
			while (true)
			{
				int num = -10362090;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD20B66CBu) % 4u)
					{
					case 1u:
						_Hnb6mPvrZFgOMCIApIeMW88jSsF = new _eNOTHZZiu5nx6PrADzfLyng3Igc();
						num = (int)((num2 * 885812163) ^ 0x3B6B3C84);
						continue;
					case 2u:
						break;
					case 0u:
						return;
					default:
						goto end_IL_0046;
					}
					break;
				}
				continue;
				end_IL_0046:
				break;
			}
		}
		string text = _eJWqL2MhFZHNHP960nsWLJJmyPD.smethod_1(_wvD7pijDcO3KNAgJ4go8LykDZAv);
		try
		{
			_Hnb6mPvrZFgOMCIApIeMW88jSsF = JsonConvert.DeserializeObject<_eNOTHZZiu5nx6PrADzfLyng3Igc>(text) ?? new _eNOTHZZiu5nx6PrADzfLyng3Igc();
		}
		catch (Exception)
		{
			while (true)
			{
				_ = -357225583;
				while (true)
				{
					_003F val = /*Error near IL_0078: Stack underflow*/^ -771004725;
					uint num2 = (uint)(int)val;
					switch (val % 3)
					{
					default:
						return;
					case 2:
						_ETHljYp3aQy9GQ1ZAzhfOYDI1sO._IGmWy5uYuv50rXGtBNbMPGzJhWh("Failed to load options, falling back to default.");
						_Hnb6mPvrZFgOMCIApIeMW88jSsF = new _eNOTHZZiu5nx6PrADzfLyng3Igc();
						_ = (num2 * 2137104146) ^ 0xF82A2FDBu;
						continue;
					case 0:
						break;
					case 1:
						return;
					}
					break;
				}
			}
		}
	}

	public static void _7cuPUL8aamrg9daETH6zQk3RwbF()
	{
		if (_Hnb6mPvrZFgOMCIApIeMW88jSsF == null)
		{
			goto IL_0007;
		}
		goto IL_002b;
		IL_002b:
		string string_ = _eJWqL2MhFZHNHP960nsWLJJmyPD.smethod_2((object)_Hnb6mPvrZFgOMCIApIeMW88jSsF);
		int num = 1267440643;
		goto IL_000c;
		IL_000c:
		switch ((uint)(num ^ 0x2CD07D4) % 4u)
		{
		case 2u:
			break;
		case 0u:
			goto IL_002b;
		case 1u:
			return;
		default:
			_eJWqL2MhFZHNHP960nsWLJJmyPD.smethod_3(_wvD7pijDcO3KNAgJ4go8LykDZAv, string_);
			return;
		}
		goto IL_0007;
		IL_0007:
		num = 1575271617;
		goto IL_000c;
	}

	static bool smethod_0(string string_0)
	{
		return File.Exists(string_0);
	}

	static string smethod_1(string string_0)
	{
		return File.ReadAllText(string_0);
	}

	static string smethod_2(object object_0)
	{
		return JsonConvert.SerializeObject(object_0);
	}

	static void smethod_3(string string_0, string string_1)
	{
		File.WriteAllText(string_0, string_1);
	}

	static AppDomain smethod_4()
	{
		return AppDomain.CurrentDomain;
	}

	static string smethod_5(AppDomain appDomain_0)
	{
		return appDomain_0.BaseDirectory;
	}

	static string smethod_6(string string_0, string string_1)
	{
		return Path.Combine(string_0, string_1);
	}
}
