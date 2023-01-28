using Newtonsoft.Json;

public class SaveData
{
	[JsonProperty("Version")]
	public int Version { get; set; }

	[JsonProperty("PlayerData")]
	public PlayerData PlayerData { get; set; }

	[JsonProperty("CutsceneState")]
	public CutsceneState CutsceneState { get; set; }

	[JsonProperty("SceneName")]
	public string SceneName { get; set; }

	[JsonProperty("PhoneEnabled")]
	public bool PhoneEnabled { get; set; }
}
