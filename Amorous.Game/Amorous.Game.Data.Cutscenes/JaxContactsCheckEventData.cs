using System;
using Newtonsoft.Json;

namespace Amorous.Game.Data.Cutscenes;

[Serializable]
public class JaxContactsCheckEventData : EventData
{
	[JsonProperty("OnlyJaxID")]
	public int OnlyJaxID { get; set; }

	[JsonProperty("OneOrTwoID")]
	public int OneOrTwoID { get; set; }

	[JsonProperty("ThreeOrMoreID")]
	public int ThreeOrMoreID { get; set; }
}
