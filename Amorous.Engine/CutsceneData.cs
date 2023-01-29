using System;
using System.Collections.Generic;
using Newtonsoft.Json;

[Serializable]
public class CutsceneData
{ // _0SvCRe0EgzR9DhI3QPe1GUqubAt
	[JsonProperty("Name")]
	public string Name { get; set; }

	[JsonProperty("Stages")]
	public List<CutsceneStageData> Stages { get; set; }

	public CutsceneData()
	{
		Stages = new List<CutsceneStageData>();
	}
}
