using Amorous.Explorer.GUI.Prototype;
using Amorous.Explorer.GUI.View.Inherits;
using Squid;

namespace Amorous.Explorer.GUI.Model;

public class ExpandableFragment : FrameFragment, IText
{
	public Button Button { get; protected set; }
	public string Text { get => Button.Text; set => Button.Text = value; }
	public bool Expanded
	{
		get => Button.Checked;
		set => Button.Checked = value;
	}
	public new DockStyle Dock
	{
		get => base.Dock;
		set
		{
			base.Dock = value;
			Button.Dock = base.Dock;
		}
	}
	public bool CollapseOnDeattach { get; set; }

	public ExpandableFragment(AbstractDesktop desktop = null) : base(desktop)
	{
		Frame.Margin = new Margin(8);
		Frame.Visible = false;
		Button = new AmorousButton()
		{
			Style = "buttonOpaqueCheckable",
			CheckOnClick = true
		};
		Button.CheckedChanged += delegate
		{
			OnCheckedChanged();
		};
	}

	protected virtual void OnCheckedChanged()
	{
		Frame.Visible = Button.Checked;
	}

	protected override void InternalAttach()
	{
		if (!IsReattaching)
		{
			Root?.Controls.Add(Button);
		}
		base.InternalAttach();
	}

	protected override void InternalDeattach()
	{
		base.InternalDeattach();
		if (!IsReattaching)
		{
			Root?.Controls.Remove(Button);
		}
		if (CollapseOnDeattach)
		{
			Expanded = false;
		}
	}
}
