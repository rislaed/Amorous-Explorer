using Squid;

namespace Amorous.Explorer.GUI.View.Inherits;

public class DangerousButton : Button
{
	public string Confirmation { get; set; } = "Really?";
	public new string Text
	{
		get => text;
		set
		{
			if (!Checked)
			{
				base.Text = value;
			}
			text = value;
		}
	}
	protected string InternalText { get => base.Text; set => base.Text = value; }

	public event VoidEvent MouseAccept;

	public DangerousButton()
	{
		base.Dock = DockStyle.Top;
		base.Style = "buttonOpaqueDangerous";
		base.CheckOnClick = true;
		base.TextAlign = Alignment.MiddleCenter;
		base.CheckedChanged += (control) => OnCheckedChanged();
		base.MouseLeave += (control) => OnMouseLeave();
	}

	private bool internallyChanging;
	private string text;

	private void OnCheckedChanged()
	{
		if (!internallyChanging)
		{
			if (Checked)
			{
				base.Text = Confirmation;
			}
			else
			{
				base.Text = Text;
				MouseAccept?.Invoke(this);
			}
		}
	}

	private void OnMouseLeave()
	{
		if (Checked)
		{
			base.Text = Text;
			internallyChanging = true;
			Checked = false;
			internallyChanging = false;
		}
	}
}
