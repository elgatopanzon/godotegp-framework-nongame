/**
 * @author      : ElGatoPanzon (contact@elgatopanzon.io) Copyright (c) ElGatoPanzon
 * @file        : SceneTree
 * @created     : Saturday Dec 30, 2023 21:46:46 CST
 */

namespace Godot;

using GodotEGP.Logging;
using GodotEGP.Misc;
using GodotEGP.Objects.Extensions;
using GodotEGP.Event.Events;

public partial class SceneTree : Node
{
	private Viewport _root;

	public Viewport Root
	{
		get { 
			return _root;
		}
	}

	public static List<Node> Nodes = new();

	// Lazy singleton instance
	private static readonly Lazy<SceneTree> _instance = 
		new Lazy<SceneTree>(
			() => new SceneTree(), isThreadSafe: true
		);

	public static SceneTree Instance {
		get { return _instance.Value; }
	}

	public SceneTree()
	{
		LoggerManager.LogDebug("Creating SceneTree instance");

		_root = new Viewport();
	}

	public void AddNode(Node node)
	{
		if (!Nodes.Contains(node))
		{
			LoggerManager.LogDebug("Adding node to scene", "", "node", $"id:{node.GetInstanceId()} name:{node.Name} type:{node.GetType().FullName}");
			LoggerManager.LogDebug("", "", "nodeParent", $"id:{node.Parent.GetInstanceId()} name:{node.Parent.Name} type:{node.Parent.GetType().FullName}");

			Nodes.Add(node);

			node._Ready();

			Instance.EmitSignal(StringNames.Instance["node_added"]);
		}
	}

	public void ProcessNodes(TimeSpan delta, List<Node> nodes = null)
	{
		// set nodes to root node list to start things off
		if (nodes == null)
		{
			nodes = GetNodeChildren(SceneTree.Instance.Root);
		}

		// recurssively process nodes in the scene tree
		foreach (Node node in nodes)
		{
			node._Process(delta.TotalMilliseconds / 1000);
			node._PhysicsProcess(delta.TotalMilliseconds / 1000);

			var children = GetNodeChildren(node);

			if (children.Count > 0)
			{
				ProcessNodes(delta, children);
			}
		}
	}

	public List<Node> GetNodeChildren(Node node)
	{
		List<Node> children = new();

		foreach (Node n in Nodes)
		{
			if (n.Parent == node)
			{
				children.Add(n);
			}
		}

		return children;

		// return Nodes.Where((x) => x.Parent == node).ToList();
	}
}

