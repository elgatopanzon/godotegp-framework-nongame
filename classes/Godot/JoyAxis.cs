/**
 * @author      : ElGatoPanzon (contact@elgatopanzon.io) Copyright (c) ElGatoPanzon
 * @file        : JoyAxis
 * @created     : Saturday Dec 30, 2023 20:43:01 CST
 */

namespace Godot;

public partial class JoyAxis
{
	public static JoyAxis LeftX { get; set; }
	public static JoyAxis LeftY { get; set; }
	public static JoyAxis RightX { get; set; }
	public static JoyAxis RightY { get; set; }
	public static JoyAxis TriggerLeft { get; set; }
	public static JoyAxis TriggerRight { get; set; }

	public static JoyAxis Invalid { get; set; }

	public JoyAxis()
	{
		
	}
}

