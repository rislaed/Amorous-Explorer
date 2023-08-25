using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

public class Saves
{ // _DW9IcpdMEINZmuzfrqmwsduBGih
	public class Item
	{
		public bool IsEmpty { get; set; }
		public bool IsAutosave { get; set; }
		public string Name { get; set; }
		public int Index { get; set; }
	}

	private const int SAVE_COUNT = 10;
	private const int AUTOSAVE_COUNT = 1;

	private static readonly string SAVES_DIRECTORY = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Saves");

	private static readonly JsonSerializerSettings ExtendedSerializers = new JsonSerializerSettings
	{
		TypeNameHandling = TypeNameHandling.Auto,
		Converters = { (JsonConverter)new ColorJsonConverter() }
	};

	private static string typeLast;
	private static int? indexLast;

	public static void Save(int state, SaveData save, string type = "save")
	{
		string contents = JsonConvert.SerializeObject(save, Formatting.Indented, ExtendedSerializers);
		File.WriteAllText(GetPath(state, type), contents);
	}

	public static void Autosave(int state, SaveData save)
	{
		Save(state, save, "autosave");
	}

	public static SaveData Read(int state, string type = "save")
	{
		string value = File.ReadAllText(GetPath(state, type));
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
		typeLast = type;
		indexLast = state;
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
		if (!Directory.Exists(SAVES_DIRECTORY))
		{
			Directory.CreateDirectory(SAVES_DIRECTORY);
		}
		return Path.Combine(SAVES_DIRECTORY, $"{type}_{state}.sav");
	}

	public static List<Item> GetItems(bool excludeAutosaves)
	{
		List<Item> list = new List<Item>();
		if (!excludeAutosaves)
		{
			for (int i = 0; i < AUTOSAVE_COUNT; i++)
			{
				string path = GetPath(0, "autosave");
				if (File.Exists(path))
				{
					DateTime lastWriteTime = File.GetLastWriteTime(path);
					list.Add(new Item
					{
						IsEmpty = false,
						IsAutosave = true,
						Name = $"Autosave #{i + 1} - {lastWriteTime:g}",
						Index = i
					});
				}
				else
				{
					list.Add(new Item
					{
						IsEmpty = true,
						IsAutosave = true,
						Name = $"Autosave #{i + 1} - Empty",
						Index = i
					});
				}
			}
		}
		for (int j = 0; j < SAVE_COUNT; j++)
		{
			string path = GetPath(j);
			if (File.Exists(path))
			{
				DateTime lastWriteTime = File.GetLastWriteTime(path);
				list.Add(new Item
				{
					IsEmpty = false,
					IsAutosave = false,
					Name = $"Slot #{j + 1} - {lastWriteTime:g}",
					Index = j
				});
			}
			else
			{
				list.Add(new Item
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

	public static Item GetLastItem()
	{
		if (indexLast.HasValue)
		{
			return new Item
			{
				IsEmpty = false,
				IsAutosave = (typeLast == "autosave"),
				Name = string.Empty,
				Index = indexLast.Value
			};
		}
		bool autosave = false;
		DateTime? dateTime = null;
		int index = -1;
		for (int i = 0; i < SAVE_COUNT; i++)
		{
			string path = GetPath(i);
			if (File.Exists(path))
			{
				DateTime lastWriteTime = File.GetLastWriteTime(path);
				if (!dateTime.HasValue || dateTime.Value < lastWriteTime)
				{
					dateTime = lastWriteTime;
					index = i;
				}
			}
		}
		for (int j = 0; j < AUTOSAVE_COUNT; j++)
		{
			string path = GetPath(j, "autosave");
			if (File.Exists(path))
			{
				DateTime lastWriteTime = File.GetLastWriteTime(path);
				if (!dateTime.HasValue || dateTime.Value < lastWriteTime)
				{
					autosave = true;
					dateTime = lastWriteTime;
					index = j;
				}
			}
		}
		return new Item
		{
			IsEmpty = (index < 0),
			IsAutosave = autosave,
			Name = string.Empty,
			Index = index
		};
	}
}
