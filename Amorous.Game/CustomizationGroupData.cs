using System;
using System.Collections.Generic;
using Newtonsoft.Json;

[Serializable]
public class CustomizationGroupData
{ // _WmDwUqOXqj6xpaw8SzHUPXR0uwB
	[JsonProperty("Name")]
	public string Name { get; set; }

	[JsonProperty("Layers")]
	public List<CustomizationLayerData> Layers { get; set; }

	public CustomizationGroupData()
	{
		Layers = new List<CustomizationLayerData>();
	}
}
