/**
 * @author      : ElGatoPanzon (contact@elgatopanzon.io) Copyright (c) ElGatoPanzon
 * @file        : Callable
 * @created     : Saturday Dec 30, 2023 21:37:50 CST
 */

namespace Godot;

public partial class Callable
{
	public Callable()
	{
		
	}

	public Callable(Object obj, string method)
	{
	}

	public static Callable From(Action<Variant> action)
	{
		return new Callable(); // TODO: implement
	}

	public static Callable From(Action action)
	{
		return new Callable(); // TODO: implement
	}

}

