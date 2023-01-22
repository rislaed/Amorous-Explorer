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
		Color val = (Color)value;
		JObject obj = _VSQz6uDf5A6KqE8xqKxxcrkhZkA.smethod_0();
		obj.set_Item("B", JToken.op_Implicit(((Color)(ref val)).get_B()));
		obj.set_Item("G", JToken.op_Implicit(((Color)(ref val)).get_G()));
		obj.set_Item("R", JToken.op_Implicit(((Color)(ref val)).get_R()));
		obj.set_Item("A", JToken.op_Implicit(((Color)(ref val)).get_A()));
		JObject val2 = obj;
		((JToken)val2).WriteTo(writer, (JsonConverter[])(object)new JsonConverter[0]);
	}

	public override object _YLNjFZnbxagddA6Iuw9uqVAxcSg(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		Color val = default(Color);
		JToken val2 = _VSQz6uDf5A6KqE8xqKxxcrkhZkA.smethod_1(reader);
		while (true)
		{
			int num = -1464308876;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCF837BB8u) % 5u)
				{
				case 4u:
					((Color)(ref val)).set_B((byte)Extensions.Value<int>((IEnumerable<JToken>)val2.get_Item((object)"B")));
					num = (int)((num2 * 141588232) ^ 0x3DC2777);
					continue;
				case 2u:
					((Color)(ref val)).set_R((byte)Extensions.Value<int>((IEnumerable<JToken>)_VSQz6uDf5A6KqE8xqKxxcrkhZkA.smethod_2(val2, (object)"R")));
					((Color)(ref val)).set_G((byte)Extensions.Value<int>((IEnumerable<JToken>)val2.get_Item((object)"G")));
					num = (int)(num2 * 657889368) ^ -350813811;
					continue;
				case 1u:
					((Color)(ref val)).set_A((byte)Extensions.Value<int>((IEnumerable<JToken>)val2.get_Item((object)"A")));
					num = ((int)num2 * -659823000) ^ -1287603400;
					continue;
				case 0u:
					break;
				default:
					return val;
				}
				break;
			}
		}
	}

	public override bool _FtkgwdC8WFI2MScrIMNR7rWyFYF(Type objectType)
	{
		return _VSQz6uDf5A6KqE8xqKxxcrkhZkA.smethod_4(objectType, _VSQz6uDf5A6KqE8xqKxxcrkhZkA.smethod_3(typeof(Color).TypeHandle));
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
