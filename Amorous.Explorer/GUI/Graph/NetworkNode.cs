using System;
using System.Collections.Generic;
using System.Linq;

namespace Amorous.Explorer.GUI.Graph;

public class NetworkNode : IComparable<NetworkNode>, IComparable
{
	public IList<NetworkNode> InputNodes { get; protected set; }
	public IList<NetworkNode> OutputNodes { get; protected set; }

	public bool HasEntry => InputNodes.Count != 0;
	public bool HasTarget => OutputNodes.Count != 0;
	public bool HasConnection => HasEntry || HasTarget;
	public bool IsHub => InputNodes.Count > 1;
	public bool IsRouter => OutputNodes.Count > 1;
	public bool IsLinear => !(IsHub || IsRouter);
	public int Quantity => (InputNodes.Count + 1) / 2 + OutputNodes.Count;

	public int Key { get; internal set; }
	public object Value { get; set; }

	public NetworkNode(int key)
	{
		Key = key;
		InputNodes = new List<NetworkNode>();
		OutputNodes = new List<NetworkNode>();
	}

	public Tuple<ISet<NetworkNode>, ISet<NetworkNode>> GetSortedNodes()
	{
		return new Tuple<ISet<NetworkNode>, ISet<NetworkNode>>(
			new SortedSet<NetworkNode>(InputNodes),
			new SortedSet<NetworkNode>(OutputNodes)
		);
	}

	public void Host(NetworkNode node)
	{
		if (node == null)
		{
			return;
		}
		OutputNodes.Add(node);
		node.InputNodes.Add(this);
	}

	public void Connect(NetworkNode node)
	{
		if (node == null)
		{
			return;
		}
		InputNodes.Add(node);
		node.OutputNodes.Add(this);
	}

	public int CompareTo(NetworkNode node) => node.Quantity - Quantity == 0 ? Key - node.Key : node.Quantity - Quantity;
	public int CompareTo(object obj) => (obj == null || !(obj is NetworkNode node)) ? -1 : CompareTo(node);

	public override bool Equals(object obj)
	{
		if (obj == null || !(obj is NetworkNode))
		{
			return false;
		}
		NetworkNode node = (NetworkNode)obj;
		return node.Key == node.Key
			&& node.InputNodes.SequenceEqual(InputNodes)
			&& node.OutputNodes.SequenceEqual(OutputNodes);
	}

	public override int GetHashCode() => base.GetHashCode();
}
