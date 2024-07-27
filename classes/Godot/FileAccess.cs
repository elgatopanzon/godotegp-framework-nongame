/**
 * @author      : ElGatoPanzon (contact@elgatopanzon.io) Copyright (c) ElGatoPanzon
 * @file        : FileAccess
 * @created     : Wednesday Jul 10, 2024 23:05:38 CST
 */

namespace Godot;

using System;

public partial class FileAccess
{
	public static bool FileExists(string path)
	{
		return File.Exists(path);
	}
}

