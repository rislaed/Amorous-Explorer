using System;
using System.Globalization;
using Amorous.Explorer.GUI.Prototype;
using Amorous.Explorer.GUI.View.Inherits;
using Newtonsoft.Json.Linq;
using Squid;

namespace Amorous.Explorer.GUI.Json;

public class TextJsonProperty : JsonProperty
{
	public string Tooltip { get; set; }
	public bool? IsMultiline { get; set; }
	public bool? Whitespaceable { get; set; }
}

public class TextPropertyFragment : JsonPropertyFragment<TextJsonProperty>
{
	public string Tooltip { get; set; }
	public bool IsMultiline
	{
		get => multiline.HasValue ? multiline.Value : Convert.ToString(Value.Value, CultureInfo.InvariantCulture).Contains("\n");
		set => multiline = value;
	}
	public bool Whitespaceable { get; set; } = true;

	protected string ParsedValue { get; set; }
	protected TextBox TextBox => this["box"] as TextBox;
	protected TextArea TextArea => this["area"] as TextArea;

	public TextPropertyFragment(JToken token, AbstractDesktop desktop = null) : base(token, desktop)
	{
		ThrowIfValueNotPresent();
	}

	private bool? multiline;

	protected override void InternalConstructLayout()
	{
		base.InternalConstructLayout();
		ParsedValue = Convert.ToString(Value.Value, CultureInfo.InvariantCulture);
		if (IsMultiline)
		{
			TextArea area = new AmorousTextArea()
			{
				TextWrap = true,
				Tooltip = Tooltip
			};
			area.TextChanged += OnTextChanged;
			area.Text = ParsedValue;
			this["area"] = area;
		}
		else
		{
			TextBox box = new AmorousTextBox()
			{
				Tooltip = Tooltip
			};
			box.TextChanged += OnTextChanged;
			box.Text = ParsedValue;
			this["box"] = box;
		}
	}

	protected virtual void OnTextChanged(Control control)
	{
		if (!(control is IText text))
		{
			return;
		}
		if (Whitespaceable ? string.IsNullOrWhiteSpace(text.Text) : string.IsNullOrEmpty(text.Text))
		{
			if (Nullable)
			{
				ParsedValue = null;
				return;
			}
			control.Style = "textboxLocked";
		}
		else
		{
			ParsedValue = text.Text;
		}
		control.Style = "textbox";
	}

	protected override void InternalApply(TextJsonProperty properties)
	{
		Tooltip = properties.Tooltip ?? Tooltip;
		IsMultiline = properties.IsMultiline ?? IsMultiline;
		Whitespaceable = properties.Whitespaceable ?? Whitespaceable;
	}

	protected override JToken Sync(JContainer container, object key)
	{
		return ParsedValue;
	}
}
