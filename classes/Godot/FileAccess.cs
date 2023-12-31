/**
 * @author      : ElGatoPanzon (contact@elgatopanzon.io) Copyright (c) ElGatoPanzon
 * @file        : FileAccess
 * @created     : Saturday Dec 30, 2023 21:44:01 CST
 */

namespace Godot;

public partial class FileAccess
{
	public static class ModeFlags
	{
		public static int Read { get; set; }
	}

	public FileAccess()
	{
		
	}

	public static FileObject Open(string path, int mode)
	{
		return new FileObject();
	}
}

