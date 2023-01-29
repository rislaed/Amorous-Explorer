using System;
using System.Collections.Generic;
using Newtonsoft.Json;

[Serializable]
public class CustomizationData
{ // _oVHccpskJmMcOYan50N52Esmi8k
	[JsonProperty("Name")]
	public string Name { get; set; }

	[JsonProperty("Width")]
	public int Width { get; set; }

	[JsonProperty("Height")]
	public int Height { get; set; }

	[JsonProperty("Groups")]
	public List<CustomizationGroupData> Groups { get; set; }

	public CustomizationData()
	{
		Groups = new List<CustomizationGroupData>();
	}
}
