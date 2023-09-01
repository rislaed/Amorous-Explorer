using System.Collections.Generic;
using System.Linq;
using Amorous.Explorer.Data;
using Amorous.Explorer.GUI.Prototype;
using Amorous.Explorer.GUI.View.Inherits;
using Amorous.Explorer.Reflection;

namespace Amorous.Explorer.GUI.Model;

public class GrouppedListFragment : FrameFragment, IChoiceConfigurable, IChoiceable, IGroupChoiceable, IMultiChoiceable, IGroupMultiChoiceable
{
	public IDictionary<string, ICollection<string>> Groups
	{
		get => taggedGroups.ToDictionary((pair) => pair.Key, (pair) => pair.Value.Keys);
		set
		{
			if ((value == null && Items.Count == 0) || (value != null && Groups.SequenceEqual(value)))
			{
				return;
			}
			if (value == null)
			{
				taggedGroups.Clear();
			}
			else
			{
				taggedGroups = new LinkedDictionary<string, IDictionary<string, object>>(
					value.Select((pair) => new KeyValuePair<string, IDictionary<string, object>>(
						pair.Key, new LinkedDictionary<string, object>(pair.Value.Select((key) => new KeyValuePair<string, object>(
							key, taggedGroups.ContainsKey(pair.Key) ? taggedGroups[pair.Key].ContainsKey(key) ? taggedGroups[pair.Key][key] : null : null
						)))
					))
				);
			}
			if (IsAttached)
			{
				Reattach();
			}
		}
	}
	public IDictionary<string, IDictionary<string, object>> TaggedGroups
	{
		get => taggedGroups;
		set
		{
			if ((value == null && Items.Count == 0) || (value != null && taggedGroups.SequenceEqual(value)))
			{
				return;
			}
			if (value == null)
			{
				taggedGroups.Clear();
			}
			else
			{
				taggedGroups = new LinkedDictionary<string, IDictionary<string, object>>(
					value.Select((pair) => new KeyValuePair<string, IDictionary<string, object>>(
						pair.Key, new LinkedDictionary<string, object>(pair.Value)
					))
				);
			}
			if (IsAttached)
			{
				Reattach();
			}
		}
	}
	public ICollection<string> Items => taggedGroups.SelectMany((pair) => pair.Value.Keys).ToList();
	public ICollection<object> Tags => taggedGroups.SelectMany((pair) => pair.Value.Values).ToList();
	public IDictionary<string, object> TaggedItems => new LinkedDictionary<string, object>(taggedGroups.SelectMany((pair) => pair.Value));
	public string SelectedItem
	{
		get => FindSelectedItem();
		set
		{
			if (value == FindSelectedItem())
			{
				return;
			}
			foreach (ListFragment fragment in Lists.Values)
			{
				if (fragment.SelectedItem != value)
				{
					if ((fragment.SelectedItem = value) == value)
					{
						break;
					}
				}
			}
		}
	}
	public ICollection<string> SelectedItems
	{
		get => FindSelectedItems();
		set
		{
			ICollection<string> selectedItems = FindSelectedItems();
			if ((value == null && selectedItems.Count == 0) || (value != null && selectedItems.SequenceEqual(value)))
			{
				return;
			}
			foreach (ListFragment fragment in Lists.Values)
			{
				fragment.SelectedItems = value;
				if (value != null)
				{
					value = value.Except(fragment.SelectedItems).ToArray();
				}
			}
		}
	}
	public ICollection<object> SelectedTags => Lists.Values.SelectMany((list) => list.SelectedTags).ToArray();
	public LinkedDictionary<string, ListFragment> Lists = new LinkedDictionary<string, ListFragment>();
	public bool UnselectOnDeattach
	{
		get => unselectOnDeattach;
		set
		{
			foreach (ListFragment fragment in Lists.Values)
			{
				fragment.UnselectOnDeattach = value;
			}
			if (unselectOnDeattach == value)
			{
				return;
			}
			unselectOnDeattach = value;
		}
	}
	public bool RadioBetweenGroups { get; set; } = true;
	public ChoiceMode Mode
	{
		get => mode;
		set
		{
			foreach (ListFragment fragment in Lists.Values)
			{
				fragment.Mode = value;
			}
			if (mode == value)
			{
				return;
			}
			mode = value;
		}
	}
	public bool MayUnselected
	{
		get => mayUnselected;
		set
		{
			foreach (ListFragment fragment in Lists.Values)
			{
				fragment.MayUnselected = value;
			}
			if (mayUnselected == value)
			{
				return;
			}
			mayUnselected = value;
		}
	}

	protected LinkedDictionary<string, IDictionary<string, object>> taggedGroups = new LinkedDictionary<string, IDictionary<string, object>>();
	protected LinkedDictionary<string, ICollection<string>> selectedItems = new LinkedDictionary<string, ICollection<string>>();
	protected bool unselectOnDeattach, mayUnselected = true;
	protected ChoiceMode mode;
	protected int groupIndex { get; set; }

	public GrouppedListFragment(AbstractDesktop desktop = null) : base(desktop) {}

	public ChoiceEvent OnSelect { get; set; }
	public UnchoiceEvent OnUnselect { get; set; }
	public MultiChoiceEvent OnChecked { get; set; }
	public GroupChoiceEvent OnGroupSelect { get; set; }
	public GroupUnchoiceEvent OnGroupUnselect { get; set; }
	public GroupMultiChoiceEvent OnGroupChecked { get; set; }

	public virtual object AddGroup(string name)
	{
		return this[$"group{groupIndex}"] = new AmorousLabel()
		{
			Text = name
		};
	}

	public virtual ListFragment AddList(string key, IDictionary<string, object> items)
	{
		ListFragment list = new ListFragment()
		{
			TaggedItems = items,
			UnselectOnDeattach = UnselectOnDeattach,
			Mode = Mode,
			MayUnselected = MayUnselected,
			OnSelect = OnBeforeSelect,
			OnUnselect = OnBeforeUnselect,
			OnChecked = OnBeforeChecked
		};
		if (selectedItems.ContainsKey(key))
		{
			list.SelectedItems = selectedItems[key];
		}
		return (ListFragment)(this[$"list{groupIndex}"] = list);
	}

	protected void OnBeforeSelect(IFragment fragment, string key)
	{
		if (RadioBetweenGroups)
		{
			foreach (ListFragment list in Lists.Values)
			{
				if (list != fragment)
				{
					list.SelectedItems = null;
				}
			}
		}
		OnGroupSelect?.Invoke(this, GroupOf(fragment), key);
		OnSelect?.Invoke(fragment, key);
	}

	protected void OnBeforeUnselect(IFragment fragment, string key)
	{
		OnGroupUnselect?.Invoke(this, GroupOf(fragment), key);
		OnUnselect?.Invoke(fragment, key);
	}

	protected void OnBeforeChecked(IFragment fragment, ICollection<string> keys)
	{
		OnGroupChecked?.Invoke(this, GroupOf(fragment), keys);
		OnChecked?.Invoke(fragment, keys);
	}

	public string GroupOf(IFragment fragment)
	{
		foreach (KeyValuePair<string, ListFragment> list in Lists)
		{
			if (list.Value == fragment)
			{
				return list.Key;
			}
		}
		return null;
	}

	public string KeyOf(object tag)
	{
		string key;
		foreach (ListFragment list in Lists.Values)
		{
			if ((key = list.KeyOf(tag)) != null)
			{
				return key;
			}
		}
		return null;
	}

	public object TagOf(string key)
	{
		object tag;
		foreach (ListFragment list in Lists.Values)
		{
			if ((tag = list.TagOf(key)) != null)
			{
				return tag;
			}
		}
		return null;
	}

	protected string FindSelectedItem()
	{
		foreach (ListFragment fragment in Lists.Values)
		{
			if (fragment.SelectedItem != null)
			{
				return fragment.SelectedItem;
			}
		}
		return null;
	}

	protected ICollection<string> FindSelectedItems()
	{
		HashSet<string> set = new HashSet<string>();
		foreach (ListFragment fragment in Lists.Values)
		{
			set.UnionWith(fragment.SelectedItems);
		}
		return set;
	}

	protected override void InternalPrepareToAttach()
	{
		groupIndex = 0;
		foreach (KeyValuePair<string, IDictionary<string, object>> group in taggedGroups)
		{
			if (group.Value != null && group.Value.Count > 0)
			{
				if (!string.IsNullOrEmpty(group.Key))
				{
					AddGroup(group.Key);
				}
				Lists[group.Key ?? $"group{groupIndex}"] = AddList(group.Key, group.Value);
				groupIndex++;
			}
		}
		base.InternalPrepareToAttach();
	}

	protected override void InternalDeattach()
	{
		base.InternalDeattach();
		selectedItems.Clear();
		foreach (KeyValuePair<string, ListFragment> list in Lists)
		{
			selectedItems[list.Key] = list.Value.SelectedItems;
		}
		Lists.Clear();
		base.Clear();
	}
}
