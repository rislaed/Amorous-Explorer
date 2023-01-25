using System;
using Newtonsoft.Json;

namespace Amorous.Engine.Data.Cutscenes;

[Serializable]
public class SwitchToSubsceneEventData : EventData
{
	[JsonProperty("SubsceneName")]
	public string SubsceneName { get; set; }
}
