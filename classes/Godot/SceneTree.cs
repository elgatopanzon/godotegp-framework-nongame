/**
 * @author      : ElGatoPanzon (contact@elgatopanzon.io) Copyright (c) ElGatoPanzon
 * @file        : SceneTree
 * @created     : Saturday Dec 30, 2023 21:46:46 CST
 */

namespace Godot;

using GodotEGP.Logging;
using GodotEGP.Misc;

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
		_root = new Viewport();
	}

	public void AddNode(Node node)
	{
		if (!Nodes.Contains(node))
		{
			LoggerManager.LogDebug("Adding node to scene", "", "node", $"id:{node.GetInstanceId()} name:{node.Name} type:{node.GetType().FullName}");
			LoggerManager.LogDebug("", "", "nodeParent", $"id:{node.Parent.GetInstanceId()} name:{node.Parent.Name} type:{node.Parent.GetType().FullName}");

			Nodes.Add(node);

			Instance.EmitSignal(StringNames.Instance["node_added"]);

			node._Ready();
		}
	}

	public void ProcessNodes(TimeSpan delta, List<Node> nodes = null)
	{
		// set nodes to root node list to start things off
		if (nodes == null)
		{
			nodes = SceneTree.Instance.Root.GetChildren();

			// LoggerManager.LogDebug("Processing root nodes count", "", "nodeCount", nodes.Count);
		}

		// LoggerManager.LogDebug("Processing node set started", "", "nodeSet", nodes.GetHashCode());

		// recurssively process nodes in the scene tree
		foreach (Node node in nodes)
		{
			// LoggerManager.LogDebug("Processing node", "", "node", $"id:{node.GetInstanceId()} p_id:{node.Parent.GetInstanceId()} name:{node.Name} type:{node.GetType().FullName}");

			node._Process(delta.TotalMilliseconds / 1000);
			node._PhysicsProcess(delta.TotalMilliseconds / 1000);

			if (node.GetChildCount() > 0)
			{
				// LoggerManager.LogDebug("Processing node children", "", "node", $"id:{node.GetInstanceId()} p_id:{node.Parent.GetInstanceId()} name:{node.Name} type:{node.GetType().FullName}");

				ProcessNodes(delta, node.GetChildren());
			}
		}

		// LoggerManager.LogDebug("Processing node set finished", "", "nodeSet", nodes.GetHashCode());
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
	}
}

