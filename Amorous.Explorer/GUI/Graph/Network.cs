using System.Collections.Generic;

namespace Amorous.Explorer.GUI.Graph;

public class Network
{
	public IDictionary<int, NetworkNode> NodeByKey { get; protected set; }
	public ISet<NetworkNode> Nodes => new HashSet<NetworkNode>(NodeByKey.Values);
	public ISet<NetworkNode> SortedNodes => new SortedSet<NetworkNode>(NodeByKey.Values);

	public object Value { get; set; }
	public int Key { get; set; }

	public Network()
	{
		NodeByKey = new Dictionary<int, NetworkNode>();
	}

	public bool Contains(int key) => NodeByKey.ContainsKey(key);

	public NetworkNode NodeOf(int key)
	{
		if (NodeByKey.TryGetValue(key, out var node) && node != null)
		{
			return node;
		}
		return NodeByKey[key] = new NetworkNode(key);
	}

	protected NetworkNode Host(NetworkNode node, int keyTo)
	{
		if (node == null)
		{
			return null;
		}
		NetworkNode target = NodeOf(keyTo);
		if (keyTo != 0)
		{
			node.Host(target);
		}
		else
		{
			node.OutputNodes.Add(target);
		}
		return target;
	}

	protected NetworkNode Connect(NetworkNode node, int keyTo)
	{
		if (node == null || keyTo == 0)
		{
			return null;
		}
		NetworkNode target = NodeOf(keyTo);
		node.Connect(target);
		return target;
	}

	public NetworkNode Host(int keyOfHub, int keyTo) => Host(NodeOf(keyOfHub), keyTo);
	public NetworkNode Connect(int keyOfHub, int keyTo) => Connect(NodeOf(keyOfHub), keyTo);
}
