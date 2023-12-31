/**
 * @author      : ElGatoPanzon (contact@elgatopanzon.io) Copyright (c) ElGatoPanzon
 * @file        : InputEventKey
 * @created     : Saturday Dec 30, 2023 22:03:14 CST
 */

namespace Godot;

public partial class InputEventKey : InputEvent
{
	public Key Keycode { get; set; }
	public bool Echo { get; set; }

	public InputEventKey()
	{
		
	}
}

