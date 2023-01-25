using System;
using Newtonsoft.Json;

namespace Amorous.Engine.Data.Cutscenes;

[Serializable]
public class UnlockContactEventData : EventData
{
	[JsonProperty("Contact")]
	public string Contact { get; set; }
}
