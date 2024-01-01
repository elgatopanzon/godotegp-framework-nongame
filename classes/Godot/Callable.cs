/**
 * @author      : ElGatoPanzon (contact@elgatopanzon.io) Copyright (c) ElGatoPanzon
 * @file        : Callable
 * @created     : Saturday Dec 30, 2023 21:37:50 CST
 */

namespace Godot;

using GodotEGP.Logging;

public partial class Callable
{
	public Action<Variant> _actionVariant;
	public Action _action;
	public object _object;
	public string _method;

	public Callable()
	{
		
	}

	public Callable(Action action)
	{
		_action = action;
	}

	public Callable(Action<Variant> action)
	{
		_actionVariant = action;
	}

	public Callable(Object obj, string method)
	{
	}

	public void Call(Variant v = null)
	{
		if (_action != null)
		{
        	LoggerManager.LogDebug("Calling Action", "", "action", _action);

			_action();
		}
		else if (_actionVariant != null)
		{
        	LoggerManager.LogDebug("Calling Action<Variant>", "", "action", _actionVariant);

			_actionVariant(v);
		}
		else if (_object != null)
		{
			// Use reflection to get the Method
        	var type = _object.GetType();
        	var methodInfo = type.GetMethod(_method);

        	// Invoke the method here
        	if (methodInfo != null)
        	{
        		LoggerManager.LogDebug("Invoking method on object", "", "method", _method);

        		methodInfo.Invoke(_object, null);
        	}
        	else 
        	{
        		LoggerManager.LogError("Invalid method for object", "", "method", _method);
        	}
		}
		
	}

	public static Callable From(Action<Variant> action)
	{
		return new Callable(action);
	}

	public static Callable From(Action action)
	{
		return new Callable(action);
	}

}

