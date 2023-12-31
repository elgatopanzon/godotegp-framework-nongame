/**
 * @author      : ElGatoPanzon (contact@elgatopanzon.io) Copyright (c) ElGatoPanzon
 * @file        : Input
 * @created     : Saturday Dec 30, 2023 20:29:44 CST
 */

namespace Godot;

public partial class Input
{
	public Input()
	{
		
	}

	public static Godot.Collections.Array<int> GetConnectedJoypads()
	{
		return new Godot.Collections.Array<int>() {};
	}

	public static bool IsAnythingPressed()
	{
		return false;
	}

	public static bool IsActionPressed(StringName action)
	{
		return false;
	}

	public static bool IsActionJustPressed(StringName action)
	{
		return false;
	}

	public static bool IsActionJustReleased(StringName action)
	{
		return false;
	}

	public static string GetJoyName(int id)
	{
		return "";
	}

	public static string GetJoyGuid(int id)
	{
		return "";
	}

	public static float GetJoyAxis(int id, JoyAxis axis)
	{
		return 0;
	}

	public static float GetAxis(StringName actionX, StringName actionY)
	{
		return 0;
	}

	public static float GetActionStrength(StringName action, bool exact = false)
	{
		return 0;
	}

	public static bool IsMouseButtonPressed(MouseButton button)
	{
		return false;
	}

	public static bool IsJoyButtonPressed(int id, JoyButton button)
	{
		return false;
	}
}

