using System;
using System.Linq;
using Squid;

namespace Amorous.Explorer.GUI.View;

public delegate void TabbedListSelected(TabbedListBox box, TabbedListBoxItem item);

public class TabbedListBox : Panel
{

	public TabbedListBoxItemCollection Items { get; private set; }

	public TabbedListBoxItem SelectedItem
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
				ItemContent.Content.Controls.Remove(selectedItem);
			}
			if (value != null)
			{
				BeforeItemContent.Controls.Clear();
				AfterItemContent.Controls.Clear();
				if (!Items.Contains(value))
				{
					BeforeItemContent.Controls.AddRange(Items.ConvertAll((list) => list.Item));
					selectedItem = null;
					TabSelected?.Invoke(this, selectedItem);
					MeasureLayout();
					return;
				}
			}
			selectedItem = value;
			if (selectedItem != null)
			{
				int index = Items.IndexOf(selectedItem);
				for (int i = 0; i <= index; i++)
				{
					BeforeItemContent.Controls.Add(Items[i].Item);
				}
				for (int i = index + 1; i < Items.Count; i++)
				{
					AfterItemContent.Controls.Add(Items[i].Item);
				}
				ItemContent.Content.Controls.Add(selectedItem);
			}
			ItemContent.Visible = selectedItem != null;
			TabSelected?.Invoke(this, selectedItem);
			MeasureLayout();
		}
	}

	public Frame BeforeItemContent { get; private set; }
	public Panel ItemContent { get; private set; }
	public Frame AfterItemContent { get; private set; }

	public event TabbedListSelected TabSelected;

	public TabbedListBox()
	{
		base.Dock = DockStyle.Fill;
		Items = new TabbedListBoxItemCollection();
		Items.BeforeItemAdded += OnBeforeItemAdded;
		Items.ItemAdded += OnItemAdded;
		Items.ItemRemoved += OnItemRemoved;
		Items.BeforeItemsCleared += OnBeforeItemsCleared;
		Items.ItemsSorted += OnItemsSorted;
		BeforeItemContent = new Frame()
		{
			Dock = DockStyle.Top,
			AutoSize = AutoSize.Vertical
		};
		Content.Controls.Add(BeforeItemContent);
		ItemContent = new Panel()
		{
			Dock = DockStyle.Top
		};
		Content.Controls.Add(ItemContent);
		AfterItemContent = new Frame()
		{
			Dock = DockStyle.Top,
			AutoSize = AutoSize.Vertical
		};
		Content.Controls.Add(AfterItemContent);
		Content.SizeChanged += OnSizeChanged;
		ClipFrame.SizeChanged += (control) => MeasureLayout();
	}

	private TabbedListBoxItem selectedItem;

	private void OnBeforeItemAdded(object sender, ListEventArgs<TabbedListBoxItem> eventArgs)
	{
		if (Items.Contains(eventArgs.Item))
		{
			eventArgs.Cancel = true;
		}
	}

	private void OnItemAdded(object sender, ListEventArgs<TabbedListBoxItem> eventArgs)
	{
		eventArgs.Item.Item.MouseClick += OnItemMouseClick;
		int index = Items.IndexOf(eventArgs.Item);
		if (index > BeforeItemContent.Controls.Count)
		{
			AfterItemContent.Controls.Insert(index - BeforeItemContent.Controls.Count, eventArgs.Item.Item);
		}
		else
		{
			BeforeItemContent.Controls.Insert(index, eventArgs.Item.Item);
		}
	}

	private void OnItemRemoved(object sender, ListEventArgs<TabbedListBoxItem> eventArgs)
	{
		eventArgs.Item.Item.MouseClick -= OnItemMouseClick;
		eventArgs.Item.Item.Parent = eventArgs.Item.Parent = null;
	}

	private void OnBeforeItemsCleared(object sender, EventArgs eventArgs)
	{
		foreach (TabbedListBoxItem item in Items)
		{
			item.Item.MouseClick -= OnItemMouseClick;
			item.Item.Parent = item.Parent = null;
		}
	}

	private void OnItemsSorted(object sender, EventArgs eventArgs)
	{
		if (SelectedItem != null)
		{
			TabbedListBoxItem selected = SelectedItem;
			SelectedItem = null;
			SelectedItem = selected;
		}
	}

	private void OnItemMouseClick(object sender, MouseEventArgs eventArgs)
	{
		if (eventArgs.Button <= 0 && sender is Control control)
		{
			SelectedItem = Items.FirstOrDefault((item) => item.Item == control || control.IsChildOf(item.Item)) ?? SelectedItem;
		}
	}

	private void OnSizeChanged(Control sender)
	{
		if (ClipFrame.Size.y <= 0)
		{
			return;
		}
		int contentDesiredHeight = Math.Max(ClipFrame.Size.y - BeforeItemContent.Size.y - AfterItemContent.Size.y, 0);
		ItemContent.Size = new Point(0, Math.Max(contentDesiredHeight, ClipFrame.Size.y / 2));
	}

	public void MeasureLayout()
	{
		if (ItemContent.Content.AutoSize == AutoSize.HorizontalVertical)
		{
			ItemContent.Content.Size = new Point(0, 0);
		}
		else if (ItemContent.Content.AutoSize == AutoSize.Horizontal)
		{
			ItemContent.Content.Size = new Point(0, ItemContent.Content.Size.y);
		}
		else if (ItemContent.Content.AutoSize == AutoSize.Vertical)
		{
			ItemContent.Content.Size = new Point(ItemContent.Content.Size.x, 0);
		}
		else
		{
			return;
		}
		ItemContent.Content.PerformLayout();
	}
}

public class TabbedListBoxItem : Frame
{
	public Control Item { get; set; }

	public TabbedListBoxItem()
	{
		base.Scissor = true;
		base.Dock = DockStyle.Fill;
		Item = new Button()
		{
			Dock = DockStyle.Top,
			TextAlign = Alignment.MiddleCenter,
			Style = "buttonOpaque"
		};
	}
}

public class TabbedListBoxItemCollection : ActiveList<TabbedListBoxItem> {}
