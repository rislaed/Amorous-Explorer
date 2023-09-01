using Amorous.Explorer.GUI.Prototype;
using Amorous.Explorer.GUI.View.Inherits;
using Microsoft.Xna.Framework;
using Newtonsoft.Json.Linq;

namespace Amorous.Explorer.GUI.Json;

public class ColorJsonProperty : JsonProperty
{
}

public class ColorPropertyFragment : JsonPropertyFragment<ColorJsonProperty>
{
	public AmorousColorBox ColorBox => this["box"] as AmorousColorBox;

	public ColorPropertyFragment(JToken token, AbstractDesktop desktop = null) : base(token, desktop)
	{
		RequiresLabel = false;
	}

	protected override void InternalConstructLayout()
	{
		base.InternalConstructLayout();
		Color color = default(Color);
		color.R = (byte)Token["R"].Value<int>();
		color.G = (byte)Token["G"].Value<int>();
		color.B = (byte)Token["B"].Value<int>();
		color.A = (byte)Token["A"].Value<int>();
		this["box"] = new AmorousColorBox()
		{
			Color = color,
			Text = Name
		};
	}

	protected override void InternalDeattach()
	{
		base.InternalDeattach();
		if (ColorBox != null && ColorBox.Picker.Visible)
		{
			ColorBox.Picker.Close();
		}
	}

	protected override void InternalApply(ColorJsonProperty properties)
	{
	}

	protected override JToken Sync(JContainer container, object key)
	{
		container["R"] = ColorBox.Color.R;
		container["G"] = ColorBox.Color.G;
		container["B"] = ColorBox.Color.B;
		container["A"] = ColorBox.Color.A;
		return container;
	}
}
