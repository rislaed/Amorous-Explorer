using System;
using System.IO;
using Newtonsoft.Json;

public class _eJWqL2MhFZHNHP960nsWLJJmyPD
{
	private static readonly string _wvD7pijDcO3KNAgJ4go8LykDZAv = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "options.json");

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
		if (!File.Exists(_wvD7pijDcO3KNAgJ4go8LykDZAv))
		{
			_Hnb6mPvrZFgOMCIApIeMW88jSsF = new _eNOTHZZiu5nx6PrADzfLyng3Igc();
			return;
		}
		string value = File.ReadAllText(_wvD7pijDcO3KNAgJ4go8LykDZAv);
		try
		{
			_Hnb6mPvrZFgOMCIApIeMW88jSsF = JsonConvert.DeserializeObject<_eNOTHZZiu5nx6PrADzfLyng3Igc>(value) ?? new _eNOTHZZiu5nx6PrADzfLyng3Igc();
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
			string contents = JsonConvert.SerializeObject(_Hnb6mPvrZFgOMCIApIeMW88jSsF);
			File.WriteAllText(_wvD7pijDcO3KNAgJ4go8LykDZAv, contents);
		}
	}
}
