using System;
using Microsoft.Xna.Framework;
using Newtonsoft.Json;

namespace Amorous.Engine.Data.Cutscenes;

[Serializable]
public class PlayDialogueEventData : _3GMZuOfG1tyI9A65sJfkkPLAGdr
{
	[JsonProperty("Text")]
	public string _K87Hdb6ToAR0us3tN3ZmvHdPdeJ { get; set; }

	[JsonProperty("Title")]
	public string _D5QiLGGNtfoCEnZIUPvH4OKqUabA { get; set; }

	[JsonProperty("Color")]
	public Color _9IjeHaRd3Ej5BEi3CTsJ7Rzh39AA { get; set; }
}
