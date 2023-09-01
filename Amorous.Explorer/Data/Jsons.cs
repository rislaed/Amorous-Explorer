using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Amorous.Explorer.Data;

public static class Jsons
{
	private static readonly JsonSerializerSettings DefaultSettings = new JsonSerializerSettings
	{
		TypeNameHandling = TypeNameHandling.Auto,
		Converters = { new ColorJsonConverter() }
	};

	public static string ToPropertyName(this JToken token) => (token as JProperty ?? token.Parent as JProperty)?.Name ?? (
		(token as JArray ?? token.Parent as JArray) is JArray array ? $"Item {array.IndexOf(token) + 1}" : (token as JConstructor ?? token.Parent as JConstructor)?.Name
	);
	public static string SerializeObject(object value) => JsonConvert.SerializeObject(value, DefaultSettings);
	public static string SerializeObject(object value, Formatting formatting) => JsonConvert.SerializeObject(value, formatting, DefaultSettings);
	public static string SerializeObject(object value, Type type) => JsonConvert.SerializeObject(value, type, DefaultSettings);
	public static string SerializeObject(object value, Type type, Formatting formatting) => JsonConvert.SerializeObject(value, type, formatting, DefaultSettings);
	public static T DeserializeAnonymousType<T>(string value, T anonymousTypeObject) => JsonConvert.DeserializeAnonymousType<T>(value, anonymousTypeObject, DefaultSettings);
	public static object DeserializeObject(string value) => JsonConvert.DeserializeObject(value, DefaultSettings);
	public static T DeserializeObject<T>(string value) => JsonConvert.DeserializeObject<T>(value, DefaultSettings);
	public static object DeserializeObject(string value, Type type) => JsonConvert.DeserializeObject(value, type, DefaultSettings);
	public static JToken FromObject(object value, out JsonSerializer serializer) => JToken.FromObject(value, serializer = JsonSerializer.CreateDefault(DefaultSettings));
	public static JToken FromObject(object value) => FromObject(value, out var serializer);
	public static object ToExtendedObject(this JToken token, Type objectType) => token.ToObject(objectType, JsonSerializer.CreateDefault(DefaultSettings));
	public static T ToExtendedObject<T>(this JToken token) => token.ToObject<T>(JsonSerializer.CreateDefault(DefaultSettings));
	public static string ToExtendedString(this JToken token, Formatting formatting) => token.ToString(formatting, new ColorJsonConverter());
	public static string ToExtendedString(this JToken token) => token.ToExtendedString(Formatting.Indented);
	public static string ToMermaidString(string source) => JsonConvert.ToString(source.Replace("\"", "\\u0022"), '"', StringEscapeHandling.EscapeNonAscii);
}
