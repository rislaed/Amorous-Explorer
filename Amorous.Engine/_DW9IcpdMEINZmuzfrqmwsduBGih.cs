using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

public class _DW9IcpdMEINZmuzfrqmwsduBGih
{
	public class _3CCr8Bt1rkuzt0M6gYLbceJGV0p
	{
		public bool _r4LqoJiAr5K9UiLsUzUDbcJDQqo { get; set; }

		public bool _3y7m8OGVjMe7WGIhZ66YOw3ITUE { get; set; }

		public string _RB8fRXeQvK5vs7JEA0XfVCEpg1i { get; set; }

		public int _B3FsRMcQWBXzFf3nLOBKzncessO { get; set; }
	}

	private const int _3P7j5vtB9UhTWKuKZyZOaOeKazw = 10;

	private const int _GXcZ5HOlWGrwQ57GNAEgXtVJV3G = 1;

	private static readonly string _QubTtSSHmMID5jdELnIaJMHe4Dz = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Saves");

	private static readonly JsonSerializerSettings _ONuPEFW55mKuOlkBaBx5Jvmw3gO;

	private static string _AiegX5a7OwPp1LYkClPD8o1ULsK;

	private static int? _siS1qYJcEWci7Kqwn9xPyVqEDUe;

	public static void _7cuPUL8aamrg9daETH6zQk3RwbF(int int_0, _lRHDfpOTd4PxClZkjMpoakPEA9d _lRHDfpOTd4PxClZkjMpoakPEA9d_0, string string_0 = "save")
	{
		string contents = JsonConvert.SerializeObject((object)_lRHDfpOTd4PxClZkjMpoakPEA9d_0, (Formatting)1, _ONuPEFW55mKuOlkBaBx5Jvmw3gO);
		string path = _8tmmqFhFpUnpTGEL7HpnRhEGP7h(int_0, string_0);
		File.WriteAllText(path, contents);
	}

	public static void _3y7m8OGVjMe7WGIhZ66YOw3ITUE(int int_0, _lRHDfpOTd4PxClZkjMpoakPEA9d _lRHDfpOTd4PxClZkjMpoakPEA9d_0)
	{
		_7cuPUL8aamrg9daETH6zQk3RwbF(int_0, _lRHDfpOTd4PxClZkjMpoakPEA9d_0, "autosave");
	}

	public static _lRHDfpOTd4PxClZkjMpoakPEA9d _sabDA8yXNR8DIRSbHjOcXx1e1Ax(int int_0, string string_0 = "save")
	{
		string path = _8tmmqFhFpUnpTGEL7HpnRhEGP7h(int_0, string_0);
		string text = File.ReadAllText(path);
		_lRHDfpOTd4PxClZkjMpoakPEA9d lRHDfpOTd4PxClZkjMpoakPEA9d;
		try
		{
			lRHDfpOTd4PxClZkjMpoakPEA9d = JsonConvert.DeserializeObject<_lRHDfpOTd4PxClZkjMpoakPEA9d>(text, _ONuPEFW55mKuOlkBaBx5Jvmw3gO);
			if (lRHDfpOTd4PxClZkjMpoakPEA9d == null)
			{
				throw new InvalidDataException("data is null");
			}
			if (lRHDfpOTd4PxClZkjMpoakPEA9d._M29jWtsDcmPvHjIYYSiTa8TbWri == null)
			{
				throw new InvalidDataException("PlayerData is null");
			}
		}
		catch (Exception ex)
		{
			_ETHljYp3aQy9GQ1ZAzhfOYDI1sO._IGmWy5uYuv50rXGtBNbMPGzJhWh("Failed to load save: {0}", ex.ToString());
			lRHDfpOTd4PxClZkjMpoakPEA9d = null;
		}
		_AiegX5a7OwPp1LYkClPD8o1ULsK = string_0;
		_siS1qYJcEWci7Kqwn9xPyVqEDUe = int_0;
		return lRHDfpOTd4PxClZkjMpoakPEA9d;
	}

	public static _lRHDfpOTd4PxClZkjMpoakPEA9d _NyR9YmfkeF4CXGOi1ENApzh6B5V(int int_0)
	{
		return _sabDA8yXNR8DIRSbHjOcXx1e1Ax(int_0, "autosave");
	}

	public static bool _IWX6rV0RuGLrk1esoZktU0seJBF(int int_0, string string_0 = "save")
	{
		return File.Exists(_8tmmqFhFpUnpTGEL7HpnRhEGP7h(int_0, string_0));
	}

	public static string _8tmmqFhFpUnpTGEL7HpnRhEGP7h(int int_0, string string_0 = "save")
	{
		if (!Directory.Exists(_QubTtSSHmMID5jdELnIaJMHe4Dz))
		{
			Directory.CreateDirectory(_QubTtSSHmMID5jdELnIaJMHe4Dz);
		}
		return Path.Combine(_QubTtSSHmMID5jdELnIaJMHe4Dz, $"{string_0}_{int_0}.sav");
	}

	public static List<_3CCr8Bt1rkuzt0M6gYLbceJGV0p> _25D1ZH2er0EbpKmvFksAbFjP2OX(bool bool_0)
	{
		//IL_00ac: Incompatible stack heights: 0 vs 1
		//IL_0156: Incompatible stack heights: 0 vs 1
		List<_3CCr8Bt1rkuzt0M6gYLbceJGV0p> list = new List<_3CCr8Bt1rkuzt0M6gYLbceJGV0p>();
		if (!bool_0)
		{
			for (int i = 0; i < 1; i++)
			{
				_ = 0;
				if (_DW9IcpdMEINZmuzfrqmwsduBGih.smethod_5("autosave"))
				{
					DateTime lastWriteTime = File.GetLastWriteTime(_8tmmqFhFpUnpTGEL7HpnRhEGP7h(0, "autosave"));
					list.Add(new _3CCr8Bt1rkuzt0M6gYLbceJGV0p
					{
						_r4LqoJiAr5K9UiLsUzUDbcJDQqo = false,
						_3y7m8OGVjMe7WGIhZ66YOw3ITUE = true,
						_RB8fRXeQvK5vs7JEA0XfVCEpg1i = $"Autosave #{i + 1} - {lastWriteTime:g}",
						_B3FsRMcQWBXzFf3nLOBKzncessO = i
					});
				}
				else
				{
					list.Add(new _3CCr8Bt1rkuzt0M6gYLbceJGV0p
					{
						_r4LqoJiAr5K9UiLsUzUDbcJDQqo = true,
						_3y7m8OGVjMe7WGIhZ66YOw3ITUE = true,
						_RB8fRXeQvK5vs7JEA0XfVCEpg1i = $"Autosave #{i + 1} - Empty",
						_B3FsRMcQWBXzFf3nLOBKzncessO = i
					});
				}
			}
		}
		for (int j = 0; j < 10; j++)
		{
			if (_DW9IcpdMEINZmuzfrqmwsduBGih.smethod_5("save"))
			{
				DateTime lastWriteTime2 = File.GetLastWriteTime(_8tmmqFhFpUnpTGEL7HpnRhEGP7h(j));
				list.Add(new _3CCr8Bt1rkuzt0M6gYLbceJGV0p
				{
					_r4LqoJiAr5K9UiLsUzUDbcJDQqo = false,
					_3y7m8OGVjMe7WGIhZ66YOw3ITUE = false,
					_RB8fRXeQvK5vs7JEA0XfVCEpg1i = $"Slot #{j + 1} - {lastWriteTime2:g}",
					_B3FsRMcQWBXzFf3nLOBKzncessO = j
				});
			}
			else
			{
				list.Add(new _3CCr8Bt1rkuzt0M6gYLbceJGV0p
				{
					_r4LqoJiAr5K9UiLsUzUDbcJDQqo = true,
					_3y7m8OGVjMe7WGIhZ66YOw3ITUE = false,
					_RB8fRXeQvK5vs7JEA0XfVCEpg1i = $"Slot #{j + 1} - Empty",
					_B3FsRMcQWBXzFf3nLOBKzncessO = j
				});
			}
		}
		return list;
	}

	public static _3CCr8Bt1rkuzt0M6gYLbceJGV0p _jVNnsNFMjoGC9t7v83qLI8vEZSH()
	{
		if (_siS1qYJcEWci7Kqwn9xPyVqEDUe.HasValue)
		{
			return new _3CCr8Bt1rkuzt0M6gYLbceJGV0p
			{
				_r4LqoJiAr5K9UiLsUzUDbcJDQqo = false,
				_3y7m8OGVjMe7WGIhZ66YOw3ITUE = (_AiegX5a7OwPp1LYkClPD8o1ULsK == "autosave"),
				_RB8fRXeQvK5vs7JEA0XfVCEpg1i = string.Empty,
				_B3FsRMcQWBXzFf3nLOBKzncessO = _siS1qYJcEWci7Kqwn9xPyVqEDUe.Value
			};
		}
		bool flag = false;
		DateTime? dateTime = null;
		int num = -1;
		for (int i = 0; i < 10; i++)
		{
			string path = _8tmmqFhFpUnpTGEL7HpnRhEGP7h(i);
			if (File.Exists(path))
			{
				DateTime lastWriteTime = File.GetLastWriteTime(path);
				if (!dateTime.HasValue || dateTime.Value < lastWriteTime)
				{
					dateTime = lastWriteTime;
					num = i;
				}
			}
		}
		for (int j = 0; j < 1; j++)
		{
			string path2 = _8tmmqFhFpUnpTGEL7HpnRhEGP7h(j, "autosave");
			if (File.Exists(path2))
			{
				DateTime lastWriteTime2 = File.GetLastWriteTime(path2);
				if (!dateTime.HasValue || dateTime.Value < lastWriteTime2)
				{
					flag = true;
					dateTime = lastWriteTime2;
					num = j;
				}
			}
		}
		return new _3CCr8Bt1rkuzt0M6gYLbceJGV0p
		{
			_r4LqoJiAr5K9UiLsUzUDbcJDQqo = (num < 0),
			_3y7m8OGVjMe7WGIhZ66YOw3ITUE = flag,
			_RB8fRXeQvK5vs7JEA0XfVCEpg1i = string.Empty,
			_B3FsRMcQWBXzFf3nLOBKzncessO = num
		};
	}

	static _DW9IcpdMEINZmuzfrqmwsduBGih()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		JsonSerializerSettings val = new JsonSerializerSettings();
		val.set_TypeNameHandling((TypeNameHandling)4);
		val.get_Converters().Add((JsonConverter)(object)new _VSQz6uDf5A6KqE8xqKxxcrkhZkA());
		_ONuPEFW55mKuOlkBaBx5Jvmw3gO = val;
	}

	static string smethod_0(object object_0, Formatting formatting_0, JsonSerializerSettings jsonSerializerSettings_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return JsonConvert.SerializeObject(object_0, formatting_0, jsonSerializerSettings_0);
	}

	static void smethod_1(string string_0, string string_1)
	{
		File.WriteAllText(string_0, string_1);
	}

	static string smethod_2(string string_0)
	{
		return File.ReadAllText(string_0);
	}

	static InvalidDataException smethod_3(string string_0)
	{
		return new InvalidDataException(string_0);
	}

	static string smethod_4(object object_0)
	{
		return object_0.ToString();
	}

	static bool smethod_5(string string_0)
	{
		return File.Exists(string_0);
	}

	static bool smethod_6(string string_0)
	{
		return Directory.Exists(string_0);
	}

	static DirectoryInfo smethod_7(string string_0)
	{
		return Directory.CreateDirectory(string_0);
	}

	static string smethod_8(string string_0, object object_0, object object_1)
	{
		return string.Format(string_0, object_0, object_1);
	}

	static string smethod_9(string string_0, string string_1)
	{
		return Path.Combine(string_0, string_1);
	}

	static DateTime smethod_10(string string_0)
	{
		return File.GetLastWriteTime(string_0);
	}

	static string smethod_11(string string_0, object object_0)
	{
		return string.Format(string_0, object_0);
	}

	static bool smethod_12(string string_0, string string_1)
	{
		return string_0 == string_1;
	}

	static AppDomain smethod_13()
	{
		return AppDomain.CurrentDomain;
	}

	static string smethod_14(AppDomain appDomain_0)
	{
		return appDomain_0.BaseDirectory;
	}

	static JsonSerializerSettings smethod_15()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new JsonSerializerSettings();
	}

	static void smethod_16(JsonSerializerSettings jsonSerializerSettings_0, TypeNameHandling typeNameHandling_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		jsonSerializerSettings_0.set_TypeNameHandling(typeNameHandling_0);
	}

	static IList<JsonConverter> smethod_17(JsonSerializerSettings jsonSerializerSettings_0)
	{
		return jsonSerializerSettings_0.get_Converters();
	}
}
