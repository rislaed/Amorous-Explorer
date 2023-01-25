using System;
using Newtonsoft.Json;

namespace Amorous.Engine.Data.Cutscenes;

[Serializable]
public class DialogueChoiceItem
{
	[JsonProperty("Text")]
	public string Text { get; set; }

	[JsonProperty("NextID")]
	public int NextID { get; set; }
}
