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
	public SceneTreeServiceWorker()
	{
		_taskRunTimeoutSec = 0; // run every frame
	}

	public override void TaskRun()
	{
		SceneTree.Instance.ProcessNodes(_deltaTime);
	}
}

