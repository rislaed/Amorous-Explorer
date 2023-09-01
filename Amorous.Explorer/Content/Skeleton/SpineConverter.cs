using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Newtonsoft.Json.Linq;

namespace Amorous.Explorer.Content.Skeleton;

public static class SpineConverter
{
	public static readonly int[] UpgradeVersion = new int[3] { 3, 8, 75 };
	public static readonly int[] DowngradeVersion = new int[3] { 3, 5, 46 };

	private static int[] ReadSpineVersion(string version)
	{
		return version.Split('.').Select(int.Parse).ToArray();
	}

	private static int CompareSpineVersions(int[] left, int[] right)
	{
		return (left[0] < right[0] || (left[0] == right[0] && left[1] < right[1]) || (left[0] == right[0] && left[1] == right[1] && left[2] < right[2]))
			? -1 : (left[0] == right[0] && left[1] == right[1] && left[2] == right[2]) ? 0 : 1;
	}

	private static void UpgradeAnimationCurves(JToken token, JContainer container = null)
	{
		if (token is JProperty property)
		{
			token = property.Value;
		}
		if (token is JContainer subcontainer)
		{
			if (container != null && subcontainer is JObject data && data.TryGetValue("curve", out var curveData) && curveData is JArray curve)
			{
				if (curve.Count > 0)
				{
					for (int e = 1, l = curve.Count; e < l; e++)
					{
						subcontainer["c" + (e + 1)] = curve[e];
					}
					subcontainer["curve"] = curve[0];
				}
				else
				{
					curveData.Remove();
				}
			}
			else
			{
				foreach (JToken subtoken in subcontainer)
				{
					UpgradeAnimationCurves(subtoken, subcontainer);
				}
			}
		}
	}

	private static void DowngradeAnimationCurves(JToken token, JContainer container = null)
	{
		if (token is JProperty property)
		{
			token = property.Value;
		}
		if (token is JContainer subcontainer)
		{
			if (container != null && subcontainer is JObject data && data.TryGetValue("curve", out var firstSegment))
			{
				Dictionary<int, object> indices = new Dictionary<int, object>();
				int weight = 4;
				foreach (JProperty segment in data.Properties())
				{
					Match match = Regex.Match(segment.Name, "c(\\d{2,}|[2-9])");
					if (match.Value == segment.Name)
					{
						int index = Convert.ToInt32(match.Captures[0]);
						indices[index - 1] = segment.Value;
						if (index > weight)
						{
							weight = index;
						}
					}
				}
				object[] curve = new object[weight];
				curve[0] = firstSegment;
				for (int i = 1; i < weight; i++)
				{
					if (data.TryGetValue($"c{i}", out var segment))
					{
						segment.Remove();
					}
					curve[i] = indices.TryGetValue(i, out var height) ? height : 0;
				}
				subcontainer["curve"] = new JArray(curve);
			}
			else
			{
				foreach (JToken subtoken in subcontainer)
				{
					DowngradeAnimationCurves(subtoken, subcontainer);
				}
			}
		}
	}

	public static JToken Upgrade(string name, JToken token, int[] version)
	{
		if (!(token is JObject data) || !data.TryGetValue("skeleton", out var skeletonData) || !(skeletonData is JObject skeleton))
		{
			throw new ArgumentException("Malformed Spine JSON!");
		}
		int[] mVersion = ReadSpineVersion(skeleton.Value<string>("spine"));
		if (CompareSpineVersions(version, mVersion) <= 0)
		{
			return null;
		}
		skeleton["spine"] = string.Join(".", version);
		if (!skeleton.TryGetValue("images", out var _))
		{
			skeleton["images"] = $"./{name}/";
		}
		if (data.TryGetValue("skins", out var skinData) && skinData is JObject skins)
		{
			JArray skinsArray = new JArray();
			foreach (KeyValuePair<string, JToken> skin in skins)
			{
				if (skin.Value is JObject slots)
				{
					foreach (JToken slot in slots.PropertyValues())
					{
						if (slot is JObject attachments)
						{
							foreach (JToken attachment in attachments.PropertyValues())
							{
								if (attachment is JObject description && description.TryGetValue("type", out var type) && type.Type == JTokenType.String && ((string)type) == "skinnedmesh")
								{
									description["type"] = "mesh";
								}
							}
						}
					}
				}
				skinsArray.Add(
					new JObject()
					{
						["name"] = skin.Key,
						["attachments"] = skin.Value
					}
				);
			}
			data["skins"] = skinsArray;
		}
		if (data.TryGetValue("animations", out var animationData) && animationData is JObject animations)
		{
			UpgradeAnimationCurves(animations);
		}
		return data;
	}

	public static JToken Downgrade(string name, JToken token, int[] version)
	{
		if (!(token is JObject data) || !data.TryGetValue("skeleton", out var skeletonData) || !(skeletonData is JObject skeleton))
		{
			throw new ArgumentException("Malformed Spine JSON!");
		}
		int[] mVersion = ReadSpineVersion(skeleton.Value<string>("spine"));
		if (CompareSpineVersions(version, mVersion) >= 0)
		{
			return null;
		}
		skeleton["spine"] = string.Join(".", version);
		if (data.TryGetValue("skins", out var skinData) && skinData is JArray skins)
		{
			JObject skinsObject = new JObject();
			foreach (JObject skin in skins)
			{
				skinsObject[skin.Value<string>("name")] = skin.Value<JObject>("attachments");
			}
			data["skins"] = skinsObject;
		}
		if (data.TryGetValue("animations", out var animationData) && animationData is JObject animations)
		{
			DowngradeAnimationCurves(animations);
		}
		return data;
	}

	public static JToken Upgrade(string name, JToken token, string version)
	{
		return Upgrade(name, token, ReadSpineVersion(version));
	}

	public static JToken Upgrade(string name, JToken token)
	{
		return Upgrade(name, token, UpgradeVersion);
	}

	public static JToken Downgrade(string name, JToken token, string version)
	{
		return Downgrade(name, token, ReadSpineVersion(version));
	}

	public static JToken Downgrade(string name, JToken token)
	{
		return Downgrade(name, token, DowngradeVersion);
	}
}
