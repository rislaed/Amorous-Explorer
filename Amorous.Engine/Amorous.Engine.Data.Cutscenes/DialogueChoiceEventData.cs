using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Amorous.Engine.Data.Cutscenes;

[Serializable]
public class DialogueChoiceEventData : _3GMZuOfG1tyI9A65sJfkkPLAGdr
{
	[JsonProperty("Choices")]
	public List<DialogueChoiceItem> _UGE50ZJkpUKKpV0XQkhALS58JSJ { get; set; }

	public DialogueChoiceEventData()
	{
		_UGE50ZJkpUKKpV0XQkhALS58JSJ = new List<DialogueChoiceItem>();
	}
}
