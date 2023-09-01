using System;
using Microsoft.Xna.Framework;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Amorous.Explorer.Content;

public class RectangleJsonConverter : JsonConverter
{
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
	{
		Rectangle rectangle = (Rectangle)value;
		JObject jObject = new JObject
		{
			["X"] = rectangle.X,
			["Y"] = rectangle.Y,
			["Width"] = rectangle.Width,
			["Height"] = rectangle.Height
		};
		jObject.WriteTo(writer);
	}

	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
	{
		JToken jToken = JToken.ReadFrom(reader);
		return new Rectangle(
			jToken["X"].Value<int>(),
			jToken["Y"].Value<int>(),
			jToken["Width"].Value<int>(),
			jToken["Height"].Value<int>()
		);
	}

	public override bool CanConvert(Type objectType)
	{
		return objectType == typeof(Rectangle);
	}
}
