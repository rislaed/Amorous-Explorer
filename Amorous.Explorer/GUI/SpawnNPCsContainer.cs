using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Amorous.Engine.NPC;
using Amorous.Explorer.Data;
using Amorous.Explorer.GUI.Model;
using Amorous.Explorer.GUI.Prototype;
using Amorous.Explorer.GUI.View;
using Amorous.Explorer.GUI.View.Inherits;
using Amorous.Explorer.Reflection;
using Microsoft.Xna.Framework;
using Squid;

namespace Amorous.Explorer.GUI;

public class SpawnNPCsContainer : AbstractContainer<PanelFragment, Type>
{
	public override PanelFragment Fragment { get; protected set; } = new PanelFragment()
	{
		Padding = new Margin(8),
		["Non Player Character"] = new AmorousLabel()
		{
			Text = "Non Player Character",
			UseTextColor = true
		},
		["Placeholder"] = new AmorousMessage()
		{
			Text = "Placeholder"
		},
		["Variations"] = new CarouselChoiceFragment(),
		["Location Label"] = new AmorousLabel()
		{
			Text = "Location"
		},
		["Location"] = new CarouselChoiceFragment()
		{
			Items = {
				"Left",
				"Middle",
				"Right"
			},
			MayUnselected = true
		},
		["Layer Order Label"] = new AmorousLabel()
		{
			Text = "Layer Order"
		},
		["Layer Order"] = new CarouselChoiceFragment()
		{
			Items = {
				"Background",
				"Foreground"
			},
			MayUnselected = true
		},
		["Emotions"] = new GrouppedListFragment()
		{
			Mode = ChoiceMode.Single
		},
		["Poses"] = new GrouppedListFragment()
		{
			Mode = ChoiceMode.Single
		},
		["Clothes"] = new GrouppedListFragment()
		{
			Mode = ChoiceMode.Combine
		},
		["Miscellaneous"] = new GrouppedListFragment()
		{
			Mode = ChoiceMode.Combine,
			TaggedGroups = {
				["Miscellaneous"] = new LinkedDictionary<string, object>() {
					["Locked On Screen"] = 0,
					["Fixed Order"] = 1,
					["Breathing"] = 2
				}
			}
		},
		["Separator"] = new AmorousSeparator(),
		["Apply"] = new AmorousButton(),
		["Overscroller"] = new AmorousSeparator()
	};

	protected Label TitleLabel => this["Non Player Character"] as Label;
	protected Label MessageLabel => this["Placeholder"] as Label;
	protected CarouselChoiceFragment VariationFragment => this["Variations"] as CarouselChoiceFragment;
	protected CarouselChoiceFragment LocationFragment => this["Location"] as CarouselChoiceFragment;
	protected CarouselChoiceFragment OrderFragment => this["Layer Order"] as CarouselChoiceFragment;
	protected GrouppedListFragment EmotionFragment => this["Emotions"] as GrouppedListFragment;
	protected GrouppedListFragment PoseFragment => this["Poses"] as GrouppedListFragment;
	protected GrouppedListFragment ClothesFragment => this["Clothes"] as GrouppedListFragment;
	protected GrouppedListFragment OptionsFragment => this["Miscellaneous"] as GrouppedListFragment;
	protected AmorousButton ApplyButton => this["Apply"] as AmorousButton;

	public IDictionary<string, Type> Variations { get; protected set; }
	public NPCLayer Layer { get; protected set; }
	public AbstractNPC NPC { get; protected set; }
	public string Name { get; protected set; }
	public Color Color { get; protected set; }

	private bool lockedOnScreen, reallyChangedLocation, reallyChangedClothes;

	public SpawnNPCsContainer(AbstractDesktop desktop = null) : base(desktop)
	{
		ApplyButton.MouseClick += delegate(Control control, MouseEventArgs eventArgs)
		{
			Fragment.Panel.Enabled = false;
			NPC.IsFixedOrder = OptionsFragment.SelectedTags.Contains(1);
			if (NPC is BreathingNPC breathing)
			{
				breathing.Breathing = OptionsFragment.SelectedTags.Contains(2);
			}
			Layer = SpawnDialogueNPC(
				NPC,
				reallyChangedLocation ? (LocationFragment.SelectedItem ?? "None") : null,
				OrderFragment.SelectedItem,
				EmotionFragment.SelectedItem,
				PoseFragment.SelectedItem,
				reallyChangedClothes ? ClothesFragment.SelectedItems.ToArray() : null,
				OptionsFragment.SelectedTags.Contains(0)
			);
		};
		LocationFragment.OnUnselect += delegate(IFragment fragment, string selectedLocation)
		{
			if (Layer != null)
			{
				ApplyButton.Text = "Despawn it!";
			}
			reallyChangedLocation = true;
		};
		LocationFragment.OnSelect += delegate(IFragment fragment, string selectedLocation)
		{
			ApplyButton.Text = "Do it!";
			reallyChangedLocation = true;
		};
		VariationFragment.OnSelect += (fragment, type) => Reattach(data: Variations[type]);
		PoseFragment.OnUnselect += (fragment, selectedPose) => ClothesFragment.Frame.Visible = false;
		PoseFragment.OnSelect += delegate(IFragment fragment, string selectedPose)
		{
			FilterablePose poseTo = NPC.Poses.FirstOrDefault((pose) => pose.Name == selectedPose);
			IEnumerable<string> clothesTo = poseTo?.Clothes.Select((cloth) => cloth.Name) ?? new string[0];
			bool hasVisibleClothes = false;
			ClothesFragment.Frame.Visible = true;
			foreach (Control control in ClothesFragment.Subcontrols)
			{
				if (control is ICheckable checkable)
				{
					string key = (string)control.Tag;
					control.Visible = clothesTo.Contains(key);
					if (!control.Visible)
					{
						checkable.Checked = false;
					}
					else
					{
						control.Style = NPC.Clothes.Contains(key)
							? "buttonOpaqueSelected" : "buttonOpaquePendingable";
						if (!hasVisibleClothes)
						{
							hasVisibleClothes = true;
						}
					}
				}
			}
			if (!hasVisibleClothes)
			{
				ClothesFragment.Frame.Visible = false;
			}
		};
		ClothesFragment.OnChecked += (fragment, selectedClothes) => reallyChangedClothes = true;
	}

	public override void Provide(Type type)
	{
		base.Provide(type);
		Fragment.Panel.VScroll.Value = Fragment.Panel.HScroll.Value = 0;
		Layer = Desktop.Explorer.Amorous.Scene?.GetNPCLayer(type.Name);
		NPC = Layer?.NPC;
		if (NPC == null && Activator.CreateInstance(type, Desktop.Explorer.Amorous) is AbstractNPC npcTo)
		{
			(NPC = npcTo).Start();
		}
		if (NPC == null)
		{
			Logger.Warning("{0} is not an NPC instance!", type);
			return;
		}
		try
		{
			Name = (string)type.GetField("Name", BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).GetValue(null);
		}
		catch (Exception)
		{
			Name = type.Name.TrimSuffix("NPC").ToPersonReadable();
		}
		try
		{
			Color = (Color)type.GetField("Color", BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).GetValue(null);
		}
		catch (Exception)
		{
			Color = Color.White;
		}
		TitleLabel.Text = Name;
		TitleLabel.TextColor = ColorInt.ARGB(Color.A, Color.R, Color.G, Color.B);
		MessageLabel.Text = $"{type.FullName}, {type.Assembly.GetName().Name}";
		IEnumerable<string> inherits = Storages.GetInheritsOf(type, typeof(AbstractNPC));
		if (inherits.Count() > 0)
		{
			MessageLabel.Text += $"\nInherits: {string.Join(", ", inherits)}";
		}
		Variations = NPC.Variations?.ToDictionary((variation) => variation.Name.TrimSuffix("NPC").ToPersonReadable()) ?? new Dictionary<string, Type>(0);
		VariationFragment.Items = Variations.Keys.ToList();
		EmotionFragment.TaggedGroups = new LinkedDictionary<string, IDictionary<string, object>>()
		{
			["Emotions"] = NPC.Emotions.ToDictionary((emotion) => emotion.Name, (emotion) => (object)emotion.Name)
		};
		PoseFragment.TaggedGroups = new LinkedDictionary<string, IDictionary<string, object>>()
		{
			["Poses"] = NPC.Poses.ToDictionary((pose) => pose.Name, (pose) => (object)pose.Name)
		};
		ClothesFragment.TaggedGroups = new LinkedDictionary<string, IDictionary<string, object>>()
		{
			["Clothes"] = new SortedSet<object>(
				NPC.Poses.SelectMany((pose) => pose.Clothes).Select((clothes) => clothes.Name)
			).ToDictionary((cloth) => (string)cloth)
		};
	}

	public virtual void Reload()
	{
		LocationFragment.SelectedItem = NPC.Location.ToString();
		foreach (Control control in LocationFragment.Carousel.Content.Controls)
		{
			if (control is RadioCheckBox box)
			{
				box.Style = box.Text == LocationFragment.SelectedItem
					? "buttonOpaqueSelected" : "buttonOpaquePendingable";
			}
		}
		OrderFragment.SelectedItem = Layer?.Layer.ToString();
		foreach (Control control in OrderFragment.Carousel.Content.Controls)
		{
			if (control is RadioCheckBox box)
			{
				box.Style = box.Text == OrderFragment.SelectedItem
					? "buttonOpaqueSelected" : "buttonOpaquePendingable";
			}
		}
		OrderFragment.Carousel.Enabled = !NPC.IsFixedOrder;
		VariationFragment.Carousel.Visible = VariationFragment.Items.Count() > 0;
		EmotionFragment.SelectedItem = NPC.Head ?? EmotionFragment.Items.FirstOrDefault();
		foreach (Control control in EmotionFragment.Subcontrols)
		{
			if (control is Button box)
			{
				box.Style = box.Text == NPC.Head
					? "buttonOpaqueSelected" : "buttonOpaquePendingable";
			}
		}
		EmotionFragment.Frame.Visible = EmotionFragment.Items.Count() > 0;
		PoseFragment.SelectedItem = NPC.Pose ?? PoseFragment.Items.FirstOrDefault();
		foreach (Control control in PoseFragment.Subcontrols)
		{
			if (control is Button box)
			{
				box.Style = box.Text == NPC.Pose
					? "buttonOpaqueSelected" : "buttonOpaquePendingable";
			}
		}
		PoseFragment.Frame.Visible = PoseFragment.Items.Count() > 0;
		ClothesFragment.SelectedItems = NPC.Clothes;
		if (PoseFragment.SelectedItem != null)
		{
			PoseFragment.OnSelect.Invoke(PoseFragment.Lists["Poses"], PoseFragment.SelectedItem);
		}
		else
		{
			ClothesFragment.Frame.Visible = false;
		}
		ISet<string> options = new SortedSet<string>();
		ISet<string> rejectedOptions = new SortedSet<string>();
		if ((lockedOnScreen = NPC.LockedOnScreen) || Layer == null)
		{
			options.Add(OptionsFragment.KeyOf(0));
		}
		if (NPC.IsFixedOrder)
		{
			options.Add(OptionsFragment.KeyOf(1));
		}
		if (NPC is BreathingNPC breathing)
		{
			if (breathing.Breathing)
			{
				options.Add(OptionsFragment.KeyOf(2));
			}
		}
		else
		{
			rejectedOptions.Add(OptionsFragment.KeyOf(2));
		}
		OptionsFragment.SelectedItems = options;
		foreach (Control control in OptionsFragment.Subcontrols)
		{
			if (control is Button button)
			{
				control.Visible = !rejectedOptions.Contains(button.Text);
				if (control.Visible)
				{
					control.Style = Layer != null && options.Contains(button.Text)
						? "buttonOpaqueSelected" : "buttonOpaquePendingable";
				}
			}
		}
		reallyChangedLocation = reallyChangedClothes = false;
		ApplyButton.Text = "Do it!";
	}

	protected override void InternalAttach(IControlContainer container, IFragment fragment = null)
	{
		base.InternalAttach(container, fragment);
		Reload();
	}

	public override void Update(GameTime gameTime)
	{
		base.Update(gameTime);
		if (!Fragment.Panel.Enabled)
		{
			if (!NPC.IsRefreshing)
			{
				Fragment.Panel.Enabled = true;
				Reload();
			}
		}
		else if (NPC.LockedOnScreen != lockedOnScreen)
		{
			Reload();
		}
		else
		{
			AbstractNPC npcTo = Desktop.Explorer.Amorous.GetNPCLayer(Data.Name) ?? (Layer == null ? NPC : null);
			if (NPC != npcTo)
			{
				Reattach();
			}
			else if (npcTo?.IsRefreshing ?? false)
			{
				Fragment.Panel.Enabled = false;
			}
		}
	}

	public virtual NPCLayer SpawnDialogueNPC(AbstractNPC npc, string location, string order, string emotion, string pose, string[] clothes, bool lockedOnScreen = true)
	{
		npc.LockedOnScreen = lockedOnScreen;
		if (npc.Variations != null)
		{
			foreach (Type type in npc.Variations)
			{
				AbstractNPC npcVariation = Desktop.Explorer.Amorous.Scene?.GetNPCLayer(type.Name)?.NPC;
				if (npcVariation != null && npcVariation.Location != NPCLocation.None)
				{
					if (location == null) location = npcVariation.Location.ToString();
					if (emotion == null) emotion = npcVariation.Head;
					if (pose == null) pose = npcVariation.Pose;
					if (clothes == null) clothes = npcVariation.Clothes;
					npcVariation.Reset();
					break;
				}
			}
		}
		NPCLayer layer = Desktop.Explorer.Amorous.Scene?.GetNPCLayer(npc.GetType().Name);
		if (layer == null || location != "None")
		{
			LayerOrder orderTo = Enum.TryParse<LayerOrder>(order, out var suborder) ? suborder : LayerOrder.None;
			if (layer == null)
			{
				layer = Desktop.Explorer.Amorous.Scene?.AddNPC(npc, (orderTo == LayerOrder.None) ? LayerOrder.Background : orderTo);
			}
			else if (!npc.IsFixedOrder)
			{
				layer.Layer = (orderTo == LayerOrder.None) ? layer.Layer : orderTo;
				layer.ZOrder = (layer.Layer == LayerOrder.Background) ? 1 : 3;
				Desktop.Explorer.Amorous.Scene?.RefreshLayerOrdering();
			}
			if (!Enum.TryParse<NPCLocation>(location, out var locationTo))
			{
				locationTo = npc.Location;
			}
			if (lockedOnScreen)
			{
				locationTo = (locationTo == NPCLocation.None) ? NPCLocation.Middle : locationTo;
			}
			AbstractNPC npcAtLocation = Desktop.Explorer.Amorous.GetNPCLayer(locationTo);
			if (npcAtLocation != null && npc != npcAtLocation)
			{
				npcAtLocation.Reset();
			}
			npc.Apply(locationTo, emotion, pose, clothes);
			if (lockedOnScreen)
			{
				switch (locationTo)
				{
					case NPCLocation.Left:
					case NPCLocation.Right:
						layer.LayerOrder = 0;
						break;
					case NPCLocation.Middle:
						layer.LayerOrder = 1;
						break;
				}
			}
		}
		else
		{
			npc.Reset();
		}
		return layer;
	}
}
