using System;
using System.IO;
using Newtonsoft.Json;

public class _eJWqL2MhFZHNHP960nsWLJJmyPD
{
	private static readonly string _wvD7pijDcO3KNAgJ4go8LykDZAv = _eJWqL2MhFZHNHP960nsWLJJmyPD.smethod_6(_eJWqL2MhFZHNHP960nsWLJJmyPD.smethod_5(_eJWqL2MhFZHNHP960nsWLJJmyPD.smethod_4()), "options.json");

	public static _eNOTHZZiu5nx6PrADzfLyng3Igc _Hnb6mPvrZFgOMCIApIeMW88jSsF { get; private set; }

	public static bool _5shlzNYVaJPuzrQfwyRBEphDX6p()
	{
		if (_Hnb6mPvrZFgOMCIApIeMW88jSsF != null && _Hnb6mPvrZFgOMCIApIeMW88jSsF._84wHcdDxJz5ElyDPXXlgRgsiW8g > 0)
		{
			return _Hnb6mPvrZFgOMCIApIeMW88jSsF._Iv7AHXGOFR9WoLBFx6PjEgEHmYI > 0;
		}
		return false;
	}

	public static void _sabDA8yXNR8DIRSbHjOcXx1e1Ax()
	{
		if (!_eJWqL2MhFZHNHP960nsWLJJmyPD.smethod_0(_wvD7pijDcO3KNAgJ4go8LykDZAv))
		{
			_Hnb6mPvrZFgOMCIApIeMW88jSsF = new _eNOTHZZiu5nx6PrADzfLyng3Igc();
			return;
		}
		string text = _eJWqL2MhFZHNHP960nsWLJJmyPD.smethod_1(_wvD7pijDcO3KNAgJ4go8LykDZAv);
		try
		{
			_Hnb6mPvrZFgOMCIApIeMW88jSsF = JsonConvert.DeserializeObject<_eNOTHZZiu5nx6PrADzfLyng3Igc>(text) ?? new _eNOTHZZiu5nx6PrADzfLyng3Igc();
		}
		catch (Exception)
		{
			_ETHljYp3aQy9GQ1ZAzhfOYDI1sO._IGmWy5uYuv50rXGtBNbMPGzJhWh("Failed to load options, falling back to default.");
			_Hnb6mPvrZFgOMCIApIeMW88jSsF = new _eNOTHZZiu5nx6PrADzfLyng3Igc();
		}
	}

	public static void _7cuPUL8aamrg9daETH6zQk3RwbF()
	{
		if (_Hnb6mPvrZFgOMCIApIeMW88jSsF != null)
		{
			string string_ = _eJWqL2MhFZHNHP960nsWLJJmyPD.smethod_2((object)_Hnb6mPvrZFgOMCIApIeMW88jSsF);
			_eJWqL2MhFZHNHP960nsWLJJmyPD.smethod_3(_wvD7pijDcO3KNAgJ4go8LykDZAv, string_);
		}
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
