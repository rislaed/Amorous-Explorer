using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public class _VSQz6uDf5A6KqE8xqKxxcrkhZkA : JsonConverter
{
	public override void _bd4Taa4wphScsFwxsMB96YNdUFo(JsonWriter writer, object value, JsonSerializer serializer)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		Color val = (Color)value;
		JObject val2 = new JObject();
		val2.set_Item("B", JToken.op_Implicit(((Color)(ref val)).get_B()));
		val2.set_Item("G", JToken.op_Implicit(((Color)(ref val)).get_G()));
		val2.set_Item("R", JToken.op_Implicit(((Color)(ref val)).get_R()));
		val2.set_Item("A", JToken.op_Implicit(((Color)(ref val)).get_A()));
		JObject val3 = val2;
		((JToken)val3).WriteTo(writer, (JsonConverter[])(object)new JsonConverter[0]);
	}

	public override object _YLNjFZnbxagddA6Iuw9uqVAxcSg(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		Color val = default(Color);
		JToken val2 = JToken.ReadFrom(reader);
		((Color)(ref val)).set_R((byte)Extensions.Value<int>((IEnumerable<JToken>)val2.get_Item((object)"R")));
		((Color)(ref val)).set_G((byte)Extensions.Value<int>((IEnumerable<JToken>)val2.get_Item((object)"G")));
		((Color)(ref val)).set_B((byte)Extensions.Value<int>((IEnumerable<JToken>)val2.get_Item((object)"B")));
		((Color)(ref val)).set_A((byte)Extensions.Value<int>((IEnumerable<JToken>)val2.get_Item((object)"A")));
		return val;
	}

	public override bool _FtkgwdC8WFI2MScrIMNR7rWyFYF(Type objectType)
	{
		return objectType == typeof(Color);
	}

	static JObject smethod_0()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new JObject();
	}

	static JToken smethod_1(JsonReader jsonReader_0)
	{
		return JToken.ReadFrom(jsonReader_0);
	}

	static JToken smethod_2(JToken jtoken_0, object object_0)
	{
		return jtoken_0.get_Item(object_0);
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
