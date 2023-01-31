using System;
using System.IO;
using Newtonsoft.Json;

public class Options
{ // _eJWqL2MhFZHNHP960nsWLJJmyPD
	private static readonly string Storage = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data.json");

	public static Config Data { get; private set; }

	public static bool ContainsResolution()
	{
		if (Data != null && Data.ResolutionHeight > 0)
		{
			return Data.ResolutionWidth > 0;
		}
		return false;
	}

	public static void Read()
	{
		if (!File.Exists(Storage))
		{
			Data = new Config();
			return;
		}
		string json = File.ReadAllText(Storage);
		try
		{
			Data = JsonConvert.DeserializeObject<Config>(json) ?? new Config();
		}
		catch (Exception)
		{
			Logger.Warning("Failed to load Data, falling back to default.");
			Data = new Config();
		}
	}

	public static void Save()
	{
		if (Data != null)
		{
			string contents = JsonConvert.SerializeObject(Data);
			File.WriteAllText(Storage, contents);
		}
	}
}
