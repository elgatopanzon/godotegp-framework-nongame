/**
 * @author      : ElGatoPanzon (contact@elgatopanzon.io) Copyright (c) ElGatoPanzon
 * @file        : GodotObject
 * @created     : Saturday Dec 30, 2023 21:13:08 CST
 */

namespace Godot;

using GodotEGP;
using GodotEGP.Logging;
using GodotEGP.Misc;
using GodotEGP.Service;

public partial class GodotObject
{
	private List<SignalConnection> _connectedSignals = new();

	public GodotObject()
	{
		
	}

	public void Connect(StringName signal, Callable callable)
	{
		AddSignalConnection(callable, signal);
	}
	public void Connect(string signal, Callable callable)
	{
		AddSignalConnection(callable, StringNames.Instance[signal]);
	}

	public void EmitSignal(StringName signal, Variant v = null)
	{
		LoggerManager.LogDebug("Emitting signal", "", "signal", signal);

		if (v != null)
		{
			ServiceRegistry.Get<EventManager>().__On_Signal(this, signal, v);
		}
		else
		{
			ServiceRegistry.Get<EventManager>().__On_Signal(this, signal);
		}
	}

	public void AddSignalConnection(Callable callable, StringName signal)
	{
		_connectedSignals.Add(new SignalConnection(callable, signal));

		LoggerManager.LogDebug("Connecting signal", "", "signal", signal);
	}
}

public class SignalConnection
{
	public Callable _callable { get; set; }
	public StringName _signal { get; set; }

	public SignalConnection(Callable callable, StringName signal)
	{
		_callable = callable;
		_signal = signal;
	}

	public void Call()
	{
		_callable.Call();
	}
}
