using System;
using System.Collections.Generic;
using Newtonsoft.Json;

[Serializable]
public class PlayerCustomizationTemplatesData
{ // _Q0ZahtTsyov6ogSphMEhTo0NJfz
	[JsonProperty("Templates")]
	public List<PlayerCustomizationData> Templates { get; set; }

	public PlayerCustomizationTemplatesData()
	{
		Templates = new List<PlayerCustomizationData>();
	}
}
