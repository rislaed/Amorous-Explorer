using Amorous.Explorer.Data;
using Amorous.Explorer.GUI.Prototype;
using Amorous.Explorer.GUI.View.Inherits;
using Newtonsoft.Json.Linq;
using Squid;

namespace Amorous.Explorer.GUI.Json;

public class LinkJsonProperty : JsonProperty
{
}

public class LinkPropertyFragment : JsonPropertyFragment<LinkJsonProperty>
{
	protected Button Button => this["button"] as Button;

	public LinkPropertyFragment(JToken token, AbstractDesktop desktop = null) : base(token, desktop)
	{
		RequiresLabel = false;
	}

	protected override void InternalConstructLayout()
	{
		base.InternalConstructLayout();
		Button button = new AmorousButton()
		{
			Text = Name.ToPersonReadable()
		};
		button.MouseClick += (control, eventArgs) => SwitchToToken();
		this["button"] = button;
	}

	protected virtual void SwitchToToken() => JsonContainer.SwitchToSubtoken(Token);

	protected override void InternalApply(LinkJsonProperty properties)
	{
	}

	protected override JToken Sync(JContainer container, object key) => container;
}
