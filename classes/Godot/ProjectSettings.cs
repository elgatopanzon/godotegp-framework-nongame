/**
 * @author      : ElGatoPanzon (contact@elgatopanzon.io) Copyright (c) ElGatoPanzon
 * @file        : ProjectSettings
 * @created     : Saturday Dec 30, 2023 21:44:27 CST
 */

namespace Godot;

public partial class ProjectSettings
{
	public ProjectSettings()
	{
		
	}

	public static string GlobalizePath(string path)
	{
		// res:// path points to executable path/project root
		if (path.StartsWith("res://"))
		{
			return Path.Combine(OS.GetExecutablePath(), path.Replace("res://", ""));
		}
		else if (path.StartsWith("user://"))
		{
			return Path.Combine(OS.GetUserDataDir(), path.Replace("user://", ""));
		}
		else
		{
			return path;
		}
	}
}

