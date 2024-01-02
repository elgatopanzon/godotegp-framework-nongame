/**
 * @author      : ElGatoPanzon (contact@elgatopanzon.io) Copyright (c) ElGatoPanzon
 * @file        : ExtensionMethods
 * @created     : Saturday Dec 30, 2023 22:29:33 CST
 */

namespace Godot;

using GodotEGP.Logging;

public static partial class ExtensionMethods
{
	public static string GetFile(this string path)
	{
		return Path.GetFileName(path);
	}
}

