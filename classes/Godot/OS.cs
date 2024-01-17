/**
 * @author      : ElGatoPanzon (contact@elgatopanzon.io) Copyright (c) ElGatoPanzon
 * @file        : OS
 * @created     : Saturday Dec 30, 2023 21:20:19 CST
 */

namespace Godot;

using System.IO;

public partial class OS
{
	public OS()
	{
		
	}

	public static bool IsDebugBuild()
	{
#if DEBUG
		return true;
#else
		return false;
#endif
	}

	public static string GetUserDataDir()
	{
		string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), System.Reflection.Assembly.GetEntryAssembly().GetName().Name+"_Data");

		// create the local directory for the project if it doesn't exist
		bool exists = System.IO.Directory.Exists(path);

		if(!exists)
    		System.IO.Directory.CreateDirectory(path);

		return path;
	}

	public static string GetExecutablePath()
	{
#if DEBUG
		return Path.Combine(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName);
#else
		return Path.Combine(Directory.GetParent(new FileInfo(System.Reflection.Assembly.GetExecutingAssembly().Location).Directory.FullName).Parent.FullName);
#endif
	}
}

