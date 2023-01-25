using System;
using Newtonsoft.Json;

namespace Amorous.Engine.Data.Cutscenes;

[Serializable]
public class SwitchToSceneEventData : EventData
{
	[JsonProperty("SceneName")]
	public string SceneName { get; set; }
}
