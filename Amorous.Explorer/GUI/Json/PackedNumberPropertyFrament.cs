using System;
using Amorous.Explorer.GUI.Model;
using Amorous.Explorer.GUI.Prototype;
using Newtonsoft.Json.Linq;
using Squid;

namespace Amorous.Explorer.GUI.Json;

public class PackedNumberJsonProperty : JsonProperty
{
	public byte[] Exponents { get; set; }
}

public class PackedNumberPropertyFragment : JsonPropertyFragment<PackedNumberJsonProperty>
{
	public byte[] Exponents { get; set; } = new byte[0];

	protected CarouselPanelFragment Carousel => this["carousel"] as CarouselPanelFragment;

	public PackedNumberPropertyFragment(JToken token, AbstractDesktop desktop = null) : base(token, desktop)
	{
		ThrowIfValueNotPresent();
	}

	public PackedNumberPropertyFragment(JToken token, byte[] exponents, AbstractDesktop desktop = null) : this(token, desktop)
	{
		Exponents = exponents;
	}

	protected override void InternalConstructLayout()
	{
		base.InternalConstructLayout();
		long value = Convert.ToInt64(Value.Value);
		Frame.Visible = Exponents.Length > 0;
		CarouselPanelFragment carousel = new CarouselPanelFragment();
		byte offset = 0;
		foreach (byte exponent in Exponents)
		{
			long maximum = (1 << exponent) - 1;
			carousel[$"exponent{offset}"] = new NumberPropertyFragment((value >> offset) & maximum)
			{
				Dock = DockStyle.Left,
				Tag = offset, 
				Unlinked = true,
				Nullable = false,
				UseText = true,
				Minimum = 0,
				Maximum = maximum
			};
			offset += exponent;
		}
		this["carousel"] = carousel;
	}

	protected override void InternalApply(PackedNumberJsonProperty properties)
	{
		Exponents = properties.Exponents ?? Exponents;
	}

	protected override JToken Sync(JContainer container, object key)
	{
		long value = 0;
		foreach (IFragment fragment in Carousel.Fragments)
		{
			if (fragment is IJsonPropertyFragment property)
			{
				property.Sync();
				value += ((long)property.Token) << ((byte)property.Tag);
			}
		}
		return value;
	}
}
