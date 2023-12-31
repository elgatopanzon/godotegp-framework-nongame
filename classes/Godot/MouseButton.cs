/**
 * @author      : ElGatoPanzon (contact@elgatopanzon.io) Copyright (c) ElGatoPanzon
 * @file        : MouseButton
 * @created     : Saturday Dec 30, 2023 20:53:24 CST
 */

namespace Godot;

public partial class MouseButton
{
	public static MouseButton Left { get; set; }
	public static MouseButton Right { get; set; }
	public static MouseButton Middle { get; set; }
	public static MouseButton WheelUp { get; set; }
	public static MouseButton WheelDown { get; set; }
	public static MouseButton WheelLeft { get; set; }
	public static MouseButton WheelRight { get; set; }

	public static MouseButton None { get; set; }

	public MouseButton()
	{
		
	}
}

