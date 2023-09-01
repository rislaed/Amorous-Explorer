using System;
using Amorous.Explorer.Data;
using Amorous.Explorer.GUI.Json;
using Amorous.Explorer.GUI.Model;
using Amorous.Explorer.GUI.Prototype;
using Microsoft.Xna.Framework;
using Squid;

namespace Amorous.Explorer.GUI;

public class StartupDesktop : AbstractDesktop
{
	public TabbedListFragment MenuFragment = new TabbedListFragment()
	{
		["Gameplay"] = new GameplayContainer(),
		["Listing"] = new ListingContainer(),
		["Assets"] = new AssetContainer(),
		// TODO: Unimplemented factory
		// ["Layers"] = new LayerContainer(),
		["Cutscene"] = new CutsceneContainer(),
		SelectedItem = "Listing"
	};

	public GameplayContainer GameplayContainer => MenuFragment["Gameplay"] as GameplayContainer;
	public ListingContainer ListingContainer => MenuFragment["Listing"] as ListingContainer;
	public AssetContainer AssetContainer => MenuFragment["Assets"] as AssetContainer;
	public LayerContainer LayerContainer => MenuFragment["Layers"] as LayerContainer;
	public CutsceneContainer CutsceneContainer => MenuFragment["Cutscene"] as CutsceneContainer;
	public SpawnNPCsContainer SpawnNPCsContainer { get; protected set; } = new SpawnNPCsContainer();
	public IContainer EventContainer { get; protected set; } = null;

	public Window MenuWindow = new Window
	{
		Visible = false,
		Dock = DockStyle.Right,
		Size = new Squid.Point(640, 0),
		Margin = new Margin(8),
		Padding = new Margin(16)
	};
	public Window ConstructorWindow = new Window
	{
		Visible = false,
		Dock = DockStyle.Right,
		Size = new Squid.Point(480, 0),
		Margin = new Margin(8, 8, 0, 8),
		Padding = new Margin(8)
	};
	public Window ToolboxWindow = new Window
	{
		Visible = false,
		Dock = DockStyle.Left,
		Size = new Squid.Point(160, 0),
		Margin = new Margin(8),
		Padding = new Margin(8)
	};

	public IContainer ContainerAttachedToConstructor { get; protected set; }
 
	public StartupDesktop(IExplorer holder) : base(holder)
	{
		Attach();
	}

	private string unexpectedSelection;

	protected virtual void Attach()
	{
		MenuFragment.Begin(this);
		MenuFragment.AttachInContainer(MenuWindow);
		AssetContainer.Provide(Explorer.Content);
		SpawnNPCsContainer.Begin(this);
		DeattachCutscene();
		MenuWindow.Show(this);
	}

	public virtual void AttachSpawnDialogueNPC(Type type)
	{
		if (ContainerAttachedToConstructor?.IsAttached ?? false)
		{
			DeattachConstructor();
		}
		ContainerAttachedToConstructor = SpawnNPCsContainer;
		SpawnNPCsContainer.Reattach(ConstructorWindow, type);
		ConstructorWindow.Show(this);
	}

	public virtual void AttachCutscene(CutsceneData cutscene)
	{
		CutsceneContainer.Provide(cutscene);
		MenuFragment.TabItems["Cutscene"].Item.Visible = true;
	}

	public virtual void AttachJsonContainer(JsonContainer container, object data)
	{
		if (ContainerAttachedToConstructor?.IsAttached ?? false)
		{
			DeattachConstructor();
		}
		ContainerAttachedToConstructor = container;
		container.Reattach(ConstructorWindow, data);
		ConstructorWindow.Show(this);
	}

	public virtual void DeattachCutscene()
	{
		MenuFragment.TabItems["Cutscene"].Item.Visible = false;
		CutsceneContainer.Deattach();
	}

	public virtual void DeattachConstructor()
	{
		if (ConstructorWindow.Visible)
		{
			ConstructorWindow.Close();
		}
		if (ContainerAttachedToConstructor?.IsAttached ?? false)
		{
			ContainerAttachedToConstructor.Deattach();
		}
		ContainerAttachedToConstructor = null;
	}

	public override void Draw(GameTime gameTime)
	{
		base.Draw(gameTime);
		if (ContainerAttachedToConstructor?.IsAttached ?? false)
		{
			ContainerAttachedToConstructor.Draw(gameTime);
		}
		if (MenuFragment.IsAttached)
		{
			MenuFragment.Draw(gameTime);
		}
	}

	public override void Update(GameTime gameTime)
	{
		base.Update(gameTime);
		if (ContainerAttachedToConstructor != null)
		{
			if (ContainerAttachedToConstructor.IsAttached)
			{
				ContainerAttachedToConstructor.Update(gameTime);
			}
			else
			{
				DeattachConstructor();
			}
		}
		if (MenuFragment.IsAttached)
		{
			MenuFragment.Update(gameTime);
		}
	}

	internal bool TryExpect(string key)
	{
		if (!MenuFragment.Items.Contains(key))
		{
			return false;
		}
		unexpectedSelection = MenuFragment.SelectedItem;
		MenuFragment.SelectedItem = key;
		MenuFragment.TabbedList.ItemContent.Lock();
		return true;
	}

	internal void Deexpect()
	{
		MenuFragment.TabbedList.ItemContent.Unlock();
		if (unexpectedSelection != null)
		{
			MenuFragment.SelectedItem = unexpectedSelection;
			unexpectedSelection = null;
		}
	}
}
