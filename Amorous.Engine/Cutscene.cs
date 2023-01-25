using System;
using System.Collections.Generic;
using Newtonsoft.Json;

[Serializable]
public class Cutscene
{
	[JsonProperty("Name")]
	public string Name { get; set; }

	[JsonProperty("Stages")]
	public List<CutsceneStage> Stages { get; set; }

	public Cutscene()
	{
		Stages = new List<CutsceneStage>();
	}
}
