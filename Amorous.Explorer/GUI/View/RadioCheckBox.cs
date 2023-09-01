using Squid;

namespace Amorous.Explorer.GUI.View;

public class RadioCheckBox : Button, IText
{
	public bool MayUnchecked { get; set; }
	public int Group { get; set; }

	public RadioCheckBox()
	{
		CheckOnClick = true;
		BeforeCheckedChanged += OnBeforeCheckedChanged;
		CheckedChanged += OnCheckedChanged;
		Style = "buttonOpaqueCheckable";
	}

	public event VoidEvent CheckedGroup;
	public event VoidEvent UncheckedGroup;

	private void OnBeforeCheckedChanged(Control control, SquidEventArgs eventArgs)
	{
		if (!Checked || MayUnchecked || base.Parent == null)
		{
			return;
		}
		bool checkedInRadio = false;
		foreach (RadioCheckBox box in base.Parent.GetControls<RadioCheckBox>())
		{
			if (box != this && box.Group == Group && box.Checked)
			{
				checkedInRadio = true;
				break;
			}
		}
		if (!checkedInRadio)
		{
			eventArgs.Cancel = true;
		}
	}

	private void OnCheckedChanged(Control control)
	{
		CheckedGroup?.Invoke(this);
		if (base.Parent == null)
		{
			return;
		}
		if (Checked)
		{
			foreach (RadioCheckBox box in base.Parent.GetControls<RadioCheckBox>())
			{
				if (box != this && box.Group == Group)
				{
					box.Checked = false;
				}
			}
		}
		else if (MayUnchecked && this.UncheckedGroup != null)
		{
			bool checkedInRadio = false;
			foreach (RadioCheckBox box in base.Parent.GetControls<RadioCheckBox>())
			{
				if (box != this && box.Group == Group && box.Checked)
				{
					checkedInRadio = true;
					break;
				}
			}
			if (!checkedInRadio)
			{
				UncheckedGroup.Invoke(this);
			}
		}
	}
}
