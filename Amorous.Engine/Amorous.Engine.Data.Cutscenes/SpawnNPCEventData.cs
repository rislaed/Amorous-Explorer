using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Amorous.Engine.Data.Cutscenes;

[Serializable]
public class SpawnNPCEventData : _3GMZuOfG1tyI9A65sJfkkPLAGdr
{
	[JsonProperty("NPC")]
	public string _4QLHHCk23T1BjK7acKxASbkCefG { get; set; }

	[JsonProperty("Location")]
	public string _qZXN2SXhpGdh4T5ZXzgMA9gjYZE { get; set; }

	[JsonProperty("Layer")]
	public string _dPmC8tBC0iph2YBAFmztEsmwUdSA { get; set; }

	[JsonProperty("Voice")]
	public string _oYBxqDGzxQL6JWNoPfdeHzWGPRp { get; set; }

	[JsonProperty("Head")]
	public string _kni1uFw1BPElsVA74myj9H1jAKh { get; set; }

	[JsonProperty("Pose")]
	public string _UjXB7oNK1WnbtEn6d4PkoGLaYEE { get; set; }

	[JsonProperty("Clothes")]
	public List<string> _wUcbLpwYJ1T1bI8GaQwj9Jxx4YX { get; set; }

	public SpawnNPCEventData()
	{
		_wUcbLpwYJ1T1bI8GaQwj9Jxx4YX = new List<string>();
	}
}
