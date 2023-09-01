using Amorous.Explorer.GUI.Prototype;
using Squid;

namespace Amorous.Explorer.GUI.Model;

public class FrameFragment : Fragment
{
	public Frame Frame { get; protected set; }
	protected override IControlContainer Subcontainer => Frame;

	public bool Visible { get => Frame.Visible; set => Frame.Visible = value; }
	public DockStyle Dock { get => Frame.Dock; set => Frame.Dock = value; }

	public FrameFragment(AbstractDesktop desktop = null) : base(desktop)
	{
		Frame = new Frame()
		{
			Dock = DockStyle.Top,
			AutoSize = AutoSize.Vertical
		};
	}

	protected override void InternalAttach()
	{
		if (!IsReattaching)
		{
			Root?.Controls.Add(Frame);
		}
		base.InternalAttach();
	}

	protected override void InternalDeattach()
	{
		base.InternalDeattach();
		if (!IsReattaching)
		{
			Root?.Controls.Remove(Frame);
		}
	}
}
