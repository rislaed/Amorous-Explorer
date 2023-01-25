using System;
using System.Collections.Generic;
using Newtonsoft.Json;

[Serializable]
public class _Qzndj0TwqO8yTQMbRwL4FFwlTbv
{
	[NonSerialized]
	[JsonIgnore]
	public _uqydQVaCmCvK7zzWs5W4gZFpKBu Layer;

	[JsonProperty("AssetName")]
	public string AssetName { get; set; }

	[JsonProperty("X")]
	public int X { get; set; }

	[JsonProperty("Y")]
	public int Y { get; set; }

	[JsonProperty("ZOrder")]
	public int ZOrder { get; set; }

	[JsonProperty("Tags")]
	public List<string> Tags { get; set; }

	public _Qzndj0TwqO8yTQMbRwL4FFwlTbv()
	{
		Tags = new List<string>();
	}
}
