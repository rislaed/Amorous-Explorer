using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Amorous.Engine.Data.Cutscenes;

[Serializable]
public class DialogueChoiceEventData : EventData
{
	[JsonProperty("Choices")]
	public List<DialogueChoiceItem> Choices { get; set; }

	public DialogueChoiceEventData()
	{
		Choices = new List<DialogueChoiceItem>();
	}
}
