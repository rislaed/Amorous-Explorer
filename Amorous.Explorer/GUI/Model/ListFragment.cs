using System.Collections.Generic;
using System.Linq;
using Amorous.Explorer.GUI.Prototype;
using Amorous.Explorer.GUI.View.Inherits;
using Amorous.Explorer.Reflection;
using Squid;

namespace Amorous.Explorer.GUI.Model;

public class ListFragment : FrameFragment, IChoiceConfigurable, IChoiceable, IMultiChoiceable
{
	public ICollection<string> Items
	{
		get => taggedItems.Keys;
		set
		{
			if ((value == null && Items.Count == 0) || (value != null && Items.SequenceEqual(value)))
			{
				return;
			}
			if (value == null)
			{
				taggedItems.Clear();
			}
			else
			{
				taggedItems = new LinkedDictionary<string, object>(
					value.Select((key) => new KeyValuePair<string, object>(key, taggedItems.ContainsKey(key) ? taggedItems[key] : null))
				);
			}
			internallyChanging = true;
			RemoveNonExistingItems();
			RefreshSelection();
			internallyChanging = false;
		}
	}
	public ICollection<object> Tags => taggedItems.Values;
	public IDictionary<string, object> TaggedItems
	{
		get => taggedItems;
		set
		{
			if ((value == null && Items.Count == 0) || (value != null && taggedItems.SequenceEqual(value)))
			{
				return;
			}
			if (value == null)
			{
				taggedItems.Clear();
			}
			else
			{
				taggedItems = new LinkedDictionary<string, object>(value);
			}
			internallyChanging = true;
			RemoveNonExistingItems();
			RefreshSelection();
			internallyChanging = false;
		}
	}
	public string SelectedItem
	{
		get => selectedItems.Count > 0 ? selectedItems[0] : null;
		set
		{
			if ((selectedItems.Count == 1 && selectedItems[0] == value) || (selectedItems.Count == 0 && value == null))
			{
				return;
			}
			selectedItems.Clear();
			if (value != null)
			{
				selectedItems.Add(value);
			}
			internallyChanging = true;
			RefreshSelection();
			internallyChanging = false;
		}
	}
	public ICollection<string> SelectedItems
	{
		get => selectedItems;
		set
		{
			if ((value == null && Items.Count == 0) || (value != null && Items.SequenceEqual(value)))
			{
				return;
			}
			selectedItems.Clear();
			if (value != null)
			{
				selectedItems.AddRange(value);
			}
			internallyChanging = true;
			RefreshSelection();
			internallyChanging = false;
		}
	}
	public ICollection<object> SelectedTags => selectedItems.Select((key) => taggedItems[key]).ToArray();
	public bool UnselectOnDeattach { get; set; }
	public ChoiceMode Mode { get; set; }
	public bool MayUnselected { get; set; } = true;

	protected LinkedDictionary<string, object> taggedItems = new LinkedDictionary<string, object>();
	protected List<string> selectedItems = new List<string>();
	protected bool internallyChanging { get; set; }
	protected int itemIndex { get; set; }

	public ListFragment(AbstractDesktop desktop = null) : base(desktop) {}

	public ChoiceEvent OnSelect { get; set; }
	public UnchoiceEvent OnUnselect { get; set; }
	public MultiChoiceEvent OnChecked { get; set; }

	public object TagOf(string key)
	{
		if (taggedItems.TryGetValue(key, out var value))
		{
			return value;
		}
		return null;
	}

	public U TagOf<U>(string key) where U : class => TagOf(key) as U;

	public string KeyOf(object tag)
	{
		foreach (KeyValuePair<string, object> item in taggedItems)
		{
			if (item.Value.Equals(tag))
			{
				return item.Key;
			}
		}
		return null;
	}

	public string KeyOf<U>(U tag) where U : class => KeyOf(tag);

	protected void RefreshSelection()
	{
		foreach (Control control in Controls)
		{
			if (control is ICheckable checkable && control is Label text)
			{
				checkable.Checked = selectedItems.Contains(text.Text);
			}
		}
	}

	protected virtual void RemoveNonExistingItems()
	{
		selectedItems = selectedItems.Intersect(Items).ToList();
	}

	protected override void InternalPrepareToAttach()
	{
		base.Clear();
		InternalBeforePrepareToAttach();
		base.InternalPrepareToAttach();
	}

	protected virtual void InternalBeforePrepareToAttach()
	{
		itemIndex = 0;
		foreach (KeyValuePair<string, object> item in taggedItems)
		{
			AddItem(item.Key, item.Value);
			itemIndex++;
		}
	}

	protected override void InternalAttach()
	{
		RefreshSelection();
		base.InternalAttach();
	}

	public virtual object AddItem(string text, object tag = null)
	{
		AmorousButton button = new AmorousButton()
		{
			Text = text,
			CheckOnClick = true,
			Style = "buttonOpaqueCheckable"
		};
		button.Tag = tag ?? button.Tag;
		button.BeforeCheckedChanged += OnBeforeButtonChecked;
		button.CheckedChanged += OnButtonChecked;
		return this[$"item{itemIndex}"] = button;
	}

	protected void OnBeforeButtonChecked(Control control, SquidEventArgs eventArgs)
	{
		if (!internallyChanging && control is ICheckable checkable && control is Label text)
		{
			if (Mode == ChoiceMode.None)
			{
				OnSelect?.Invoke(this, text.Text);
			}
			else if (!(!MayUnselected && checkable.Checked && selectedItems.Count == 1))
			{
				return;
			}
			eventArgs.Cancel = true;
		}
	}

	protected void OnButtonChecked(Control control)
	{
		if (!internallyChanging && control is ICheckable checkable && control is Label text)
		{
			if (!checkable.Checked)
			{
				if (!selectedItems.Remove(text.Text))
				{
					return;
				}
			}
			else if (!selectedItems.Contains(text.Text))
			{
				if (Mode == ChoiceMode.Single)
				{
					selectedItems.Clear();
				}
				selectedItems.Add(text.Text);
				if (Mode == ChoiceMode.Single)
				{
					internallyChanging = true;
					RefreshSelection();
					internallyChanging = false;
				}
			}
			else
			{
				return;
			}
			if (Mode == ChoiceMode.Single)
			{
				if (SelectedItem == null)
				{
					OnUnselect?.Invoke(this, text.Text);
				}
				else
				{
					OnSelect?.Invoke(this, text.Text);
				}
			}
			OnChecked?.Invoke(this, SelectedItems);
		}
	}

	protected override void InternalDeattach()
	{
		base.InternalDeattach();
		if (UnselectOnDeattach)
		{
			selectedItems.Clear();
		}
		base.Clear();
	}
}
