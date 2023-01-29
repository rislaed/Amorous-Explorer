using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

public class Saves
{ // _DW9IcpdMEINZmuzfrqmwsduBGih
	public class Pointer
	{
		public bool IsEmpty { get; set; }
		public bool IsAutosave { get; set; }
		public string Name { get; set; }
		public int Index { get; set; }
	}

	private const int SavesCount = 10;
	private const int AutosavesCount = 1;

	private static readonly string SavesDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Saves");

	private static readonly JsonSerializerSettings ExtendedSerializers = new JsonSerializerSettings
	{
		TypeNameHandling = TypeNameHandling.Auto,
		Converters = { (JsonConverter)new ColorJsonConverter() }
	};

	private static string _lastType;
	private static int? _lastIndex;

	public static void Save(int state, SaveData save, string type = "save")
	{
		string contents = JsonConvert.SerializeObject(save, Formatting.Indented, ExtendedSerializers);
		string path = GetPath(state, type);
		File.WriteAllText(path, contents);
	}

	public static void Autosave(int state, SaveData save)
	{
		Save(state, save, "autosave");
	}

	public static SaveData Read(int state, string type = "save")
	{
		string path = GetPath(state, type);
		string value = File.ReadAllText(path);
		SaveData save;
		try
		{
			save = JsonConvert.DeserializeObject<SaveData>(value, ExtendedSerializers);
			if (save == null)
			{
				throw new InvalidDataException("data is null");
			}
			if (save.PlayerData == null)
			{
				throw new InvalidDataException("PlayerData is null");
			}
		}
		catch (Exception ex)
		{
			Logger.Warning("Failed to load save: {0}", ex.ToString());
			save = null;
		}
		_lastType = type;
		_lastIndex = state;
		return save;
	}

	public static SaveData ReadAutosave(int state)
	{
		return Read(state, "autosave");
	}

	public static bool Has(int state, string type = "save")
	{
		return File.Exists(GetPath(state, type));
	}

	public static string GetPath(int state, string type = "save")
	{
		if (!Directory.Exists(SavesDirectory))
		{
			Directory.CreateDirectory(SavesDirectory);
		}
		return Path.Combine(SavesDirectory, $"{type}_{state}.sav");
	}

	public static List<Pointer> GetPointers(bool excludeAutosaves)
	{
		List<Pointer> list = new List<Pointer>();
		if (!excludeAutosaves)
		{
			for (int i = 0; i < AutosavesCount; i++)
			{
				string path = GetPath(0, "autosave");
				if (File.Exists(path))
				{
					DateTime lastWriteTime = File.GetLastWriteTime(path);
					list.Add(new Pointer
					{
						IsEmpty = false,
						IsAutosave = true,
						Name = $"Autosave #{i + 1} - {lastWriteTime:g}",
						Index = i
					});
				}
				else
				{
					list.Add(new Pointer
					{
						IsEmpty = true,
						IsAutosave = true,
						Name = $"Autosave #{i + 1} - Empty",
						Index = i
					});
				}
			}
		}
		for (int j = 0; j < SavesCount; j++)
		{
			string path = GetPath(j);
			if (File.Exists(path))
			{
				DateTime lastWriteTime = File.GetLastWriteTime(path);
				list.Add(new Pointer
				{
					IsEmpty = false,
					IsAutosave = false,
					Name = $"Slot #{j + 1} - {lastWriteTime:g}",
					Index = j
				});
			}
			else
			{
				list.Add(new Pointer
				{
					IsEmpty = true,
					IsAutosave = false,
					Name = $"Slot #{j + 1} - Empty",
					Index = j
				});
			}
		}
		return list;
	}

	public static Pointer GetLastPointer()
	{
		if (_lastIndex.HasValue)
		{
			return new Pointer
			{
				IsEmpty = false,
				IsAutosave = (_lastType == "autosave"),
				Name = string.Empty,
				Index = _lastIndex.Value
			};
		}
		bool flag = false;
		DateTime? dateTime = null;
		int num = -1;
		for (int i = 0; i < SavesCount; i++)
		{
			string path = GetPath(i);
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
		for (int j = 0; j < AutosavesCount; j++)
		{
			string path = GetPath(j, "autosave");
			if (File.Exists(path))
			{
				DateTime lastWriteTime = File.GetLastWriteTime(path);
				if (!dateTime.HasValue || dateTime.Value < lastWriteTime)
				{
					flag = true;
					dateTime = lastWriteTime;
					num = j;
				}
			}
		}
		return new Pointer
		{
			IsEmpty = (num < 0),
			IsAutosave = flag,
			Name = string.Empty,
			Index = num
		};
	}
}
