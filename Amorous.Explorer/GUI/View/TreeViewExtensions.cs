using System.Collections.Generic;
using Squid;

namespace Amorous.Explorer.GUI.View;

public static class TreeViewExtensions
{
	public static void ExpandEverything(this TreeView tree)
	{
		foreach (TreeNode node in tree.Nodes)
		{
			Expand(node);
		}
	}

	public static void Expand(this TreeNode node)
	{
		if (node.Nodes.Count > 0)
		{
			node.Expanded = true;
		}
		foreach (TreeNode subnode in node.Nodes)
		{
			Expand(subnode);
		}
	}

	public static void CollapseEverything(this TreeView tree)
	{
		foreach (TreeNode node in tree.Nodes)
		{
			Collapse(node);
		}
	}

	public static void Collapse(this TreeNode node)
	{
		if (node.Nodes.Count > 0)
		{
			node.Expanded = false;
		}
		foreach (TreeNode subnode in node.Nodes)
		{
			Collapse(subnode);
		}
	}

	public static void InvertEverythingExpansion(this TreeView tree)
	{
		foreach (TreeNode node in tree.Nodes)
		{
			InvertExpansion(node);
		}
	}

	public static void InvertExpansion(this TreeNode node)
	{
		if (node.Nodes.Count > 0)
		{
			node.Expanded = !node.Expanded;
		}
		foreach (TreeNode subnode in node.Nodes)
		{
			InvertExpansion(subnode);
		}
	}

	public static void ExpansionWithParents(this TreeNode node, bool collapse = false)
	{
		Queue<TreeNode> nodes = new Queue<TreeNode>();
		while (node != null)
		{
			nodes.Enqueue(node);
			node = node.Parent;
		}
		while (nodes.Count > 0)
		{
			node = nodes.Dequeue();
			node.Expanded = !collapse;
		}
	}

	public static IList<TreeNode> PathTo(this TreeNode parent, TreeNode node)
	{
		List<TreeNode> nodes = new List<TreeNode>();
		if (parent.InspectTreeRecursive(node, nodes))
		{
			return nodes;
		}
		return null;
	}

	private static bool InspectTreeRecursive(this TreeNode parent, TreeNode node, IList<TreeNode> nodes)
	{
		if (parent == node)
		{
			if (nodes.Count > 0)
			{
				nodes.RemoveAt(nodes.Count - 1);
			}
			return true;
		}
		foreach (TreeNode subnode in parent.Nodes)
		{
			int index = nodes.Count;
			nodes.Add(subnode);
			if (subnode.InspectTreeRecursive(node, nodes))
			{
				return true;
			}
			nodes.RemoveAt(index);
		}
		return false;
	}

	public static void ExpansionWithInspect(this TreeNode parent, TreeNode node, bool collapse = false)
	{
		IList<TreeNode> pathTo = parent.PathTo(node);
		if (pathTo != null)
		{
			foreach (TreeNode subnode in pathTo)
			{
				subnode.Expanded = !collapse;
			}
		}
	}

	public static void Expansion(this TreeNode node, TreeNode parent = null, bool collapse = false)
	{
		if (node?.Parent != null)
		{
			node.ExpansionWithParents(collapse);
			return;
		}
		parent?.ExpansionWithInspect(node, collapse);
	}

	public static void ScrollTo(this TreeView tree, TreeNode node)
	{
		float offset = tree.ClipFrame.Size.y;
		float height = tree.ClipFrame.Controls[0].Size.y - offset;
		float scroll = height > 0 ? (node.Position.y - offset) / height : 0;
		tree.Scrollbar.Value = scroll + ((offset + node.Size.y) / height) * 0.5f;
	}

	public static void ScrollTo(this TreeNode node)
	{
		((node as Control).Parent?.Parent?.Parent as TreeView)?.ScrollTo(node);
	}
}
