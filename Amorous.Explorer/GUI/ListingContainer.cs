using System;
using System.IO;
using System.Linq;
using Amorous.Explorer.Data;
using Amorous.Explorer.GUI.Json;
using Amorous.Explorer.GUI.Model;
using Amorous.Explorer.GUI.Prototype;
using Amorous.Explorer.Reflection;
using Amorous.Explorer.Specialized;
using Amorous.Game.Scenes;
using Amorous.Game.Sexscenes;

namespace Amorous.Explorer.GUI;

public class ListingContainer : AbstractContainer<TabbedListFragment, object>
{
	public override TabbedListFragment Fragment { get; protected set; } = new TabbedListFragment()
	{
		["Scenes"] = new GrouppedListFragment()
		{
			TaggedGroups = Convertions.ToObjectDictionary(
				Readables.ToPersonReadableDictionary(Readables.ToTrimmedSuffixDictionary(
					Convertions.ClassesToDictionary(Convertions.SkipAbstracts(
						Assemblies.ResolveClassesOfType<AbstractScene>()
					)), "Scene"
				))
			),
			OnSelect = (self, key) => (self.GetContainer() as ListingContainer).SelectScene((Type)(self as ListFragment).TagOf(key)),
			OnUnselect = (self, key) => (self.GetContainer() as ListingContainer).UnselectScene((Type)(self as ListFragment).TagOf(key)),
			OnUpdate = (self, gameTime) => (self.GetContainer() as ListingContainer).UpdateCurrentScene(),
			OnBeforeAttach = (self, container, fragment) => (self.GetContainer() as ListingContainer).scene = null
		},
		["Sexscenes"] = new GrouppedListFragment()
		{
			TaggedGroups = Convertions.ToObjectDictionary(
				Readables.ToPersonReadableDictionary(Readables.ToTrimmedSuffixDictionary(
					Convertions.ClassesToDictionary(Convertions.SkipAbstracts(
						Assemblies.ResolveClassesOfType<AbstractSexscene>()
					)), "Sexscene"
				))
			),
			OnSelect = (self, key) => (self.GetContainer() as ListingContainer).SelectSexscene((Type)(self as ListFragment).TagOf(key)),
			OnUnselect = (self, key) => (self.GetContainer() as ListingContainer).UnselectSexscene((Type)(self as ListFragment).TagOf(key)),
			OnUpdate = (self, gameTime) => (self.GetContainer() as ListingContainer).UpdateCurrentSexscene(),
			OnBeforeAttach = (self, container, fragment) => (self.GetContainer() as ListingContainer).sexscene = null
		},
		["Cutscenes"] = new GrouppedListFragment()
		{
			Mode = ChoiceMode.Single,
			TaggedGroups = Convertions.ToObjectDictionary(
				Readables.ToPersonReadableDictionary(Convertions.FilesToDictionary(
					AmorousExplorer.Singleton.Content.GetFiles("*.json", "Data", "Quests")
				))
			),
			OnSelect = (self, key) => (self.GetContainer() as ListingContainer).SelectCutscene((string)(self as ListFragment).TagOf(key)),
			OnUnselect = (self, key) => (self.GetContainer() as ListingContainer).UnselectCutscene((string)(self as ListFragment).TagOf(key)),
			OnUpdate = (self, gameTime) => (self.GetContainer() as ListingContainer).UpdateCurrentCutscene(),
			OnBeforeAttach = (self, container, fragment) => (self.GetContainer() as ListingContainer).cutscene = null
		},
		["Subscenes"] = new GrouppedListFragment()
		{
			TaggedGroups = Convertions.ToObjectDictionary(
				Readables.ToPersonReadableKeysDictionary(Readables.ToTrimmedSuffixKeysDictionary(
					Readables.ToPersonReadableDictionary(Assemblies.ResolveSubscenes()), "Scene"
				))
			),
			OnSelect = (self, key) => (self.GetContainer() as ListingContainer).SelectSubscene((string)(self as ListFragment).TagOf(key))
		},
		["NPCs"] = new GrouppedListFragment()
		{
			Mode = ChoiceMode.Single,
			TaggedGroups = Convertions.ToObjectDictionary(
				Readables.ToPersonReadableDictionary(Readables.ToTrimmedSuffixDictionary(
					Convertions.ClassesToDictionary(Convertions.SkipAbstracts(
						Assemblies.ResolveClassesOfType<AbstractNPC>()
					)), "NPC"
				))
			),
			OnSelect = (self, key) => (self.GetContainer() as ListingContainer).SelectNPC((Type)(self as ListFragment).TagOf(key)),
			OnUnselect = (self, key) => (self.GetContainer() as ListingContainer).UnselectNPC((Type)(self as ListFragment).TagOf(key))
		},
		["Dialogue NPCs"] = new GrouppedListFragment()
		{
			Mode = ChoiceMode.Single,
			TaggedGroups = Convertions.ToObjectDictionary(
				Convertions.OrderByKeys(Convertions.ClassesToDialogueNPCsDictionary(
					Convertions.SkipNonDialogueNPCs(Convertions.SkipAbstracts(
						Assemblies.ResolveClassesOfType<AbstractNPC>()
					))
				))
			),
			OnSelect = (self, key) => (self.GetContainer() as ListingContainer).SelectNPC((Type)(self as ListFragment).TagOf(key)),
			OnUnselect = (self, key) => (self.GetContainer() as ListingContainer).UnselectNPC((Type)(self as ListFragment).TagOf(key))
		},
		["Events"] = new GrouppedListFragment()
		{
			TaggedGroups = Convertions.ToObjectDictionary(
				Readables.ToPersonReadableDictionary(Readables.ToTrimmedSuffixDictionary(
					Convertions.ClassesToGenericDictionary(Convertions.SkipUnimplemented(
						Assemblies.ResolveClassesOfType<IEvent>()
					)), "EventData", "Event"
				))
			),
			OnSelect = (self, key) => (self.GetContainer() as ListingContainer).SelectEvent((Type)(self as ListFragment).TagOf(key))
		},
		["Contacts"] = new ListFragment()
		{
			TaggedItems = Convertions.ToObjectDictionary(
				Readables.ToPersonReadableDictionary(Enum.GetNames(typeof(PlayerData.EPhoneContacts)))
			),
			OnSelect = (self, key) => (self.GetContainer() as ListingContainer).SelectContacts((self as ListFragment).TagOf<string>(key)),
			OnChecked = (self, keys) => (self.GetContainer() as ListingContainer).SelectContacts(keys.Select((key) => (self as ListFragment).TagOf<string>(key)).ToArray())
		},
		OnBeforeAttach = (self, container, fragment) => (self.GetContainer() as ListingContainer).HideEssentials(),
		SelectedItem = "Scenes"
	};

	protected StartupDesktop StartupDesktop => Desktop as StartupDesktop;
	public GrouppedListFragment ScenesFragment => this["Scenes"] as GrouppedListFragment;
	public GrouppedListFragment SexscenesFragment => this["Sexscenes"] as GrouppedListFragment;
	public GrouppedListFragment CutscenesFragment => this["Cutscenes"] as GrouppedListFragment;
	public GrouppedListFragment SubscenesFragment => this["Subscenes"] as GrouppedListFragment;
	public GrouppedListFragment NPCsFragment => this["NPCs"] as GrouppedListFragment;
	public GrouppedListFragment DialogueNPCsFragment => this["Dialogue NPCs"] as GrouppedListFragment;
	public GrouppedListFragment EventsFragment => this["Events"] as GrouppedListFragment;
	public ListFragment ContactsFragment => this["Contacts"] as ListFragment;

	public ListingContainer(AbstractDesktop desktop = null) : base(desktop) {}

	private AbstractScene scene;
	private AbstractSexscene sexscene;
	private Cutscene cutscene;
	private Action<object> then;
	private string unexpectedSelection;
	private ChoiceMode? unexpectedChoiceMode;

	public void SelectScene(Type type)
	{
		if (then != null)
		{
			then.Invoke(type);
			return;
		}
		if (type == typeof(SaveMigrationScene))
		{
			TryExpect("Scenes", delegate(object type)
			{
				Deexpect();
				if ((Type)type != typeof(SaveMigrationScene))
				{
					TryExpect("Cutscenes", delegate(object path)
					{
						Deexpect();
						Desktop.Explorer.Amorous.StartScene(
							new SaveMigrationScene(Desktop.Explorer.Amorous, (string)path, ((Type)type).Name)
						);
					}, ChoiceMode.None);
				}
			}, ChoiceMode.None);
			return;
		}
		Desktop.Explorer.Amorous.StartScene(type);
	}

	public void UnselectScene(Type type) => then?.Invoke(null);

	private sealed class CensoredSexsceneData
	{
		public string Spine { get; set; }
		public string Background { get; set; }
		public string Overlay { get; set; }
		public int? SpineX { get; set; } = 900;
		public int? SpineY { get; set; } = 900;
		public float Scale { get; set; } = 1f;
		public bool PremultipliedAlpha { get; set; } = true;
		public float CensoredCycle { get; set; } = 1000f;
		public string Animation { get; set; } = "animation";
		public bool? Explode { get; set; }
		public AbstractSexscene.EPhase? Phase { get; set; }
	}

	public void SelectSexscene(Type type)
	{
		if (then != null)
		{
			then.Invoke(type);
			return;
		}
		if (type == typeof(CensoredSexscene))
		{
			if (StartupDesktop.ContainerAttachedToConstructor?.Tag == this)
			{
				StartupDesktop.DeattachConstructor();
				return;
			}
			JsonContainer container = new JsonContainer(Desktop)
			{
				Title = type.Name.ToPersonReadable(),
				OnApply = delegate(JsonContainer container, object value)
				{
					if (value is CensoredSexsceneData data)
					{
						object instance = Activator.CreateInstance(type, Desktop.Explorer.Amorous.Content, data.Spine, data.Background, data.Overlay, data.Scale, data.PremultipliedAlpha, null, null, data.CensoredCycle);
						if (instance is AbstractSexscene sexscene)
						{
							if (data.Animation != null)
							{
								sexscene.Skeleton.StartAnimationWithLooping(data.Animation);
							}
							if (data.SpineX.HasValue)
							{
								sexscene.Skeleton.X = data.SpineX.Value;
							}
							if (data.SpineY.HasValue)
							{
								sexscene.Skeleton.Y = data.SpineY.Value;
							}
							if (data.Phase.HasValue || data.Explode.HasValue)
							{
								sexscene.LoadPhase(data.Phase ?? sexscene.Phase, data.Explode ?? false);
							}
							sexscene.Skeleton.SetVisibility(1f);
							Desktop.Explorer.Amorous.ChangeSexscene(sexscene);
						}
					}
				},
				Properties = {
					["Spine"] = new TextJsonProperty()
					{
						Whitespaceable = false
					},
					["Background"] = new TextJsonProperty()
					{
						Whitespaceable = false
					}
				},
				Tag = this
			};
			StartupDesktop.AttachJsonContainer(container, new CensoredSexsceneData());
			return;
		}
		object instance = Activator.CreateInstance(type, Desktop.Explorer.Amorous.Content);
		if (instance is AbstractSexscene sexscene)
		{
			Desktop.Explorer.Amorous.ChangeSexscene(sexscene);
		}
	}

	public void UnselectSexscene(Type type) => then?.Invoke(null);

	public void SelectCutscene(string path)
	{
		string subpath = Path.ChangeExtension(path, null);
		if (subpath.Contains("Quests"))
		{
			subpath = subpath.Substring(subpath.IndexOf("Quests") + 7);
		}
		if (then != null)
		{
			then.Invoke(subpath);
			return;
		}
		Cutscene cutscene = Desktop.Explorer.Amorous.ReadCutscene(subpath);
		StartupDesktop.AttachCutscene(cutscene?.Data ?? new CutsceneData());
	}

	public void UnselectCutscene(string path)
	{
		if (then != null)
		{
			then.Invoke(null);
			return;
		}
		StartupDesktop.DeattachCutscene();
	}

	public void SelectSubscene(string subscene) => then?.Invoke(subscene);

	public void SelectNPC(Type type)
	{
		if (then != null)
		{
			then.Invoke(type);
			return;
		}
		StartupDesktop.AttachSpawnDialogueNPC(type);
	}

	public void UnselectNPC(Type type)
	{
		if (then != null)
		{
			then.Invoke(null);
			return;
		}
		if (StartupDesktop.SpawnNPCsContainer.IsAttached)
		{
			StartupDesktop.DeattachConstructor();
		}
	}

	public void SelectEvent(Type type) => then?.Invoke(type);

	public void SelectContacts(params string[] selectedContacts)
	{
		if (then == null)
		{
			return;
		}
		PlayerData.EPhoneContacts contacts = PlayerData.EPhoneContacts.None;
		foreach (string contact in selectedContacts)
		{
			if (Enum.TryParse<PlayerData.EPhoneContacts>(contact, out var econtacts))
			{
				contacts |= econtacts;
			}
		}
		then.Invoke(contacts);
	}

	public void UpdateCurrentScene()
	{
		if (scene != (scene = Desktop.Explorer.Amorous.Scene))
		{
			UpdateSelectionByTag(ScenesFragment.Subcontrols, scene?.GetType());
		}
	}

	public void UpdateCurrentSexscene()
	{
		if (sexscene != (sexscene = Desktop.Explorer.Amorous.Sexscene))
		{
			UpdateSelectionByTag(SexscenesFragment.Subcontrols, sexscene?.GetType());
		}
	}

	public void UpdateCurrentCutscene()
	{
		if (cutscene != (cutscene = Desktop.Explorer.Amorous.Cutscene))
		{
			UpdateSelectionByText(CutscenesFragment.Subcontrols, cutscene?.Data.Name);
		}
	}

	public bool TryExpect(string key, Action<object> when = null, ChoiceMode? mode = null, params string[] selectedItems)
	{
		if (!Fragment.Items.Contains(key))
		{
			return false;
		}
		if (!StartupDesktop.TryExpect("Listing"))
		{
			return false;
		}
		if (!Fragment.Items.Contains(key))
		{
			StartupDesktop.Deexpect();
			return false;
		}
		unexpectedSelection = Fragment.SelectedItem;
		Fragment.SelectedItem = key;
		Fragment.TabItems[key].Item.Visible = true;
		unexpectedChoiceMode = null;
		if (mode.HasValue && unexpectedSelection != null && Fragment[key] is IChoiceConfigurable configurable)
		{
			unexpectedChoiceMode = configurable.Mode;
			configurable.Mode = mode.Value;
		}
		if (Fragment[key] is IMultiChoiceable multiChoiceable)
		{
			multiChoiceable.SelectedItems = selectedItems;
		}
		else if (Fragment[key] is IChoiceable choiceable)
		{
			choiceable.SelectedItem = selectedItems.Length > 0 ? selectedItems[0] : null;
		}
		then = when;
		Fragment.TabbedList.ItemContent.Lock();
		return true;
	}

	public void Deexpect()
	{
		then = null;
		Fragment.TabbedList.ItemContent.Unlock();
		if (unexpectedSelection != null)
		{
			if (unexpectedChoiceMode.HasValue)
			{
				if (Fragment.SelectedTab is IChoiceConfigurable configurable)
				{
					configurable.Mode = unexpectedChoiceMode.Value;
				}
				unexpectedChoiceMode = null;
			}
			if (Fragment.SelectedTab is IChoiceable choiceable)
			{
				choiceable.SelectedItem = null;
			}
			else if (Fragment.SelectedTab is IMultiChoiceable multiChoiceable)
			{
				multiChoiceable.SelectedItems = null;
			}
			Fragment.SelectedItem = unexpectedSelection;
			unexpectedSelection = null;
		}
		StartupDesktop.Deexpect();
		if (IsAttached)
		{
			HideEssentials();
		}
	}

	protected virtual void HideEssentials()
	{
		Fragment.TabItems["Subscenes"].Item.Visible = false;
		Fragment.TabItems["Events"].Item.Visible = false;
		Fragment.TabItems["Contacts"].Item.Visible = false;
	}
}
