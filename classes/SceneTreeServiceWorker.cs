/**
 * @author      : ElGatoPanzon (contact@elgatopanzon.io) Copyright (c) ElGatoPanzon
 * @file        : SceneTreeServiceWorker
 * @created     : Sunday Dec 31, 2023 02:57:59 CST
 */

namespace GodotEGPNonGame.ServiceWorkers;

using Godot;
using GodotEGP.Objects.Extensions;
using GodotEGP.Logging;
using GodotEGP.Service;
using GodotEGP.Event.Events;
using GodotEGP.Config;

using System.Collections.Generic;

public partial class SceneTreeServiceWorker : FrameBasedServiceWorker
{
	public static List<Node> Nodes = new();

	public SceneTreeServiceWorker()
	{
		_taskRunTimeoutSec = 0; // run every frame
	}

	public static void AddChild(Node node)
	{
		LoggerManager.LogDebug("Adding node to fake scene tree", "", "nodeType", node.GetType().FullName);

		Nodes.Add(node);
		node._Ready();
	}

	public override void TaskRun()
	{
		foreach (var node in Nodes)
		{
			node._Process(_deltaTime.TotalMilliseconds / 1000);
			node._PhysicsProcess(_deltaTime.TotalMilliseconds / 1000);
		}
	}
}

