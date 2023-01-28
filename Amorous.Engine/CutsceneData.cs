using System;
using System.Collections.Generic;
using Newtonsoft.Json;

[Serializable]
public class CutsceneData
{
	[JsonProperty("Name")]
	public string Name { get; set; }

	[JsonProperty("Stages")]
	public List<CutsceneStageData> Stages { get; set; }

	public CutsceneData()
	{
		Stages = new List<CutsceneStageData>();
	}
}
