using Amorous.Explorer.GUI.Prototype;
using Squid;

namespace Amorous.Explorer.GUI.Model;

public class PanelFragment : Fragment
{
	public Panel Panel { get; protected set; }
	protected override IControlContainer Subcontainer => Panel.Content;

	public PanelFragment(AbstractDesktop desktop = null) : base(desktop)
	{
		Panel = new Panel()
		{
			Dock = DockStyle.Fill
		};
	}

	protected override void InternalAttach()
	{
		if (!IsReattaching)
		{
			Root?.Controls.Add(Panel);
		}
		base.InternalAttach();
	}

	protected override void InternalDeattach()
	{
		base.InternalDeattach();
		if (!IsReattaching)
		{
			Root?.Controls.Remove(Panel);
		}
	}
}
