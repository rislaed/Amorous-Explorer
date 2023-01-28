using System;
using System.Collections.Generic;
using Newtonsoft.Json;

[Serializable]
public class CutsceneStageData
{
	[JsonProperty("Stage")]
	public int Stage { get; set; }

	[JsonProperty("StartID")]
	public int StartID { get; set; }

	[JsonProperty("Events")]
	public List<EventData> Events { get; set; }

	public CutsceneStageData()
	{
		Events = new List<EventData>();
	}
}
