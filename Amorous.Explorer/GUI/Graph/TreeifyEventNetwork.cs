using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Amorous.Engine.Data.Cutscenes;
using Amorous.Explorer.Data;
using Amorous.Explorer.GUI.View;
using Amorous.Game.Data.Cutscenes;
using Newtonsoft.Json;
using Squid;

namespace Amorous.Explorer.GUI.Graph;

public enum MermaidNodeMode
{
	None,
	Key,
	Message,
	KeyWithMessage
}

public class TreeifyEventNetwork
{
	protected Stack<Tuple<TreeNode, NetworkNode>> PendingNodes { get; }
	protected Dictionary<int, TreeNode> Controls { get; }
	protected HashSet<int> UsedIDs { get; }
	protected Stack<TreeNode> ExpectedLinks { get; }
	protected bool ExpectingResearch { get; set; }
	protected Network Network { get; set; }
	protected TreeNode ParentNode { get; set; }

	public int Stage => Network?.Key ?? 0;

	public TreeifyEventNetwork()
	{
		PendingNodes = new Stack<Tuple<TreeNode, NetworkNode>>();
		Controls = new Dictionary<int, TreeNode>();
		UsedIDs = new HashSet<int>() { 0 };
		ExpectedLinks = new Stack<TreeNode>();
	}

	public virtual void Enqueue(TreeNode tree, NetworkNode network) => PendingNodes.Push(new Tuple<TreeNode, NetworkNode>(tree, network));

	public void Treeify(Network network, TreeNode unusedTree = null)
	{
		Network = network;
		ParentNode = unusedTree;
		while (PendingNodes.Count > 0)
		{
			Tuple<TreeNode, NetworkNode> which = PendingNodes.Pop();
			InspectNetwork(which.Item1, which.Item2);
			ExpectingResearch = false;
		}
		if (unusedTree != null)
		{
			IEnumerable<int> keys = network.NodeByKey.Keys;
			if (UsedIDs.SetEquals(keys))
			{
				return;
			}
			keys = keys.Except(UsedIDs);
			TreeNode subtree = ExpectOf(unusedTree, "Disconnected nodes", "buttonOpaqueLocked");
			foreach (NetworkNode node in network.SortedNodes)
			{
				if (keys.Contains(node.Key))
				{
					InspectNetworkTree(subtree, node);
					while (PendingNodes.Count > 0)
					{
						Tuple<TreeNode, NetworkNode> which = PendingNodes.Pop();
						InspectNetwork(which.Item1, which.Item2);
						ExpectingResearch = false;
					}
					keys = keys.Except(UsedIDs);
				}
			}
		}
		TryExpectingLinks();
		if (ExpectedLinks.Count > 0)
		{
			Logger.Warning("Found missing entries: {0} (stage {1})!", string.Join(", ", new SortedSet<int>(ExpectedLinks.Select((tuple) => Convert.ToInt32(tuple.Value)))), network.Key);
		}
	}

	protected virtual void TryExpectingLinks(int key = 0)
	{
		Stack<TreeNode> links = new Stack<TreeNode>();
		while (ExpectedLinks.Count > 0)
		{
			TreeNode node = ExpectedLinks.Pop();
			if (node.Value is int tag)
			{
				if ((key == 0 || key == tag) && Controls.ContainsKey(tag))
				{
					ExpectLink(node, Controls[tag]);
				}
				else
				{
					links.Push(node);
				}
			}
		}
		while (links.Count > 0)
		{
			ExpectedLinks.Push(links.Pop());
		}
	}

	protected void InspectNetwork(TreeNode tree, NetworkNode network)
	{
		if ((network?.Key ?? 0) == 0)
		{
			InspectNetworkExit(tree);
			return;
		}
		if (UsedIDs.Contains(network.Key))
		{
			TreeNode node = ExpectOf(tree);
			node.SelectedChanged += ScrollToLink;
			if (Controls.ContainsKey(network.Key))
			{
				ExpectLink(node, Controls[network.Key]);
			}
			else
			{
				ExpectInvalidLink(node, network.Key);
			}
			return;
		}
		if (network.IsRouter && ExpectingResearch)
		{
			Enqueue(tree, network);
			return;
		}
		UsedIDs.Add(network.Key);
		if (network.IsRouter)
		{
			InspectNetworkTree(tree, network);
			ExpectingResearch = true;
			return;
		}
		InspectNetworkNode(tree, network);
		if (network.HasTarget)
		{
			InspectNetwork(tree, network.OutputNodes[0]);
		}
	}

	protected virtual void InspectNetworkTree(TreeNode tree, NetworkNode network)
	{
		EventData data = network.Value as EventData;
		TreeNode node = InspectNetworkNode(tree, network);
		if (data is CensorCheckEventData censor)
		{
			Enqueue(ExpectOf(node, "Not Safe For Work", "buttonOpaqueLocked"), network.OutputNodes[0]);
			Enqueue(ExpectOf(node, "Safe For Work", "buttonOpaqueSelected"), network.OutputNodes[1]);
		}
		else if (data is ConditionalBranchEventData conditional)
		{
			Enqueue(ExpectOf(node, "True", "buttonOpaqueSelected"), network.OutputNodes[0]);
			Enqueue(ExpectOf(node, "False", "buttonOpaqueLocked"), network.OutputNodes[1]);
		}
		else if (data is DialogueChoiceEventData dialogue)
		{
			int index = 0;
			foreach (NetworkNode choice in network.OutputNodes)
			{
				Enqueue(ExpectConditionOf(node, dialogue.Choices[index++].Text), choice);
			}
		}
		else if (data is JaxContactsCheckEventData jax)
		{
			Enqueue(ExpectConditionOf(node, "Only Jax"), network.OutputNodes[0]);
			Enqueue(ExpectConditionOf(node, "One or Two"), network.OutputNodes[1]);
			Enqueue(ExpectConditionOf(node, "Three or More"), network.OutputNodes[2]);
		}
		else
		{
			foreach (NetworkNode subnode in network.OutputNodes)
			{
				Enqueue(node, subnode);
			}
		}
	}

	protected virtual TreeNode Expect(TreeNode node, string label = null, string style = null, string expanderStyle = null)
	{
		if (label != null && node is IText text)
		{
			text.Text = label;
		}
		if (node is TreeNodeButton button)
		{
			if (style != null)
			{
				button.Button.Style = style;
				if (expanderStyle == null)
				{
					button.Expander.Style = style;
				}
			}
			if (expanderStyle != null)
			{
				button.Expander.Style = expanderStyle;
			}
		}
		else if (style != null)
		{
			node.Style = style;
		}
		return node;
	}

	protected virtual TreeNode ExpectOf(TreeNode parent, string label = null, string style = null, string expanderStyle = null)
	{
		TreeNodeButton button = new TreeNodeButton();
		parent.Nodes.Add(button);
		return Expect(button, label, style, expanderStyle);
	}

	protected virtual TreeNode ExpectConditionOf(TreeNode tree, string label = null) => ExpectOf(tree, label, "buttonOpaquePendingable", "buttonOpaqueQueued");

	protected void ScrollToLink(Control control)
	{
		TreeNode node = control as TreeNode;
		if (node != null && node.Selected)
		{
			node.Selected = false;
			if (node.Value is TreeNode target)
			{
				FocusTo(target);
			}
			else if (node.Value is int key)
			{
				TryExpectingLinks(key);
			}
			else
			{
				throw new InvalidOperationException();
			}
		}
	}

	public virtual void FocusTo(TreeNode node)
	{
		if (node == null)
		{
			return;
		}
		node.Expansion(ParentNode);
		node.ScrollTo();
		if (!(node.Value is TreeNode || node.Value is int))
		{
			if (node.Nodes.Count == 0)
			{
				node.Selected = true;
			}
			else if (!node.Expanded)
			{
				node.Expanded = true;
			}
			else
			{
				node.Selected = true;
			}
		}
	}

	public virtual bool FocusTo(int key)
	{
		if (Controls.TryGetValue(key, out var node))
		{
			FocusTo(node);
			return true;
		}
		return false;
	}

	protected virtual void ExpectLink(TreeNode node, TreeNode target)
	{
		node.Value = target;
		if (target.Value is NetworkNode network)
		{
			Expect(node, $"{network.Key} : {ToString(network)}", "buttonOpaqueQueued");
		}
		else if (target.Value is int key)
		{
			ExpectInvalidLink(node, key);
		}
		else
		{
			throw new InvalidOperationException();
		}
	}

	protected virtual void ExpectInvalidLink(TreeNode node, int key)
	{
		node.Value = key;
		Expect(node, $"{key} : Not found!", "buttonOpaqueLocked");
		if (!ExpectedLinks.Contains(node))
		{
			ExpectedLinks.Push(node);
		}
	}

	protected virtual TreeNode InspectNetworkNode(TreeNode tree, NetworkNode network)
	{
		TreeNode node = ExpectOf(tree, $"{network.Key}. {ToString(network)}");
		node.Value = network;
		return Controls[network.Key] = node;
	}

	protected virtual void InspectNetworkExit(TreeNode tree) => ExpectOf(tree, "End of Sequence", "buttonOpaqueLocked");

	public virtual bool ExpectNode(NetworkNode network)
	{
		if (Controls.TryGetValue(network.Key, out var node))
		{
			ExpectNode(node, network);
			return true;
		}
		return false;
	}

	protected virtual void ExpectNode(TreeNode tree, NetworkNode network, TreeNode parent = null)
	{
		if ((parent = parent ?? ParentNode) == null)
		{
			return;
		}
		if (parent.Value is NetworkNode networkTo)
		{
			if (networkTo == network)
			{
				Expect(parent, $"{network.Key}. {ToString(network)}");
			}
		}
		else if ((parent.Value is TreeNode treeTo && treeTo == tree) || (parent.Value is int tag && tag == network.Key))
		{
			ExpectLink(parent, tree);
		}
		foreach (TreeNode node in parent.Nodes)
		{
			ExpectNode(tree, network, node);
		}
	}

	public virtual bool SelectNode(int key)
	{
		if (Controls.TryGetValue(key, out var node))
		{
			node.Selected = true;
			return true;
		}
		return false;
	}

	protected virtual string ConnectMermaidNodes(NetworkNode node, NetworkNode subnode, int index = -1)
	{
		EventData data = node.Value as EventData;
		string label = null;
		if (data is CensorCheckEventData censor)
		{
			if (index == 0)
			{
				label = "Not Safe For Work";
			}
			else if (index == 1)
			{
				label = "Safe For Work";
			}
		}
		else if (data is ConditionalBranchEventData conditional)
		{
			if (index == 0)
			{
				label = "True";
			}
			else if (index == 1)
			{
				label = "False";
			}
		}
		else if (data is DialogueChoiceEventData dialogue)
		{
			if (index >= 0 && index < dialogue.Choices.Count)
			{
				label = dialogue.Choices[index].Text;
			}
		}
		else if (data is JaxContactsCheckEventData jax)
		{
			if (index == 0)
			{
				label = "Only Jax";
			}
			else if (index == 1)
			{
				label = "One or Two";
			}
			else if (index == 2)
			{
				label = "Three or More";
			}
		}
		return label == null ? $"{node.Key} --> {subnode.Key}" : $"{node.Key} -- {Jsons.ToMermaidString(label)} --> {subnode.Key}";
	}

	public virtual string ToMermaid(Network network = null, MermaidNodeMode mode = MermaidNodeMode.KeyWithMessage)
	{
		if ((network = network ?? Network) == null)
		{
			throw new ArgumentNullException("network");
		}
		StringBuilder sb = new StringBuilder();
		sb.AppendLine("flowchart TB");
		int keyOfEntry = Convert.ToInt32(network.Value);
		foreach (NetworkNode node in network.NodeByKey.OrderBy(
			(pair) => pair.Key).Select((pair) => pair.Value)
		)
		{
			if (node.Key == 0)
			{
				continue;
			}
			if (mode != MermaidNodeMode.Key)
			{
				sb.Append(node.Key);
				if (keyOfEntry == node.Key)
				{
					sb.Append('(');
				}
				sb.Append('[');
				string value = ToString(node, mode);
				if (mode == MermaidNodeMode.KeyWithMessage)
				{
					value = $"{node.Key}. {value}";
				}
				sb.Append(Jsons.ToMermaidString(value));
				sb.Append(']');
				if (keyOfEntry == node.Key)
				{
					sb.Append(')');
				}
				sb.AppendLine();
			}
			else if (keyOfEntry == node.Key)
			{
				sb.AppendLine($"{node.Key}([{node.Key}])");
			}
		}
		HashSet<string> nodes = new HashSet<string>();
		int indexOfExit = 0;
		foreach (NetworkNode node in network.SortedNodes)
		{
			if (node.Key == 0)
			{
				continue;
			}
			int index = 0;
			foreach (NetworkNode subnode in node.OutputNodes)
			{
				string value = ConnectMermaidNodes(node, subnode, index++);
				if (subnode.Key == 0)
				{
					sb.AppendLine($"exit{indexOfExit}[/\"End\"/]");
					nodes.Add($"{value.TrimEnd('0')}exit{indexOfExit++}");
					continue;
				}
				nodes.Add(value);
			}
		}
		foreach (string node in nodes)
		{
			sb.AppendLine(node);
		}
		return sb.ToString();
	}

	private static string Shrink(string source, int length)
		=> (length - source.Length) < 0 ? source.Substring(0, length - 3) + "..." : source;

	public virtual string ToString(NetworkNode node, MermaidNodeMode mode = MermaidNodeMode.None)
	{
		if (!(node.Value is EventData data))
		{
			if (node.Value == null)
			{
				return "Error";
			}
			return node.Value?.GetType().Name.ToPersonReadable();
		}
		if (data is DelayEventData delay)
		{
			return $"Delay: {delay.Delay}ms";
		}
		if (data is DisableContactEventData disableContact)
		{
			return $"Disable Contact: {disableContact.Contact}";
		}
		if (data is PlayDialogueEventData playDialogue)
		{
			string message = playDialogue.Text
				?.Replace("\r", "").Replace("░", "")
				.Replace("%playername%", PlayerPreferences.GetPlayerData()?.Name)
				.Trim();
			if (mode == MermaidNodeMode.None)
			{
				message = message?.Replace("\n", " ").Replace("<i>", "").Replace("</i>", "");
			}
			return playDialogue.Title == "%playername%"
				? message : $"{playDialogue.Title}: {message}";
		}
		if (data is PlaySexsceneEventData playSexscene)
		{
			string scene = playSexscene.SceneName;
			if (scene.EndsWith("Scene"))
			{
				scene = scene.Substring(0, scene.Length - 5);
			}
			return $"Play Sexscene: {scene.ToPersonReadable()}";
		}
		if (data is SetFlagEventData setFlag)
		{
			return $"{setFlag.Flag} = {setFlag.Value}";
		}
		if (data is ConditionalBranchEventData conditionalBranch)
		{
			return conditionalBranch.Flag;
		}
		if (data is SetStageEventData setStage)
		{
			return $"{setStage.Quest} = {setStage.Stage}";
		}
		if (data is SpawnNPCEventData spawnNPC)
		{
			string npc = spawnNPC.NPC;
			if (npc.EndsWith("NPC"))
			{
				npc = npc.Substring(0, npc.Length - 3);
			}
			if (spawnNPC.Location == "None")
			{
				return $"Despawn NPC: {npc}";
			}
			if (spawnNPC.Location != null)
			{
				return $"Spawn NPC: {npc} to {spawnNPC.Location}";
			}
			return $"Change NPC: {npc}";
		}
		if (data is SwitchToSceneEventData switchToScene)
		{
			string scene = switchToScene.SceneName;
			if (scene.EndsWith("Scene"))
			{
				scene = scene.Substring(0, scene.Length - 5);
			}
			return $"Switch to Scene: {scene.ToPersonReadable()}";
		}
		if (data is SwitchToSubsceneEventData switchToSubscene)
		{
			return $"Switch to Subscene: {switchToSubscene.SubsceneName.ToPersonReadable()}";
		}
		if (data is CommandEventData command)
		{
			return $"Command: {command.Command}";
		}
		string name = data.GetType().Name;
		if (name.EndsWith("EventData"))
		{
			name = name.Substring(0, name.Length - 9);
		}
		if (data is UnlockContactEventData unlockContact)
		{
			return $"{name.ToPersonReadable()}: {unlockContact.Contact}";
		}
		return name.ToPersonReadable();
	}
}
