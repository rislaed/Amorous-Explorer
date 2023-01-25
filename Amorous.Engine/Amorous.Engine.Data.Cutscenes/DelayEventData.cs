using System;
using Newtonsoft.Json;

namespace Amorous.Engine.Data.Cutscenes;

[Serializable]
public class DelayEventData : EventData
{
	[JsonProperty("Delay")]
	public int Delay { get; set; }
}
