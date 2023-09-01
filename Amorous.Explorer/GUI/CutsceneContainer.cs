using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using Amorous.Explorer.Data;
using Amorous.Explorer.GUI.Graph;
using Amorous.Explorer.GUI.Json;
using Amorous.Explorer.GUI.Model;
using Amorous.Explorer.GUI.Prototype;
using Amorous.Explorer.GUI.View;
using Amorous.Explorer.GUI.View.Inherits;
using Amorous.Explorer.Reflection;
using Amorous.Explorer.Specialized;
using Microsoft.Xna.Framework;
using Squid;

namespace Amorous.Explorer.GUI;

public class CutsceneContainer : AbstractContainer<Fragment, CutsceneData>
{
	public override Fragment Fragment { get; protected set; } = new Fragment()
	{
		["Expansion"] = new CarouselChoiceFragment()
		{
			MayUnselected = true,
			Items = {
				"Expand",
				"Collapse",
				"Inverse"
			},
			OnSelect = (self, key) => (self.GetContainer() as CutsceneContainer).ChangeExpansion(key)
		},
		["Miscellaneous"] = new FrameFragment()
		{
			Dock = DockStyle.Bottom,
			["Show More"] = new AmorousButton()
			{
				Style = "buttonOpaqueCheckable",
				Size = new Squid.Point(30, 30),
				Dock = DockStyle.Right,
				CheckOnClick = true
			},
			["Follow Track"] = new AmorousButton()
			{
				Style = "buttonOpaqueSwitch",
				Dock = DockStyle.Fill,
				Text = "Follow Track",
				CheckOnClick = true
			}
		},
		["More"] = new ListFragment()
		{
			Dock = DockStyle.Bottom,
			TaggedItems = {
				["Play Cutscene Directly"] = 0,
				["To Mermaid"] = 1
			},
			OnSelect = (self, key) => (self.GetContainer() as CutsceneContainer).DoStuff(key)
		},
		["Reset Cutscene"] = new AmorousButton()
		{
			Style = "buttonOpaque",
			Dock = DockStyle.Bottom,
			Text = "Reset Cutscene"
		},
		["Play Cutscene"] = new AmorousButton()
		{
			Style = "buttonOpaque",
			Dock = DockStyle.Bottom,
			Text = "Play Cutscene"
		},
		["Tree"] = new TreeView()
		{
			Dock = DockStyle.Fill,
			Indent = 5
		}
	};

	protected StartupDesktop StartupDesktop => Desktop as StartupDesktop;
	protected TreeView TreeView => this["Tree"] as TreeView;
	protected CarouselChoiceFragment ExpansionFragment => this["Expansion"] as CarouselChoiceFragment;
	protected ListFragment MoreFragment => this["More"] as ListFragment;
	protected Button FollowTrackButton => GetControl("Follow Track") as Button;
	protected Button ShowMoreButton => GetControl("Show More") as Button;

	public bool InDesignMode { get; protected set; }
	public List<Network> Stages { get; protected set; }
	public List<TreeifyEventNetwork> Treeifiers { get; protected set; }
	public Cutscene Cutscene { get; protected set; }
	public Cutscene StubCutscene { get; protected set; }

	public string Name
	{
		get => Data?.Name;
		set
		{
			if (Data != null)
			{
				Data.Name = value;
			}
		}
	}

	public static CutsceneData StubCutsceneData = new CutsceneData()
	{
		Name = "Indev",
		Stages = {
			new CutsceneStageData()
			{
				Stage = 0,
				StartID = 1,
				Events = {
					new StubEventData()
					{
						ID = 1,
						DebugID = 1
					}
				}
			}
		}
	};

	public CutsceneContainer(AbstractDesktop desktop = null) : base(desktop)
	{
		Stages = new List<Network>();
		Treeifiers = new List<TreeifyEventNetwork>();
		GetControl("Reset Cutscene").MouseClick += (control, eventArgs) => ResetCutscene();
		GetControl("Play Cutscene").MouseClick += (control, eventArgs) => PlayCutscene();
		FollowTrackButton.CheckedChanged += (control) => ChangeFollowTrack((control as ICheckable).Checked);
		ShowMoreButton.CheckedChanged += (control) => ChangeMiscellaneous((control as ICheckable).Checked);
		MoreFragment.Frame.Visible = false;
	}

	private bool followTrack;
	private TreeifyEventNetwork treeifier;
	private int stage, id;

	public virtual void SaveToMermaid()
	{
		StringBuilder sb = new StringBuilder();
		sb.AppendLine($"# {Name}");
		foreach (TreeifyEventNetwork treeifier in Treeifiers)
		{
			sb.AppendLine();
			sb.AppendLine($"## Stage {treeifier.Stage}");
			sb.AppendLine();
			sb.AppendLine("```mermaid");
			sb.Append(treeifier.ToMermaid());
			sb.AppendLine("```");
		}
		string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Markdown", $"{Name}.md");
		Directory.CreateDirectory(Path.GetDirectoryName(path));
		File.WriteAllText(path, sb.ToString());
		Logger.Success("Markdown of cutscene saved to {0}!", Path.GetFileName(path));
	}

	protected void ChangeExpansion(string key)
	{
		if (TreeView.SelectedNode == null)
		{
			if (key == "Expand")
			{
				TreeView.ExpandEverything();
			}
			else if (key == "Collapse")
			{
				TreeView.CollapseEverything();
			}
			else if (key == "Inverse")
			{
				TreeView.InvertEverythingExpansion();
			}
		}
		else
		{
			if (key == "Expand")
			{
				TreeView.SelectedNode.Expand();
			}
			else if (key == "Collapse")
			{
				TreeView.SelectedNode.Collapse();
			}
			else if (key == "Inverse")
			{
				TreeView.SelectedNode.InvertExpansion();
			}
		}
		ExpansionFragment.SelectedItem = null;
	}

	protected void ChangeFollowTrack(bool follow)
	{
		followTrack = follow;
		id = stage = 0;
		if (follow)
		{
			UpdateTrack();
		}
		else if (TreeView.SelectedNode != null)
		{
			TreeView.SelectedNode = null;
		}
	}

	protected void UpdateTrack()
	{
		if (Cutscene?.Stage?.EventData == null)
		{
			if (Cutscene?.IsActive ?? false)
			{
				TreeView.SelectedNode = null;
			}
			return;
		}
		if (stage != (stage = Cutscene.Stage.StageData.Stage))
		{
			treeifier = TreeifierOf(stage);
		}
		else if (id == (id = Cutscene.Stage.EventData.ID))
		{
			return;
		}
		if (treeifier == null || !treeifier.FocusTo(id))
		{
			TreeView.SelectedNode = null;
		}
	}

	public void ChangeMiscellaneous(bool visible)
	{
		MoreFragment.Frame.Visible = visible;
		ShowMoreButton.Checked = visible;
	}

	protected Network NetworkOf(NetworkNode node)
	{
		return Stages.FirstOrDefault((stage) => stage.Contains(node.Key) && stage.NodeByKey[node.Key] == node);
	}

	protected CutsceneStageData StageOf(int stage)
	{
		return Data.Stages.FirstOrDefault((data) => data.Stage == stage);
	}

	protected TreeifyEventNetwork TreeifierOf(int stage)
	{
		return Treeifiers.FirstOrDefault((treeifier) => treeifier.Stage == stage);
	}

	public virtual void Rebuild()
	{
		if (Data == null)
		{
			return;
		}
		CutsceneData data = new CutsceneData()
		{
			Name = Name
		};
		foreach (Network network in Stages)
		{
			CutsceneStageData stage = new CutsceneStageData()
			{
				Stage = network.Key,
				StartID = (int)network.Value
			};
			foreach (NetworkNode node in network.Nodes)
			{
				if (node.Value is EventData eventData)
				{
					stage.Events.Add(eventData);
				}
			}
			data.Stages.Add(stage);
		}
		Data = data;
	}

	protected virtual void PlayCutscene()
	{
		if (StubCutscene == null)
		{
			StubCutscene = new Cutscene(Desktop.Explorer.Amorous, StubCutsceneData, GetType().Assembly);
		}
		if (!StubCutscene.IsActive)
		{
			Desktop.Explorer.Amorous.PlayCutscene(StubCutscene, 0);
		}
		PlayCutsceneDirectly(false);
	}

	protected virtual void PlayCutsceneDirectly(bool directly = true)
	{
		if (Cutscene == null || Cutscene.Data != Data)
		{
			try
			{
				List<Assembly> assemblies = Assemblies.LoadedAssemblies.ToList();
				assemblies.Remove(Assembly.Load("Amorous.Engine"));
				Cutscene = new Cutscene(Desktop.Explorer.Amorous, Data, assemblies.ToArray());
			}
			catch
			{
				Cutscene = new Cutscene(Desktop.Explorer.Amorous, Data, Assembly.Load("Amorous.Game"));
			}
		}
		int? stage = null;
		if (Cutscene.IsActive)
		{
			stage = Cutscene.Stage.StageData.Stage;
			Cutscene.ResetState();
		}
		if (TreeView.SelectedNode != null && TreeView.SelectedNode.Value is NetworkNode node && NetworkOf(node) is Network network)
		{
			if (directly)
			{
				Desktop.Explorer.Amorous.PlayCutscene(Cutscene, network.Key, node.Key);
			}
			else
			{
				Cutscene.Start(network.Key, node.Key);
			}
			return;
		}
		else if (directly)
		{
			Desktop.Explorer.Amorous.PlayCutscene(Cutscene, stage);
			return;
		}
		else if (!stage.HasValue && PlayerPreferences.GetPlayerData() is PlayerData data && data.QuestStages.ContainsKey(Data.Name))
		{
			stage = PlayerPreferences.GetPlayerData().QuestStages[Data.Name];
		}
		Cutscene.Start(stage ?? 10);
	}

	protected virtual void ResetCutscene()
	{
		Desktop.Explorer.Amorous.ResetCutscene();
		StubCutscene?.ResetState();
		Cutscene?.ResetState();
		id = stage = 0;
	}

	protected virtual void DoStuff(string key)
	{
		if (key == "Play Cutscene Directly")
		{
			PlayCutsceneDirectly();
		}
		else if (key == "To Mermaid")
		{
			SaveToMermaid();
		}
		ChangeMiscellaneous(false);
	}

	public override void Provide(CutsceneData data)
	{
		base.Provide(data);
		Stages.Clear();
		foreach (CutsceneStageData stage in data.Stages)
		{
			Network network = new Network();
			network.Key = stage.Stage;
			network.Value = stage.StartID;
			foreach (EventData eventData in stage.Events)
			{
				network.NodeOf(eventData);
			}
			Stages.Add(network);
		}
		TreeView.Nodes.Clear();
		TreeView.SelectedNode = null;
		Treeifiers.Clear();
		foreach (Network network in Stages)
		{
			TreeNodeButton node = new TreeNodeButton()
			{
				Text = $"Stage {network.Key}"
			};
			TreeView.Nodes.Add(node);
			TreeifyEventNetwork treeifier = new TreeifyEventNetwork();
			int startId = (int)network.Value;
			if (startId != 0 && network.Contains(startId))
			{
				treeifier.Enqueue(node, network.NodeByKey[startId]);
			}
			treeifier.Treeify(network, node);
			Treeifiers.Add(treeifier);
		}
		TreeView.SelectedNodeChanged += (control, value) => SelectedNodeChanged(value);
	}

	protected virtual void SelectedNodeChanged(TreeNode tree)
	{
		if (tree == null)
		{
			StartupDesktop.DeattachConstructor();
		}
		else if (tree.Value is NetworkNode node && node.Value != null)
		{
			Network network = NetworkOf(node);
			if (network != null && node.Value is EventData data)
			{
				EventDataContainer container = new EventDataContainer(Desktop)
				{
					Title = $"{data.GetType().Name.TrimSuffix("EventData").ToPersonReadable()} ({network.Key}:{node.Key})",
					OnApply = delegate(JsonContainer container, object value)
					{
						if (value is EventData newData)
						{
							node.Value = newData;
							if (TreeifierOf(network.Key) is TreeifyEventNetwork treeifier)
							{
								treeifier.ExpectNode(node);
							}
							if (StageOf(network.Key) is CutsceneStageData stage)
							{
								for (int i = 0; i < stage.Events.Count; i++)
								{
									if (stage.Events[i].ID == newData.ID)
									{
										stage.Events[i] = newData;
										return;
									}
								}
								stage.Events.Add(newData);
							}
						}
					}
				};
				StartupDesktop.AttachJsonContainer(container, node.Value);
			}
		}
	}

	public override void Update(GameTime gameTime)
	{
		base.Update(gameTime);
		if (MoreFragment.Frame.Visible && Desktop.Explorer.Amorous.Controller.IsPressed(Microsoft.Xna.Framework.Input.Keys.Escape))
		{
			ChangeMiscellaneous(false);
		}
		if (StubCutscene != null && StubCutscene.IsActive)
		{
			if (Cutscene != null && Cutscene.IsActive && StubCutscene.Stage.EventData != null && Desktop.Explorer.Amorous.Cutscene == StubCutscene && !Cutscene.Stage.Update(gameTime))
			{
			}
			else
			{
				StubCutscene.ResetState();
				id = stage = 0;
			}
		}
		else if (Cutscene != null && Cutscene.IsActive)
		{
			if (Cutscene.Stage.EventData != null && Desktop.Explorer.Amorous.Cutscene == Cutscene)
			{
			}
			else if (id != 0 || stage != 0)
			{
				id = stage = 0;
			}
			else
			{
				return;
			}
		}
		else
		{
			return;
		}
		if (followTrack)
		{
			UpdateTrack();
		}
	}
}
