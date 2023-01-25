using System;
using Newtonsoft.Json;

namespace Amorous.Engine.Data.Cutscenes;

[Serializable]
public class CensorCheckEventData : EventData
{
	[JsonProperty("SFWID")]
	public int SFWID { get; set; }

	[JsonProperty("NSFWID")]
	public int NSFWID { get; set; }
}
