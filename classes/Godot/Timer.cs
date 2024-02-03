/**
 * @author      : ElGatoPanzon (contact@elgatopanzon.io) Copyright (c) ElGatoPanzon
 * @file        : Timer
 * @created     : Saturday Dec 30, 2023 21:28:40 CST
 */

namespace Godot;

using GodotEGP.Logging;
using GodotEGP.Misc;

public partial class Timer : Node
{
	public bool OneShot { get; set; }
	public float WaitTime { get; set; }
	public float TimeLeft { get; set; }
	public bool Autostart { get; set; }

	private bool _running { get; set; }
	private bool _ready { get; set; }

	public Timer()
	{
		OneShot = false;
		WaitTime = 0;
		TimeLeft = 0;
		Autostart = false;

		_running = false;
	}

	public bool IsStopped()
	{
		return _running == false;
	}

	public void Start(float waitTime = -1)
	{
		if (waitTime > 0)
		{
			WaitTime = waitTime;

			Stop();
			Start();
		}

		TimeLeft = WaitTime;
		_running = true;
	}

	public void Stop()
	{
		TimeLeft = 0;
	}

	private void Finished()
	{
		Stop();
		_running = false;

		EmitSignal(StringNames.Instance["timeout"]);

		if (!OneShot)
		{
			Start();
		}
	}

	public override void _Process(double delta)
	{
		// only process if in the scene
		if (_ready && _running)
		{
			TimeLeft -= (float) delta;

			if (TimeLeft <= 0)
			{
				Finished();
			}
		}
	}

	public override void _Ready()
	{
		_ready = true;

		if (Autostart)
		{
			Start();
		}
	}
}

