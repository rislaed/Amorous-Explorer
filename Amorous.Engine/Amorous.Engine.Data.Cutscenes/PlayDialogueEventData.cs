using System;
using Microsoft.Xna.Framework;
using Newtonsoft.Json;

namespace Amorous.Engine.Data.Cutscenes;

[Serializable]
public class PlayDialogueEventData : EventData
{
	[JsonProperty("Text")]
	public string Text { get; set; }

	[JsonProperty("Title")]
	public string Title { get; set; }

	[JsonProperty("Color")]
	public Color Color { get; set; }
}
