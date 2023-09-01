using System;
using Amorous.Explorer.GUI.Model;
using Amorous.Explorer.GUI.Prototype;
using Newtonsoft.Json.Linq;

namespace Amorous.Explorer.GUI.Json;

public class EnumJsonProperty : JsonProperty
{
}

public class EnumPropertyFragment : JsonPropertyFragment<EnumJsonProperty>
{
	protected CarouselChoiceFragment Carousel => this["carousel"] as CarouselChoiceFragment;
	protected ListFragment List => this["list"] as ListFragment;

	public EnumPropertyFragment(JToken token, AbstractDesktop desktop = null) : base(token, desktop)
	{
		ThrowIfValueNotPresent();
		Nullable = UnderlyingType != CreatedType;
	}

	protected override void InternalConstructLayout()
	{
		ThrowIfContractNotPresent();
		base.InternalConstructLayout();
		string[] names = Enum.GetNames(CreatedType);
		string selectedName = Nullable && Value.Value == null ? null : Value.Value == null ? names.Length > 0 ? names[0] : "None" : Enum.GetName(CreatedType, Value.Value);
		if (names.Length <= JsonContainer.CarouselEnumLimit)
		{
			this["carousel"] = new CarouselChoiceFragment()
			{
				Items = names,
				MayUnselected = Nullable,
				SelectedItem = selectedName
			};
		}
		else
		{
			this["list"] = new ListFragment()
			{
				Items = names,
				MayUnselected = Nullable,
				SelectedItem = selectedName
			};
		}
	}

	protected override void InternalApply(EnumJsonProperty properties)
	{
	}

	protected override JToken Sync(JContainer container, object key)
	{
		if (Carousel is CarouselChoiceFragment carousel)
		{
			return new JValue(Nullable && carousel.SelectedItem == null ? null : Enum.Parse(CreatedType, carousel.SelectedItem));
		}
		else if (List is ListFragment list)
		{
			return new JValue(Nullable && list.SelectedItem == null ? null : Enum.Parse(CreatedType, list.SelectedItem));
		}
		throw new NotSupportedException();
	}
}
