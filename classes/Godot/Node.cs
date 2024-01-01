/**
 * @author      : ElGatoPanzon (contact@elgatopanzon.io) Copyright (c) ElGatoPanzon
 * @file        : Node
 * @created     : Saturday Dec 30, 2023 20:24:59 CST
 */

namespace Godot;

using GodotEGP;
using GodotEGP.Logging;

using GodotEGPNonGame.ServiceWorkers;

public partial class Node : GodotObject
{
	public string Name { get; set; }
	public Node Parent { get; set; }

	public int Id
	{
		get { return GetHashCode(); }
	}

	public string SceneFilePath { get; set; }

	public bool Visible { get; set; }

	public Node()
	{
		Name = "";
		SceneFilePath = "";
	}

	public string GetInstanceId()
	{
		return Id.ToString();
	}

	public Viewport GetViewport()
	{
		return SceneTree.Instance.Root;
	}

	public SceneTree GetTree()
	{
		return SceneTree.Instance;
	}

	public void AddChild(Node node)
	{
		// set self as the parent node
		node.Parent = this;

		// add the node to the SceneTree
		SceneTree.Instance.AddNode(node);
	}

	public List<Node> GetChildren()
	{
		return SceneTree.Instance.GetNodeChildren(this);
	}

	public int GetChildCount()
	{
		return GetChildren().Count;
	}

	public virtual void _Ready()
	{

	}

	public virtual void _Process(double delta)
	{
		
	}

	public virtual void _PhysicsProcess(double delta)
	{
		
	}

	public virtual void _UnhandledInput(InputEvent @event)
	{
		
	}

	public void QueueFree()
	{
		
	}

	public bool IsQueuedForDeletion()
	{
		return false;
	}

	public void SetMeta(string id, string value)
	{
		
	}

	public bool HasMeta(string id)
	{
		return false;
	}

	public string GetMeta(string id)
	{
		return "";
	}

	public void CallDeferred(string methodName)
	{
		var callable = new Callable(this, methodName);
		callable.Call();
	}

	public string GetPath()
	{
		return ""; // TODO: implement
	}

	public List<string> GetGroups()
	{
		return new List<string>() {}; // TODO: implement
	}

}

