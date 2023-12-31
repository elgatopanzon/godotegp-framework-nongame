/**
 * @author      : ElGatoPanzon (contact@elgatopanzon.io) Copyright (c) ElGatoPanzon
 * @file        : InputMap
 * @created     : Saturday Dec 30, 2023 20:33:44 CST
 */

namespace Godot;

using System.Collections.Generic;

public partial class InputMap
{
	public InputMap()
	{
		
	}

	public static List<string> GetActions()
	{
		return new List<string>() {};
	}

	public static void EraseAction(StringName action)
	{
		
	}

	public static List<InputEvent> ActionGetEvents(StringName action)
	{
		return new List<InputEvent>() {};
	}

	public static void ActionEraseEvent(StringName action, InputEvent @event)
	{
		
	}

	public static void AddAction(StringName action, float deadzone = 0)
	{
		
	}

	public static void ActionAddEvent(StringName action, InputEvent @event)
	{
		
	}
}

