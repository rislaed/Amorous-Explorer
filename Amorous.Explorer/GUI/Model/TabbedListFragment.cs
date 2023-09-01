using Amorous.Explorer.GUI.Prototype;
using Amorous.Explorer.GUI.View;
using Amorous.Explorer.Reflection;
using Squid;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Amorous.Explorer.GUI.Model;

public class TabbedListFragment : Fragment, IChoiceable
{
	public TabbedListBox TabbedList { get; protected set; }
	protected override IControlContainer Subcontainer => TabbedList.ItemContent.Content;
	public bool UnselectOnDeattach { get; set; }
	public bool MayUnselected { get; set; }

	public readonly LinkedDictionary<TabbedListBoxItem, string> TabItems = new LinkedDictionary<TabbedListBoxItem, string>();

	public IFragment SelectedTab
	{
		get => selectedTab;
		set
		{
			if (selectedTab == value)
			{
				return;
			}
			if (selectedTab != null)
			{
				selectedTab.Deattach();
			}
			if (value != null && !Fragments.Contains(value))
			{
				selectedTab = null;
				return;
			}
			selectedTab = value;
			if (selectedTab != null && IsAttached)
			{
				internallyChanging = true;
				ReselectFragment();
				internallyChanging = false;
			}
		}
	}

	public ICollection<string> Items => IsAttached ? TabItems.Values : Keys;

	public string SelectedItem
	{
		get => this[selectedTab];
		set => SelectedTab = this[value] as IFragment;
	}

	public ChoiceEvent OnSelect { get; set; }
	public UnchoiceEvent OnUnselect { get; set; }

	public TabbedListFragment(AbstractDesktop desktop = null) : base(desktop)
	{
		TabbedList = new TabbedListBox();
		TabbedList.TabSelected += TabSelected;
		TabbedList.ItemContent.ClipFrame.Margin = new Margin(8);
	}

	private bool internallyChanging;
	private IFragment selectedTab;

	protected virtual void TabSelected(TabbedListBox box, TabbedListBoxItem item)
	{
		if (!internallyChanging)
		{
			if (item == null)
			{
				SelectedTab = null;
				OnUnselect?.Invoke(this, null);
				return;
			}
			if (!TabItems.TryGetValue(item, out var key))
			{
				key = Convert.ToString(item.Tag, CultureInfo.InvariantCulture);
			}
			if (string.IsNullOrEmpty(key) || (MayUnselected && SelectedItem == key) || !(this[key] is IFragment fragment))
			{
				SelectedTab = null;
				OnUnselect?.Invoke(this, null);
				return;
			}
			SelectedTab = fragment;
			OnSelect?.Invoke(this, key);
		}
	}

	protected virtual void ReselectFragment()
	{
		TabbedList.SelectedItem = TabItems[SelectedItem] ?? TabbedList.SelectedItem;
		TabbedList.ItemContent.Content.Controls.Clear();
		TabbedList.ItemContent.VScroll.Value = TabbedList.ItemContent.HScroll.Value = 0;
		SelectedTab?.AttachInContainer(TabbedList.ItemContent.Content, this);
	}

	protected override void InternalPrepareToAttach()
	{
		foreach (string key in Keys)
		{
			if (this[key] is IFragment)
			{
				TabbedListBoxItem item = new TabbedListBoxItem();
				if (item.Item is IText)
				{
					(item.Item as IText).Text = key?.ToString() ?? "null";
				}
				else if (item.Item is Label)
				{
					(item.Item as Label).Text = key?.ToString() ?? "null";
				}
				TabbedList.Items.Add(item);
				TabItems[item] = key;
			}
		}
	}

	protected override void InternalAttach()
	{
		if (!IsReattaching)
		{
			Root?.Controls.Add(TabbedList);
		}
		if (selectedTab != null)
		{
			internallyChanging = true;
			ReselectFragment();
			internallyChanging = false;
		}
	}

	protected override void InternalDeattach()
	{
		base.InternalDeattach();
		if (!IsReattaching)
		{
			Root?.Controls.Remove(TabbedList);
		}
		TabItems.Clear();
		internallyChanging = true;
		TabbedList.SelectedItem = null;
		TabbedList.Items.Clear();
		internallyChanging = false;
		if (UnselectOnDeattach)
		{
			selectedTab = null;
		}
	}
}
