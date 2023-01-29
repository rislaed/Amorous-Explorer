using System;
using Microsoft.Xna.Framework;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public class ColorJsonConverter : JsonConverter
{ // _VSQz6uDf5A6KqE8xqKxxcrkhZkA
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
	{
		Color color = (Color)value;
		JObject jObject = new JObject
		{
			["B"] = color.B,
			["G"] = color.G,
			["R"] = color.R,
			["A"] = color.A
		};
		jObject.WriteTo(writer);
	}

	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
	{
		Color color = default(Color);
		JToken jToken = JToken.ReadFrom(reader);
		color.R = (byte)jToken["R"].Value<int>();
		color.G = (byte)jToken["G"].Value<int>();
		color.B = (byte)jToken["B"].Value<int>();
		color.A = (byte)jToken["A"].Value<int>();
		return color;
	}

	public override bool CanConvert(Type objectType)
	{
		return objectType == typeof(Color);
	}
}
