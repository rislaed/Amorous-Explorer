using Newtonsoft.Json;

namespace Amorous.Engine.Data.Cutscenes;

public class SetFlagEventData : EventData
{
	[JsonProperty("Flag")]
	public string Flag { get; set; }

	[JsonProperty("Value")]
	public bool Value { get; set; }
}
