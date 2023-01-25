using Amorous.Engine.GUI;
using Newtonsoft.Json;

public class Config
{
	[JsonProperty("ResolutionWidth")]
	public int ResolutionWidth { get; set; }

	[JsonProperty("ResolutionHeight")]
	public int ResolutionHeight { get; set; }

	[JsonProperty("Fullscreen")]
	public bool Fullscreen { get; set; }

	[JsonProperty("MasterVolume")]
	public float MasterVolume { get; set; }

	[JsonProperty("MusicVolume")]
	public float MusicVolume { get; set; }

	[JsonProperty("SfxVolume")]
	public float SfxVolume { get; set; }

	[JsonProperty("DialogueTextSpeed")]
	public DialogueSpeed DialogueTextSpeed { get; set; }

	[JsonProperty("DialogueAutoSkip")]
	public bool DialogueAutoSkip { get; set; }

	[JsonProperty("CheatsCensored")]
	public bool CheatsCensored { get; set; }

	[JsonProperty("CheatsTopless")]
	public bool CheatsTopless { get; set; }

	[JsonProperty("CheatsBottomless")]
	public bool CheatsBottomless { get; set; }

	public Config()
	{
		MasterVolume = 1f;
		MusicVolume = 0.4f;
		SfxVolume = 0.4f;
		DialogueTextSpeed = DialogueSpeed.Normal;
		DialogueAutoSkip = true;
		CheatsCensored = false;
		CheatsTopless = false;
		CheatsBottomless = false;
	}
}
