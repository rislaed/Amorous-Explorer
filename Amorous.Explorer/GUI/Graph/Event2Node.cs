using System;
using Amorous.Engine.Data.Cutscenes;
using Amorous.Game.Data.Cutscenes;

namespace Amorous.Explorer.GUI.Graph;

public static class Event2Node
{
	private static NetworkNode NodeOfPrototype(this Network network, EventData data, bool standard = true)
	{
		NetworkNode node = network.NodeOf(data.ID);
		if (node != null)
		{
			node.Value = data;
			if (standard)
			{
				network.Host(node.Key, data.NextID);
			}
		}
		return node;
	}

	private static NetworkNode NodeOf(this Network network, CensorCheckEventData data)
	{
		NetworkNode node = network.NodeOfPrototype(data, false);
		if (node != null)
		{
			network.Host(node.Key, data.NSFWID);
			network.Host(node.Key, data.SFWID);
		}
		return node;
	}

	private static NetworkNode NodeOf(this Network network, ConditionalBranchEventData data)
	{
		NetworkNode node = network.NodeOfPrototype(data, false);
		if (node != null)
		{
			network.Host(node.Key, data.TrueID);
			network.Host(node.Key, data.FalseID);
		}
		return node;
	}

	private static NetworkNode NodeOf(this Network network, DialogueChoiceEventData data)
	{
		NetworkNode node = network.NodeOfPrototype(data, false);
		if (node != null && data.Choices != null)
		{
			foreach (DialogueChoiceItem dialogue in data.Choices)
			{
				network.Host(node.Key, dialogue.NextID);
			}
		}
		return node;
	}

	private static NetworkNode NodeOf(this Network network, JaxContactsCheckEventData data)
	{
		NetworkNode node = network.NodeOfPrototype(data, false);
		if (node != null)
		{
			network.Host(node.Key, data.OnlyJaxID);
			network.Host(node.Key, data.OneOrTwoID);
			network.Host(node.Key, data.ThreeOrMoreID);
		}
		return node;
	}

	public static NetworkNode NodeOf(this Network network, EventData data)
	{
		if (data == null || data.ID == 0)
		{
			return network.NodeOf(0);
		}
		if (network.Contains(data.ID))
		{
			NetworkNode node = network.NodeOf(data.ID);
			if (node.Value is EventData)
			{
				return node;
			}
		}
		if (data is CensorCheckEventData censor)
		{
			return network.NodeOf(censor);
		}
		if (data is ConditionalBranchEventData conditional)
		{
			return network.NodeOf(conditional);
		}
		if (data is DialogueChoiceEventData dialogue)
		{
			return network.NodeOf(dialogue);
		}
		if (data is JaxContactsCheckEventData jax)
		{
			return network.NodeOf(jax);
		}
		return network.NodeOfPrototype(data);
	}
}
