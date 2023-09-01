using System;
using System.Collections.Generic;
using System.IO;
using Amorous.Explorer.Data;
using Amorous.Explorer.GUI.Json;
using Amorous.Explorer.GUI.Model;
using Amorous.Explorer.GUI.Prototype;
using Amorous.Explorer.GUI.View.Inherits;
using Amorous.Explorer.Reflection;
using Amorous.Explorer.Specialized;
using Amorous.Game.Scenes;
using Microsoft.Xna.Framework;
using Squid;

namespace Amorous.Explorer.GUI;

public class GameplayContainer : AbstractContainer<Fragment, object>
{
	public override Fragment Fragment { get; protected set; } = new Fragment()
	{
		["Time Label"] = new AmorousLabel()
		{
			Text = "Time"
		},
		["Time Hour"] = new AmorousSlider()
		{
			Minimum = 0f,
			Maximum = 23f
		},
		// Unused
		/* ["Time Minute"] = new AmorousSlider()
		{
			Minimum = 0f,
			Maximum = 59f
		}, */
		["Use Real Time"] = new AmorousButton()
		{
			Style = "buttonOpaqueSwitch",
			Text = "Use Real Time",
			CheckOnClick = true
		},
		["Scene"] = new AmorousLabel()
		{
			Text = "Gameplay"
		},
		["Reset Scene"] = new DangerousButton()
		{
			Text = "Reset Scene"
		},
		["Reset Sexscene"] = new DangerousButton()
		{
			Text = "Reset Sexscene"
		},
		["Reset Cutscene"] = new DangerousButton()
		{
			Text = "Reset Cutscene"
		},
		["Freezing"] = new CarouselPanelFragment()
		{
			["Updating"] = new AmorousButton()
			{
				Dock = DockStyle.Left,
				Style = "buttonOpaqueSwitch",
				Text = "Updating",
				CheckOnClick = true
			},
			["Drawing"] = new AmorousButton()
			{
				Dock = DockStyle.Left,
				Style = "buttonOpaqueSwitch",
				Text = "Drawing",
				CheckOnClick = true
			}
		},
		["Subscenes"] = new GrouppedListFragment()
		{
			Mode = ChoiceMode.Single,
			MayUnselected = false,
			RadioBetweenGroups = false,
			OnGroupSelect = (self, group, key) => (self.GetContainer() as GameplayContainer)
				.SelectSubscene(group, (string)(self as GrouppedListFragment).Lists[group].TagOf(key)),
			OnBeforePrepareToAttach = (self, container, fragment) => (self.GetContainer() as GameplayContainer)
				.PrepareToAttachSubscenes()
		},
		["Flags Label"] = new AmorousLabel()
		{
			Text = "Flags"
		},
		["Flags"] = new CarouselPanelFragment()
		{
			["Show Me Some Booty"] = new AmorousButton()
			{
				Dock = DockStyle.Left,
				Style = "buttonOpaqueSwitch",
				Text = "Show Me Some Booty",
				CheckOnClick = true
			},
			["Non Steam"] = new AmorousButton()
			{
				Dock = DockStyle.Left,
				Style = "buttonOpaqueSwitch",
				Text = "Non Steam",
				CheckOnClick = true
			}
		},
		["Censorship"] = new CarouselPanelFragment()
		{
			["Censored"] = new AmorousButton()
			{
				Dock = DockStyle.Left,
				Style = "buttonOpaqueSwitch",
				Text = "Censored",
				CheckOnClick = true
			},
			["Topless"] = new AmorousButton()
			{
				Dock = DockStyle.Left,
				Style = "buttonOpaqueSwitch",
				Text = "Topless",
				CheckOnClick = true
			},
			["Bottomless"] = new AmorousButton()
			{
				Dock = DockStyle.Left,
				Style = "buttonOpaqueSwitch",
				Text = "Bottomless",
				CheckOnClick = true
			}
		},
		["Tests"] = new AmorousLabel()
		{
			Text = "Tests"
		},
		["Convert Cutscenes To Mermaid"] = new AmorousButton()
		{
			Text = "Convert Cutscenes To Mermaid"
		},
		["Resolve Json Contracts"] = new AmorousButton()
		{
			Text = "Resolve Json Contracts"
		},
		["Overscrolling Label"] = new AmorousLabel()
		{
			Text = "Overscrolling"
		},
		["Overscrolling"] = new CarouselPanelFragment()
		{
			MeasuredWidth = 90,
			["Overscrolling Left"] = new AmorousTextBox()
			{
				Dock = DockStyle.Left,
				Text = "-2000"
			},
			["Overscrolling Right"] = new AmorousTextBox()
			{
				Dock = DockStyle.Left,
				Text = "2000"
			},
			["Overscrolling Top"] = new AmorousTextBox()
			{
				Dock = DockStyle.Left,
				Text = "-2000"
			},
			["Overscrolling Bottom"] = new AmorousTextBox()
			{
				Dock = DockStyle.Left,
				Text = "2000"
			}
		},
		OnBeforeAttach = (self, container, fragment) => (self.GetContainer() as GameplayContainer)
			.UpdateBeforeAttach()
	};

	protected StartupDesktop StartupDesktop => Desktop as StartupDesktop;
	protected Slider TimeHourSlider => this["Time Hour"] as Slider;
	protected Button UseRealTimeButton => this["Use Real Time"] as Button;
	protected GrouppedListFragment SubsceneFragment => this["Subscenes"] as GrouppedListFragment;
	protected Button UpdatingButton => GetControl("Updating") as Button;
	protected Button DrawingButton => GetControl("Drawing") as Button;
	protected DangerousButton ResetSceneButton => this["Reset Scene"] as DangerousButton;
	protected DangerousButton ResetSexsceneButton => this["Reset Sexscene"] as DangerousButton;
	protected DangerousButton ResetCutsceneButton => this["Reset Cutscene"] as DangerousButton;
	protected Button ShowMeSomeBootyButton => GetControl("Show Me Some Booty") as Button;
	protected Button NonSteamButton => GetControl("Non Steam") as Button;
	protected Button CensoredButton => GetControl("Censored") as Button;
	protected Button ToplessButton => GetControl("Topless") as Button;
	protected Button BottomlessButton => GetControl("Bottomless") as Button;
	protected CarouselPanelFragment OverscrollingCarousel => this["Overscrolling"] as CarouselPanelFragment;

	public GameplayContainer(AbstractDesktop desktop = null) : base(desktop)
	{
		TimeHourSlider.ValueChanged += delegate(Control control)
		{
			if (!internallyUpdating)
			{
				Clocks.Hour = (int)(control as Slider).Value;
				Clocks.InRealTime = false;
			}
		};
		UseRealTimeButton.CheckedChanged += delegate(Control control)
		{
			if (!internallyUpdating)
			{
				Clocks.InRealTime = ((ICheckable)control).Checked;
			}
		};
		ResetSceneButton.MouseAccept += (control) => ResetScene();
		ResetSexsceneButton.MouseAccept += (control) => ResetSexscene();
		ResetCutsceneButton.MouseAccept += (control) => ResetCutscene();
		GetControl("Convert Cutscenes To Mermaid").MouseClick += delegate(Control control, MouseEventArgs eventArgs)
		{
			foreach (string path in StartupDesktop.ListingContainer.CutscenesFragment.Tags)
			{
				string subpath = Path.ChangeExtension(path, null);
				if (subpath.Contains("Quests"))
				{
					subpath = subpath.Substring(subpath.IndexOf("Quests") + 7);
				}
				Cutscene cutscene = Desktop.Explorer.Amorous.ReadCutscene(subpath);
				if (cutscene != null)
				{
					StartupDesktop.CutsceneContainer.Provide(cutscene.Data);
					StartupDesktop.CutsceneContainer.SaveToMermaid();
				}
			}
		};
		GetControl("Resolve Json Contracts").MouseClick += delegate(Control control, MouseEventArgs eventArgs)
		{
			JsonContainer container = new JsonContainer(Desktop)
			{
				OnApply = delegate(JsonContainer container, object value)
				{
					Desktop.Explorer.Amorous.LoadCutscene(value as CutsceneState);
				}
			};
			StartupDesktop.AttachJsonContainer(container, Desktop.Explorer.Amorous.GetCutsceneState());
		};
		UpdatingButton.CheckedChanged += delegate(Control control)
		{
			if (!internallyUpdating)
			{
				Desktop.Explorer.IsInternallyInterrupted = false;
				Desktop.Explorer.IsUpdateInterrupted = !((ICheckable)control).Checked;
			}
		};
		DrawingButton.CheckedChanged += delegate(Control control)
		{
			if (!internallyUpdating)
			{
				Desktop.Explorer.IsInternallyInterrupted = false;
				Desktop.Explorer.IsDrawInterrupted = !((ICheckable)control).Checked;
			}
		};
		ShowMeSomeBootyButton.CheckedChanged += delegate(Control control)
		{
			if (!internallyUpdating) Censorship.SetBooties(ChangeFlag("ShowMeSomeBooty", ((ICheckable)control).Checked));
		};
		NonSteamButton.CheckedChanged += delegate(Control control)
		{
			if (!internallyUpdating)
			{
				if (!ChangeFlag("NonSteam", ((ICheckable)control).Checked) && !Desktop.Explorer.Amorous.Achievements.IsSteamSupported)
				{
					Desktop.Explorer.Amorous.Initialize();
				}
			}
		};
		CensoredButton.CheckedChanged += delegate(Control control)
		{
			if (!internallyUpdating) Censorship.Censored = ((ICheckable)control).Checked;
		};
		ToplessButton.CheckedChanged += delegate(Control control)
		{
			if (!internallyUpdating) Censorship.Topless = ((ICheckable)control).Checked;
		};
		BottomlessButton.CheckedChanged += delegate(Control control)
		{
			if (!internallyUpdating) Censorship.Bottomless = ((ICheckable)control).Checked;
		};
		(OverscrollingCarousel["Overscrolling Left"] as TextBox).TextChanged += (control) => UpdateOverscrolling();
		(OverscrollingCarousel["Overscrolling Right"] as TextBox).TextChanged += (control) => UpdateOverscrolling();
		(OverscrollingCarousel["Overscrolling Top"] as TextBox).TextChanged += (control) => UpdateOverscrolling();
		(OverscrollingCarousel["Overscrolling Bottom"] as TextBox).TextChanged += (control) => UpdateOverscrolling();
	}

	private bool internallyUpdating;
	private AbstractScene scene;
	private string subscene;
	private AbstractSexscene sexscene;
	private string subsexscene;

	protected virtual void UpdateOverscrolling()
	{
		Desktop.Explorer.Amorous.Canvas.SetOverscroll(
			int.TryParse((OverscrollingCarousel["Overscrolling Left"] as TextBox).Text, out var offset) ? offset : 0,
			int.TryParse((OverscrollingCarousel["Overscrolling Right"] as TextBox).Text, out offset) ? offset : 0,
			int.TryParse((OverscrollingCarousel["Overscrolling Top"] as TextBox).Text, out offset) ? offset : 0,
			int.TryParse((OverscrollingCarousel["Overscrolling Bottom"] as TextBox).Text, out offset) ? offset : 0
		);
	}

	protected virtual void UpdateBeforeAttach()
	{
		internallyUpdating = true;
		ShowMeSomeBootyButton.Checked = ChangeFlag("ShowMeSomeBooty");
		NonSteamButton.Checked = ChangeFlag("NonSteam");
		internallyUpdating = false;
	}

	protected bool ChangeFlag(string filename, bool? enabled = null)
	{
		string file = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, filename);
		bool exists1 = File.Exists(file), exists2 = File.Exists($"{file}.txt");
		if (enabled.HasValue)
		{
			if (enabled.Value)
			{
				if (!(exists1 || exists2))
				{
					using (File.Create(file)) {}
				}
			}
			else
			{
				if (exists1)
				{
					File.Delete(file);
				}
				if (exists2)
				{
					File.Delete($"{file}.txt");
				}
			}
			return enabled.Value;
		}
		return exists1 || exists2;
	}

	protected void ResetScene()
	{
		Desktop.Explorer.Amorous.SwitchToScene<EmptyScene>();
	}

	protected void ResetSexscene()
	{
		Desktop.Explorer.Amorous.ResetSexscene();
	}

	protected void ResetCutscene()
	{
		Desktop.Explorer.Amorous.ResetCutscene();
	}

	protected void SelectSubscene(string group, string subscene)
	{
		if (group == "Subscenes")
		{
			scene?.SwitchToSubscene(subscene);
		}
		else
		{
			sexscene?.SwitchToSubscene(subscene);
		}
	}

	protected void PrepareToAttachSubscenes()
	{
		SubsceneFragment.TaggedGroups = new LinkedDictionary<string, IDictionary<string, object>>()
		{
			["Subscenes"] = Convertions.ToObjectDictionary(
				Readables.ToPersonReadableDictionary(Assemblies.ResolveSubscenesOfType(scene?.GetType()))
			),
			["Sexscenes"] = Convertions.ToObjectDictionary(
				Readables.ToPersonReadableDictionary(sexscene?.GetSubscenes() ?? new string[0])
			)
		};
	}

	public override void Update(GameTime gameTime)
	{
		base.Update(gameTime);
		internallyUpdating = true;
		TimeHourSlider.Value = Clocks.Hour;
		UseRealTimeButton.Checked = Clocks.InRealTime;
		UpdatingButton.Checked = !Desktop.Explorer.IsUpdateInterrupted;
		DrawingButton.Checked = !Desktop.Explorer.IsDrawInterrupted;
		if (scene != (scene = Desktop.Explorer.Amorous.Scene))
		{
			SubsceneFragment.Reattach();
		}
		if (subscene != (subscene = scene?.Subscene))
		{
			SubsceneFragment.Lists["Subscenes"].SelectedItem = subscene?.ToPersonReadable();
		}
		if (sexscene != (sexscene = Desktop.Explorer.Amorous.Sexscene))
		{
			SubsceneFragment.Reattach();
		}
		if (subsexscene != (subsexscene = sexscene?.Subscene))
		{
			SubsceneFragment.Lists["Sexscenes"].SelectedItem = subsexscene?.ToPersonReadable();
		}
		CensoredButton.Checked = Censorship.Censored;
		ToplessButton.Checked = Censorship.Topless;
		BottomlessButton.Checked = Censorship.Bottomless;
		internallyUpdating = false;
	}
}
