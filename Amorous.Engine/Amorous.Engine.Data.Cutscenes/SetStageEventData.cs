using System;
using Newtonsoft.Json;

namespace Amorous.Engine.Data.Cutscenes;

[Serializable]
public class SetStageEventData : EventData
{
	[JsonProperty("Quest")]
	public string Quest { get; set; }

	[JsonProperty("Stage")]
	public int Stage { get; set; }
}
