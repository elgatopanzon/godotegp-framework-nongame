/**
 * @author      : ElGatoPanzon (contact@elgatopanzon.io) Copyright (c) ElGatoPanzon
 * @file        : GD
 * @created     : Saturday Dec 30, 2023 21:22:20 CST
 */

namespace Godot;

using System;

public partial class GD
{
	public GD()
	{
		
	}

	public static void Print(object text)
	{
		Console.WriteLine(text);
	}

	public static void PrintRich(object text)
	{
		Console.WriteLine(text);
	}

	public static Resource Load(string path)
	{
		return new Resource(); // TODO: implement
	}

	public static T Load<T>(string path) where T : Resource
	{
		return (T) new Resource(); // TODO: implement
	}
}

