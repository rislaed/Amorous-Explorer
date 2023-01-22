using System;
using Microsoft.Xna.Framework;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public class _VSQz6uDf5A6KqE8xqKxxcrkhZkA : JsonConverter
{
	public override void _bd4Taa4wphScsFwxsMB96YNdUFo(JsonWriter writer, object value, JsonSerializer serializer)
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

	public override object _YLNjFZnbxagddA6Iuw9uqVAxcSg(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
	{
		Color color = default(Color);
		JToken jToken = JToken.ReadFrom(reader);
		color.R = (byte)jToken["R"].Value<int>();
		color.G = (byte)jToken["G"].Value<int>();
		color.B = (byte)jToken["B"].Value<int>();
		color.A = (byte)jToken["A"].Value<int>();
		return color;
	}

	public override bool _FtkgwdC8WFI2MScrIMNR7rWyFYF(Type objectType)
	{
		return objectType == typeof(Color);
	}

	static JObject smethod_0()
	{
		return new JObject();
	}

	static JToken smethod_1(JsonReader jsonReader_0)
	{
		return JToken.ReadFrom(jsonReader_0);
	}

	static JToken smethod_2(JToken jtoken_0, object object_0)
	{
		return jtoken_0[object_0];
	}

	static Type smethod_3(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	static bool smethod_4(Type type_0, Type type_1)
	{
		return type_0 == type_1;
	}
}
