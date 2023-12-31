/**
 * @author      : ElGatoPanzon (contact@elgatopanzon.io) Copyright (c) ElGatoPanzon
 * @file        : InputEventMouseButton
 * @created     : Saturday Dec 30, 2023 21:25:02 CST
 */

namespace Godot;

public partial class InputEventMouseButton : InputEvent
{
	public MouseButton ButtonIndex { get; set; }
	public bool DoubleClick { get; set; }

	public InputEventMouseButton()
	{
		
	}
}

