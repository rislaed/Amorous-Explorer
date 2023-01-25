using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Amorous.Game.Data.Cutscenes;

[Serializable]
public class CommandEventData : EventData
{
	[JsonProperty("Command")]
	public string Command { get; set; }

	[JsonProperty("Parameters")]
	public Dictionary<string, string> Parameters { get; set; }
}
