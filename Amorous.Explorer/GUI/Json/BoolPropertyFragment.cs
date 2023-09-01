using System;
using Amorous.Explorer.GUI.Prototype;
using Amorous.Explorer.GUI.View.Inherits;
using Newtonsoft.Json.Linq;
using Squid;

namespace Amorous.Explorer.GUI.Json;

public class BoolJsonProperty : JsonProperty
{
}

public class BoolPropertyFragment : JsonPropertyFragment<BoolJsonProperty>
{
	protected Button Button => this["button"] as Button;

	public BoolPropertyFragment(JToken token, AbstractDesktop desktop = null) : base(token, desktop)
	{
		ThrowIfValueNotPresent();
		RequiresLabel = false;
		Nullable = UnderlyingType != CreatedType;
	}

	protected override void InternalConstructLayout()
	{
		base.InternalConstructLayout();
		Button button = new AmorousButton()
		{
			Style = Nullable && Value.Value == null ? "buttonOpaque" : "buttonOpaqueSwitch",
			CheckOnClick = true,
			Text = Name,
			Checked = Convert.ToBoolean(Value.Value)
		};
		button.CheckedChanged += CheckedChanged;
		this["button"] = button;
	}

	protected virtual void CheckedChanged(Control control)
	{
		if (control is ICheckable checkable && checkable.Checked && Nullable)
		{
			if (control.Style == "buttonOpaqueSwitch")
			{
				control.Style = "buttonOpaque";
				checkable.Checked = false;
			}
			else
			{
				control.Style = "buttonOpaqueSwitch";
			}
		}
	}

	protected override void InternalApply(BoolJsonProperty properties)
	{
	}

	protected override JToken Sync(JContainer container, object key)
	{
		return Nullable && Button.Style == "buttonOpaque" ? null : Button.Checked;
	}
}
