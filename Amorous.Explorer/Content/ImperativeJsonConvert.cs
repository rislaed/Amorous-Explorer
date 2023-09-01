using System.Linq;
using System.Reflection;
using Microsoft.Xna.Framework.Content;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Amorous.Explorer.Content;

public static class ImperativeJsonConvert
{
	sealed class ImperativeContractResolver : DefaultContractResolver
	{
		protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
		{
			JsonProperty property = base.CreateProperty(member, memberSerialization);
			if (member.GetCustomAttributes(true).FirstOrDefault(
				(what) => typeof(ContentSerializerIgnoreAttribute).IsAssignableFrom(what.GetType())
			) != null)
			{
				property.ShouldSerialize = (what) => false;
			}
			return property;
		}
	}

	private static readonly JsonSerializerSettings SERIALIZER_SETTINGS = new JsonSerializerSettings
	{
		ContractResolver = new ImperativeContractResolver(),
		Converters = {
			new RectangleJsonConverter(),
			new ColorJsonConverter()
		}
	};

	public static string SerializeObject(object asset)
	{
		return JsonConvert.SerializeObject(asset, SERIALIZER_SETTINGS);
	}
}
