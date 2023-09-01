using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Amorous.Explorer.Data;
using Amorous.Explorer.GUI.Model;
using Amorous.Explorer.GUI.Prototype;
using Amorous.Explorer.GUI.View;
using Amorous.Explorer.GUI.View.Inherits;
using Amorous.Explorer.Reflection;
using Microsoft.Xna.Framework;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using Squid;

namespace Amorous.Explorer.GUI.Json;

public delegate void JsonApplyEvent(JsonContainer container, object value);

public class JsonContainer : AbstractContainer<PanelFragment, object>
{
	public static int TokenShortLength { get; internal set; } = 5;
	public static int TokenPagerLength { get; internal set; } = 20;
	public static int CarouselEnumLimit { get; internal set; } = 4;

	public override PanelFragment Fragment { get; protected set; } = new PanelFragment()
	{
		Padding = new Margin(8)
	};
	public virtual IDictionary<string, JsonProperty> Properties { get; set; } = new LinkedDictionary<string, JsonProperty>();

	protected static JTokenType[] JPrimitives = new JTokenType[]
	{
		JTokenType.Comment,
		JTokenType.Integer,
		JTokenType.Float,
		JTokenType.String,
		JTokenType.Boolean,
		JTokenType.Null,
		JTokenType.Undefined
	};

	public virtual string Title { get; set; } = "Inspect Token";
	protected bool ExcludedSubtree { get; set; }
	public JToken Token { get; protected set; }
	public JToken Subtoken { get; protected set; }
	public JsonSerializer Serializer { get; protected set; }
	public Type Contract { get; protected set; }
	public JsonApplyEvent OnApply { get; set; }

	protected IList<IJsonPropertyFragment> AfterSubtokenBools { get; set; } = new List<IJsonPropertyFragment>();
	protected IList<IJsonPropertyFragment> AfterSubtokenLinks { get; set; } = new List<IJsonPropertyFragment>();

	public JsonContainer(AbstractDesktop desktop = null) : base(desktop) {}

	private JToken subtoken;

	public override void Provide(object data)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (Data == data && Token != null)
		{
			InternalSwitchToSubtoken(Subtoken ?? Token);
			return;
		}
		base.Provide(data);
		if (data is JToken token)
		{
			Provide(token, JsonSerializer.CreateDefault());
			return;
		}
		Provide(Jsons.FromObject(data, out var serializer), serializer, data.GetType());
	}

	protected virtual void Provide(JToken token, JsonSerializer serializer = null, Type contract = null)
	{
		Contract = contract ?? ContractOf(token.Path)?.CreatedType;
		Serializer = serializer ?? Serializer;
		SwitchToSubtoken(Token = token);
	}

	public void SwitchToSubtoken(JToken token)
	{
		if (this[token.Path] is IJsonPropertyFragment)
		{
			if ((token = RerouteSubtoken(token)) == null)
			{
				return;
			}
		}
		if (IsAttached)
		{
			foreach (IJsonPropertyFragment property in Fragments.OfType<IJsonPropertyFragment>())
			{
				property.Sync();
			}
			subtoken = token;
			Reattach();
		}
		else
		{
			InternalSwitchToSubtoken(token);
		}
	}

	public virtual void SwitchToSubtoken(string href)
	{
		if (Token == null)
		{
			throw new ArgumentException("Token is null!");
		}
		JToken token = Token;
		if (href != ".")
		{
			try
			{
				token = token.SelectToken(href, errorWhenNoMatch: true);
			}
			catch (JsonException ex)
			{
				Logger.Error(ex.ToString());
				return;
			}
		}
		SwitchToSubtoken(token);
	}

	protected virtual void InternalSwitchToSubtoken(JToken token)
	{
		Fragment.Clear();
		AfterSubtokenBools.Clear();
		AfterSubtokenLinks.Clear();
		ExcludedSubtree = false;
		BeforeSwitchToSubtoken(token);
		InspectToken(Subtoken = token);
		if (AfterSubtokenBools.Count > 0)
		{
			this["After Subtoken Bools Separator"] = new AmorousSeparator();
			foreach (IJsonPropertyFragment fragment in AfterSubtokenBools)
			{
				this[fragment.Token.Path] = fragment;
			}
		}
		if (AfterSubtokenLinks.Count > 0)
		{
			this["After Subtoken Links Separator"] = new AmorousSeparator();
			foreach (IJsonPropertyFragment fragment in AfterSubtokenLinks)
			{
				this[fragment.Token.Path] = fragment;
			}
		}
		AfterSwitchToSubtoken(token);
	}

	protected virtual JToken RerouteSubtoken(JToken token)
	{
		if (token is JProperty property)
		{
			token = property.Value;
		}
		if (token is JArray array && array.Count <= TokenPagerLength)
		{
			if (IsGenericArray(array) && IsPrimitiveArray(array))
			{
				return token;
			}
			return array.First;
		}
		return token;
	}

	protected override void InternalReattach(IControlContainer container = null, object data = null, IFragment fragment = null)
	{
		if (subtoken != null)
		{
			InternalSwitchToSubtoken(subtoken);
			subtoken = null;
		}
	}

	protected virtual void BeforeSwitchToSubtoken(JToken token)
	{
		Label label = new HighlightLabel()
		{
			Dock = DockStyle.Top,
			TextWrap = true,
			BBCodeEnabled = true,
			AutoSize = AutoSize.Vertical,
			Margin = new Margin(5, 0, 0, 0),
			HightlightColor = ColorInt.ARGB(1f, 0.258f, 0.458f, 0.738f),
			Text = GetLink(token.Path, Title)
		};
		label.LinkClicked += (href) => SwitchToSubtoken(href);
		this["Navigation Title"] = label;
	}

	protected virtual void AfterSwitchToSubtoken(JToken token)
	{
		this["Separator Before Pager"] = new AmorousSeparator();
		PagerApplyControl pager = new PagerApplyControl();
		pager.Button.MouseClick += (control, eventArgs) => Apply();
		pager.TurnLeft.MouseClick += (control, eventArgs) => TurnLeft(token, token.Parent);
		pager.TurnRight.MouseClick += (control, eventArgs) => TurnRight(token, token.Parent);
		if (token.Parent is JArray array)
		{
			pager.TurnLeft.Visible = pager.TurnRight.Visible = true;
			int index = array.IndexOf(token);
			pager.TurnLeft.Enabled = index > 0;
			pager.TurnRight.Enabled = index < array.Count - 1;
		}
		else
		{
			pager.TurnLeft.Visible = pager.TurnRight.Visible = false;
		}
		this["Apply Pager"] = pager;
		this["Overscroller After Pager"] = new AmorousSeparator();
	}

	public void Apply()
	{
		foreach (IJsonPropertyFragment property in Fragments.OfType<IJsonPropertyFragment>())
		{
			property.Sync();
		}
		if (Contract != null)
		{
			InternalApply(Data = Token.ToExtendedObject(Contract));
		}
		else
		{
			InternalApply(Token);
		}
		Reattach();
	}

	protected virtual void InternalApply(object value) => OnApply?.Invoke(this, value);

	protected virtual void TurnLeft(JToken token, JContainer container)
	{
		if (container == null)
		{
			return;
		}
		if (container is IList<JToken> list)
		{
			int index = list.IndexOf(token);
			if (index <= 0)
			{
				return;
			}
			SwitchToSubtoken(list[index - 1]);
		}
	}

	protected virtual void TurnRight(JToken token, JContainer container)
	{
		if (container == null)
		{
			return;
		}
		if (container is IList<JToken> list)
		{
			int index = list.IndexOf(token);
			if (index >= list.Count - 1)
			{
				return;
			}
			SwitchToSubtoken(list[index + 1]);
		}
	}

	protected virtual void InspectToken(JToken token)
	{
		if (token is JProperty property)
		{
			token = property.Value;
		}
		if (token is JValue value)
		{
			InspectValue(value);
		}
		else if (token is JObject obj)
		{
			InspectObject(obj);
		}
		else if (token is JArray array)
		{
			InspectArray(array);
		}
		else
		{
			throw new ArgumentException($"Unsupported token {token?.GetType().Name ?? "null"}!");
		}
		if (this[token.Path] is IJsonPropertyFragment fragment)
		{
			ApplyProperties(token, fragment);
		}
	}

	protected virtual void ApplyProperties(JToken token, IJsonPropertyFragment fragment)
	{
		foreach (KeyValuePair<string, JsonProperty> pair in Properties)
		{
			try
			{
				if (token.Path == pair.Key || Regex.IsMatch(token.Path, pair.Key))
				{
					fragment.Apply(pair.Value);
				}
			}
			catch
			{
			}
		}
		if (fragment is BoolPropertyFragment)
		{
			AfterSubtokenBools.Add(fragment);
		}
		else if (fragment is LinkPropertyFragment)
		{
			AfterSubtokenLinks.Add(fragment);
		}
		else
		{
			return;
		}
		Fragment.Remove(token.Path);
	}

	protected virtual void InspectObject(JObject obj)
	{
		JsonContract contract = ContractOf(obj.Path);
		if (contract != null && contract.CreatedType == typeof(Color))
		{
			InspectColor(obj, contract);
			return;
		}
		if (!IsShortObject(obj))
		{
			if (ExcludedSubtree)
			{
				InspectLink(obj);
				return;
			}
			ExcludedSubtree = true;
		}
		foreach (JProperty property in obj.Properties())
		{
			InspectToken(property);
		}
	}

	protected virtual void InspectArray(JArray array)
	{
		if (!IsShortArray(array))
		{
			if (ExcludedSubtree)
			{
				InspectLink(array);
				return;
			}
			ExcludedSubtree = true;
		}
		if (IsGenericArray(array) && IsPrimitiveArray(array))
		{
			this[array.Path] = new AmorousLabel()
			{
				Text = (array.Parent as JProperty)?.Name ?? array.Path
			};
			foreach (JToken token in array)
			{
				InspectValue(token as JValue, false);
			}
			return;
		}
		foreach (JToken token in array)
		{
			InspectToken(token);
		}
	}

	protected virtual void InspectValue(JValue value, bool requiresLabel = true)
	{
		JsonContract contract = ContractOf(value.Path);
		if (contract == null || !InspectValue(value, contract))
		{
			switch (value.Type)
			{
				case JTokenType.Comment:
				case JTokenType.String:
					InspectText(value, contract);
					break;
				case JTokenType.Integer:
				case JTokenType.Float:
					if (value.Value?.GetType().IsEnum ?? false)
					{
						InspectEnum(value, contract);
					}
					else
					{
						InspectNumber(value, contract);
					}
					break;
				case JTokenType.Boolean:
					InspectBool(value, contract);
					break;
			}
		}
		if (this[value.Path] is IJsonPropertyFragment property)
		{
			if (property.RequiresLabel)
			{
				property.RequiresLabel = requiresLabel;
			}
		}
	}

	protected virtual bool InspectValue(JValue value, JsonContract contract)
	{
		if (contract.CreatedType.IsEnum)
		{
			InspectEnum(value, contract);
		}
		else
		{
			TypeCode code = Type.GetTypeCode(contract.CreatedType);
			switch (code)
			{
				case TypeCode.Char:
				case TypeCode.SByte:
				case TypeCode.Byte:
				case TypeCode.Int16:
				case TypeCode.UInt16:
				case TypeCode.Int32:
				case TypeCode.UInt32:
				case TypeCode.Int64:
				case TypeCode.UInt64:
				case TypeCode.Single:
				case TypeCode.Double:
				case TypeCode.Decimal:
					InspectNumber(value, contract);
					break;
				case TypeCode.Empty:
				case TypeCode.DBNull:
				case TypeCode.String:
				case TypeCode.DateTime:
					InspectText(value, contract);
					break;
				case TypeCode.Boolean:
					InspectBool(value, contract);
					break;
				default:
					return false;
			}
		}
		return true;
	}

	protected virtual void InspectEnum(JToken token, JsonContract contract)
	{
		this[token.Path] = new EnumPropertyFragment(token)
		{
			Contract = contract
		};
	}

	protected virtual void InspectNumber(JToken token, JsonContract contract)
	{
		this[token.Path] = new NumberPropertyFragment(token)
		{
			Contract = contract
		};
	}

	protected virtual void InspectText(JToken token, JsonContract contract)
	{
		this[token.Path] = new TextPropertyFragment(token)
		{
			Contract = contract
		};
	}

	protected virtual void InspectBool(JToken token, JsonContract contract)
	{
		this[token.Path] = new BoolPropertyFragment(token)
		{
			Contract = contract
		};
	}

	protected virtual void InspectColor(JToken token, JsonContract contract)
	{
		this[token.Path] = new ColorPropertyFragment(token)
		{
			Contract = contract
		};
	}

	protected virtual void InspectLink(JToken token)
	{
		this[token.Path] = new LinkPropertyFragment(token);
	}

	protected static Queue GetConstraint(string path)
	{
		Queue queue = new Queue();
		StringBuilder stroke = new StringBuilder();
		bool quoted = false, escaped = false;
		int depth = 0;
		foreach (char character in path.ToCharArray())
		{
			if (quoted)
			{
				if (character == '\\')
				{
					escaped = !escaped;
					continue;
				}
				else if (escaped || character != '\'')
				{
					stroke.Append(character);
					escaped = false;
					continue;
				}
			}
			else if (character == '\'')
			{
				quoted = true;
				continue;
			}
			else if (!(character == '.' || character == '[' || character == ']'))
			{
				stroke.Append(character);
				continue;
			}
			if (stroke.Length > 0)
			{
				string key = stroke.ToString();
				queue.Enqueue(quoted || depth <= 0 ? key : Convert.ToInt32(key));
				stroke.Clear();
			}
			if (character == ']')
			{
				depth--;
			}
			else if (character == '[')
			{
				depth++;
			}
			quoted = escaped = false;
		}
		if (stroke.Length > 0)
		{
			queue.Enqueue(stroke.ToString());
		}
		stroke.Clear();
		return queue;
	}

	protected static string GetLink(string path, string home = null)
	{
		StringBuilder stroke = new StringBuilder();
		char[] chars = path.ToCharArray();
		bool bracket = false;
		string entry = "";
		for (int i = 0; i < chars.Length; i++)
		{
			char character = chars[i];
			if (!(bracket || character == '.' || character == '['))
			{
				entry += character;
				if (character == ']')
				{
					bracket = true;
				}
				continue;
			}
			if (entry.Length > 0)
			{
				stroke.Append($"<a href=\"{path.Substring(0, i)}\">{entry}</a>");
				entry = "";
			}
			if (character == '.')
			{
				stroke.Append(character);
			}
			else if (bracket || character == '[')
			{
				entry += character;
			}
			bracket = false;
		}
		if (entry.Length > 0)
		{
			stroke.Append(entry);
		}
		home = string.IsNullOrEmpty(home) ? "..." : home;
		if (stroke.Length > 0)
		{
			return $"<a href=\".\">{home}</a> > {stroke.ToString()}";
		}
		return home;
	}

	public JsonContract ContractOf(string path)
	{
		if (Data == null)
		{
			throw new ArgumentException("Data is null!");
		}
		Queue constraint = GetConstraint(path);
		JsonContract contract = Serializer.ContractResolver.ResolveContract(Contract);
		while (constraint.Count > 0)
		{
			object key = constraint.Dequeue();
			if (contract is JsonArrayContract array)
			{
				if (array.CollectionItemType == null)
				{
					return null;
				}
				if (array.IsMultidimensionalArray)
				{
					for (int i = 0; i < array.CreatedType.GetArrayRank(); i++)
					{
						if (!(constraint.Peek() is int))
						{
							return null;
						}
						constraint.Dequeue();
					}
				}
				contract = Serializer.ContractResolver.ResolveContract(array.CollectionItemType);
			}
			else if (contract is JsonDictionaryContract dictionary)
			{
				if (dictionary.DictionaryValueType == null)
				{
					return null;
				}
				contract = Serializer.ContractResolver.ResolveContract(dictionary.DictionaryValueType);
			}
			else if (contract is JsonContainerContract container)
			{
				JsonPropertyCollection properties = (contract as JsonObjectContract)?.Properties;
				if (properties == null)
				{
					properties = (contract as JsonDynamicContract)?.Properties;
					if (properties == null)
					{
						return null;
					}
				}
                Newtonsoft.Json.Serialization.JsonProperty property = properties.GetClosestMatchProperty(key.ToString());
				if (property == null || property.PropertyType == null)
				{
					return null;
				}
				contract = Serializer.ContractResolver.ResolveContract(property.PropertyType);
			}
			else if (constraint.Count > 0)
			{
				throw new ArgumentOutOfRangeException("Constraint not yet completed during constructor reinvestigation, try to validate path!");
			}
		}
		return contract;
	}

	public JsonContract ContractOfContainer(JToken token)
	{
		if (token == null)
		{
			return null;
		}
		string path = token.Path;
		while (!string.IsNullOrEmpty(path) && token != null && path == (path = token.Path))
		{
			token = token.Parent;
		}
		return ContractOf(path ?? string.Empty);
	}

	public static bool IsGenericObject(JObject obj)
	{
		if (obj == null || obj.Count == 0 || !(obj.First is JProperty first))
		{
			return false;
		}
		JTokenType type = first.Value?.Type ?? JTokenType.None;
		foreach (JProperty property in obj.Properties())
		{
			if (property.Value?.Type != type)
			{
				return false;
			}
		}
		return true;
	}

	public static bool IsGenericArray(JArray array)
	{
		if (array == null || array.Count == 0)
		{
			return false;
		}
		JTokenType type = array.First?.Type ?? JTokenType.None;
		foreach (JToken token in array)
		{
			if (token.Type != type)
			{
				return false;
			}
		}
		return true;
	}

	public static bool IsPrimitiveObject(JObject obj)
	{
		if (obj == null || obj.Count == 0)
		{
			return false;
		}
		foreach (JProperty property in obj.Properties())
		{
			if (property.Value == null || Array.BinarySearch(JPrimitives, property.Value.Type) < 0)
			{
				return false;
			}
		}
		return false;
	}

	public static bool IsPrimitiveArray(JArray array)
	{
		if (array == null || array.Count == 0)
		{
			return false;
		}
		foreach (JToken token in array)
		{
			if (Array.BinarySearch(JPrimitives, token.Type) < 0)
			{
				return false;
			}
		}
		return true;
	}

	public static bool IsShortObject(JObject obj)
		=> obj != null && (obj.Count == 0 || (
			obj.Count <= TokenShortLength && IsPrimitiveObject(obj)
		));

	public static bool IsShortArray(JArray array)
		=> array != null && (array.Count == 0 || (
			array.Count <= TokenShortLength && IsPrimitiveArray(array)
		));
}
