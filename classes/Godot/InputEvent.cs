/**
 * @author      : ElGatoPanzon (contact@elgatopanzon.io) Copyright (c) ElGatoPanzon
 * @file        : InputEvent
 * @created     : Saturday Dec 30, 2023 20:31:26 CST
 */

namespace Godot;

public partial class InputEvent
{
	public int Device { get; set; }
	public float AxisValue { get; set; }

	public bool Pressed { get; set; }
	public bool MetaPressed { get; set; }
	public bool ShiftPressed { get; set; }
	public bool CtrlPressed { get; set; }
	public bool AltPressed { get; set; }

	public InputEvent()
	{
		
	}
}

