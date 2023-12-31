/**
 * @author      : ElGatoPanzon (contact@elgatopanzon.io) Copyright (c) ElGatoPanzon
 * @file        : InputEventJoypadMotion
 * @created     : Saturday Dec 30, 2023 20:46:06 CST
 */

namespace Godot;

public partial class InputEventJoypadMotion : InputEvent
{
	public JoyAxis Axis { get; set; }
	public InputEventJoypadMotion()
	{
		
	}
}

