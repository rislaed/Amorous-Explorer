using System;
using Newtonsoft.Json;

namespace Amorous.Engine.Data.Cutscenes;

[Serializable]
public class ConditionalBranchEventData : EventData
{
	[JsonProperty("Flag")]
	public string Flag { get; set; }

	[JsonProperty("TrueID")]
	public int TrueID { get; set; }

	[JsonProperty("FalseID")]
	public int FalseID { get; set; }
}
