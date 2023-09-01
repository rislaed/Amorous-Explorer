using Squid;

namespace Amorous.Explorer.GUI.View;

public class PagerApplyControl : Control, IText, ICheckable
{
	public Button Button { get; set; }
	public Button TurnLeft { get; set; }
	public Button TurnRight { get; set; }
	public string Text
	{
		get => Button.Text;
		set => Button.Text = value;
	}
	public bool Checked
	{
		get => Button.Checked;
		set => Button.Checked = value;
	}
	public new string Style
	{
		get => Button.Style;
		set
		{
			TurnLeft.Style = value;
			TurnRight.Style = value;
			Button.Style = value;
		}
	}
	public bool TurnLeftVisible
	{
		get => TurnLeft.Visible;
		set => TurnLeft.Visible = value;
	}
	public bool TurnRightVisible
	{
		get => TurnRight.Visible;
		set => TurnRight.Visible = value;
	}

	public PagerApplyControl()
	{
		base.Dock = DockStyle.Top;
		base.Size = new Point(100, 30);
		base.AutoSize = AutoSize.Vertical;
		TurnLeft = new Button();
		TurnLeft.Style = "buttonOpaque";
		TurnLeft.Size = new Point(30, 30);
		TurnLeft.Dock = DockStyle.Left;
		TurnLeft.Visible = false;
		Elements.Add(TurnLeft);
		TurnRight = new Button();
		TurnRight.Style = "buttonOpaque";
		TurnRight.Size = new Point(30, 30);
		TurnRight.Dock = DockStyle.Right;
		TurnRight.Visible = false;
		Elements.Add(TurnRight);
		Button = new Button();
		Button.Style = "buttonOpaque";
		Button.Dock = DockStyle.Fill;
		Button.TextAlign = Alignment.MiddleCenter;
		Button.AutoEllipsis = true;
		Button.Text = "Apply";
		Elements.Add(Button);
	}
}
