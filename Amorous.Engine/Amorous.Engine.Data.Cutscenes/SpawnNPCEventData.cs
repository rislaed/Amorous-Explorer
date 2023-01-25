using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Amorous.Engine.Data.Cutscenes;

[Serializable]
public class SpawnNPCEventData : EventData
{
	[JsonProperty("NPC")]
	public string NPC { get; set; }

	[JsonProperty("Location")]
	public string Location { get; set; }

	[JsonProperty("Layer")]
	public string Layer { get; set; }

	[JsonProperty("Voice")]
	public string Voice { get; set; }

	[JsonProperty("Head")]
	public string Head { get; set; }

	[JsonProperty("Pose")]
	public string Pose { get; set; }

	[JsonProperty("Clothes")]
	public List<string> Clothes { get; set; }

	public SpawnNPCEventData()
	{
		Clothes = new List<string>();
	}
}
