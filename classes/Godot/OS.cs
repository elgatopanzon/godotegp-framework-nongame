/**
 * @author      : ElGatoPanzon (contact@elgatopanzon.io) Copyright (c) ElGatoPanzon
 * @file        : OS
 * @created     : Saturday Dec 30, 2023 21:20:19 CST
 */

namespace Godot;

public partial class OS
{
	public OS()
	{
		
	}

	public static bool IsDebugBuild()
	{
		return true; // TODO: make this better
	}

	public static string GetUserDataDir()
	{
		return "";
	}
}

