/**
 * @author      : ElGatoPanzon (contact@elgatopanzon.io) Copyright (c) ElGatoPanzon
 * @file        : Variant
 * @created     : Saturday Dec 30, 2023 21:16:11 CST
 */

namespace Godot;

public partial class Variant : GodotObject
{
	public Variant()
	{
		
	}

	public static implicit operator string(Variant stringname)
	{
		return (string) stringname;
	}

	public static implicit operator Variant(string stringname)
	{
		return (Variant) stringname;
	}
}

