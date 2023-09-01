using System.Collections.Generic;
using Amorous.Explorer.GUI.Prototype;
using Amorous.Explorer.GUI.View;
using Squid;

namespace Amorous.Explorer.GUI.Model;

public class CarouselChoiceFragment : CarouselPanelFragment, IChoiceable
{
	public bool UnselectOnDeattach { get; set; } = true;
	public bool MayUnselected { get; set; }
	public int Group { get; set; }

	public ICollection<string> Items { get; set; } = new List<string>();

	protected int ItemCount { get; set; }

	public string SelectedItem
	{
		get => selectedItem;
		set
		{
			if (selectedItem == value)
			{
				return;
			}
			if (selectedItem != null)
			{
				internallyChanging = true;
				RefreshRadio(false);
				internallyChanging = false;
			}
			selectedItem = value;
			if (value != null)
			{
				internallyChanging = true;
				RefreshRadio(true);
				internallyChanging = false;
			}
		}
	}

	public IEnumerable<RadioCheckBox> CheckBoxes
	{
		get
		{
			foreach (Control control in Controls)
			{
				if (control is RadioCheckBox box)
				{
					yield return box;
				}
			}
		}
	}

	private bool internallyChanging;
	private string selectedItem;

	public CarouselChoiceFragment(AbstractDesktop desktop = null) : base(desktop) {}

	public ChoiceEvent OnSelect { get; set; }
	public UnchoiceEvent OnUnselect { get; set; }

	protected void RefreshRadio(bool check)
	{
		if (selectedItem != null)
		{
			if (ContainsKey(selectedItem) && this[selectedItem] is RadioCheckBox box)
			{
				box.Checked = check;
			}
		}
	}

	protected override void InternalPrepareToAttach()
	{
		base.InternalPrepareToAttach();
		foreach (string label in Items)
		{
			RadioCheckBox box = new RadioCheckBox()
			{
				Dock = DockStyle.Left,
				Text = label,
				TextAlign = Alignment.MiddleCenter,
				Group = Group,
				MayUnchecked = MayUnselected
			};
			box.CheckedGroup += CheckedGroup;
			box.UncheckedGroup += UncheckedGroup;
			this[label] = box;
		}
	}

	protected virtual void CheckedGroup(Control control)
	{
		if (!internallyChanging)
		{
			string key = (control as IText).Text;
			if ((control as ICheckable).Checked) 
			{
				selectedItem = key;
				OnSelect?.Invoke(this, selectedItem);
			}
			else if (key == selectedItem)
			{
				selectedItem = null;
			}
		}
	}

	protected virtual void UncheckedGroup(Control control)
	{
		if (!internallyChanging)
		{
			OnUnselect?.Invoke(this, (control as IText).Text);
		}
	}

	protected override void InternalAttach()
	{
		base.InternalAttach();
		internallyChanging = true;
		RefreshRadio(true);
		internallyChanging = false;
	}

	protected override void InternalDeattach()
	{
		base.InternalDeattach();
		base.Clear();
		ItemCount = 0;
		if (UnselectOnDeattach)
		{
			selectedItem = null;
		}
	}
}
