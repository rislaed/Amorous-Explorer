using Amorous.Explorer.GUI.Prototype;
using Squid;

namespace Amorous.Explorer.GUI.Model;

public class IndevFragment : Fragment
{
	public Label Label => this["placeholder"] as Label;
	public static readonly string[] Phrases = new string[]
	{
		"Not developed yet!",
		"Nothing here, see later!",
		"Sadly, too early!"
	};

	public IndevFragment(AbstractDesktop desktop = null) : base(desktop)
	{
		this["placeholder"] = new Label()
		{
			Dock = DockStyle.Center,
			TextAlign = Alignment.MiddleCenter
		};
	}

	protected override void InternalAttach()
	{
		Label.Text = Phrases[Utils.Random(0, Phrases.Length)];
		base.InternalAttach();
	}
}
