using System;
using System.IO;
using Newtonsoft.Json;

public class Options
{ // _eJWqL2MhFZHNHP960nsWLJJmyPD
	private static readonly string PATH = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data.json");

	public static Config Config { get; private set; }

	public static bool ContainsResolution()
	{
		if (Config != null && Config.ResolutionHeight > 0)
		{
			return Config.ResolutionWidth > 0;
		}
		return false;
	}

	public static void Read()
	{
		if (!File.Exists(PATH))
		{
			Config = new Config();
			return;
		}
		string json = File.ReadAllText(PATH);
		try
		{
			Config = JsonConvert.DeserializeObject<Config>(json) ?? new Config();
		}
		catch (Exception)
		{
			Logger.Warning("Failed to load Data, falling back to default.");
			Config = new Config();
		}
	}

	public static void Save()
	{
		if (Config != null)
		{
			string contents = JsonConvert.SerializeObject(Config);
			File.WriteAllText(PATH, contents);
		}
	}
}
