/**
 * @author      : ElGatoPanzon (contact@elgatopanzon.io) Copyright (c) ElGatoPanzon
 * @file        : Node
 * @created     : Saturday Dec 30, 2023 20:24:59 CST
 */

namespace Godot;

using GodotEGP;
using GodotEGP.Logging;

public partial class Node : GodotObject
{
	public string Name { get; set; }

	public string SceneFilePath { get; set; }

	public bool Visible { get; set; }

	public Node()
	{
		Name = "";
		SceneFilePath = "";
	}

	public Viewport GetViewport()
	{
		return new Viewport();
	}

	public virtual void _Ready()
	{

	}

	public virtual void _Process(double delta)
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

	public void AddChild(Node node)
	{
		LoggerManager.LogDebug("TODO: implement AddChild with fake Node mainloop");
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
		// TODO: implement this
	}

	public List<Node> GetChildren()
	{
		return new List<Node>() {}; // TODO: implement
	}

	public string GetPath()
	{
		return ""; // TODO: implement
	}

	public List<string> GetGroups()
	{
		return new List<string>() {}; // TODO: implement
	}

	public SceneTree GetTree()
	{
		return new SceneTree();
	}
}

