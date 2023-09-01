using System;
using Amorous.Explorer.Data;
using Amorous.Explorer.GUI.Model;
using Amorous.Explorer.GUI.Prototype;
using Amorous.Explorer.GUI.View.Inherits;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using Squid;

namespace Amorous.Explorer.GUI.Json;

public class JsonProperty
{
	public string Name { get; set; }
	public bool? Nullable { get; set; }
	public bool? Disabled { get; set; }
	public bool? Unlinked { get; set; }
	public JsonContract Contract { get; set; }
}

public interface IJsonPropertyFragment : IFragment
{
	JToken Token { get; }
	JValue Value { get; }
	JProperty Property { get; }
	string Name { get; set; }
	Type CreatedType { get; }
	Type UnderlyingType { get; }
	JsonContract Contract { get; set; }
	bool RequiresLabel { get; set; }
	bool Nullable { get; set; }
	bool Disabled { get; set; }
	bool Unlinked { get; set; }
	void Apply(JsonProperty properties);
	void Sync();
}

public abstract class JsonPropertyFragment<TProperty> : FrameFragment, IJsonPropertyFragment where TProperty : JsonProperty
{
	public JToken Token { get; private set; }
	public JValue Value => Token as JValue;
	public JProperty Property => Token.Parent as JProperty;
	public string Name
	{
		get => name ?? Token.ToPropertyName() ?? Token.Path;
		set => name = value;
	}
	public Type CreatedType => Contract?.CreatedType;
	public Type UnderlyingType => Contract?.UnderlyingType;
	public JsonContract Contract
	{
		get => contract == null ? (contract = JsonContainer?.ContractOf(Token.Path)) : contract;
		set => contract = value;
	}
	public bool RequiresLabel { get; set; } = true;
	public bool Nullable { get; set; } = true;
	public bool Disabled { get; set; }
	public bool Unlinked { get; set; }

	protected Label CategoryLabel => this["label"] as Label;
	protected JsonContainer JsonContainer => this.GetContainer() as JsonContainer;

	public JsonPropertyFragment(JToken token, AbstractDesktop desktop = null) : base(desktop)
	{
		if (token is JProperty property)
		{
			token = property.Value;
		}
		if (token == null)
		{
			throw new ArgumentNullException("token");
		}
		Token = token;
		Frame.Enabled = false;
	}

	private string name;
	private JsonContract contract;

	protected override void InternalPrepareToAttach()
	{
		base.Clear();
		InternalConstructLayout();
		base.InternalPrepareToAttach();
	}

	protected virtual void InternalConstructLayout()
	{
		if (RequiresLabel && Name.Length > 0)
		{
			this["label"] = new AmorousLabel()
			{
				Text = Name.ToPersonReadable()
			};
		}
	}

	protected void ThrowIfValueNotPresent()
	{
		if (Value == null)
		{
			throw new ArgumentException($"Unsupported token of type {Token.Type}, it must be JProperty or JValue.");
		}
	}

	protected void ThrowIfContractNotPresent()
	{
		if (Contract == null)
		{
			throw new ArgumentException($"Unable to determine contract of present type in token {Token.Type.ToString()}.");
		}
	}

	public void Apply(JsonProperty properties)
	{
		if (properties is TProperty property)
		{
			Name = properties.Name ?? Name;
			Contract = properties.Contract ?? Contract;
			Nullable = properties.Nullable ?? Nullable;
			Disabled = properties.Disabled ?? Disabled;
			Unlinked = properties.Unlinked ?? Unlinked;
			InternalApply(properties: property);
		}
	}

	protected override void InternalAttach()
	{
		base.InternalAttach();
		Frame.Enabled = !Disabled;
	}

	protected abstract void InternalApply(TProperty properties);

	public void Sync()
	{
		if (!Frame.Enabled)
		{
			return;
		}
		if (Unlinked || Token is JContainer)
		{
			Token = Sync(Token as JContainer, null);
		}
		else if (Token.Parent is JArray array)
		{
			int index = array.IndexOf(Token);
			if (index == -1)
			{
				throw new IndexOutOfRangeException();
			}
			array[index] = Token = Sync(array, index);
		}
		else if (Token.Parent is JProperty property)
		{
			if (property.Parent is JObject obj)
			{
				obj[property.Name] = Token = Sync(obj, property.Name);
			}
			else
			{
				throw new InvalidOperationException();
			}
		}
		else
		{
			if (Token.Parent == null)
			{
				Logger.Warning($"Unlinked node {Name}::{Token.Type.ToString()} cannot be synced! Make sure parent exists or apply 'Unlinked' to true.");
				return;
			}
			throw new InvalidOperationException();
		}
		if (Token == null)
		{
			throw new NotSupportedException();
		}
	}

	protected abstract JToken Sync(JContainer container, object key);
}
