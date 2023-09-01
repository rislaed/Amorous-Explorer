using Squid;

namespace Amorous.Explorer.GUI.View;

public class TreeNodeButton : TreeNode, IText
{
	public Button Button { get; protected set; }
	public Button Expander { get; protected set; }

	public bool DenyExpandableSelection { get; set; }

	public string Text
	{
		get => Button?.Text;
		set
		{
			if (Button != null)
			{
				Button.Text = value;
			}
		}
	}

	public TreeNodeButton()
	{
		base.Size = new Point(100, 30);
		Expander = new Button();
		Expander.Style = "buttonOpaqueCheckable";
		Expander.Size = new Point(30, 30);
		Expander.Dock = DockStyle.Left;
		Expander.MouseClick += OnExpanderMouseClick;
		Elements.Add(Expander);
		Button = new Button();
		Button.Style = "buttonOpaqueCheckable";
		Button.Dock = DockStyle.Fill;
		Button.TextAlign = Alignment.MiddleLeft;
		Button.AutoEllipsis = true;
		Button.MouseClick += OnMouseClick;
		Elements.Add(Button);
		base.ExpandedChanged += OnExpandedChanged;
		base.SelectedChanged += OnSelectedChanged;
	}

	private void OnExpanderMouseClick(Control control, MouseEventArgs eventArgs)
	{
		if (eventArgs.Button <= 0)
		{
			base.Expanded = !base.Expanded;
		}
	}

	private void OnMouseClick(Control control, MouseEventArgs eventArgs)
	{
		if (eventArgs.Button <= 0)
		{
			if (Expander == null || !Expander.Visible || !DenyExpandableSelection)
			{
				base.Selected = !base.Selected;
			}
			else if (Expander != null && Expander.Visible)
			{
				base.Expanded = !base.Expanded;
			}
		}
	}

	protected virtual void OnExpandedChanged(Control control)
	{
		Expander.Checked = base.Expanded;
		if (!base.Selected && DenyExpandableSelection)
		{
			Button.Checked = base.Expanded;
		}
	}

	protected virtual void OnSelectedChanged(Control control)
	{
		Button.Checked = base.Selected;
	}

	protected override void OnUpdate()
	{
		base.OnUpdate();
		if (Expander != null)
		{
			Expander.Visible = Nodes.Count > 0;
		}
	}
}
