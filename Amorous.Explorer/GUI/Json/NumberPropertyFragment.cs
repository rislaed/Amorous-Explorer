using System;
using Amorous.Explorer.GUI.Model;
using Amorous.Explorer.GUI.Prototype;
using Amorous.Explorer.GUI.View.Inherits;
using Newtonsoft.Json.Linq;
using Squid;

namespace Amorous.Explorer.GUI.Json;

public class NumberJsonProperty : JsonProperty
{
	public float? Minimum { get; set; }
	public float? Maximum { get; set; }
	public float? Steps { get; set; }
	public float? Multiplier { get; set; }
	public bool? UseText { get; set; }
}

public class NumberPropertyFragment : JsonPropertyFragment<NumberJsonProperty>
{
	public float? Minimum { get; set; }
	public float DefaultMinimum { get; set; } = 0f;
	public float? Maximum { get; set; }
	public float DefaultMaximum { get; set; } = 100f;
	public float? Steps { get; set; }
	public float DefaultSteps { get; set; } = 10f;
	public float? Multiplier { get; set; }
	public bool UseText { get; set; }
	protected float? ParsedValue { get; set; }
	protected bool InternallyChanging { get; set; }

	protected Slider Slider => this["slider"] as Slider;
	protected TextBox TextBox => this["box"] as TextBox;

	public NumberPropertyFragment(JToken token, AbstractDesktop desktop = null) : base(token, desktop)
	{
		ThrowIfValueNotPresent();
	}

	protected override void InternalConstructLayout()
	{
		base.InternalConstructLayout();
		ParsedValue = Nullable && Value.Value == null ? null : Convert.ToSingle(Value.Value);
		if (Multiplier.HasValue && ParsedValue != null)
		{
			ParsedValue /= Multiplier.Value;
		}
		InternallyChanging = true;
		if (!UseText && (ParsedValue == null || Steps.HasValue || (Minimum <= ParsedValue && Maximum >= ParsedValue)))
		{
			Slider slider = new AmorousSlider()
			{
				Minimum = Minimum ?? DefaultMinimum,
				Maximum = Maximum ?? DefaultMaximum,
				Steps = Steps ?? DefaultSteps,
				Value = ParsedValue ?? 0f
			};
			slider.Button.MouseDoubleClick += (control, eventArgs) => MouseDoubleClick(slider, eventArgs);
			slider.ValueChanged += ValueChanged;
			this["slider"] = slider;
			ValueChanged(slider);
		}
		else
		{
			TextBox box = new AmorousTextBox()
			{
				Mode = TextBoxMode.Numeric
			};
			box.MouseDoubleClick += MouseDoubleClick;
			box.TextChanged += TextChanged;
			box.Text = ParsedValue?.ToString();
			this["box"] = box;
		}
		InternallyChanging = false;
	}

	protected virtual void TextChanged(Control control)
	{
		if (!InternallyChanging && control is TextBox box)
		{
			box.Style = "textbox";
			if (float.TryParse(box.Text, out var value))
			{
				ParsedValue = value;
				if (ParsedValue.HasValue)
				{
					if (Minimum.HasValue && Minimum.Value > ParsedValue.Value)
					{
						ParsedValue = Minimum;
					}
					else if (Maximum.HasValue && Maximum.Value < ParsedValue.Value)
					{
						ParsedValue = Maximum;
					}
					else
					{
						return;
					}
					InternallyChanging = true;
					box.Text = ParsedValue?.ToString();
					InternallyChanging = false;
				}
			}
			else if (Nullable && string.IsNullOrEmpty(box.Text))
			{
				ParsedValue = null;
			}
			else
			{
				box.Style = "textboxLocked";
			}
		}
	}

	protected virtual void ValueChanged(Control control)
	{
		if (!InternallyChanging && control is Slider slider)
		{
			ParsedValue = slider.Value;
			slider.Button.Style = "scrollSliderButton";
		}
		if (CategoryLabel is Label label)
		{
			string value = ParsedValue?.ToString() ?? "null";
			label.Text = string.IsNullOrEmpty(Name) ? value : $"{Name} = {value}";
		}
	}

	protected virtual void MouseDoubleClick(Control control, MouseEventArgs eventArgs)
	{
		if (Nullable)
		{
			ParsedValue = null;
			InternallyChanging = true;
			if (control is Slider slider)
			{
				slider.Button.Style = "sliderButton";
				ValueChanged(slider);
			}
			else if (control is TextBox box)
			{
				box.Text = string.Empty;
			}
			InternallyChanging = false;
		}
	}

	protected override void InternalApply(NumberJsonProperty properties)
	{
		Minimum = properties.Minimum ?? Minimum;
		Maximum = properties.Maximum ?? Maximum;
		Steps = properties.Steps ?? Steps;
		Multiplier = properties.Multiplier ?? Multiplier;
		UseText = properties.UseText ?? UseText;
	}

	protected override JToken Sync(JContainer container, object key)
	{
		return Multiplier.HasValue ? Multiplier.Value * ParsedValue : ParsedValue;
	}
}
