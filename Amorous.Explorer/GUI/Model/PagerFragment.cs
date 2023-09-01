using System;
using System.Collections.Generic;
using System.Linq;
using Amorous.Explorer.GUI.Prototype;
using Amorous.Explorer.GUI.View;
using Amorous.Explorer.Reflection;
using Amorous.Explorer.Specialized;
using Squid;

namespace Amorous.Explorer.GUI.Model;

public enum PagerDockStyle
{
	Bottom,
	Top
}

public delegate bool SlideEvent(PagerFragment fragment, string selectedItem, int selectedKey, object tag);
public delegate void TurnLeftEvent(PagerFragment fragment, string selectedItem, int selectedKey);
public delegate void TurnRightEvent(PagerFragment fragment, string selectedItem, int selectedKey);

public class PagerFragment : FrameFragment, IChoiceable
{
	public PagerApplyControl Buttons { get; protected set; }
	public PagerDockStyle PagerDock { get; set; } = PagerDockStyle.Bottom;
	public string Text { get => Buttons.Button.Text; set => Buttons.Button.Text = value; }

	public string SelectedItem
	{
		get => selectedItem;
		set
		{
			if (selectedItem == value)
			{
				return;
			}
			selectedItem = value;
			if (value != null)
			{
				RefreshSelection();
			}
		}
	}
	public int SelectedKey
	{
		get => selectedItem != null ? Array.IndexOf(Items.ToArray(), selectedItem) : -1;
		set
		{
			if (SelectedKey == value || Items.Count == 0 || value >= Items.Count)
			{
				return;
			}
			SelectedItem = Items.ElementAtOrDefault(value);
		}
	}
	public object SelectedTab => taggedTabs.TryGetValue(selectedItem, out var tab) ? tab : null;
	public bool UnselectOnDeattach { get; set; } = false;
	public bool MayUnselected { get => false; set => throw new NotSupportedException(); }
	public ICollection<string> Items
	{
		get => taggedTabs.Keys;
		set
		{
			if ((value == null && Items.Count == 0) || (value != null && Items.SequenceEqual(value)))
			{
				return;
			}
			if (value == null)
			{
				taggedTabs.Clear();
			}
			else
			{
				taggedTabs = new LinkedDictionary<string, object>(
					value.Select((key) => new KeyValuePair<string, object>(key, taggedTabs.ContainsKey(key) ? taggedTabs[key] : null))
				);
			}
			RefreshSelection();
		}
	}
	public ICollection<object> Tabs => taggedTabs.Values;
	public IDictionary<string, object> TaggedTabs
	{
		get => taggedTabs;
		set
		{
			if ((value == null && Items.Count == 0) || (value != null && taggedTabs.SequenceEqual(value)))
			{
				return;
			}
			if (value == null)
			{
				taggedTabs.Clear();
			}
			else
			{
				taggedTabs = new LinkedDictionary<string, object>(value);
			}
			RefreshSelection();
		}
	}
	protected Control Linker { get; set; }

	public FragmentEvent OnApply { get; set; }
	public ChoiceEvent OnSelect { get; set; }
	public UnchoiceEvent OnUnselect { get; set; }
	public SlideEvent OnSlide { get; set; }
	public TurnLeftEvent OnTurnLeft { get; set; }
	public TurnLeftEvent OnTurnRight { get; set; }

	public PagerFragment(AbstractDesktop desktop = null) : base(desktop)
	{
		Buttons = new PagerApplyControl
		{
			Text = string.Empty,
			TurnLeftVisible = true,
			TurnRightVisible = true
		};
		Buttons.TurnLeft.Enabled = false;
		Buttons.TurnLeft.MouseClick += (control, eventArgs) => {
			if (eventArgs.Button <= 0)
			{
				TurnLeft();
			}
		};
		Buttons.TurnRight.Enabled = false;
		Buttons.TurnRight.MouseClick += (control, eventArgs) => {
			if (eventArgs.Button <= 0)
			{
				TurnRight();
			}
		};
		Buttons.Button.NoEvents = true;
		Linker = new Control
		{
			Size = new Point(Point.Zero)
		};
		ElementCollection elements = Linker.GetElements();
		Control turnLeft = new Control
		{
			AllowFocus = true
		};
		turnLeft.GotFocus += (control) => {
			TurnLeft();
			control.Desktop.SetFocus(null);
		};
		Control turnRight = new Control
		{
			AllowFocus = true,
			TabIndex = 1
		};
		turnRight.GotFocus += (control) => {
			TurnRight();
			control.Desktop.SetFocus(null);
		};
		elements.Add(turnLeft);
		elements.Add(turnRight);
	}

	private IDictionary<string, object> taggedTabs = new LinkedDictionary<string, object>();
	private string selectedItem;

	protected virtual void RefreshSelection()
	{
		if (IsAttached)
		{
			if (selectedItem == null)
			{
				OnUnselect?.Invoke(this, selectedItem);
			}
			else
			{
				OnSelect?.Invoke(this, selectedItem);
			}
		}
		int selectedKey = SelectedKey;
		Buttons.TurnRight.Enabled = selectedKey < Items.Count - 1;
		Buttons.TurnLeft.Enabled = selectedKey > 0;
		if (!IsAttached)
		{
			return;
		}
		object selectedTab = SelectedTab;
		if (OnSlide?.Invoke(this, selectedItem, selectedKey, selectedTab) ?? false)
		{
			return;
		}
		Frame.Controls.Clear();
		if (selectedTab == null)
		{
			return;
		}
		if (selectedTab is IFragment fragment)
		{
			fragment.AttachInContainer(Frame, this);
		}
		else if (selectedTab is Control control)
		{
			Frame.Controls.Add(control);
		}
	}

	protected override void InternalAttach()
	{
		if (selectedItem != null)
		{
			RefreshSelection();
		}
		if (IsReattaching)
		{
			base.InternalAttach();
			return;
		}
		if (PagerDock == PagerDockStyle.Top)
		{
			Root?.Controls.Add(Buttons);
		}
		base.InternalAttach();
		if (PagerDock == PagerDockStyle.Bottom)
		{
			Root?.Controls.Add(Buttons);
		}
	}

	protected override void InternalDeattach()
	{
		if (!IsReattaching)
		{
			Root?.Controls.Remove(Buttons);
		}
		base.InternalDeattach();
		if (UnselectOnDeattach)
		{
			SelectedKey = 0;
		}
	}

	public virtual void TurnLeft()
	{
		int selectedKey = SelectedKey;
		if (selectedKey <= 0)
		{
			return;
		}
		selectedKey -= 1;
		if (selectedKey >= Items.Count)
		{
			return;
		}
		selectedItem = Items.ElementAtOrDefault(selectedKey);
		OnTurnLeft?.Invoke(this, selectedItem, selectedKey);
		RefreshSelection();
	}

	public virtual void TurnRight()
	{
		int selectedKey = SelectedKey;
		selectedKey += 1;
		if (selectedKey < 0 || selectedKey >= Items.Count)
		{
			return;
		}
		selectedItem = Items.ElementAtOrDefault(selectedKey);
		OnTurnRight?.Invoke(this, selectedItem, selectedKey);
		RefreshSelection();
	}
}
