using System;
using Newtonsoft.Json;

[Serializable]
public abstract class EventData
{ // _3GMZuOfG1tyI9A65sJfkkPLAGdr
	[JsonProperty("ID")]
	public int ID { get; set; }

	[JsonProperty("NextID")]
	public int NextID { get; set; }

	[JsonProperty("DebugID")]
	public int DebugID { get; set; }
}
